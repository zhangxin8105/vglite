// GraphView1.h
// Copyright (c) 2012-2013, https://github.com/rhcad/touchvg

#import <UIKit/UIKit.h>

class GiCanvasAdapter;

//! 测试绘图的视图类
@interface GraphView1 : UIView {
    GiCanvasAdapter  *_canvas;
    CGPoint         _lastpt;
    UIView          *_dynview;
    int             _flags;
    int             _drawTimes;
    
    float           _lineWidth;
    int             _lineStyle;
    bool            _useFill;
    bool            _antiAlias;
    float           _flatness;
    int             _testOrder;
}

- (id)initWithFrame:(CGRect)frame withFlags:(int)t;
- (void)save;
- (void)edit;
- (void)draw:(GiCanvasAdapter*)canvas;
- (void)dynDraw:(GiCanvasAdapter*)canvas;
- (void)showDrawnTime:(int)ms logging:(BOOL)log;

@end

//! 通过线程不断重绘的测试视图类
@interface GraphView2 : GraphView1 {
    NSThread    *_thread;
}
@end
