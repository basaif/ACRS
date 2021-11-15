using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Models;
using ACRS.GuiClasses;

namespace ACRS.Forms
{
    public partial class CarDetailsForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        LayoutFunctions layout = new LayoutFunctions();

        CarModel car;

        public CarDetailsForm(CarModel model)
        {
            InitializeComponent();
            car = model;
            PopulateCarDetails();
        }

        private void PopulateCarDetails()
        {
            layout.PopulateCarDetails(carLabel, registerationNumberValue, categoryValue, pricePerDayValue, mileageValue,
                    peopleNumberValue, luggageNumberValue, statusValue, featuresTextBox, car);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.white_close_image_44x30;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close_image_44x30;
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void headerPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
