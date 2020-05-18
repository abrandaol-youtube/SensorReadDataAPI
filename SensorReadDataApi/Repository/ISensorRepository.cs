using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorReadDataApi.Domain;

namespace SensorReadDataApi.Repository
{
    public interface ISensorRepository
    {
        public IEnumerable<Sensor> ListAll();

        public int Insert(long step);
    }
}
