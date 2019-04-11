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
                new Person { FullName = "��������� �������� ����������", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "����, ������, ������������ �������, �. ��������" },
                new Person { FullName = "�������� ������� ����������", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "����, ������, ������������ �������, �. ��������" },
                new Person { FullName = "������� ����������", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "����, ������, ������������ �������, �. ��������" },
                new Person { FullName = "������� ���� ������������", DateOfBirth = new DateTime(1941, 01, 01), PlaceOfBirth = "����, ������, ������������ �������, �. ��������" }
            });

            PersonController controller = new PersonController(mock.Object);
            IEnumerable<Person> result = controller.List().ViewData.Model as IEnumerable<Person>;

            Person[] people = result.ToArray();

            Assert.True(people.Length == 4);
        }
    }

}

