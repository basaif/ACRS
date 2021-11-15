using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Models;
using BusinessLogic.RentalClasses;
using ACRS.GuiClasses;

namespace ACRS.Forms
{
    public partial class MainForm : Form, ICustomerRequester, ICarRequester, IRentalRequester
    {
        private bool mouseDown;
        private Point lastLocation;

        private int activeTab = 1;

        IDataPresenter data = new ManipulateModels();

        List<RentalModel> rentalsList;
        List<RentalModel> activeRentalsList;
        List<RentalModel> lateRentalsList;
        List<RentalModel> newRentalsList;
        List<RentalModel> returnedRentalList;

        List<CustomerModel> customersList;
        List<CarModel> carsList;

        public MainForm()
        {
            InitializeComponent();

            InitilizeLists();

            WireUpRentalsLists(activeTab);
            WireUpCarsList();
            WireUpCustomersList();

        }

        private void InitilizeLists()
        {
            rentalsList = data.GetRentalModels();
            customersList = data.GetNotObsoleteCustomerModels();
            carsList = data.GetNotObsoleteCarModels();
            

            activeRentalsList = rentalsList.Where(x => x.Status.Equals("Active")).ToList();
            lateRentalsList = rentalsList.Where(x => x.Status.Equals("Late")).ToList();
            newRentalsList = rentalsList.Where(x => x.Status.Equals("New")).ToList();
            returnedRentalList = rentalsList.Where(x => x.Status.Equals("Returned")).ToList();
        }

        private void WireUpRentalsLists(int tab)
        {
            List<RentalModel> list = new List<RentalModel>();

            if (tab == 1)
            {
                list = activeRentalsList;
            }
            else if (tab == 2)
            {
                list = lateRentalsList;
            }
            else if (tab == 3)
            {
                list = newRentalsList;
            }
            else if (tab == 4)
            {
                list = returnedRentalList;
            }
            

            rentalsListBox.DataSource = null;

            rentalsListBox.DataSource = list;
            rentalsListBox.DisplayMember = "DisplayName";

        }

        private void WireUpCustomersList()
        {
            customersListBox.DataSource = null;

            customersListBox.DataSource = customersList;
            customersListBox.DisplayMember = "FullName";
        }

