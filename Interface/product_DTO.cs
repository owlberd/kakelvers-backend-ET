using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class product_DTO
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string? ProductNaam { get; set; }
        public string? ProductOmschrijving { get; set; }
        public string? Eenheid { get; set; }
        public string? MassaVolume { get; set; }
        public string? Voedingswaarde { get; set; }
        public int? Ean { get; set; }
        public int? Voorraad { get; set; }
        public int? LeverancierId { get; set; }
    }
}
