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

            if (buyLitres.Text != "" && ByLitres.Checked)
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
            if (_litres < 0) MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            //if (_litres > 0 && _litres < 5) MessageBox.Show("We don't fill less then 5 litres!", "Minimal Limit", MessageBoxButtons.OK, MessageBoxIcon.Stop); 
            SumForPetrol.Text = Convert.ToString(_litres * Convert.ToDouble(PriceTypeOfPetrol.Text));
        }

        private void buyMoney_TextChanged(object sender, EventArgs e)
        {

            if (buyMoney.Text != "")
            {
                try
                {
                    _money = Convert.ToDouble(buyMoney.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            }
            if (_money < 0) MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            _money = Math.Round(_money, 2);
            buyLitres.Text = Convert.ToString(Math.Round(_money / Convert.ToDouble(PriceTypeOfPetrol.Text), 2));
            SumForPetrol.Text = Convert.ToString(_money);
        }

        private void hotDogCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (hotDogCheck.Checked) hotDogNum.Enabled = true;
            else
            {
                hotDogNum.Enabled = false;
                hotDogNum.Clear();
            }
        }

        private void hamburgerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburgerCheck.Checked) hamburgerNum.Enabled = true;
            else
            {
                hamburgerNum.Enabled = false;
                hamburgerNum.Clear();
            }
        }

        private void potatoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (potatoCheck.Checked) potatoNum.Enabled = true;
            else
            {
                potatoNum.Enabled = false;
                potatoNum.Clear();
            }
        }

        private void colaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (colaCheck.Checked) colaNum.Enabled = true;
            else
            {
                colaNum.Enabled = false;
                colaNum.Clear();
            }
        }
        //private void cafeGroupBoxTextBoxChanged(object sender, EventArgs e)
        //{
        //    //Controls.cafeGroupBox.OfType<TextBox>().Any(textBox => textBox.Text == ""); 

        //}

        private void hotDogNum_TextChanged(object sender, EventArgs e)
        {
            byte hotDog = 0;
            if (hotDogNum.Text!="")
            {
                try
                {
                    hotDog = Convert.ToByte(hotDogNum.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    hotDogNum.Clear();
                }
                if (hotDog < 0) MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error); 
            }
        }

        private void hamburgerNum_TextChanged(object sender, EventArgs e)
        {
            byte hamburger = 0;
            if (hamburgerNum.Text != "")
            {
                try
                {
                    hamburger = Convert.ToByte(hamburgerNum.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    hamburgerNum.Clear();
                }
                if (hamburger < 0) MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void potatoNum_TextChanged(object sender, EventArgs e)
        {
            byte potato = 0;
            if (potatoNum.Text != "")
            {
                try
                {
                    potato = Convert.ToByte(potatoNum.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    potatoNum.Clear();
                }
                if (potato < 0) MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void colaNum_TextChanged(object sender, EventArgs e)
        {
            byte cola = 0;
            if (colaNum.Text != "")
            {
                try
                {
                    cola = Convert.ToByte(colaNum.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    colaNum.Clear();
                }
                if (cola < 0) MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
    }
}

