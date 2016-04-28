using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Vanilla.Service.ViewModel;

namespace Vanilla.Controller.Controller
{
    public class AdminController : System.Web.Mvc.Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
