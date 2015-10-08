using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AmosBatista.MiniDataEntry.Model
{
    public class Campo
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

        [StringLength(50)]
        [Required]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
    }
}
