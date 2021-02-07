using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentaCarEntities.Concrete
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        //public string Serial { get; set; }
        //public string Model { get; set; }
        //public FuelEnum Fuel { get; set; }
        //public GearEnum Gear { get; set; }
        //public CaseTypeEnum CaseType { get; set; }
        //public int EnginePower { get; set; }
        //public double EngineVolume { get; set; }
    }
    //public enum FuelEnum { Diesel = 1, Gasoline = 2, Lpg = 3, GasolineLpg = 4, Electricity = 5, Hybrid = 6 } //Yakıt
    //public enum GearEnum { Manuel = 1, Semiautomatic = 2, Automatic = 3 }//Vites
    //public enum CaseTypeEnum { Sedan = 1, Hatchback = 2, Cabrio = 3, Coupe = 4, StationWagon = 5 }//Kasa tipi

}
