using System;
using Xunit;
using System.Collections.Generic;
using drevoroda.Models;

namespace drevoroda.Test
{
    public class BasisTest
    {
        [Fact]
        public void TrueInitRepo()
        {
            FakePersonRepository fakePerson = new FakePersonRepository();


            List<Person> people = (List<Person>)fakePerson.Persons;

            int Count = 4;

            Assert.Equal(people.Count, Count);


        }
    }
}
