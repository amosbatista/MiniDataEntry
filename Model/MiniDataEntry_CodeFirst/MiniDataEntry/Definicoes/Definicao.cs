using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmosBatista.MiniDataEntry.Model
{
    public class Definicao
    {
        private int _id;

        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return _id; }
            //set { _id = value; }
        }
        private string _nome;
        [Required]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private List<Campo> _campos;
        public List<Campo> Campos
        {
            get { return _campos; }
            set { _campos = value; }
        }

        public Definicao()
        {
            _campos = new List<Campo>();
        }
    }
}
