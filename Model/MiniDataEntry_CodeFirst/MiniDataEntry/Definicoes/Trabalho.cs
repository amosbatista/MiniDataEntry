using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmosBatista.MiniDataEntry.Model
{
    public class Trabalho
    {
        private int _id;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get { return _id; }
            //set { _id = value; }
        }
        private string _dataCriacao;
        [Timestamp]
        public string DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = value; }
        }
        private List<Documento> _listaDocumentos;
        internal List<Documento> ListaDocumentos
        {
            get { return _listaDocumentos; }
            set { _listaDocumentos = value; }
        }
    }
}
