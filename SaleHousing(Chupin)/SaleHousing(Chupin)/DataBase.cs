using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleHousing_Chupin_
{
    public class DataBase
    {
        private List<Sale> _sales;

        public List<Sale> Sales => _sales;
        public int CountSales => _sales.Count;

        public DataBase()
        {
            _sales = new List<Sale>();
        }

        public List<ListViewItem> Demand(int from, int to)
        {
            List<ListViewItem> items = new List<ListViewItem>();

            for (int i = 0; i < _sales.Count; i++)
            {
                if (_sales[i].NeedingPrice >= from && _sales[i].NeedingPrice <= to)
                {
                    items.Add(GetDataByIndex(i));
                }
            }

            return items;
        }

        public void AddSale(string distrcit, string address, string houseCharacteristic, string apartmentCharacteristic, int needingPrice, string square, string layout, int floor, string conatctDetails)
        {
            _sales.Add(new Sale(CountSales+1,distrcit,address,houseCharacteristic,apartmentCharacteristic,needingPrice,square,layout,floor,conatctDetails));
        }

        public void SetSales(List<Sale> sales)
        {
            _sales = sales;
        }

        public Sale GetSaleById(int index)
        {
            foreach (Sale sale in _sales)
            {
                if (sale.Id == index)
                {
                    return sale;
                }
            }

            return null;
        }

        public void RemoveSaleAt(int index)
        {
            foreach (Sale sale in _sales)
            {
                if (sale.Id == index)
                {
                    _sales.Remove(sale);
                    return;
                }
            }

            MessageBox.Show("Id не найден");
        }

        public List<ListViewItem> GetItemsByAttribute(string attribute, string path)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            string data = null;

            for (int i = 0; i < _sales.Count; i++)
            {
                if (_sales[i].Id.ToString() == attribute)
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
                else if (_sales[i].District.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
                else if (_sales[i].Address.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
                else if (_sales[i].HouseCharacteristic.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
                else if (_sales[i].ApartmentCharacteristic.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
                else if (_sales[i].NeedingPrice.ToString() == attribute.ToLower())
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
                else if (_sales[i].Square.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
                else if (_sales[i].Layout.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
                else if (_sales[i].Floor.ToString() == attribute.ToLower())
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
                else if (_sales[i].ContactDetails.ToLower().Contains(attribute.ToLower()))
                {
                    items.Add(GetDataByIndex(i));
                    data += AddData(_sales[i]);
                }
            }

            File.WriteAllText(path, data);
            return items;
        }

        private string AddData(Sale sale)
        {
            string data = null;
            data = $"{sale.Id} " +
                $"{sale.District} " +
                $"{sale.Address} " +
                $"{sale.HouseCharacteristic} " +
                $"{sale.ApartmentCharacteristic} " +
                $"{sale.NeedingPrice} " +
                $"{sale.Square} " +
                $"{sale.Layout} " +
                $"{sale.Floor} " +
                $"{sale.ContactDetails}\n";

            return data;
        }

        public void ShowData(ListView listView)
        {
            ListViewItem listViewItems = null;

            foreach (Sale sale in _sales)
            {
                listViewItems = new ListViewItem(new string[] {
                    sale.Id.ToString(),
                    sale.District,
                    sale.Address,
                    sale.HouseCharacteristic,
                    sale.ApartmentCharacteristic,
                    sale.NeedingPrice.ToString(),
                    sale.Square,
                    sale.Layout,
                    sale.Floor.ToString(),
                    sale.ContactDetails
                });
                listView.Items.Add(listViewItems);
            }
        }

        public void ShowDataByAttribute(ListView listView, string attribute, string path)
        {
            List<ListViewItem> listViewItems = GetItemsByAttribute(attribute, path);

            if (listViewItems.Count != 0)
            {
                listView.Items.Clear();

                foreach (ListViewItem items in listViewItems)
                {
                    listView.Items.Add(items);
                }
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
                listView.Items.Clear();
                ShowData(listView);
            }
        }

        private ListViewItem GetDataByIndex(int index)
        {
            ListViewItem listViewItem = null;

            listViewItem = new ListViewItem(new string[] {
                _sales[index].Id.ToString(),
                _sales[index].District,
                _sales[index].Address,
                _sales[index].HouseCharacteristic,
                _sales[index].ApartmentCharacteristic,
                _sales[index].NeedingPrice.ToString(),
                _sales[index].Square,
                _sales[index].Layout,
                _sales[index].Floor.ToString(),
                _sales[index].ContactDetails
            });

            return listViewItem;
        }
    }
}
