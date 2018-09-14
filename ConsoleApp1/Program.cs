using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //RANDOM
            Random aleatoire = new Random();
            int laChance =
               aleatoire.Next(1, 11);
            Random alea = new Random();
            int laChance2 =
              aleatoire.Next(1, 6);

            //AFFICHAGE
            Console.WriteLine("P.S: La début du jeux change selon le niveau de beauté de Deadpool");
            Console.WriteLine("");
            Console.WriteLine(" MISE EN SITUATION: , Deadpool s'ennuie tellement qu'il décide de jouer à une sorte de jeu qui s'appelle un simulateur de drague (pathétique)");
            Console.WriteLine("");
            Console.WriteLine("BUT: Il va falloir que tu aides Deadpool à avouer ses sentiments à «son amies d'enfance» qui n'avait pas vu depuis 5 ans en faisant les meilleurs choix, car il est amoureux d'elle depuis toujours, mais il n'est pas capable des les exprimer alors il compte sur toi  ");
            Console.WriteLine("");
            Console.WriteLine("Maintenant, on va te dire le niveau de beauté de Deadpool pour voir si tu vas avoir de la misère à l'aider");
            Console.WriteLine("");
            Console.WriteLine("Votre niveau de beauté est de " + laChance);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            //VARIABLES ENTRE 8 & 9
            int choix1 = 0;
            int choix2 = 0;
            int choix3 = 0;
            //VARIABLES ENTRE 2 & 4
            int choix7 = 0;
            int choix8 = 0;
            int choix9 = 0;
            //VARIABLES ENTRE 5 & 7
            int choix4 = 0;
            int choix5 = 0;
            int choix6 = 0;
            //VARIABLE CACHER
            int choix10 = 0;
            //DEBUT LEVEL DE BEAUTE

            if (laChance == 10)
            {
                Console.WriteLine(" Après 5 ans sans l'avoir vu, elle veut absolument lui dire quelque chose et elle lui avoue sessentiments et toi aussi (FIN JOYEUSE)!!!");
            }
            else if (1 == laChance)
            {
                Console.WriteLine("C'est la friendzone automatique mon deadpool (RECOMMENCEZ)");
            }
            else if (4 >= laChance)
            {
                Console.WriteLine(" Après 5 ans, elle lui demande  s'il veut aller a quelque part ? Aide-le à trouver l'endroit parfait pour lui avouer ses sentiments!  ");
                Console.WriteLine("");
                Console.WriteLine("Magasiner (Appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("L'a laisser choir l'endroit (Appuyer sur 2)");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix7 = Convert.ToInt32(Console.ReadLine());
            }


            else if (7 >= laChance)
            {
                Console.WriteLine("Après 5 ans, elle lui demande  s'il veut aller a quelque part ? Aide-le à trouver l'endroit parfait pour lui avouer ses sentiments!");
                Console.WriteLine("");
                Console.WriteLine("Magasiner (appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("L'a laisser choisir l'endroit (appuyer sur 2) ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix4 = Convert.ToInt32(Console.ReadLine());

            }


            else if (9 >= laChance)
            {
                Console.WriteLine("Après 5 ans, elle lui demande  s'il veut aller a quelque part ? Aide-le à trouver l'endroit parfait pour lui avouer ses sentiments!");
                Console.WriteLine("");
                Console.WriteLine("Magasiner (appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("L'a laisser choisir l'endroit (appuyer sur 2) ");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix1 = Convert.ToInt32(Console.ReadLine());
            }
            //FIN DU LEVEL DE BEAUTE


            //DEBUT DE LA CONDITION DU LEVEL DE BEAUTE ENTRE 8 & 9
            if (9 >= laChance && 1 == choix1)
            {
                Console.WriteLine("Parfait! C'est l'endroit préféré de Hiyori(Son amie d'enfance) tu as bien choisi pour Deadpool ! ");
                Console.WriteLine("");
                Console.WriteLine("Il va l'a trouver dans un centre d'achats et ils commencent à magasiner ensemble, aide Deadpool à ce que les retrouvailles ne soient pas trop malaisante.");
                Console.WriteLine("");
                Console.WriteLine("Il engage la discussion et lui parle de tout et de rien (appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("Il engage la discussion et il lui dit qu'elle est toujours aussi mignonne qu'avant (appuyer sur 2)");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix2 = Convert.ToInt32(Console.ReadLine());
            }
            else if (9 >= laChance && 2 == choix1)
            {
                Console.WriteLine("Non,  elle veut absolument que c'est toi qui trouve l'endroit. C'était un mauvaiS choix tu as mal conseillé Deadpool (RECOMMENCEZ)");
            }


            if (9 >= laChance && 1 == choix1 && 1 == choix2)
            {
                Console.WriteLine("Le temps passe tellement vite que vous avez pas vu l'heure passé juste avant de partir,Deadpool veut lui dire ses sentiments, aide-le");
                Console.WriteLine("");
                Console.WriteLine("Vas-y Deadpool c'est le bon moment (Appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("Ne fais rien Deadpool (Appuyer sur 2)");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix3 = Convert.ToInt32(Console.ReadLine());

            }
            else if (9 >= laChance && 1 == choix1 && 2 == choix2)
            {
                Console.WriteLine("Elle le regarde avec des yeux si magnigique qu'il lui donne des papillons à Deadpool. C'est le bon moment pour conclure, aide-le ");
                Console.WriteLine("");
                Console.WriteLine("Vas-y Deadpool c'est le bon moment (Appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine(" Il ne peux plus enlever son regard de ses yeux et tu ne peux rien faire pour l'aider (Appuyer sur 2)");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix3 = Convert.ToInt32(Console.ReadLine());

            }



            if (9 >= laChance && 1 == choix1 && 1 == choix2 && 1 == choix3)
            {
                Console.WriteLine("Félicitation tu as aidé Deadpool a conquérir son amour de toujours, il te remercie (FIN JOYEUSE)");
            }
            else if (9 >= laChance && 1 == choix1 && 1 == choix2 && 2 == choix3)
            {
                Console.WriteLine("Mauvais choix le but c'est d'aider Deadpool à concquérir son amours de toujours pas le contraire (RECOMMENCEZ)");
            }
            else if (9 >= laChance && 1 == choix1 && 2 == choix2 && 1 == choix3)
            {
                Console.WriteLine("quand il lui a déclaré sa flamme et lui as dit d'arrêter de parler et ils se sont embrassés (FIN JOYEUSE)");
            }
            else if (9 >= laChance && 1 == choix1 && 2 == choix2 && 2 == choix3)
            {
                Console.WriteLine("Sans rien penser Deadpool et Hiyori s'approchent et s'embrasse, un instant que les deux n'oublieront jamais(FFIN JOYEUSE) ");
            }






            //FIN DE LA CONDITION DE LA BEAUTE ENTRE 8 & 9

            if (7 >= laChance && 1 == choix4)
            {
                Console.WriteLine("Parfait! C'est l'endroit préféré de Hiyori(Son amie d'enfance) tu as bien choisi pour Deadpool ! ");
                Console.WriteLine("");
                Console.WriteLine("Il va l'a trouver dans un centre d'achats et ils commencent à magasiner ensemble, aide Deadpool à ce que les retrouvailles ne soient pas trop malaisante.");
                Console.WriteLine("");
                Console.WriteLine("Il engage la discussion et lui parle de tout et de rien (appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("Il engage la discussion et il lui dit qu'elle est toujours aussi mignonne qu'avant (appuyer sur 2)");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix5 = Convert.ToInt32(Console.ReadLine());
            }
            else if (7 >= laChance && 2 == choix4)
            {
                Console.WriteLine("Non,  elle veut absolument que c'est toi qui trouve l'endroit. C'était un mauvaiS choix tu as mal conseillé Deadpool (RECOMMENCEZ)");
            }


            if (7 >= laChance && 1 == choix4 && 1 == choix5)
            {
                Console.WriteLine("Le temps passe tellement vite que vous avez pas vu l'heure passé juste avant de partir,Deadpool veut lui dire ses sentiments, aide-le");
                Console.WriteLine("");
                Console.WriteLine("Vas-y Deadpool c'est le bon moment (Appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("Ne fais rien Deadpool (Appuyer sur 2)");
                Console.WriteLine(""); Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix6 = Convert.ToInt32(Console.ReadLine());

            }
            else if (7 >= laChance && 1 == choix4 && 2 == choix5)
            {
                Console.WriteLine("Elle le regarde avec des yeux si magnigique qu'il lui donne des papillons à Deadpool. C'est le bon moment pour conclure, aide-le ");
                Console.WriteLine("");
                Console.WriteLine("Vas-y Deadpool c'est le bon moment (Appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine(" Il ne peux plus enlever son regard de ses yeux et tu ne peux rien faire pour l'aider (Appuyer sur 2)");
                Console.WriteLine(""); Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix6 = Convert.ToInt32(Console.ReadLine());
            }


            if (7 >= laChance && 1 == choix4 && 1 == choix5 && 1 == choix6)
            {
                Console.WriteLine("Félicitation tu as aidé Deadpool a conquérir son amour de toujours, il te remercie (FIN JOYEUSE)");
            }
            else if (7 >= laChance && 1 == choix4 && 1 == choix5 && 2 == choix6)
            {
                Console.WriteLine("Mauvais choix le but c'est d'aider Deadpool à concquérir son amours de toujours pas le contraire (RECOMMENCEZ)");
            }
            else if (7 >= laChance && 1 == choix4 && 2 == choix5 && 1 == choix6)
            {
                Console.WriteLine("quand il lui a déclaré sa flamme et lui as dit d'arrêter de parler et ils se sont embrassés (FIN JOYEUSE)");
            }
            else if (7 >= laChance && 1 == choix4 && 2 == choix5 && 2 == choix6)
            {
                Console.WriteLine("Sans rien penser Deadpool et Hiyori s'approchent et s'embrasse, un instant que les deux n'oublieront jamais(FFIN JOYEUSE) ");
            }

            if (4 >= laChance && 1 == choix7)
            {
                Console.WriteLine("Parfait! C'est l'endroit préféré de Hiyori(Son amie d'enfance) tu as bien choisi pour Deadpool ! ");
                Console.WriteLine("");
                Console.WriteLine("Il va l'a trouver dans un centre d'achats et ils commencent à magasiner ensemble, aide Deadpool à ce que les retrouvailles ne soient pas trop malaisante.");
                Console.WriteLine("");
                Console.WriteLine("Il engage la discussion et lui parle de tout et de rien (appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("Il engage la discussion et il lui dit qu'elle est toujours aussi mignonne qu'avant (appuyer sur 2)");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix8 = Convert.ToInt32(Console.ReadLine());
            }
            else if (4 >= laChance && 2 == choix7)
            {
                Console.WriteLine("Non,  elle veut absolument que c'est toi qui trouve l'endroit. C'était un mauvaiS choix tu as mal conseillé Deadpool (RECOMMENCEZ)");
            }


            if (4 >= laChance && 1 == choix7 && 1 == choix8)
            {
                Console.WriteLine("Le temps passe tellement vite que vous avez pas vu l'heure passé juste avant de partir,Deadpool veut lui dire ses sentiments, aide-le");
                Console.WriteLine("");
                Console.WriteLine("Vas-y Deadpool c'est le bon moment (Appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("Ne fais rien Deadpool (Appuyer sur 2)");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix9 = Convert.ToInt32(Console.ReadLine());

            }
            else if (4 >= laChance && 1 == choix7 && 2 == choix8)
            {
                Console.WriteLine("Elle le regarde avec des yeux si magnigique qu'il lui donne des papillons à Deadpool. C'est le bon moment pour conclure, aide-le ");
                Console.WriteLine("");
                Console.WriteLine("Vas-y Deadpool c'est le bon moment (Appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine(" Il ne peux plus enlever son regard de ses yeux et tu ne peux rien faire pour l'aider (Appuyer sur 2)");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix9 = Convert.ToInt32(Console.ReadLine());
            }


            if (4 >= laChance && 1 == choix7 && 1 == choix8 && 1 == choix9)
            {
                Console.WriteLine("Félicitation tu as aidé Deadpool a conquérir son amour de toujours, il te remercie (FIN JOYEUSE)");
            }
            else if (4 >= laChance && 1 == choix7 && 1 == choix8 && 2 == choix9)
            {
                Console.WriteLine("Mauvais choix le but c'est d'aider Deadpool à concquérir son amours de toujours pas le contraire (RECOMMENCEZ)");
            }
            else if (4 >= laChance && 1 == choix7 && 2 == choix8 && 1 == choix9)
            {
                Console.WriteLine("quand il lui a déclaré sa flamme et lui as dit d'arrêter de parler et ils se sont embrassés (FIN JOYEUSE)");
            }
            else if (4 >= laChance && 1 == choix7 && 2 == choix8 && 2 == choix9)
            {
                Console.WriteLine("Sans rien penser Deadpool et Hiyori s'approchent et s'embrasse, un instant que les deux n'oublieront jamais(FIN JOYEUSE) ");
            }




            if (5 == laChance2)
            {
                Console.WriteLine("..........................................");
                Console.WriteLine("..........................................");
                Console.WriteLine("..........................................");
                Console.WriteLine("..........................................");
                Console.WriteLine("..........................................");
                Console.WriteLine("..........................................");
                Console.WriteLine("..........................................");
                Console.WriteLine("Oh une fin cachée!!");
                Console.WriteLine("");
                Console.WriteLine("Si tu as gagné (Appuyer sur 1)");
                Console.WriteLine("");
                Console.WriteLine("Si tu as perdu (Appuyer sur 2)");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                choix10 = Convert.ToInt32(Console.ReadLine());
            }

            if (5 == laChance2 && 1 == choix10)
            {
                Console.WriteLine("Félicitation pour avoir fini mon jeu trop facile et pas très original,désolé");
                Console.WriteLine("");
                Console.WriteLine("Créer par Marco Alias Le Nouare");
            }
            else if (5 == laChance2 && 2 == choix2)
            {
                Console.WriteLine("Une de perdue dix de retrouvée comme on dit et pas de félicitation pour avoir perdue à mon jeu trop facile et pas très originale,désolé");
                Console.WriteLine("");
                Console.WriteLine("Créer par Marco Alias Le Nouare");
            }



            Console.ReadKey();


            //FIN
        }
    }
}
