﻿namespace Movie_Theater_Manager
{
    partial class ManagerPortal
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.clientListView = new System.Windows.Forms.ListView();
            this.clientLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ticketsSoldByMovieListView = new System.Windows.Forms.ListView();
            this.ticketsSoldByShowtimeListView = new System.Windows.Forms.ListView();
            this.ticketSoldMovieLabel = new System.Windows.Forms.Label();
            this.ticketsSoldShowtimeLabel = new System.Windows.Forms.Label();
            this.ticketsSoldLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showtimeListView = new System.Windows.Forms.ListView();
            this.showtimeAddButton = new System.Windows.Forms.Button();
            this.showtimeEditButton = new System.Windows.Forms.Button();
            this.showtimeDeleteButton = new System.Windows.Forms.Button();
            this.ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this.ticketPriceLabel = new System.Windows.Forms.Label();
            this.showtimeScreenRoomCodeIDTextBox = new System.Windows.Forms.TextBox();
            this.showtimeIDTextBox = new System.Windows.Forms.TextBox();
            this.showtimeIDLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.showtimeMovieIDTextBox = new System.Windows.Forms.TextBox();
            this.dateTimeTextBox = new System.Windows.Forms.TextBox();
            this.showtimeMovieIdLabel = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.showtimeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.screeningRoomListView = new System.Windows.Forms.ListView();
            this.screeningRoomCodeTextBox = new System.Windows.Forms.TextBox();
            this.screeningRoomCodeLabel = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.ScreeningRoomDescriptionLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.deleteScreeningRoomButton = new System.Windows.Forms.Button();
            this.editScreeningRoomButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addScreeningRoomButton = new System.Windows.Forms.Button();
            this.screeningRoomLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.movieListView = new System.Windows.Forms.ListView();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.movieIDTextBox = new System.Windows.Forms.TextBox();
            this.editMovieButton = new System.Windows.Forms.Button();
            this.movieIDLabel = new System.Windows.Forms.Label();
            this.imagePathLabel = new System.Windows.Forms.Label();
            this.imageFilePathTextBox = new System.Windows.Forms.TextBox();
            this.movieRatingLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.audienceRatingTextBox = new System.Windows.Forms.TextBox();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.movieLabel = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutButton.Location = new System.Drawing.Point(636, 512);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(80, 41);
            this.logoutButton.TabIndex = 124;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.clientListView);
            this.panel5.Location = new System.Drawing.Point(401, 437);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 155);
            this.panel5.TabIndex = 123;
            // 
            // clientListView
            // 
            this.clientListView.HideSelection = false;
            this.clientListView.Location = new System.Drawing.Point(3, 3);
            this.clientListView.Name = "clientListView";
            this.clientListView.Size = new System.Drawing.Size(182, 145);
            this.clientListView.TabIndex = 1;
            this.clientListView.UseCompatibleStateImageBehavior = false;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clientLabel.Location = new System.Drawing.Point(397, 410);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(73, 24);
            this.clientLabel.TabIndex = 122;
            this.clientLabel.Text = "Clients";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.ticketsSoldByMovieListView);
            this.panel4.Controls.Add(this.ticketsSoldByShowtimeListView);
            this.panel4.Controls.Add(this.ticketSoldMovieLabel);
            this.panel4.Controls.Add(this.ticketsSoldShowtimeLabel);
            this.panel4.Location = new System.Drawing.Point(20, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(333, 272);
            this.panel4.TabIndex = 121;
            // 
            // ticketsSoldByMovieListView
            // 
            this.ticketsSoldByMovieListView.HideSelection = false;
            this.ticketsSoldByMovieListView.Location = new System.Drawing.Point(6, 157);
            this.ticketsSoldByMovieListView.Name = "ticketsSoldByMovieListView";
            this.ticketsSoldByMovieListView.Size = new System.Drawing.Size(318, 108);
            this.ticketsSoldByMovieListView.TabIndex = 5;
            this.ticketsSoldByMovieListView.UseCompatibleStateImageBehavior = false;
            // 
            // ticketsSoldByShowtimeListView
            // 
            this.ticketsSoldByShowtimeListView.HideSelection = false;
            this.ticketsSoldByShowtimeListView.Location = new System.Drawing.Point(6, 30);
            this.ticketsSoldByShowtimeListView.Name = "ticketsSoldByShowtimeListView";
            this.ticketsSoldByShowtimeListView.Size = new System.Drawing.Size(318, 108);
            this.ticketsSoldByShowtimeListView.TabIndex = 4;
            this.ticketsSoldByShowtimeListView.UseCompatibleStateImageBehavior = false;
            // 
            // ticketSoldMovieLabel
            // 
            this.ticketSoldMovieLabel.AutoSize = true;
            this.ticketSoldMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketSoldMovieLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ticketSoldMovieLabel.Location = new System.Drawing.Point(3, 141);
            this.ticketSoldMovieLabel.Name = "ticketSoldMovieLabel";
            this.ticketSoldMovieLabel.Size = new System.Drawing.Size(59, 13);
            this.ticketSoldMovieLabel.TabIndex = 3;
            this.ticketSoldMovieLabel.Text = "By Movie";
            // 
            // ticketsSoldShowtimeLabel
            // 
            this.ticketsSoldShowtimeLabel.AutoSize = true;
            this.ticketsSoldShowtimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsSoldShowtimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ticketsSoldShowtimeLabel.Location = new System.Drawing.Point(3, 10);
            this.ticketsSoldShowtimeLabel.Name = "ticketsSoldShowtimeLabel";
            this.ticketsSoldShowtimeLabel.Size = new System.Drawing.Size(79, 13);
            this.ticketsSoldShowtimeLabel.TabIndex = 1;
            this.ticketsSoldShowtimeLabel.Text = "By Showtime";
            // 
            // ticketsSoldLabel
            // 
            this.ticketsSoldLabel.AutoSize = true;
            this.ticketsSoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsSoldLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ticketsSoldLabel.Location = new System.Drawing.Point(16, 293);
            this.ticketsSoldLabel.Name = "ticketsSoldLabel";
            this.ticketsSoldLabel.Size = new System.Drawing.Size(124, 24);
            this.ticketsSoldLabel.TabIndex = 120;
            this.ticketsSoldLabel.Text = "Tickets Sold";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.showtimeListView);
            this.panel3.Controls.Add(this.showtimeAddButton);
            this.panel3.Controls.Add(this.showtimeEditButton);
            this.panel3.Controls.Add(this.showtimeDeleteButton);
            this.panel3.Controls.Add(this.ticketPriceTextBox);
            this.panel3.Controls.Add(this.ticketPriceLabel);
            this.panel3.Controls.Add(this.showtimeScreenRoomCodeIDTextBox);
            this.panel3.Controls.Add(this.showtimeIDTextBox);
            this.panel3.Controls.Add(this.showtimeIDLabel);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.showtimeMovieIDTextBox);
            this.panel3.Controls.Add(this.dateTimeTextBox);
            this.panel3.Controls.Add(this.showtimeMovieIdLabel);
            this.panel3.Controls.Add(this.dateTimeLabel);
            this.panel3.Location = new System.Drawing.Point(401, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 195);
            this.panel3.TabIndex = 119;
            // 
            // showtimeListView
            // 
            this.showtimeListView.HideSelection = false;
            this.showtimeListView.Location = new System.Drawing.Point(3, 5);
            this.showtimeListView.Name = "showtimeListView";
            this.showtimeListView.Size = new System.Drawing.Size(121, 173);
            this.showtimeListView.TabIndex = 98;
            this.showtimeListView.UseCompatibleStateImageBehavior = false;
            this.showtimeListView.SelectedIndexChanged += new System.EventHandler(this.ShowtimeListView_SelectedIndexChanged);
            // 
            // showtimeAddButton
            // 
            this.showtimeAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showtimeAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeAddButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeAddButton.Location = new System.Drawing.Point(299, 145);
            this.showtimeAddButton.Name = "showtimeAddButton";
            this.showtimeAddButton.Size = new System.Drawing.Size(41, 33);
            this.showtimeAddButton.TabIndex = 95;
            this.showtimeAddButton.Text = "Add";
            this.showtimeAddButton.UseVisualStyleBackColor = false;
            this.showtimeAddButton.Click += new System.EventHandler(this.ShowtimeAddButton_Click);
            // 
            // showtimeEditButton
            // 
            this.showtimeEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showtimeEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeEditButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeEditButton.Location = new System.Drawing.Point(193, 145);
            this.showtimeEditButton.Name = "showtimeEditButton";
            this.showtimeEditButton.Size = new System.Drawing.Size(40, 33);
            this.showtimeEditButton.TabIndex = 94;
            this.showtimeEditButton.Text = "Edit";
            this.showtimeEditButton.UseVisualStyleBackColor = false;
            this.showtimeEditButton.Click += new System.EventHandler(this.ShowtimeEditButton_Click);
            // 
            // showtimeDeleteButton
            // 
            this.showtimeDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showtimeDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeDeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeDeleteButton.Location = new System.Drawing.Point(239, 145);
            this.showtimeDeleteButton.Name = "showtimeDeleteButton";
            this.showtimeDeleteButton.Size = new System.Drawing.Size(54, 33);
            this.showtimeDeleteButton.TabIndex = 96;
            this.showtimeDeleteButton.Text = "Delete";
            this.showtimeDeleteButton.UseVisualStyleBackColor = false;
            this.showtimeDeleteButton.Click += new System.EventHandler(this.ShowtimeDeleteButton_Click);
            // 
            // ticketPriceTextBox
            // 
            this.ticketPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ticketPriceTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ticketPriceTextBox.Location = new System.Drawing.Point(240, 115);
            this.ticketPriceTextBox.Name = "ticketPriceTextBox";
            this.ticketPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketPriceTextBox.TabIndex = 93;
            // 
            // ticketPriceLabel
            // 
            this.ticketPriceLabel.AutoSize = true;
            this.ticketPriceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ticketPriceLabel.Location = new System.Drawing.Point(129, 118);
            this.ticketPriceLabel.Name = "ticketPriceLabel";
            this.ticketPriceLabel.Size = new System.Drawing.Size(64, 13);
            this.ticketPriceLabel.TabIndex = 92;
            this.ticketPriceLabel.Text = "Ticket Price";
            // 
            // showtimeScreenRoomCodeIDTextBox
            // 
            this.showtimeScreenRoomCodeIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showtimeScreenRoomCodeIDTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeScreenRoomCodeIDTextBox.Location = new System.Drawing.Point(249, 88);
            this.showtimeScreenRoomCodeIDTextBox.Name = "showtimeScreenRoomCodeIDTextBox";
            this.showtimeScreenRoomCodeIDTextBox.Size = new System.Drawing.Size(91, 20);
            this.showtimeScreenRoomCodeIDTextBox.TabIndex = 91;
            // 
            // showtimeIDTextBox
            // 
            this.showtimeIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showtimeIDTextBox.Enabled = false;
            this.showtimeIDTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeIDTextBox.Location = new System.Drawing.Point(239, 5);
            this.showtimeIDTextBox.Name = "showtimeIDTextBox";
            this.showtimeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.showtimeIDTextBox.TabIndex = 79;
            // 
            // showtimeIDLabel
            // 
            this.showtimeIDLabel.AutoSize = true;
            this.showtimeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeIDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeIDLabel.Location = new System.Drawing.Point(129, 12);
            this.showtimeIDLabel.Name = "showtimeIDLabel";
            this.showtimeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.showtimeIDLabel.TabIndex = 78;
            this.showtimeIDLabel.Text = "Showtime ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(129, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 13);
            this.label16.TabIndex = 74;
            this.label16.Text = "Screening Room Code";
            // 
            // showtimeMovieIDTextBox
            // 
            this.showtimeMovieIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showtimeMovieIDTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeMovieIDTextBox.Location = new System.Drawing.Point(240, 61);
            this.showtimeMovieIDTextBox.Name = "showtimeMovieIDTextBox";
            this.showtimeMovieIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.showtimeMovieIDTextBox.TabIndex = 97;
            // 
            // dateTimeTextBox
            // 
            this.dateTimeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateTimeTextBox.Enabled = false;
            this.dateTimeTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimeTextBox.Location = new System.Drawing.Point(239, 34);
            this.dateTimeTextBox.Name = "dateTimeTextBox";
            this.dateTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateTimeTextBox.TabIndex = 75;
            // 
            // showtimeMovieIdLabel
            // 
            this.showtimeMovieIdLabel.AutoSize = true;
            this.showtimeMovieIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeMovieIdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeMovieIdLabel.Location = new System.Drawing.Point(129, 64);
            this.showtimeMovieIdLabel.Name = "showtimeMovieIdLabel";
            this.showtimeMovieIdLabel.Size = new System.Drawing.Size(50, 13);
            this.showtimeMovieIdLabel.TabIndex = 73;
            this.showtimeMovieIdLabel.Text = "Movie ID";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimeLabel.Location = new System.Drawing.Point(129, 37);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(56, 13);
            this.dateTimeLabel.TabIndex = 72;
            this.dateTimeLabel.Text = "Date Time";
            // 
            // showtimeLabel
            // 
            this.showtimeLabel.AutoSize = true;
            this.showtimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showtimeLabel.Location = new System.Drawing.Point(397, 170);
            this.showtimeLabel.Name = "showtimeLabel";
            this.showtimeLabel.Size = new System.Drawing.Size(111, 24);
            this.showtimeLabel.TabIndex = 118;
            this.showtimeLabel.Text = "Showtimes";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.screeningRoomListView);
            this.panel2.Controls.Add(this.screeningRoomCodeTextBox);
            this.panel2.Controls.Add(this.screeningRoomCodeLabel);
            this.panel2.Controls.Add(this.capacityTextBox);
            this.panel2.Controls.Add(this.ScreeningRoomDescriptionLabel);
            this.panel2.Controls.Add(this.capacityLabel);
            this.panel2.Controls.Add(this.deleteScreeningRoomButton);
            this.panel2.Controls.Add(this.editScreeningRoomButton);
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(this.addScreeningRoomButton);
            this.panel2.Location = new System.Drawing.Point(401, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 119);
            this.panel2.TabIndex = 117;
            // 
            // screeningRoomListView
            // 
            this.screeningRoomListView.HideSelection = false;
            this.screeningRoomListView.Location = new System.Drawing.Point(3, 3);
            this.screeningRoomListView.Name = "screeningRoomListView";
            this.screeningRoomListView.Size = new System.Drawing.Size(121, 104);
            this.screeningRoomListView.TabIndex = 92;
            this.screeningRoomListView.UseCompatibleStateImageBehavior = false;
            this.screeningRoomListView.SelectedIndexChanged += new System.EventHandler(this.ScreeningRoomListView_SelectedIndexChanged);
            // 
            // screeningRoomCodeTextBox
            // 
            this.screeningRoomCodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.screeningRoomCodeTextBox.Enabled = false;
            this.screeningRoomCodeTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.screeningRoomCodeTextBox.Location = new System.Drawing.Point(202, 7);
            this.screeningRoomCodeTextBox.Name = "screeningRoomCodeTextBox";
            this.screeningRoomCodeTextBox.Size = new System.Drawing.Size(111, 20);
            this.screeningRoomCodeTextBox.TabIndex = 90;
            // 
            // screeningRoomCodeLabel
            // 
            this.screeningRoomCodeLabel.AutoSize = true;
            this.screeningRoomCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screeningRoomCodeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.screeningRoomCodeLabel.Location = new System.Drawing.Point(129, 10);
            this.screeningRoomCodeLabel.Name = "screeningRoomCodeLabel";
            this.screeningRoomCodeLabel.Size = new System.Drawing.Size(32, 13);
            this.screeningRoomCodeLabel.TabIndex = 89;
            this.screeningRoomCodeLabel.Text = "Code";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.capacityTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.capacityTextBox.Location = new System.Drawing.Point(202, 32);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(111, 20);
            this.capacityTextBox.TabIndex = 83;
            // 
            // ScreeningRoomDescriptionLabel
            // 
            this.ScreeningRoomDescriptionLabel.AutoSize = true;
            this.ScreeningRoomDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningRoomDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ScreeningRoomDescriptionLabel.Location = new System.Drawing.Point(129, 61);
            this.ScreeningRoomDescriptionLabel.Name = "ScreeningRoomDescriptionLabel";
            this.ScreeningRoomDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.ScreeningRoomDescriptionLabel.TabIndex = 84;
            this.ScreeningRoomDescriptionLabel.Text = "Description";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.capacityLabel.Location = new System.Drawing.Point(129, 35);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(48, 13);
            this.capacityLabel.TabIndex = 82;
            this.capacityLabel.Text = "Capacity";
            // 
            // deleteScreeningRoomButton
            // 
            this.deleteScreeningRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteScreeningRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteScreeningRoomButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteScreeningRoomButton.Location = new System.Drawing.Point(202, 88);
            this.deleteScreeningRoomButton.Name = "deleteScreeningRoomButton";
            this.deleteScreeningRoomButton.Size = new System.Drawing.Size(60, 25);
            this.deleteScreeningRoomButton.TabIndex = 88;
            this.deleteScreeningRoomButton.Text = "Delete";
            this.deleteScreeningRoomButton.UseVisualStyleBackColor = false;
            this.deleteScreeningRoomButton.Click += new System.EventHandler(this.DeleteScreeningRoomButton_Click);
            // 
            // editScreeningRoomButton
            // 
            this.editScreeningRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editScreeningRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editScreeningRoomButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editScreeningRoomButton.Location = new System.Drawing.Point(147, 89);
            this.editScreeningRoomButton.Name = "editScreeningRoomButton";
            this.editScreeningRoomButton.Size = new System.Drawing.Size(49, 24);
            this.editScreeningRoomButton.TabIndex = 86;
            this.editScreeningRoomButton.Text = "Edit";
            this.editScreeningRoomButton.UseVisualStyleBackColor = false;
            this.editScreeningRoomButton.Click += new System.EventHandler(this.EditScreeningRoomButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionTextBox.Location = new System.Drawing.Point(202, 58);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(111, 20);
            this.descriptionTextBox.TabIndex = 85;
            // 
            // addScreeningRoomButton
            // 
            this.addScreeningRoomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addScreeningRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScreeningRoomButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addScreeningRoomButton.Location = new System.Drawing.Point(268, 88);
            this.addScreeningRoomButton.Name = "addScreeningRoomButton";
            this.addScreeningRoomButton.Size = new System.Drawing.Size(45, 25);
            this.addScreeningRoomButton.TabIndex = 87;
            this.addScreeningRoomButton.Text = "Add";
            this.addScreeningRoomButton.UseVisualStyleBackColor = false;
            this.addScreeningRoomButton.Click += new System.EventHandler(this.AddScreeningRoomButton_Click);
            // 
            // screeningRoomLabel
            // 
            this.screeningRoomLabel.AutoSize = true;
            this.screeningRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screeningRoomLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.screeningRoomLabel.Location = new System.Drawing.Point(397, 9);
            this.screeningRoomLabel.Name = "screeningRoomLabel";
            this.screeningRoomLabel.Size = new System.Drawing.Size(167, 24);
            this.screeningRoomLabel.TabIndex = 116;
            this.screeningRoomLabel.Text = "Screening Room";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.genreLabel);
            this.panel1.Controls.Add(this.genreListBox);
            this.panel1.Controls.Add(this.movieListView);
            this.panel1.Controls.Add(this.addMovieButton);
            this.panel1.Controls.Add(this.movieIDTextBox);
            this.panel1.Controls.Add(this.editMovieButton);
            this.panel1.Controls.Add(this.movieIDLabel);
            this.panel1.Controls.Add(this.imagePathLabel);
            this.panel1.Controls.Add(this.imageFilePathTextBox);
            this.panel1.Controls.Add(this.movieRatingLabel);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.audienceRatingTextBox);
            this.panel1.Controls.Add(this.deleteMovieButton);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.yearTextBox);
            this.panel1.Controls.Add(this.yearLabel);
            this.panel1.Controls.Add(this.lengthLabel);
            this.panel1.Controls.Add(this.lengthTextBox);
            this.panel1.Location = new System.Drawing.Point(16, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 244);
            this.panel1.TabIndex = 115;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.genreLabel.Location = new System.Drawing.Point(169, 39);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 93;
            this.genreLabel.Text = "Genre";
            // 
            // genreListBox
            // 
            this.genreListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genreListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.Location = new System.Drawing.Point(247, 39);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(101, 30);
            this.genreListBox.TabIndex = 92;
            // 
            // movieListView
            // 
            this.movieListView.HideSelection = false;
            this.movieListView.Location = new System.Drawing.Point(4, 3);
            this.movieListView.Name = "movieListView";
            this.movieListView.Size = new System.Drawing.Size(159, 225);
            this.movieListView.TabIndex = 91;
            this.movieListView.UseCompatibleStateImageBehavior = false;
            this.movieListView.SelectedIndexChanged += new System.EventHandler(this.MovieListView_SelectedIndexChanged);
            // 
            // addMovieButton
            // 
            this.addMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addMovieButton.Location = new System.Drawing.Point(307, 203);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(41, 33);
            this.addMovieButton.TabIndex = 76;
            this.addMovieButton.Text = "Add";
            this.addMovieButton.UseVisualStyleBackColor = false;
            this.addMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // movieIDTextBox
            // 
            this.movieIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.movieIDTextBox.Enabled = false;
            this.movieIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIDTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieIDTextBox.Location = new System.Drawing.Point(248, 13);
            this.movieIDTextBox.Name = "movieIDTextBox";
            this.movieIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.movieIDTextBox.TabIndex = 90;
            // 
            // editMovieButton
            // 
            this.editMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMovieButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editMovieButton.Location = new System.Drawing.Point(201, 203);
            this.editMovieButton.Name = "editMovieButton";
            this.editMovieButton.Size = new System.Drawing.Size(40, 33);
            this.editMovieButton.TabIndex = 75;
            this.editMovieButton.Text = "Edit";
            this.editMovieButton.UseVisualStyleBackColor = false;
            this.editMovieButton.Click += new System.EventHandler(this.EditMovieButton_Click);
            // 
            // movieIDLabel
            // 
            this.movieIDLabel.AutoSize = true;
            this.movieIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieIDLabel.Location = new System.Drawing.Point(169, 13);
            this.movieIDLabel.Name = "movieIDLabel";
            this.movieIDLabel.Size = new System.Drawing.Size(50, 13);
            this.movieIDLabel.TabIndex = 89;
            this.movieIDLabel.Text = "Movie ID";
            // 
            // imagePathLabel
            // 
            this.imagePathLabel.AutoSize = true;
            this.imagePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.imagePathLabel.Location = new System.Drawing.Point(167, 182);
            this.imagePathLabel.Name = "imagePathLabel";
            this.imagePathLabel.Size = new System.Drawing.Size(61, 13);
            this.imagePathLabel.TabIndex = 82;
            this.imagePathLabel.Text = "Image Path";
            // 
            // imageFilePathTextBox
            // 
            this.imageFilePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imageFilePathTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.imageFilePathTextBox.Location = new System.Drawing.Point(247, 179);
            this.imageFilePathTextBox.Name = "imageFilePathTextBox";
            this.imageFilePathTextBox.Size = new System.Drawing.Size(100, 20);
            this.imageFilePathTextBox.TabIndex = 88;
            // 
            // movieRatingLabel
            // 
            this.movieRatingLabel.AutoSize = true;
            this.movieRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieRatingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieRatingLabel.Location = new System.Drawing.Point(167, 156);
            this.movieRatingLabel.Name = "movieRatingLabel";
            this.movieRatingLabel.Size = new System.Drawing.Size(38, 13);
            this.movieRatingLabel.TabIndex = 81;
            this.movieRatingLabel.Text = "Rating";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleTextBox.Location = new System.Drawing.Point(247, 75);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 84;
            // 
            // audienceRatingTextBox
            // 
            this.audienceRatingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.audienceRatingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audienceRatingTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.audienceRatingTextBox.Location = new System.Drawing.Point(247, 153);
            this.audienceRatingTextBox.Name = "audienceRatingTextBox";
            this.audienceRatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.audienceRatingTextBox.TabIndex = 87;
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMovieButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteMovieButton.Location = new System.Drawing.Point(247, 203);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(54, 33);
            this.deleteMovieButton.TabIndex = 83;
            this.deleteMovieButton.Text = "Delete";
            this.deleteMovieButton.UseVisualStyleBackColor = false;
            this.deleteMovieButton.Click += new System.EventHandler(this.DeleteMovieButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(167, 78);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 78;
            this.titleLabel.Text = "Title";
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yearTextBox.Location = new System.Drawing.Point(247, 101);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 85;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yearLabel.Location = new System.Drawing.Point(167, 104);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 79;
            this.yearLabel.Text = "Year";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lengthLabel.Location = new System.Drawing.Point(167, 130);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(40, 13);
            this.lengthLabel.TabIndex = 80;
            this.lengthLabel.Text = "Length";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lengthTextBox.Location = new System.Drawing.Point(247, 127);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 86;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movieLabel.Location = new System.Drawing.Point(12, 9);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(66, 24);
            this.movieLabel.TabIndex = 114;
            this.movieLabel.Text = "Movie";
            // 
            // ManagerPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(769, 606);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.clientLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ticketsSoldLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.showtimeLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.screeningRoomLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.movieLabel);
            this.Name = "ManagerPortal";
            this.Text = "ManagerPortal";
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ticketSoldMovieLabel;
        private System.Windows.Forms.Label ticketsSoldShowtimeLabel;
        private System.Windows.Forms.Label ticketsSoldLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button showtimeAddButton;
        private System.Windows.Forms.Button showtimeEditButton;
        private System.Windows.Forms.Button showtimeDeleteButton;
        private System.Windows.Forms.TextBox ticketPriceTextBox;
        private System.Windows.Forms.Label ticketPriceLabel;
        private System.Windows.Forms.TextBox showtimeScreenRoomCodeIDTextBox;
        private System.Windows.Forms.TextBox showtimeIDTextBox;
        private System.Windows.Forms.Label showtimeIDLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox showtimeMovieIDTextBox;
        private System.Windows.Forms.TextBox dateTimeTextBox;
        private System.Windows.Forms.Label showtimeMovieIdLabel;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Label showtimeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox screeningRoomCodeTextBox;
        private System.Windows.Forms.Label screeningRoomCodeLabel;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label ScreeningRoomDescriptionLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Button deleteScreeningRoomButton;
        private System.Windows.Forms.Button editScreeningRoomButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addScreeningRoomButton;
        private System.Windows.Forms.Label screeningRoomLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.TextBox movieIDTextBox;
        private System.Windows.Forms.Button editMovieButton;
        private System.Windows.Forms.Label movieIDLabel;
        private System.Windows.Forms.Label imagePathLabel;
        private System.Windows.Forms.TextBox imageFilePathTextBox;
        private System.Windows.Forms.Label movieRatingLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox audienceRatingTextBox;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.ListView clientListView;
        private System.Windows.Forms.ListView ticketsSoldByMovieListView;
        private System.Windows.Forms.ListView ticketsSoldByShowtimeListView;
        private System.Windows.Forms.ListView showtimeListView;
        private System.Windows.Forms.ListView screeningRoomListView;
        private System.Windows.Forms.ListView movieListView;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ListBox genreListBox;
    }
}