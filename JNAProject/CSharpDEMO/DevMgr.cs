using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtocolContext;

namespace DEMO
{
    public class DevMgr
    {
        /// <summary>
        /// 设备信息列表
        /// </summary>
        public List<DeviceInfo> lstDevs;
        /// <summary>
        /// 设备参数信息列表
        /// </summary>
        public List<Parameter> lstParam;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DevMgr()
        {
            lstDevs = new List<DeviceInfo>();
            lstParam = new List<Parameter>();
        }

        /// <summary>
        /// 增加设备信息
        /// </summary>
        public void AddDevice(DeviceInfo info)
        {
            int iIndex = lstDevs.FindIndex((o) => o.deviceID == info.deviceID);
            if(iIndex >= 0)
            {
                lstDevs[iIndex] = info;
            }
            else
            {
                lstDevs.Add(info);
            }
        }

        /// <summary>
        /// 增加设备参数信息
        /// </summary>
        public void AddDeviceParameter(Parameter info)
        {
            int iIndex = lstParam.FindIndex((o) => o.deviceID == info.deviceID);
            if (iIndex >= 0)
            {
                lstParam[iIndex] = info;
            }
            else
            {
                lstParam.Add(info);
            }
        }

        /// <summary>
        /// 查找设备信息
        /// </summary>
        public DeviceInfo FindDeviceInfo(string deviceID)
        {
            return lstDevs.Find((o) => o.deviceID == deviceID);
        }



    }
}
