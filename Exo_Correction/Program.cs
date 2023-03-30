
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

//int compteur = 0;
//ArrayList premiers = new ArrayList();

//// 2 est le premier nombre premier
//int valeur = 2;
//while (valeur < userchoice)
//{
//    bool estPremier = true;
//    int racine = (int)Math.Sqrt(valeur);

//    for (int index = 0; estPremier && racine > 1 && (int)premiers[index]! <= racine; index++)
//    {
//        compteur++;
//        if (valeur % (int)premiers[index]! == 0 )
//            estPremier = false;
//    }

//    if (estPremier)
//    {
//        premiers.Add(valeur); 
//    }

//    valeur++;
//}

//foreach ( int premier in premiers )
//{
//    Console.WriteLine($"{premier} est un nombre premier !");
//}

//Console.WriteLine($"nombre de boucles : {compteur}");

#endregion

#region Exo 1.2

// 1.2 : Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).

int userchoice;
do
    Console.WriteLine("Combien de nombres premiers voulez vous trouver ? ");

while (!int.TryParse(Console.ReadLine(), out userchoice));

List<int> nombresPremiers = new List<int>(); // Collection pour stocker les nombres premiers trouvés
nombresPremiers.Add(2); // Ajouter le premier nombre premier (2)

for (int i = 1; i < userchoice; i++) // Boucle pour trouver les x premiers nombres premiers
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
Console.Write("Les " + userchoice + " premiers nombres premiers sont : ");
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
