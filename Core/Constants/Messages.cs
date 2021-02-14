using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Constants
{
    public static class Messages
    {
        public static string Added(object entity) { return string.Format("{0} added!", entity.GetType().Name); }
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string ProductsListed = "Ürünler listelendi!";
        public static string MaintenanceTime = "Sistem bakımda!";
    }
}
