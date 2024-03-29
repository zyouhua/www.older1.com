﻿using System.Collections.Generic;

namespace platform
{
    public class StringTable : Headstream
    {
        public override void _headSerialize(ISerialize nSerialize)
        {
            nSerialize._serialize(ref mStringElements, "stringElements");
            base._headSerialize(nSerialize);
        }

        public override string _streamName()
        {
            return @"stringTable";
        }

        public string _getString(string nName)
        {
            string result_ = null;
            if (mStringElements.ContainsKey(nName))
            {
                StringElement stringElement_ = mStringElements[nName];
                result_ = stringElement_._getValue();
            }
            return result_;
        }

        public StringTable()
        {
            mStringElements = new Dictionary<string, StringElement>();
        }

        Dictionary<string, StringElement> mStringElements;
    }
}
