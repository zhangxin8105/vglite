//! \file TestDoubleViews.java
//! \brief 测试双视图布局的测试视图类
// Copyright (c) 2012-2013, https://github.com/rhcad/vglite

package vgdemo.testview.view;

import touchvg.view.DynDrawStdView;
import touchvg.view.DynDrawSurfaceView;
import touchvg.view.GraphSurfaceView;
import touchvg.view.GraphView;
import android.app.Activity;
import android.content.Context;
import android.graphics.Color;
import android.view.View;
import android.widget.FrameLayout;

//! 测试双视图布局的测试视图类
public class TestDoubleViews extends FrameLayout {

    public TestDoubleViews(Context context) {
        super(context);
        
        int flags = ((Activity) context).getIntent().getExtras().getInt("flags");
        final LayoutParams params = new LayoutParams(LayoutParams.MATCH_PARENT, LayoutParams.MATCH_PARENT);
        
        if ((flags & 0x01) == 0) {      // 主视图使用普通View
            final GraphView view = new GraphView(context);
            addView(view, params);
            
            if ((flags & 0x02) != 0) {  // 动态视图使用普通View
                final DynDrawStdView dynview = new DynDrawStdView(context);
                view.setDynDrawView(dynview);
                addView(dynview, params);
            }
            if ((flags & 0x04) != 0) {  // 动态视图使用SurfaceView
                final DynDrawSurfaceView dynview = new DynDrawSurfaceView(context);
                view.setDynDrawView(dynview);
                addView(dynview, params);
            }
        }
        else {                          // 主视图使用SurfaceView
            final GraphSurfaceView view = new GraphSurfaceView(context);
            
            if ((flags & 0x100000) == 0) {  // 不是底部视图
                view.setBackgroundColor(Color.TRANSPARENT);
            }
            addView(view, params);
            
            if ((flags & 0x02) != 0) {  // 动态视图使用普通View
                final DynDrawStdView dynview = new DynDrawStdView(context);
                view.setDynDrawView(dynview);
                addView(dynview, params);
            }
            if ((flags & 0x04) != 0) {  // 动态视图使用SurfaceView
                final DynDrawSurfaceView dynview = new DynDrawSurfaceView(context);
                view.setDynDrawView(dynview);
                addView(dynview, params);
            }
        }
        
        final View midview = new View(context);
        midview.setBackgroundColor(Color.YELLOW);
        addView(midview, new LayoutParams(40, 40));
    }

}
