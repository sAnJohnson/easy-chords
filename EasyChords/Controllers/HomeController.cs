using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyChords.Models;
using EasyChords.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EasyChords.Controllers
{
    public class HomeController : Controller
    {
        private readonly IChordRepository _chordRepository;

        public HomeController(IChordRepository chordRepository)
        {
            _chordRepository = chordRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                MinorChords = _chordRepository.MinorChords,
                MajorChords = _chordRepository.MajorChords
            };

            return View(homeViewModel);
        }
    }
}
