using System;
using System.ComponentModel;

namespace DapperWithOracle.Domain.Entities
{
    public class Cor
    {
        public long Id { get; set; }
        
        [AmbientValue("DS_COR")]
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