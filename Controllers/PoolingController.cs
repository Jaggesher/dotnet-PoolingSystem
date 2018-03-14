using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_PoolingSystem.Models;
using dotnet_PoolingSystem.ViewModels;
using dotnet_PoolingSystem.Services;
using Microsoft.AspNetCore.Authorization;

namespace dotnet_PoolingSystem.Controllers
{
    public class PoolingController:Controller
    {
        private readonly IPoolingService _poolingService;
        protected PoolingController(IPoolingService poolingService)
        {
            _poolingService = poolingService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
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
        public IActionResult AddEvent(AddEventViewModel addEvent)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Vote(AllEventViewModel allEvent)
        {
            return View();
        }

    }
}