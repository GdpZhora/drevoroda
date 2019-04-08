using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drevoroda.Models
{
    public interface IPersonRepository
    {
        IEnumerable<Person> Persons { get; }

    }
}
