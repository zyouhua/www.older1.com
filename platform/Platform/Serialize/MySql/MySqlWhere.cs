using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace platform
{
    public class MySqlWhere : ISqlSerialize
    {
        public void _serialize(ref bool nValue, string nName, bool nOptimal = default(bool))
        {
        }

        public void _serialize(ref sbyte nValue, string nName, sbyte nOptimal = default(sbyte))
        {
        }

        public void _serialize<__t>(ref Dictionary<sbyte, __t> nValue, string nName) where __t : IKeyI8
        {
        }

        public void _serialize(ref List<sbyte> nValue, string nName)
        {
        }

        public void _serialize(ref byte nValue, string nName, byte nOptimal = default(byte))
        {
        }

        public void _serialize<__t>(ref Dictionary<byte, __t> nValue, string nName) where __t : IKeyU8
        {
        }

        public void _serialize(ref List<byte> nValue, string nName)
        {
        }

        public void _serialize(ref short nValue, string nName, short nOptimal = default(short))
        {
        }

        public void _serialize<__t>(ref Dictionary<short, __t> nValue, string nName) where __t : IKeyI16
        {
        }

        public void _serialize(ref List<short> nValue, string nName)
        {
        }

        public void _serialize(ref ushort nValue, string nName, ushort nOptimal = default(ushort))
        {
        }

        public void _serialize<__t>(ref Dictionary<ushort, __t> nValue, string nName) where __t : IKeyU16
        {
        }

        public void _serialize(ref List<ushort> nValue, string nName)
        {
        }

        public void _serialize(ref int nValue, string nName, int nOptimal = default(int))
        {
        }

        public void _serialize<__t>(ref Dictionary<int, __t> nValue, string nName) where __t : IKeyI32
        {
        }

        public void _serialize(ref List<int> nValue, string nName)
        {
        }

        public void _serialize(ref uint nValue, string nName, uint nOptimal = default(uint))
        {
        }

        public void _serialize<__t>(ref Dictionary<uint, __t> nValue, string nName) where __t : IKeyU32
        {
        }

        public void _serialize(ref List<uint> nValue, string nName)
        {
        }

        public void _serialize(ref long nValue, string nName, long nOptimal = default(long))
        {
        }

        public void _serialize<__t>(ref Dictionary<long, __t> nValue, string nName) where __t : IKeyI64
        {
        }

        public void _serialize(ref List<long> nValue, string nName)
        {
        }

        public void _serialize(ref ulong nValue, string nName, ulong nOptimal = default(ulong))
        {
        }

        public void _serialize<__t>(ref Dictionary<ulong, __t> nValue, string nName) where __t : IKeyU64
        {
        }

        public void _serialize(ref List<ulong> nValue, string nName)
        {
        }

        public void _serialize(ref string nValue, string nName, string nOptimal = default(string))
        {
        }

        public void _serialize<__t>(ref Dictionary<string, __t> nValue, string nName) where __t : IKeyStr
        {
        }

        public void _serialize(ref List<string> nValue, string nName)
        {
        }

        public void _serialize(ref float nValue, string nName, float nOptimal = default(float))
        {
        }

        public void _serialize<__t>(ref Dictionary<float, __t> nValue, string nName) where __t : IKeyFloat
        {
        }

        public void _serialize(ref List<float> nValue, string nName)
        {
        }

        public void _serialize(ref double nValue, string nName, double nOptimal = default(double))
        {
        }

        public void _serialize<__t>(ref Dictionary<double, __t> nValue, string nName) where __t : IKeyDouble
        {
        }

        public void _serialize(ref List<double> nValue, string nName)
        {
        }

        public void _serialize<__t>(ref __t nValue, string nName, __t nOptimal = default(__t)) where __t : IStream
        {
        }

        public void _serialize<__t>(ref List<__t> nValue, string nName) where __t : IStream
        {
        }

        public void _selectStream(string nStreamName)
        {
            mCommand += nStreamName;
        }

        public string _sqlCommand()
        {
            return mCommand;
        }

        public MySqlWhere()
        {
            mCommand = " WHERE ";
        }

        string mCommand;
    }
}
