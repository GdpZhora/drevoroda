using System;
using Xunit;
using System.Collections.Generic;
using drevoroda.Models;
using drevoroda.Controllers;

namespace drevoroda.Test
{
    public class BasisTest
    {
        [Fact]
        public void ListRepoPerson()
        {

            RepoPerson repoPerson = new RepoPerson();
            PersonController controller = new PersonController(repoPerson);


        }
    }
    public class RepoPerson : IPersonRepository
    {
        public IEnumerable<Person> Persons => new List<Person>
        {
                new Person { FullName = "Низамеева Антонина Васильевна", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Аниховка" },
                new Person { FullName = "Низамеев Николай Мисбахович", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Аниховка" },
                new Person { FullName = "Гаврусь Александра", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Аниховка" },
                new Person { FullName = "Гаврусь Петр Сарапионович", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Аниховка" }

        };
    }

}

