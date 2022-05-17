using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SaleHousing_Chupin_
{
    [Serializable]
    public class Sales
    {
        public Sales() { }

        public List<Sale> SalesList { get; set; } = new List<Sale>();
    }

    [Serializable]
    public class Sale
    {
        [XmlElement("SALE")]

        public int Id { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string HouseCharacteristic { get; set; }
        public string ApartmentCharacteristic { get; set; }
        public int NeedingPrice { get; set; }
        public string Square { get; set; }
        public string Layout { get; set; }
        public int Floor { get; set; }
        public string ContactDetails { get; set; }

        public Sale() { }

        public Sale(int id, string distrcit, string address, string houseCharacteristic, string apartmentCharacteristic, int needingPrice, string square, string layout, int floor, string conatctDetails)
        {
            Id = id;
            District = distrcit;
            Address = address;
            HouseCharacteristic = houseCharacteristic;
            ApartmentCharacteristic = apartmentCharacteristic;
            NeedingPrice = needingPrice;
            Square = square;
            Layout = layout;
            Floor = floor;
            ContactDetails = conatctDetails;
        }

        public void SetData(string distrcit, string address, string houseCharacteristic, string apartmentCharacteristic, int needingPrice, string square, string layout, int floor, string conatctDetails)
        {
            District = distrcit;
            Address = address;
            HouseCharacteristic = houseCharacteristic;
            ApartmentCharacteristic = apartmentCharacteristic;
            NeedingPrice = needingPrice;
            Square = square;
            Layout = layout;
            Floor = floor;
            ContactDetails = conatctDetails;
        }
    }
}
