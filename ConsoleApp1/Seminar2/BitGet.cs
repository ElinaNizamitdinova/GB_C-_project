using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar2
{
    internal interface IBitGet
    {
        bool GetBitByIndex (byte index);
        void SetBitByIndex (byte index, bool value);
    }
    public class Bits : IBitGet { 



        public long Value { get; set; }
        public int Size {  get; set; }
        public Bits(byte value)
        {
            Value = value;
            Size = sizeof(byte);
        }
        public Bits(int value)
        {
            Value = value;
            Size = sizeof(int);
        }
        public Bits(long value)
        {
            Value = value;
            Size = sizeof(long);
        }


        public bool GetBitByIndex(byte index)
        {
            return (Value & (1 << index)) != 0;
        }

        public void SetBitByIndex(byte index, bool value)
        {
            if(value) { 
                Value |= (byte)(1 << index);
            }
            else {
            Value &= (byte)~(1 << index);
                    }
        }
        public bool this[byte index] {
            get => GetBitByIndex(index);
            set => SetBitByIndex(index, value);
        }
        public static implicit operator long(Bits bits)
        {
            return bits.Value;
        }
        public static explicit operator Bits(long value)
        {
            return new(value);
        }
    }


    
}
