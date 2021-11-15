using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Models;
using BusinessLogic.RentalClasses;
using System.Configuration;
using Dapper;
using System.Data;

namespace DataAccess
{
    public class DatabaseAccessor : IDataAccess
    {
        static readonly string name = "RentCarDB";

        readonly string CnnString = ConfigurationManager.ConnectionStrings[name].ConnectionString;

        static private RentalLogic logic = new RentalLogic();

        public void SaveCategory(CarCategoryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.CarCategoryName);
                p.Add("@PeopleNumber", model.PeopleNumber);
                p.Add("@LuggageNumber", model.LuggageNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCarCategories_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public void SaveFeature(CarFeatureModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@CarFeatureName", model.CarFeatureName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCarFeatures_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public void SaveCustomer(CustomerModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                char statusFlag = CustomerStatusStringToCharMapper(model.Status);
                var p = new DynamicParameters();
                p.Add("@LicenseNumber", model.LicenseNumber);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@Status", statusFlag);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCustomers_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public List<CarCategoryModel> GetAll_Categories()
        {
            List<CarCategoryModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                output = connection.Query<CarCategoryModel>("dbo.spCarCategories_GetAll").ToList();
            }
            return output;
        }

        public List<CarFeatureModel> GetAll_Features()
        {
            List<CarFeatureModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                output = connection.Query<CarFeatureModel>("dbo.spCarFeatures_GetAll").ToList();
            }
            return output;
        }

        public void SaveCar(CarModel carModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                char statusFlag = CarStatusStringToCharMapper(carModel.Status);
                p.Add("@Year", carModel.Year);
                p.Add("@Make", carModel.Make);
                p.Add("@Model", carModel.Model);
                p.Add("@TypeId", carModel.Category.Id);
                p.Add("@Status", statusFlag);
                p.Add("@PricePerDay", carModel.PricePerDay);
                p.Add("@Mileage", carModel.Mileage);
                p.Add("@RegisterationNumber", carModel.RegisterationNumber);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCars_Insert", p, commandType: CommandType.StoredProcedure);

                carModel.Id = p.Get<int>("@id");

                foreach (CarFeatureModel featureModel in carModel.Features)
                {
                    p = new DynamicParameters();
                    p.Add("@FeatureId", featureModel.Id);
                    p.Add("@CarId", carModel.Id);

                    connection.Execute("dbo.spFeaturesPerCar_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public List<CustomerModel> GetCustomers_NotRenting()
        {
            List<CustomerModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                output = connection.Query<CustomerModel>("dbo.spCustomers_GetNotRenting").ToList();
                foreach (CustomerModel customer in output)
                {
                    customer.Status = CustomerStatusCharToStringMapper(customer.Status);
                }
            }
            return output;
        }

        public List<CarModel> GetCars_Available()
        {
            List<CarModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                output = connection.Query<CarModel>("dbo.spCars_GetAvailable").ToList();

                foreach (CarModel car in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@CarId", car.Id);
                    car.Features = connection.Query<CarFeatureModel>("dbo.spFeaturesPerCar_GetByCar", p, commandType: CommandType.StoredProcedure).ToList();
                    car.Category = connection.Query<CarCategoryModel>("dbo.spCategories_GetByCar", p, commandType: CommandType.StoredProcedure).ToList().First();
                    car.Status = CarStatusCharToStringMapper(car.Status);
                }
            }
            return output;
        }

        public void SaveRental(RentalModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                char statusFlag = logic.DetermineRentalStatus(model);

                p.Add("@PickupDate", model.PickupDate);
                p.Add("@DropoffDate", model.DropoffDate);
                p.Add("@LateFeePerDay", model.LateFeePerDay);
                p.Add("@EarlyDiscountPerDay", model.EarlyDiscountPerDay);
                p.Add("@CustomerId", model.Renter.Id);
                p.Add("@CarId", model.RentedCar.Id);
                p.Add("@Status", statusFlag);
                p.Add("@EstimatedPrice", model.EstimatedPrice);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spRentals_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                statusFlag = '0';
                p = new DynamicParameters();
                p.Add("@CarId", model.RentedCar.Id);
                p.Add("@Status", statusFlag);

                connection.Execute("dbo.spCars_UpdateStatus", p, commandType: CommandType.StoredProcedure);

                statusFlag = '1';
                p = new DynamicParameters();
                p.Add("@CustomerId", model.Renter.Id);
                p.Add("@Status", statusFlag);

                connection.Execute("dbo.spCustomers_UpdateStatus", p, commandType: CommandType.StoredProcedure);

            }
        }

