using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesieMobile.Model
{
    public class LogEntity
    {
        public DateTime LogTimeUtc { get; set; }
        public DateTime LogTimeLocal { get { return LogTimeUtc.ToLocalTime(); } }
        public string CallingMethod { get; set; }
        public string Message { get; set; }
        public bool IsError { get; set; }

        public bool IsNotError => !IsError;
    }
}
