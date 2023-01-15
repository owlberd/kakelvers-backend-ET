using Interface;
using kakelversbackend_stub;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestProject_kakelversbackend
{
    [TestClass]
    public class KlantTest
    {
        [TestMethod]
        public void GetKlants()
        {
            //Arrange
            int controle = 2;
            int totaal;
            klant_Stub klantstub = new klant_Stub();

            //Act
            totaal = klantstub.GetKlants().Count();

            //Assert
            Assert.AreEqual(controle, totaal);
        }


        [TestMethod]
        public void GetKlants_By_ID()
        {
            //Arrange
            klant_Stub klantstub = new klant_Stub();
            klant_DTO klanten;
            klant_DTO klant = new klant_DTO() { Id = 2, Naam = "Jeroen", Achternaam = "Abelen", Email = "hugo@gmail.com", LidSinds = "6-11-1", Telefoon = "06234" };

            //Act
            klanten = klantstub.GetKlant(klant.Id);

            //Assert
            Assert.AreEqual(klant.Id, klanten.Id);
            Assert.AreEqual(klant.Naam, klanten.Naam);
            Assert.AreEqual(klant.Achternaam, klanten.Achternaam);
            Assert.AreEqual(klant.Email, klanten.Email);
            Assert.AreEqual(klant.Telefoon, klanten.Telefoon);
            Assert.AreEqual(klant.LidSinds, klanten.LidSinds);
        }


        [TestMethod]
        public void PostProducten()
        {
            //Arrange
            klant_Stub klantstub = new klant_Stub();
            int teller;
            int controlle = 3;
            klant_DTO klant = new klant_DTO() { Id = 3, Naam = "peter", Achternaam = "Aarts", Email = "peter@gmail.com", LidSinds = "11-11-11", Telefoon = "6666666" };

            //Act
            klantstub.PostKlant(klant);
            teller = klantstub.GetKlants().Count();


            //Assert
            Assert.AreEqual(controlle, teller);
        }
    }
}