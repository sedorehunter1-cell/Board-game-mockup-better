Console.WriteLine("Choose your order");

string Tower1 = Console.ReadLine();

string Tower2 = Console.ReadLine();

string Tower3 = Console.ReadLine();

Random rnd = new Random();

int Rand1 = rnd.Next(0, 3); 
int Rand2 = rnd.Next(0, 3); 
while (Rand1 == Rand2)
{
    Rand2 = rnd.Next(0, 3);
}
int Rand3 = rnd.Next(0, 3);
while (Rand3 == Rand1 || Rand3 == Rand2)
{
    Rand3 = rnd.Next(0, 3);
}

string Enemy1;

string Enemy2;

string Enemy3;

if (Rand1 == 0)
{
    Enemy1 = "ice";
}
else if (Rand1 == 1)
{
    Enemy1 = "fire";
}
else
{
    Enemy1 = "water";
}
if (Rand2 == 0)
{
    Enemy2 = "ice";
}
else if (Rand2 == 1)
{
    Enemy2 = "fire";
}
else
{
    Enemy2 = "water";
}
if (Rand3 == 0)
{
    Enemy3 = "ice";
}
else if (Rand3 == 1)
{
    Enemy3 = "fire";
}
else
{
    Enemy3 = "water";
}
//0 = ice, 1 = fire, 2 = water

Console.WriteLine(Tower1 + "         " + Tower3);
Console.WriteLine("                    " + Enemy1 + " " + Enemy2 + " " + Enemy3);
Console.WriteLine("     " + Tower2);
Console.WriteLine("-----");

