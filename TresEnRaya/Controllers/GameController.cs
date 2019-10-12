using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TresEnRayaCore;

namespace TresEnRaya.Controllers
{
    [Route("[controller]")]
    public class GameController : Controller
    {
        private readonly Game ticTacToe;

        public GameController(Game TicTacToe)
        {
            ticTacToe = TicTacToe;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(ticTacToe);
        }
        [HttpPost]
        public ActionResult ClickCell(Cell cell)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}