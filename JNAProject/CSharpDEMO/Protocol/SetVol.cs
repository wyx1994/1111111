using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
     public class SetVol
    {
        /// <summary>
        ///音量时段个数
        /// </summary>
        public int levelCount;
         /// <summary>
        ///音量时段级别
        /// </summary>
	    public VolLevel[] level;
         /// <summary>
        ///非设定时段声音级别
        /// </summary>
        public int defualtLevel; 
    }

    public class SetVolSend:DeviceSendHead
    {
        /// <summary>
        ///音量时段级别
        /// </summary>
        public SetVol[] data;
    }
}
