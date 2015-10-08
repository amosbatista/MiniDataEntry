using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace AmosBatista.MiniDataEntry.Model
{
    public class DataEntryContext:DbContext
    {
        // Lista de Entidades (tabelas) à serem salvas
        private DbSet<Campo> _campoSet;
        private DbSet<Definicao> _definicaoSet;

        public DbSet<Definicao> DefinicaoSet
        {
            get { return _definicaoSet; }
            set { _definicaoSet = value; }
        }
        private DbSet<Documento> _documentoSet;
        private DbSet<IndexacaoCampo> _indexacaoCampoSet;
        private DbSet<Trabalho> _trabalhoSet;

        // Criar ou abrir banco com a string de conexão configurada
        public DataEntryContext():base("SistemplanEntities")
        {

        }


    }
}
