using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;
using System;

namespace Hangman.Controllers
{
    public class HangmanController : Controller
    {
        [HttpGet("/new")]
      public ActionResult New()
      {
        return View("New", Hang.hiddenWord);
      }

      [HttpPost("/new")]
      public ActionResult Create(string guessedLetter)
      {
          char letter = Convert.ToChar(guessedLetter);
          return RedirectToAction("New", Hang.hiddenWord);
      }

    }
}