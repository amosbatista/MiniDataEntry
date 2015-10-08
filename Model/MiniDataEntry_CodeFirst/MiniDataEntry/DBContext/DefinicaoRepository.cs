using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AmosBatista.MiniDataEntry.Model
{
    public class DefinicaoRepository
    {

        public void Salvar(Definicao definicao)
        {
            var dataEntryContext = new DataEntryContext();
            dataEntryContext.DefinicaoSet.Add(definicao);
            dataEntryContext.SaveChanges();
        }
    }
}
