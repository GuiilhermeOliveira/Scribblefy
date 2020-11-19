using Scribblefy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scribblefy.Repositories
{
    public interface ILocalizacaoRepository
    {
        Localizacao Buscar(int codigo);
        void Cadastrar(Localizacao localizacao);
        void Remover(int codigo);
        IList<Localizacao> ListarLocalizacao();
        void Salvar();
    }
}
