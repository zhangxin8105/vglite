//! \file PaintView.java
//! \brief Android绘图视图类
// Copyright (c) 2012-2013, https://github.com/rhcad/vglite

package touchvg.view;

import touchvg.jni.GiCoreView;
import touchvg.jni.GiView;
import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.PixelFormat;
import android.graphics.PorterDuff.Mode;
import android.os.SystemClock;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
import android.view.View;

//! Android绘图视图类
/*! \ingroup GROUP_ANDROID
 */
public class GraphSurfaceView extends SurfaceView {
    private CanvasAdapter mCanvasAdapter;
    private ViewAdapter mViewAdapter;
    private GiCoreView mCoreView;
    private DynDrawView mDynDrawView;
    private long mDrawnTime;
    private long mEndPaintTime;

    public GraphSurfaceView(Context context) {
        super(context);
        mCanvasAdapter = new CanvasAdapter(this);
        mViewAdapter = new ViewAdapter();
        mCoreView = new GiCoreView();
        
        getHolder().addCallback(new SurfaceCallback());
        setZOrderOnTop(true);
        getHolder().setFormat(PixelFormat.TRANSPARENT);
        
        this.setOnTouchListener(new OnTouchListener() {
            public boolean onTouch(View v, MotionEvent event) {
                if (event.getAction() == MotionEvent.ACTION_UP) {
                    mViewAdapter.regen();
                }
                else if ((mDynDrawView != null && !mDynDrawView.isDrawing()
                        && event.getEventTime() > mDynDrawView.getEndPaintTime())
                        || (mDynDrawView == null && !isDrawing()
                        && event.getEventTime() > mEndPaintTime)) {
                    mCoreView.onTouch(mViewAdapter, event.getX(), event.getY());
                }
                return true;
            }
        });
    }
    
    public GiCoreView getCoreView() {
        return mCoreView;
    }
    
    public void setDynDrawView(DynDrawView view) {
        mDynDrawView = view;
        if (mDynDrawView != null) {
            mDynDrawView.setCoreView(mCoreView);
        }
    }
    
    public long getDrawnTime() {
        return mDrawnTime;
    }
    
    public boolean isDrawing() {
        return mCanvasAdapter != null && mCanvasAdapter.isDrawing();
    }

    @Override
    protected void onDraw(Canvas canvas) {
        if (mCanvasAdapter.beginPaint(canvas)) {
            if (this.getBackground() == null) {
                canvas.drawColor(Color.TRANSPARENT, Mode.CLEAR);
            }
            mCoreView.draw(mCanvasAdapter);
            if (mDynDrawView == null) {
                mCoreView.dyndraw(mCanvasAdapter);
            }
            mCanvasAdapter.endPaint();
        }
    }

    @Override
    protected void onDetachedFromWindow() {
        if (mDynDrawView != null) {
            mDynDrawView.setCoreView(null);
            mDynDrawView = null;
        }
        if (mViewAdapter != null) {
            mViewAdapter.delete();
            mViewAdapter = null;
        }
        if (mCoreView != null) {
            mCoreView.delete();
            mCoreView = null;
        }
        if (mCanvasAdapter != null) {
            mCanvasAdapter.delete();
            mCanvasAdapter = null;
        }
        super.onDetachedFromWindow();
    }
    
    private void doDraw() {
        if (!mCanvasAdapter.isDrawing()) {
            new Thread(new DrawThread()).start();
        }
    }
    
    private class SurfaceCallback implements SurfaceHolder.Callback {
        public void surfaceCreated(SurfaceHolder holder) {
            doDraw();
        }

        public void surfaceChanged(SurfaceHolder holder, int format, int width, int height) {
        }

        public void surfaceDestroyed(SurfaceHolder holder) {
        }
    }
    
    private class DrawThread implements Runnable {
        public void run() {
            long ms = SystemClock.currentThreadTimeMillis();
            Canvas canvas = null;
            try {
                canvas = getHolder().lockCanvas();
                if (canvas != null) {
                    draw(canvas);
                }
            } catch (Exception e) {
                e.printStackTrace();
            } finally {
                if (canvas != null) {
                    getHolder().unlockCanvasAndPost(canvas);
                }
            }
            mDrawnTime = SystemClock.currentThreadTimeMillis() - ms;
            mEndPaintTime = android.os.SystemClock.uptimeMillis();
        }
    }
    
    private class ViewAdapter extends GiView {
        @Override
        public void regen() {
            doDraw();
            if (mDynDrawView != null) {
                mDynDrawView.doDraw();
            }
        }
        
        @Override
        public void redraw() {
            if (mDynDrawView != null) {
                mDynDrawView.doDraw();
            }
            else {
                doDraw();
            }
        }
    }
}
