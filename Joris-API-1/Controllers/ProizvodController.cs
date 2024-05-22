using Joris_API_1.DTOs;
using Joris_API_1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Joris_API_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private static IProizvodRepository proizvodRepos;

        public ProizvodController(IProizvodRepository repository)
        {
            proizvodRepos = repository;
        }

        [HttpGet("svi-proizvodi")]
        public List<Proizvod> GetProizvodi()
        {
            return proizvodRepos.GetProizvodi();
        }

        [HttpGet("detalji-proizvoda/{id}")]
        public void DetaljiProzivoda(int id)
        {
            proizvodRepos.DetaljiProizvoda(id);
        }

        [HttpPost("novi-proizvod")]
        public void DodajNovi([FromBody] Proizvod novi)
        {
            proizvodRepos.DodajNovi(novi);
        }

        [HttpPut("azuriraj-proizvod/{id}")]
        public void AzurirajPostojeci(int id, [FromBody] Proizvod novi)
        {
            proizvodRepos.AzurirajPostojeci(id, novi);
        }

        [HttpDelete("obrisi-proizvod/{id}")]
        public void ObrisiProizvod(int id)
        {
            proizvodRepos.ObrisiProizvod(id);
        }
    }
}
