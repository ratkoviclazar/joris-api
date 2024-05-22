using Joris_API_1.DTOs;

namespace Joris_API_1.Repositories
{
    public interface IProizvodRepository
    {
        public List<Proizvod> GetProizvodi();
        public void DetaljiProizvoda(int id);
        public void DodajNovi(Proizvod novi);
        public void AzurirajPostojeci(int id, Proizvod novi);
        public void ObrisiProizvod(int id);

    }
    public interface IKategorijaRepository
    {
        public List<Kategorija> GetKategorija();
        public void DetaljiKategorije(int id);
        public void DodajNovu(Kategorija nova);
        public void AzurirajPostojecu(int id, Kategorija nova);
        public void ObrisiKategoriju(int id);

    }
}
