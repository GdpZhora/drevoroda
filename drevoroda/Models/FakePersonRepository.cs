using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drevoroda.Models
{
    public class FakePersonRepository : IPersonRepository
    {
        public IEnumerable<Person> Persons
        {
            get
            {



            // twoline
            Person mother = new Person { FullName = "Гаврусь Светлана Николаевна", DateOfBirth = new DateTime(1963, 06, 13), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Джасай" };
            Person father = new Person { FullName = "Гаврусь Михаил Петрович", DateOfBirth = new DateTime(1956, 11, 14), PlaceOfBirth = "СССР, Россия, Оренбургская область, с. Аниховка" };

            // oneline
            Person mnu = new Person { FullName = "Гаврусь Евгений Михайлович", DateOfBirth = new DateTime(1986, 09, 09), PlaceOfBirth = "СССР, Россия, Оренбургская область, г. Орск", Father = father, Mother = mother };
            Person sister = new Person { FullName = "Тюрина Наталья Михайловна", DateOfBirth = new DateTime(1983, 05, 11), PlaceOfBirth = "СССР, Россия, Оренбургская область, г. Орск", Father = father, Mother = mother };

                return new List<Person>
            {
                mother,
                father,
                mnu,
                sister
            };
            }
        }

    }


}