        public List<RentalModel> GetAll_Rentals()
        {
            List<RentalModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                output = connection.Query<RentalModel>("dbo.spRentals_GetAll").ToList();

                foreach (RentalModel rental in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@RentalId", rental.Id);

                    rental.Renter = connection.Query<CustomerModel>("dbo.spCustomers_GetByRental", p, commandType: CommandType.StoredProcedure).ToList().First();
                    rental.Renter.Status = CustomerStatusCharToStringMapper(rental.Renter.Status);

                    rental.RentedCar = connection.Query<CarModel>("dbo.spCars_GetByRental", p, commandType: CommandType.StoredProcedure).ToList().First();
                    rental.RentedCar.Status = CarStatusCharToStringMapper(rental.RentedCar.Status);

                    p = new DynamicParameters();
                    p.Add("@CarId", rental.RentedCar.Id);
                    rental.RentedCar.Features = connection.Query<CarFeatureModel>("dbo.spFeaturesPerCar_GetByCar", p, commandType: CommandType.StoredProcedure).ToList();
                    rental.RentedCar.Category = connection.Query<CarCategoryModel>("dbo.spCategories_GetByCar", p, commandType: CommandType.StoredProcedure).ToList().First();

                    RentalStatus_Update(rental, logic.DetermineRentalStatus(rental));

                    rental.Status = RentalStatusCharToStringMapper(rental.Status);

                    rental.EstimatedPrice = (logic.EstimateRentalPrice(rental));

                    RentalPrice_Update(rental, rental.EstimatedPrice);
                }
            }
            return output;
        }

        private string CustomerStatusCharToStringMapper(string statusFlag)
        {
            if (statusFlag.Equals("0"))
            {
                return "Not Renting";
            }
            else if (statusFlag.Equals("1"))
            {
                return "Renting";
            }
            else
            {
                return "Obsolete";
            }

        }

        private char CustomerStatusStringToCharMapper(string status)
        {
            if (status.Equals("Renting"))
            {
                return '1';
            }
            else if (status.Equals("Not Renting"))
            {
                return '0';
            }
            else
            {
                return '2';
            }

        }

        private char CarStatusStringToCharMapper(string status)
        {
            if (status.Equals("Available"))
            {
                return '1';
            }
            else if (status.Equals("Not Available"))
            {
                return '0';
            }
            else
            {
                return '2';
            }
        }

        private string CarStatusCharToStringMapper(string statusFlag)
        {
            if (statusFlag.Equals("0"))
            {
                return "Not Available";
            }
            else if (statusFlag.Equals("1"))
            {
                return "Available";
            }
            else
            {
                return "Obsolete";
            }
        }

        private string RentalStatusCharToStringMapper(string statusFlag)
        {
            if (statusFlag.Equals("0"))
            {
                return "New";
            }
            else if (statusFlag.Equals("1"))
            {
                return "Active";
            }
            else if (statusFlag.Equals("2"))
            {
                return "Late";
            }
            else
            {
                return "Returned";
            }
        }

