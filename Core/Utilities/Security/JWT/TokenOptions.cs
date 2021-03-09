using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class TokenOptions
    {
        public string Audince { get; set; } //Token'ın kullanıcı kitlesi
        public string Issuer { get; set; } // İmzalayan
        public int AccessTokenExpiration { get; set; } // erişim jetonunun son kullanma süresi => dakika cinsinden olduğu için int
        public string SecurityKey { get; set; } //Güvenlik anahtarı

    }
}
