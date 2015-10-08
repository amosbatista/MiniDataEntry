using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmosBatista.MiniDataEntry.Model
{
    public class IndexacaoCampo
    {
        private Campo _campo;

        // TODO: Se ocorrer erro em trazer uma classe inteira, utilizar chave estrangeira com o atributo ForeignKeyAttribute 
        [Required]
        internal Campo Campo
        {
            get { return _campo; }
            set { _campo = value; }
        }
        private string _valor;

        [StringLength(50)]
        [Required]
        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
    }
}
