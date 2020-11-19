using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Scribblefy.Models;
using Scribblefy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scribblefy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalizacaoController : ControllerBase
    {
        private ILocalizacaoRepository _repository;

        public LocalizacaoController(ILocalizacaoRepository localizacaoRepository)
        {
            _repository = localizacaoRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Localizacao> Get(int id)
        {
            var usuario = _repository.Buscar(id);
            if (usuario == null)
                return NotFound();
            return usuario;
        }

        [HttpGet("lista")]
       
        public IList<Localizacao> Get()
        {
            return _repository.ListarLocalizacao();
        
        }

        [HttpPost]
        public ActionResult<Localizacao> Post(Localizacao localizacao)
        {
            _repository.Cadastrar(localizacao);
            _repository.Salvar();
            return CreatedAtAction("Get", new { id = localizacao.LocalizacaoId }, localizacao);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            if (_repository.Buscar(id) == null)
                return NotFound();

            _repository.Remover(id);
            _repository.Salvar();
            return NoContent();
        }
    }
}
