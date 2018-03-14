using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_PoolingSystem.Models;
// using dotnet_PoolingSystem.ViewModels;
using dotnet_PoolingSystem.Services;
using Microsoft.AspNetCore.Authorization;

namespace dotnet_PoolingSystem.Controllers
{
    public class PoolingController:Controller
    {
        private readonly IPoolingService _poolingService;
        public PoolingController(IPoolingService poolingService)
        {
            _poolingService = poolingService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _poolingService.getAll();
            var model = new AllEventViewModel()
            {
                Events = data
            };
            
            return Json(model);
        }
        

        [Authorize]
        [HttpGet]
        public IActionResult AddEvent()
        {
            return View();
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddEvent(AddEventViewModel addEvent)
        {

            if(!ModelState.IsValid) return Redirect("AddEvent");

            var result = await _poolingService.addEvent(addEvent);
            if(!result){
                return BadRequest("Some thing Went Wrong");
            }
            return Redirect("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Vote(AllEventViewModel allEvent)
        {
            return View();
        }

    }
}