Exemple de model MVC

```csharp
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
```