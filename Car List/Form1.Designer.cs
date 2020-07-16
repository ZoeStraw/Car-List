namespace Car_List
{
    partial class frm
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
            this.lstMake = new System.Windows.Forms.ComboBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lstYear = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chkNew = new System.Windows.Forms.CheckBox();
            this.lvwCars = new System.Windows.Forms.ListView();
            this.lvwNew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwMake = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMake
            // 
            this.lstMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMake.FormattingEnabled = true;
            this.lstMake.Items.AddRange(new object[] {
            "Ferrari",
            "Ford",
            "Honda",
            "Mazerati",
            "Mitsubishi"});
            this.lstMake.Location = new System.Drawing.Point(57, 13);
            this.lstMake.Name = "lstMake";
            this.lstMake.Size = new System.Drawing.Size(121, 21);
            this.lstMake.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(57, 41);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(121, 20);
            this.txtModel.TabIndex = 1;
            // 
            // lstYear
            // 
            this.lstYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstYear.FormattingEnabled = true;
            this.lstYear.Location = new System.Drawing.Point(57, 68);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(121, 21);
            this.lstYear.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(57, 96);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // chkNew
            // 
            this.chkNew.AutoSize = true;
            this.chkNew.Location = new System.Drawing.Point(57, 123);
            this.chkNew.Name = "chkNew";
            this.chkNew.Size = new System.Drawing.Size(48, 17);
            this.chkNew.TabIndex = 4;
            this.chkNew.Text = "New";
            this.chkNew.UseVisualStyleBackColor = true;
            // 
            // lvwCars
            // 
            this.lvwCars.CheckBoxes = true;
            this.lvwCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvwNew,
            this.lvwMake,
            this.lvwModel,
            this.lvwYear,
            this.lvwPrice});
            this.lvwCars.FullRowSelect = true;
            this.lvwCars.HideSelection = false;
            this.lvwCars.Location = new System.Drawing.Point(-1, 148);
            this.lvwCars.MultiSelect = false;
            this.lvwCars.Name = "lvwCars";
            this.lvwCars.Size = new System.Drawing.Size(466, 232);
            this.lvwCars.TabIndex = 5;
            this.lvwCars.UseCompatibleStateImageBehavior = false;
            this.lvwCars.View = System.Windows.Forms.View.Details;
            this.lvwCars.SelectedIndexChanged += new System.EventHandler(this.lvwCars_SelectedIndexChanged);
            // 
            // lvwNew
            // 
            this.lvwNew.Text = "New";
            this.lvwNew.Width = 69;
            // 
            // lvwMake
            // 
            this.lvwMake.Text = "Make";
            this.lvwMake.Width = 130;
            // 
            // lvwModel
            // 
            this.lvwModel.Text = "Model";
            this.lvwModel.Width = 139;
            // 
            // lvwYear
            // 
            this.lvwYear.Text = "Year";
            this.lvwYear.Width = 52;
            // 
            // lvwPrice
            // 
            this.lvwPrice.Text = "Price";
            this.lvwPrice.Width = 72;
            // 
            // lblMake
            // 
            this.lblMake.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMake.Location = new System.Drawing.Point(10, 16);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(41, 13);
            this.lblMake.TabIndex = 6;
            this.lblMake.Text = "Make:";
            this.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModel
            // 
            this.lblModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblModel.Location = new System.Drawing.Point(8, 44);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(43, 13);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYear
            // 
            this.lblYear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblYear.Location = new System.Drawing.Point(15, 71);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(36, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year:";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(13, 99);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(-1, 386);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.Size = new System.Drawing.Size(466, 89);
            this.txtDetails.TabIndex = 10;
            this.txtDetails.Text = "Details";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(215, 482);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "&Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(296, 482);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(377, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(464, 517);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lvwCars);
            this.Controls.Add(this.chkNew);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lstMake);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Database";
            this.Load += new System.EventHandler(this.frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox lstYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox chkNew;
        private System.Windows.Forms.ListView lvwCars;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader lvwNew;
        private System.Windows.Forms.ColumnHeader lvwMake;
        private System.Windows.Forms.ColumnHeader lvwModel;
        private System.Windows.Forms.ColumnHeader lvwYear;
        private System.Windows.Forms.ColumnHeader lvwPrice;
    }
}

