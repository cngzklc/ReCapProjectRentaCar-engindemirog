using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentaCarEntities.Concrete
{
    public class Car : IEntity
    {
        string _carName;
        decimal _dailyPrice;
        public int CarId { get; set; }
        public string CarName
        {
            get { return _carName; }
            set { if (value.Length < 2) { throw new Exception("Araba ismi 2 karakterden uzun olmalı"); } else {  _carName = value; } }
        }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice
        {
            get { return _dailyPrice; }
            set { if (value <= 0) { throw new Exception("Günlük kiralama ücreti sıfırdan büyük olmalı"); } else { _dailyPrice = value; } }
        }
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

    //class RequiredPropertyAttribute : Attribute
    //{

    //}
}


//[Display(Name = "Ürün Adı")]
//[Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
//[MinLength(2, ErrorMessage = "{0} alanı en az {1} karakter olmalıdır!")]
//[MaxLength(250, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır!")]
//public string ProductName { get; set; }

//[Display(Name = "Birim Fiyat")]
//[Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
//[Range(0, Decimal.MaxValue, ErrorMessage = "{0} alanı, {1} den büyük olmalıdır")]
//public decimal UnitPrice { get; set; }

//[Display(Name = "Posta Kodu")]
//[Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
//[MaxLength(5, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır!")]
//[RegularExpression("^[0-9]{5}$", "Lütfen geçerli bir posta kodu yazınız!")]
//public string PostCode { get; set; }