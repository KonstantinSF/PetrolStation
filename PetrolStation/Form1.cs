using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PetrolStation
{
    public partial class FuelStationForm : Form
    {
        byte _litres = 0;
        double _money = 0;
        double _sumCafe = 0;
        bool _countEnter = true;

        public FuelStationForm()
        {
            InitializeComponent();
            PetrolType.Text = "Аи-95";
            ByLitres.Checked = true;
            SumForPetrol.Text = _money.ToString();
            SumCafe.Text = _sumCafe.ToString();

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
            SumForPetrol.Text="0";
            buyMoney.Enabled = false;
        }

        private void ByMoney_CheckedChanged(object sender, EventArgs e)
        {
            buyMoney.Enabled = true;
            buyMoney.Clear();
            SumForPetrol.Text="0";
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
                    buyLitres.Clear();
                    _litres = 0;
                }
            }
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
                    buyMoney.Clear();
                }
            }
            if (_money < 0) MessageBox.Show("Please enter a correct number", "Input Error!", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            _money = Math.Round(_money, 2);
            buyLitres.Text = Convert.ToString(Math.Round(_money / Convert.ToDouble(PriceTypeOfPetrol.Text), 2));
            SumForPetrol.Text = Convert.ToString(_money);
        }

        private void hotDogCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (hotDogCheck.Checked)
            {
                hotDogNum.Enabled = true;
                hotDogNum.Focus();
            }
            else if (!hotDogNum.Enabled)
            {
                _sumCafe -= Convert.ToDouble(hotDogNum.Text) * Convert.ToDouble(hotDogPrice.Text);
                hotDogNum.Clear();
            }
            else if (!hotDogCheck.Checked && hotDogNum.Text != "")
            {
                hotDogNum.Clear();
                hotDogNum.Enabled = false;
            }
            SumCafe.Text = _sumCafe.ToString();
        }

        private void hamburgerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburgerCheck.Checked)
            {
                hamburgerNum.Enabled = true;
                hamburgerNum.Focus();
            }
            else if (!hamburgerNum.Enabled)
            {
                 _sumCafe -= Convert.ToDouble(hamburgerNum.Text) * Convert.ToDouble(hamburgerPrice.Text);
                hamburgerNum.Clear();
            }
            else if (!hamburgerCheck.Checked && hamburgerNum.Text != "")
            {
                hamburgerNum.Clear();
                hamburgerNum.Enabled = false;
            }
            SumCafe.Text = _sumCafe.ToString();
        }

        private void potatoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (potatoCheck.Checked)
            {
                potatoNum.Enabled = true;
                potatoNum.Focus();
            }
            else if (!potatoNum.Enabled)
            {
                 _sumCafe -= Convert.ToDouble(potatoNum.Text) * Convert.ToDouble(potatoPrice.Text);
                potatoNum.Clear();
            }
            else if (!potatoCheck.Checked && potatoNum.Text != "")
            {
                potatoNum.Clear();
                potatoNum.Enabled = false;
            }
            SumCafe.Text = _sumCafe.ToString();
        }

        private void colaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (colaCheck.Checked)
            {
                colaNum.Enabled = true;
                colaNum.Focus();
            }
            else if (!colaNum.Enabled)
            {
                _sumCafe -= Convert.ToDouble(colaNum.Text) * Convert.ToDouble(colaPrice.Text);
                colaNum.Clear();
                colaNum.Enabled = false;
            }
            else if (!colaCheck.Checked && colaNum.Text != "")
            {
                colaNum.Clear();
                colaNum.Enabled = false;
            }
            SumCafe.Text = _sumCafe.ToString();
        }

        private void hotDogNum_TextChanged(object sender, EventArgs e)
        {
            byte hotDog = 0;
            if (hotDogNum.Text != "")
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
            }
        }
        private void colaNum_Leave(object sender, EventArgs e) => _countEnter = true;
        private void colaNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && _countEnter == true)
            {
                double colaPricePart = 0;
                if (colaNum.Text != "" && colaCheck.Checked)
                {
                    _countEnter = false;
                    colaPricePart = Convert.ToSByte(colaNum.Text) * Convert.ToDouble(colaPrice.Text);
                    _sumCafe += colaPricePart;
                    colaNum.Enabled = false;
                }
                SumCafe.Text = _sumCafe.ToString();
                countButton.Focus();
            }
        }

        private void potatoNum_Leave(object sender, EventArgs e) => _countEnter = true;
        private void potatoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && _countEnter == true)
            {
                double potatoPricePart = 0;
                if (potatoNum.Text != "" && potatoCheck.Checked)
                {
                    _countEnter = false;
                    potatoPricePart = Convert.ToSByte(potatoNum.Text) * Convert.ToDouble(potatoPrice.Text);
                    _sumCafe += potatoPricePart;
                    potatoNum.Enabled = false;
                }
                SumCafe.Text = _sumCafe.ToString();
                countButton.Focus();
            }
        }

        private void hamburgerNum_Leave(object sender, EventArgs e) => _countEnter = true;

        private void hamburgerNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && _countEnter == true)
            {
                double hamburgerPricePart = 0;
                if (hamburgerNum.Text != "" && hamburgerCheck.Checked)
                {
                    _countEnter = false;
                    hamburgerPricePart = Convert.ToSByte(hamburgerNum.Text) * Convert.ToDouble(hamburgerPrice.Text);
                    _sumCafe += hamburgerPricePart;
                    hamburgerNum.Enabled = false;
                }
                SumCafe.Text = _sumCafe.ToString();
                countButton.Focus();
            }
        }
        private void hotDogNum_Leave(object sender, EventArgs e) => _countEnter = true;
        private void hotDogNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && _countEnter == true)
            {
                double hotDogPricePart = 0;
                if (hotDogNum.Text != "" && hotDogCheck.Checked)
                {
                    _countEnter = false;
                    hotDogPricePart = Convert.ToSByte(hotDogNum.Text) * Convert.ToDouble(hotDogPrice.Text);
                    _sumCafe += hotDogPricePart;
                    hotDogNum.Enabled = false;
                }
                SumCafe.Text = _sumCafe.ToString();
                countButton.Focus(); 
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            if (!hotDogNum.Enabled && !hamburgerNum.Enabled && !potatoNum.Enabled && !colaNum.Enabled)
            {
                totalSum.Text = (Convert.ToDouble(SumForPetrol.Text) + Convert.ToDouble(SumCafe.Text)).ToString();
            }
            else MessageBox.Show("Please, fill the all lines in MiniCafe. Do NOT forget press Enter after each line!","Empty lines in MiniCafe", MessageBoxButtons.OK, icon: MessageBoxIcon.Error); 
        }

        private void buyLitres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buyLitres.Enabled = false;
                countButton.Focus();
            }
        }

        private void buyMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buyMoney.Enabled = false;
                countButton.Focus();
            }
        }

        private void hotDogCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == 13) hotDogCheck.Checked = true; 
        }

        private void hamburgerCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == 13) hamburgerCheck.Checked = true; 
        }

        private void potatoCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == 13) potatoCheck.Checked = true; 
        }

        private void colaCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar == 13) colaCheck.Checked = true; 
        }
    }
}

