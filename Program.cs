int choice = 0;
string input = "";
string output = "";

//Dictionary<string, string>

Console.WriteLine("=== Couteau Suisse ===");
Console.WriteLine("1. Texte -> Morse");
Console.WriteLine("2. Morse -> Texte");
Console.WriteLine("3. (à venir)");
Console.WriteLine("4. (à venir)");
Console.WriteLine("0. Quitter");

Console.Write("\nVotre choix : ");
choice = Console.Read();

if (choice == 1)
{
    Console.WriteLine("=== Texte -> Morse ===");
    Console.Write("Texte (lettres A-Z, chiffres) :");

    input = Console.ReadLine();

    Console.WriteLine("Résultat en Morse :");
    Console.Write(output);
}

string ConvertirTexteEnMorse()
{
    return output;
}



Console.Read();