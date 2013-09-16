//! \file IosGraphViewImpl.h
//! \brief 定义iOS绘图视图类的内部实现接口
// Copyright (c) 2012-2013, https://github.com/rhcad/touchvg

#import "IosGraphView.h"
#include "IosCanvasAdapter.h"
#include "gicoreview.h"
#include <vector>

class IosViewAdapter;

//! 动态图形的绘图视图类
@interface IosTempView : UIView {
    IosViewAdapter   *_adapter;
}

- (id)initView:(CGRect)frame :(IosViewAdapter *)adapter;

@end

//! 绘图视图适配器
class IosViewAdapter : public GiView
{
private:
    UIView      *_view;         //!< 静态图形视图, IosGraphView
    UIView      *_dynview;      //!< 动态图形视图, IosTempView
    GiCoreView  *_coreView;     //!< 内核视图分发器
    UIImage     *_tmpshot;      //!< 用于增量绘图的临时快照
    long        _drawCount;     //!< 用于增量绘图的计数
    
public:
    
    IosViewAdapter(UIView *mainView, GiCoreView *coreView);
    virtual ~IosViewAdapter();
    
    GiCoreView *coreView() { return _coreView; }
    UIImage *snapshot(bool autoDraw);
    bool drawAppend(GiCanvas* canvas);
    void clearCachedData();
    
    virtual void regenAll();
    virtual void regenAppend();
    virtual void redraw();
    virtual bool isContextActionsVisible();
    virtual bool showContextActions(const mgvector<int>& actions,
                                    float x, float y, float w, float h);
    virtual void commandChanged();
    virtual void selectionChanged();
    
    bool dispatchGesture(GiGestureType gestureType, GiGestureState gestureState, CGPoint pt);
    bool dispatchPan(GiGestureState gestureState, CGPoint pt, bool switchGesture = false);
    bool twoFingersMove(UIGestureRecognizer *sender, int state = -1, bool switchGesture = false);
};

@interface IosGraphView()<UIGestureRecognizerDelegate> {
    IosViewAdapter   *_adapter;              //!< 视图回调适配器
    
    UIPanGestureRecognizer *_panRecognizer;             //!< 拖动手势识别器
    UITapGestureRecognizer *_tapRecognizer;             //!< 单指点击手势识别器
    UITapGestureRecognizer *_twoTapsRecognizer;         //!< 单指双击手势识别器
    UILongPressGestureRecognizer *_pressRecognizer;     //!< 单指长按手势识别器
    UIPinchGestureRecognizer *_pinchRecognizer;         //!< 双指放缩手势识别器
    UIRotationGestureRecognizer *_rotationRecognizer;   //!< 双指旋转手势识别器
    
    std::vector<CGPoint>    _points;        //!< 手势生效前的轨迹
    CGPoint                 _startPt;       //!< 开始位置
    CGPoint                 _lastPt;        //!< 上次位置
    CGPoint                 _tapPoint;      //!< 点击位置
    int                     _tapCount;      //!< 点击次数
    int                     _touchCount;    //!< 触点个数
    BOOL            _gestureRecognized;     //!< 识别出手势
}

- (void)activiteView;                       //!< 设置为当前活动视图

@end

@interface IosGraphView(GestureRecognizer)

- (void)setupGestureRecognizers;
- (BOOL)panHandler:(UIGestureRecognizer *)sender;
- (BOOL)tapHandler:(UITapGestureRecognizer *)sender;
- (BOOL)twoTapsHandler:(UITapGestureRecognizer *)sender;
- (BOOL)pressHandler:(UILongPressGestureRecognizer *)sender;
- (void)delayTap;
- (void)dispatchTapPending;

@end
