using csharp_boolflix.Models;

namespace csharp_boolflix.Data
{
    public class FormSerie
    {
        public Serie Serie { get; set; }
        public List<Caratteristica>? Caratteristiche { get; set; }
        public List<Genere>? Generi { get; set; }
        public List<Attore>? Attori { get; set; }
        public List<Regia>? Registi { get; set; }
    }
}
