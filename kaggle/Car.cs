using System;
using System.Collections.Generic;
using System.Text;

namespace kaggle
{
    public class Car
    {
        public int Id { get; set; }
        public int Price { get; set; }

        public string PriceCHF { get { return $"{Price} CHF"; } }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string TitleStatus { get; set; }
        public float Mileage { get; set; }
        public string Color { get; set; }

        public string GetInfos()
        {
            return $"Id : {Id} - Marque : {Brand} - Année : {Year} - Prix : {PriceCHF}";
        }
        public string Vin { get; set; }
        public string Lot { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Condition { get; set; }

        public Car(string ligne) { 
            string[] maLigne = ligne.Split(',');
            Id = int.Parse(maLigne[0]);
            Price = int.Parse(maLigne[1]);
            Brand = maLigne[2];
            Model = maLigne[3];
            int year = 0;
            Year = int.TryParse(maLigne[4], out year) ? year : -1;
            TitleStatus = maLigne[5];
            Mileage = float.Parse(maLigne[6]);
            Color = maLigne[7];
            Vin = maLigne[8];
            Lot = maLigne[9];
            State = maLigne[10];
            Country = maLigne[11];
            Condition = maLigne[12];
        } 

    }
}
