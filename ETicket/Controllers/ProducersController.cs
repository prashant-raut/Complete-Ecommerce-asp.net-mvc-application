using ETicket.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ETicket.Data.Services;
using ETicket.Models;
namespace ETicket.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducerService _service;

        public ProducersController(IProducerService service)
        {
            //_context = context;
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allproducers = await _service.GetAllAsync();
            return View(allproducers);
        }

        //Get:producer/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var producerdetails = await _service.GetByIdAsync(id);
            if (producerdetails==null) return View("NotFound");
            return View(producerdetails);
        }

        //Get:producer

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Create([Bind("ProfilePictureURL,FullName,Bio")]Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }





    }
}
