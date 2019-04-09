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
                new Person { FullName = "��������� �������� ����������", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "����, ������, ������������ �������, �. ��������" },
                new Person { FullName = "�������� ������� ����������", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "����, ������, ������������ �������, �. ��������" },
                new Person { FullName = "������� ����������", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "����, ������, ������������ �������, �. ��������" },
                new Person { FullName = "������� ���� ������������", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "����, ������, ������������ �������, �. ��������" }

        };
    }

}

