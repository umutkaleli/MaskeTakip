using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{

    public class ForeignerManager : IApplicantService
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
            throw new NotImplementedException();
        }
    }
}