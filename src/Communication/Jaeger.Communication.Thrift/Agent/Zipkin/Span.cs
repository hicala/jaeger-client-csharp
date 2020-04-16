/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;


namespace Jaeger.Thrift.Agent.Zipkin
{

  /// <summary>
  /// A trace is a series of spans (often RPC calls) which form a latency tree.
  /// 
  /// The root span is where trace_id = id and parent_id = Nil. The root span is
  /// usually the longest interval in the trace, starting with a SERVER_RECV
  /// annotation and ending with a SERVER_SEND.
  /// </summary>
  public partial class Span : TBase
  {
    private long _trace_id;
    private string _name;
    private long _id;
    private long _parent_id;
    private List<Annotation> _annotations;
    private List<BinaryAnnotation> _binary_annotations;
    private bool _debug;
    private long _timestamp;
    private long _duration;
    private long _trace_id_high;

    public long Trace_id
    {
      get
      {
        return _trace_id;
      }
      set
      {
        __isset.trace_id = true;
        this._trace_id = value;
      }
    }

    /// <summary>
    /// Span name in lowercase, rpc method for example
    /// 
    /// Conventionally, when the span name isn't known, name = "unknown".
    /// </summary>
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public long Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public long Parent_id
    {
      get
      {
        return _parent_id;
      }
      set
      {
        __isset.parent_id = true;
        this._parent_id = value;
      }
    }

    public List<Annotation> Annotations
    {
      get
      {
        return _annotations;
      }
      set
      {
        __isset.annotations = true;
        this._annotations = value;
      }
    }

    public List<BinaryAnnotation> Binary_annotations
    {
      get
      {
        return _binary_annotations;
      }
      set
      {
        __isset.binary_annotations = true;
        this._binary_annotations = value;
      }
    }

    public bool Debug
    {
      get
      {
        return _debug;
      }
      set
      {
        __isset.debug = true;
        this._debug = value;
      }
    }

    /// <summary>
    /// Microseconds from epoch of the creation of this span.
    /// 
    /// This value should be set directly by instrumentation, using the most
    /// precise value possible. For example, gettimeofday or syncing nanoTime
    /// against a tick of currentTimeMillis.
    /// 
    /// For compatibility with instrumentation that precede this field, collectors
    /// or span stores can derive this via Annotation.timestamp.
    /// For example, SERVER_RECV.timestamp or CLIENT_SEND.timestamp.
    /// 
    /// This field is optional for compatibility with old data: first-party span
    /// stores are expected to support this at time of introduction.
    /// </summary>
    public long Timestamp
    {
      get
      {
        return _timestamp;
      }
      set
      {
        __isset.timestamp = true;
        this._timestamp = value;
      }
    }

    /// <summary>
    /// Measurement of duration in microseconds, used to support queries.
    /// 
    /// This value should be set directly, where possible. Doing so encourages
    /// precise measurement decoupled from problems of clocks, such as skew or NTP
    /// updates causing time to move backwards.
    /// 
    /// For compatibility with instrumentation that precede this field, collectors
    /// or span stores can derive this by subtracting Annotation.timestamp.
    /// For example, SERVER_SEND.timestamp - SERVER_RECV.timestamp.
    /// 
    /// If this field is persisted as unset, zipkin will continue to work, except
    /// duration query support will be implementation-specific. Similarly, setting
    /// this field non-atomically is implementation-specific.
    /// 
    /// This field is i64 vs i32 to support spans longer than 35 minutes.
    /// </summary>
    public long Duration
    {
      get
      {
        return _duration;
      }
      set
      {
        __isset.duration = true;
        this._duration = value;
      }
    }

