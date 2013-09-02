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

public class MgStorage : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgStorage(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgStorage obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgStorage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgcsPINVOKE.delete_MgStorage(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool readNode(string name, int index, bool ended) {
    bool ret = touchvgcsPINVOKE.MgStorage_readNode(swigCPtr, name, index, ended);
    return ret;
  }

  public virtual bool writeNode(string name, int index, bool ended) {
    bool ret = touchvgcsPINVOKE.MgStorage_writeNode(swigCPtr, name, index, ended);
    return ret;
  }

  public virtual bool readBool(string name, bool defvalue) {
    bool ret = touchvgcsPINVOKE.MgStorage_readBool(swigCPtr, name, defvalue);
    return ret;
  }

  public virtual float readFloat(string name, float defvalue) {
    float ret = touchvgcsPINVOKE.MgStorage_readFloat(swigCPtr, name, defvalue);
    return ret;
  }

  public virtual void writeBool(string name, bool value) {
    touchvgcsPINVOKE.MgStorage_writeBool(swigCPtr, name, value);
  }

  public virtual void writeFloat(string name, float value) {
    touchvgcsPINVOKE.MgStorage_writeFloat(swigCPtr, name, value);
  }

  public virtual void writeString(string name, string value) {
    touchvgcsPINVOKE.MgStorage_writeString(swigCPtr, name, value);
  }

  public virtual int readInt(string name, int defvalue) {
    int ret = touchvgcsPINVOKE.MgStorage_readInt(swigCPtr, name, defvalue);
    return ret;
  }

  public virtual void writeInt(string name, int value) {
    touchvgcsPINVOKE.MgStorage_writeInt(swigCPtr, name, value);
  }

  public virtual void writeUInt(string name, int value) {
    touchvgcsPINVOKE.MgStorage_writeUInt(swigCPtr, name, value);
  }

  public virtual bool setError(string arg0) {
    bool ret = touchvgcsPINVOKE.MgStorage_setError(swigCPtr, arg0);
    return ret;
  }

}

}
