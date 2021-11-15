using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;
using BusinessLogic.RentalClasses;

namespace ACRS.GuiClasses
{
    public class ManipulateModels : IDataPresenter
    {

        private static IDataAccess Connection { get; set; } = Program.connection;

        public CustomerModel CreateCustomerModel(string fname, string lname, string licenseNo, string phoneNo, string email)
        {
            CustomerModel customer = new CustomerModel
            {
                FirstName = fname,
                LastName = lname,
                LicenseNumber = licenseNo,
                PhoneNumber = phoneNo,
                EmailAddress = email,
                Status = "Not Renting"
            };

            Connection.SaveCustomer(customer);

            return customer;
        }

        public CarCategoryModel CreateCategoryModel(string name, string peopleNumber, string luggageNumber)
        {
            CarCategoryModel category = new CarCategoryModel
            {
                CarCategoryName = name,
                PeopleNumber = int.Parse(peopleNumber),
                LuggageNumber = int.Parse(luggageNumber)
            };

            Connection.SaveCategory(category);

            return category;
        }

        public CarFeatureModel CreateFeatureModel(string name)
        {
            CarFeatureModel feature = new CarFeatureModel
            {
                CarFeatureName = name
            };

            Connection.SaveFeature(feature);

            return feature;
        }

        public CarModel CreateCarModel(string registerationNo, string year, string make, string model, string price, string mileage, CarCategoryModel type, List<CarFeatureModel> features)
        {
            CarModel car = new CarModel
            {
                RegisterationNumber = registerationNo,
                Year = year,
                Make = make,
                Model = model,
                PricePerDay = decimal.Parse(price),
                Mileage = int.Parse(mileage),
                Category = type,
                Features = features,
                Status = "Available"
            };

            Connection.SaveCar(car);

            return car;
        }

        public RentalModel CreateRentalModel(DateTime startDate, DateTime endDate, string lateFee, string earlyDiscount, CustomerModel renter, CarModel car)
        {
            RentalLogic logic = new RentalLogic();
            string status = "New";
            if (Math.Floor(startDate.Subtract(DateTime.Today).TotalDays) <= 0)
            {
                status = "Active";
            }
            if (Math.Floor(startDate.Subtract(DateTime.Today).TotalDays) > 0)
            {
                status = "New";
            }
            RentalModel rental = new RentalModel
            {
                PickupDate = startDate,
                DropoffDate = endDate,
                EstimatedPrice = logic.EstimatePrice(Math.Ceiling(endDate.Subtract(startDate).TotalDays), car.PricePerDay),
                Status = status,
                LateFeePerDay = decimal.Parse(lateFee),
                EarlyDiscountPerDay = decimal.Parse(earlyDiscount),
                Renter = renter,
                RentedCar = car
            };

            Connection.SaveRental(rental);

            return rental;
        }
        

        public void ReturnRental(RentalModel rentalModel, DateTime returnDate, int newMileage)
        {
            Connection.RentalStatus_Update(rentalModel, '3');
            Connection.RentalActualDropoffDate_Update(rentalModel, returnDate);

            Connection.CarStaus_Update(rentalModel.RentedCar, '1');

            
            Connection.CarMileage_Update(rentalModel.RentedCar, newMileage);

            Connection.CustomerStaus_Update(rentalModel.Renter, '0');

            
        }

        public void UpdateRentalModel(RentalModel oldModel, DateTime newStartDate, DateTime newEndDate, CustomerModel newCustomer, CarModel newCar, string newLateFee, string newEarlyDiscount)
        {
            RentalLogic logic = new RentalLogic();
            Connection.CarStaus_Update(oldModel.RentedCar, '1');
            oldModel.RentedCar.Status = "Available";
            Connection.CustomerStaus_Update(oldModel.Renter, '0');
            oldModel.RentedCar.Status = "Not Renting";

            oldModel.PickupDate = newStartDate;
            oldModel.DropoffDate = newEndDate;
            oldModel.Renter = newCustomer;
            oldModel.RentedCar = newCar;
            oldModel.LateFeePerDay = decimal.Parse(newLateFee);
            oldModel.EarlyDiscountPerDay = decimal.Parse(newEarlyDiscount);
            oldModel.EstimatedPrice = logic.EstimatePrice(Math.Ceiling(newEndDate.Subtract(newStartDate).TotalDays), newCar.PricePerDay);

            Connection.CarStaus_Update(newCar, '0');
            newCar.Status = "Not Available";
            Connection.CustomerStaus_Update(newCustomer, '1');
            newCustomer.Status = "Renting";

            Connection.UpdateRental(oldModel);
        }
        public void DeleteRental(RentalModel model)
        {
            Connection.CarStaus_Update(model.RentedCar, '1');
            model.RentedCar.Status = "Available";
            Connection.CustomerStaus_Update(model.Renter, '0');
            model.RentedCar.Status = "Not Renting";

            Connection.DeleteRental(model.Id);
        }

        public void UpdateCustomerModel(string fname, string lname, string licenseNo, string phoneNo, string email, CustomerModel customer)
        {
            customer.FirstName = fname;
            customer.LastName = lname;
            customer.LicenseNumber = licenseNo;
            customer.PhoneNumber = phoneNo;
            customer.EmailAddress = email;

            Connection.UpdateCustomer(customer);
        }

        public void DeleteCustomer(CustomerModel model)
        {
            model.Status = "Obsolete";
            Connection.DeleteCustomer(model.Id);
        }

        public void DeleteCar(CarModel model)
        {
            model.Status = "Obsolete";
            Connection.DeleteCar(model.Id);
        }

        public void UpdateCarModel(string registerationNo, string year, string make, string model, string price, string mileage, CarCategoryModel type, List<CarFeatureModel> features, CarModel oldModel)
        {
            oldModel.RegisterationNumber = registerationNo;
            oldModel.Year = year;
            oldModel.Make = make;
            oldModel.Model = model;
            oldModel.PricePerDay = decimal.Parse(price);
            oldModel.Mileage = int.Parse(mileage);
            oldModel.Category = type;
            oldModel.Features = features;

            Connection.UpdateCar(oldModel);
        }

        public List<CarCategoryModel> GetCarCategoryModels()
        {
            return Connection.GetAll_Categories();
        }

        public List<CarFeatureModel> GetCarFeatureModels()
        {
            return Connection.GetAll_Features();
        }

        public List<RentalModel> GetRentalModels()
        {
            return Connection.GetAll_Rentals();
        }

        public List<CustomerModel> GetNotObsoleteCustomerModels()
        {
            return Connection.GetCustomers_NotObsolete();
        }

        public List<CarModel> GetNotObsoleteCarModels()
        {
            return Connection.GetCars_NotObsolete();
        }

        public List<CustomerModel> GetNotRentingCustomerModels()
        {
            return Connection.GetCustomers_NotRenting();
        }

        public List<CarModel> GetAvailableCarModels()
        {
            return Connection.GetCars_Available();
        }
    }
}
