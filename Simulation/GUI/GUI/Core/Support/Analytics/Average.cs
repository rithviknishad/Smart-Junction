using System;

namespace GUI.Core.Support.Analytics.Average
{

    public class AverageU8_8
    {

        private byte AVERAGE_VALUE = 0;
        private byte COUNT = 0;

        public void Add(byte _Value)
        {
            AVERAGE_VALUE = (byte)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = COUNT = 0;
        }

        public byte Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU8_16
    {

        private byte AVERAGE_VALUE = 0;
        private ushort COUNT = 0;

        public void Add(byte _Value)
        {
            AVERAGE_VALUE = (byte)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (byte)(COUNT = 0);
        }

        public byte Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU8_32
    {

        private byte AVERAGE_VALUE = 0;
        private uint COUNT = 0;

        public void Add(byte _Value)
        {
            AVERAGE_VALUE = (byte)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (byte)(COUNT = 0);
        }

        public byte Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU8_64
    {
        private byte AVERAGE_VALUE = 0;
        private ulong COUNT = 0;

        public void Add(byte _Value)
        {
            AVERAGE_VALUE = (byte)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (byte)(COUNT = 0);
        }

        public byte Value()
        {
            return AVERAGE_VALUE;
        }

    }


    public class AverageU16_8
    {

        private ushort AVERAGE_VALUE = 0;
        private byte COUNT = 0;

        public void Add(ushort _Value)
        {
            AVERAGE_VALUE = (ushort)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (ushort)(COUNT = 0);
        }

        public ushort Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU16_16
    {

        private ushort AVERAGE_VALUE = 0;
        private ushort COUNT = 0;

        public void Add(ushort _Value)
        {
            AVERAGE_VALUE = (ushort)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = COUNT = 0;
        }

        public ushort Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU16_32
    {

        private ushort AVERAGE_VALUE = 0;
        private uint COUNT = 0;

        public void Add(ushort _Value)
        {
            AVERAGE_VALUE = (ushort)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (ushort)(COUNT = 0);
        }

        public ushort Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU16_64
    {

        private ushort AVERAGE_VALUE = 0;
        private ulong COUNT = 0;

        public void Add(ushort _Value)
        {
            AVERAGE_VALUE = (ushort)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (ushort)(COUNT = 0);
        }

        public ushort Value()
        {
            return AVERAGE_VALUE;
        }

    }


    public class AverageU32_8
    {

        private uint AVERAGE_VALUE = 0;
        private byte COUNT = 0;

        public void Add(uint _Value)
        {
            AVERAGE_VALUE = (uint)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (uint)(COUNT = 0);
        }

        public uint Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU32_16
    {

        private uint AVERAGE_VALUE = 0;
        private ushort COUNT = 0;

        public void Add(uint _Value)
        {
            AVERAGE_VALUE = (uint)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (uint)(COUNT = 0);
        }

        public uint Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU32_32
    {

        private uint AVERAGE_VALUE = 0;
        private uint COUNT = 0;

        public void Add(uint _Value)
        {
            AVERAGE_VALUE = (uint)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (uint)(COUNT = 0);
        }

        public uint Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU32_64
    {

        private uint AVERAGE_VALUE = 0;
        private ulong COUNT = 0;

        public void Add(uint _Value)
        {
            AVERAGE_VALUE = (uint)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (uint)(COUNT = 0);
        }

        public uint Value()
        {
            return AVERAGE_VALUE;
        }

    }


    public class AverageU64_8
    {

        private ulong AVERAGE_VALUE = 0;
        private byte COUNT = 0;

        public void Add(ulong _Value)
        {
            AVERAGE_VALUE = (ulong)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = COUNT = 0;
        }

        public ulong Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU64_16
    {

        private ulong AVERAGE_VALUE = 0;
        private ushort COUNT = 0;

        public void Add(ulong _Value)
        {
            AVERAGE_VALUE = (ulong)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = COUNT = 0;
        }

        public ulong Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU64_32
    {

        private ulong AVERAGE_VALUE = 0;
        private uint COUNT = 0;

        public void Add(ulong _Value)
        {
            AVERAGE_VALUE = (ulong)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = COUNT = 0;
        }

        public ulong Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageU64
    {

        private ulong AVERAGE_VALUE = 0;
        private ulong COUNT = 0;

        public void Add(ulong _Value)
        {
            AVERAGE_VALUE = (ulong)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = COUNT = 0;
        }

        public ulong Value()
        {
            return AVERAGE_VALUE;
        }

    }


    public class AverageFLOAT8
    {

        private float AVERAGE_VALUE = 0;
        private byte COUNT = 0;

        public void Add(float _Value)
        {
            AVERAGE_VALUE = (float)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (float)(COUNT = 0);
        }

        public float Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageFLOAT16
    {

        private float AVERAGE_VALUE = 0;
        private ushort COUNT = 0;

        public void Add(float _Value)
        {
            AVERAGE_VALUE = (float)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (float)(COUNT = 0);
        }

        public float Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageFLOAT32
    {

        private float AVERAGE_VALUE = 0;
        private uint COUNT = 0;

        public void Add(float _Value)
        {
            AVERAGE_VALUE = (float)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (float)(COUNT = 0);
        }

        public float Value()
        {
            return AVERAGE_VALUE;
        }

    }

    public class AverageFLOAT64
    {

        private float AVERAGE_VALUE = 0;
        private ulong COUNT = 0;

        public void Add(float _Value)
        {
            AVERAGE_VALUE = (float)(((AVERAGE_VALUE * COUNT) + _Value) / (++COUNT));
        }

        public void Reset()
        {
            AVERAGE_VALUE = (float)(COUNT = 0);
        }

        public float Value()
        {
            return AVERAGE_VALUE;
        }

    }

}