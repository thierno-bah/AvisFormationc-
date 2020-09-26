using AvisFormation.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestSite.Controllers
{
    public class FormationController : Controller
    {
        // GET: Formation
        public ActionResult Index()
        {
            List<Formation> ListFormations = new List<Formation>();
            using (var context = new AvisTestDbEntities())
            {

                 ListFormations = context.Formations.ToList();
            
            
            };
            return View(ListFormations);
        }
    }
}