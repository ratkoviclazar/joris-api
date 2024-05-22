using Joris_API_1.Models;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Joris_API_1.Repositories
{
    public class InMemoryKorisnikRepository : IKorisnikRepository
    {
        List<Korisnik> korisnici = new List<Korisnik>()
        {
            new Korisnik()
            {
                id = 0,
                imePrezime = "Petar Petrovic",
                email = "petar@gmail.com",
                godine = 20
            },
            new Korisnik()
            {
                id = 1,
                imePrezime = "Marko Markovic",
                email = "marko@gmail.com",
                godine = 25
            }
        };

        public List<Korisnik> SviKorisnici()
        {
            return korisnici;
        }

        public Korisnik KorisnikPoID(int id)
        {
            var korisnikId = korisnici.FirstOrDefault(x => x.id == id);
            if (korisnikId == null)
            {
                throw new Exception("Dati korisnik ne postoji!");
            }
            return korisnikId;
        }

        public void DodajNovog(Korisnik novi)
        {
            var postoji = korisnici.FirstOrDefault(x => x.id == novi.id);
            if (postoji != null)
            {
                throw new Exception("Dati korisnik vec postoji!");
            }
                korisnici.Add(novi);
        }
        
        public void AzurirajKorisnika(Korisnik novi, int id)
        {
            var postoji = korisnici.FirstOrDefault(x => x.id == id);
            if(postoji == null)
            {
                throw new Exception("Dati korisnik ne postoji!");
            }
            postoji.imePrezime = novi.imePrezime;
            postoji.email = novi.email;
            postoji.godine = novi.godine;
        }

        public void ObrisiKorisnika(int id)
        {
            var trazeni = korisnici.FirstOrDefault(x => x.id == id);

            if(trazeni == null)
            {
                throw new Exception("Dati korisnik vec postoji!");
            }

            korisnici.Remove(trazeni);
        }
    }
}
