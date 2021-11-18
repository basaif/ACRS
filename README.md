# ACRS
A WinForms application that manages car rental information, including the information of renters, cars, and rental bookings.

# Installation
1. Download the project code.
2. Create `RentCarDB` in Sql Server Express.
3. Run [this script](https://gist.github.com/basaif/4b0c16d04c812cabdb759170fa5ddcb7) to add tables and stored procedures to `RentCardDB` in Sql Server.
4. Replace the stars in the `connectionString` in `App.config` in the `ACRS` project with your server name.
```
<connectionStrings>
    <add name="RentCarDB" connectionString="Server=**********\SQLEXPRESS;Database=RentCarDB;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
</connectionStrings>
 ```
 5. Run the project in Visual Studio.

