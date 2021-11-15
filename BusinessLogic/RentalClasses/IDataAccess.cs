using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;

namespace BusinessLogic.RentalClasses
{
    public interface IDataAccess
    {
        void SaveCustomer(CustomerModel model);
        void SaveCategory(CarCategoryModel model);
        void SaveFeature(CarFeatureModel model);
        List<CarCategoryModel> GetAll_Categories();
        List<CarFeatureModel> GetAll_Features();
        void SaveCar(CarModel carModel);
        List<CustomerModel> GetCustomers_NotRenting();
        List<CarModel> GetCars_Available();
        void SaveRental(RentalModel model);
        List<RentalModel> GetAll_Rentals();
        void RentalStatus_Update(RentalModel model, char status);
        void RentalActualDropoffDate_Update(RentalModel model, DateTime returnDate);
        void CarStaus_Update(CarModel model, char status);
        void CarMileage_Update(CarModel model, int newMileage);
        void CustomerStaus_Update(CustomerModel model, char status);
        void RentalPrice_Update(RentalModel model, decimal price);
        void UpdateRental(RentalModel model);
        void DeleteRental(int id);
        List<CarModel> GetCars_NotObsolete();
        List<CustomerModel> GetCustomers_NotObsolete();
        void UpdateCustomer(CustomerModel model);
        void DeleteCustomer(int id);
        void DeleteCar(int id);
        void UpdateCar(CarModel carModel);
    }
}
