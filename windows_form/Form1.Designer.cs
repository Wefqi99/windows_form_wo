namespace windows_form
{
    partial class frmdelivery
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
            this.gbcustinfo = new System.Windows.Forms.GroupBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblcname = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.gbdriver = new System.Windows.Forms.GroupBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txtdname = new System.Windows.Forms.TextBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldname = new System.Windows.Forms.Label();
            this.gbpizzasize = new System.Windows.Forms.GroupBox();
            this.lstsize = new System.Windows.Forms.ListBox();
            this.gbtoppings = new System.Windows.Forms.GroupBox();
            this.chkveggie = new System.Windows.Forms.CheckBox();
            this.chkmeat = new System.Windows.Forms.CheckBox();
            this.chkcheese = new System.Windows.Forms.CheckBox();
            this.gbtip = new System.Windows.Forms.GroupBox();
            this.rbfifteen = new System.Windows.Forms.RadioButton();
            this.rbeighteen = new System.Windows.Forms.RadioButton();
            this.rbten = new System.Windows.Forms.RadioButton();
            this.lblinstruction = new System.Windows.Forms.Label();
            this.rtbinstruction = new System.Windows.Forms.RichTextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblclist = new System.Windows.Forms.Label();
            this.ddclist = new System.Windows.Forms.ComboBox();
            this.gbcustinfo.SuspendLayout();
            this.gbdriver.SuspendLayout();
            this.gbpizzasize.SuspendLayout();
            this.gbtoppings.SuspendLayout();
            this.gbtip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbcustinfo
            // 
            this.gbcustinfo.Controls.Add(this.txtaddress);
            this.gbcustinfo.Controls.Add(this.txtcname);
            this.gbcustinfo.Controls.Add(this.txtdate);
            this.gbcustinfo.Controls.Add(this.lbladdress);
            this.gbcustinfo.Controls.Add(this.lblcname);
            this.gbcustinfo.Controls.Add(this.lbldate);
            this.gbcustinfo.Location = new System.Drawing.Point(37, 24);
            this.gbcustinfo.Name = "gbcustinfo";
            this.gbcustinfo.Size = new System.Drawing.Size(227, 140);
            this.gbcustinfo.TabIndex = 0;
            this.gbcustinfo.TabStop = false;
            this.gbcustinfo.Text = "Customer Information";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(79, 102);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(100, 22);
            this.txtaddress.TabIndex = 5;
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(79, 67);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(100, 22);
            this.txtcname.TabIndex = 4;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(79, 31);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 22);
            this.txtdate.TabIndex = 3;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(15, 105);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(58, 16);
            this.lbladdress.TabIndex = 2;
            this.lbladdress.Text = "Address";
            // 
            // lblcname
            // 
            this.lblcname.AutoSize = true;
            this.lblcname.Location = new System.Drawing.Point(15, 67);
            this.lblcname.Name = "lblcname";
            this.lblcname.Size = new System.Drawing.Size(44, 16);
            this.lblcname.TabIndex = 1;
            this.lblcname.Text = "Name";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(15, 31);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(36, 16);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Date";
            this.lbldate.Click += new System.EventHandler(this.lbldate_Click);
            // 
            // gbdriver
            // 
            this.gbdriver.Controls.Add(this.txttime);
            this.gbdriver.Controls.Add(this.txtdname);
            this.gbdriver.Controls.Add(this.lbltime);
            this.gbdriver.Controls.Add(this.lbldname);
            this.gbdriver.Location = new System.Drawing.Point(37, 180);
            this.gbdriver.Name = "gbdriver";
            this.gbdriver.Size = new System.Drawing.Size(227, 123);
            this.gbdriver.TabIndex = 1;
            this.gbdriver.TabStop = false;
            this.gbdriver.Text = "Driver Information";
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(104, 79);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(100, 22);
            this.txttime.TabIndex = 3;
            // 
            // txtdname
            // 
            this.txtdname.Location = new System.Drawing.Point(104, 36);
            this.txtdname.Name = "txtdname";
            this.txtdname.Size = new System.Drawing.Size(100, 22);
            this.txtdname.TabIndex = 2;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(15, 85);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(62, 16);
            this.lbltime.TabIndex = 1;
            this.lbltime.Text = "Time-Out";
            this.lbltime.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbldname
            // 
            this.lbldname.AutoSize = true;
            this.lbldname.Location = new System.Drawing.Point(15, 39);
            this.lbldname.Name = "lbldname";
            this.lbldname.Size = new System.Drawing.Size(83, 16);
            this.lbldname.TabIndex = 0;
            this.lbldname.Text = "Driver Name";
            // 
            // gbpizzasize
            // 
            this.gbpizzasize.Controls.Add(this.lstsize);
            this.gbpizzasize.Location = new System.Drawing.Point(326, 114);
            this.gbpizzasize.Name = "gbpizzasize";
            this.gbpizzasize.Size = new System.Drawing.Size(172, 136);
            this.gbpizzasize.TabIndex = 8;
            this.gbpizzasize.TabStop = false;
            this.gbpizzasize.Text = "Pizza SIze";
            // 
            // lstsize
            // 
            this.lstsize.FormattingEnabled = true;
            this.lstsize.ItemHeight = 16;
            this.lstsize.Items.AddRange(new object[] {
            "Small ",
            "Mediuam",
            "Large ",
            "XL Large",
            "Stadium",
            "Party"});
            this.lstsize.Location = new System.Drawing.Point(23, 21);
            this.lstsize.Name = "lstsize";
            this.lstsize.Size = new System.Drawing.Size(143, 100);
            this.lstsize.TabIndex = 0;
            this.lstsize.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gbtoppings
            // 
            this.gbtoppings.Controls.Add(this.chkveggie);
            this.gbtoppings.Controls.Add(this.chkmeat);
            this.gbtoppings.Controls.Add(this.chkcheese);
            this.gbtoppings.Location = new System.Drawing.Point(611, 114);
            this.gbtoppings.Name = "gbtoppings";
            this.gbtoppings.Size = new System.Drawing.Size(159, 136);
            this.gbtoppings.TabIndex = 9;
            this.gbtoppings.TabStop = false;
            this.gbtoppings.Text = "Pizza Toppings";
            // 
            // chkveggie
            // 
            this.chkveggie.AutoSize = true;
            this.chkveggie.Location = new System.Drawing.Point(7, 97);
            this.chkveggie.Name = "chkveggie";
            this.chkveggie.Size = new System.Drawing.Size(80, 20);
            this.chkveggie.TabIndex = 2;
            this.chkveggie.Text = "Veggies";
            this.chkveggie.UseVisualStyleBackColor = true;
            // 
            // chkmeat
            // 
            this.chkmeat.AutoSize = true;
            this.chkmeat.Location = new System.Drawing.Point(6, 63);
            this.chkmeat.Name = "chkmeat";
            this.chkmeat.Size = new System.Drawing.Size(59, 20);
            this.chkmeat.TabIndex = 1;
            this.chkmeat.Text = "Meat";
            this.chkmeat.UseVisualStyleBackColor = true;
            this.chkmeat.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkcheese
            // 
            this.chkcheese.AutoSize = true;
            this.chkcheese.Location = new System.Drawing.Point(7, 28);
            this.chkcheese.Name = "chkcheese";
            this.chkcheese.Size = new System.Drawing.Size(76, 20);
            this.chkcheese.TabIndex = 0;
            this.chkcheese.Text = "Cheese";
            this.chkcheese.UseVisualStyleBackColor = true;
            // 
            // gbtip
            // 
            this.gbtip.Controls.Add(this.rbfifteen);
            this.gbtip.Controls.Add(this.rbeighteen);
            this.gbtip.Controls.Add(this.rbten);
            this.gbtip.Location = new System.Drawing.Point(37, 309);
            this.gbtip.Name = "gbtip";
            this.gbtip.Size = new System.Drawing.Size(114, 129);
            this.gbtip.TabIndex = 10;
            this.gbtip.TabStop = false;
            this.gbtip.Text = "Tip Percentage";
            // 
            // rbfifteen
            // 
            this.rbfifteen.AutoSize = true;
            this.rbfifteen.Location = new System.Drawing.Point(6, 68);
            this.rbfifteen.Name = "rbfifteen";
            this.rbfifteen.Size = new System.Drawing.Size(54, 20);
            this.rbfifteen.TabIndex = 11;
            this.rbfifteen.Text = "15%";
            this.rbfifteen.UseVisualStyleBackColor = true;
            // 
            // rbeighteen
            // 
            this.rbeighteen.AutoSize = true;
            this.rbeighteen.Location = new System.Drawing.Point(5, 94);
            this.rbeighteen.Name = "rbeighteen";
            this.rbeighteen.Size = new System.Drawing.Size(54, 20);
            this.rbeighteen.TabIndex = 1;
            this.rbeighteen.Text = "18%";
            this.rbeighteen.UseVisualStyleBackColor = true;
            // 
            // rbten
            // 
            this.rbten.AutoSize = true;
            this.rbten.Checked = true;
            this.rbten.Location = new System.Drawing.Point(6, 42);
            this.rbten.Name = "rbten";
            this.rbten.Size = new System.Drawing.Size(54, 20);
            this.rbten.TabIndex = 0;
            this.rbten.TabStop = true;
            this.rbten.Text = "10%";
            this.rbten.UseVisualStyleBackColor = true;
            // 
            // lblinstruction
            // 
            this.lblinstruction.AutoSize = true;
            this.lblinstruction.Location = new System.Drawing.Point(270, 262);
            this.lblinstruction.Name = "lblinstruction";
            this.lblinstruction.Size = new System.Drawing.Size(122, 16);
            this.lblinstruction.TabIndex = 11;
            this.lblinstruction.Text = "Special Instructions";
            // 
            // rtbinstruction
            // 
            this.rtbinstruction.Location = new System.Drawing.Point(270, 288);
            this.rtbinstruction.Name = "rtbinstruction";
            this.rtbinstruction.Size = new System.Drawing.Size(500, 104);
            this.rtbinstruction.TabIndex = 12;
            this.rtbinstruction.Text = "";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(686, 398);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(99, 40);
            this.btnsubmit.TabIndex = 13;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::windows_form.Properties.Resources.dinicos_pizza;
            this.pictureBox1.Location = new System.Drawing.Point(300, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblclist
            // 
            this.lblclist.AutoSize = true;
            this.lblclist.Location = new System.Drawing.Point(451, 24);
            this.lblclist.Name = "lblclist";
            this.lblclist.Size = new System.Drawing.Size(127, 16);
            this.lblclist.TabIndex = 15;
            this.lblclist.Text = "Previous Customers";
            this.lblclist.Click += new System.EventHandler(this.lblclist_Click);
            // 
            // ddclist
            // 
            this.ddclist.FormattingEnabled = true;
            this.ddclist.Location = new System.Drawing.Point(584, 16);
            this.ddclist.Name = "ddclist";
            this.ddclist.Size = new System.Drawing.Size(186, 24);
            this.ddclist.TabIndex = 16;
            this.ddclist.SelectedIndexChanged += new System.EventHandler(this.ddclist_SelectedIndexChanged);
            // 
            // frmdelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddclist);
            this.Controls.Add(this.lblclist);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.rtbinstruction);
            this.Controls.Add(this.lblinstruction);
            this.Controls.Add(this.gbtip);
            this.Controls.Add(this.gbtoppings);
            this.Controls.Add(this.gbpizzasize);
            this.Controls.Add(this.gbdriver);
            this.Controls.Add(this.gbcustinfo);
            this.Name = "frmdelivery";
            this.Text = "Dinico\'s Pizza Delivery System";
            this.Load += new System.EventHandler(this.frmdelivery_Load);
            this.Click += new System.EventHandler(this.frmdelivery_Click);
            this.gbcustinfo.ResumeLayout(false);
            this.gbcustinfo.PerformLayout();
            this.gbdriver.ResumeLayout(false);
            this.gbdriver.PerformLayout();
            this.gbpizzasize.ResumeLayout(false);
            this.gbtoppings.ResumeLayout(false);
            this.gbtoppings.PerformLayout();
            this.gbtip.ResumeLayout(false);
            this.gbtip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbcustinfo;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblcname;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.GroupBox gbdriver;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldname;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.TextBox txtdname;
        private System.Windows.Forms.GroupBox gbpizzasize;
        private System.Windows.Forms.ListBox lstsize;
        private System.Windows.Forms.GroupBox gbtoppings;
        private System.Windows.Forms.CheckBox chkveggie;
        private System.Windows.Forms.CheckBox chkmeat;
        private System.Windows.Forms.CheckBox chkcheese;
        private System.Windows.Forms.GroupBox gbtip;
        private System.Windows.Forms.RadioButton rbfifteen;
        private System.Windows.Forms.RadioButton rbeighteen;
        private System.Windows.Forms.RadioButton rbten;
        private System.Windows.Forms.Label lblinstruction;
        private System.Windows.Forms.RichTextBox rtbinstruction;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblclist;
        private System.Windows.Forms.ComboBox ddclist;
    }
}

