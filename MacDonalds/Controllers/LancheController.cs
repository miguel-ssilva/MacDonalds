﻿using MacDonalds.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MacDonalds.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            var lanches = _lancheRepository.Lanches;

            return View(lanches);
        }
    }
}
