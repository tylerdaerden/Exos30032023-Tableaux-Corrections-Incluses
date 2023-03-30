
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
//        if (valeur % (int)premiers[index]! == 0) // unboxing object > int
//            estPremier = false;
//    }

//    if (estPremier)
//    {
//        premiers.Add(valeur); // boxing int > object
//    }

//    valeur++;
//}

//foreach (int premier in premiers)
//{
//    Console.WriteLine($"{premier} est un nombre premier !");
//}

//Console.WriteLine($"nombre de boucles : {compteur}");

//Console.Readline();

#endregion

#region Exo 1.2

// 1.2 : Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).



//int userchoice;
//do
//    Console.WriteLine("entrez le nombre jusqu'auquel nous devons afficher les nombres premiers existants");

//while (!int.TryParse(Console.ReadLine(), out userchoice));

//Console.WriteLine($"nous allons afficher les nombres premiers jusque {userchoice} ");
//Thread.Sleep(2000);
//Console.Clear();

//List <int> premiers = new List<int>();

//// 2 est le premier nombre premier
//int valeur = 2;
//while (valeur < userchoice)
//{
//    bool estPremier = true;
//    int racine = (int)Math.Sqrt(valeur);

//    for (int index = 0; estPremier && racine > 1 && premiers[index]! <= racine; index++)
//    {
//        if (valeur % premiers[index]! == 0)
//            estPremier = false;
//    }

//    if (estPremier)
//    {
//        premiers.Add(valeur);
//    }

//    valeur++;
//}

//foreach (int premier in premiers)
//{
//    Console.WriteLine($"{premier} est un nombre premier !");
//}

#endregion

#region Exo 1.3

//1.3 : Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition de ces deux nombres en ne convertissant que caractère par caractère. (Méthode « ToCharArray » de la classe « string »).




#endregion

#endregion
