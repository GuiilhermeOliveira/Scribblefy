using Scribblefy.Models;
using Scribblefy.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scribblefy.Repositories
{
    public class LocalizacaoRepository : ILocalizacaoRepository
    {

        private ScribblefyContext _context;

        public LocalizacaoRepository(ScribblefyContext context)
        {
            _context = context;
        }

        public Localizacao Buscar(int codigo)
        {
            return _context.Localizacaos.Find(codigo);
        }

        public IList<Localizacao> ListarLocalizacao()
        {
            return _context.Localizacaos.ToList();
        }

        public void Cadastrar(Localizacao localizacao)
        {
            _context.Localizacaos.Add(localizacao);
        }

        public void Remover(int codigo)
        {
            _context.Localizacaos.Remove(_context.Localizacaos.Find(codigo));
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
