public interface IVehicle {
    string getType();
}

public class Car : IVehicle {
    public string getType() {
        return "Car";
    }
}

public class Bike : IVehicle {
    public string getType() {
        return "Bike";
    }
}

public class Truck : IVehicle {
    public string getType() {
        return "Truck";
    }
}

public abstract class VehicleFactory {
    public abstract IVehicle createVehicle();
}

public class CarFactory : VehicleFactory {
    public override IVehicle createVehicle()
    {
        return new Car();
    }
    // Write your code here
}

public class BikeFactory : VehicleFactory {
    public override IVehicle createVehicle()
    {
        return new Bike();
    }
    // Write your code here
}

public class TruckFactory : VehicleFactory {
    // Write your code here
    public override IVehicle createVehicle()
    {
        return new Truck();
    }
}
