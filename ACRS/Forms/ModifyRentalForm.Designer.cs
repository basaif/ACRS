namespace ACRS.Forms
{
    partial class ModifyRentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyRentalForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.earlyDollarSignLabel = new System.Windows.Forms.Label();
            this.lateDollarSignLabel = new System.Windows.Forms.Label();
            this.earlyDiscountValue = new System.Windows.Forms.TextBox();
            this.lateFeeValue = new System.Windows.Forms.TextBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.renterComboBox = new System.Windows.Forms.ComboBox();
            this.earlyDiscountLabel = new System.Windows.Forms.Label();
            this.lateFeeLabel = new System.Windows.Forms.Label();
            this.carLabel = new System.Windows.Forms.Label();
            this.renterLabel = new System.Windows.Forms.Label();
            this.dropOffDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pickupDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dropOffDateLabel = new System.Windows.Forms.Label();
            this.prickupDateLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.contentPanel.SuspendLayout();
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
            this.headerPanel.Size = new System.Drawing.Size(600, 40);
            this.headerPanel.TabIndex = 3;
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
            this.headerLabel.Location = new System.Drawing.Point(470, 14);
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
            this.iconPictureBox.Location = new System.Drawing.Point(549, 0);
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
            this.contentPanel.Controls.Add(this.saveButton);
            this.contentPanel.Controls.Add(this.earlyDollarSignLabel);
            this.contentPanel.Controls.Add(this.lateDollarSignLabel);
            this.contentPanel.Controls.Add(this.earlyDiscountValue);
            this.contentPanel.Controls.Add(this.lateFeeValue);
            this.contentPanel.Controls.Add(this.carComboBox);
            this.contentPanel.Controls.Add(this.renterComboBox);
            this.contentPanel.Controls.Add(this.earlyDiscountLabel);
            this.contentPanel.Controls.Add(this.lateFeeLabel);
            this.contentPanel.Controls.Add(this.carLabel);
            this.contentPanel.Controls.Add(this.renterLabel);
            this.contentPanel.Controls.Add(this.dropOffDateTimePicker);
            this.contentPanel.Controls.Add(this.pickupDateTimePicker);
            this.contentPanel.Controls.Add(this.dropOffDateLabel);
            this.contentPanel.Controls.Add(this.prickupDateLabel);
            this.contentPanel.Controls.Add(this.titleLabel);
            this.contentPanel.Location = new System.Drawing.Point(20, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(560, 400);
            this.contentPanel.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Green;
            this.saveButton.Image = global::ACRS.Properties.Resources.save_image_30x30;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(36, 331);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveButton.Size = new System.Drawing.Size(148, 50);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "حفظ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // earlyDollarSignLabel
            // 
            this.earlyDollarSignLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.earlyDollarSignLabel.AutoSize = true;
            this.earlyDollarSignLabel.ForeColor = System.Drawing.Color.Navy;
            this.earlyDollarSignLabel.Location = new System.Drawing.Point(187, 265);
            this.earlyDollarSignLabel.Name = "earlyDollarSignLabel";
            this.earlyDollarSignLabel.Size = new System.Drawing.Size(17, 20);
            this.earlyDollarSignLabel.TabIndex = 20;
            this.earlyDollarSignLabel.Text = "$";
            this.earlyDollarSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lateDollarSignLabel
            // 
            this.lateDollarSignLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lateDollarSignLabel.AutoSize = true;
            this.lateDollarSignLabel.ForeColor = System.Drawing.Color.Navy;
            this.lateDollarSignLabel.Location = new System.Drawing.Point(189, 229);
            this.lateDollarSignLabel.Name = "lateDollarSignLabel";
            this.lateDollarSignLabel.Size = new System.Drawing.Size(17, 20);
            this.lateDollarSignLabel.TabIndex = 19;
            this.lateDollarSignLabel.Text = "$";
            this.lateDollarSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // earlyDiscountValue
            // 
            this.earlyDiscountValue.Location = new System.Drawing.Point(212, 262);
            this.earlyDiscountValue.Name = "earlyDiscountValue";
            this.earlyDiscountValue.Size = new System.Drawing.Size(100, 27);
            this.earlyDiscountValue.TabIndex = 18;
            this.earlyDiscountValue.TextChanged += new System.EventHandler(this.lateFeeValue_TextChanged);
            // 
            // lateFeeValue
            // 
            this.lateFeeValue.Location = new System.Drawing.Point(212, 226);
            this.lateFeeValue.Name = "lateFeeValue";
            this.lateFeeValue.Size = new System.Drawing.Size(100, 27);
            this.lateFeeValue.TabIndex = 17;
            this.lateFeeValue.TextChanged += new System.EventHandler(this.lateFeeValue_TextChanged);
            // 
            // carComboBox
            // 
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Location = new System.Drawing.Point(45, 183);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(268, 28);
            this.carComboBox.TabIndex = 16;
            this.carComboBox.SelectedIndexChanged += new System.EventHandler(this.lateFeeValue_TextChanged);
            // 
            // renterComboBox
            // 
            this.renterComboBox.FormattingEnabled = true;
            this.renterComboBox.Location = new System.Drawing.Point(45, 142);
            this.renterComboBox.Name = "renterComboBox";
            this.renterComboBox.Size = new System.Drawing.Size(268, 28);
            this.renterComboBox.TabIndex = 15;
            this.renterComboBox.SelectedIndexChanged += new System.EventHandler(this.lateFeeValue_TextChanged);
            // 
            // earlyDiscountLabel
            // 
            this.earlyDiscountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.earlyDiscountLabel.AutoSize = true;
            this.earlyDiscountLabel.ForeColor = System.Drawing.Color.Navy;
            this.earlyDiscountLabel.Location = new System.Drawing.Point(331, 269);
            this.earlyDiscountLabel.Name = "earlyDiscountLabel";
            this.earlyDiscountLabel.Size = new System.Drawing.Size(185, 20);
            this.earlyDiscountLabel.TabIndex = 14;
            this.earlyDiscountLabel.Text = "خصم الإعادة القبلية لكل يوم";
            this.earlyDiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lateFeeLabel
            // 
            this.lateFeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lateFeeLabel.AutoSize = true;
            this.lateFeeLabel.ForeColor = System.Drawing.Color.Navy;
            this.lateFeeLabel.Location = new System.Drawing.Point(331, 227);
            this.lateFeeLabel.Name = "lateFeeLabel";
            this.lateFeeLabel.Size = new System.Drawing.Size(139, 20);
            this.lateFeeLabel.TabIndex = 13;
            this.lateFeeLabel.Text = "غرامة التأخير لكل يوم";
            this.lateFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carLabel
            // 
            this.carLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.carLabel.AutoSize = true;
            this.carLabel.ForeColor = System.Drawing.Color.Navy;
            this.carLabel.Location = new System.Drawing.Point(331, 186);
            this.carLabel.Name = "carLabel";
            this.carLabel.Size = new System.Drawing.Size(53, 20);
            this.carLabel.TabIndex = 12;
            this.carLabel.Text = "السيارة";
            this.carLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // renterLabel
            // 
            this.renterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renterLabel.AutoSize = true;
            this.renterLabel.ForeColor = System.Drawing.Color.Navy;
            this.renterLabel.Location = new System.Drawing.Point(331, 144);
            this.renterLabel.Name = "renterLabel";
            this.renterLabel.Size = new System.Drawing.Size(64, 20);
            this.renterLabel.TabIndex = 11;
            this.renterLabel.Text = "المستأجر";
            this.renterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dropOffDateTimePicker
            // 
            this.dropOffDateTimePicker.Location = new System.Drawing.Point(45, 93);
            this.dropOffDateTimePicker.Name = "dropOffDateTimePicker";
            this.dropOffDateTimePicker.Size = new System.Drawing.Size(269, 27);
            this.dropOffDateTimePicker.TabIndex = 10;
            this.dropOffDateTimePicker.ValueChanged += new System.EventHandler(this.lateFeeValue_TextChanged);
            // 
            // pickupDateTimePicker
            // 
            this.pickupDateTimePicker.Location = new System.Drawing.Point(45, 50);
            this.pickupDateTimePicker.Name = "pickupDateTimePicker";
            this.pickupDateTimePicker.Size = new System.Drawing.Size(269, 27);
            this.pickupDateTimePicker.TabIndex = 9;
            this.pickupDateTimePicker.ValueChanged += new System.EventHandler(this.lateFeeValue_TextChanged);
            // 
            // dropOffDateLabel
            // 
            this.dropOffDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropOffDateLabel.AutoSize = true;
            this.dropOffDateLabel.ForeColor = System.Drawing.Color.Navy;
            this.dropOffDateLabel.Location = new System.Drawing.Point(331, 98);
            this.dropOffDateLabel.Name = "dropOffDateLabel";
            this.dropOffDateLabel.Size = new System.Drawing.Size(115, 20);
            this.dropOffDateLabel.TabIndex = 8;
            this.dropOffDateLabel.Text = "تاريخ نهاية التأجير";
            this.dropOffDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prickupDateLabel
            // 
            this.prickupDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prickupDateLabel.AutoSize = true;
            this.prickupDateLabel.ForeColor = System.Drawing.Color.Navy;
            this.prickupDateLabel.Location = new System.Drawing.Point(331, 55);
            this.prickupDateLabel.Name = "prickupDateLabel";
            this.prickupDateLabel.Size = new System.Drawing.Size(115, 20);
            this.prickupDateLabel.TabIndex = 7;
            this.prickupDateLabel.Text = "تاريخ بداية التأجير";
            this.prickupDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Navy;
            this.titleLabel.Location = new System.Drawing.Point(390, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(160, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "تعديل بيانات التأجير";
            // 
            // ModifyRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyRentalForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات التأجير";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label dropOffDateLabel;
        private System.Windows.Forms.Label prickupDateLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label earlyDollarSignLabel;
        private System.Windows.Forms.Label lateDollarSignLabel;
        private System.Windows.Forms.TextBox earlyDiscountValue;
        private System.Windows.Forms.TextBox lateFeeValue;
        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.ComboBox renterComboBox;
        private System.Windows.Forms.Label earlyDiscountLabel;
        private System.Windows.Forms.Label lateFeeLabel;
        private System.Windows.Forms.Label carLabel;
        private System.Windows.Forms.Label renterLabel;
        private System.Windows.Forms.DateTimePicker dropOffDateTimePicker;
        private System.Windows.Forms.DateTimePicker pickupDateTimePicker;
        private System.Windows.Forms.Button saveButton;
    }
}