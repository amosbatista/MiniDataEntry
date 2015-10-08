using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmosBatista.MiniDataEntry.Model;
using System.Runtime.Serialization.Json;



namespace AmosBatista.MiniDataEntry.Control
{
    public class DefinicaoController
    {
        private Definicao _definicao;

        public DefinicaoController()
        {
            _definicao = new Definicao();
        }

        public void NovoCampo(string nome)
        {
            var campo = new Campo();
            campo.Nome = nome;
            _definicao.Campos.Add(campo);
        }
        
        public void SalvarDefinicao()
        {
            var definicaoRepository = new DefinicaoRepository();
            definicaoRepository.Salvar(_definicao);
        }
    }
}
