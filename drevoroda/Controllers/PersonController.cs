using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using drevoroda.Models;
using Microsoft.AspNetCore.Mvc;

namespace drevoroda.Controllers
{
    public class PersonController : Controller
    {
        private IPersonRepository repository;

        public PersonController(IPersonRepository repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Persons);
    }
}
