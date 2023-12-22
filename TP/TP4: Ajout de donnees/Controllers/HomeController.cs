using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EF.Models;

namespace EF.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
	private readonly BiblioContext _context;

    public HomeController(ILogger<HomeController> logger, BiblioContext context)
    {
		_context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
		Auteur monauteur = new Auteur(){NomAuteur="Doe", PrenomAuteur="John"};
        _context.Auteurs.Add(monauteur);
		_context.SaveChanges();
	    return View();
    }

    public IActionResult Auteurs()
    {
		var mes_auteurs = _context.Auteurs;

		foreach (var auteur in mes_auteurs)
		{
			System.Console.WriteLine($"-------ID : {auteur.IdAuteur}---------");

			System.Console.WriteLine($"Nom Auteur : {auteur.NomAuteur}");
			System.Console.WriteLine($"Prenom Auteur : {auteur.PrenomAuteur}");

			System.Console.WriteLine("-------END--------");
		}

        return View(mes_auteurs);
    }

	[HttpPost]
	public IActionResult NewAuteur(Auteur newAuteur)
	{
		
		_context.Auteurs.Add(newAuteur);
		_context.SaveChanges();
		return Ok();
	}

	public IActionResult FormAuteur()
	{
		return View();
	}
	public IActionResult Auteur(int id)
    {
		var auteur = _context.Auteurs.Find(id);

		System.Console.WriteLine($"-------ID : {auteur.IdAuteur}---------");
		System.Console.WriteLine($"Nom Auteur : {auteur.NomAuteur}");
		System.Console.WriteLine($"Prenom Auteur : {auteur.PrenomAuteur}");

        return View(auteur);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
