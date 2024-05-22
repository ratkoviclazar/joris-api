using Joris_API_1.Models;

namespace Joris_API_1.Repositories
{
    public interface IKorisnikRepository
    {

        public List<Korisnik> SviKorisnici();
        public Korisnik KorisnikPoID(int id);
        public void AzurirajKorisnika(Korisnik korisnik, int id);
        public void DodajNovog(Korisnik novi);
        public void ObrisiKorisnika(int id);

    }
}
