using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesieMobile.Model
{
    public class ActivityEntity
    {
        public string ActivityID { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        private DateTime modifiedAt;
        public DateTime ModifiedAt
        {
            get
            {
                if (modifiedAt == DateTime.MinValue)
                    return CreatedAt;

                return modifiedAt;
            }
            set { modifiedAt = value; }
        }

        public bool IsSynchronized { get; set; }
        public bool Deleted { get; set; }

        public string DeviceID { get; set; }
        public string DeviceName { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsPinned { get; set; }


    }
}
