using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test3203.ModelLayer;

namespace Test3203.Services
{
    public class RegisterDevice : IRegisterDevice
    {
        private readonly IMongoCollection<BaseDevice> _devices;

        public RegisterDevice(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _devices = database.GetCollection<BaseDevice>(settings.DevicesCollectionName);
        }
        public bool Register(BaseDevice device)
        {
            if (_devices.Find(d=>d.Equals(device)).Any())
            {
                return false;
            }
            else
            {
                try
                {
                    _devices.InsertOne(device);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
