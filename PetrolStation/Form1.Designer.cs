﻿namespace PetrolStation
{
    partial class FuelStationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuelStationForm));
            this.PetrolGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buyMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buyLitres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ByMoney = new System.Windows.Forms.RadioButton();
            this.ByLitres = new System.Windows.Forms.RadioButton();
            this.PriceTypeOfPetrol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PetrolType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SumForPetrol = new System.Windows.Forms.TextBox();
            this.hotDogNum = new System.Windows.Forms.TextBox();
            this.hamburgerNum = new System.Windows.Forms.TextBox();
            this.potatoNum = new System.Windows.Forms.TextBox();
            this.colaNum = new System.Windows.Forms.TextBox();
            this.colaCheck = new System.Windows.Forms.CheckBox();
            this.potatoCheck = new System.Windows.Forms.CheckBox();
            this.hamburgerCheck = new System.Windows.Forms.CheckBox();
            this.hotDogCheck = new System.Windows.Forms.CheckBox();
            this.cafeGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SumCafe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.colaPrice = new System.Windows.Forms.TextBox();
            this.potatoPrice = new System.Windows.Forms.TextBox();
            this.hamburgerPrice = new System.Windows.Forms.TextBox();
            this.hotDogPrice = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalPerCharge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalSum = new System.Windows.Forms.TextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.timerCloseForm = new System.Windows.Forms.Timer(this.components);
            this.closeCharge = new System.Windows.Forms.Button();
            this.PetrolGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cafeGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // PetrolGroupBox
            // 
            this.PetrolGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.PetrolGroupBox.Controls.Add(this.label5);
            this.PetrolGroupBox.Controls.Add(this.buyMoney);
            this.PetrolGroupBox.Controls.Add(this.label4);
            this.PetrolGroupBox.Controls.Add(this.buyLitres);
            this.PetrolGroupBox.Controls.Add(this.label3);
            this.PetrolGroupBox.Controls.Add(this.ByMoney);
            this.PetrolGroupBox.Controls.Add(this.ByLitres);
            this.PetrolGroupBox.Controls.Add(this.PriceTypeOfPetrol);
            this.PetrolGroupBox.Controls.Add(this.label2);
            this.PetrolGroupBox.Controls.Add(this.label1);
            this.PetrolGroupBox.Controls.Add(this.PetrolType);
            this.PetrolGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetrolGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetrolGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PetrolGroupBox.Location = new System.Drawing.Point(0, 0);
            this.PetrolGroupBox.Name = "PetrolGroupBox";
            this.PetrolGroupBox.Size = new System.Drawing.Size(372, 449);
            this.PetrolGroupBox.TabIndex = 1;
            this.PetrolGroupBox.TabStop = false;
            this.PetrolGroupBox.Text = "PetrolControl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(318, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rub";
            // 
            // buyMoney
            // 
            this.buyMoney.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buyMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyMoney.Location = new System.Drawing.Point(171, 224);
            this.buyMoney.Name = "buyMoney";
            this.buyMoney.Size = new System.Drawing.Size(115, 30);
            this.buyMoney.TabIndex = 11;
            this.buyMoney.TextChanged += new System.EventHandler(this.buyMoney_TextChanged);
            this.buyMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buyMoney_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(318, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Litres";
            // 
            // buyLitres
            // 
            this.buyLitres.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buyLitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyLitres.Location = new System.Drawing.Point(171, 176);
            this.buyLitres.Name = "buyLitres";
            this.buyLitres.Size = new System.Drawing.Size(115, 30);
            this.buyLitres.TabIndex = 9;
            this.buyLitres.TextChanged += new System.EventHandler(this.buyLitres_TextChanged);
            this.buyLitres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buyLitres_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(318, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rub";
            // 
            // ByMoney
            // 
            this.ByMoney.AutoSize = true;
            this.ByMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ByMoney.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ByMoney.Location = new System.Drawing.Point(28, 230);
            this.ByMoney.Name = "ByMoney";
            this.ByMoney.Size = new System.Drawing.Size(79, 24);
            this.ByMoney.TabIndex = 7;
            this.ByMoney.TabStop = true;
            this.ByMoney.Text = "Money";
            this.ByMoney.UseVisualStyleBackColor = true;
            this.ByMoney.CheckedChanged += new System.EventHandler(this.ByMoney_CheckedChanged);
            // 
            // ByLitres
            // 
            this.ByLitres.AutoSize = true;
            this.ByLitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ByLitres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ByLitres.Location = new System.Drawing.Point(28, 182);
            this.ByLitres.Name = "ByLitres";
            this.ByLitres.Size = new System.Drawing.Size(72, 24);
            this.ByLitres.TabIndex = 6;
            this.ByLitres.TabStop = true;
            this.ByLitres.Text = "Litres";
            this.ByLitres.UseVisualStyleBackColor = true;
            this.ByLitres.CheckedChanged += new System.EventHandler(this.ByLitres_CheckedChanged);
            // 
            // PriceTypeOfPetrol
            // 
            this.PriceTypeOfPetrol.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PriceTypeOfPetrol.Enabled = false;
            this.PriceTypeOfPetrol.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTypeOfPetrol.ForeColor = System.Drawing.Color.Black;
            this.PriceTypeOfPetrol.Location = new System.Drawing.Point(171, 79);
            this.PriceTypeOfPetrol.Name = "PriceTypeOfPetrol";
            this.PriceTypeOfPetrol.Size = new System.Drawing.Size(115, 30);
            this.PriceTypeOfPetrol.TabIndex = 5;
            this.PriceTypeOfPetrol.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Petrol";
            // 
            // PetrolType
            // 
            this.PetrolType.AllowDrop = true;
            this.PetrolType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetrolType.FormattingEnabled = true;
            this.PetrolType.Items.AddRange(new object[] {
            "Аи-100",
            "Аи-76",
            "Аи-92",
            "Аи-95",
            "биоДТ",
            "ДТ",
            "закись азота"});
            this.PetrolType.Location = new System.Drawing.Point(171, 29);
            this.PetrolType.Name = "PetrolType";
            this.PetrolType.Size = new System.Drawing.Size(194, 28);
            this.PetrolType.Sorted = true;
            this.PetrolType.TabIndex = 2;
            this.PetrolType.Text = "Aи-76";
            this.PetrolType.SelectedIndexChanged += new System.EventHandler(this.PetrolType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SumForPetrol);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(28, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 141);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price for Petrol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(274, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rub";
            // 
            // SumForPetrol
            // 
            this.SumForPetrol.BackColor = System.Drawing.SystemColors.Control;
            this.SumForPetrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SumForPetrol.Enabled = false;
            this.SumForPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumForPetrol.Location = new System.Drawing.Point(143, 63);
            this.SumForPetrol.Name = "SumForPetrol";
            this.SumForPetrol.Size = new System.Drawing.Size(100, 38);
            this.SumForPetrol.TabIndex = 0;
            this.SumForPetrol.TabStop = false;
            // 
            // hotDogNum
            // 
            this.hotDogNum.Enabled = false;
            this.hotDogNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotDogNum.Location = new System.Drawing.Point(261, 55);
            this.hotDogNum.Name = "hotDogNum";
            this.hotDogNum.Size = new System.Drawing.Size(100, 26);
            this.hotDogNum.TabIndex = 17;
            this.hotDogNum.TextChanged += new System.EventHandler(this.hotDogNum_TextChanged);
            this.hotDogNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotDogNum_KeyPress);
            this.hotDogNum.Leave += new System.EventHandler(this.hotDogNum_Leave);
            // 
            // hamburgerNum
            // 
            this.hamburgerNum.Enabled = false;
            this.hamburgerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hamburgerNum.Location = new System.Drawing.Point(261, 111);
            this.hamburgerNum.Name = "hamburgerNum";
            this.hamburgerNum.Size = new System.Drawing.Size(100, 26);
            this.hamburgerNum.TabIndex = 20;
            this.hamburgerNum.TextChanged += new System.EventHandler(this.hamburgerNum_TextChanged);
            this.hamburgerNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hamburgerNum_KeyPress);
            this.hamburgerNum.Leave += new System.EventHandler(this.hamburgerNum_Leave);
            // 
            // potatoNum
            // 
            this.potatoNum.Enabled = false;
            this.potatoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.potatoNum.Location = new System.Drawing.Point(261, 163);
            this.potatoNum.Name = "potatoNum";
            this.potatoNum.Size = new System.Drawing.Size(100, 26);
            this.potatoNum.TabIndex = 23;
            this.potatoNum.TextChanged += new System.EventHandler(this.potatoNum_TextChanged);
            this.potatoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.potatoNum_KeyPress);
            this.potatoNum.Leave += new System.EventHandler(this.potatoNum_Leave);
            // 
            // colaNum
            // 
            this.colaNum.Enabled = false;
            this.colaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colaNum.Location = new System.Drawing.Point(261, 211);
            this.colaNum.Name = "colaNum";
            this.colaNum.Size = new System.Drawing.Size(100, 26);
            this.colaNum.TabIndex = 26;
            this.colaNum.TextChanged += new System.EventHandler(this.colaNum_TextChanged);
            this.colaNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colaNum_KeyPress);
            this.colaNum.Leave += new System.EventHandler(this.colaNum_Leave);
            // 
            // colaCheck
            // 
            this.colaCheck.AutoSize = true;
            this.colaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colaCheck.Location = new System.Drawing.Point(23, 211);
            this.colaCheck.Name = "colaCheck";
            this.colaCheck.Size = new System.Drawing.Size(101, 21);
            this.colaCheck.TabIndex = 24;
            this.colaCheck.Text = "Coca-Cola";
            this.colaCheck.UseVisualStyleBackColor = true;
            this.colaCheck.CheckedChanged += new System.EventHandler(this.colaCheck_CheckedChanged);
            this.colaCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colaCheck_KeyPress);
            // 
            // potatoCheck
            // 
            this.potatoCheck.AutoSize = true;
            this.potatoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.potatoCheck.Location = new System.Drawing.Point(23, 163);
            this.potatoCheck.Name = "potatoCheck";
            this.potatoCheck.Size = new System.Drawing.Size(124, 21);
            this.potatoCheck.TabIndex = 21;
            this.potatoCheck.Text = "Potato (fried)";
            this.potatoCheck.UseVisualStyleBackColor = true;
            this.potatoCheck.CheckedChanged += new System.EventHandler(this.potatoCheck_CheckedChanged);
            this.potatoCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.potatoCheck_KeyPress);
            // 
            // hamburgerCheck
            // 
            this.hamburgerCheck.AutoSize = true;
            this.hamburgerCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hamburgerCheck.Location = new System.Drawing.Point(23, 111);
            this.hamburgerCheck.Name = "hamburgerCheck";
            this.hamburgerCheck.Size = new System.Drawing.Size(107, 21);
            this.hamburgerCheck.TabIndex = 18;
            this.hamburgerCheck.Text = "Hamburger";
            this.hamburgerCheck.UseVisualStyleBackColor = true;
            this.hamburgerCheck.CheckedChanged += new System.EventHandler(this.hamburgerCheck_CheckedChanged);
            this.hamburgerCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hamburgerCheck_KeyPress);
            // 
            // hotDogCheck
            // 
            this.hotDogCheck.AutoSize = true;
            this.hotDogCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotDogCheck.Location = new System.Drawing.Point(23, 60);
            this.hotDogCheck.Name = "hotDogCheck";
            this.hotDogCheck.Size = new System.Drawing.Size(86, 21);
            this.hotDogCheck.TabIndex = 15;
            this.hotDogCheck.Text = "Hot Dog";
            this.hotDogCheck.UseVisualStyleBackColor = true;
            this.hotDogCheck.CheckedChanged += new System.EventHandler(this.hotDogCheck_CheckedChanged);
            this.hotDogCheck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotDogCheck_KeyPress);
            // 
            // cafeGroupBox
            // 
            this.cafeGroupBox.Controls.Add(this.groupBox3);
            this.cafeGroupBox.Controls.Add(this.label9);
            this.cafeGroupBox.Controls.Add(this.label8);
            this.cafeGroupBox.Controls.Add(this.colaNum);
            this.cafeGroupBox.Controls.Add(this.colaPrice);
            this.cafeGroupBox.Controls.Add(this.colaCheck);
            this.cafeGroupBox.Controls.Add(this.potatoNum);
            this.cafeGroupBox.Controls.Add(this.potatoPrice);
            this.cafeGroupBox.Controls.Add(this.potatoCheck);
            this.cafeGroupBox.Controls.Add(this.hamburgerNum);
            this.cafeGroupBox.Controls.Add(this.hamburgerPrice);
            this.cafeGroupBox.Controls.Add(this.hamburgerCheck);
            this.cafeGroupBox.Controls.Add(this.hotDogNum);
            this.cafeGroupBox.Controls.Add(this.hotDogPrice);
            this.cafeGroupBox.Controls.Add(this.hotDogCheck);
            this.cafeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cafeGroupBox.Location = new System.Drawing.Point(379, 0);
            this.cafeGroupBox.Name = "cafeGroupBox";
            this.cafeGroupBox.Size = new System.Drawing.Size(380, 449);
            this.cafeGroupBox.TabIndex = 14;
            this.cafeGroupBox.TabStop = false;
            this.cafeGroupBox.Text = "Mini Cafe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.SumCafe);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(23, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 141);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Price for Food";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(274, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rub";
            // 
            // SumCafe
            // 
            this.SumCafe.BackColor = System.Drawing.SystemColors.Control;
            this.SumCafe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SumCafe.Enabled = false;
            this.SumCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumCafe.Location = new System.Drawing.Point(143, 63);
            this.SumCafe.Name = "SumCafe";
            this.SumCafe.Size = new System.Drawing.Size(100, 38);
            this.SumCafe.TabIndex = 0;
            this.SumCafe.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(264, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Quantity, pc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(139, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Price, Rub";
            // 
            // colaPrice
            // 
            this.colaPrice.Enabled = false;
            this.colaPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colaPrice.Location = new System.Drawing.Point(142, 211);
            this.colaPrice.Name = "colaPrice";
            this.colaPrice.ReadOnly = true;
            this.colaPrice.Size = new System.Drawing.Size(100, 26);
            this.colaPrice.TabIndex = 25;
            this.colaPrice.TabStop = false;
            this.colaPrice.Text = "10";
            // 
            // potatoPrice
            // 
            this.potatoPrice.Enabled = false;
            this.potatoPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.potatoPrice.Location = new System.Drawing.Point(142, 163);
            this.potatoPrice.Name = "potatoPrice";
            this.potatoPrice.ReadOnly = true;
            this.potatoPrice.Size = new System.Drawing.Size(100, 26);
            this.potatoPrice.TabIndex = 22;
            this.potatoPrice.TabStop = false;
            this.potatoPrice.Text = "50";
            // 
            // hamburgerPrice
            // 
            this.hamburgerPrice.Enabled = false;
            this.hamburgerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hamburgerPrice.Location = new System.Drawing.Point(142, 111);
            this.hamburgerPrice.Name = "hamburgerPrice";
            this.hamburgerPrice.ReadOnly = true;
            this.hamburgerPrice.Size = new System.Drawing.Size(100, 26);
            this.hamburgerPrice.TabIndex = 19;
            this.hamburgerPrice.TabStop = false;
            this.hamburgerPrice.Text = "100";
            // 
            // hotDogPrice
            // 
            this.hotDogPrice.Enabled = false;
            this.hotDogPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotDogPrice.Location = new System.Drawing.Point(142, 55);
            this.hotDogPrice.Name = "hotDogPrice";
            this.hotDogPrice.ReadOnly = true;
            this.hotDogPrice.Size = new System.Drawing.Size(100, 26);
            this.hotDogPrice.TabIndex = 16;
            this.hotDogPrice.TabStop = false;
            this.hotDogPrice.Text = "200";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.closeCharge);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.totalPerCharge);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.totalSum);
            this.groupBox5.Controls.Add(this.countButton);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(13, 456);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(746, 130);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(560, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Total per charge:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(690, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Rub";
            // 
            // totalPerCharge
            // 
            this.totalPerCharge.BackColor = System.Drawing.SystemColors.Control;
            this.totalPerCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPerCharge.Enabled = false;
            this.totalPerCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPerCharge.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalPerCharge.Location = new System.Drawing.Point(563, 59);
            this.totalPerCharge.Name = "totalPerCharge";
            this.totalPerCharge.Size = new System.Drawing.Size(121, 19);
            this.totalPerCharge.TabIndex = 15;
            this.totalPerCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(486, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Rub";
            // 
            // totalSum
            // 
            this.totalSum.BackColor = System.Drawing.SystemColors.Control;
            this.totalSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalSum.Enabled = false;
            this.totalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalSum.Location = new System.Drawing.Point(311, 48);
            this.totalSum.Name = "totalSum";
            this.totalSum.Size = new System.Drawing.Size(169, 46);
            this.totalSum.TabIndex = 14;
            this.totalSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.Firebrick;
            this.countButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countButton.Location = new System.Drawing.Point(15, 25);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(290, 85);
            this.countButton.TabIndex = 0;
            this.countButton.Text = "COUNT";
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // timerCloseForm
            // 
            this.timerCloseForm.Interval = 10000;
            this.timerCloseForm.Tick += new System.EventHandler(this.timerCloseForm_Tick);
            // 
            // closeCharge
            // 
            this.closeCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeCharge.ForeColor = System.Drawing.Color.Green;
            this.closeCharge.Location = new System.Drawing.Point(489, 86);
            this.closeCharge.Name = "closeCharge";
            this.closeCharge.Size = new System.Drawing.Size(231, 23);
            this.closeCharge.TabIndex = 18;
            this.closeCharge.Text = "close the charge";
            this.closeCharge.UseVisualStyleBackColor = true;
            this.closeCharge.Click += new System.EventHandler(this.closeCharge_Click);
            // 
            // FuelStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 607);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PetrolGroupBox);
            this.Controls.Add(this.cafeGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FuelStationForm";
            this.Text = "FuelStation";
            this.PetrolGroupBox.ResumeLayout(false);
            this.PetrolGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cafeGroupBox.ResumeLayout(false);
            this.cafeGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox PetrolGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PetrolType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceTypeOfPetrol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ByMoney;
        private System.Windows.Forms.RadioButton ByLitres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buyMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox buyLitres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SumForPetrol;
        private System.Windows.Forms.GroupBox cafeGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SumCafe;
        private System.Windows.Forms.TextBox colaNum;
        private System.Windows.Forms.TextBox colaPrice;
        private System.Windows.Forms.CheckBox colaCheck;
        private System.Windows.Forms.TextBox potatoNum;
        private System.Windows.Forms.TextBox potatoPrice;
        private System.Windows.Forms.CheckBox potatoCheck;
        private System.Windows.Forms.TextBox hamburgerNum;
        private System.Windows.Forms.TextBox hamburgerPrice;
        private System.Windows.Forms.CheckBox hamburgerCheck;
        private System.Windows.Forms.TextBox hotDogNum;
        private System.Windows.Forms.TextBox hotDogPrice;
        private System.Windows.Forms.CheckBox hotDogCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalSum;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Timer timerCloseForm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox totalPerCharge;
        private System.Windows.Forms.Button closeCharge;
    }
}

