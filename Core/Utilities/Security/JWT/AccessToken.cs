using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; } // Jeton
        public DateTime Expiration { get; set; } //Jetonun sona erme süresi
    }
}
