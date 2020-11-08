using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test3203.Services
{
    public interface IDatabaseSettings
    {
        string DevicesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
