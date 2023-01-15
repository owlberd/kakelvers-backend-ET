using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface;
using kakaleversbackend.Models;

namespace kakelversbackend_stub
{
    public class producten_Stub
    {
        List<product_DTO> producten { get; set; }
        public producten_Stub()
        {
            this.producten = new List<product_DTO>()
            {
                new product_DTO(){Id = 1, Ean = 111, Eenheid = "Gr", LeverancierId= 1, MassaVolume= "500", ProductNaam = "rundvlees", ProductId= 222, ProductOmschrijving="vers rundvlees", Voedingswaarde="?", Voorraad=100},
                new product_DTO(){Id = 2, Ean = 121, Eenheid = "L", LeverancierId= 2, MassaVolume= "1", ProductNaam = "Melk", ProductId= 11, ProductOmschrijving="verse melk", Voedingswaarde="?", Voorraad=100}
            };
        }

        public List<product_DTO> GetProductens()
        {
            return producten;
        }

        public product_DTO GetprudGetProducten(int id)
        {
            product_DTO product = new product_DTO();

            for (int i = 0; i < producten.Count(); i++)
            {
                if (producten[i].Id == id)
                {
                    product = new product_DTO() 
                    { 
                        Id = producten[i].Id, 
                        Ean = producten[i].Ean, 
                        Eenheid = producten[i].Eenheid, 
                        LeverancierId = producten[i].LeverancierId, 
                        MassaVolume = producten[i].MassaVolume, 
                        ProductNaam = producten[i].ProductNaam, 
                        ProductId = producten[i].ProductId, 
                        ProductOmschrijving = producten[i].ProductOmschrijving, 
                        Voedingswaarde = producten[i].Voedingswaarde, 
                        Voorraad = producten[i].Voorraad 
                    };
                }
            }
            return product;
        }

        public void PutProducten(product_DTO product)
        {
            for (int i = 0; i < producten.Count(); i++)
            {
                if (producten[i].Id == product.Id)
                {
                    producten[i].ProductNaam = product.ProductNaam;
                    producten[i].Ean = product.Ean;
                    producten[i].Eenheid = product.Eenheid;
                    producten[i].LeverancierId = product.LeverancierId;
                    producten[i].MassaVolume = product.MassaVolume;
                    producten[i].ProductId = product.ProductId;
                    producten[i].ProductOmschrijving = product.ProductOmschrijving;
                    producten[i].Voedingswaarde = product.Voedingswaarde;
                    producten[i].Voorraad = product.Voorraad;
                
                }
            }
        }

        public void DeleteProducten(product_DTO product)
        {
            for (int i = 0; i < producten.Count(); i++)
            {
                if (producten[i].Id == product.Id)
                {
                    producten.Remove(producten[i]);
                }
            }
        }

        public void PostProducten(product_DTO product)
        {
            this.producten.Add(product);
        }

    }
}
