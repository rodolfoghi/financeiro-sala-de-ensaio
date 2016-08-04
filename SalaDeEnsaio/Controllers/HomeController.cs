using SalaDeEnsaio.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SalaDeEnsaio.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            var model = new HomeViewModels();

            model.Vencidos = db.ContasReceber
                .Include(c => c.Pessoa)
                .Where(x => DbFunctions.TruncateTime(x.Vencimento) < DbFunctions.TruncateTime(DateTime.Now)
                    && !x.Recebido)
                .OrderBy(x => x.Vencimento)
                .ToList();

            model.VencemHoje = db.ContasReceber
                .Include(c => c.Pessoa)
                .Where(x => DbFunctions.TruncateTime(x.Vencimento) == DbFunctions.TruncateTime(DateTime.Now)
                    && !x.Recebido)
                .OrderBy(x => x.Pessoa.Nome)
                .ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}