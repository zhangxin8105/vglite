/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.10
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class GiColor : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GiColor(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(GiColor obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~GiColor() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgcsPINVOKE.delete_GiColor(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public byte r {
    set {
      touchvgcsPINVOKE.GiColor_r_set(swigCPtr, value);
    } 
    get {
      byte ret = touchvgcsPINVOKE.GiColor_r_get(swigCPtr);
      return ret;
    } 
  }

  public byte g {
    set {
      touchvgcsPINVOKE.GiColor_g_set(swigCPtr, value);
    } 
    get {
      byte ret = touchvgcsPINVOKE.GiColor_g_get(swigCPtr);
      return ret;
    } 
  }

  public byte b {
    set {
      touchvgcsPINVOKE.GiColor_b_set(swigCPtr, value);
    } 
    get {
      byte ret = touchvgcsPINVOKE.GiColor_b_get(swigCPtr);
      return ret;
    } 
  }

  public byte a {
    set {
      touchvgcsPINVOKE.GiColor_a_set(swigCPtr, value);
    } 
    get {
      byte ret = touchvgcsPINVOKE.GiColor_a_get(swigCPtr);
      return ret;
    } 
  }

  public GiColor() : this(touchvgcsPINVOKE.new_GiColor__SWIG_0(), true) {
  }

  public GiColor(int _r, int _g, int _b, int _a) : this(touchvgcsPINVOKE.new_GiColor__SWIG_1(_r, _g, _b, _a), true) {
  }

  public GiColor(int _r, int _g, int _b) : this(touchvgcsPINVOKE.new_GiColor__SWIG_2(_r, _g, _b), true) {
  }

  public GiColor(GiColor c) : this(touchvgcsPINVOKE.new_GiColor__SWIG_3(GiColor.getCPtr(c)), true) {
    if (touchvgcsPINVOKE.SWIGPendingException.Pending) throw touchvgcsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GiColor(int rgb, bool alpha) : this(touchvgcsPINVOKE.new_GiColor__SWIG_4(rgb, alpha), true) {
  }

  public GiColor(int rgb) : this(touchvgcsPINVOKE.new_GiColor__SWIG_5(rgb), true) {
  }

  public static GiColor White() {
    GiColor ret = new GiColor(touchvgcsPINVOKE.GiColor_White(), true);
    return ret;
  }

  public static GiColor Black() {
    GiColor ret = new GiColor(touchvgcsPINVOKE.GiColor_Black(), true);
    return ret;
  }

  public static GiColor Invalid() {
    GiColor ret = new GiColor(touchvgcsPINVOKE.GiColor_Invalid(), true);
    return ret;
  }

  public int getARGB() {
    int ret = touchvgcsPINVOKE.GiColor_getARGB(swigCPtr);
    return ret;
  }

  public void setARGB(int value) {
    touchvgcsPINVOKE.GiColor_setARGB(swigCPtr, value);
  }

  public void set(int _r, int _g, int _b) {
    touchvgcsPINVOKE.GiColor_set__SWIG_0(swigCPtr, _r, _g, _b);
  }

  public void set(int _r, int _g, int _b, int _a) {
    touchvgcsPINVOKE.GiColor_set__SWIG_1(swigCPtr, _r, _g, _b, _a);
  }

  public bool isInvalid() {
    bool ret = touchvgcsPINVOKE.GiColor_isInvalid(swigCPtr);
    return ret;
  }

  public bool equals(GiColor src) {
    bool ret = touchvgcsPINVOKE.GiColor_equals(swigCPtr, GiColor.getCPtr(src));
    if (touchvgcsPINVOKE.SWIGPendingException.Pending) throw touchvgcsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
