namespace PetrolStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuelStationForm));
            this.PetrolGroup = new System.Windows.Forms.GroupBox();
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
            this.PetrolGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PetrolGroup
            // 
            this.PetrolGroup.BackColor = System.Drawing.SystemColors.Control;
            this.PetrolGroup.Controls.Add(this.label5);
            this.PetrolGroup.Controls.Add(this.buyMoney);
            this.PetrolGroup.Controls.Add(this.label4);
            this.PetrolGroup.Controls.Add(this.buyLitres);
            this.PetrolGroup.Controls.Add(this.label3);
            this.PetrolGroup.Controls.Add(this.ByMoney);
            this.PetrolGroup.Controls.Add(this.ByLitres);
            this.PetrolGroup.Controls.Add(this.PriceTypeOfPetrol);
            this.PetrolGroup.Controls.Add(this.label2);
            this.PetrolGroup.Controls.Add(this.label1);
            this.PetrolGroup.Controls.Add(this.PetrolType);
            this.PetrolGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetrolGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetrolGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PetrolGroup.Location = new System.Drawing.Point(0, 0);
            this.PetrolGroup.Name = "PetrolGroup";
            this.PetrolGroup.Size = new System.Drawing.Size(372, 449);
            this.PetrolGroup.TabIndex = 1;
            this.PetrolGroup.TabStop = false;
            this.PetrolGroup.Text = "PetrolControl";
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
            this.buyMoney.Location = new System.Drawing.Point(171, 224);
            this.buyMoney.Name = "buyMoney";
            this.buyMoney.Size = new System.Drawing.Size(115, 30);
            this.buyMoney.TabIndex = 11;
            this.buyMoney.TextChanged += new System.EventHandler(this.buyMoney_TextChanged);
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
            this.buyLitres.Location = new System.Drawing.Point(171, 176);
            this.buyLitres.Name = "buyLitres";
            this.buyLitres.Size = new System.Drawing.Size(115, 30);
            this.buyLitres.TabIndex = 9;
            this.buyLitres.TextChanged += new System.EventHandler(this.buyLitres_TextChanged);
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
            this.PetrolType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetrolType.FormattingEnabled = true;
            this.PetrolType.Items.AddRange(new object[] {
            "Аи-76",
            "Аи-92",
            "Аи-95",
            "Аи-100",
            "ДТ",
            "биоДТ",
            "закись азота"});
            this.PetrolType.Location = new System.Drawing.Point(171, 29);
            this.PetrolType.Name = "PetrolType";
            this.PetrolType.Size = new System.Drawing.Size(194, 28);
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
            this.SumForPetrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumForPetrol.Location = new System.Drawing.Point(143, 63);
            this.SumForPetrol.Name = "SumForPetrol";
            this.SumForPetrol.Size = new System.Drawing.Size(100, 38);
            this.SumForPetrol.TabIndex = 0;
            // 
            // FuelStationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PetrolGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FuelStationForm";
            this.Text = "FuelStation";
            this.PetrolGroup.ResumeLayout(false);
            this.PetrolGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox PetrolGroup;
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
    }
}

