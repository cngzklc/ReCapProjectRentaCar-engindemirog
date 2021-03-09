using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Constants
{
    public static class Messages
    {
        public static string Added(object entity) { return string.Format("{0} added!", entity.GetType().Name); }
        public static string Invalid(object entity) { return string.Format("Invalid! {0}", entity.GetType().Name); }
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string Listed(object entity) { return string.Format("{0} Listed!", entity.GetType().Name); }
        public static string NotListed(object entity) { return string.Format("{0} Not Listed!", entity.GetType().Name); }
        public static string MaintenanceTime = "Sistem bakımda!";

        //public static string RentableCar(object entity) { return string.Format("Rentable {0}!", entity.GetType().Name); }
        //public static string NotRentableCar(object entity) { return string.Format("Not a rentable {0}!", entity.GetType().Name); }
        public static string NotRentableCar = "Kirada olan araç gelmeden kiralanamaz!";
        public static string RentableCar = "Kiralanabilir araç";
        public static string NoMoreCarImagesCanBeAdded = "Daha fazla araba resmi eklenemez";
        public static string NotRealPerson = "Kişiye ait bilgileri kontrol ediniz! Girilen kişi doğrulanamadı!";
        public static string NationalIdExisted = "Bu kimlik numarası önceden girilmiş!";


        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string SuccessfulLogin = "Sisteme Giriş Başarılı!";
        public static string PasswordError = "Hatalı Şifre!";
        public static string UserAlreadyExists= "Kullanıcı zaten var!";
        public static string UserRegistered= "Kullanıcı başarı ile kayıt edildi!";
        public static string AccessTokenCreated= "Access Token başarı ile oluşturuldu!";

        public static string Updated(object entity) { return string.Format("{0} updated!", entity.GetType().Name); }
        public static string Deleted(object entity) { return string.Format("{0} deleted!", entity.GetType().Name); }
    }
}
