using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RepeatIt.Domain.Services;
using System.Globalization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RepeatIt.Web.Controllers
{
    public class CardController : Controller
    {
        private readonly CardGenerator _cardGenerator;

        public CardController(CardGenerator cardGenerator)
        {
            _cardGenerator = cardGenerator;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var card = _cardGenerator.Generate(new CultureInfo("ru"), new CultureInfo("en"));
            return View();
        }
    }
}
