using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessLogic.Models;
using BusinessLogic.RentalClasses;
using ACRS.GuiClasses;


namespace ACRS.Forms
{
    public partial class AddNewCarForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        ValidateData ValidateData = new ValidateData();
        IDataPresenter data = new ManipulateModels();

        List<CarCategoryModel> categoriesList;
        List<CarFeatureModel> featuresList;
        List<CarFeatureModel> selectedFeaturesList = new List<CarFeatureModel>();

        ICarRequester callingForm;

        public AddNewCarForm(ICarRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            categoriesList = data.GetCarCategoryModels();
            featuresList = data.GetCarFeatureModels();

            WireUpCategoryLists();

            WireUpFeatureLists();
        }

        private void WireUpCategoryLists()
        {
            typeComboBox.DataSource = null;

            typeComboBox.DataSource = categoriesList;
            typeComboBox.DisplayMember = "CarCategoryName";

            
        }

        private void WireUpFeatureLists()
        {
            featuresComboBox.DataSource = null;

            featuresComboBox.DataSource = featuresList;
            featuresComboBox.DisplayMember = "CarFeatureName";

            featuresListBox.DataSource = null;

            featuresListBox.DataSource = selectedFeaturesList;
            featuresListBox.DisplayMember = "CarFeatureName";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.white_close_image_44x30;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.close_image_44x30;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void saveCategoryButton_Click(object sender, EventArgs e)
        {
            if (ValidateCategory())
            {
                CarCategoryModel carCategory = data.CreateCategoryModel(categoryNameValue.Text,
                    peopleNumberValue.Text, luggageNumberValue.Text);
                categoriesList.Add(carCategory);

                WireUpCategoryLists();

                typeComboBox.SelectedItem = carCategory;

                categoryNameValue.Text = "";
                peopleNumberValue.Text = "";
                luggageNumberValue.Text = "";
            }
        }

        private bool ValidateCategory()
        {
            bool output = true;
            string errorMessage = "";

            if (!ValidateData.IsNameValid(categoryNameValue.Text))
            {
                output = false;
                errorMessage += "اسم النوع الذي أدخلته يحتوي على رموز غير مقبولة";
                errorMessage += "\n";
            }

            if (!ValidateData.IsInteger(peopleNumberValue.Text))
            {
                output = false;
                errorMessage += "عدد الركاب الذي أدخلته ليس عدد صحيح";
                errorMessage += "\n";
            }

            if (!ValidateData.IsInteger(luggageNumberValue.Text))
            {
                output = false;
                errorMessage += "عدد الحقائب الذي أدخلته ليس عدد صحيح";
                errorMessage += "\n";
            }

            if (!output)
            {
                string messageTitle = "بيانات خاطئة";
                errorMessage += "أعد الإدخال من جديد";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Stop;

                MessageBox.Show(errorMessage, messageTitle, button, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            return output;
        }

        private void DetermineCategorySaveButtonState()
        {
            saveCategoryButton.Enabled = false;
            bool emptyData = string.IsNullOrEmpty(categoryNameValue.Text) || string.IsNullOrEmpty(peopleNumberValue.Text) || string.IsNullOrEmpty(luggageNumberValue.Text);
            if (!emptyData)
            {
                saveCategoryButton.Enabled = true;
            }
        }

        private void categoryNameValue_TextChanged(object sender, EventArgs e)
        {
            DetermineCategorySaveButtonState();
        }

        private void saveFeatureButton_Click(object sender, EventArgs e)
        {
            if (ValidateFeature())
            {
                
                selectedFeaturesList.Add(data.CreateFeatureModel(featureNameValue.Text));

                WireUpFeatureLists();

                featureNameValue.Text = "";
            }
        }

        private void DetermineFeatureSaveButtonState()
        {
            saveFeatureButton.Enabled = false;
            bool emptyData = string.IsNullOrEmpty(featureNameValue.Text);
            if (!emptyData)
            {
                saveFeatureButton.Enabled = true;
            }
        }

        private bool ValidateFeature()
        {
            bool output = true;
            string errorMessage = "";

            if (!ValidateData.IsNameValid(featureNameValue.Text))
            {
                output = false;
                errorMessage += "اسم الميزة الذي أدخلته يحتوي على رموز غير مقبولة";
                errorMessage += "\n";
            }
            if (!output)
            {
                string messageTitle = "بيانات خاطئة";
                errorMessage += "أعد الإدخال من جديد";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Stop;

                MessageBox.Show(errorMessage, messageTitle, button, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            return output;
        }

        private void featureNameValue_TextChanged(object sender, EventArgs e)
        {
            DetermineFeatureSaveButtonState();
        }

        private void addFeatureButton_Click(object sender, EventArgs e)
        {
            CarFeatureModel f = (CarFeatureModel)featuresComboBox.SelectedItem;
            if (f != null)
            {
                featuresList.Remove(f);
                selectedFeaturesList.Add(f);

                WireUpFeatureLists();
            }
        }

        private void removeFeatureButton_Click(object sender, EventArgs e)
        {
            CarFeatureModel f = (CarFeatureModel)featuresListBox.SelectedItem;
            if (f != null)
            {
                selectedFeaturesList.Remove(f);
                featuresList.Add(f);

                WireUpFeatureLists();
            }
        }

        private void featuresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarFeatureModel f = (CarFeatureModel)featuresComboBox.SelectedItem;
            if (f != null)
            {
                addFeatureButton.Enabled = true;
            }
            else
            {
                addFeatureButton.Enabled = false;
            }
            DetermineCarSaveButtonState();
        }

        private void featuresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarFeatureModel f = (CarFeatureModel)featuresListBox.SelectedItem;
            if (f != null)
            {
                removeFeatureButton.Enabled = true;
            }
            else
            {
                removeFeatureButton.Enabled = false;
            }
            DetermineCarSaveButtonState();
        }

        private void saveCarButton_Click(object sender, EventArgs e)
        {
            if (ValidateCar())
            {
                CarModel c = data.CreateCarModel(registerationNumberValue.Text, yearValue.Text, makeValue.Text, modelValue.Text,
                    pricePerDayValue.Text, mileageValue.Text, (CarCategoryModel)typeComboBox.SelectedItem, selectedFeaturesList);

                callingForm.CarComplete(c);

                Close();
            }
        }

        private void DetermineCarSaveButtonState()
        {
            saveCarButton.Enabled = false;
            bool emptyData = string.IsNullOrEmpty(registerationNumberValue.Text) || string.IsNullOrEmpty(makeValue.Text) || string.IsNullOrEmpty(yearValue.Text)
                || string.IsNullOrEmpty(modelValue.Text) || string.IsNullOrEmpty(pricePerDayValue.Text) || string.IsNullOrEmpty(mileageValue.Text)
                || typeComboBox.SelectedItem == null || selectedFeaturesList.Count == 0;

            if (!emptyData)
            {
                saveCarButton.Enabled = true;
            }
        }

        private bool ValidateCar()
        {
            bool output = true;
            string errorMessage = "";

            if (!ValidateData.IsAlphanumeric(registerationNumberValue.Text))
            {
                output = false;
                errorMessage += "رقم السيارة الذي أدخلته غير صحيح";
                errorMessage += "\n";
            }
            if (!ValidateData.IsYear(yearValue.Text))
            {
                output = false;
                errorMessage += "السنة التي أدخلتها غير صحيحة";
                errorMessage += "\n";
            }
            if (!ValidateData.IsNameValid(makeValue.Text))
            {
                output = false;
                errorMessage += "اسم الشركة الذي أدخلته يحتوي على رموز غير مقبولة";
                errorMessage += "\n";
            }
            if (!ValidateData.IsNameValid(modelValue.Text))
            {
                output = false;
                errorMessage += "اسم الموديل الذي أدخلته يحتوي على رموز غير مقبولة";
                errorMessage += "\n";
            }
            if (!ValidateData.IsDecimal(pricePerDayValue.Text))
            {
                output = false;
                errorMessage += "السعر الذي أدخلته غير صحيح";
                errorMessage += "\n";
            }
            else if (!ValidateData.IsPriceValid(pricePerDayValue.Text))
            {
                output = false;
                errorMessage += "يجب أن يكون السعر 100$ أو أكثر";
                errorMessage += "\n";
            }

            if (!ValidateData.IsInteger(mileageValue.Text))
            {
                output = false;
                errorMessage += "المسافة التي أدخلتها غير صحيحة";
                errorMessage += "\n";
            }
            if (typeComboBox.SelectedItem == null)
            {
                output = false;
                errorMessage += "يجب أن تختار نوع السيارة";
                errorMessage += "\n";
            }
            if (selectedFeaturesList.Count == 0)
            {
                output = false;
                errorMessage += "يجب أن تختار ميزة واحدة على الأقل";
                errorMessage += "\n";
            }
            if (!output)
            {
                string messageTitle = "بيانات خاطئة";
                errorMessage += "أعد الإدخال من جديد";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Stop;

                MessageBox.Show(errorMessage, messageTitle, button, icon, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

            return output;
        }

        private void registerationNumberValue_TextChanged(object sender, EventArgs e)
        {
            DetermineCarSaveButtonState();
        }
    }
}
