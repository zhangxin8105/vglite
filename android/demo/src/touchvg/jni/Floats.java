/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package touchvg.jni;

public class Floats {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected Floats(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(Floats obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        touchvgJNI.delete_Floats(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public Floats(int n) {
    this(touchvgJNI.new_Floats(n), true);
  }

  public int count() {
    return touchvgJNI.Floats_count(swigCPtr, this);
  }

  public float get(int index) {
    return touchvgJNI.Floats_get(swigCPtr, this, index);
  }

  public void set(int index, float value) {
    touchvgJNI.Floats_set(swigCPtr, this, index, value);
  }

}
