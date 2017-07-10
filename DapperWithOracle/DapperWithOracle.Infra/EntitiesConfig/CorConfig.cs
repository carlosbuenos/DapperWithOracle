using DapperWithOracle.Domain.Entities;
using System;

namespace DapperWithOracle.Infra.EntitiesConfig
{
    public class CorConfig
    {
        public static Cor Map(dynamic value)
        {
            var cor = new Cor();
            cor.Id = Convert.ToInt64(value.CD_COR);
            cor.Descricao = value.DS_COR;
            cor.Usuario = value.NM_USUARIO;
            cor.DataAlteracao = Convert.ToDateTime(value.DT_ATUALIZACAO);

            return cor;
        }
    }
}