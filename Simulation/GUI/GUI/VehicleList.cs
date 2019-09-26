using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VehicleModel
{
    public byte TOPSPEED { get; private set; } = 10;
    public byte ACCELERATION { get; private set; } = 3;
    public string MODEL { get; private set; } = "";
    public double LENGTH { get; private set; } = 3.9;
    public double BREADTH { get; private set; } = 1.8;
    public VehicleModel(string model, byte topspeed, byte acceleration,double length,double breadth);
}

class VehicleModels
{
    public static VehicleModel[] Cars =
    {
        new VehicleModel("TESLA-ROADSTER",111,14,3.9,1.8),
        new VehicleModel("MISTUBISHI-PAJERO",47,5,4.9,1.8),
        new VehicleModel("MARUTI-SWIFT-PETROL",55,7,3.8,1.7),
        new VehicleModel("ALTO-800",38,6,3.3,1.5),
        new VehicleModel("E-CLASS",69,12,5,1.8),
        new VehicleModel("TATA-NANO",27,3,3,1.4),
        new VehicleModel("VOLKSWAGEN-POLO",66,7,3.9,1.6),
        new VehicleModel("VOLKSWAGON-VENTO",66,10,4.3,1.7),
        new VehicleModel("HONDA-AMAZE",50,9,3.9,1.6),
        new VehicleModel("HONDA-CITY",61,9,4.4,1.6),
        new VehicleModel("HUNDAI-CREATA",61,9,4.2,1.7),
    };
    public static VehicleModel[] motorcycles =
    {
        new VehicleModel("PULSUR-150",50,10,2,0.7),
        new VehicleModel("PULSUR-220",55,10,2,0.7),
        new VehicleModel("BULLET-350CC ",41,4,2.1,0.8),
        new VehicleModel("SPLENDER",38,7,1.9,0.7),
        new VehicleModel("ACTIVA",27,4,1.8,0.7),
    };
    public static VehicleModel[] bus =
    {
        new VehicleModel("ASHOK-LEYLAND ",33,3,7,2),
        new VehicleModel("TATA",38,3,11.7,2.5),
    };
    public static VehicleModel[] truck =
    {
        new VehicleModel("BHARATH-BENZ ",33,3,7,2),
        new VehicleModel("TATA ",33,3,7,2),
    };
}
