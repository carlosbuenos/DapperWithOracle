using DapperWithOracle.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using DapperWithOracle.Domain.Entities;
using Oracle.ManagedDataAccess.Client;
using Dapper;
using System.Linq;
using DapperWithOracle.Infra.Context;
using DapperWithOracle.Infra.EntitiesConfig;

namespace DapperWithOracle.Infra.Repositories
{
    public class CorRepository : ICorRepository
    {
        private readonly OracleConnection _conn = OracleContext.GetConnection();

        public List<Cor> BuscarTudo()
        {
            var list = _conn.Query<dynamic>("SELECT * FROM COR").ToList();
            List<Cor> lista = new List<Cor>();

            list.ForEach(x => lista.Add(CorConfig.Map(x)));

            return lista;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}