using System;
using System.Collections.Generic;

using platform;

namespace account
{
    public class Account
    {
        public AccountC _getAccountC(uint nDeviceType)
        {
            AccountC accountC_ = null;
            if (mDeviceStatus.ContainsKey(nDeviceType))
            {
                accountC_ = new AccountC();
                accountC_.m_tAccountId = mAccountId;
                accountC_.m_tTicks = mTicks;
                DeviceStatus deviceStatus_ = mDeviceStatus[nDeviceType];
                accountC_.m_tDeviceId = deviceStatus_._getId();
            }
            return accountC_;
        }

        public void _addDeviceType(uint nDeviceType)
        {
            DeviceStatus deviceStatus_ = new DeviceStatus();
            deviceStatus_._setType(nDeviceType);
            deviceStatus_._setId(_deviceId());
            mDeviceStatus[nDeviceType] = deviceStatus_;
        }

        public ErrorCode_ _logout(uint nDeviceId, uint nDeviceType)
        {
            ErrorCode_ result_ = ErrorCode_.mSucess_;
            DeviceStatus deviceStatus_ = this._getDeviceStatus(nDeviceType);
            if (null == deviceStatus_)
            {
                result_ = ErrorCode_.mDeviceType_;
            }
            if (deviceStatus_._getId() != nDeviceId)
            {
                result_ = ErrorCode_.mDeviceId_;
            }
            if (ErrorCode_.mSucess_ == result_)
            {
                mDeviceStatus.Remove(nDeviceType);
            }
            return result_;
        }

        DeviceStatus _getDeviceStatus(uint nDeviceType)
        {
            DeviceStatus result_ = null;
            if (mDeviceStatus.ContainsKey(nDeviceType))
            {
                result_ = mDeviceStatus[nDeviceType];
            }
            return result_;
        }

        uint _deviceId()
        {
            Random random_ = new Random();
            uint offset_ = (uint)random_.Next(0, 0x400);
            return HashString._runHash(@"account", offset_);
        }

        public void _setTicks(long nTicks)
        {
            mTicks = nTicks;
        }

        public long _getTicks()
        {
            return mTicks;
        }

        public void _setAccountId(uint nAccountId)
        {
            mAccountId = nAccountId;
        }

        public uint _getAccountId()
        {
            return mAccountId;
        }

        public Account()
        {
            mDeviceStatus = new Dictionary<uint, DeviceStatus>();
            mAccountId = 0;
            mTicks = 0;
        }

        Dictionary<uint, DeviceStatus> mDeviceStatus;
        uint mAccountId;
        long mTicks;
    }
}
