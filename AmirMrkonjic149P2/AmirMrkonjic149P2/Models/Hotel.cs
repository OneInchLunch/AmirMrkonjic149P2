using System;
using System.Collections.Generic;
using System.Text;

namespace AmirMrkonjic149P2.Models
{
    public class Hotel
    {
        public string Id { get; set; }
        public string Naziv { get; set; }
        public string Nivo { get; set; }
        public string KratkiOpis { get; set; }
        public string Adresa { get; set; }
        public string DostupneSobe { get; set; }
        public string PreporuceniAranzman { get; set; }
        public string Opis { get; set; }
        public string Fotografija { get; set; }
        public double CijenaMin { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Hotel(
            string id, 
            string naziv, 
            string nivo, 
            string kratkiOpis,
            string adresa, 
            string dostupneSobe, 
            string preporuceniAranzman, 
            string opis,
            string fotografija,
            double cijenaMin,
            double longitude,
            double latitude
            ) 
        {
            Id = id; 
            Naziv = naziv;
            Nivo = nivo;
            KratkiOpis = kratkiOpis;
            Adresa = adresa;
            DostupneSobe = dostupneSobe;
            PreporuceniAranzman = preporuceniAranzman;
            Opis = opis;
            Fotografija = fotografija;
            CijenaMin = cijenaMin;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
