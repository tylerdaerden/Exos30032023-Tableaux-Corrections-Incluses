
#region Exos Tableaux

#region Exo 1.1 

// 1.1 : Grâce à une boucle « while » et à l’aide d’une collection, calculez les nombres premiers inférieur à un nombre entier entré au clavier.

//using System.Collections;

//int userchoice;
//do
//    Console.WriteLine("entrez le nombre jusqu'auquel nous devons afficher les nombres premiers existants");

//while (!int.TryParse(Console.ReadLine(), out userchoice));

//Console.WriteLine($"nous allons afficher les nombres premiers jusque {userchoice} ");
//Thread.Sleep(2000);
//Console.Clear();

//ArrayList NombresPremiers = new ArrayList();
//NombresPremiers.Add(2);

//int num = 3;
//while (num < userchoice)
//{
//    int i = 0;
//    while (i < NombresPremiers.Count && num % (int)NombresPremiers[i] != 0)
//    {
//        i++;
//    }
//    if (i == NombresPremiers.Count)
//    {
//        NombresPremiers.Add(num);
//    }
//    num += 2;
//}

//Console.WriteLine("Les nombres premiers inférieurs à {0} sont :", userchoice);
//foreach (int premiers in NombresPremiers)
//{
//    Console.Write("{0} ", premiers);
//}

//Console.ReadLine();

//ArrayList NombrePremiers = new ArrayList(); // Créer une nouvelle ArrayList pour stocker les nombres premiers
//NombresPremiers.Add(2); // Ajouter 2, le premier nombre premier, à la liste

//int num = 3; // Commencer la recherche à partir de 3, le premier nombre impair
//while (num < userchoice)
//{ // Continuer la recherche jusqu'à ce que l'on atteigne le nombre maximum entré par l'utilisateur
//    int i = 0; // Initialiser l'index à 0
//    while (i < NombresPremiers.Count && num % (int)NombresPremiers[i] != 0)
//    { // Vérifier si le nombre courant est divisible par un nombre premier précédent dans la liste
//        i++; // Passer au nombre premier suivant dans la liste
//    }
//    if (i == NombresPremiers.Count)
//    { // Si le nombre courant n'est divisible par aucun nombre premier précédent dans la liste, c'est un nombre premier
//        NombresPremiers.Add(num); // Ajouter le nombre premier à la liste
//    }
//    num += 2; // Passer au nombre impair suivant
//}

//Console.WriteLine("Les nombres premiers inférieurs à {0} sont :", userchoice);
//foreach (int premiers in NombresPremiers)
//{ // Parcourir la liste des nombres premiers et les afficher à l'écran
//    Console.Write("{0} ", premiers);
//}
//Console.WriteLine();


//Thread.Sleep(2000); // juste pour le fun de jouer avec l'affichage , j'avoue 🕹
////Console.Clear();
////Thread.Sleep(1000);
////Console.WriteLine($"voici les nombres premiers jusque {userchoice} ");

//ArrayList NombrePremier = new ArrayList();

//for (int nombre = 0; nombre <= userchoice; nombre++)
//{
//    bool estPremier = true;
//    int sqrt = (int)Math.Sqrt(nombre);
//    for (int diviseur = 2; diviseur <= sqrt && estPremier; diviseur++)
//    {
//        if (nombre % diviseur == 0)
//        {
//            estPremier = false;
//        }
//    }

//    if (estPremier && nombre > 1)
//    {
//        Console.WriteLine(nombre);
//        NombrePremier.Add(nombre);

//    }
//}



//for (int nombre = 0; nombre <= userchoice; nombre++)
//{
//    bool estPremier = true;
//    int sqrt = (int)Math.Sqrt(nombre);
//    for (int diviseur = 2; diviseur <= sqrt && estPremier; diviseur++)
//    {
//        if (nombre % diviseur == 0)
//        {
//            estPremier = false;
//        }
//    }

//    if (estPremier && nombre > 1)
//    {
//        Console.WriteLine(nombre);
//        NombrePremier.Add(nombre);

//    }
//}
//Console.WriteLine($"Notre liste contient {NombrePremier.Count} nombres premiers");
//Console.ReadLine();


#endregion

#region Exo 1.2

// 1.2 : Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).

int x = 10; // Nombre de nombres premiers à trouver
List<int> nombresPremiers = new List<int>(); // Collection pour stocker les nombres premiers trouvés
nombresPremiers.Add(2); // Ajouter le premier nombre premier (2)

for (int i = 1; i < x; i++) // Boucle pour trouver les x premiers nombres premiers
{
    int dernierNombrePremier = nombresPremiers[nombresPremiers.Count - 1]; // Récupérer le dernier nombre premier dans la collection
    int prochainNombrePremier = dernierNombrePremier + 1; // Initialiser le prochain nombre premier à tester
    bool estPremier = false; // Initialiser la variable à false

    while (!estPremier) // Boucle tant que le prochain nombre n'est pas premier
    {
        estPremier = true; // Supposer que le nombre est premier

        for (int j = 2; j <= Math.Sqrt(prochainNombrePremier); j++) // Tester si le nombre est premier en utilisant la racine carrée
        {
            if (prochainNombrePremier % j == 0)
            {
                estPremier = false; // Si le nombre n'est pas premier, mettre la variable à false
                break; // Sortir de la boucle for pour le test de primalité
            }
        }

        if (estPremier) // Si le nombre est premier, l'ajouter à la collection
        {
            nombresPremiers.Add(prochainNombrePremier);
        }
        else // Sinon, passer au nombre suivant
        {
            prochainNombrePremier++;
        }
    }
}

// Afficher les nombres premiers trouvés
Console.Write("Les " + x + " premiers nombres premiers sont : ");
foreach (int nombrePremier in nombresPremiers)
{
    Console.Write(nombrePremier + " ");
}
Console.WriteLine();




#endregion

#region Exo 1.3

//1.3 : Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition de ces deux nombres en ne convertissant que ca ractère par caractère. (Méthode « ToCharArray » de la classe « string »).




#endregion

#endregion
