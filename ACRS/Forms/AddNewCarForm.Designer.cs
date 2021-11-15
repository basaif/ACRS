namespace ACRS.Forms
{
    partial class AddNewCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCarForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.carPanel = new System.Windows.Forms.Panel();
            this.mileageValue = new System.Windows.Forms.TextBox();
            this.featuresGroupBox = new System.Windows.Forms.GroupBox();
            this.removeFeatureButton = new System.Windows.Forms.Button();
            this.addFeatureButton = new System.Windows.Forms.Button();
            this.featuresListBox = new System.Windows.Forms.ListBox();
            this.featuresComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.pricePerDayDollarSignLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.saveCarButton = new System.Windows.Forms.Button();
            this.registerationNumberLabel = new System.Windows.Forms.Label();
            this.pricePerDayLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.pricePerDayValue = new System.Windows.Forms.TextBox();
            this.modelValue = new System.Windows.Forms.TextBox();
            this.makeValue = new System.Windows.Forms.TextBox();
            this.registerationNumberValue = new System.Windows.Forms.TextBox();
            this.yearValue = new System.Windows.Forms.TextBox();
            this.carTitleLabel = new System.Windows.Forms.Label();
            this.categoryPanel = new System.Windows.Forms.Panel();
            this.saveCategoryButton = new System.Windows.Forms.Button();
            this.luggageNumberLabel = new System.Windows.Forms.Label();
            this.luggageNumberValue = new System.Windows.Forms.TextBox();
            this.peopleNumberLabel = new System.Windows.Forms.Label();
            this.peopleNumberValue = new System.Windows.Forms.TextBox();
            this.categoryNameLabel = new System.Windows.Forms.Label();
            this.categoryNameValue = new System.Windows.Forms.TextBox();
            this.categoryTitleLabel = new System.Windows.Forms.Label();
            this.featurePanel = new System.Windows.Forms.Panel();
            this.saveFeatureButton = new System.Windows.Forms.Button();
            this.featureNameLabel = new System.Windows.Forms.Label();
            this.featureNameValue = new System.Windows.Forms.TextBox();
            this.featuresTitleLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.carPanel.SuspendLayout();
            this.featuresGroupBox.SuspendLayout();
            this.categoryPanel.SuspendLayout();
            this.featurePanel.SuspendLayout();
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
            this.headerPanel.TabIndex = 1;
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
            this.headerLabel.Location = new System.Drawing.Point(788, 14);
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
            // 
            // carPanel
            // 
            this.carPanel.BackColor = System.Drawing.Color.White;
            this.carPanel.Controls.Add(this.mileageValue);
            this.carPanel.Controls.Add(this.featuresGroupBox);
            this.carPanel.Controls.Add(this.typeComboBox);
            this.carPanel.Controls.Add(this.pricePerDayDollarSignLabel);
            this.carPanel.Controls.Add(this.typeLabel);
            this.carPanel.Controls.Add(this.mileageLabel);
            this.carPanel.Controls.Add(this.saveCarButton);
            this.carPanel.Controls.Add(this.registerationNumberLabel);
            this.carPanel.Controls.Add(this.pricePerDayLabel);
            this.carPanel.Controls.Add(this.modelLabel);
            this.carPanel.Controls.Add(this.makeLabel);
            this.carPanel.Controls.Add(this.yearLabel);
            this.carPanel.Controls.Add(this.pricePerDayValue);
            this.carPanel.Controls.Add(this.modelValue);
            this.carPanel.Controls.Add(this.makeValue);
            this.carPanel.Controls.Add(this.registerationNumberValue);
            this.carPanel.Controls.Add(this.yearValue);
            this.carPanel.Controls.Add(this.carTitleLabel);
            this.carPanel.Location = new System.Drawing.Point(325, 60);
            this.carPanel.Name = "carPanel";
            this.carPanel.Size = new System.Drawing.Size(575, 520);
            this.carPanel.TabIndex = 0;
            // 
            // mileageValue
            // 
            this.mileageValue.ForeColor = System.Drawing.Color.Black;
            this.mileageValue.Location = new System.Drawing.Point(30, 138);
            this.mileageValue.Name = "mileageValue";
            this.mileageValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mileageValue.Size = new System.Drawing.Size(141, 27);
            this.mileageValue.TabIndex = 6;
            this.mileageValue.TextChanged += new System.EventHandler(this.registerationNumberValue_TextChanged);
            // 
            // featuresGroupBox
            // 
            this.featuresGroupBox.Controls.Add(this.removeFeatureButton);
            this.featuresGroupBox.Controls.Add(this.addFeatureButton);
            this.featuresGroupBox.Controls.Add(this.featuresListBox);
            this.featuresGroupBox.Controls.Add(this.featuresComboBox);
            this.featuresGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.featuresGroupBox.Location = new System.Drawing.Point(26, 213);
            this.featuresGroupBox.Name = "featuresGroupBox";
            this.featuresGroupBox.Size = new System.Drawing.Size(513, 210);
            this.featuresGroupBox.TabIndex = 0;
            this.featuresGroupBox.TabStop = false;
            this.featuresGroupBox.Text = "الميزات";
            // 
            // removeFeatureButton
            // 
            this.removeFeatureButton.Enabled = false;
            this.removeFeatureButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.removeFeatureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeFeatureButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFeatureButton.ForeColor = System.Drawing.Color.Red;
            this.removeFeatureButton.Image = global::ACRS.Properties.Resources.remove_image_30x30;
            this.removeFeatureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeFeatureButton.Location = new System.Drawing.Point(21, 139);
            this.removeFeatureButton.Name = "removeFeatureButton";
            this.removeFeatureButton.Padding = new System.Windows.Forms.Padding(5);
            this.removeFeatureButton.Size = new System.Drawing.Size(184, 45);
            this.removeFeatureButton.TabIndex = 11;
            this.removeFeatureButton.Text = "احذف الميزة";
            this.removeFeatureButton.UseVisualStyleBackColor = true;
            this.removeFeatureButton.Click += new System.EventHandler(this.removeFeatureButton_Click);
            // 
            // addFeatureButton
            // 
            this.addFeatureButton.Enabled = false;
            this.addFeatureButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.addFeatureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFeatureButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFeatureButton.ForeColor = System.Drawing.Color.Green;
            this.addFeatureButton.Image = global::ACRS.Properties.Resources.add_image_30x30;
            this.addFeatureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addFeatureButton.Location = new System.Drawing.Point(21, 82);
            this.addFeatureButton.Name = "addFeatureButton";
            this.addFeatureButton.Padding = new System.Windows.Forms.Padding(5);
            this.addFeatureButton.Size = new System.Drawing.Size(184, 45);
            this.addFeatureButton.TabIndex = 10;
            this.addFeatureButton.Text = "أضف الميزة";
            this.addFeatureButton.UseVisualStyleBackColor = true;
            this.addFeatureButton.Click += new System.EventHandler(this.addFeatureButton_Click);
            // 
            // featuresListBox
            // 
            this.featuresListBox.ForeColor = System.Drawing.Color.Navy;
            this.featuresListBox.FormattingEnabled = true;
            this.featuresListBox.ItemHeight = 20;
            this.featuresListBox.Location = new System.Drawing.Point(218, 40);
            this.featuresListBox.Name = "featuresListBox";
            this.featuresListBox.Size = new System.Drawing.Size(269, 144);
            this.featuresListBox.TabIndex = 9;
            this.featuresListBox.SelectedIndexChanged += new System.EventHandler(this.featuresListBox_SelectedIndexChanged);
            // 
            // featuresComboBox
            // 
            this.featuresComboBox.ForeColor = System.Drawing.Color.Navy;
            this.featuresComboBox.FormattingEnabled = true;
            this.featuresComboBox.Location = new System.Drawing.Point(21, 40);
            this.featuresComboBox.Name = "featuresComboBox";
            this.featuresComboBox.Size = new System.Drawing.Size(184, 28);
            this.featuresComboBox.TabIndex = 8;
            this.featuresComboBox.SelectedIndexChanged += new System.EventHandler(this.featuresComboBox_SelectedIndexChanged);
            // 
            // typeComboBox
            // 
            this.typeComboBox.ForeColor = System.Drawing.Color.Navy;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(187, 177);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(252, 28);
            this.typeComboBox.TabIndex = 7;
            // 
            // pricePerDayDollarSignLabel
            // 
            this.pricePerDayDollarSignLabel.AutoSize = true;
            this.pricePerDayDollarSignLabel.ForeColor = System.Drawing.Color.Navy;
            this.pricePerDayDollarSignLabel.Location = new System.Drawing.Point(316, 141);
            this.pricePerDayDollarSignLabel.Name = "pricePerDayDollarSignLabel";
            this.pricePerDayDollarSignLabel.Size = new System.Drawing.Size(17, 20);
            this.pricePerDayDollarSignLabel.TabIndex = 0;
            this.pricePerDayDollarSignLabel.Text = "$";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.ForeColor = System.Drawing.Color.Navy;
            this.typeLabel.Location = new System.Drawing.Point(445, 181);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 20);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "النوع";
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.ForeColor = System.Drawing.Color.Navy;
            this.mileageLabel.Location = new System.Drawing.Point(177, 141);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(102, 20);
            this.mileageLabel.TabIndex = 0;
            this.mileageLabel.Text = "المسافة بالميل";
            // 
            // saveCarButton
            // 
            this.saveCarButton.Enabled = false;
            this.saveCarButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.saveCarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCarButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCarButton.ForeColor = System.Drawing.Color.Green;
            this.saveCarButton.Image = global::ACRS.Properties.Resources.save_image_30x30;
            this.saveCarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveCarButton.Location = new System.Drawing.Point(30, 447);
            this.saveCarButton.Name = "saveCarButton";
            this.saveCarButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveCarButton.Size = new System.Drawing.Size(148, 50);
            this.saveCarButton.TabIndex = 22;
            this.saveCarButton.Text = "حفظ";
            this.saveCarButton.UseVisualStyleBackColor = true;
            this.saveCarButton.Click += new System.EventHandler(this.saveCarButton_Click);
            // 
            // registerationNumberLabel
            // 
            this.registerationNumberLabel.AutoSize = true;
            this.registerationNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.registerationNumberLabel.Location = new System.Drawing.Point(445, 61);
            this.registerationNumberLabel.Name = "registerationNumberLabel";
            this.registerationNumberLabel.Size = new System.Drawing.Size(79, 20);
            this.registerationNumberLabel.TabIndex = 0;
            this.registerationNumberLabel.Text = "رقم السيارة";
            // 
            // pricePerDayLabel
            // 
            this.pricePerDayLabel.AutoSize = true;
            this.pricePerDayLabel.ForeColor = System.Drawing.Color.Navy;
            this.pricePerDayLabel.Location = new System.Drawing.Point(445, 141);
            this.pricePerDayLabel.Name = "pricePerDayLabel";
            this.pricePerDayLabel.Size = new System.Drawing.Size(99, 20);
            this.pricePerDayLabel.TabIndex = 0;
            this.pricePerDayLabel.Text = "السعر لكل يوم";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.ForeColor = System.Drawing.Color.Navy;
            this.modelLabel.Location = new System.Drawing.Point(177, 101);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(58, 20);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "الموديل";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.ForeColor = System.Drawing.Color.Navy;
            this.makeLabel.Location = new System.Drawing.Point(445, 101);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(50, 20);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "الشركة";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.ForeColor = System.Drawing.Color.Navy;
            this.yearLabel.Location = new System.Drawing.Point(177, 61);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(44, 20);
            this.yearLabel.TabIndex = 0;
            this.yearLabel.Text = "السنة";
            // 
            // pricePerDayValue
            // 
            this.pricePerDayValue.ForeColor = System.Drawing.Color.Black;
            this.pricePerDayValue.Location = new System.Drawing.Point(341, 138);
            this.pricePerDayValue.Name = "pricePerDayValue";
            this.pricePerDayValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pricePerDayValue.Size = new System.Drawing.Size(98, 27);
            this.pricePerDayValue.TabIndex = 5;
            this.pricePerDayValue.TextChanged += new System.EventHandler(this.registerationNumberValue_TextChanged);
            // 
            // modelValue
            // 
            this.modelValue.ForeColor = System.Drawing.Color.Black;
            this.modelValue.Location = new System.Drawing.Point(30, 98);
            this.modelValue.Name = "modelValue";
            this.modelValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.modelValue.Size = new System.Drawing.Size(141, 27);
            this.modelValue.TabIndex = 4;
            this.modelValue.TextChanged += new System.EventHandler(this.registerationNumberValue_TextChanged);
            // 
            // makeValue
            // 
            this.makeValue.ForeColor = System.Drawing.Color.Black;
            this.makeValue.Location = new System.Drawing.Point(292, 98);
            this.makeValue.Name = "makeValue";
            this.makeValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.makeValue.Size = new System.Drawing.Size(147, 27);
            this.makeValue.TabIndex = 3;
            this.makeValue.TextChanged += new System.EventHandler(this.registerationNumberValue_TextChanged);
            // 
            // registerationNumberValue
            // 
            this.registerationNumberValue.ForeColor = System.Drawing.Color.Black;
            this.registerationNumberValue.Location = new System.Drawing.Point(292, 58);
            this.registerationNumberValue.Name = "registerationNumberValue";
            this.registerationNumberValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.registerationNumberValue.Size = new System.Drawing.Size(147, 27);
            this.registerationNumberValue.TabIndex = 1;
            this.registerationNumberValue.TextChanged += new System.EventHandler(this.registerationNumberValue_TextChanged);
            // 
            // yearValue
            // 
            this.yearValue.ForeColor = System.Drawing.Color.Black;
            this.yearValue.Location = new System.Drawing.Point(84, 58);
            this.yearValue.Name = "yearValue";
            this.yearValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yearValue.Size = new System.Drawing.Size(87, 27);
            this.yearValue.TabIndex = 2;
            this.yearValue.TextChanged += new System.EventHandler(this.registerationNumberValue_TextChanged);
            // 
            // carTitleLabel
            // 
            this.carTitleLabel.AutoSize = true;
            this.carTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carTitleLabel.ForeColor = System.Drawing.Color.Navy;
            this.carTitleLabel.Location = new System.Drawing.Point(458, 10);
            this.carTitleLabel.Name = "carTitleLabel";
            this.carTitleLabel.Size = new System.Drawing.Size(107, 25);
            this.carTitleLabel.TabIndex = 0;
            this.carTitleLabel.Text = "سيارة جديدة";
            // 
            // categoryPanel
            // 
            this.categoryPanel.BackColor = System.Drawing.Color.White;
            this.categoryPanel.Controls.Add(this.saveCategoryButton);
            this.categoryPanel.Controls.Add(this.luggageNumberLabel);
            this.categoryPanel.Controls.Add(this.luggageNumberValue);
            this.categoryPanel.Controls.Add(this.peopleNumberLabel);
            this.categoryPanel.Controls.Add(this.peopleNumberValue);
            this.categoryPanel.Controls.Add(this.categoryNameLabel);
            this.categoryPanel.Controls.Add(this.categoryNameValue);
            this.categoryPanel.Controls.Add(this.categoryTitleLabel);
            this.categoryPanel.Location = new System.Drawing.Point(20, 60);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(300, 300);
            this.categoryPanel.TabIndex = 0;
            // 
            // saveCategoryButton
            // 
            this.saveCategoryButton.Enabled = false;
            this.saveCategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.saveCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCategoryButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCategoryButton.ForeColor = System.Drawing.Color.Green;
            this.saveCategoryButton.Image = global::ACRS.Properties.Resources.add_image_30x30;
            this.saveCategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveCategoryButton.Location = new System.Drawing.Point(17, 231);
            this.saveCategoryButton.Name = "saveCategoryButton";
            this.saveCategoryButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveCategoryButton.Size = new System.Drawing.Size(170, 40);
            this.saveCategoryButton.TabIndex = 14;
            this.saveCategoryButton.Text = "إضافة نوع";
            this.saveCategoryButton.UseVisualStyleBackColor = true;
            this.saveCategoryButton.Click += new System.EventHandler(this.saveCategoryButton_Click);
            // 
            // luggageNumberLabel
            // 
            this.luggageNumberLabel.AutoSize = true;
            this.luggageNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.luggageNumberLabel.Location = new System.Drawing.Point(186, 164);
            this.luggageNumberLabel.Name = "luggageNumberLabel";
            this.luggageNumberLabel.Size = new System.Drawing.Size(87, 20);
            this.luggageNumberLabel.TabIndex = 0;
            this.luggageNumberLabel.Text = "عدد الحقائب";
            // 
            // luggageNumberValue
            // 
            this.luggageNumberValue.ForeColor = System.Drawing.Color.Black;
            this.luggageNumberValue.Location = new System.Drawing.Point(30, 161);
            this.luggageNumberValue.Name = "luggageNumberValue";
            this.luggageNumberValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.luggageNumberValue.Size = new System.Drawing.Size(147, 27);
            this.luggageNumberValue.TabIndex = 13;
            this.luggageNumberValue.TextChanged += new System.EventHandler(this.categoryNameValue_TextChanged);
            // 
            // peopleNumberLabel
            // 
            this.peopleNumberLabel.AutoSize = true;
            this.peopleNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.peopleNumberLabel.Location = new System.Drawing.Point(186, 124);
            this.peopleNumberLabel.Name = "peopleNumberLabel";
            this.peopleNumberLabel.Size = new System.Drawing.Size(78, 20);
            this.peopleNumberLabel.TabIndex = 0;
            this.peopleNumberLabel.Text = "عدد الركاب";
            // 
            // peopleNumberValue
            // 
            this.peopleNumberValue.ForeColor = System.Drawing.Color.Black;
            this.peopleNumberValue.Location = new System.Drawing.Point(30, 121);
            this.peopleNumberValue.Name = "peopleNumberValue";
            this.peopleNumberValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.peopleNumberValue.Size = new System.Drawing.Size(147, 27);
            this.peopleNumberValue.TabIndex = 12;
            this.peopleNumberValue.TextChanged += new System.EventHandler(this.categoryNameValue_TextChanged);
            // 
            // categoryNameLabel
            // 
            this.categoryNameLabel.AutoSize = true;
            this.categoryNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.categoryNameLabel.Location = new System.Drawing.Point(186, 84);
            this.categoryNameLabel.Name = "categoryNameLabel";
            this.categoryNameLabel.Size = new System.Drawing.Size(70, 20);
            this.categoryNameLabel.TabIndex = 0;
            this.categoryNameLabel.Text = "اسم النوع";
            // 
            // categoryNameValue
            // 
            this.categoryNameValue.ForeColor = System.Drawing.Color.Black;
            this.categoryNameValue.Location = new System.Drawing.Point(30, 81);
            this.categoryNameValue.Name = "categoryNameValue";
            this.categoryNameValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoryNameValue.Size = new System.Drawing.Size(147, 27);
            this.categoryNameValue.TabIndex = 11;
            this.categoryNameValue.TextChanged += new System.EventHandler(this.categoryNameValue_TextChanged);
            // 
            // categoryTitleLabel
            // 
            this.categoryTitleLabel.AutoSize = true;
            this.categoryTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryTitleLabel.ForeColor = System.Drawing.Color.Navy;
            this.categoryTitleLabel.Location = new System.Drawing.Point(208, 10);
            this.categoryTitleLabel.Name = "categoryTitleLabel";
            this.categoryTitleLabel.Size = new System.Drawing.Size(82, 25);
            this.categoryTitleLabel.TabIndex = 0;
            this.categoryTitleLabel.Text = "نوع جديد";
            // 
            // featurePanel
            // 
            this.featurePanel.BackColor = System.Drawing.Color.White;
            this.featurePanel.Controls.Add(this.saveFeatureButton);
            this.featurePanel.Controls.Add(this.featureNameLabel);
            this.featurePanel.Controls.Add(this.featureNameValue);
            this.featurePanel.Controls.Add(this.featuresTitleLabel);
            this.featurePanel.Location = new System.Drawing.Point(20, 365);
            this.featurePanel.Name = "featurePanel";
            this.featurePanel.Size = new System.Drawing.Size(300, 215);
            this.featurePanel.TabIndex = 0;
            // 
            // saveFeatureButton
            // 
            this.saveFeatureButton.Enabled = false;
            this.saveFeatureButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.saveFeatureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFeatureButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFeatureButton.ForeColor = System.Drawing.Color.Green;
            this.saveFeatureButton.Image = global::ACRS.Properties.Resources.add_image_30x30;
            this.saveFeatureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveFeatureButton.Location = new System.Drawing.Point(17, 147);
            this.saveFeatureButton.Name = "saveFeatureButton";
            this.saveFeatureButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveFeatureButton.Size = new System.Drawing.Size(170, 40);
            this.saveFeatureButton.TabIndex = 16;
            this.saveFeatureButton.Text = "إضافة ميزة";
            this.saveFeatureButton.UseVisualStyleBackColor = true;
            this.saveFeatureButton.Click += new System.EventHandler(this.saveFeatureButton_Click);
            // 
            // featureNameLabel
            // 
            this.featureNameLabel.AutoSize = true;
            this.featureNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.featureNameLabel.Location = new System.Drawing.Point(186, 79);
            this.featureNameLabel.Name = "featureNameLabel";
            this.featureNameLabel.Size = new System.Drawing.Size(75, 20);
            this.featureNameLabel.TabIndex = 0;
            this.featureNameLabel.Text = "اسم الميزة";
            // 
            // featureNameValue
            // 
            this.featureNameValue.ForeColor = System.Drawing.Color.Black;
            this.featureNameValue.Location = new System.Drawing.Point(30, 76);
            this.featureNameValue.Name = "featureNameValue";
            this.featureNameValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.featureNameValue.Size = new System.Drawing.Size(147, 27);
            this.featureNameValue.TabIndex = 15;
            this.featureNameValue.TextChanged += new System.EventHandler(this.featureNameValue_TextChanged);
            // 
            // featuresTitleLabel
            // 
            this.featuresTitleLabel.AutoSize = true;
            this.featuresTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresTitleLabel.ForeColor = System.Drawing.Color.Navy;
            this.featuresTitleLabel.Location = new System.Drawing.Point(193, 10);
            this.featuresTitleLabel.Name = "featuresTitleLabel";
            this.featuresTitleLabel.Size = new System.Drawing.Size(97, 25);
            this.featuresTitleLabel.TabIndex = 0;
            this.featuresTitleLabel.Text = "ميزة جديدة";
            // 
            // AddNewCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(920, 600);
            this.Controls.Add(this.featurePanel);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.carPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewCarForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة سيارة جديدة";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.carPanel.ResumeLayout(false);
            this.carPanel.PerformLayout();
            this.featuresGroupBox.ResumeLayout(false);
            this.categoryPanel.ResumeLayout(false);
            this.categoryPanel.PerformLayout();
            this.featurePanel.ResumeLayout(false);
            this.featurePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel carPanel;
        private System.Windows.Forms.Panel categoryPanel;
        private System.Windows.Forms.Panel featurePanel;
        private System.Windows.Forms.Label carTitleLabel;
        private System.Windows.Forms.GroupBox featuresGroupBox;
        private System.Windows.Forms.Button addFeatureButton;
        private System.Windows.Forms.ListBox featuresListBox;
        private System.Windows.Forms.ComboBox featuresComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label pricePerDayDollarSignLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Button saveCarButton;
        private System.Windows.Forms.Label registerationNumberLabel;
        private System.Windows.Forms.Label pricePerDayLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox pricePerDayValue;
        private System.Windows.Forms.TextBox modelValue;
        private System.Windows.Forms.TextBox makeValue;
        private System.Windows.Forms.TextBox registerationNumberValue;
        private System.Windows.Forms.TextBox yearValue;
        private System.Windows.Forms.Button saveCategoryButton;
        private System.Windows.Forms.Label luggageNumberLabel;
        private System.Windows.Forms.TextBox luggageNumberValue;
        private System.Windows.Forms.Label peopleNumberLabel;
        private System.Windows.Forms.TextBox peopleNumberValue;
        private System.Windows.Forms.Label categoryNameLabel;
        private System.Windows.Forms.TextBox categoryNameValue;
        private System.Windows.Forms.Label categoryTitleLabel;
        private System.Windows.Forms.Label featureNameLabel;
        private System.Windows.Forms.TextBox featureNameValue;
        private System.Windows.Forms.Label featuresTitleLabel;
        private System.Windows.Forms.TextBox mileageValue;
        private System.Windows.Forms.Button saveFeatureButton;
        private System.Windows.Forms.Button removeFeatureButton;
    }
}