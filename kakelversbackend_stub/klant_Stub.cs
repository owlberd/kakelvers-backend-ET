using Interface;
using kakaleversbackend.Models;

namespace kakelversbackend_stub
{
    public class klant_Stub
    {
        List<klant_DTO> klanten { get; set; }
        public klant_Stub()
        {
            this.klanten = new List<klant_DTO>()
            {
                new klant_DTO(){Id =1, Naam = "Hugo", Achternaam = "Abelen", Email = "hugo@gmail.com", LidSinds= "22-2-12", Telefoon = "0612345"},
                new klant_DTO(){Id =2, Naam = "Jeroen", Achternaam = "Abelen", Email = "hugo@gmail.com", LidSinds= "6-11-1", Telefoon = "06234"}
            };
        }

        public List<klant_DTO> GetKlants()
        {
            return klanten;
        }

        public klant_DTO GetKlant(int id)
        {
            klant_DTO klant = new klant_DTO();

            for (int i = 0; i < klanten.Count(); i++)
            {
                if (klanten[i].Id == id)
                {
                    klant = new klant_DTO() { Id = klanten[i].Id, Naam = klanten[i].Naam, Achternaam = klanten[i].Achternaam, Email = klanten[i].Email, Telefoon = klanten[i].Telefoon, LidSinds = klanten[i].LidSinds };
                }
            }
            return klant;
        }

        public void PutKlant(int id, klant_DTO klant)
        {
            for (int i = 0; i < klanten.Count(); i++)
            {
                if (klanten[i].Id == id)
                {
                    klanten[i].Id = klant.Id;
                    klanten[i].Naam = klant.Naam;
                    klanten[i].Achternaam = klant.Achternaam;
                    klanten[i].LidSinds = klant.LidSinds;
                    klanten[i].Email = klant.Email;
                    klanten[i].Telefoon = klant.Telefoon;
                }
            }
        }

        public void PostKlant(klant_DTO klant)
        {
            this.klanten.Add(klant);
        }


    }
}