namespace Joris_API_1.DTOs
{
    public class Kategorija
    {
        public int id { get; set; }
        public string naziv {  get; set; }
        public List<Proizvod> listaProizvoda { get; set; }
    }
}
