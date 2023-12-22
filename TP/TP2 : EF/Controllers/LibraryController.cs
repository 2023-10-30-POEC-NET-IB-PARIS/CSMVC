using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
		[Route("Library/book/{id}")]
		public IActionResult Book(int id)
		{
			// Prendre un parametre id
			// 1. Creer une route avec un parametre id
			// 1.1. [Route("Library/book/{id}")]
			// 2. Mettre le parametre id dans la methode Book
			// 2.1 public IActionResult Book(int id)

			// Creer une liste de livres
			// 3. Creer une classe Book
			// 3.1. Creer un fichier Book.cs dans Models
			// 3.2. Creer les proprietes de la classe Book
			// 3.2.1. Titre
			// 3.2.2. Auteur
			// 3.2.3. Resume
			// 3.2.4. Date de publication
			// 3.3. Creer un constructeur avec les parametres
			// 3.4. Importer models dans LibraryController
			// 3.4.1. using WebApplication2.Models;
			// 4. Creer une liste de livres dans la Action Book
			// 4.1. List<Book> liste_livres = new List<Book>();
			// 5. Ajouter des livres dans la liste
			// 5.1. liste_livres.Add(new Book("Le comte de MC", "Dumas", "Un comte se bat contre un autre comte", new DateTime(1840, 1, 1)));

			// Selectionner le livre avec l'id correspondant
			// Etant donne un id et une liste de livres
			// livre_selectionne = liste_livres[id]

			// Envoyer le livre dans la vue
			// return View(livre_selectionne);

			// Receptionner le livre dans la vue
			// 6. Creer une vue Book
			// 6.1. Creer un fichier Book.cshtml dans Views/Library
			// 7. Specifier le type de donnees dans la vue
			// 7.1. @model Book

			// Afficher le livre dans la vue
			// 8. Afficher le Titre
			// 9. Afficher l'Auteur
			// 10. Afficher le Resume
			// 11. Afficher la date de publication

			//List<Book> liste_livres = new List<Book>();
			//liste_livres.Add(new Book("Le comte de MC", "Dumas", "Un comte se bat contre un autre comte", "1840-01-01"));
			//liste_livres.Add(new Book("LOTR", "JR Tolkien", "Un petit gars avec un anneau", "1954-07-29"));
			//liste_livres.Add(new Book("Harry Potter", "JK Rowling", "Un petit gars avec une baguette", "1997-06-26"));

			//Book livre_selectionne = liste_livres[id];

			//return View(livre_selectionne);
			return View();
		}

        [HttpGet]
        public IActionResult Books() // <<<< 2
        {
            Console.WriteLine("GET Books");

            // Chercher des donnes   
            //    6           3
            //   | |         | |
            //   \ /         \ /
            //    v           v
            // Donnes = donnes dans le modele


            //    8           7
            //   | |         | |
            //   \ /         \ /
            //    v           v
            var resultview = View();


            return resultview; // <--- 9
        }

        [HttpPost]
        public IActionResult Books(int? id)
        {
            Console.WriteLine("POST Books");
            return View();
        }
        public IActionResult Lotr()
        {
            return View();
        }
        public IActionResult getallbooks() {

            var mybooks = new Dictionary<string, string>
            {
                  {"Le comte de MC","Dumas"},
                  {"LOTR","JR Tolkien"},

            };


            return Json(mybooks);

        }
    }
}
