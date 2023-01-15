using Interface;
using kakelversbackend_stub;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_kakelversbackend
{
    [TestClass]
    public class ProductTest
    {

        [TestMethod]
        public void GetProducten()
        {
            //Arrange
            int controle = 2;
            int totaal;
            producten_Stub productstub = new producten_Stub();

            //Act
            totaal = productstub.GetProductens().Count();

            //Assert
            Assert.AreEqual(controle, totaal);
        }

        [TestMethod]
        public void GetProducten_By_ID()
        {
            //Arrange
            producten_Stub productstub = new producten_Stub();
            product_DTO producten;
            product_DTO product = new product_DTO() { Id = 2, Ean = 121, Eenheid = "L", LeverancierId = 2, MassaVolume = "1", ProductNaam = "Melk", ProductId = 11, ProductOmschrijving = "verse melk", Voedingswaarde = "?", Voorraad = 100 };

            //Act
            producten = productstub.GetprudGetProducten(product.Id);

            //Assert
            Assert.AreEqual(product.Id, producten.Id);
            Assert.AreEqual(product.Ean, producten.Ean);
            Assert.AreEqual(product.Eenheid, producten.Eenheid);
            Assert.AreEqual(product.LeverancierId, producten.LeverancierId);
            Assert.AreEqual(product.MassaVolume, producten.MassaVolume);
            Assert.AreEqual(product.ProductNaam, producten.ProductNaam);
            Assert.AreEqual(product.ProductOmschrijving, producten.ProductOmschrijving);
            Assert.AreEqual(product.ProductId, producten.ProductId);
            Assert.AreEqual(product.Voedingswaarde, producten.Voedingswaarde);
            Assert.AreEqual(product.Voorraad, producten.Voorraad);
        }

        [TestMethod]
        public void PutProducten()
        {
            //Arrange
            producten_Stub productstub = new producten_Stub();
            product_DTO producten;
            product_DTO product = new product_DTO() { Id = 2, Ean = 666, Eenheid = "Kg", LeverancierId = 2, MassaVolume = "1", ProductNaam = "Kaas", ProductId = 99, ProductOmschrijving = "verse kaas", Voedingswaarde = "?", Voorraad = 999 };

            //Act
            productstub.PutProducten(product);
            producten = productstub.GetprudGetProducten(product.Id);
            //Assert
            Assert.AreEqual(product.Id, producten.Id);
            Assert.AreEqual(product.Ean, producten.Ean);
            Assert.AreEqual(product.Eenheid, producten.Eenheid);
            Assert.AreEqual(product.LeverancierId, producten.LeverancierId);
            Assert.AreEqual(product.MassaVolume, producten.MassaVolume);
            Assert.AreEqual(product.ProductNaam, producten.ProductNaam);
            Assert.AreEqual(product.ProductOmschrijving, producten.ProductOmschrijving);
            Assert.AreEqual(product.ProductId, producten.ProductId);
            Assert.AreEqual(product.Voedingswaarde, producten.Voedingswaarde);
            Assert.AreEqual(product.Voorraad, producten.Voorraad);
        }

        [TestMethod]
        public void DeleteProducten()
        {
            //Arrange
            producten_Stub productstub = new producten_Stub();
            int teller;
            int controlle = 1;
             product_DTO product = new product_DTO() { Id = 2, Ean = 666, Eenheid = "Kg", LeverancierId = 2, MassaVolume = "1", ProductNaam = "Kaas", ProductId = 99, ProductOmschrijving = "verse kaas", Voedingswaarde = "?", Voorraad = 999 };

            //Act
            productstub.DeleteProducten(product);
            teller = productstub.GetProductens().Count();


            //Assert
            Assert.AreEqual(controlle, teller);
        }

        [TestMethod]
        public void PostProducten()
        {
            //Arrange
            producten_Stub productstub = new producten_Stub();
            int teller;
            int controlle = 3;
            product_DTO product = new product_DTO() { Id = 3, Ean = 777, Eenheid = "Kg", LeverancierId = 2, MassaVolume = "1", ProductNaam = "ui", ProductId = 995, ProductOmschrijving = "verse ui", Voedingswaarde = "?", Voorraad = 999 };

            //Act
            productstub.PostProducten(product);
            teller = productstub.GetProductens().Count();


            //Assert
            Assert.AreEqual(controlle, teller);
        }
    }   
}
