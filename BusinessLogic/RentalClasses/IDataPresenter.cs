using System;
using System.Collections.Generic;
using BusinessLogic.Models;

namespace BusinessLogic.RentalClasses
{
    public interface IDataPresenter
    {
        CustomerModel CreateCustomerModel(string fname, string lname, string licenseNo, string phoneNo, string email);
        CarCategoryModel CreateCategoryModel(string name, string peopleNumber, string luggageNumber);
        CarFeatureModel CreateFeatureModel(string name);
        CarModel CreateCarModel(string registerationNo, string year, string make, string model, string price, string mileage, CarCategoryModel type, List<CarFeatureModel> features);
        RentalModel CreateRentalModel(DateTime startDate, DateTime endDate, string lateFee, string earlyDiscount, CustomerModel renter, CarModel car);
        void ReturnRental(RentalModel rentalModel, DateTime returnDate, int newMileage);
        void UpdateRentalModel(RentalModel oldModel, DateTime newStartDate, DateTime newEndDate, CustomerModel newCustomer, CarModel newCar, string newLateFee, string newEarlyDiscount);
        void DeleteRental(RentalModel model);
        void UpdateCustomerModel(string fname, string lname, string licenseNo, string phoneNo, string email, CustomerModel customer);
        void DeleteCustomer(CustomerModel model);
        void DeleteCar(CarModel model);
        void UpdateCarModel(string registerationNo, string year, string make, string model, string price, string mileage, CarCategoryModel type, List<CarFeatureModel> features, CarModel oldModel);
        List<CarCategoryModel> GetCarCategoryModels();
        List<CarFeatureModel> GetCarFeatureModels();
        List<RentalModel> GetRentalModels();
        List<CustomerModel> GetNotObsoleteCustomerModels();
        List<CarModel> GetNotObsoleteCarModels();
        List<CustomerModel> GetNotRentingCustomerModels();
        List<CarModel> GetAvailableCarModels();
    }
}
