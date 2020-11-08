using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test3203.ModelLayer
{
    public interface IBaseDevice
    {
        int Id { get; set; }
        string SerialNumber { get; set; }
        double FirmwareVersion { get; set; }
        bool Status { get; set; }
    }
}
