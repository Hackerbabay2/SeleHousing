using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SaleHousing_Chupin_
{
    public partial class SaleHouseing : Form
    {
        private DataBase _dataBase;
        private string _pathFoundData = "foundData.txt";
        private Sales _sales;

        public SaleHouseing()
        {
            InitializeComponent();
            _dataBase = new DataBase();
            _sales = new Sales();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_pathFoundData))
                File.Create(_pathFoundData).Close();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView listview = (ListView)sender;

            if (e.Column == ListViewItemComparer.SortColumn)
            {
                if (ListViewItemComparer.Order == SortOrder.Ascending)
                {
                    ListViewItemComparer.Order = SortOrder.Descending;
                }
                else
                {
                    ListViewItemComparer.Order = SortOrder.Ascending;
                }
            }
            else
            {
                ListViewItemComparer.SortColumn = e.Column;
                ListViewItemComparer.Order = SortOrder.Ascending;
            }
            this.salesListView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salesListView.Items.Clear();
            _dataBase.AddSale(districtBox.Text, addressBox.Text, houseCharactiristicBox.Text, apartmentCharactiristicBox.Text, (int)needingPriceNumeric.Value, SquareBox.Text, LayoutBox.Text, (int)floorNumeric.Value, contactDetailsBox.Text);
            _dataBase.ShowData(salesListView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _dataBase.ShowDataByAttribute(salesListView,searchBox.Text,_pathFoundData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".xml (*.xml*)|*.xml*";
            saveFileDialog.ShowDialog();

            if (!saveFileDialog.FileName.EndsWith(".xml"))
                saveFileDialog.FileName += ".xml";

            File.Delete(saveFileDialog.FileName);
            _sales.SalesList = _dataBase.Sales;
            SerializeXML(_sales,saveFileDialog.FileName);
        }

        private void SerializeXML(Sales sales, string pathFile)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Sales));

            using (FileStream fileStream = new FileStream(pathFile, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, sales);
            }
        }

        private Sales DeseriacliezeXml(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Sales));

            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                return (Sales)xmlSerializer.Deserialize(fileStream);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = ".xml (*.xml*)|*.xml*";
            openFileDialog.ShowDialog();

            try
            {
                if (openFileDialog.FileName.EndsWith(".xml"))
                {
                    _sales = DeseriacliezeXml(openFileDialog.FileName);
                    _dataBase.SetSales(_sales.SalesList);
                    _dataBase.ShowData(salesListView);
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sale redactorSale = _dataBase.GetSaleById((int)idNumeric.Value);

            if (redactorSale != null)
            {
                RedactorData redactorData = new RedactorData(redactorSale);
                redactorData.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            salesListView.Items.Clear();
            _dataBase.ShowData(salesListView);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _dataBase.RemoveSaleAt((int)idNumeric.Value);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((int)toNumeric.Value < (int)fromNumeric.Value)
            {
                MessageBox.Show("Максимальная цена не может быть меньше минимальной!");
            }
            else
            {
                List<ListViewItem> items = _dataBase.Demand((int)fromNumeric.Value, (int)toNumeric.Value);
                salesListView.Items.Clear();

                foreach (ListViewItem item in items)
                {
                    salesListView.Items.Add(item);
                }
            }
        }
    }
}
