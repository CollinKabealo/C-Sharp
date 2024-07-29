namespace Exercise1_Part2
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
            lblLengthDesc = new Label();
            lblWidthDesc = new Label();
            lblCostPerSqFtDesc = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            txtCostPerSqFt = new TextBox();
            label1 = new Label();
            lblFloorSizeCost = new Label();
            lblInstallationHoursCost = new Label();
            lblTotalCost = new Label();
            btnCalculateCost = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblLengthDesc
            // 
            lblLengthDesc.AutoSize = true;
            lblLengthDesc.Location = new Point(45, 31);
            lblLengthDesc.Name = "lblLengthDesc";
            lblLengthDesc.Size = new Size(135, 25);
            lblLengthDesc.TabIndex = 0;
            lblLengthDesc.Text = "Length of floor:";
            // 
            // lblWidthDesc
            // 
            lblWidthDesc.AutoSize = true;
            lblWidthDesc.Location = new Point(51, 72);
            lblWidthDesc.Name = "lblWidthDesc";
            lblWidthDesc.Size = new Size(129, 25);
            lblWidthDesc.TabIndex = 1;
            lblWidthDesc.Text = "Width of floor:";
            // 
            // lblCostPerSqFtDesc
            // 
            lblCostPerSqFtDesc.AutoSize = true;
            lblCostPerSqFtDesc.Location = new Point(0, 109);
            lblCostPerSqFtDesc.Name = "lblCostPerSqFtDesc";
            lblCostPerSqFtDesc.Size = new Size(180, 25);
            lblCostPerSqFtDesc.TabIndex = 2;
            lblCostPerSqFtDesc.Text = "Cost per square foot:";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(186, 31);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(150, 31);
            txtLength.TabIndex = 3;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(186, 66);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(150, 31);
            txtWidth.TabIndex = 4;
            // 
            // txtCostPerSqFt
            // 
            txtCostPerSqFt.Location = new Point(186, 103);
            txtCostPerSqFt.Name = "txtCostPerSqFt";
            txtCostPerSqFt.Size = new Size(150, 31);
            txtCostPerSqFt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 152);
            label1.Name = "label1";
            label1.Size = new Size(257, 25);
            label1.TabIndex = 6;
            label1.Text = "-----------------------------------";
            // 
            // lblFloorSizeCost
            // 
            lblFloorSizeCost.AutoSize = true;
            lblFloorSizeCost.Location = new Point(21, 177);
            lblFloorSizeCost.Name = "lblFloorSizeCost";
            lblFloorSizeCost.Size = new Size(338, 25);
            lblFloorSizeCost.TabIndex = 7;
            lblFloorSizeCost.Text = "Cost of total floor size of 1125: $5906.25";
            // 
            // lblInstallationHoursCost
            // 
            lblInstallationHoursCost.AutoSize = true;
            lblInstallationHoursCost.Location = new Point(12, 220);
            lblInstallationHoursCost.Name = "lblInstallationHoursCost";
            lblInstallationHoursCost.Size = new Size(556, 25);
            lblInstallationHoursCost.TabIndex = 8;
            lblInstallationHoursCost.Text = "Number of hours to install the floor: 28.13     At a cost of:  $1,005.47";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(21, 266);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(433, 25);
            lblTotalCost.TabIndex = 9;
            lblTotalCost.Text = "The total finished cost for the new floor is:  $6,911.72";
            // 
            // btnCalculateCost
            // 
            btnCalculateCost.Location = new Point(21, 334);
            btnCalculateCost.Name = "btnCalculateCost";
            btnCalculateCost.Size = new Size(145, 34);
            btnCalculateCost.TabIndex = 10;
            btnCalculateCost.Text = "Calculate Cost";
            btnCalculateCost.UseVisualStyleBackColor = true;
            btnCalculateCost.Click += btnCalculateCost_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(402, 334);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCalculateCost);
            Controls.Add(lblTotalCost);
            Controls.Add(lblInstallationHoursCost);
            Controls.Add(lblFloorSizeCost);
            Controls.Add(label1);
            Controls.Add(txtCostPerSqFt);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(lblCostPerSqFtDesc);
            Controls.Add(lblWidthDesc);
            Controls.Add(lblLengthDesc);
            Name = "Form1";
            Text = "Collin M. Kabealo Flooring Cost Estimator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLengthDesc;
        private Label lblWidthDesc;
        private Label lblCostPerSqFtDesc;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtCostPerSqFt;
        private Label label1;
        private Label lblFloorSizeCost;
        private Label lblInstallationHoursCost;
        private Label lblTotalCost;
        private Button btnCalculateCost;
        private Button btnExit;
    }
}