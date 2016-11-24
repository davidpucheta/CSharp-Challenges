using System.Web.Mvc;

namespace CharacterSheetApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var model = new Character();
			model.Name = "Hux";
			return View(model); 
		}


		public ActionResult Create(string characterName)
		{
			var model = new Character();
			model.Name = characterName;
			return View("Index", model);

		}

	}
}

