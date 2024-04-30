// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sample.schema
{

    using global::System;
    using global::System.Collections.Generic;
    using global::Google.FlatBuffers;

    public struct InertialValue : IFlatbufferObject
    {
        private Table __p;
        public ByteBuffer ByteBuffer { get { return __p.bb; } }
        public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_7(); }
        public static InertialValue GetRootAsInertialValue(ByteBuffer _bb) { return GetRootAsInertialValue(_bb, new InertialValue()); }
        public static InertialValue GetRootAsInertialValue(ByteBuffer _bb, InertialValue obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
        public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
        public InertialValue __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

        public short X { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
        public short Y { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
        public short Z { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }

        public static Offset<sample.schema.InertialValue> CreateInertialValue(FlatBufferBuilder builder,
            short x = 0,
            short y = 0,
            short z = 0)
        {
            builder.StartTable(3);
            InertialValue.AddZ(builder, z);
            InertialValue.AddY(builder, y);
            InertialValue.AddX(builder, x);
            return InertialValue.EndInertialValue(builder);
        }

        public static void StartInertialValue(FlatBufferBuilder builder) { builder.StartTable(3); }
        public static void AddX(FlatBufferBuilder builder, short x) { builder.AddShort(0, x, 0); }
        public static void AddY(FlatBufferBuilder builder, short y) { builder.AddShort(1, y, 0); }
        public static void AddZ(FlatBufferBuilder builder, short z) { builder.AddShort(2, z, 0); }
        public static Offset<sample.schema.InertialValue> EndInertialValue(FlatBufferBuilder builder)
        {
            int o = builder.EndTable();
            return new Offset<sample.schema.InertialValue>(o);
        }
        public static void FinishInertialValueBuffer(FlatBufferBuilder builder, Offset<sample.schema.InertialValue> offset) { builder.Finish(offset.Value); }
        public static void FinishSizePrefixedInertialValueBuffer(FlatBufferBuilder builder, Offset<sample.schema.InertialValue> offset) { builder.FinishSizePrefixed(offset.Value); }
        public InertialValueT UnPack()
        {
            var _o = new InertialValueT();
            this.UnPackTo(_o);
            return _o;
        }
        public void UnPackTo(InertialValueT _o)
        {
            _o.X = this.X;
            _o.Y = this.Y;
            _o.Z = this.Z;
        }
        public static Offset<sample.schema.InertialValue> Pack(FlatBufferBuilder builder, InertialValueT _o)
        {
            if (_o == null) return default(Offset<sample.schema.InertialValue>);
            return CreateInertialValue(
              builder,
              _o.X,
              _o.Y,
              _o.Z);
        }
    }

    public class InertialValueT
    {
        public short X { get; set; }
        public short Y { get; set; }
        public short Z { get; set; }

        public InertialValueT()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        public static InertialValueT DeserializeFromBinary(byte[] fbBuffer)
        {
            return InertialValue.GetRootAsInertialValue(new ByteBuffer(fbBuffer)).UnPack();
        }
        public byte[] SerializeToBinary()
        {
            var fbb = new FlatBufferBuilder(0x10000);
            InertialValue.FinishInertialValueBuffer(fbb, InertialValue.Pack(fbb, this));
            return fbb.DataBuffer.ToSizedArray();
        }
    }


}
