using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test3203.ModelLayer;

namespace Test3203.Services
{
    public interface IRegisterDevice
    {
        bool Register(BaseDevice device);
    }
}
