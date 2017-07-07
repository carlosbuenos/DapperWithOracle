using System;

namespace DapperWithOracle.Domain.Entities
{
    public class Cor
    {
        public string Descricao { get; set; }
        public string Usuario { get; set; }
        public DateTime DataAlteracao { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Descricao.Trim()))
                return false;

            if (string.IsNullOrEmpty(Usuario.Trim()))
                return false;

            return true;
        }
    }
}