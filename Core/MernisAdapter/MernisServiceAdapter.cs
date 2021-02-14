//using Core.Business.Abstract;
using Core.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.MernisAdapter
{
    // "https://tckimlik.nvi.gov.tr/service/kpspublic.asmx?wsdl" adresini Project\Add Service Reference\ kısmına yapıştırarak ekliyoruz.
    public class MernisServiceAdapter : IPersonCheckService
    {
        async Task<bool> CheckIfRealPersonAsync(IPerson person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var returnobject = await client.TCKimlikNoDogrulaAsync
                ( Convert.ToInt64(person.NationalId),
                person.FirstName,
                person.LastName,
                Convert.ToInt32(person.DateOfBirth.Year));
            return returnobject.Body.TCKimlikNoDogrulaResult;
        }

      public bool CheckIfRealPerson(IPerson person)
        {
            return CheckIfRealPersonAsync(person).Result;
        }
    }
}
