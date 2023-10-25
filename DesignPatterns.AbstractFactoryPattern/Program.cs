using DesignPatterns.AbstractFactoryPattern;

#region Regular
IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();

IBike regularBike = regularVehicleFactory.CreateBike();
regularBike.GetDetails();

ICar regularCar = regularVehicleFactory.CreateCar();
regularCar.GetDetails();
#endregion


#region Sports
IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();

IBike sportsBike = sportsVehicleFactory.CreateBike();
sportsBike.GetDetails();

ICar sportsCar = sportsVehicleFactory.CreateCar();
sportsCar.GetDetails();
#endregion