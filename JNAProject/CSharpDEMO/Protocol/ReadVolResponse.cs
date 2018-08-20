using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class ReadVolResponse:DeviceResponseHead
    {
        /// <summary>
        ///音量时段级别
        /// </summary>
        public SetVol[] data;
    }
}
