#region 1.1 Nombre premier < à x en utilisant boucle while et une collection
{
    //int nombre;

    //do
    //{
    //    Console.Write("Entrez un nombre entier : ");
    //} while (!int.TryParse(Console.ReadLine(), out nombre));

    //ArrayList premiers = new ArrayList();
    ////2 est le premier nombre premier
    //int valeur = 2;
    //while (valeur < nombre)
    //{
    //    bool estPremier = true;
    //    int racine = (int)Math.Sqrt(valeur);

    //    for (int index = 0; estPremier && racine > 1 && (int)premiers[index]! <= racine; index++)
    //    {
    //        if (valeur % (int)premiers[index]! == 0) //unboxing object > int
    //            estPremier = false;
    //    }

    //    if (estPremier)
    //    {
    //        premiers.Add(valeur); //boxing int > object
    //    }

    //    valeur++;
    //}

    //foreach (int premier in premiers)
    //{
    //    Console.WriteLine($"{premier} est un nombre premier!");
    //}
}
#endregion

#region 1.2 x premiers nombres premiers en utilisant une collection générique
{
    //int nombre;

    //do
    //{
    //    Console.Write("Entrez un nombre entier : ");
    //} while (!int.TryParse(Console.ReadLine(), out nombre));

    //List<int> premiers = new List<int>();

    ////2 est le premier nombre premier
    //for (int count = 0, valeur = 2; count < nombre; valeur++)
    //{
    //    bool estPremier = true;
    //    int racine = (int)Math.Sqrt(valeur);

    //    for (int index = 0; estPremier && racine > 1 && premiers[index] <= racine; index++)
    //    {
    //        if (valeur % premiers[index] == 0)
    //            estPremier = false;
    //    }

    //    if (estPremier)
    //    {
    //        premiers.Add(valeur);
    //        count++;
    //    }
    //}

    //foreach (int premier in premiers)
    //{
    //    Console.WriteLine($"{premier} est un nombre premier!");
    //}
}
#endregion

#region 1.3 Addition
{
    //string nombre1;
    //string nombre2;

    //do
    //{
    //    Console.Write("Entrez un nombre entier : ");
    //} while (!Regex.IsMatch(nombre1 = Console.ReadLine()!, @"^\d+$"));

    //do
    //{
    //    Console.Write("Entrez un second nombre entier : ");
    //} while (!Regex.IsMatch(nombre2 = Console.ReadLine()!, @"^\d+$"));

    //Stack<int> chiffresNombre1 = new Stack<int>();
    //foreach (char c in nombre1)
    //{
    //    chiffresNombre1.Push(c - 48);
    //}

    //Stack<int> chiffresNombre2 = new Stack<int>();
    //foreach (char c in nombre2)
    //{
    //    chiffresNombre2.Push(c - 48);
    //}

    //string resultat = "";
    //int report = 0;

    //while (chiffresNombre1.Count > 0 || chiffresNombre2.Count > 0)
    //{
    //    int chiffre1 = chiffresNombre1.Count > 0 ? chiffresNombre1.Pop() : 0;
    //    int chiffre2 = chiffresNombre2.Count > 0 ? chiffresNombre2.Pop() : 0;

    //    int addition = chiffre1 + chiffre2 + report;
    //    resultat = $"{addition % 10}{resultat}";
    //    report = addition / 10;
    //}

    //if (report > 0)
    //{
    //    resultat = $"{report}{resultat}";
    //}

    //Console.WriteLine(resultat);
}
#endregion

#region Fonction de tri
{
    //int nombre;

    //do
    //{
    //    Console.Write("Entrez le nombre d'éléménts entiers de votre tableau (au moins 10) : ");
    //} while (!int.TryParse(Console.ReadLine(), out nombre) || nombre < 10);

    //int[] tableau = new int[nombre];

    //for (int i = 0; i < tableau.Length; i++)
    //{
    //    tableau[i] = Random.Shared.Next(1000);
    //}

    //Console.WriteLine(string.Join(", ", tableau));

    ////Tri simple
    //for (int i = 0; i < tableau.Length - 1; i++)
    //{
    //    for (int j = i + 1; j < tableau.Length; j++)
    //    {
    //        if (tableau[j] < tableau[i])
    //        {
    //            //swap
    //            int temp = tableau[j];
    //            tableau[j] = tableau[i];
    //            tableau[i] = temp;
    //        }
    //    }
    //}

    //Console.WriteLine(string.Join(", ", tableau));
}
#endregion