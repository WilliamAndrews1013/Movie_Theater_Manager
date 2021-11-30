namespace Movie_Theater_Manager
{
    partial class AddShowtime
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
            this.codeComboBox = new System.Windows.Forms.ComboBox();
            this.ticketPriceLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.showtimeMovieIdLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.errorlabel4 = new System.Windows.Forms.Label();
            this.errorlabel3 = new System.Windows.Forms.Label();
            this.errorlabel2 = new System.Windows.Forms.Label();
            this.errorlabel1 = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.movieLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codeComboBox
            // 
            this.codeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.codeComboBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeComboBox.FormattingEnabled = true;
            this.codeComboBox.Location = new System.Drawing.Point(135, 109);
            this.codeComboBox.Name = "codeComboBox";
            this.codeComboBox.Size = new System.Drawing.Size(203, 21);
            this.codeComboBox.TabIndex = 161;
            // 
            // ticketPriceLabel
            // 
            this.ticketPriceLabel.AutoSize = true;
            this.ticketPriceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ticketPriceLabel.Location = new System.Drawing.Point(55, 139);
            this.ticketPriceLabel.Name = "ticketPriceLabel";
            this.ticketPriceLabel.Size = new System.Drawing.Size(64, 13);
            this.ticketPriceLabel.TabIndex = 160;
            this.ticketPriceLabel.Text = "Ticket Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(5, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 13);
            this.label16.TabIndex = 159;
            this.label16.Text = "Screening Room Code";
            // 
            // showtimeMovieIdLabel
            // 
            this.showtimeMovieIdLabel.AutoSize = true;
            this.showtimeMovieIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeMovieIdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeMovieIdLabel.Location = new System.Drawing.Point(69, 87);
            this.showtimeMovieIdLabel.Name = "showtimeMovieIdLabel";
            this.showtimeMovieIdLabel.Size = new System.Drawing.Size(50, 13);
            this.showtimeMovieIdLabel.TabIndex = 158;
            this.showtimeMovieIdLabel.Text = "Movie ID";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimeLabel.Location = new System.Drawing.Point(63, 61);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(56, 13);
            this.dateTimeLabel.TabIndex = 157;
            this.dateTimeLabel.Text = "Date Time";
            // 
            // errorlabel4
            // 
            this.errorlabel4.AutoSize = true;
            this.errorlabel4.ForeColor = System.Drawing.Color.Red;
            this.errorlabel4.Location = new System.Drawing.Point(124, 139);
            this.errorlabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorlabel4.Name = "errorlabel4";
            this.errorlabel4.Size = new System.Drawing.Size(11, 13);
            this.errorlabel4.TabIndex = 156;
            this.errorlabel4.Text = "*";
            this.errorlabel4.Visible = false;
            // 
            // errorlabel3
            // 
            this.errorlabel3.AutoSize = true;
            this.errorlabel3.ForeColor = System.Drawing.Color.Red;
            this.errorlabel3.Location = new System.Drawing.Point(124, 115);
            this.errorlabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorlabel3.Name = "errorlabel3";
            this.errorlabel3.Size = new System.Drawing.Size(11, 13);
            this.errorlabel3.TabIndex = 155;
            this.errorlabel3.Text = "*";
            this.errorlabel3.Visible = false;
            // 
            // errorlabel2
            // 
            this.errorlabel2.AutoSize = true;
            this.errorlabel2.ForeColor = System.Drawing.Color.Red;
            this.errorlabel2.Location = new System.Drawing.Point(124, 87);
            this.errorlabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorlabel2.Name = "errorlabel2";
            this.errorlabel2.Size = new System.Drawing.Size(11, 13);
            this.errorlabel2.TabIndex = 154;
            this.errorlabel2.Text = "*";
            this.errorlabel2.Visible = false;
            // 
            // errorlabel1
            // 
            this.errorlabel1.AutoSize = true;
            this.errorlabel1.ForeColor = System.Drawing.Color.Red;
            this.errorlabel1.Location = new System.Drawing.Point(124, 61);
            this.errorlabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorlabel1.Name = "errorlabel1";
            this.errorlabel1.Size = new System.Drawing.Size(11, 13);
            this.errorlabel1.TabIndex = 153;
            this.errorlabel1.Text = "*";
            this.errorlabel1.Visible = false;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLabel.Location = new System.Drawing.Point(112, 33);
            this.errorMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(132, 13);
            this.errorMessageLabel.TabIndex = 152;
            this.errorMessageLabel.Text = "Complete all required fields\r\n";
            this.errorMessageLabel.Visible = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(210, 162);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(61, 33);
            this.addButton.TabIndex = 151;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(277, 162);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(61, 33);
            this.cancelButton.TabIndex = 150;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieLabel.Location = new System.Drawing.Point(107, 9);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(145, 24);
            this.movieLabel.TabIndex = 149;
            this.movieLabel.Text = "Add Showtime";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTextBox.Location = new System.Drawing.Point(135, 58);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(203, 20);
            this.dateTextBox.TabIndex = 146;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceTextBox.Location = new System.Drawing.Point(135, 136);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(203, 20);
            this.priceTextBox.TabIndex = 148;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IDTextBox.Location = new System.Drawing.Point(135, 84);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(203, 20);
            this.IDTextBox.TabIndex = 147;
            // 
            // AddShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(357, 213);
            this.Controls.Add(this.codeComboBox);
            this.Controls.Add(this.ticketPriceLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.showtimeMovieIdLabel);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.errorlabel4);
            this.Controls.Add(this.errorlabel3);
            this.Controls.Add(this.errorlabel2);
            this.Controls.Add(this.errorlabel1);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Name = "AddShowtime";
            this.Text = "AddShowtime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ticketPriceLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label showtimeMovieIdLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label movieLabel;
        public System.Windows.Forms.ComboBox codeComboBox;
        public System.Windows.Forms.Label errorlabel4;
        public System.Windows.Forms.Label errorlabel3;
        public System.Windows.Forms.Label errorlabel2;
        public System.Windows.Forms.Label errorlabel1;
        public System.Windows.Forms.Label errorMessageLabel;
        public System.Windows.Forms.TextBox dateTextBox;
        public System.Windows.Forms.TextBox priceTextBox;
        public System.Windows.Forms.TextBox IDTextBox;
    }
}