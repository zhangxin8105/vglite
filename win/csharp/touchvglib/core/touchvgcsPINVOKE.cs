/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

class touchvgcsPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [DllImport("touchvgcs", EntryPoint="SWIGRegisterExceptionCallbacks_touchvgcs")]
    public static extern void SWIGRegisterExceptionCallbacks_touchvgcs(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [DllImport("touchvgcs", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_touchvgcs")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_touchvgcs(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_touchvgcs(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_touchvgcs(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [ThreadStatic]
    private static Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(Exception e) {
      if (pendingException != null)
        throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(touchvgcsPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static Exception Retrieve() {
      Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(touchvgcsPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [DllImport("touchvgcs", EntryPoint="SWIGRegisterStringCallback_touchvgcs")]
    public static extern void SWIGRegisterStringCallback_touchvgcs(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_touchvgcs(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static touchvgcsPINVOKE() {
  }


  [DllImport("touchvgcs", EntryPoint="CSharp_delete_Ints")]
  public static extern void delete_Ints(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_Ints")]
  public static extern IntPtr new_Ints(int jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_Ints_count")]
  public static extern int Ints_count(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_Ints_get")]
  public static extern int Ints_get(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_Ints_set")]
  public static extern void Ints_set(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_Floats")]
  public static extern void delete_Floats(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_Floats")]
  public static extern IntPtr new_Floats(int jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_Floats_count")]
  public static extern int Floats_count(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_Floats_get")]
  public static extern float Floats_get(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_Floats_set")]
  public static extern void Floats_set(HandleRef jarg1, int jarg2, float jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_Chars")]
  public static extern void delete_Chars(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_Chars")]
  public static extern IntPtr new_Chars(int jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_Chars_count")]
  public static extern int Chars_count(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_Chars_get")]
  public static extern char Chars_get(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_Chars_set")]
  public static extern void Chars_set(HandleRef jarg1, int jarg2, char jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_GiCanvas")]
  public static extern void delete_GiCanvas(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_setPen")]
  public static extern void GiCanvas_setPen(HandleRef jarg1, int jarg2, float jarg3, int jarg4, float jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_setBrush")]
  public static extern void GiCanvas_setBrush(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_clearRect")]
  public static extern void GiCanvas_clearRect(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_drawRect")]
  public static extern void GiCanvas_drawRect(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5, bool jarg6, bool jarg7);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_drawLine")]
  public static extern void GiCanvas_drawLine(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_drawEllipse")]
  public static extern void GiCanvas_drawEllipse(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5, bool jarg6, bool jarg7);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_beginPath")]
  public static extern void GiCanvas_beginPath(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_moveTo")]
  public static extern void GiCanvas_moveTo(HandleRef jarg1, float jarg2, float jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_lineTo")]
  public static extern void GiCanvas_lineTo(HandleRef jarg1, float jarg2, float jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_bezierTo")]
  public static extern void GiCanvas_bezierTo(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_quadTo")]
  public static extern void GiCanvas_quadTo(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_closePath")]
  public static extern void GiCanvas_closePath(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_drawPath")]
  public static extern void GiCanvas_drawPath(HandleRef jarg1, bool jarg2, bool jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_saveClip")]
  public static extern void GiCanvas_saveClip(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_restoreClip")]
  public static extern void GiCanvas_restoreClip(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_clipRect")]
  public static extern bool GiCanvas_clipRect(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_clipPath")]
  public static extern bool GiCanvas_clipPath(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_drawHandle")]
  public static extern void GiCanvas_drawHandle(HandleRef jarg1, float jarg2, float jarg3, int jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_drawBitmap")]
  public static extern void GiCanvas_drawBitmap(HandleRef jarg1, string jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_drawTextAt")]
  public static extern float GiCanvas_drawTextAt(HandleRef jarg1, string jarg2, float jarg3, float jarg4, float jarg5, int jarg6);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiCanvas")]
  public static extern IntPtr new_GiCanvas();

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCanvas_director_connect")]
  public static extern void GiCanvas_director_connect(HandleRef jarg1, GiCanvas.SwigDelegateGiCanvas_0 delegate0, GiCanvas.SwigDelegateGiCanvas_1 delegate1, GiCanvas.SwigDelegateGiCanvas_2 delegate2, GiCanvas.SwigDelegateGiCanvas_3 delegate3, GiCanvas.SwigDelegateGiCanvas_4 delegate4, GiCanvas.SwigDelegateGiCanvas_5 delegate5, GiCanvas.SwigDelegateGiCanvas_6 delegate6, GiCanvas.SwigDelegateGiCanvas_7 delegate7, GiCanvas.SwigDelegateGiCanvas_8 delegate8, GiCanvas.SwigDelegateGiCanvas_9 delegate9, GiCanvas.SwigDelegateGiCanvas_10 delegate10, GiCanvas.SwigDelegateGiCanvas_11 delegate11, GiCanvas.SwigDelegateGiCanvas_12 delegate12, GiCanvas.SwigDelegateGiCanvas_13 delegate13, GiCanvas.SwigDelegateGiCanvas_14 delegate14, GiCanvas.SwigDelegateGiCanvas_15 delegate15, GiCanvas.SwigDelegateGiCanvas_16 delegate16, GiCanvas.SwigDelegateGiCanvas_17 delegate17, GiCanvas.SwigDelegateGiCanvas_18 delegate18, GiCanvas.SwigDelegateGiCanvas_19 delegate19);

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_GiView")]
  public static extern void delete_GiView(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_regenAll")]
  public static extern void GiView_regenAll(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_regenAppend")]
  public static extern void GiView_regenAppend(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_redraw")]
  public static extern void GiView_redraw(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_useFinger")]
  public static extern bool GiView_useFinger(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_useFingerSwigExplicitGiView")]
  public static extern bool GiView_useFingerSwigExplicitGiView(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_isContextActionsVisible")]
  public static extern bool GiView_isContextActionsVisible(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_isContextActionsVisibleSwigExplicitGiView")]
  public static extern bool GiView_isContextActionsVisibleSwigExplicitGiView(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_showContextActions")]
  public static extern bool GiView_showContextActions(HandleRef jarg1, HandleRef jarg2, float jarg3, float jarg4, float jarg5, float jarg6);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_showContextActionsSwigExplicitGiView")]
  public static extern bool GiView_showContextActionsSwigExplicitGiView(HandleRef jarg1, HandleRef jarg2, float jarg3, float jarg4, float jarg5, float jarg6);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_commandChanged")]
  public static extern void GiView_commandChanged(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_commandChangedSwigExplicitGiView")]
  public static extern void GiView_commandChangedSwigExplicitGiView(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_selectionChanged")]
  public static extern void GiView_selectionChanged(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_selectionChangedSwigExplicitGiView")]
  public static extern void GiView_selectionChangedSwigExplicitGiView(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_contentChanged")]
  public static extern void GiView_contentChanged(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_contentChangedSwigExplicitGiView")]
  public static extern void GiView_contentChangedSwigExplicitGiView(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiView")]
  public static extern IntPtr new_GiView();

  [DllImport("touchvgcs", EntryPoint="CSharp_GiView_director_connect")]
  public static extern void GiView_director_connect(HandleRef jarg1, GiView.SwigDelegateGiView_0 delegate0, GiView.SwigDelegateGiView_1 delegate1, GiView.SwigDelegateGiView_2 delegate2, GiView.SwigDelegateGiView_3 delegate3, GiView.SwigDelegateGiView_4 delegate4, GiView.SwigDelegateGiView_5 delegate5, GiView.SwigDelegateGiView_6 delegate6, GiView.SwigDelegateGiView_7 delegate7, GiView.SwigDelegateGiView_8 delegate8);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_r_set")]
  public static extern void GiColor_r_set(HandleRef jarg1, byte jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_r_get")]
  public static extern byte GiColor_r_get(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_g_set")]
  public static extern void GiColor_g_set(HandleRef jarg1, byte jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_g_get")]
  public static extern byte GiColor_g_get(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_b_set")]
  public static extern void GiColor_b_set(HandleRef jarg1, byte jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_b_get")]
  public static extern byte GiColor_b_get(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_a_set")]
  public static extern void GiColor_a_set(HandleRef jarg1, byte jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_a_get")]
  public static extern byte GiColor_a_get(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiColor__SWIG_0")]
  public static extern IntPtr new_GiColor__SWIG_0();

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiColor__SWIG_1")]
  public static extern IntPtr new_GiColor__SWIG_1(int jarg1, int jarg2, int jarg3, int jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiColor__SWIG_2")]
  public static extern IntPtr new_GiColor__SWIG_2(int jarg1, int jarg2, int jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiColor__SWIG_3")]
  public static extern IntPtr new_GiColor__SWIG_3(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiColor__SWIG_4")]
  public static extern IntPtr new_GiColor__SWIG_4(int jarg1, bool jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiColor__SWIG_5")]
  public static extern IntPtr new_GiColor__SWIG_5(int jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_White")]
  public static extern IntPtr GiColor_White();

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_Black")]
  public static extern IntPtr GiColor_Black();

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_Invalid")]
  public static extern IntPtr GiColor_Invalid();

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_getARGB")]
  public static extern int GiColor_getARGB(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_setARGB")]
  public static extern void GiColor_setARGB(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_set__SWIG_0")]
  public static extern void GiColor_set__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_set__SWIG_1")]
  public static extern void GiColor_set__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_isInvalid")]
  public static extern bool GiColor_isInvalid(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiColor_equals")]
  public static extern bool GiColor_equals(HandleRef jarg1, HandleRef jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_GiColor")]
  public static extern void delete_GiColor(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiContext__SWIG_0")]
  public static extern IntPtr new_GiContext__SWIG_0();

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiContext__SWIG_1")]
  public static extern IntPtr new_GiContext__SWIG_1(float jarg1, HandleRef jarg2, int jarg3, HandleRef jarg4, bool jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiContext__SWIG_2")]
  public static extern IntPtr new_GiContext__SWIG_2(float jarg1, HandleRef jarg2, int jarg3, HandleRef jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiContext__SWIG_3")]
  public static extern IntPtr new_GiContext__SWIG_3(float jarg1, HandleRef jarg2, int jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiContext__SWIG_4")]
  public static extern IntPtr new_GiContext__SWIG_4(float jarg1, HandleRef jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiContext__SWIG_5")]
  public static extern IntPtr new_GiContext__SWIG_5(float jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiContext__SWIG_6")]
  public static extern IntPtr new_GiContext__SWIG_6(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_copy__SWIG_0")]
  public static extern IntPtr GiContext_copy__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_copy__SWIG_1")]
  public static extern IntPtr GiContext_copy__SWIG_1(HandleRef jarg1, HandleRef jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_equals")]
  public static extern bool GiContext_equals(HandleRef jarg1, HandleRef jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_getLineStyle")]
  public static extern int GiContext_getLineStyle(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setLineStyle")]
  public static extern void GiContext_setLineStyle(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_getLineWidth")]
  public static extern float GiContext_getLineWidth(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_isAutoScale")]
  public static extern bool GiContext_isAutoScale(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setLineWidth")]
  public static extern void GiContext_setLineWidth(HandleRef jarg1, float jarg2, bool jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_isNullLine")]
  public static extern bool GiContext_isNullLine(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setNullLine")]
  public static extern void GiContext_setNullLine(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_getLineColor")]
  public static extern IntPtr GiContext_getLineColor(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setLineColor__SWIG_0")]
  public static extern void GiContext_setLineColor__SWIG_0(HandleRef jarg1, HandleRef jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setLineColor__SWIG_1")]
  public static extern void GiContext_setLineColor__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setLineColor__SWIG_2")]
  public static extern void GiContext_setLineColor__SWIG_2(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_getLineARGB")]
  public static extern int GiContext_getLineARGB(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setLineARGB")]
  public static extern void GiContext_setLineARGB(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_getLineAlpha")]
  public static extern int GiContext_getLineAlpha(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setLineAlpha")]
  public static extern void GiContext_setLineAlpha(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_hasFillColor")]
  public static extern bool GiContext_hasFillColor(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setNoFillColor")]
  public static extern void GiContext_setNoFillColor(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_getFillColor")]
  public static extern IntPtr GiContext_getFillColor(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setFillColor__SWIG_0")]
  public static extern void GiContext_setFillColor__SWIG_0(HandleRef jarg1, HandleRef jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setFillColor__SWIG_1")]
  public static extern void GiContext_setFillColor__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setFillColor__SWIG_2")]
  public static extern void GiContext_setFillColor__SWIG_2(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_getFillARGB")]
  public static extern int GiContext_getFillARGB(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setFillARGB")]
  public static extern void GiContext_setFillARGB(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_getFillAlpha")]
  public static extern int GiContext_getFillAlpha(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setFillAlpha")]
  public static extern void GiContext_setFillAlpha(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_isAutoFillColor")]
  public static extern bool GiContext_isAutoFillColor(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_setAutoFillColor")]
  public static extern void GiContext_setAutoFillColor(HandleRef jarg1, bool jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiContext_getType")]
  public static extern int GiContext_getType(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_GiContext")]
  public static extern void delete_GiContext(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiCoreView__SWIG_0")]
  public static extern IntPtr new_GiCoreView__SWIG_0(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiCoreView__SWIG_1")]
  public static extern IntPtr new_GiCoreView__SWIG_1();

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_GiCoreView")]
  public static extern void delete_GiCoreView(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_createView__SWIG_0")]
  public static extern void GiCoreView_createView__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_createView__SWIG_1")]
  public static extern void GiCoreView_createView__SWIG_1(HandleRef jarg1, HandleRef jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_createMagnifierView")]
  public static extern void GiCoreView_createMagnifierView(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_destoryView")]
  public static extern void GiCoreView_destoryView(HandleRef jarg1, HandleRef jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_drawAll")]
  public static extern int GiCoreView_drawAll(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_drawAppend")]
  public static extern bool GiCoreView_drawAppend(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_dynDraw")]
  public static extern void GiCoreView_dynDraw(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_setBkColor")]
  public static extern int GiCoreView_setBkColor(HandleRef jarg1, HandleRef jarg2, int jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_setScreenDpi")]
  public static extern void GiCoreView_setScreenDpi(int jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_onSize")]
  public static extern void GiCoreView_onSize(HandleRef jarg1, HandleRef jarg2, int jarg3, int jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_onGesture__SWIG_0")]
  public static extern bool GiCoreView_onGesture__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3, int jarg4, float jarg5, float jarg6, bool jarg7);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_onGesture__SWIG_1")]
  public static extern bool GiCoreView_onGesture__SWIG_1(HandleRef jarg1, HandleRef jarg2, int jarg3, int jarg4, float jarg5, float jarg6);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_twoFingersMove__SWIG_0")]
  public static extern bool GiCoreView_twoFingersMove__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3, float jarg4, float jarg5, float jarg6, float jarg7, bool jarg8);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_twoFingersMove__SWIG_1")]
  public static extern bool GiCoreView_twoFingersMove__SWIG_1(HandleRef jarg1, HandleRef jarg2, int jarg3, float jarg4, float jarg5, float jarg6, float jarg7);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_isPressDragging")]
  public static extern bool GiCoreView_isPressDragging(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_getGestureType")]
  public static extern int GiCoreView_getGestureType(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_getGestureState")]
  public static extern int GiCoreView_getGestureState(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_getCommand")]
  public static extern string GiCoreView_getCommand(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_setCommand")]
  public static extern bool GiCoreView_setCommand(HandleRef jarg1, HandleRef jarg2, string jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_doContextAction")]
  public static extern bool GiCoreView_doContextAction(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_clearCachedData")]
  public static extern void GiCoreView_clearCachedData(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_addShapesForTest")]
  public static extern int GiCoreView_addShapesForTest(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_getShapeCount")]
  public static extern int GiCoreView_getShapeCount(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_getSelectedShapeCount")]
  public static extern int GiCoreView_getSelectedShapeCount(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_getSelectedShapeType")]
  public static extern int GiCoreView_getSelectedShapeType(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_loadFromFile")]
  public static extern bool GiCoreView_loadFromFile(HandleRef jarg1, string jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_saveToFile__SWIG_0")]
  public static extern bool GiCoreView_saveToFile__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_saveToFile__SWIG_1")]
  public static extern bool GiCoreView_saveToFile__SWIG_1(HandleRef jarg1, string jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_getContent")]
  public static extern string GiCoreView_getContent(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_freeContent")]
  public static extern void GiCoreView_freeContent(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_setContent")]
  public static extern bool GiCoreView_setContent(HandleRef jarg1, string jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_zoomToExtent")]
  public static extern bool GiCoreView_zoomToExtent(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_zoomToModel")]
  public static extern bool GiCoreView_zoomToModel(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_calcPenWidth")]
  public static extern float GiCoreView_calcPenWidth(HandleRef jarg1, float jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_getContext")]
  public static extern IntPtr GiCoreView_getContext(HandleRef jarg1, bool jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_setContext__SWIG_0")]
  public static extern void GiCoreView_setContext__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3, int jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_setContext__SWIG_1")]
  public static extern void GiCoreView_setContext__SWIG_1(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_setContextEditing")]
  public static extern void GiCoreView_setContextEditing(HandleRef jarg1, bool jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiCoreView_addImageShape")]
  public static extern bool GiCoreView_addImageShape(HandleRef jarg1, string jarg2, float jarg3, float jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_initRand")]
  public static extern void TestCanvas_initRand();

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_randInt")]
  public static extern int TestCanvas_randInt(int jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_randFloat")]
  public static extern float TestCanvas_randFloat(float jarg1, float jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_test__SWIG_0")]
  public static extern void TestCanvas_test__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, bool jarg4);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_test__SWIG_1")]
  public static extern void TestCanvas_test__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_test__SWIG_2")]
  public static extern void TestCanvas_test__SWIG_2(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testRect")]
  public static extern void TestCanvas_testRect(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testLine")]
  public static extern void TestCanvas_testLine(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testEllipse")]
  public static extern void TestCanvas_testEllipse(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testQuadBezier")]
  public static extern void TestCanvas_testQuadBezier(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testCubicBezier")]
  public static extern void TestCanvas_testCubicBezier(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testPolygon")]
  public static extern void TestCanvas_testPolygon(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testClipPath")]
  public static extern void TestCanvas_testClipPath(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testHandle")]
  public static extern void TestCanvas_testHandle(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testDynCurves")]
  public static extern void TestCanvas_testDynCurves(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_TestCanvas_testTextAt")]
  public static extern void TestCanvas_testTextAt(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_TestCanvas")]
  public static extern IntPtr new_TestCanvas();

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_TestCanvas")]
  public static extern void delete_TestCanvas(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_GiMouseHelper")]
  public static extern IntPtr new_GiMouseHelper(HandleRef jarg1, HandleRef jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiMouseHelper_onLButtonDown")]
  public static extern bool GiMouseHelper_onLButtonDown(HandleRef jarg1, float jarg2, float jarg3, bool jarg4, bool jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiMouseHelper_onRButtonDown")]
  public static extern bool GiMouseHelper_onRButtonDown(HandleRef jarg1, float jarg2, float jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiMouseHelper_onMouseUp")]
  public static extern bool GiMouseHelper_onMouseUp(HandleRef jarg1, float jarg2, float jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiMouseHelper_onMouseMove")]
  public static extern bool GiMouseHelper_onMouseMove(HandleRef jarg1, float jarg2, float jarg3, bool jarg4, bool jarg5);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiMouseHelper_onLButtonDblClk")]
  public static extern bool GiMouseHelper_onLButtonDblClk(HandleRef jarg1, float jarg2, float jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_GiMouseHelper_onKeyDown")]
  public static extern bool GiMouseHelper_onKeyDown(HandleRef jarg1, int jarg2);

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_GiMouseHelper")]
  public static extern void delete_GiMouseHelper(HandleRef jarg1);

  [DllImport("touchvgcs", EntryPoint="CSharp_DemoTrade_registerCmds")]
  public static extern void DemoTrade_registerCmds();

  [DllImport("touchvgcs", EntryPoint="CSharp_DemoTrade_getDimensions")]
  public static extern int DemoTrade_getDimensions(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

  [DllImport("touchvgcs", EntryPoint="CSharp_new_DemoTrade")]
  public static extern IntPtr new_DemoTrade();

  [DllImport("touchvgcs", EntryPoint="CSharp_delete_DemoTrade")]
  public static extern void delete_DemoTrade(HandleRef jarg1);
}

}
