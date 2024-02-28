using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            //check from mernis service 
            KPSPublicSoapClient client =
                new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}