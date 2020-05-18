using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorReadDataApi.Domain
{
    public sealed class Sensor
    {
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public long Step { get; set; }
    }
}
