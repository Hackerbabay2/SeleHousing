using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleHousing_Chupin_
{
    public partial class RedactorData : Form
    {
        private Sale _sale;

        public RedactorData(Sale sale)
        {
            InitializeComponent();
            _sale = sale;
        }
        private void RedactorData_Load(object sender, EventArgs e)
        {
            districtBox.Text = _sale.District;
            addressBox.Text = _sale.Address;
            houseCharactiristicBox.Text = _sale.HouseCharacteristic;
            apartmentCharactiristicBox.Text = _sale.ApartmentCharacteristic;
            needingPriceNumeric.Value = _sale.NeedingPrice;
            SquareBox.Text = _sale.Square;
            LayoutBox.Text = _sale.Layout;
            floorNumeric.Value = _sale.Floor;
            contactDetailsBox.Text = _sale.ContactDetails;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _sale.SetData(districtBox.Text, addressBox.Text, houseCharactiristicBox.Text, apartmentCharactiristicBox.Text, (int)needingPriceNumeric.Value, SquareBox.Text, LayoutBox.Text, (int)floorNumeric.Value, contactDetailsBox.Text);

            DialogResult result = MessageBox.Show(
                "Завершить редактирование?",
                "Изменения применены",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );

            if (result == DialogResult.Yes)
            {
                Hide();
            }
        }
    }
}