    /// <summary>
    /// Optional unique 8-byte additional identifier for a trace. If non zero, this
    /// means the trace uses 128 bit traceIds instead of 64 bit.
    /// </summary>
    public long Trace_id_high
    {
      get
      {
        return _trace_id_high;
      }
      set
      {
        __isset.trace_id_high = true;
        this._trace_id_high = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool trace_id;
      public bool name;
      public bool id;
      public bool parent_id;
      public bool annotations;
      public bool binary_annotations;
      public bool debug;
      public bool timestamp;
      public bool duration;
      public bool trace_id_high;
    }

    public Span()
    {
      this._debug = false;
      this.__isset.debug = true;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I64)
              {
                Trace_id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                Name = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                Id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I64)
              {
                Parent_id = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.List)
              {
                {
                  TList _list0 = await iprot.ReadListBeginAsync(cancellationToken);
                  Annotations = new List<Annotation>(_list0.Count);
                  for(int _i1 = 0; _i1 < _list0.Count; ++_i1)
                  {
                    Annotation _elem2;
                    _elem2 = new Annotation();
                    await _elem2.ReadAsync(iprot, cancellationToken);
                    Annotations.Add(_elem2);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.List)
              {
                {
                  TList _list3 = await iprot.ReadListBeginAsync(cancellationToken);
                  Binary_annotations = new List<BinaryAnnotation>(_list3.Count);
                  for(int _i4 = 0; _i4 < _list3.Count; ++_i4)
                  {
                    BinaryAnnotation _elem5;
                    _elem5 = new BinaryAnnotation();
                    await _elem5.ReadAsync(iprot, cancellationToken);
                    Binary_annotations.Add(_elem5);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.Bool)
              {
                Debug = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.I64)
              {
                Timestamp = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 11:
              if (field.Type == TType.I64)
              {
                Duration = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 12:
              if (field.Type == TType.I64)
              {
                Trace_id_high = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("Span");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (__isset.trace_id)
        {
          field.Name = "trace_id";
          field.Type = TType.I64;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Trace_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Name != null && __isset.name)
        {
          field.Name = "name";
          field.Type = TType.String;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.id)
        {
          field.Name = "id";
          field.Type = TType.I64;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.parent_id)
        {
          field.Name = "parent_id";
          field.Type = TType.I64;
          field.ID = 5;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Parent_id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Annotations != null && __isset.annotations)
        {
          field.Name = "annotations";
          field.Type = TType.List;
          field.ID = 6;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Annotations.Count), cancellationToken);
            foreach (Annotation _iter6 in Annotations)
            {
              await _iter6.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Binary_annotations != null && __isset.binary_annotations)
        {
          field.Name = "binary_annotations";
          field.Type = TType.List;
          field.ID = 8;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Binary_annotations.Count), cancellationToken);
            foreach (BinaryAnnotation _iter7 in Binary_annotations)
            {
              await _iter7.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.debug)
        {
          field.Name = "debug";
          field.Type = TType.Bool;
          field.ID = 9;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(Debug, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.timestamp)
        {
          field.Name = "timestamp";
          field.Type = TType.I64;
          field.ID = 10;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Timestamp, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.duration)
        {
          field.Name = "duration";
          field.Type = TType.I64;
          field.ID = 11;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Duration, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.trace_id_high)
        {
          field.Name = "trace_id_high";
          field.Type = TType.I64;
          field.ID = 12;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Trace_id_high, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as Span;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.trace_id == other.__isset.trace_id) && ((!__isset.trace_id) || (System.Object.Equals(Trace_id, other.Trace_id))))
        && ((__isset.name == other.__isset.name) && ((!__isset.name) || (System.Object.Equals(Name, other.Name))))
        && ((__isset.id == other.__isset.id) && ((!__isset.id) || (System.Object.Equals(Id, other.Id))))
        && ((__isset.parent_id == other.__isset.parent_id) && ((!__isset.parent_id) || (System.Object.Equals(Parent_id, other.Parent_id))))
        && ((__isset.annotations == other.__isset.annotations) && ((!__isset.annotations) || (TCollections.Equals(Annotations, other.Annotations))))
        && ((__isset.binary_annotations == other.__isset.binary_annotations) && ((!__isset.binary_annotations) || (TCollections.Equals(Binary_annotations, other.Binary_annotations))))
        && ((__isset.debug == other.__isset.debug) && ((!__isset.debug) || (System.Object.Equals(Debug, other.Debug))))
        && ((__isset.timestamp == other.__isset.timestamp) && ((!__isset.timestamp) || (System.Object.Equals(Timestamp, other.Timestamp))))
        && ((__isset.duration == other.__isset.duration) && ((!__isset.duration) || (System.Object.Equals(Duration, other.Duration))))
        && ((__isset.trace_id_high == other.__isset.trace_id_high) && ((!__isset.trace_id_high) || (System.Object.Equals(Trace_id_high, other.Trace_id_high))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.trace_id)
          hashcode = (hashcode * 397) + Trace_id.GetHashCode();
        if(__isset.name)
          hashcode = (hashcode * 397) + Name.GetHashCode();
        if(__isset.id)
          hashcode = (hashcode * 397) + Id.GetHashCode();
        if(__isset.parent_id)
          hashcode = (hashcode * 397) + Parent_id.GetHashCode();
        if(__isset.annotations)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Annotations);
        if(__isset.binary_annotations)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Binary_annotations);
        if(__isset.debug)
          hashcode = (hashcode * 397) + Debug.GetHashCode();
        if(__isset.timestamp)
          hashcode = (hashcode * 397) + Timestamp.GetHashCode();
        if(__isset.duration)
          hashcode = (hashcode * 397) + Duration.GetHashCode();
        if(__isset.trace_id_high)
          hashcode = (hashcode * 397) + Trace_id_high.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("Span(");
      bool __first = true;
      if (__isset.trace_id)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Trace_id: ");
        sb.Append(Trace_id);
      }
      if (Name != null && __isset.name)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Name: ");
        sb.Append(Name);
      }
      if (__isset.id)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Id: ");
        sb.Append(Id);
      }
      if (__isset.parent_id)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Parent_id: ");
        sb.Append(Parent_id);
      }
      if (Annotations != null && __isset.annotations)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Annotations: ");
        sb.Append(Annotations);
      }
      if (Binary_annotations != null && __isset.binary_annotations)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Binary_annotations: ");
        sb.Append(Binary_annotations);
      }
      if (__isset.debug)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Debug: ");
        sb.Append(Debug);
      }
      if (__isset.timestamp)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Timestamp: ");
        sb.Append(Timestamp);
      }
      if (__isset.duration)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Duration: ");
        sb.Append(Duration);
      }
      if (__isset.trace_id_high)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Trace_id_high: ");
        sb.Append(Trace_id_high);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}