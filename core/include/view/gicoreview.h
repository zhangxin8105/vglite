//! \file gicoreview.h
//! \brief 定义内核视图分发器类 GiCoreView
// Copyright (c) 2012-2013, https://github.com/rhcad/touchvg

#ifndef TOUCHVG_CORE_VIEWDISPATCHER_H
#define TOUCHVG_CORE_VIEWDISPATCHER_H

#include "gigesture.h"

class GiView;
class GiCanvas;
class GiCoreViewImpl;
struct MgStorage;

//! 内核视图分发器类
/*! 本对象拥有图形文档对象，负责显示和手势动作的分发。
    \ingroup CORE_VIEW
 */
class GiCoreView
{
public:
    //! 构造函数，传入NULL构造主视图，传入主视图构造辅助视图
    GiCoreView(GiCoreView* mainView);
    
    //! 析构函数
    ~GiCoreView();
    
    //! 创建内核视图
    void createView(GiView* view, int type = 1);
    
    //! 创建放大镜视图
    void createMagnifierView(GiView* newview, GiView* mainView);
    
    //! 销毁内核视图
    void destoryView(GiView* view);
    
    //! 显示所有图形
    int drawAll(GiView* view, GiCanvas* canvas);

    //! 显示新图形，在 GiView.regenAppend() 后调用
    bool drawAppend(GiView* view, GiCanvas* canvas);
    
    //! 显示动态图形
    void dynDraw(GiView* view, GiCanvas* canvas);
    
    //! 设置背景颜色
    int setBkColor(GiView* view, int argb);

    //! 设置屏幕的点密度
    static void setScreenDpi(int dpi);
    
    //! 设置视图的宽高
    void onSize(GiView* view, int w, int h);
    
    //! 传递单指触摸手势消息
    bool onGesture(GiView* view, GiGestureType gestureType,
            GiGestureState gestureState, float x, float y, bool switchGesture = false);

    //! 传递双指移动手势(可放缩旋转)
    bool twoFingersMove(GiView* view, GiGestureState gestureState,
            float x1, float y1, float x2, float y2, bool switchGesture = false);
    
    //! 返回当前命令名称
    const char* command() const;
    
    //! 启动命令
    bool setCommand(GiView* view, const char* name);
    
    //! 释放临时数据内存
    void clearCachedData();
    
    //! 添加测试图形
    int addShapesForTest();
    
    //! 返回图形总数
    int getShapeCount();

    //! 从JSON文件中加载图形
    bool loadFromFile(const char* vgfile);
    
    //! 保存图形到JSON文件
    bool saveToFile(const char* vgfile, bool pretty = true);

    //! 得到图形的JSON内容，需要再调用 freeContent()
    const char* getContent();
    
    //! 释放 getContent() 产生的缓冲资源
    void freeContent();

    //! 从JSON内容中加载图形
    bool setContent(const char* content);

    //! 从指定的数据来源中加载图形
    bool loadShapes(MgStorage* s);
    
    //! 保存图形到指定的数据来源中
    bool saveShapes(MgStorage* s);
    
    //! 放缩显示全部内容
    bool zoomToExtent();

private:
    GiCoreViewImpl* impl;
};

#endif // TOUCHVG_CORE_VIEWDISPATCHER_H
