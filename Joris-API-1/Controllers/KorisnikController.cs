using Joris_API_1.Models;
using Joris_API_1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Joris_API_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KorisnikController : ControllerBase
    {
        private static IKorisnikRepository korisnikRepos;

        public KorisnikController(IKorisnikRepository repository)
        {
            korisnikRepos = repository;
        }

        [HttpGet("svi-korisnici")]
        public List<Korisnik> SviKorisnici()
        {
            return korisnikRepos.SviKorisnici();
        }

        [HttpGet("korisnik/{id}")]
        public Korisnik korisnikPoID(int id)
        {
            return korisnikRepos.KorisnikPoID(id);
        }

        [HttpPost("novi-korisnik")]
        public void DodajNovog([FromBody] Korisnik novi)
        {
            korisnikRepos.DodajNovog(novi);
        }

        [HttpPut("azuriraj-korisnika/{id}")]
        public void AzuzirajKorisnika([FromBody] Korisnik novi, int id)
        {
            korisnikRepos.AzurirajKorisnika(novi, id);
        }

        [HttpDelete("obrisi-korisnika/{id}")]
        public void ObrisiKorisnika(int id)
        {
            korisnikRepos.ObrisiKorisnika(id);
        }
    }
}
