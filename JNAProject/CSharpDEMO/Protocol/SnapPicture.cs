using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolContext
{
    public class SnapPicture
    {
        /// <summary>
        /// 文件在服务器上面的路径
        /// </summary>
        public string imageID;   
    }

    public class SnapPictureResponse:DeviceResponseHead
    {
        /// <summary>
        /// 文件在服务器上面的路径
        /// </summary>
        public SnapPicture[] data;
    }
}