        public void RentalStatus_Update(RentalModel model, char status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@RentalId", model.Id);
                p.Add("@Status", status);

                connection.Execute("dbo.spRentals_UpdateStatus", p, commandType: CommandType.StoredProcedure);
            }

        }
        public void RentalPrice_Update(RentalModel model, decimal price)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@RentalId", model.Id);
                p.Add("@EstimatedPrice", price);

                connection.Execute("dbo.spRentals_UpdatePrice", p, commandType: CommandType.StoredProcedure);
            }

        }

        public void CarStaus_Update(CarModel model, char status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@CarId", model.Id);
                p.Add("@Status", status);

                connection.Execute("dbo.spCars_UpdateStatus", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CarMileage_Update(CarModel model, int newMileage)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@CarId", model.Id);
                p.Add("@Mileage", newMileage);

                connection.Execute("dbo.spCars_UpdateMileage", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CustomerStaus_Update(CustomerModel model, char status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@CustomerId", model.Id);
                p.Add("@Status", status);

                connection.Execute("dbo.spCustomers_UpdateStatus", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void RentalActualDropoffDate_Update(RentalModel model, DateTime returnDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@RentalId", model.Id);
                p.Add("@ActualDropoffDate", returnDate);

                connection.Execute("dbo.spRentals_UpdateActualDropoffDate", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateRental(RentalModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@RentalId", model.Id);
                p.Add("@PickupDate", model.PickupDate);
                p.Add("@DropoffDate", model.DropoffDate);
                p.Add("@LateFeePerDay", model.LateFeePerDay);
                p.Add("@EarlyDiscountPerDay", model.EarlyDiscountPerDay);
                p.Add("@CustomerId", model.Renter.Id);
                p.Add("@CarId", model.RentedCar.Id);
                p.Add("@EstimatedPrice", model.EstimatedPrice);

                connection.Execute("dbo.spRentals_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteRental(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@RentalId", id);

                connection.Execute("dbo.spRentals_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<CarModel> GetCars_NotObsolete()
        {
            List<CarModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                output = connection.Query<CarModel>("dbo.spCars_GetNotObsolete").ToList();

                foreach (CarModel car in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@CarId", car.Id);
                    car.Features = connection.Query<CarFeatureModel>("dbo.spFeaturesPerCar_GetByCar", p, commandType: CommandType.StoredProcedure).ToList();
                    car.Category = connection.Query<CarCategoryModel>("dbo.spCategories_GetByCar", p, commandType: CommandType.StoredProcedure).ToList().First();
                    car.Status = CarStatusCharToStringMapper(car.Status);
                }
            }
            return output;
        }

        public List<CustomerModel> GetCustomers_NotObsolete()
        {
            List<CustomerModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                output = connection.Query<CustomerModel>("dbo.spCustomers_GetNotObsolete").ToList();
                foreach (CustomerModel customer in output)
                {
                    customer.Status = CustomerStatusCharToStringMapper(customer.Status);
                }
            }
            return output;
        }

        public void UpdateCustomer(CustomerModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();

                p.Add("@CustomerId", model.Id);
                p.Add("@LicenseNumber", model.LicenseNumber);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@EmailAddress", model.EmailAddress);

                connection.Execute("dbo.spCustomers_Update", p, commandType: CommandType.StoredProcedure);

            }
        }

        public void DeleteCustomer(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@CustomerId", id);

                connection.Execute("dbo.spCustomers_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteCar(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@CarId", id);

                connection.Execute("dbo.spCars_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateCar(CarModel carModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnString))
            {
                var p = new DynamicParameters();
                p.Add("@CarId", carModel.Id);
                p.Add("@Year", carModel.Year);
                p.Add("@Make", carModel.Make);
                p.Add("@Model", carModel.Model);
                p.Add("@TypeId", carModel.Category.Id);
                p.Add("@PricePerDay", carModel.PricePerDay);
                p.Add("@Mileage", carModel.Mileage);
                p.Add("@RegisterationNumber", carModel.RegisterationNumber);

                connection.Execute("dbo.spCars_Update", p, commandType: CommandType.StoredProcedure);

                p = new DynamicParameters();
                p.Add("@CarId", carModel.Id);

                connection.Execute("dbo.spFeaturesPerCar_Delete", p, commandType: CommandType.StoredProcedure);

                foreach (CarFeatureModel featureModel in carModel.Features)
                {
                    p = new DynamicParameters();
                    p.Add("@FeatureId", featureModel.Id);
                    p.Add("@CarId", carModel.Id);

                    connection.Execute("dbo.spFeaturesPerCar_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }


    }
}
