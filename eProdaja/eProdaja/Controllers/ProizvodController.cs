using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route(template:"[controller]")]
    public class ProizvodController : ControllerBase
    {
        /// <summary> dependency injection
        public IProizvodService _proizvodService { get; set; }

        public ProizvodController(IProizvodService proizvodService)
        {
            _proizvodService = proizvodService;
        }
        /// </summary>

        [HttpGet]
        public IEnumerable<Proizvod>Get()
        {
            return _proizvodService.Get();
            //return _proizvodi;
        }

        [HttpGet(template:"{id}")]
        public Proizvod GetById(int id)
        {
            return _proizvodService.GetById(id);
            //return _proizvodi.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        public Proizvod Insert (Proizvod proizvod)
        {
            return _proizvodService.Insert(proizvod);

            //_proizvodi.Add(proizvod);
            //return proizvod;
        }

        [HttpPut(template: "{id}")]
        public Proizvod Update (int id, Proizvod proizvod)
        {
            return _proizvodService.Update(id, proizvod);

            //var current= _proizvodi.FirstOrDefault(x => x.Id == id);
            //current.Name = proizvod.Name;
            //return current;
        }
    }


}

public class Proizvod
{
    public int Id { get; set; }
    public string Name { get; set; }
}