using DapperWithOracle.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DapperWithOracle.Domain.Interfaces.Repository
{
    public interface ICorRepository : IDisposable
    {
        List<Cor> BuscarTudo();
    }
}