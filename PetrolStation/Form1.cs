using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetrolStation
{
    public partial class FuelStationForm : Form
    {
        byte _litres = 0;
        double _money = 0;

        public FuelStationForm()
        {
            InitializeComponent();
            PetrolType.Text = "Аи-95";
            ByLitres.Checked = true;

        }
        Dictionary<string, double> PetrolPrice = new Dictionary<string, double>()
        {
            {"Аи-76",  60},
            {"Аи-92",  65},
            {"Аи-95",  68},
            {"Аи-100", 78},
            {"ДТ",     54},
            {"биоДТ",  56},
            {"закись азота",  200}
        };

        private void PetrolType_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string item in PetrolPrice.Keys)
            {
                if (item == PetrolType.Text)
                {
                    PriceTypeOfPetrol.Text = Convert.ToString(PetrolPrice[item]); break;
                }
            }
            if (ByLitres.Checked)
            SumForPetrol.Text = Convert.ToString(_litres * Convert.ToDouble(PriceTypeOfPetrol.Text));
            if (ByMoney.Checked)
            {
                buyLitres.Text = Convert.ToString(Math.Round(_money / Convert.ToDouble(PriceTypeOfPetrol.Text), 2));
                SumForPetrol.Text = Convert.ToString(_money);
            }
        }

        private void ByLitres_CheckedChanged(object sender, EventArgs e)
        {
            buyLitres.Enabled = true;
            buyLitres.Clear();
            SumForPetrol.Clear(); 
            buyMoney.Enabled = false;
        }

        private void ByMoney_CheckedChanged(object sender, EventArgs e)
        {
            buyMoney.Enabled = true;
            buyMoney.Clear();
            SumForPetrol.Clear(); 
            buyLitres.Enabled = false;
        }

        private void buyLitres_TextChanged(object sender, EventArgs e)
        {
            
            if (buyLitres.Text != ""&& ByLitres.Checked)
            {
                try
                {
                    _litres = Convert.ToByte(buyLitres.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
            if (_litres<0) MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            //if (_litres > 0 && _litres < 5) MessageBox.Show("We don't fill less then 5 litres!", "Minimal Limit", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
            SumForPetrol.Text = Convert.ToString(_litres * Convert.ToDouble(PriceTypeOfPetrol.Text)); 
        }

        private void buyMoney_TextChanged(object sender, EventArgs e)
        {
             
            if (buyMoney.Text != "")
            {
                try
                {
                    _money = Convert.ToDouble (buyMoney.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
            if(_money<0) MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            _money = Math.Round(_money, 2); 
            buyLitres.Text = Convert.ToString(Math.Round(_money / Convert.ToDouble(PriceTypeOfPetrol.Text),2)); 
            SumForPetrol.Text = Convert.ToString(_money);
        }
    }
}
