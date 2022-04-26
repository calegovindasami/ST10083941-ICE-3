
namespace ICE_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHead = new System.Windows.Forms.Label();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.lblAttrOne = new System.Windows.Forms.Label();
            this.lblAttrTwo = new System.Windows.Forms.Label();
            this.lblAttrThree = new System.Windows.Forms.Label();
            this.lblAttrFour = new System.Windows.Forms.Label();
            this.lblAttrFive = new System.Windows.Forms.Label();
            this.lblAttrSix = new System.Windows.Forms.Label();
            this.boxAttrOne = new System.Windows.Forms.TextBox();
            this.boxAttrTwo = new System.Windows.Forms.TextBox();
            this.boxAttrThree = new System.Windows.Forms.TextBox();
            this.boxAttrFour = new System.Windows.Forms.TextBox();
            this.boxAttrFive = new System.Windows.Forms.TextBox();
            this.boxAttrSix = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Location = new System.Drawing.Point(13, 9);
            this.lblHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(168, 21);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Please select a vehicle: ";
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Items.AddRange(new object[] {
            "Car",
            "Airplane",
            "Boat",
            "Helicopter",
            "Submarine"});
            this.cmbVehicle.Location = new System.Drawing.Point(239, 12);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(277, 29);
            this.cmbVehicle.TabIndex = 1;
            this.cmbVehicle.SelectedIndexChanged += new System.EventHandler(this.cmbVehicle_SelectedIndexChanged);
            // 
            // lblAttrOne
            // 
            this.lblAttrOne.AutoSize = true;
            this.lblAttrOne.Location = new System.Drawing.Point(23, 99);
            this.lblAttrOne.Name = "lblAttrOne";
            this.lblAttrOne.Size = new System.Drawing.Size(89, 21);
            this.lblAttrOne.TabIndex = 2;
            this.lblAttrOne.Text = "EngineType";
            // 
            // lblAttrTwo
            // 
            this.lblAttrTwo.AutoSize = true;
            this.lblAttrTwo.Location = new System.Drawing.Point(23, 167);
            this.lblAttrTwo.Name = "lblAttrTwo";
            this.lblAttrTwo.Size = new System.Drawing.Size(127, 21);
            this.lblAttrTwo.TabIndex = 3;
            this.lblAttrTwo.Text = "Number of Seats";
            // 
            // lblAttrThree
            // 
            this.lblAttrThree.AutoSize = true;
            this.lblAttrThree.Location = new System.Drawing.Point(23, 235);
            this.lblAttrThree.Name = "lblAttrThree";
            this.lblAttrThree.Size = new System.Drawing.Size(87, 21);
            this.lblAttrThree.TabIndex = 4;
            this.lblAttrThree.Text = "Body Color";
            // 
            // lblAttrFour
            // 
            this.lblAttrFour.AutoSize = true;
            this.lblAttrFour.Location = new System.Drawing.Point(23, 300);
            this.lblAttrFour.Name = "lblAttrFour";
            this.lblAttrFour.Size = new System.Drawing.Size(52, 21);
            this.lblAttrFour.TabIndex = 5;
            this.lblAttrFour.Text = "label4";
            // 
            // lblAttrFive
            // 
            this.lblAttrFive.AutoSize = true;
            this.lblAttrFive.Location = new System.Drawing.Point(23, 363);
            this.lblAttrFive.Name = "lblAttrFive";
            this.lblAttrFive.Size = new System.Drawing.Size(52, 21);
            this.lblAttrFive.TabIndex = 6;
            this.lblAttrFive.Text = "label5";
            // 
            // lblAttrSix
            // 
            this.lblAttrSix.AutoSize = true;
            this.lblAttrSix.Location = new System.Drawing.Point(23, 434);
            this.lblAttrSix.Name = "lblAttrSix";
            this.lblAttrSix.Size = new System.Drawing.Size(52, 21);
            this.lblAttrSix.TabIndex = 7;
            this.lblAttrSix.Text = "label6";
            // 
            // boxAttrOne
            // 
            this.boxAttrOne.Location = new System.Drawing.Point(280, 91);
            this.boxAttrOne.Name = "boxAttrOne";
            this.boxAttrOne.Size = new System.Drawing.Size(210, 29);
            this.boxAttrOne.TabIndex = 8;
            // 
            // boxAttrTwo
            // 
            this.boxAttrTwo.Location = new System.Drawing.Point(280, 159);
            this.boxAttrTwo.Name = "boxAttrTwo";
            this.boxAttrTwo.Size = new System.Drawing.Size(210, 29);
            this.boxAttrTwo.TabIndex = 9;
            // 
            // boxAttrThree
            // 
            this.boxAttrThree.Location = new System.Drawing.Point(280, 227);
            this.boxAttrThree.Name = "boxAttrThree";
            this.boxAttrThree.Size = new System.Drawing.Size(210, 29);
            this.boxAttrThree.TabIndex = 10;
            // 
            // boxAttrFour
            // 
            this.boxAttrFour.Location = new System.Drawing.Point(280, 292);
            this.boxAttrFour.Name = "boxAttrFour";
            this.boxAttrFour.Size = new System.Drawing.Size(210, 29);
            this.boxAttrFour.TabIndex = 11;
            // 
            // boxAttrFive
            // 
            this.boxAttrFive.Location = new System.Drawing.Point(280, 355);
            this.boxAttrFive.Name = "boxAttrFive";
            this.boxAttrFive.Size = new System.Drawing.Size(210, 29);
            this.boxAttrFive.TabIndex = 12;
            // 
            // boxAttrSix
            // 
            this.boxAttrSix.Location = new System.Drawing.Point(280, 426);
            this.boxAttrSix.Name = "boxAttrSix";
            this.boxAttrSix.Size = new System.Drawing.Size(210, 29);
            this.boxAttrSix.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(159, 488);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(261, 69);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 590);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.boxAttrSix);
            this.Controls.Add(this.boxAttrFive);
            this.Controls.Add(this.boxAttrFour);
            this.Controls.Add(this.boxAttrThree);
            this.Controls.Add(this.boxAttrTwo);
            this.Controls.Add(this.boxAttrOne);
            this.Controls.Add(this.lblAttrSix);
            this.Controls.Add(this.lblAttrFive);
            this.Controls.Add(this.lblAttrFour);
            this.Controls.Add(this.lblAttrThree);
            this.Controls.Add(this.lblAttrTwo);
            this.Controls.Add(this.lblAttrOne);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.lblHead);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label lblAttrOne;
        private System.Windows.Forms.Label lblAttrTwo;
        private System.Windows.Forms.Label lblAttrThree;
        private System.Windows.Forms.Label lblAttrFour;
        private System.Windows.Forms.Label lblAttrFive;
        private System.Windows.Forms.Label lblAttrSix;
        private System.Windows.Forms.TextBox boxAttrOne;
        private System.Windows.Forms.TextBox boxAttrTwo;
        private System.Windows.Forms.TextBox boxAttrThree;
        private System.Windows.Forms.TextBox boxAttrFour;
        private System.Windows.Forms.TextBox boxAttrFive;
        private System.Windows.Forms.TextBox boxAttrSix;
        private System.Windows.Forms.Button btnSubmit;
    }
}

