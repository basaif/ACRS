namespace ACRS.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.customersButton = new System.Windows.Forms.Button();
            this.carsButton = new System.Windows.Forms.Button();
            this.rentalsButton = new System.Windows.Forms.Button();
            this.rentalsPanel = new System.Windows.Forms.Panel();
            this.rentalListsPanel = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.rentalsCancelButton = new System.Windows.Forms.Button();
            this.rentalsModifyButton = new System.Windows.Forms.Button();
            this.returnRentalsButton = new System.Windows.Forms.Button();
            this.rentalDetailsButton = new System.Windows.Forms.Button();
            this.rentalsListBox = new System.Windows.Forms.ListBox();
            this.addRentalButton = new System.Windows.Forms.Button();
            this.returnedRentalsButton = new System.Windows.Forms.Button();
            this.newRentalsButton = new System.Windows.Forms.Button();
            this.lateRentalsButton = new System.Windows.Forms.Button();
            this.activeRentalsButton = new System.Windows.Forms.Button();
            this.carsPanel = new System.Windows.Forms.Panel();
            this.carsRefreshButton = new System.Windows.Forms.Button();
            this.carsDeleteButton = new System.Windows.Forms.Button();
            this.carsModifyButton = new System.Windows.Forms.Button();
            this.carsDetailsButton = new System.Windows.Forms.Button();
            this.carsListBox = new System.Windows.Forms.ListBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.customersPanel = new System.Windows.Forms.Panel();
            this.customersRefreshButton = new System.Windows.Forms.Button();
            this.customersDeleteButton = new System.Windows.Forms.Button();
            this.customerModifyButton = new System.Windows.Forms.Button();
            this.customerDetailsButton = new System.Windows.Forms.Button();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.rentalsPanel.SuspendLayout();
            this.rentalListsPanel.SuspendLayout();
            this.carsPanel.SuspendLayout();
            this.customersPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Controls.Add(this.iconPictureBox);
            this.headerPanel.Controls.Add(this.minimizeButton);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(920, 40);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Navy;
            this.headerLabel.Location = new System.Drawing.Point(785, 14);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(75, 15);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "تأجير السيارات";
            this.headerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            this.headerLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseUp);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox.BackgroundImage = global::ACRS.Properties.Resources.car_rental_icon_30x30;
            this.iconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox.Location = new System.Drawing.Point(867, 0);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(50, 40);
            this.iconPictureBox.TabIndex = 1;
            this.iconPictureBox.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = global::ACRS.Properties.Resources.minimize_image_44x30;
            this.minimizeButton.Location = new System.Drawing.Point(56, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(50, 40);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::ACRS.Properties.Resources.close_image_44x30;
            this.closeButton.Location = new System.Drawing.Point(0, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(50, 40);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(60)))), ((int)(((byte)(234)))));
            this.menuPanel.Controls.Add(this.customersButton);
            this.menuPanel.Controls.Add(this.carsButton);
            this.menuPanel.Controls.Add(this.rentalsButton);
            this.menuPanel.Location = new System.Drawing.Point(700, 40);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(220, 610);
            this.menuPanel.TabIndex = 1;
            // 
            // customersButton
            // 
            this.customersButton.FlatAppearance.BorderSize = 0;
            this.customersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(134)))), ((int)(((byte)(232)))));
            this.customersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersButton.ForeColor = System.Drawing.Color.White;
            this.customersButton.Image = global::ACRS.Properties.Resources.customers_image_50x50;
            this.customersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customersButton.Location = new System.Drawing.Point(0, 120);
            this.customersButton.Name = "customersButton";
            this.customersButton.Size = new System.Drawing.Size(220, 60);
            this.customersButton.TabIndex = 2;
            this.customersButton.Text = "الزبائن";
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
            // 
            // carsButton
            // 
            this.carsButton.FlatAppearance.BorderSize = 0;
            this.carsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(134)))), ((int)(((byte)(232)))));
            this.carsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.carsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsButton.ForeColor = System.Drawing.Color.White;
            this.carsButton.Image = global::ACRS.Properties.Resources.cars_image_50x50;
            this.carsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.carsButton.Location = new System.Drawing.Point(0, 60);
            this.carsButton.Name = "carsButton";
            this.carsButton.Size = new System.Drawing.Size(220, 60);
            this.carsButton.TabIndex = 1;
            this.carsButton.Text = "السيارات";
            this.carsButton.UseVisualStyleBackColor = true;
            this.carsButton.Click += new System.EventHandler(this.carsButton_Click);
            // 
            // rentalsButton
            // 
            this.rentalsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(134)))), ((int)(((byte)(232)))));
            this.rentalsButton.FlatAppearance.BorderSize = 0;
            this.rentalsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(134)))), ((int)(((byte)(232)))));
            this.rentalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(114)))), ((int)(((byte)(206)))));
            this.rentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalsButton.ForeColor = System.Drawing.Color.White;
            this.rentalsButton.Image = global::ACRS.Properties.Resources.clipboard_image_50x50;
            this.rentalsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rentalsButton.Location = new System.Drawing.Point(0, 0);
            this.rentalsButton.Name = "rentalsButton";
            this.rentalsButton.Size = new System.Drawing.Size(220, 60);
            this.rentalsButton.TabIndex = 0;
            this.rentalsButton.Text = "إدارة المستأجرات";
            this.rentalsButton.UseVisualStyleBackColor = false;
            this.rentalsButton.Click += new System.EventHandler(this.rentalsButton_Click);
            // 
            // rentalsPanel
            // 
            this.rentalsPanel.BackColor = System.Drawing.Color.White;
            this.rentalsPanel.Controls.Add(this.rentalListsPanel);
            this.rentalsPanel.Controls.Add(this.addRentalButton);
            this.rentalsPanel.Controls.Add(this.returnedRentalsButton);
            this.rentalsPanel.Controls.Add(this.newRentalsButton);
            this.rentalsPanel.Controls.Add(this.lateRentalsButton);
            this.rentalsPanel.Controls.Add(this.activeRentalsButton);
            this.rentalsPanel.Location = new System.Drawing.Point(25, 125);
            this.rentalsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rentalsPanel.Name = "rentalsPanel";
            this.rentalsPanel.Size = new System.Drawing.Size(650, 500);
            this.rentalsPanel.TabIndex = 2;
            // 
            // rentalListsPanel
            // 
            this.rentalListsPanel.Controls.Add(this.refreshButton);
            this.rentalListsPanel.Controls.Add(this.rentalsCancelButton);
            this.rentalListsPanel.Controls.Add(this.rentalsModifyButton);
            this.rentalListsPanel.Controls.Add(this.returnRentalsButton);
            this.rentalListsPanel.Controls.Add(this.rentalDetailsButton);
            this.rentalListsPanel.Controls.Add(this.rentalsListBox);
            this.rentalListsPanel.Location = new System.Drawing.Point(15, 57);
            this.rentalListsPanel.Name = "rentalListsPanel";
            this.rentalListsPanel.Size = new System.Drawing.Size(620, 380);
            this.rentalListsPanel.TabIndex = 7;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.White;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.refreshButton.Image = global::ACRS.Properties.Resources.green_refresh_image_30x30;
            this.refreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshButton.Location = new System.Drawing.Point(16, 262);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(130, 50);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "تحديث";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // rentalsCancelButton
            // 
            this.rentalsCancelButton.BackColor = System.Drawing.Color.White;
            this.rentalsCancelButton.Enabled = false;
            this.rentalsCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rentalsCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalsCancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalsCancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.rentalsCancelButton.Image = global::ACRS.Properties.Resources.cancel_image_30x30;
            this.rentalsCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentalsCancelButton.Location = new System.Drawing.Point(16, 196);
            this.rentalsCancelButton.Name = "rentalsCancelButton";
            this.rentalsCancelButton.Size = new System.Drawing.Size(130, 50);
            this.rentalsCancelButton.TabIndex = 4;
            this.rentalsCancelButton.Text = "إلغاء";
            this.rentalsCancelButton.UseVisualStyleBackColor = false;
            this.rentalsCancelButton.Visible = false;
            this.rentalsCancelButton.Click += new System.EventHandler(this.rentalsCancelButton_Click);
            // 
            // rentalsModifyButton
            // 
            this.rentalsModifyButton.BackColor = System.Drawing.Color.White;
            this.rentalsModifyButton.Enabled = false;
            this.rentalsModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.rentalsModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalsModifyButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalsModifyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.rentalsModifyButton.Image = global::ACRS.Properties.Resources.modify_image_30x30;
            this.rentalsModifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentalsModifyButton.Location = new System.Drawing.Point(16, 131);
            this.rentalsModifyButton.Name = "rentalsModifyButton";
            this.rentalsModifyButton.Size = new System.Drawing.Size(130, 50);
            this.rentalsModifyButton.TabIndex = 3;
            this.rentalsModifyButton.Text = "تعديل";
            this.rentalsModifyButton.UseVisualStyleBackColor = false;
            this.rentalsModifyButton.Visible = false;
            this.rentalsModifyButton.Click += new System.EventHandler(this.rentalsModifyButton_Click);
            // 
            // returnRentalsButton
            // 
            this.returnRentalsButton.BackColor = System.Drawing.Color.White;
            this.returnRentalsButton.Enabled = false;
            this.returnRentalsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.returnRentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnRentalsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnRentalsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(179)))), ((int)(((byte)(68)))));
            this.returnRentalsButton.Image = global::ACRS.Properties.Resources.return_image_30x30;
            this.returnRentalsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnRentalsButton.Location = new System.Drawing.Point(16, 131);
            this.returnRentalsButton.Name = "returnRentalsButton";
            this.returnRentalsButton.Size = new System.Drawing.Size(130, 50);
            this.returnRentalsButton.TabIndex = 2;
            this.returnRentalsButton.Text = "إعادة";
            this.returnRentalsButton.UseVisualStyleBackColor = false;
            this.returnRentalsButton.Click += new System.EventHandler(this.returnRentalsButton_Click);
            // 
            // rentalDetailsButton
            // 
            this.rentalDetailsButton.BackColor = System.Drawing.Color.White;
            this.rentalDetailsButton.Enabled = false;
            this.rentalDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.rentalDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalDetailsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalDetailsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.rentalDetailsButton.Image = global::ACRS.Properties.Resources.details_image_30x30;
            this.rentalDetailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentalDetailsButton.Location = new System.Drawing.Point(16, 67);
            this.rentalDetailsButton.Name = "rentalDetailsButton";
            this.rentalDetailsButton.Size = new System.Drawing.Size(130, 50);
            this.rentalDetailsButton.TabIndex = 1;
            this.rentalDetailsButton.Text = "تفاصيل";
            this.rentalDetailsButton.UseVisualStyleBackColor = false;
            this.rentalDetailsButton.Click += new System.EventHandler(this.rentalDetailsButton_Click);
            // 
            // rentalsListBox
            // 
            this.rentalsListBox.FormattingEnabled = true;
            this.rentalsListBox.ItemHeight = 20;
            this.rentalsListBox.Location = new System.Drawing.Point(165, 18);
            this.rentalsListBox.Name = "rentalsListBox";
            this.rentalsListBox.Size = new System.Drawing.Size(440, 344);
            this.rentalsListBox.TabIndex = 0;
            this.rentalsListBox.SelectedIndexChanged += new System.EventHandler(this.rentalsListBox_SelectedIndexChanged);
            // 
            // addRentalButton
            // 
            this.addRentalButton.BackColor = System.Drawing.Color.Green;
            this.addRentalButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addRentalButton.FlatAppearance.BorderSize = 0;
            this.addRentalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRentalButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRentalButton.ForeColor = System.Drawing.Color.White;
            this.addRentalButton.Image = global::ACRS.Properties.Resources.rent_car_50x501;
            this.addRentalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addRentalButton.Location = new System.Drawing.Point(0, 449);
            this.addRentalButton.Name = "addRentalButton";
            this.addRentalButton.Size = new System.Drawing.Size(650, 51);
            this.addRentalButton.TabIndex = 5;
            this.addRentalButton.Text = "تأجير سيارة";
            this.addRentalButton.UseVisualStyleBackColor = false;
            this.addRentalButton.Click += new System.EventHandler(this.addRentalButton_Click);
            // 
            // returnedRentalsButton
            // 
            this.returnedRentalsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.returnedRentalsButton.FlatAppearance.BorderSize = 0;
            this.returnedRentalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.returnedRentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnedRentalsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedRentalsButton.Location = new System.Drawing.Point(0, 0);
            this.returnedRentalsButton.Name = "returnedRentalsButton";
            this.returnedRentalsButton.Size = new System.Drawing.Size(162, 45);
            this.returnedRentalsButton.TabIndex = 4;
            this.returnedRentalsButton.Text = "المعادة";
            this.returnedRentalsButton.UseVisualStyleBackColor = false;
            this.returnedRentalsButton.Click += new System.EventHandler(this.returnedRentalsButton_Click);
            // 
            // newRentalsButton
            // 
            this.newRentalsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.newRentalsButton.FlatAppearance.BorderSize = 0;
            this.newRentalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.newRentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRentalsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRentalsButton.ForeColor = System.Drawing.Color.Green;
            this.newRentalsButton.Location = new System.Drawing.Point(162, 0);
            this.newRentalsButton.Name = "newRentalsButton";
            this.newRentalsButton.Size = new System.Drawing.Size(162, 45);
            this.newRentalsButton.TabIndex = 3;
            this.newRentalsButton.Text = "الحديثة";
            this.newRentalsButton.UseVisualStyleBackColor = false;
            this.newRentalsButton.Click += new System.EventHandler(this.newRentalsButton_Click);
            // 
            // lateRentalsButton
            // 
            this.lateRentalsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.lateRentalsButton.FlatAppearance.BorderSize = 0;
            this.lateRentalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lateRentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lateRentalsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lateRentalsButton.ForeColor = System.Drawing.Color.Red;
            this.lateRentalsButton.Location = new System.Drawing.Point(324, 0);
            this.lateRentalsButton.Name = "lateRentalsButton";
            this.lateRentalsButton.Size = new System.Drawing.Size(162, 45);
            this.lateRentalsButton.TabIndex = 2;
            this.lateRentalsButton.Text = "المتأخرة";
            this.lateRentalsButton.UseVisualStyleBackColor = false;
            this.lateRentalsButton.Click += new System.EventHandler(this.lateRentalsButton_Click);
            // 
            // activeRentalsButton
            // 
            this.activeRentalsButton.FlatAppearance.BorderSize = 0;
            this.activeRentalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.activeRentalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activeRentalsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeRentalsButton.ForeColor = System.Drawing.Color.Navy;
            this.activeRentalsButton.Location = new System.Drawing.Point(486, 0);
            this.activeRentalsButton.Name = "activeRentalsButton";
            this.activeRentalsButton.Size = new System.Drawing.Size(164, 45);
            this.activeRentalsButton.TabIndex = 1;
            this.activeRentalsButton.Text = "النشطة";
            this.activeRentalsButton.UseVisualStyleBackColor = true;
            this.activeRentalsButton.Click += new System.EventHandler(this.activeRentalsButton_Click);
            // 
            // carsPanel
            // 
            this.carsPanel.BackColor = System.Drawing.Color.White;
            this.carsPanel.Controls.Add(this.carsRefreshButton);
            this.carsPanel.Controls.Add(this.carsDeleteButton);
            this.carsPanel.Controls.Add(this.carsModifyButton);
            this.carsPanel.Controls.Add(this.carsDetailsButton);
            this.carsPanel.Controls.Add(this.carsListBox);
            this.carsPanel.Controls.Add(this.addCarButton);
            this.carsPanel.Location = new System.Drawing.Point(25, 125);
            this.carsPanel.Name = "carsPanel";
            this.carsPanel.Size = new System.Drawing.Size(650, 500);
            this.carsPanel.TabIndex = 3;
            this.carsPanel.Visible = false;
            // 
            // carsRefreshButton
            // 
            this.carsRefreshButton.BackColor = System.Drawing.Color.White;
            this.carsRefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.carsRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsRefreshButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsRefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.carsRefreshButton.Image = global::ACRS.Properties.Resources.green_refresh_image_30x30;
            this.carsRefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carsRefreshButton.Location = new System.Drawing.Point(31, 294);
            this.carsRefreshButton.Name = "carsRefreshButton";
            this.carsRefreshButton.Size = new System.Drawing.Size(130, 50);
            this.carsRefreshButton.TabIndex = 10;
            this.carsRefreshButton.Text = "تحديث";
            this.carsRefreshButton.UseVisualStyleBackColor = false;
            this.carsRefreshButton.Click += new System.EventHandler(this.carsRefreshButton_Click);
            // 
            // carsDeleteButton
            // 
            this.carsDeleteButton.BackColor = System.Drawing.Color.White;
            this.carsDeleteButton.Enabled = false;
            this.carsDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.carsDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsDeleteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.carsDeleteButton.Image = global::ACRS.Properties.Resources.cancel_image_30x30;
            this.carsDeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carsDeleteButton.Location = new System.Drawing.Point(31, 228);
            this.carsDeleteButton.Name = "carsDeleteButton";
            this.carsDeleteButton.Size = new System.Drawing.Size(130, 50);
            this.carsDeleteButton.TabIndex = 9;
            this.carsDeleteButton.Text = "حذف";
            this.carsDeleteButton.UseVisualStyleBackColor = false;
            this.carsDeleteButton.Click += new System.EventHandler(this.carsDeleteButton_Click);
            // 
            // carsModifyButton
            // 
            this.carsModifyButton.BackColor = System.Drawing.Color.White;
            this.carsModifyButton.Enabled = false;
            this.carsModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.carsModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsModifyButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsModifyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.carsModifyButton.Image = global::ACRS.Properties.Resources.modify_image_30x30;
            this.carsModifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carsModifyButton.Location = new System.Drawing.Point(31, 163);
            this.carsModifyButton.Name = "carsModifyButton";
            this.carsModifyButton.Size = new System.Drawing.Size(130, 50);
            this.carsModifyButton.TabIndex = 8;
            this.carsModifyButton.Text = "تعديل";
            this.carsModifyButton.UseVisualStyleBackColor = false;
            this.carsModifyButton.Click += new System.EventHandler(this.carsModifyButton_Click);
            // 
            // carsDetailsButton
            // 
            this.carsDetailsButton.BackColor = System.Drawing.Color.White;
            this.carsDetailsButton.Enabled = false;
            this.carsDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.carsDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carsDetailsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carsDetailsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.carsDetailsButton.Image = global::ACRS.Properties.Resources.details_image_30x30;
            this.carsDetailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carsDetailsButton.Location = new System.Drawing.Point(31, 99);
            this.carsDetailsButton.Name = "carsDetailsButton";
            this.carsDetailsButton.Size = new System.Drawing.Size(130, 50);
            this.carsDetailsButton.TabIndex = 7;
            this.carsDetailsButton.Text = "تفاصيل";
            this.carsDetailsButton.UseVisualStyleBackColor = false;
            this.carsDetailsButton.Click += new System.EventHandler(this.carsDetailsButton_Click);
            // 
            // carsListBox
            // 
            this.carsListBox.FormattingEnabled = true;
            this.carsListBox.ItemHeight = 20;
            this.carsListBox.Location = new System.Drawing.Point(185, 25);
            this.carsListBox.Name = "carsListBox";
            this.carsListBox.Size = new System.Drawing.Size(440, 404);
            this.carsListBox.TabIndex = 6;
            this.carsListBox.SelectedIndexChanged += new System.EventHandler(this.carsListBox_SelectedIndexChanged);
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.Color.Green;
            this.addCarButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.ForeColor = System.Drawing.Color.White;
            this.addCarButton.Image = global::ACRS.Properties.Resources.add_car_image_50x50;
            this.addCarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCarButton.Location = new System.Drawing.Point(0, 450);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(650, 50);
            this.addCarButton.TabIndex = 0;
            this.addCarButton.Text = "إضافة سيارة";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // customersPanel
            // 
            this.customersPanel.BackColor = System.Drawing.Color.White;
            this.customersPanel.Controls.Add(this.customersRefreshButton);
            this.customersPanel.Controls.Add(this.customersDeleteButton);
            this.customersPanel.Controls.Add(this.customerModifyButton);
            this.customersPanel.Controls.Add(this.customerDetailsButton);
            this.customersPanel.Controls.Add(this.customersListBox);
            this.customersPanel.Controls.Add(this.addCustomerButton);
            this.customersPanel.Location = new System.Drawing.Point(25, 125);
            this.customersPanel.Name = "customersPanel";
            this.customersPanel.Size = new System.Drawing.Size(650, 500);
            this.customersPanel.TabIndex = 4;
            this.customersPanel.Visible = false;
            // 
            // customersRefreshButton
            // 
            this.customersRefreshButton.BackColor = System.Drawing.Color.White;
            this.customersRefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.customersRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersRefreshButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersRefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(47)))));
            this.customersRefreshButton.Image = global::ACRS.Properties.Resources.green_refresh_image_30x30;
            this.customersRefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersRefreshButton.Location = new System.Drawing.Point(31, 294);
            this.customersRefreshButton.Name = "customersRefreshButton";
            this.customersRefreshButton.Size = new System.Drawing.Size(130, 50);
            this.customersRefreshButton.TabIndex = 15;
            this.customersRefreshButton.Text = "تحديث";
            this.customersRefreshButton.UseVisualStyleBackColor = false;
            this.customersRefreshButton.Click += new System.EventHandler(this.customersRefreshButton_Click);
            // 
            // customersDeleteButton
            // 
            this.customersDeleteButton.BackColor = System.Drawing.Color.White;
            this.customersDeleteButton.Enabled = false;
            this.customersDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customersDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersDeleteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersDeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.customersDeleteButton.Image = global::ACRS.Properties.Resources.cancel_image_30x30;
            this.customersDeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersDeleteButton.Location = new System.Drawing.Point(31, 228);
            this.customersDeleteButton.Name = "customersDeleteButton";
            this.customersDeleteButton.Size = new System.Drawing.Size(130, 50);
            this.customersDeleteButton.TabIndex = 14;
            this.customersDeleteButton.Text = "حذف";
            this.customersDeleteButton.UseVisualStyleBackColor = false;
            this.customersDeleteButton.Click += new System.EventHandler(this.customersDeleteButton_Click);
            // 
            // customerModifyButton
            // 
            this.customerModifyButton.BackColor = System.Drawing.Color.White;
            this.customerModifyButton.Enabled = false;
            this.customerModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.customerModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerModifyButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerModifyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.customerModifyButton.Image = global::ACRS.Properties.Resources.modify_image_30x30;
            this.customerModifyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerModifyButton.Location = new System.Drawing.Point(31, 163);
            this.customerModifyButton.Name = "customerModifyButton";
            this.customerModifyButton.Size = new System.Drawing.Size(130, 50);
            this.customerModifyButton.TabIndex = 13;
            this.customerModifyButton.Text = "تعديل";
            this.customerModifyButton.UseVisualStyleBackColor = false;
            this.customerModifyButton.Click += new System.EventHandler(this.customerModifyButton_Click);
            // 
            // customerDetailsButton
            // 
            this.customerDetailsButton.BackColor = System.Drawing.Color.White;
            this.customerDetailsButton.Enabled = false;
            this.customerDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.customerDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerDetailsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDetailsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(165)))), ((int)(((byte)(229)))));
            this.customerDetailsButton.Image = global::ACRS.Properties.Resources.details_image_30x30;
            this.customerDetailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerDetailsButton.Location = new System.Drawing.Point(31, 99);
            this.customerDetailsButton.Name = "customerDetailsButton";
            this.customerDetailsButton.Size = new System.Drawing.Size(130, 50);
            this.customerDetailsButton.TabIndex = 12;
            this.customerDetailsButton.Text = "تفاصيل";
            this.customerDetailsButton.UseVisualStyleBackColor = false;
            this.customerDetailsButton.Click += new System.EventHandler(this.customerDetailsButton_Click);
            // 
            // customersListBox
            // 
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 20;
            this.customersListBox.Location = new System.Drawing.Point(185, 25);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(440, 404);
            this.customersListBox.TabIndex = 11;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.customersListBox_SelectedIndexChanged);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.Color.Green;
            this.addCustomerButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addCustomerButton.FlatAppearance.BorderSize = 0;
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerButton.ForeColor = System.Drawing.Color.White;
            this.addCustomerButton.Image = global::ACRS.Properties.Resources.add_customer_image_50x50;
            this.addCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCustomerButton.Location = new System.Drawing.Point(0, 450);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(650, 50);
            this.addCustomerButton.TabIndex = 1;
            this.addCustomerButton.Text = "إضافة زبون";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(60)))), ((int)(((byte)(234)))));
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Location = new System.Drawing.Point(0, 40);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(700, 60);
            this.titlePanel.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(512, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(138, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "إدارة المستأجرات";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(920, 650);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.customersPanel);
            this.Controls.Add(this.carsPanel);
            this.Controls.Add(this.rentalsPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تأجير السيارات";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.rentalsPanel.ResumeLayout(false);
            this.rentalListsPanel.ResumeLayout(false);
            this.carsPanel.ResumeLayout(false);
            this.customersPanel.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button rentalsButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button carsButton;
        private System.Windows.Forms.Panel rentalsPanel;
        private System.Windows.Forms.Button returnedRentalsButton;
        private System.Windows.Forms.Button newRentalsButton;
        private System.Windows.Forms.Button lateRentalsButton;
        private System.Windows.Forms.Button activeRentalsButton;
        private System.Windows.Forms.Panel carsPanel;
        private System.Windows.Forms.Panel customersPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addRentalButton;
        private System.Windows.Forms.Panel rentalListsPanel;
        private System.Windows.Forms.Button rentalsCancelButton;
        private System.Windows.Forms.Button rentalsModifyButton;
        private System.Windows.Forms.Button returnRentalsButton;
        private System.Windows.Forms.Button rentalDetailsButton;
        private System.Windows.Forms.ListBox rentalsListBox;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button carsRefreshButton;
        private System.Windows.Forms.Button carsDeleteButton;
        private System.Windows.Forms.Button carsModifyButton;
        private System.Windows.Forms.Button carsDetailsButton;
        private System.Windows.Forms.ListBox carsListBox;
        private System.Windows.Forms.Button customersRefreshButton;
        private System.Windows.Forms.Button customersDeleteButton;
        private System.Windows.Forms.Button customerModifyButton;
        private System.Windows.Forms.Button customerDetailsButton;
        private System.Windows.Forms.ListBox customersListBox;
    }
}