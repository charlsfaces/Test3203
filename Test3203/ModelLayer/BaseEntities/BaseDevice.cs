using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test3203.ModelLayer
{
    public class BaseDevice : IBaseDevice
    {
        /// <summary>
        /// Unique identificator of the object
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        /// <summary>
        /// Identificative model serial number
        /// </summary>
        [Required]
        public string SerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// Firmware version number
        /// </summary>        
        public double FirmwareVersion { get; set; }

        /// <summary>
        /// Current status of the device
        /// </summary>
        public bool Status { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is BaseDevice device)
            {
                return this.SerialNumber.Equals(device.SerialNumber) && this.FirmwareVersion.Equals(device.FirmwareVersion); 
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this);
        }
    }
}
