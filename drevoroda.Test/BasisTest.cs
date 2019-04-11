using System;
using Xunit;
using System.Collections.Generic;
using drevoroda.Models;
using drevoroda.Controllers;
using System.Linq;
using Moq;

namespace drevoroda.Test
{
    public class BasisTest
    {
        [Fact]
        public void ListRepoPerson()
        {

            Mock<IPersonRepository> mock = new Mock<IPersonRepository>();
            mock.Setup(m => m.Persons).Returns(new Person[] {
                new Person { FullName = "Низамеева Антонина Васильевна", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Аниховка" },
                new Person { FullName = "Низамеев Николай Мисбахович", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Аниховка" },
                new Person { FullName = "Гаврусь Александра", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Аниховка" },
                new Person { FullName = "Гаврусь Петр Сарапионович", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Аниховка" }
            });

            PersonController controller = new PersonController(mock.Object);
            IEnumerable<Person> result = controller.List().ViewData.Model as IEnumerable<Person>;

            Person[] people = result.ToArray();

            Assert.True(people.Length == 4);
        }
    }

}

