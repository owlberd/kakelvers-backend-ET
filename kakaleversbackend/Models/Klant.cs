using System;
using System.Collections.Generic;

namespace kakaleversbackend.Models
{
    public partial class Klant
    {
        public int Id { get; set; }
        public string? Naam { get; set; }
        public string? Achternaam { get; set; }
        public string? Email { get; set; }
        public string? Telefoon { get; set; }
        public string? LidSinds { get; set; }
    }
}
