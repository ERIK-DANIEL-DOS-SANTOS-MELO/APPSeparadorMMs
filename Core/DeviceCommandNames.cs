using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSeparadorMMs.Core
{
    public static class DeviceCommandNames
    {
        public const string Start = "Start";
        public const string Stop = "Stop";
        public const string ResetCounters = "ResetCounters";

        public const string Ping = "Ping";
        public const string GetConfig = "GetConfig";
        public const string SaveConfig = "SaveConfig";

        public const string SetThreshold = "SetThreshold";
        public const string SetSamplingInterval = "SetSamplingInterval";
    }
}
