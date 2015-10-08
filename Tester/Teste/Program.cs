using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmosBatista.MiniDataEntry.Control;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var controladorDefinicao = new DefinicaoController();
            controladorDefinicao.NovoCampo("Nome");
            controladorDefinicao.NovoCampo("RG");
            controladorDefinicao.NovoCampo("CPF");
            controladorDefinicao.SalvarDefinicao();

        }
    }
}
