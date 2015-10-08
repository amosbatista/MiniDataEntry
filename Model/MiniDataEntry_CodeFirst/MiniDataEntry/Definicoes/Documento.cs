using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmosBatista.MiniDataEntry.Model
{
    public class Documento
    {
        private int _id;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return _id; }
            //set { _id = value; }
        }
        private List<IndexacaoCampo> _indexacaoCampos;
        internal List<IndexacaoCampo> IndexacaoCampos
        {
            get { return _indexacaoCampos; }
            set { _indexacaoCampos = value; }
        }
    }
}
