using Joris_API_1.DTOs;

namespace Joris_API_1.Repositories
{
    public class InMemoryProizvodRepository : IProizvodRepository
    {
        List <Proizvod> proizvodi = new List <Proizvod> ();
        public void AzurirajPostojeci(int id, Proizvod novi)
        {
            var postoji = proizvodi.FirstOrDefault(x => x.id == id);
            if (postoji == null) {
                throw new Exception("Ne postoji!");
            }
            postoji.naziv = novi.naziv;
            postoji.cena = novi.cena;
            postoji.opis = novi.opis;
            postoji.idKategorije = novi.idKategorije;
        }

        public void DetaljiProizvoda(int id)
        {
            var proizvod = proizvodi.FirstOrDefault(x=>x.id == id);
            if (proizvod == null)
            {
                throw new Exception("Ne postoji!");
            }
            Console.WriteLine(proizvod.id +" "+ proizvod.naziv + " " +proizvod.cena + " " + proizvod.opis + " " + proizvod.idKategorije);
        }

        public void DodajNovi(Proizvod novi)
        {
            var postoji = proizvodi.FirstOrDefault(x => x.id == novi.id);
            if (postoji != null)
            {
                throw new Exception("Postoji!");
            }
            proizvodi.Add(novi);
        }

        public List<Proizvod> GetProizvodi()
        {
            return proizvodi;
        }

        public void ObrisiProizvod(int id)
        {
            var proizvod = proizvodi.FirstOrDefault(x => x.id == id);
            if (proizvod == null)
            {
                throw new Exception("Ne postoji!");
            }
            proizvodi.Remove(proizvod);
        }
    }
}
