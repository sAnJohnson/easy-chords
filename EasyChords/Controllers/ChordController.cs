using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using EasyChords.Models;
using EasyChords.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EasyChords.Controllers
{
    public class ChordController : Controller
    {
        private readonly IChordRepository _chordRepository;
        private readonly IMusicalKeyRepository _musicalKeyRepository;

        public ChordController(IChordRepository chordRepository, IMusicalKeyRepository musicalKeyRepository)
        {
            _chordRepository = chordRepository;
            _musicalKeyRepository = musicalKeyRepository;
        }

        public ViewResult List()
        {
            ChordsListViewModel chordsListViewModel = new ChordsListViewModel();
            chordsListViewModel.Chords = _chordRepository.AllChords;

            chordsListViewModel.CurrentMusicalKey = "C Major";
            return View(chordsListViewModel);
        }

        public IActionResult Details(int id)
        {
            var chord = _chordRepository.GetChordById(id);
            if (chord == null)
                return NotFound();
            return View(chord);
        }
    }
}
