//! \file GiGraphView.mm
//! \brief 实现iOS绘图视图类 GiGraphView
// Copyright (c) 2012-2013, https://github.com/rhcad/vglite

#import "GiGraphView.h"
#import <QuartzCore/CALayer.h>
#include "GiQuartzCanvas.h"
#include "giview.h"
#include "gicoreview.h"

//! 动态图形的绘图视图类
@interface DynDrawView : UIView {
    GiCoreView  *_coreView;
}
@end

@implementation DynDrawView

- (id)initWithFrame:(CGRect)frame :(GiCoreView *)coreView
{
    self = [super initWithFrame:frame];
    if (self) {
        _coreView = coreView;
        self.opaque = NO;                           // 透明背景
        self.userInteractionEnabled = NO;           // 禁止交互，避免影响主视图显示
    }
    return self;
}

- (void)drawRect:(CGRect)rect
{
    GiQuartzCanvas canvas;
    
    if (canvas.beginPaint(UIGraphicsGetCurrentContext())) {
        _coreView->dynDraw(canvas);
        canvas.endPaint();
    }
}

@end

//! 绘图视图适配器
class GiViewAdapter : public GiView
{
private:
    UIView      *_view;
    UIView      *_dynview;
    GiCoreView  *_coreView;
    UIImage     *_tmpshot;
    
public:
    GiViewAdapter(UIView *mainView, int viewType) : _view(mainView), _dynview(nil), _tmpshot(nil) {
        _coreView = GiCoreView::createView(viewType);
    }
    
    virtual ~GiViewAdapter() {
        if (_coreView) {
            delete _coreView;
            _coreView = NULL;
        }
        [_tmpshot release];
    }
    
    GiCoreView *coreView() {
        return _coreView;
    }
    
    UIImage *snapshot() {
        UIGraphicsBeginImageContextWithOptions(_view.bounds.size, _view.opaque, 0);
        [_view.layer renderInContext:UIGraphicsGetCurrentContext()];
        UIImage *image = UIGraphicsGetImageFromCurrentImageContext();
        UIGraphicsEndImageContext();
        return image;
    }
    
    bool drawAppend(GiQuartzCanvas &canvas) {
        if (_tmpshot) {
            [_tmpshot drawAtPoint:CGPointZero];
            [_tmpshot release];
            _tmpshot = nil;
            return _coreView->drawAppend(canvas);
        }
        return false;
    }
    
    virtual void regenAll() {
        [_view setNeedsDisplay];
        [_dynview setNeedsDisplay];
    }
    
    virtual void regenAppend() {
        [_tmpshot release];
        _tmpshot = nil;                 // renderInContext可能会调用drawRect
        _tmpshot = snapshot();
        [_tmpshot retain];
        
        [_view setNeedsDisplay];
        [_dynview setNeedsDisplay];
    }
    
    virtual void redraw() {
        if (!_dynview && _view) {       // 自动创建动态图形视图
            _dynview = [[DynDrawView alloc]initWithFrame:_view.frame :_coreView];
            _dynview.autoresizingMask = _view.autoresizingMask;
            [_view.superview addSubview:_dynview];
            [_dynview release];
        }
        [_dynview setNeedsDisplay];
    }
};

@implementation GiGraphView

- (void)dealloc
{
    delete _viewAdapter;
    [super dealloc];
}

- (id)initWithFrame:(CGRect)frame
{
    self = [super initWithFrame:frame];
    if (self) {
        self.opaque = NO;                           // 透明背景
        self.autoresizingMask = 0xFF;               // 自动适应大小
        _viewAdapter = new GiViewAdapter(self, 1);
        
        GiCoreView::setScreenDpi(GiQuartzCanvas::getScreenDpi());
        [self coreView]->onSize(*_viewAdapter, frame.size.width, frame.size.height);
    }
    return self;
}

- (void)drawRect:(CGRect)rect
{
    CGContextRef context = UIGraphicsGetCurrentContext();
    GiQuartzCanvas canvas;
    
    [self coreView]->onSize(*_viewAdapter, self.bounds.size.width, self.bounds.size.height);
    
    if (canvas.beginPaint(context)) {
        if (!_viewAdapter->drawAppend(canvas)) {
            [self coreView]->drawAll(canvas);
        }
        canvas.endPaint();
    }
}

- (GiCoreView *)coreView
{
    return _viewAdapter->coreView();
}

- (UIImage *)snapshot
{
    return _viewAdapter->snapshot();
}

- (BOOL)savePng:(NSString *)filename
{
    BOOL ret = NO;
    UIImage *image = [self snapshot];
    NSData* imageData = UIImagePNGRepresentation(image);
    
    if (imageData) {
        ret = [imageData writeToFile:filename atomically:NO];                 
    }
    
    return ret;
}

- (void)touchesBegan:(NSSet *)touches withEvent:(UIEvent *)event
{
    [super touchesMoved:touches withEvent:event];
    
    UITouch *touch = [touches anyObject];
    CGPoint pt = [touch locationInView:touch.view];
    
    [self coreView]->onGesture(*_viewAdapter, kGiGesturePan,
                               kGiGestureBegan, pt.x, pt.y);
}

- (void)touchesMoved:(NSSet *)touches withEvent:(UIEvent *)event
{
    [super touchesMoved:touches withEvent:event];
    
    UITouch *touch = [touches anyObject];
    CGPoint pt = [touch locationInView:touch.view];
    
    [self coreView]->onGesture(*_viewAdapter, kGiGesturePan,
                               kGiGestureMoved, pt.x, pt.y);
}

- (void)touchesEnded:(NSSet *)touches withEvent:(UIEvent *)event
{
    [super touchesMoved:touches withEvent:event];
    
    UITouch *touch = [touches anyObject];
    CGPoint pt = [touch locationInView:touch.view];
    
    [self coreView]->onGesture(*_viewAdapter, kGiGesturePan,
                               kGiGestureEnded, pt.x, pt.y);
}

@end

@implementation GiMagnifierView

- (void)dealloc
{
    delete _viewAdapter;
    [super dealloc];
}

- (id)initWithFrame:(CGRect)frame
{
    self = [super initWithFrame:frame];
    if (self) {
        self.opaque = NO;                           // 透明背景
        _viewAdapter = new GiViewAdapter(self, 2);
    }
    return self;
}

- (void)drawRect:(CGRect)rect
{
    GiCoreView *coreView = _viewAdapter->coreView();
    CGContextRef context = UIGraphicsGetCurrentContext();
    GiQuartzCanvas canvas;
        
    coreView->onSize(*_viewAdapter, self.bounds.size.width, self.bounds.size.height);
    
    if (canvas.beginPaint(context)) {
        if (!_viewAdapter->drawAppend(canvas)) {
            coreView->drawAll(canvas);
        }
        canvas.endPaint();
    }
}

@end
