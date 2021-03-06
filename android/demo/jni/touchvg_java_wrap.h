/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_touchvg_WRAP_H_
#define SWIG_touchvg_WRAP_H_

class SwigDirector_GiCanvas : public GiCanvas, public Swig::Director {

public:
    void swig_connect_director(JNIEnv *jenv, jobject jself, jclass jcls, bool swig_mem_own, bool weak_global);
    SwigDirector_GiCanvas(JNIEnv *jenv);
    virtual ~SwigDirector_GiCanvas();
    virtual void setPen(int argb, float width, int style, float phase);
    virtual void setBrush(int argb, int style);
    virtual void clearRect(float x, float y, float w, float h);
    virtual void drawRect(float x, float y, float w, float h, bool stroke, bool fill);
    virtual void drawLine(float x1, float y1, float x2, float y2);
    virtual void drawEllipse(float x, float y, float w, float h, bool stroke, bool fill);
    virtual void beginPath();
    virtual void moveTo(float x, float y);
    virtual void lineTo(float x, float y);
    virtual void bezierTo(float c1x, float c1y, float c2x, float c2y, float x, float y);
    virtual void quadTo(float cpx, float cpy, float x, float y);
    virtual void closePath();
    virtual void drawPath(bool stroke, bool fill);
    virtual void saveClip();
    virtual void restoreClip();
    virtual bool clipRect(float x, float y, float w, float h);
    virtual bool clipPath();
    virtual void drawHandle(float x, float y, int type);
    virtual void drawBitmap(char const *name, float xc, float yc, float w, float h, float angle);
    virtual float drawTextAt(char const *text, float x, float y, float h, int align);
public:
    bool swig_overrides(int n) {
      return (n < 20 ? swig_override[n] : false);
    }
protected:
    bool swig_override[20];
};

class SwigDirector_GiView : public GiView, public Swig::Director {

public:
    void swig_connect_director(JNIEnv *jenv, jobject jself, jclass jcls, bool swig_mem_own, bool weak_global);
    SwigDirector_GiView(JNIEnv *jenv);
    virtual ~SwigDirector_GiView();
    virtual void regenAll();
    virtual void regenAppend();
    virtual void redraw();
    virtual bool useFinger();
    virtual bool isContextActionsVisible();
    virtual bool showContextActions(mgvector< int > const &actions, mgvector< float > const &buttonXY, float x, float y, float w, float h);
    virtual void commandChanged();
    virtual void selectionChanged();
    virtual void contentChanged();
public:
    bool swig_overrides(int n) {
      return (n < 9 ? swig_override[n] : false);
    }
protected:
    bool swig_override[9];
};


#endif
