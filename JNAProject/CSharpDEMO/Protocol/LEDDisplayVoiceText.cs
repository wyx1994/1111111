using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class LEDDisplayVoiceText
    {
        /// <summary>
        /// 文本串
        /// </summary>
        public string text;   
    }

    public class TextSend:DeviceSendHead
    {
        /// <summary>
        /// 文本串
        /// </summary>
        public LEDDisplayVoiceText[] data;
    }
}
