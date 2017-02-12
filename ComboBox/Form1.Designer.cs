namespace ComboBox
{
    partial class SelectionSwitchStatement
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
            this.cboCountries = new System.Windows.Forms.ComboBox();
            this.lblCountries = new System.Windows.Forms.Label();
            this.btnMultiSwitch = new System.Windows.Forms.Button();
            this.btnPrize = new System.Windows.Forms.Button();
            this.btnVoting = new System.Windows.Forms.Button();
            this.btnDriverSwitch = new System.Windows.Forms.Button();
            this.btnEat = new System.Windows.Forms.Button();
            this.btnVendingSwitch = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboCountries
            // 
            this.cboCountries.FormattingEnabled = true;
            this.cboCountries.Items.AddRange(new object[] {
            "The United States",
            "Canada",
            "Mexico"});
            this.cboCountries.Location = new System.Drawing.Point(256, 292);
            this.cboCountries.Name = "cboCountries";
            this.cboCountries.Size = new System.Drawing.Size(343, 21);
            this.cboCountries.TabIndex = 0;
            this.cboCountries.SelectedIndexChanged += new System.EventHandler(this.cboCountries_SelectedIndexChanged);
            // 
            // lblCountries
            // 
            this.lblCountries.AutoSize = true;
            this.lblCountries.Location = new System.Drawing.Point(50, 295);
            this.lblCountries.Name = "lblCountries";
            this.lblCountries.Size = new System.Drawing.Size(137, 13);
            this.lblCountries.TabIndex = 1;
            this.lblCountries.Text = "Countries and their capitals:";
            // 
            // btnMultiSwitch
            // 
            this.btnMultiSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiSwitch.Location = new System.Drawing.Point(53, 152);
            this.btnMultiSwitch.Name = "btnMultiSwitch";
            this.btnMultiSwitch.Size = new System.Drawing.Size(140, 55);
            this.btnMultiSwitch.TabIndex = 2;
            this.btnMultiSwitch.Text = "Multiple Alternative \r\nSwitch Statement";
            this.btnMultiSwitch.UseVisualStyleBackColor = true;
            this.btnMultiSwitch.Click += new System.EventHandler(this.btnMultiSwitch_Click);
            // 
            // btnPrize
            // 
            this.btnPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrize.Location = new System.Drawing.Point(459, 213);
            this.btnPrize.Name = "btnPrize";
            this.btnPrize.Size = new System.Drawing.Size(140, 55);
            this.btnPrize.TabIndex = 3;
            this.btnPrize.Text = "Prize";
            this.btnPrize.UseVisualStyleBackColor = true;
            this.btnPrize.Click += new System.EventHandler(this.btnPrize_Click);
            // 
            // btnVoting
            // 
            this.btnVoting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoting.Location = new System.Drawing.Point(459, 152);
            this.btnVoting.Name = "btnVoting";
            this.btnVoting.Size = new System.Drawing.Size(140, 55);
            this.btnVoting.TabIndex = 4;
            this.btnVoting.Text = "Voting Eligibility";
            this.btnVoting.UseVisualStyleBackColor = true;
            this.btnVoting.Click += new System.EventHandler(this.btnVoting_Click);
            // 
            // btnDriverSwitch
            // 
            this.btnDriverSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriverSwitch.Location = new System.Drawing.Point(265, 213);
            this.btnDriverSwitch.Name = "btnDriverSwitch";
            this.btnDriverSwitch.Size = new System.Drawing.Size(140, 55);
            this.btnDriverSwitch.TabIndex = 5;
            this.btnDriverSwitch.Text = "Driver License\r\nSwitch Statement";
            this.btnDriverSwitch.UseVisualStyleBackColor = true;
            this.btnDriverSwitch.Click += new System.EventHandler(this.btnDriverSwitch_Click);
            // 
            // btnEat
            // 
            this.btnEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEat.Location = new System.Drawing.Point(265, 152);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(140, 55);
            this.btnEat.TabIndex = 6;
            this.btnEat.Text = "Where to Eat";
            this.btnEat.UseVisualStyleBackColor = true;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // btnVendingSwitch
            // 
            this.btnVendingSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendingSwitch.Location = new System.Drawing.Point(53, 213);
            this.btnVendingSwitch.Name = "btnVendingSwitch";
            this.btnVendingSwitch.Size = new System.Drawing.Size(140, 55);
            this.btnVendingSwitch.TabIndex = 7;
            this.btnVendingSwitch.Text = "Vending Machine\r\nSwith Statement";
            this.btnVendingSwitch.UseVisualStyleBackColor = true;
            this.btnVendingSwitch.Click += new System.EventHandler(this.btnVendingSwitch_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(32, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(567, 109);
            this.txtDisplay.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(53, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SelectionSwitchStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 372);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnVendingSwitch);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.btnDriverSwitch);
            this.Controls.Add(this.btnVoting);
            this.Controls.Add(this.btnPrize);
            this.Controls.Add(this.btnMultiSwitch);
            this.Controls.Add(this.lblCountries);
            this.Controls.Add(this.cboCountries);
            this.Name = "SelectionSwitchStatement";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCountries;
        private System.Windows.Forms.Label lblCountries;
        private System.Windows.Forms.Button btnMultiSwitch;
        private System.Windows.Forms.Button btnPrize;
        private System.Windows.Forms.Button btnVoting;
        private System.Windows.Forms.Button btnDriverSwitch;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Button btnVendingSwitch;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnClear;
    }
}

