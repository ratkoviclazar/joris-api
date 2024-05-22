namespace Joris_API_1.DTOs
{
    public class Proizvod
    {
        public int id {  get; set; }
        public string naziv {  get; set; }
        public string opis {  get; set; }
        public decimal cena { get; set; }
        public int idKategorije { get; set; }
    }
}
