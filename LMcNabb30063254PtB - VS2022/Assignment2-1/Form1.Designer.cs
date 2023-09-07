using static Assignment2_1.Program;
using System.Collections.Generic;

namespace Assignment2_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.general = new System.Windows.Forms.Button();
            this.motors = new System.Windows.Forms.Button();
            this.property = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.LisitingTitle = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Coniditon = new System.Windows.Forms.Label();
            this.generalinput = new System.Windows.Forms.GroupBox();
            this.newbutton = new System.Windows.Forms.RadioButton();
            this.usedbutton = new System.Windows.Forms.RadioButton();
            this.gensubmit = new System.Windows.Forms.Button();
            this.carinput = new System.Windows.Forms.GroupBox();
            this.newcar = new System.Windows.Forms.RadioButton();
            this.usedcar = new System.Windows.Forms.RadioButton();
            this.carsubmit = new System.Windows.Forms.Button();
            this.CarReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceCar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleCar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.generalcheck = new System.Windows.Forms.RadioButton();
            this.propcheck = new System.Windows.Forms.RadioButton();
            this.motorscheck = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.ListBox();
            this.propertyinput = new System.Windows.Forms.GroupBox();
            this.Suburb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Numbeds = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.propsubmit = new System.Windows.Forms.Button();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PriceProp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.marketplaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalinput.SuspendLayout();
            this.carinput.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.propertyinput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketplaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // general
            // 
            this.general.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.general.Location = new System.Drawing.Point(20, 19);
            this.general.Name = "general";
            this.general.Size = new System.Drawing.Size(124, 34);
            this.general.TabIndex = 1;
            this.general.Text = "General";
            this.general.UseVisualStyleBackColor = false;
            this.general.Click += new System.EventHandler(this.general_Click);
            // 
            // motors
            // 
            this.motors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.motors.Location = new System.Drawing.Point(20, 81);
            this.motors.Name = "motors";
            this.motors.Size = new System.Drawing.Size(124, 34);
            this.motors.TabIndex = 2;
            this.motors.Text = "Motors";
            this.motors.UseVisualStyleBackColor = false;
            this.motors.Click += new System.EventHandler(this.motors_Click);
            // 
            // property
            // 
            this.property.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.property.Location = new System.Drawing.Point(20, 146);
            this.property.Name = "property";
            this.property.Size = new System.Drawing.Size(124, 34);
            this.property.TabIndex = 3;
            this.property.Text = "Property";
            this.property.UseVisualStyleBackColor = false;
            this.property.Click += new System.EventHandler(this.property_Click);
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(87, 34);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(246, 20);
            this.TitleBox.TabIndex = 4;
            // 
            // DescBox
            // 
            this.DescBox.Location = new System.Drawing.Point(87, 68);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(246, 61);
            this.DescBox.TabIndex = 5;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(87, 142);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(246, 20);
            this.PriceBox.TabIndex = 6;
            // 
            // LisitingTitle
            // 
            this.LisitingTitle.AutoSize = true;
            this.LisitingTitle.Location = new System.Drawing.Point(21, 37);
            this.LisitingTitle.Name = "LisitingTitle";
            this.LisitingTitle.Size = new System.Drawing.Size(60, 13);
            this.LisitingTitle.TabIndex = 7;
            this.LisitingTitle.Text = "Listing Title";
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(21, 71);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(60, 13);
            this.Desc.TabIndex = 8;
            this.Desc.Text = "Description";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(50, 145);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 9;
            this.Price.Text = "Price";
            // 
            // Coniditon
            // 
            this.Coniditon.AutoSize = true;
            this.Coniditon.Location = new System.Drawing.Point(30, 176);
            this.Coniditon.Name = "Coniditon";
            this.Coniditon.Size = new System.Drawing.Size(51, 13);
            this.Coniditon.TabIndex = 11;
            this.Coniditon.Text = "Condition";
            // 
            // generalinput
            // 
            this.generalinput.Controls.Add(this.newbutton);
            this.generalinput.Controls.Add(this.usedbutton);
            this.generalinput.Controls.Add(this.gensubmit);
            this.generalinput.Controls.Add(this.DescBox);
            this.generalinput.Controls.Add(this.Coniditon);
            this.generalinput.Controls.Add(this.Desc);
            this.generalinput.Controls.Add(this.PriceBox);
            this.generalinput.Controls.Add(this.Price);
            this.generalinput.Controls.Add(this.LisitingTitle);
            this.generalinput.Controls.Add(this.TitleBox);
            this.generalinput.Location = new System.Drawing.Point(38, 117);
            this.generalinput.Name = "generalinput";
            this.generalinput.Size = new System.Drawing.Size(371, 245);
            this.generalinput.TabIndex = 14;
            this.generalinput.TabStop = false;
            this.generalinput.Text = "Add a General Lisiting";
            // 
            // newbutton
            // 
            this.newbutton.AutoSize = true;
            this.newbutton.Location = new System.Drawing.Point(156, 176);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(47, 17);
            this.newbutton.TabIndex = 16;
            this.newbutton.TabStop = true;
            this.newbutton.Text = "New";
            this.newbutton.UseVisualStyleBackColor = true;
            // 
            // usedbutton
            // 
            this.usedbutton.AutoSize = true;
            this.usedbutton.Location = new System.Drawing.Point(100, 176);
            this.usedbutton.Name = "usedbutton";
            this.usedbutton.Size = new System.Drawing.Size(50, 17);
            this.usedbutton.TabIndex = 15;
            this.usedbutton.TabStop = true;
            this.usedbutton.Text = "Used";
            this.usedbutton.UseVisualStyleBackColor = true;
            // 
            // gensubmit
            // 
            this.gensubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gensubmit.Location = new System.Drawing.Point(42, 204);
            this.gensubmit.Name = "gensubmit";
            this.gensubmit.Size = new System.Drawing.Size(281, 30);
            this.gensubmit.TabIndex = 9;
            this.gensubmit.Text = "Submit";
            this.gensubmit.UseVisualStyleBackColor = false;
            this.gensubmit.Click += new System.EventHandler(this.gensubmit_Click);
            // 
            // carinput
            // 
            this.carinput.Controls.Add(this.newcar);
            this.carinput.Controls.Add(this.usedcar);
            this.carinput.Controls.Add(this.carsubmit);
            this.carinput.Controls.Add(this.CarReg);
            this.carinput.Controls.Add(this.label1);
            this.carinput.Controls.Add(this.label2);
            this.carinput.Controls.Add(this.PriceCar);
            this.carinput.Controls.Add(this.label3);
            this.carinput.Controls.Add(this.label4);
            this.carinput.Controls.Add(this.TitleCar);
            this.carinput.Location = new System.Drawing.Point(619, 339);
            this.carinput.Name = "carinput";
            this.carinput.Size = new System.Drawing.Size(371, 230);
            this.carinput.TabIndex = 17;
            this.carinput.TabStop = false;
            this.carinput.Text = "Add a Motors Lisiting";
            // 
            // newcar
            // 
            this.newcar.AutoSize = true;
            this.newcar.Location = new System.Drawing.Point(164, 157);
            this.newcar.Name = "newcar";
            this.newcar.Size = new System.Drawing.Size(47, 17);
            this.newcar.TabIndex = 16;
            this.newcar.TabStop = true;
            this.newcar.Text = "New";
            this.newcar.UseVisualStyleBackColor = true;
            // 
            // usedcar
            // 
            this.usedcar.AutoSize = true;
            this.usedcar.Location = new System.Drawing.Point(108, 157);
            this.usedcar.Name = "usedcar";
            this.usedcar.Size = new System.Drawing.Size(50, 17);
            this.usedcar.TabIndex = 15;
            this.usedcar.TabStop = true;
            this.usedcar.Text = "Used";
            this.usedcar.UseVisualStyleBackColor = true;
            // 
            // carsubmit
            // 
            this.carsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.carsubmit.Location = new System.Drawing.Point(44, 185);
            this.carsubmit.Name = "carsubmit";
            this.carsubmit.Size = new System.Drawing.Size(281, 30);
            this.carsubmit.TabIndex = 9;
            this.carsubmit.Text = "Submit";
            this.carsubmit.UseVisualStyleBackColor = false;
            this.carsubmit.Click += new System.EventHandler(this.carsubmit_Click);
            // 
            // CarReg
            // 
            this.CarReg.Location = new System.Drawing.Point(93, 78);
            this.CarReg.Name = "CarReg";
            this.CarReg.Size = new System.Drawing.Size(246, 20);
            this.CarReg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Condition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Car Registration";
            // 
            // PriceCar
            // 
            this.PriceCar.Location = new System.Drawing.Point(95, 123);
            this.PriceCar.Name = "PriceCar";
            this.PriceCar.Size = new System.Drawing.Size(246, 20);
            this.PriceCar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Listing Title";
            // 
            // TitleCar
            // 
            this.TitleCar.Location = new System.Drawing.Point(93, 34);
            this.TitleCar.Name = "TitleCar";
            this.TitleCar.Size = new System.Drawing.Size(246, 20);
            this.TitleCar.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.generalcheck);
            this.groupBox3.Controls.Add(this.propcheck);
            this.groupBox3.Controls.Add(this.motorscheck);
            this.groupBox3.Location = new System.Drawing.Point(38, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 41);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select a listing type";
            // 
            // generalcheck
            // 
            this.generalcheck.AutoSize = true;
            this.generalcheck.Location = new System.Drawing.Point(6, 18);
            this.generalcheck.Name = "generalcheck";
            this.generalcheck.Size = new System.Drawing.Size(62, 17);
            this.generalcheck.TabIndex = 16;
            this.generalcheck.TabStop = true;
            this.generalcheck.Text = "General";
            this.generalcheck.UseVisualStyleBackColor = true;
            this.generalcheck.CheckedChanged += new System.EventHandler(this.generalcheck_CheckedChanged);
            // 
            // propcheck
            // 
            this.propcheck.AutoSize = true;
            this.propcheck.Location = new System.Drawing.Point(137, 18);
            this.propcheck.Name = "propcheck";
            this.propcheck.Size = new System.Drawing.Size(72, 17);
            this.propcheck.TabIndex = 18;
            this.propcheck.TabStop = true;
            this.propcheck.Text = "Properties";
            this.propcheck.UseVisualStyleBackColor = true;
            this.propcheck.CheckedChanged += new System.EventHandler(this.propcheck_CheckedChanged);
            // 
            // motorscheck
            // 
            this.motorscheck.AutoSize = true;
            this.motorscheck.Location = new System.Drawing.Point(74, 19);
            this.motorscheck.Name = "motorscheck";
            this.motorscheck.Size = new System.Drawing.Size(57, 17);
            this.motorscheck.TabIndex = 17;
            this.motorscheck.TabStop = true;
            this.motorscheck.Text = "Motors";
            this.motorscheck.UseVisualStyleBackColor = true;
            this.motorscheck.CheckedChanged += new System.EventHandler(this.motorscheck_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.general);
            this.groupBox2.Controls.Add(this.property);
            this.groupBox2.Controls.Add(this.motors);
            this.groupBox2.Location = new System.Drawing.Point(420, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 196);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View other listings...";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(62, 641);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(492, 23);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // display
            // 
            this.display.FormattingEnabled = true;
            this.display.Location = new System.Drawing.Point(38, 388);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(541, 251);
            this.display.TabIndex = 16;
            // 
            // propertyinput
            // 
            this.propertyinput.Controls.Add(this.Suburb);
            this.propertyinput.Controls.Add(this.label10);
            this.propertyinput.Controls.Add(this.Numbeds);
            this.propertyinput.Controls.Add(this.label9);
            this.propertyinput.Controls.Add(this.propsubmit);
            this.propertyinput.Controls.Add(this.CityBox);
            this.propertyinput.Controls.Add(this.label6);
            this.propertyinput.Controls.Add(this.PriceProp);
            this.propertyinput.Controls.Add(this.label7);
            this.propertyinput.Controls.Add(this.label8);
            this.propertyinput.Controls.Add(this.Address);
            this.propertyinput.Location = new System.Drawing.Point(619, 54);
            this.propertyinput.Name = "propertyinput";
            this.propertyinput.Size = new System.Drawing.Size(371, 231);
            this.propertyinput.TabIndex = 20;
            this.propertyinput.TabStop = false;
            this.propertyinput.Text = "Add a Property Lisiting";
            // 
            // Suburb
            // 
            this.Suburb.Location = new System.Drawing.Point(87, 114);
            this.Suburb.Name = "Suburb";
            this.Suburb.Size = new System.Drawing.Size(246, 20);
            this.Suburb.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Suburb";
            // 
            // Numbeds
            // 
            this.Numbeds.Location = new System.Drawing.Point(87, 86);
            this.Numbeds.Name = "Numbeds";
            this.Numbeds.Size = new System.Drawing.Size(246, 20);
            this.Numbeds.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bedrooms";
            // 
            // propsubmit
            // 
            this.propsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.propsubmit.Location = new System.Drawing.Point(42, 188);
            this.propsubmit.Name = "propsubmit";
            this.propsubmit.Size = new System.Drawing.Size(281, 30);
            this.propsubmit.TabIndex = 9;
            this.propsubmit.Text = "Submit";
            this.propsubmit.UseVisualStyleBackColor = false;
            this.propsubmit.Click += new System.EventHandler(this.propsubmit_Click);
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(87, 60);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(246, 20);
            this.CityBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "City";
            // 
            // PriceProp
            // 
            this.PriceProp.Location = new System.Drawing.Point(87, 145);
            this.PriceProp.Name = "PriceProp";
            this.PriceProp.Size = new System.Drawing.Size(246, 20);
            this.PriceProp.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Street Address";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(87, 34);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(246, 20);
            this.Address.TabIndex = 4;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(35, 361);
            this.name.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.name.MinimumSize = new System.Drawing.Size(200, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 13);
            this.name.TabIndex = 21;
            this.name.Text = "label5";
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Location = new System.Drawing.Point(35, 9);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(81, 13);
            this.name2.TabIndex = 22;
            this.name2.Text = "FlickOff Listings";
            this.name2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment2_1.Properties.Resources.image_2023_06_08_130808571_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(420, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 170);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // marketplaceBindingSource
            // 
            this.marketplaceBindingSource.DataSource = typeof(Assignment2_1.Listing.Marketplace);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 667);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.propertyinput);
            this.Controls.Add(this.carinput);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.display);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.generalinput);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "FlickOff";
            this.Load += new System.EventHandler(this.FlickOff_Load);
            this.generalinput.ResumeLayout(false);
            this.generalinput.PerformLayout();
            this.carinput.ResumeLayout(false);
            this.carinput.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.propertyinput.ResumeLayout(false);
            this.propertyinput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketplaceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource marketplaceBindingSource;
        private System.Windows.Forms.Button general;
        private System.Windows.Forms.Button motors;
        private System.Windows.Forms.Button property;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label LisitingTitle;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Coniditon;
        private System.Windows.Forms.GroupBox generalinput;
        private System.Windows.Forms.Button gensubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton newbutton;
        private System.Windows.Forms.RadioButton usedbutton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton generalcheck;
        private System.Windows.Forms.RadioButton propcheck;
        private System.Windows.Forms.RadioButton motorscheck;
        private System.Windows.Forms.ListBox display;
        private System.Windows.Forms.GroupBox carinput;
        private System.Windows.Forms.RadioButton newcar;
        private System.Windows.Forms.RadioButton usedcar;
        private System.Windows.Forms.Button carsubmit;
        private System.Windows.Forms.TextBox CarReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TitleCar;
        private System.Windows.Forms.GroupBox propertyinput;
        private System.Windows.Forms.Button propsubmit;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PriceProp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Numbeds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Suburb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

