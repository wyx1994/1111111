using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class TimeString
    {
        /// <summary>
        /// 时间
        /// </summary>
        public string time;
    }

    public class ReadTimeResponse:DeviceResponseHead
    {
        /// <summary>
        /// 时间
        /// </summary>
        public TimeString[] data;
    }

    public class SetTime : DeviceSendHead
    {
        /// <summary>
        /// 时间
        /// </summary>
        public TimeString[] data;
    }
}