        private void WireUpCarsList()
        {
            carsListBox.DataSource = null;

            carsListBox.DataSource = carsList;
            carsListBox.DisplayMember = "CarName";
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.white_close_image_44x30;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close_image_44x30;
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.white_close_image_44x30;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void activeRentalsButton_Click(object sender, EventArgs e)
        {
            activeTab = 1;
            WireUpRentalsLists(activeTab);

            activeRentalsButton.BackColor = Color.White;
            lateRentalsButton.BackColor = Color.Gainsboro;
            newRentalsButton.BackColor = Color.Gainsboro;
            returnedRentalsButton.BackColor = Color.Gainsboro;

            
            rentalListsPanel.Visible = true;

            returnRentalsButton.Visible = true;
            rentalsModifyButton.Visible = false;
            rentalsCancelButton.Visible = false;
            refreshButton.Visible = true;

        }

        private void lateRentalsButton_Click(object sender, EventArgs e)
        {
            activeTab = 2;
            WireUpRentalsLists(activeTab);

            activeRentalsButton.BackColor = Color.Gainsboro;
            lateRentalsButton.BackColor = Color.White;
            newRentalsButton.BackColor = Color.Gainsboro;
            returnedRentalsButton.BackColor = Color.Gainsboro;

            
            rentalListsPanel.Visible = true;

            returnRentalsButton.Visible = true;
            rentalsModifyButton.Visible = false;
            rentalsCancelButton.Visible = false;
            refreshButton.Visible = true;
        }

        private void newRentalsButton_Click(object sender, EventArgs e)
        {
            activeTab = 3;
            WireUpRentalsLists(activeTab);

            activeRentalsButton.BackColor = Color.Gainsboro;
            lateRentalsButton.BackColor = Color.Gainsboro;
            newRentalsButton.BackColor = Color.White;
            returnedRentalsButton.BackColor = Color.Gainsboro;

            
            rentalListsPanel.Visible = true;

            returnRentalsButton.Visible = false;
            rentalsModifyButton.Visible = true;
            rentalsCancelButton.Visible = true;
            refreshButton.Visible = true;
        }

        private void returnedRentalsButton_Click(object sender, EventArgs e)
        {
            activeTab = 4;
            WireUpRentalsLists(activeTab);

            activeRentalsButton.BackColor = Color.Gainsboro;
            lateRentalsButton.BackColor = Color.Gainsboro;
            newRentalsButton.BackColor = Color.Gainsboro;
            returnedRentalsButton.BackColor = Color.White;

            rentalListsPanel.Visible = true;

            returnRentalsButton.Visible = false;
            rentalsModifyButton.Visible = false;
            rentalsCancelButton.Visible = false;
            refreshButton.Visible = true;
        }

        private void rentalsButton_Click(object sender, EventArgs e)
        {
            rentalsButton.BackColor = Color.FromArgb(106, 134, 232);
            carsButton.BackColor = Color.FromArgb(53, 60, 234);
            customersButton.BackColor = Color.FromArgb(53, 60, 234);

            rentalsPanel.Visible = true;
            carsPanel.Visible = false;
            customersPanel.Visible = false;

            titleLabel.Text = "إدارة المستأجرات";
            titleLabel.Location = new Point(512, 18);

            RentalListsRefresh();
        }

        private void carsButton_Click(object sender, EventArgs e)
        {
            rentalsButton.BackColor = Color.FromArgb(53, 60, 234);
            carsButton.BackColor = Color.FromArgb(106, 134, 232);
            customersButton.BackColor = Color.FromArgb(53, 60, 234);

            rentalsPanel.Visible = false;
            carsPanel.Visible = true;
            customersPanel.Visible = false;

            titleLabel.Text = "السيارات";
            titleLabel.Location = new Point(573, 18);

            InitilizeLists();
            WireUpCarsList();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            rentalsButton.BackColor = Color.FromArgb(53, 60, 234);
            carsButton.BackColor = Color.FromArgb(53, 60, 234);
            customersButton.BackColor = Color.FromArgb(106, 134, 232);

            rentalsPanel.Visible = false;
            carsPanel.Visible = false;
            customersPanel.Visible = true;

            titleLabel.Text = "الزبائن";
            titleLabel.Location = new Point(590, 18);

            InitilizeLists();
            WireUpCarsList();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddNewCustomerForm addNewCustomerForm = new AddNewCustomerForm(this);
            addNewCustomerForm.Show();
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

        private void rentalDetailsButton_Click(object sender, EventArgs e)
        {
            RentalModel selectedRental = (RentalModel)rentalsListBox.SelectedItem;
            RentalDetailsForm rentalDetailsForm = new RentalDetailsForm(selectedRental);
            rentalDetailsForm.Show();
        }

        private void rentalsModifyButton_Click(object sender, EventArgs e)
        {
            RentalModel selectedRental = (RentalModel)rentalsListBox.SelectedItem;
            ModifyRentalForm modifyRentalForm = new ModifyRentalForm(selectedRental);
            modifyRentalForm.Show();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            AddNewCarForm addNewCarForm = new AddNewCarForm(this);
            addNewCarForm.Show();
        }

        private void addRentalButton_Click(object sender, EventArgs e)
        {
            RentACarForm rentACarForm = new RentACarForm(this);
            rentACarForm.Show();
        }

        public void CustomerComplete(CustomerModel model)
        {
            customersList.Add(model);
            WireUpCustomersList();

            customersListBox.SelectedItem = model;

        }

        public void CarComplete(CarModel model)
        {
            carsList.Add(model);
            WireUpCarsList();

            carsListBox.SelectedItem = model;

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RentalListsRefresh();
        }

        private void RentalListsRefresh()
        {
            rentalsList = data.GetRentalModels();
            InitilizeLists();
            WireUpRentalsLists(activeTab);
        }

        public void RentalComplete(RentalModel model)
        {
            rentalsList.Add(model);

            WireUpRentalsLists(activeTab);
            RentalListsRefresh();
        }

        private void rentalsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rentalsListBox.SelectedItem != null)
            {
                rentalDetailsButton.Enabled = true;
                rentalsModifyButton.Enabled = true;
                returnRentalsButton.Enabled = true;
                rentalsCancelButton.Enabled = true;
            }
            else
            {
                rentalDetailsButton.Enabled = false;
                rentalsModifyButton.Enabled = false;
                returnRentalsButton.Enabled = false;
                rentalsCancelButton.Enabled = false;
            }
        }

        private void returnRentalsButton_Click(object sender, EventArgs e)
        {
            ReturnForm returnForm = new ReturnForm((RentalModel)rentalsListBox.SelectedItem);
            returnForm.Show();
            
        }

