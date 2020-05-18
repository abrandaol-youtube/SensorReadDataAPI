using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using SensorReadDataApi.Domain;

namespace SensorReadDataApi.Repository
{
    public sealed class SensorRepository : ISensorRepository
    {
        private readonly string _connectionString;

        public SensorRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SensorDataServer");
        }

        public IEnumerable<Sensor> ListAll()
        {
            using var connection = new SqlConnection(_connectionString);

            var sensorData = connection.Query<Sensor>("select * from sensor");

            return sensorData;
        }

        public int Insert(long step)
        {
            using var connection = new SqlConnection(_connectionString);

            var query = "insert into sensor (step)values (@step)";

            var result = connection.Execute(query, new { step = step });

            return result;
        }
    }
}

