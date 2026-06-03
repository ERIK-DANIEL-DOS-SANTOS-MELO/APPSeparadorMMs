using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSeparadorMMs.Core
{
    public static class DeviceCommandNames
    {
        public const string IsRunning = "IsRunning";
        public const string Start = "Start";
        public const string Stop = "Stop";
        public const string ResetCounters = "ResetCounters";

        public const string Ping = "Ping";

        public const string GetThreshold = "GetThreshold";
        public const string SetThreshold = "SetThreshold";
        public const string GetInterval = "GetInterval";
        public const string SetInterval = "SetInterval";
    }
}
