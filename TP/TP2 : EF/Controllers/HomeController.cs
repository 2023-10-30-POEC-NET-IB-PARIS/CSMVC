using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

		[Route("Home/Demo/{author}")]
		public IActionResult Demo(string author)
		{
			List<Auteur> auteurs = new List<Auteur>();
			auteurs.Add(new Auteur("Dumas", "Alexandre"));
			auteurs.Add(new Auteur("Hugo", "Victor"));
			auteurs.Add(new Auteur("De Balzac", "Honore"));

			var auteur_a_afficher = auteurs[0];
			foreach (var auteur in auteurs)
			{
				if (auteur.Nom == author)
				{
					auteur_a_afficher = auteur;
				}
			}

			return View(auteur_a_afficher);
		}

		public IActionResult Index()
		{
			//Auteur monauteur = new Auteur("Dumas", "Alexandre");
			List<Auteur> auteurs = new List<Auteur>();
			auteurs.Add(new Auteur("Dumas", "Alexandre"));
			auteurs.Add(new Auteur("Hugo", "Victor"));
			auteurs.Add(new Auteur("De Balzac", "Honore"));
		
			return View(auteurs);
		}

        public IActionResult Auteurs()
        {
            
            
            // - Transmettre les donnees >  ViewBag.MaListeAuteur = MaListeAuteur
            // - Receptionner les donnees > Recuperer ViewBag.MaListeAuteur dans /Views/Home/index.cshtml
            // - Mettre en forme les donnees
            //          - Apprendre a boucler sur un dictionnaire Valider 
            //          - Apprendre a boucler sur la liste des valeurs du Dict Valider
            //          - Le faire dans la vue
            //          - Ameliore la mise en page 

            var MaListeAuteur = new Dictionary<string,List<string>>
            {
                {"Alexandre Dumas",new List<string>{"Mousquettaire","Tulipe Noir"}},
                {"Jr Tolkien",new List<string>{"LOTR 1","LOTR 2","LOTR 3"}},
                {"Victor Hugo",new List<string>{"Bossu","Miserable"}},
                {"Emile Zola",new List<string>{"Bete humaine","pot bouille"}}
            };

            // // Apprendre a faire une boucle sur les Dictionnaires

            // foreach(var element_dictionnaire in MaListeAuteur )
            // {
            //     var auteur = element_dictionnaire.Key;
            //     var auteur_oeuvres = element_dictionnaire.Value;

            //     Console.WriteLine($"L'auteur est : {auteur}");
            //     foreach(var oeuvre in auteur_oeuvres)
            //     {
            //         Console.WriteLine($"- {oeuvre}");
            //     }
            // }

            ViewBag.MaListeAuteur = MaListeAuteur;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
