namespace ACRS.Forms
{
    partial class RentalDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalDetailsForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.renterGroupBox = new System.Windows.Forms.GroupBox();
            this.emailValueLabel = new System.Windows.Forms.Label();
            this.phoneNumberValueLabel = new System.Windows.Forms.Label();
            this.licenseNumberValueLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.licenseNumberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.rentalDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.earlyDiscountValueLabel = new System.Windows.Forms.Label();
            this.lateFeeLabelValue = new System.Windows.Forms.Label();
            this.earlyDiscountLabel = new System.Windows.Forms.Label();
            this.lateFeeLabel = new System.Windows.Forms.Label();
            this.rentalStatusValueLabel = new System.Windows.Forms.Label();
            this.rentalPeriodValueLabel = new System.Windows.Forms.Label();
            this.estimatedPriceValueLabel = new System.Windows.Forms.Label();
            this.dropOffDateValueLabel = new System.Windows.Forms.Label();
            this.pickupDateValueLabel = new System.Windows.Forms.Label();
            this.rentalPeriodLabel = new System.Windows.Forms.Label();
            this.rentalStatusLabel = new System.Windows.Forms.Label();
            this.estimatedPriceLabel = new System.Windows.Forms.Label();
            this.dropoffDateLabel = new System.Windows.Forms.Label();
            this.pickupDateLabel = new System.Windows.Forms.Label();
            this.carGroupBox = new System.Windows.Forms.GroupBox();
            this.featuresTextBox = new System.Windows.Forms.TextBox();
            this.featuresLabel = new System.Windows.Forms.Label();
            this.luggageNumberValue = new System.Windows.Forms.Label();
            this.peopleNumberValue = new System.Windows.Forms.Label();
            this.luggageNumberLabel = new System.Windows.Forms.Label();
            this.peopleNumberLabel = new System.Windows.Forms.Label();
            this.mileageValue = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.pricePerDayValue = new System.Windows.Forms.Label();
            this.pricePerDayLabel = new System.Windows.Forms.Label();
            this.categoryValue = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.registerationNumberValue = new System.Windows.Forms.Label();
            this.registerationNumberLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.renterGroupBox.SuspendLayout();
            this.rentalDetailsGroupBox.SuspendLayout();
            this.carGroupBox.SuspendLayout();
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
            this.headerPanel.TabIndex = 2;
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
            this.headerLabel.Location = new System.Drawing.Point(790, 14);
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
            this.iconPictureBox.Location = new System.Drawing.Point(869, 0);
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
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.renterGroupBox);
            this.contentPanel.Controls.Add(this.rentalDetailsGroupBox);
            this.contentPanel.Controls.Add(this.carGroupBox);
            this.contentPanel.Location = new System.Drawing.Point(20, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(880, 440);
            this.contentPanel.TabIndex = 9;
            // 
            // renterGroupBox
            // 
            this.renterGroupBox.BackColor = System.Drawing.Color.White;
            this.renterGroupBox.Controls.Add(this.emailValueLabel);
            this.renterGroupBox.Controls.Add(this.phoneNumberValueLabel);
            this.renterGroupBox.Controls.Add(this.licenseNumberValueLabel);
            this.renterGroupBox.Controls.Add(this.nameValueLabel);
            this.renterGroupBox.Controls.Add(this.phoneNumberLabel);
            this.renterGroupBox.Controls.Add(this.emailLabel);
            this.renterGroupBox.Controls.Add(this.licenseNumberLabel);
            this.renterGroupBox.Controls.Add(this.nameLabel);
            this.renterGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.renterGroupBox.Location = new System.Drawing.Point(381, 260);
            this.renterGroupBox.Name = "renterGroupBox";
            this.renterGroupBox.Size = new System.Drawing.Size(480, 161);
            this.renterGroupBox.TabIndex = 27;
            this.renterGroupBox.TabStop = false;
            this.renterGroupBox.Text = "المستأجر";
            // 
            // emailValueLabel
            // 
            this.emailValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailValueLabel.AutoSize = true;
            this.emailValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.emailValueLabel.Location = new System.Drawing.Point(305, 120);
            this.emailValueLabel.Name = "emailValueLabel";
            this.emailValueLabel.Size = new System.Drawing.Size(15, 20);
            this.emailValueLabel.TabIndex = 27;
            this.emailValueLabel.Text = "-";
            this.emailValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNumberValueLabel
            // 
            this.phoneNumberValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberValueLabel.AutoSize = true;
            this.phoneNumberValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.phoneNumberValueLabel.Location = new System.Drawing.Point(305, 89);
            this.phoneNumberValueLabel.Name = "phoneNumberValueLabel";
            this.phoneNumberValueLabel.Size = new System.Drawing.Size(15, 20);
            this.phoneNumberValueLabel.TabIndex = 26;
            this.phoneNumberValueLabel.Text = "-";
            this.phoneNumberValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // licenseNumberValueLabel
            // 
            this.licenseNumberValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.licenseNumberValueLabel.AutoSize = true;
            this.licenseNumberValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.licenseNumberValueLabel.Location = new System.Drawing.Point(305, 58);
            this.licenseNumberValueLabel.Name = "licenseNumberValueLabel";
            this.licenseNumberValueLabel.Size = new System.Drawing.Size(15, 20);
            this.licenseNumberValueLabel.TabIndex = 25;
            this.licenseNumberValueLabel.Text = "-";
            this.licenseNumberValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameValueLabel.AutoSize = true;
            this.nameValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.nameValueLabel.Location = new System.Drawing.Point(305, 28);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(15, 20);
            this.nameValueLabel.TabIndex = 24;
            this.nameValueLabel.Text = "-";
            this.nameValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.phoneNumberLabel.Location = new System.Drawing.Point(328, 89);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(76, 20);
            this.phoneNumberLabel.TabIndex = 23;
            this.phoneNumberLabel.Text = "رقم الهاتف";
            this.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.Navy;
            this.emailLabel.Location = new System.Drawing.Point(328, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(109, 20);
            this.emailLabel.TabIndex = 22;
            this.emailLabel.Text = "البريد الإلكتروني";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // licenseNumberLabel
            // 
            this.licenseNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.licenseNumberLabel.AutoSize = true;
            this.licenseNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.licenseNumberLabel.Location = new System.Drawing.Point(328, 58);
            this.licenseNumberLabel.Name = "licenseNumberLabel";
            this.licenseNumberLabel.Size = new System.Drawing.Size(82, 20);
            this.licenseNumberLabel.TabIndex = 21;
            this.licenseNumberLabel.Text = "رقم الرخصة";
            this.licenseNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.Navy;
            this.nameLabel.Location = new System.Drawing.Point(328, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 20);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "الاسم";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentalDetailsGroupBox
            // 
            this.rentalDetailsGroupBox.BackColor = System.Drawing.Color.White;
            this.rentalDetailsGroupBox.Controls.Add(this.earlyDiscountValueLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.lateFeeLabelValue);
            this.rentalDetailsGroupBox.Controls.Add(this.earlyDiscountLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.lateFeeLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.rentalStatusValueLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.rentalPeriodValueLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.estimatedPriceValueLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.dropOffDateValueLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.pickupDateValueLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.rentalPeriodLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.rentalStatusLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.estimatedPriceLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.dropoffDateLabel);
            this.rentalDetailsGroupBox.Controls.Add(this.pickupDateLabel);
            this.rentalDetailsGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.rentalDetailsGroupBox.Location = new System.Drawing.Point(381, 9);
            this.rentalDetailsGroupBox.Name = "rentalDetailsGroupBox";
            this.rentalDetailsGroupBox.Size = new System.Drawing.Size(480, 245);
            this.rentalDetailsGroupBox.TabIndex = 22;
            this.rentalDetailsGroupBox.TabStop = false;
            this.rentalDetailsGroupBox.Text = "تفاصيل التأجير";
            // 
            // earlyDiscountValueLabel
            // 
            this.earlyDiscountValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.earlyDiscountValueLabel.AutoSize = true;
            this.earlyDiscountValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.earlyDiscountValueLabel.Location = new System.Drawing.Point(251, 172);
            this.earlyDiscountValueLabel.Name = "earlyDiscountValueLabel";
            this.earlyDiscountValueLabel.Size = new System.Drawing.Size(15, 20);
            this.earlyDiscountValueLabel.TabIndex = 30;
            this.earlyDiscountValueLabel.Text = "-";
            this.earlyDiscountValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lateFeeLabelValue
            // 
            this.lateFeeLabelValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lateFeeLabelValue.AutoSize = true;
            this.lateFeeLabelValue.ForeColor = System.Drawing.Color.Navy;
            this.lateFeeLabelValue.Location = new System.Drawing.Point(251, 145);
            this.lateFeeLabelValue.Name = "lateFeeLabelValue";
            this.lateFeeLabelValue.Size = new System.Drawing.Size(15, 20);
            this.lateFeeLabelValue.TabIndex = 29;
            this.lateFeeLabelValue.Text = "-";
            this.lateFeeLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // earlyDiscountLabel
            // 
            this.earlyDiscountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.earlyDiscountLabel.AutoSize = true;
            this.earlyDiscountLabel.ForeColor = System.Drawing.Color.Navy;
            this.earlyDiscountLabel.Location = new System.Drawing.Point(274, 172);
            this.earlyDiscountLabel.Name = "earlyDiscountLabel";
            this.earlyDiscountLabel.Size = new System.Drawing.Size(185, 20);
            this.earlyDiscountLabel.TabIndex = 28;
            this.earlyDiscountLabel.Text = "خصم الإعادة القبلية لكل يوم";
            this.earlyDiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lateFeeLabel
            // 
            this.lateFeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lateFeeLabel.AutoSize = true;
            this.lateFeeLabel.ForeColor = System.Drawing.Color.Navy;
            this.lateFeeLabel.Location = new System.Drawing.Point(274, 145);
            this.lateFeeLabel.Name = "lateFeeLabel";
            this.lateFeeLabel.Size = new System.Drawing.Size(139, 20);
            this.lateFeeLabel.TabIndex = 27;
            this.lateFeeLabel.Text = "غرامة التأخير لكل يوم";
            this.lateFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentalStatusValueLabel
            // 
            this.rentalStatusValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rentalStatusValueLabel.AutoSize = true;
            this.rentalStatusValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.rentalStatusValueLabel.Location = new System.Drawing.Point(251, 199);
            this.rentalStatusValueLabel.Name = "rentalStatusValueLabel";
            this.rentalStatusValueLabel.Size = new System.Drawing.Size(15, 20);
            this.rentalStatusValueLabel.TabIndex = 26;
            this.rentalStatusValueLabel.Text = "-";
            this.rentalStatusValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentalPeriodValueLabel
            // 
            this.rentalPeriodValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rentalPeriodValueLabel.AutoSize = true;
            this.rentalPeriodValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.rentalPeriodValueLabel.Location = new System.Drawing.Point(251, 91);
            this.rentalPeriodValueLabel.Name = "rentalPeriodValueLabel";
            this.rentalPeriodValueLabel.Size = new System.Drawing.Size(15, 20);
            this.rentalPeriodValueLabel.TabIndex = 25;
            this.rentalPeriodValueLabel.Text = "-";
            // 
            // estimatedPriceValueLabel
            // 
            this.estimatedPriceValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.estimatedPriceValueLabel.AutoSize = true;
            this.estimatedPriceValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.estimatedPriceValueLabel.Location = new System.Drawing.Point(251, 118);
            this.estimatedPriceValueLabel.Name = "estimatedPriceValueLabel";
            this.estimatedPriceValueLabel.Size = new System.Drawing.Size(15, 20);
            this.estimatedPriceValueLabel.TabIndex = 24;
            this.estimatedPriceValueLabel.Text = "-";
            this.estimatedPriceValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dropOffDateValueLabel
            // 
            this.dropOffDateValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropOffDateValueLabel.AutoSize = true;
            this.dropOffDateValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.dropOffDateValueLabel.Location = new System.Drawing.Point(251, 64);
            this.dropOffDateValueLabel.Name = "dropOffDateValueLabel";
            this.dropOffDateValueLabel.Size = new System.Drawing.Size(15, 20);
            this.dropOffDateValueLabel.TabIndex = 23;
            this.dropOffDateValueLabel.Text = "-";
            this.dropOffDateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pickupDateValueLabel
            // 
            this.pickupDateValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickupDateValueLabel.AutoSize = true;
            this.pickupDateValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.pickupDateValueLabel.Location = new System.Drawing.Point(251, 37);
            this.pickupDateValueLabel.Name = "pickupDateValueLabel";
            this.pickupDateValueLabel.Size = new System.Drawing.Size(15, 20);
            this.pickupDateValueLabel.TabIndex = 22;
            this.pickupDateValueLabel.Text = "-";
            this.pickupDateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentalPeriodLabel
            // 
            this.rentalPeriodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rentalPeriodLabel.AutoSize = true;
            this.rentalPeriodLabel.ForeColor = System.Drawing.Color.Navy;
            this.rentalPeriodLabel.Location = new System.Drawing.Point(274, 91);
            this.rentalPeriodLabel.Name = "rentalPeriodLabel";
            this.rentalPeriodLabel.Size = new System.Drawing.Size(76, 20);
            this.rentalPeriodLabel.TabIndex = 21;
            this.rentalPeriodLabel.Text = "مدة التأجير";
            this.rentalPeriodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rentalStatusLabel
            // 
            this.rentalStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rentalStatusLabel.AutoSize = true;
            this.rentalStatusLabel.ForeColor = System.Drawing.Color.Navy;
            this.rentalStatusLabel.Location = new System.Drawing.Point(274, 199);
            this.rentalStatusLabel.Name = "rentalStatusLabel";
            this.rentalStatusLabel.Size = new System.Drawing.Size(77, 20);
            this.rentalStatusLabel.TabIndex = 20;
            this.rentalStatusLabel.Text = "حالة التأجير";
            this.rentalStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // estimatedPriceLabel
            // 
            this.estimatedPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.estimatedPriceLabel.AutoSize = true;
            this.estimatedPriceLabel.ForeColor = System.Drawing.Color.Navy;
            this.estimatedPriceLabel.Location = new System.Drawing.Point(274, 118);
            this.estimatedPriceLabel.Name = "estimatedPriceLabel";
            this.estimatedPriceLabel.Size = new System.Drawing.Size(102, 20);
            this.estimatedPriceLabel.TabIndex = 19;
            this.estimatedPriceLabel.Text = "السعر التقريبي";
            this.estimatedPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dropoffDateLabel
            // 
            this.dropoffDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropoffDateLabel.AutoSize = true;
            this.dropoffDateLabel.ForeColor = System.Drawing.Color.Navy;
            this.dropoffDateLabel.Location = new System.Drawing.Point(274, 64);
            this.dropoffDateLabel.Name = "dropoffDateLabel";
            this.dropoffDateLabel.Size = new System.Drawing.Size(115, 20);
            this.dropoffDateLabel.TabIndex = 18;
            this.dropoffDateLabel.Text = "تاريخ نهاية التأجير";
            this.dropoffDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pickupDateLabel
            // 
            this.pickupDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickupDateLabel.AutoSize = true;
            this.pickupDateLabel.ForeColor = System.Drawing.Color.Navy;
            this.pickupDateLabel.Location = new System.Drawing.Point(274, 37);
            this.pickupDateLabel.Name = "pickupDateLabel";
            this.pickupDateLabel.Size = new System.Drawing.Size(115, 20);
            this.pickupDateLabel.TabIndex = 17;
            this.pickupDateLabel.Text = "تاريخ بداية التأجير";
            this.pickupDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carGroupBox
            // 
            this.carGroupBox.Controls.Add(this.featuresTextBox);
            this.carGroupBox.Controls.Add(this.featuresLabel);
            this.carGroupBox.Controls.Add(this.luggageNumberValue);
            this.carGroupBox.Controls.Add(this.peopleNumberValue);
            this.carGroupBox.Controls.Add(this.luggageNumberLabel);
            this.carGroupBox.Controls.Add(this.peopleNumberLabel);
            this.carGroupBox.Controls.Add(this.mileageValue);
            this.carGroupBox.Controls.Add(this.mileageLabel);
            this.carGroupBox.Controls.Add(this.pricePerDayValue);
            this.carGroupBox.Controls.Add(this.pricePerDayLabel);
            this.carGroupBox.Controls.Add(this.categoryValue);
            this.carGroupBox.Controls.Add(this.categoryLabel);
            this.carGroupBox.Controls.Add(this.registerationNumberValue);
            this.carGroupBox.Controls.Add(this.registerationNumberLabel);
            this.carGroupBox.Controls.Add(this.carLabel);
            this.carGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.carGroupBox.Location = new System.Drawing.Point(17, 9);
            this.carGroupBox.Name = "carGroupBox";
            this.carGroupBox.Size = new System.Drawing.Size(354, 412);
            this.carGroupBox.TabIndex = 21;
            this.carGroupBox.TabStop = false;
            this.carGroupBox.Text = "السيارة";
            // 
            // featuresTextBox
            // 
            this.featuresTextBox.BackColor = System.Drawing.Color.White;
            this.featuresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.featuresTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.featuresTextBox.ForeColor = System.Drawing.Color.Navy;
            this.featuresTextBox.Location = new System.Drawing.Point(17, 259);
            this.featuresTextBox.Multiline = true;
            this.featuresTextBox.Name = "featuresTextBox";
            this.featuresTextBox.ReadOnly = true;
            this.featuresTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.featuresTextBox.Size = new System.Drawing.Size(276, 130);
            this.featuresTextBox.TabIndex = 14;
            this.featuresTextBox.Text = "-";
            // 
            // featuresLabel
            // 
            this.featuresLabel.AutoSize = true;
            this.featuresLabel.Location = new System.Drawing.Point(209, 226);
            this.featuresLabel.Name = "featuresLabel";
            this.featuresLabel.Size = new System.Drawing.Size(55, 20);
            this.featuresLabel.TabIndex = 13;
            this.featuresLabel.Text = "الميزات";
            // 
            // luggageNumberValue
            // 
            this.luggageNumberValue.AutoSize = true;
            this.luggageNumberValue.Location = new System.Drawing.Point(185, 199);
            this.luggageNumberValue.Name = "luggageNumberValue";
            this.luggageNumberValue.Size = new System.Drawing.Size(15, 20);
            this.luggageNumberValue.TabIndex = 12;
            this.luggageNumberValue.Text = "-";
            // 
            // peopleNumberValue
            // 
            this.peopleNumberValue.AutoSize = true;
            this.peopleNumberValue.Location = new System.Drawing.Point(185, 172);
            this.peopleNumberValue.Name = "peopleNumberValue";
            this.peopleNumberValue.Size = new System.Drawing.Size(15, 20);
            this.peopleNumberValue.TabIndex = 11;
            this.peopleNumberValue.Text = "-";
            // 
            // luggageNumberLabel
            // 
            this.luggageNumberLabel.AutoSize = true;
            this.luggageNumberLabel.Location = new System.Drawing.Point(209, 199);
            this.luggageNumberLabel.Name = "luggageNumberLabel";
            this.luggageNumberLabel.Size = new System.Drawing.Size(87, 20);
            this.luggageNumberLabel.TabIndex = 10;
            this.luggageNumberLabel.Text = "عدد الحقائب";
            // 
            // peopleNumberLabel
            // 
            this.peopleNumberLabel.AutoSize = true;
            this.peopleNumberLabel.Location = new System.Drawing.Point(209, 172);
            this.peopleNumberLabel.Name = "peopleNumberLabel";
            this.peopleNumberLabel.Size = new System.Drawing.Size(97, 20);
            this.peopleNumberLabel.TabIndex = 9;
            this.peopleNumberLabel.Text = "عدد الأشخاص";
            // 
            // mileageValue
            // 
            this.mileageValue.AutoSize = true;
            this.mileageValue.Location = new System.Drawing.Point(185, 145);
            this.mileageValue.Name = "mileageValue";
            this.mileageValue.Size = new System.Drawing.Size(15, 20);
            this.mileageValue.TabIndex = 8;
            this.mileageValue.Text = "-";
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Location = new System.Drawing.Point(209, 145);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(102, 20);
            this.mileageLabel.TabIndex = 7;
            this.mileageLabel.Text = "المسافة بالميل";
            // 
            // pricePerDayValue
            // 
            this.pricePerDayValue.AutoSize = true;
            this.pricePerDayValue.Location = new System.Drawing.Point(185, 118);
            this.pricePerDayValue.Name = "pricePerDayValue";
            this.pricePerDayValue.Size = new System.Drawing.Size(15, 20);
            this.pricePerDayValue.TabIndex = 6;
            this.pricePerDayValue.Text = "-";
            // 
            // pricePerDayLabel
            // 
            this.pricePerDayLabel.AutoSize = true;
            this.pricePerDayLabel.Location = new System.Drawing.Point(209, 118);
            this.pricePerDayLabel.Name = "pricePerDayLabel";
            this.pricePerDayLabel.Size = new System.Drawing.Size(99, 20);
            this.pricePerDayLabel.TabIndex = 5;
            this.pricePerDayLabel.Text = "السعر لكل يوم";
            // 
            // categoryValue
            // 
            this.categoryValue.AutoSize = true;
            this.categoryValue.Location = new System.Drawing.Point(185, 91);
            this.categoryValue.Name = "categoryValue";
            this.categoryValue.Size = new System.Drawing.Size(15, 20);
            this.categoryValue.TabIndex = 4;
            this.categoryValue.Text = "-";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(209, 91);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(79, 20);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "نوع السيارة";
            // 
            // registerationNumberValue
            // 
            this.registerationNumberValue.AutoSize = true;
            this.registerationNumberValue.Location = new System.Drawing.Point(185, 64);
            this.registerationNumberValue.Name = "registerationNumberValue";
            this.registerationNumberValue.Size = new System.Drawing.Size(15, 20);
            this.registerationNumberValue.TabIndex = 2;
            this.registerationNumberValue.Text = "-";
            // 
            // registerationNumberLabel
            // 
            this.registerationNumberLabel.AutoSize = true;
            this.registerationNumberLabel.Location = new System.Drawing.Point(209, 64);
            this.registerationNumberLabel.Name = "registerationNumberLabel";
            this.registerationNumberLabel.Size = new System.Drawing.Size(79, 20);
            this.registerationNumberLabel.TabIndex = 1;
            this.registerationNumberLabel.Text = "رقم السيارة";
            // 
            // carLabel
            // 
            this.carLabel.AutoSize = true;
            this.carLabel.Location = new System.Drawing.Point(296, 37);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(15, 20);
            this.carLabel.TabIndex = 0;
            this.carLabel.Text = "-";
            // 
            // RentalDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(920, 520);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RentalDetailsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل التأجير";
            this.Load += new System.EventHandler(this.RentalDetailsForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.renterGroupBox.ResumeLayout(false);
            this.renterGroupBox.PerformLayout();
            this.rentalDetailsGroupBox.ResumeLayout(false);
            this.rentalDetailsGroupBox.PerformLayout();
            this.carGroupBox.ResumeLayout(false);
            this.carGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.GroupBox renterGroupBox;
        private System.Windows.Forms.Label emailValueLabel;
        private System.Windows.Forms.Label phoneNumberValueLabel;
        private System.Windows.Forms.Label licenseNumberValueLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label licenseNumberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox rentalDetailsGroupBox;
        private System.Windows.Forms.Label rentalStatusValueLabel;
        private System.Windows.Forms.Label rentalPeriodValueLabel;
        private System.Windows.Forms.Label estimatedPriceValueLabel;
        private System.Windows.Forms.Label dropOffDateValueLabel;
        private System.Windows.Forms.Label pickupDateValueLabel;
        private System.Windows.Forms.Label rentalPeriodLabel;
        private System.Windows.Forms.Label rentalStatusLabel;
        private System.Windows.Forms.Label estimatedPriceLabel;
        private System.Windows.Forms.Label dropoffDateLabel;
        private System.Windows.Forms.Label pickupDateLabel;
        private System.Windows.Forms.GroupBox carGroupBox;
        private System.Windows.Forms.TextBox featuresTextBox;
        private System.Windows.Forms.Label featuresLabel;
        private System.Windows.Forms.Label luggageNumberValue;
        private System.Windows.Forms.Label peopleNumberValue;
        private System.Windows.Forms.Label luggageNumberLabel;
        private System.Windows.Forms.Label peopleNumberLabel;
        private System.Windows.Forms.Label mileageValue;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label pricePerDayValue;
        private System.Windows.Forms.Label pricePerDayLabel;
        private System.Windows.Forms.Label categoryValue;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label registerationNumberValue;
        private System.Windows.Forms.Label registerationNumberLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label earlyDiscountValueLabel;
        private System.Windows.Forms.Label lateFeeLabelValue;
        private System.Windows.Forms.Label earlyDiscountLabel;
        private System.Windows.Forms.Label lateFeeLabel;
    }
}