using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test3203.Services
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string DevicesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