while ((Enemy1 != "dead" && Enemy2 != "dead" && Enemy3 != "dead") || (Tower1 != "dead" && Tower2 != "dead" && Tower3 != "dead") || (Enemy1 != "won") || (Enemy2 != "won") || (Enemy3 != "won"))
{

    if (Enemy1 != "dead")
    {

        if (Enemy1 != Tower3)
        {

            if (Tower3 == "ice")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("             " + Enemy1 + "     " + Enemy2 + " " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy1 == "water")
                {
                    Enemy1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy1);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy1 == "fire")
                {
                    Tower3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("             " + Enemy1 + "     " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }



            }
            else if (Tower3 == "fire")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("             " + Enemy1 + "     " + Enemy2 + " " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy1 == "ice")
                {
                    Enemy1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy1);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy1 == "water")
                {
                    Tower3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("             " + Enemy1 + "     " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
            else if (Tower3 == "water")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("             " + Enemy1 + "     " + Enemy2 + " " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy1 == "fire")
                {
                    Enemy1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy1);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy1 == "ice")
                {
                    Tower3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("             " + Enemy1 + "     " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
        }
        if (Enemy1 != Tower2)
        {

            if (Tower2 == "ice")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("     " + Enemy1 + "             " + Enemy2 + " " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy1 == "water")
                {
                    Enemy1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy2 + "          " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy1);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy1 == "fire")
                {
                    Tower2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("     " + Enemy1 + "             " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
            else if (Tower2 == "fire")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("     " + Enemy1 + "             " + Enemy2 + " " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy1 == "ice")
                {
                    Enemy1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy2 + "          " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy1);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy1 == "water")
                {
                    Tower2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("     " + Enemy1 + "             " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
            else if (Tower2 == "water")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("     " + Enemy1 + "             " + Enemy2 + " " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy1 == "fire")
                {
                    Enemy1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy2 + "          " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy1);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy1 == "ice")
                {
                    Tower2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("     " + Enemy1 + "             " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
        }
        if (Enemy1 != Tower1)
        {

            if (Tower1 == "ice")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine(Enemy1 + "                       " + Enemy2 + " " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy1 == "water")
                {
                    Enemy1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy1);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy1 == "fire")
                {
                    Tower1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine(Enemy1 + "                       " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    Enemy1 = "won";

                    break;
                }
            }
            else if (Tower1 == "fire")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine(Enemy1 + "                       " + Enemy2 + " " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy1 == "ice")
                {
                    Enemy1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy1);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy1 == "water")
                {
                    Tower1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine(Enemy1 + "                       " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    Enemy1 = "won";

                    break;
                }
            }
            else if (Tower1 == "water")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine(Enemy1 + "                       " + Enemy2 + " " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy1 == "fire")
                {
                    Enemy1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy1);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy1 == "ice")
                {
                    Tower1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine(Enemy1 + "                       " + Enemy2 + " " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    Enemy1 = "won";

                    break;
                }
            }
        }
        if (Enemy1 == Tower1)
        {
            Enemy1 = "won";
            Console.WriteLine(Tower1 + "         " + Tower3);
            Console.WriteLine(Enemy1 + "                       " + Enemy2 + " " + Enemy3);
            Console.WriteLine("     " + Tower2);
            Console.WriteLine("-----");

            break;
        }
    }

    if (Enemy2 != "dead")
    {

        if (Enemy2 != Tower3)
        {

            if (Tower3 == "ice")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("             " + Enemy2 + "     " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy2 == "water")
                {
                    Enemy2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy2);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy2 == "fire")
                {
                    Tower3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("             " + Enemy2 + "     " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }



            }
            else if (Tower3 == "fire")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("             " + Enemy2 + "     " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy2 == "ice")
                {
                    Enemy2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy2);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy2 == "water")
                {
                    Tower3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("             " + Enemy2 + "     " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
            else if (Tower3 == "water")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("             " + Enemy2 + "     " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy2 == "fire")
                {
                    Enemy2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy2);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy2 == "ice")
                {
                    Tower3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("             " + Enemy2 + "     " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
        }
        if (Enemy2 != Tower2)
        {

            if (Tower2 == "ice")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("     " + Enemy2 + "             " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy2 == "water")
                {
                    Enemy2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy2);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy2 == "fire")
                {
                    Tower2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("     " + Enemy2 + "             " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
            else if (Tower2 == "fire")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("     " + Enemy2 + "             " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy2 == "ice")
                {
                    Enemy2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy2);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy2 == "water")
                {
                    Tower2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("     " + Enemy2 + "             " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
            else if (Tower2 == "water")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("     " + Enemy2 + "             " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy2 == "fire")
                {
                    Enemy2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy2);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy2 == "ice")
                {
                    Tower2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("     " + Enemy2 + "             " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
        }
        if (Enemy2 != Tower1)
        {

            if (Tower1 == "ice")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine(Enemy2 + "                       " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy2 == "water")
                {
                    Enemy2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy2);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy2 == "fire")
                {
                    Tower1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine(Enemy2 + "                       " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    Enemy2 = "won";

                    break;
                }
            }
            else if (Tower1 == "fire")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine(Enemy2 + "                       " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy2 == "ice")
                {
                    Enemy2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy2);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy2 == "water")
                {
                    Tower1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine(Enemy2 + "                       " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    Enemy2 = "won";

                    break;
                }
            }
            else if (Tower1 == "water")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine(Enemy2 + "                       " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy2 == "fire")
                {
                    Enemy2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("                      " + Enemy3);
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy2);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy2 == "ice")
                {
                    Tower1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine(Enemy2 + "                       " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    Enemy2 = "won";

                    break;
                }
            }
        }

        if (Enemy2 == Tower1)
        {
            Enemy2 = "won";
            Console.WriteLine(Tower1 + "         " + Tower3);
            Console.WriteLine(Enemy2 + "                       " + Enemy3);
            Console.WriteLine("     " + Tower2);
            Console.WriteLine("-----");

            break;
        }
    }

    if (Enemy3 != "dead")
    {

        if (Enemy3 != Tower3)
        {

            if (Tower3 == "ice")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("             " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy3 == "water")
                {
                    Enemy3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine();
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy3);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy3 == "fire")
                {
                    Tower3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("             " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }



            }
            else if (Tower3 == "fire")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("             " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy3 == "ice")
                {
                    Enemy3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine();
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy3);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy3 == "water")
                {
                    Tower3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("             " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
            else if (Tower3 == "water")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("             " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy3 == "fire")
                {
                    Enemy3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine();
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy3);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy3 == "ice")
                {
                    Tower3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("             " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
        }
        if (Enemy3 != Tower2)
        {

            if (Tower2 == "ice")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("     " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy3 == "water")
                {
                    Enemy3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine();
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy3);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy3 == "fire")
                {
                    Tower2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("     " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
            else if (Tower2 == "fire")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("     " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy3 == "ice")
                {
                    Enemy3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine();
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy3);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy3 == "water")
                {
                    Tower2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("     " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
            else if (Tower2 == "water")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine("     " + Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy3 == "fire")
                {
                    Enemy3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine();
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy3);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy3 == "ice")
                {
                    Tower2 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine("     " + Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    continue;
                }
            }
        }
        if (Enemy3 != Tower1)
        {

            if (Tower1 == "ice")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine(Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy3 == "water")
                {
                    Enemy3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine();
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy3);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy3 == "fire")
                {
                    Tower1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine(Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    Enemy3 = "won";

                    break;
                }
            }
            else if (Tower1 == "fire")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine(Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy3 == "ice")
                {
                    Enemy3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine();
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy3);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy3 == "water")
                {
                    Tower1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine(Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    Enemy3 = "won";

                    break;
                }
            }
            else if (Tower1 == "water")
            {

                Console.WriteLine(Tower1 + "         " + Tower3);
                Console.WriteLine(Enemy3);
                Console.WriteLine("     " + Tower2);
                Console.WriteLine("-----");

                if (Enemy3 == "fire")
                {
                    Enemy3 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine();
                    Console.WriteLine("     " + Tower2 + "                                 " + Enemy3);
                    Console.WriteLine("-----");

                    continue;
                }

                else if (Enemy3 == "ice")
                {
                    Tower1 = "dead";

                    Console.WriteLine(Tower1 + "         " + Tower3);
                    Console.WriteLine(Enemy3);
                    Console.WriteLine("     " + Tower2);
                    Console.WriteLine("-----");

                    Enemy3 = "won";

                    break;
                }
            }
        }
        if (Enemy3 == Tower1)
        {
            Enemy3 = "won";
            Console.WriteLine(Tower1 + "         " + Tower3);
            Console.WriteLine(Enemy3);
            Console.WriteLine("     " + Tower2);
            Console.WriteLine("-----");
            break;
        }
    }
    break;
}

if ((Tower1 == "dead" && Tower2 == "dead" && Tower3 == "dead") || (Enemy1 == "won") || (Enemy2 == "won") || (Enemy3 == "won"))
{
    Console.WriteLine("You lost!");
}
else
{
    Console.WriteLine("You won!");
}