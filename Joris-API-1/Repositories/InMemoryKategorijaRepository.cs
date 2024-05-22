using Joris_API_1.DTOs;

namespace Joris_API_1.Repositories
{
    public class InMemoryKategorijaRepository : IKategorijaRepository
    {
        List<Kategorija> kategorije = new List<Kategorija>();
        public void AzurirajPostojecu(int id, Kategorija nova)
        {
            var postoji = kategorije.FirstOrDefault(x => x.id == id);
            if (postoji == null)
            {
                throw new Exception("Ne postoji!");
            }
            postoji.naziv = nova.naziv;
            postoji.listaProizvoda = nova.listaProizvoda;
        }

        public void DetaljiKategorije(int id)
        {
            var kategorija = kategorije.FirstOrDefault(x => x.id == id);
            if (kategorija == null)
            {
                throw new Exception("Ne postoji!");
            }
            Console.WriteLine(kategorija.id + " " + kategorija.naziv + " " + kategorija.listaProizvoda.ToArray());
        }

        public void DodajNovu(Kategorija nova)
        {
            var postoji = kategorije.FirstOrDefault(x => x.id == nova.id);
            if (postoji != null)
            {
                throw new Exception("Postoji!");
            }
            kategorije.Add(nova);
        }


        public List<Kategorija> GetKategorija()
        {
            return kategorije;
        }

        public void ObrisiKategoriju(int id)
        {
            var kategorija= kategorije.FirstOrDefault(x => x.id == id);
            if (kategorija == null)
            {
                throw new Exception("Ne postoji!");
            }
            kategorije.Remove(kategorija);
        }
    }
}