        private void rentalsCancelButton_Click(object sender, EventArgs e)
        {
            string message = "هل أنت متأكد أنك تريد إلغاء هذا الإيجار؟";
            message += "\n";
            message += "لا يمكنك التراجع عن هذا الفعل";
            string title = "إلغاء الإيجار؟";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, title, buttons, icon, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
            {
                data.DeleteRental((RentalModel)rentalsListBox.SelectedItem);
            }
        }

        private void DetermineCarButtonsState()
        {
            carsDetailsButton.Enabled = false;
            carsModifyButton.Enabled = false;
            carsDeleteButton.Enabled = false;

            if (carsListBox.SelectedItem != null)
            {
                carsDetailsButton.Enabled = true;
                carsModifyButton.Enabled = true;
                carsDeleteButton.Enabled = true;
            }
        }

        private void DetermineCustomerButtonsState()
        {
            customerDetailsButton.Enabled = false;
            customerModifyButton.Enabled = false;
            customersDeleteButton.Enabled = false;

            if (carsListBox.SelectedItem != null)
            {
                customerDetailsButton.Enabled = true;
                customerModifyButton.Enabled = true;
                customersDeleteButton.Enabled = true;
            }
        }

        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetermineCustomerButtonsState();
        }

        private void carsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetermineCarButtonsState();
        }

        private void customersRefreshButton_Click(object sender, EventArgs e)
        {
            InitilizeLists();
            WireUpCustomersList();
        }

        private void carsRefreshButton_Click(object sender, EventArgs e)
        {
            InitilizeLists();
            WireUpCarsList();
        }

        private void customerDetailsButton_Click(object sender, EventArgs e)
        {
            CustomerModel selectedCustomer = (CustomerModel)customersListBox.SelectedItem;
            CustomerDetailsForm customerDetailsForm = new CustomerDetailsForm(selectedCustomer);
            customerDetailsForm.Show();
        }

        private void carsDetailsButton_Click(object sender, EventArgs e)
        {
            CarModel selectedCar = (CarModel)carsListBox.SelectedItem;
            CarDetailsForm carDetailsForm = new CarDetailsForm(selectedCar);
            carDetailsForm.Show();
        }

        private void customerModifyButton_Click(object sender, EventArgs e)
        {
            CustomerModel selectedCustomer = (CustomerModel)customersListBox.SelectedItem;
            CustomerModifyForm customerModifyForm = new CustomerModifyForm(selectedCustomer);
            customerModifyForm.Show();
        }

        private void customersDeleteButton_Click(object sender, EventArgs e)
        {
            string message = "هل أنت متأكد أنك تريد حذف هذا الزبون؟";
            message += "\n";
            message += "لا يمكنك التراجع عن هذا الفعل";
            string title = "حذف الزبون؟";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, title, buttons, icon, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
            {
                CustomerModel selectedCustomer = (CustomerModel)customersListBox.SelectedItem;
                if (selectedCustomer.Status.Equals("Not Renting"))
                {
                    data.DeleteCustomer(selectedCustomer);
                }
                else
                {
                    string messageTitle = "فشل الحذف";
                    string errorMessage = "لا يمكنك حذف زبون مستأجر حالياً";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon errorIcon = MessageBoxIcon.Stop;

                    MessageBox.Show(errorMessage, messageTitle, button, errorIcon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                
            }
        }

        private void carsDeleteButton_Click(object sender, EventArgs e)
        {
            string message = "هل أنت متأكد أنك تريد حذف هذه السيارة؟";
            message += "\n";
            message += "لا يمكنك التراجع عن هذا الفعل";
            string title = "حذف السيارة؟";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, title, buttons, icon, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
            {
                CarModel selectedCar = (CarModel)carsListBox.SelectedItem;

                if (selectedCar.Status.Equals("Available"))
                {
                    data.DeleteCar(selectedCar);
                }

                else
                {
                    string messageTitle = "فشل الحذف";
                    string errorMessage = "لا يمكنك حذف سيارة مستأجرة حالياً";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon errorIcon = MessageBoxIcon.Stop;

                    MessageBox.Show(errorMessage, messageTitle, button, errorIcon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                
            }
        }

        private void carsModifyButton_Click(object sender, EventArgs e)
        {
            CarModel selectedCar = (CarModel)carsListBox.SelectedItem;
            CarModifyForm carModifyForm = new CarModifyForm(selectedCar);
            carModifyForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RentalListsRefresh();
        }
    }
}
