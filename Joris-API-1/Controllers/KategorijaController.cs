using Joris_API_1.DTOs;
using Joris_API_1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Joris_API_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategorijaController : ControllerBase
    {
        private static IKategorijaRepository kategorijaRepos;

        public KategorijaController(IKategorijaRepository repository)
        {
            kategorijaRepos = repository;
        }

        [HttpGet("sve-kategorije")]
        public List<Kategorija> GetKategorija()
        {
            return kategorijaRepos.GetKategorija();
        }

        [HttpGet("detalji-kategorije/{id}")]
        public void DetaljiKategorije(int id)
        {
            kategorijaRepos.DetaljiKategorije(id);
        }

        [HttpPost("nova-kategorija")]
        public void DodajNovu([FromBody] Kategorija nova)
        {
            kategorijaRepos.DodajNovu(nova);
        }

        [HttpPut("azuriraj-kategoriju/{id}")]
        public void AzurirajPostojecu(int id, [FromBody] Kategorija nova)
        {
            kategorijaRepos.AzurirajPostojecu(id, nova);
        }

        [HttpDelete("obrisi-kategoriju/{id}")]
        public void ObrisiKategorija(int id)
        {
            kategorijaRepos.ObrisiKategoriju(id);
        }
    }
}
