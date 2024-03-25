using System;
using System.IO;
using System.Media;
using System.Numerics;




namespace AmusmentwithFigures
{
    internal class Program
    {
        //Makes it so the values of stats are 0 whenever the program is ran
        static long numbercount = 0;
        static long totalnumbers = 0;
        static long smallnumber = 0;
        static long bignumber = 0;
        static long coordsplotted = 0;
        static long eggs = 0;
        static long mt = 0;
        static long boron = 0;
        static long fourtwenty = 0;
        static string errorskull = @"      NO!                          MNO!
     MNO!!         [NBK]          MNNOO!
   MMNO!                           MNNOO!!
 MNOONNOO!   MMMMMMMMMMPPPOII!   MNNO!!!!
 !O! NNO! MMMMMMMMMMMMMPPPOOOII!! NO!
       ! MMMMMMMMMMMMMPPPPOOOOIII! !
        MMMMMMMMMMMMPPPPPOOOOOOII!!
        MMMMMOOOOOOPPPPPPPPOOOOMII!
        MMMMM..    OPPMMP    .,OMI!
        MMMM::   o.,OPMP,.o   ::I!!
          NNM:::.,,OOPM!P,.::::!!
         MMNNNNNOOOOPMO!!IIPPO!!O!
         MMMMMNNNNOO:!!:!!IPPPPOO!
          MMMMMNNOOMMNNIIIPPPOO!!
             MMMONNMMNNNIIIOO!
           MN MOMMMNNNIIIIIO! OO
          MNO! IiiiiiiiiiiiI OOOO
     NNN.MNO!   O!!!!!!!!!O   OONO NO!
    MNNNNNO!    OOOOOOOOOOO    MMNNON!
      MNNNNO!    PPPPPPPPP    MMNON!
         OO!                   ON!";


        static void SaveStats()
        {
            //Creates a txt file outside the program to save stats even after the program is closed
            StreamWriter coolFile = File.CreateText("stats.txt");
            coolFile.WriteLine(numbercount);
            coolFile.WriteLine(totalnumbers);
            coolFile.WriteLine(smallnumber);
            coolFile.WriteLine(bignumber);
            coolFile.WriteLine(coordsplotted);
            coolFile.WriteLine(eggs);
            coolFile.WriteLine(mt);
            coolFile.WriteLine(fourtwenty);
            coolFile.Close();
        }
        //read the stats file than adds values to the different variables
        static void ReadStats()
        {
            if (!File.Exists("stats.txt"))
            {
                return;
            }
            StreamReader coolFile = File.OpenText("stats.txt");
            numbercount = int.Parse(coolFile.ReadLine());
            totalnumbers = int.Parse(coolFile.ReadLine());
            smallnumber = int.Parse(coolFile.ReadLine());
            bignumber = int.Parse(coolFile.ReadLine());
            coordsplotted = int.Parse(coolFile.ReadLine());
            eggs = int.Parse(coolFile.ReadLine());
            mt = int.Parse(coolFile.ReadLine());
            boron = int.Parse(coolFile.ReadLine());
            coolFile.Close();
        }
        static void Main(string[] args)
        {
            ReadStats();
            bool exit = false;
            while (!exit)
            {
                //MAIN MENU:

                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Welcome to Amusment with Figures");
                Console.WriteLine("Choose from the menu below:");
                Console.WriteLine(" (A) Check number features");
                Console.WriteLine(" (B) Plot numbers");
                Console.WriteLine(" (C) Check overall stats");
                Console.WriteLine(" (D) Fun with eggs");
                Console.WriteLine();
                Console.WriteLine(" (E) Credits");
                Console.WriteLine(" (X) Save and exit");
                Console.Write("Choice: ");

                string choice = Console.ReadLine().ToUpper();

                //Opens new method based on users choice
                // If user inputs A, opens  Number Feature
                if (choice == "A")
                {
                    NumberFeatures();
                }
                // If user inputs B, opens Plotter
                else if (choice == "B")
                {
                    Plotter();
                }
                // If user inputs C, opens  Stats
                else if (choice == "C")
                {
                    Stats();
                }
                else if (choice == "E")
                {
                    Credits();
                }
                // If user inputs X, closes and saves Fun with Numbers
                else if (choice == "X")
                {
                    SaveStats();
                    Environment.Exit(0);
                }
                else if (choice == "D")
                {
                    Eggcelent();
                }
                else if (choice == "MATTHEW")
                {
                    Console.Clear();
                    SoundPlayer sounds = new SoundPlayer("zelda.wav");
                    sounds.Load();
                    sounds.Play();
                    Console.WriteLine("You are right, he is cool");
                    if (mt < 1)
                    {
                        eggs++;
                    }
                    mt++;
                    Console.ReadKey();
                }
                else if (choice == "CAYDEN")
                {
                    Console.Clear();
                    Console.WriteLine("Cayden smells doesn't he");
                    Console.Write("Press X to stop: ");
                    SoundPlayer sounds = new SoundPlayer("cayden.wav");
                    sounds.Load();
                    sounds.Play();
                    if (boron < 1)
                    {
                        eggs++;
                    }
                    boron++;
                    string mute = Console.ReadLine().ToUpper();
                    if (mute == "X")
                    {
                        sounds.Stop();
                    }
                    Console.ReadKey();
                }
            }

        }
        //Everything under changes to the different options
        static void NumberFeatures()
        {
            Console.Clear();
            Console.Write("Please enter a whole number that will be checked over: ");
            Int64 isNumber = 0;
            // Handles errors if input is a letter or over the in32 limit
            try
            { 
                 isNumber = Int64.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                SoundPlayer sounds = new SoundPlayer("error.wav");
                sounds.Load();
                sounds.Play();
                Console.WriteLine("Error 2564: Input was not a whole number or was over 32 bits");
                Console.WriteLine(errorskull);
                Console.WriteLine();
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                return;
            };
            Int64 number = isNumber;
            if (number == 420)
            {

                Console.Clear();
                Console.WriteLine("Drugs are bad. Only good drug is");
                SoundPlayer sounds = new SoundPlayer("zelda.wav");
                sounds.Load();
                sounds.Play();
                Console.WriteLine("                                                                                  dddddddd                         ");
                Console.WriteLine("PPPPPPPPPPPPPPPPP                                                                 d::::::d                 lllllll ");
                Console.WriteLine("P::::::::::::::::P                                                                d::::::d                 l:::::l ");
                Console.WriteLine("P::::::PPPPPP:::::P                                                               d::::::d                 l:::::l");
                Console.WriteLine("PP:::::P     P:::::P                                                              d:::::d                  l:::::l ");
                Console.WriteLine("  P::::P     P:::::Paaaaaaaaaaaaa  nnnn  nnnnnnnn      aaaaaaaaaaaaa      ddddddddd:::::d    ooooooooooo    l::::l ");
                Console.WriteLine("  P::::P     P:::::Pa::::::::::::a n:::nn::::::::nn    a::::::::::::a   dd::::::::::::::d  oo:::::::::::oo  l::::l ");
                Console.WriteLine("  P::::PPPPPP:::::P aaaaaaaaa:::::an::::::::::::::nn   aaaaaaaaa:::::a d::::::::::::::::d o:::::::::::::::o l::::l ");
                Console.WriteLine("  P:::::::::::::PP           a::::ann:::::::::::::::n           a::::ad:::::::ddddd:::::d o:::::ooooo:::::o l::::l ");
                Console.WriteLine("  P::::PPPPPPPPP      aaaaaaa:::::a  n:::::nnnn:::::n    aaaaaaa:::::ad::::::d    d:::::d o::::o     o::::o l::::l ");
                Console.WriteLine("  P::::P            aa::::::::::::a  n::::n    n::::n  aa::::::::::::ad:::::d     d:::::d o::::o     o::::o l::::l ");
                Console.WriteLine("  P::::P            aa::::::::::::a  n::::n    n::::n  aa::::::::::::ad:::::d     d:::::d o::::o     o::::o l::::l ");
                Console.WriteLine("  P::::P          a::::a    a:::::a  n::::n    n::::na::::a    a:::::ad:::::d     d:::::d o::::o     o::::o l::::l ");
                Console.WriteLine("PP::::::PP        a::::a    a:::::a  n::::n    n::::na::::a    a:::::ad::::::ddddd::::::ddo:::::ooooo:::::ol::::::l");
                Console.WriteLine("P::::::::P        a:::::aaaa::::::a  n::::n    n::::na:::::aaaa::::::a d:::::::::::::::::do:::::::::::::::ol::::::l");
                Console.WriteLine("P::::::::P         a::::::::::aa:::a n::::n    n::::n a::::::::::aa:::a d:::::::::ddd::::d oo:::::::::::oo l::::::l");
                Console.WriteLine("PPPPPPPPPP          aaaaaaaaaa  aaaa nnnnnn    nnnnnn  aaaaaaaaaa  aaaa  ddddddddd   ddddd   ooooooooooo   llllllll");
                Console.WriteLine();
                Console.WriteLine("Also if you wanted to know:");

                if (fourtwenty < 1)
                {
                    eggs++;
                }
                fourtwenty++;
                Console.ReadKey();
            }
            Console.WriteLine();
            Console.WriteLine($"The features of {number} are...");
            Console.WriteLine(number > 0 ? " Positive" : (number < 0 ? " Negative" : " Zero"));
            Console.WriteLine(number % 2 == 0 ? " Even" : " Odd");
            //Determines factors and if the number is a Prime or not
            Console.Write(" Factors are");
            int primeCount = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(" " + i);
                    primeCount++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(primeCount == 2 ? " Is a prime" : " Is not a prime");
            //Calculates numbercount, totalnumbers, bignumbers and small numbers
            if (numbercount == 0)
            {
                smallnumber = number;
                bignumber = number;

            }
            else
            {
                if (number < smallnumber)
                {
                    smallnumber = number;
                }
                else if (number > bignumber)
                {
                    bignumber = number;
                }
            }
            numbercount++;
            totalnumbers += number;
            Console.ReadKey();
        }
        static void Plotter()
        //the actual plot
        {
            Console.Clear();
            Console.WriteLine("                                                    x axis");
            Console.WriteLine("      1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38");
            Console.WriteLine("   --------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("  1|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  2|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  3|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  4|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("y 5|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("a 6|                                                                                                                  |");
            Console.WriteLine("x  |                                                                                                                  |");
            Console.WriteLine("i 7|                                                                                                                  |");
            Console.WriteLine("s  |                                                                                                                  |");
            Console.WriteLine("  8|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine("  9|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine(" 10|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine(" 11|                                                                                                                  |");
            Console.WriteLine("   |                                                                                                                  |");
            Console.WriteLine(" 12|                                                                                                                  |");
            Console.WriteLine("   --------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Enter a coordinate below to be added to the plot:");

            //user input for plot
            bool exit = false;
            while (!exit)
            {
                Console.Write("x axis:");
                int test1 = 0; 
                //tests for a whole number
                try
                {
                    test1 = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    SoundPlayer sounds = new SoundPlayer("error.wav");
                    sounds.Load();
                    sounds.Play();
                    Console.Write("Error 420: Input was not a whole number between 1-38 or was over 32 bits.");
                    Console.WriteLine();
                    Console.WriteLine(errorskull);
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                };

                int xAxis = test1;

                if (xAxis >= 1 && xAxis <= 38)
                {
                    Console.Write("y axis:");
                    int test2 = 0;
                    try
                    {
                        test2 = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        SoundPlayer sounds = new SoundPlayer("error.wav");
                        sounds.Load();
                        sounds.Play();
                        Console.Write("Error 420: Input was not a whole number between 1-12 or was over 32 bits.");
                        Console.WriteLine();
                        Console.WriteLine(errorskull);
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.White;
                        return;
                    };

                    int yAxis = test2;

                    if (yAxis >= 1 && yAxis <= 12)
                    //Sets where the x will go on the plot
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.SetCursorPosition(3 + xAxis * 3, 1 + yAxis * 2);
                        Console.Write("x");
                        Console.SetCursorPosition(0, 27);
                        // Clears the last three lines for next input for the plot
                        Console.WriteLine("                                                                        ");
                        Console.WriteLine("          ");
                        Console.WriteLine("          ");
                        Console.SetCursorPosition(0, 27);
                        coordsplotted++;
                        //runs exit msg for plotter
                        Console.Write("Do you wish to add another corrdinate (y/n)? ");
                        string exitorno = Console.ReadLine().ToUpper();
                        if (exitorno == "N" || exitorno == "no")
                        {
                            exit = true;
                        }
                        //resets cursor for net point 
                        else if (exitorno == "Y")
                        {
                            Console.SetCursorPosition(0, 27);
                            Console.WriteLine("                                                      ");
                            Console.SetCursorPosition(0, 27);
                        }
                        else
                        {
                            Console.SetCursorPosition(0, 27);
                            Console.WriteLine("                                                      ");
                            Console.SetCursorPosition(0, 27);
                        }
                        if (yAxis > 12)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            SoundPlayer sounds = new SoundPlayer("error.wav");
                            sounds.Load();
                            sounds.Play();
                            Console.Write("Error 420: Input was not a whole number between 1-12 or was over 32 bits.");
                            Console.WriteLine();
                            Console.WriteLine(errorskull);
                            Console.WriteLine();
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.White;
                            return;
                        }
                        else if (yAxis < 1)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            SoundPlayer sounds = new SoundPlayer("error.wav");
                            sounds.Load();
                            sounds.Play();
                            Console.Write("Error 420: Input was not a whole number between 1-12 or was over 32 bits.");
                            Console.WriteLine();
                            Console.WriteLine(errorskull);
                            Console.WriteLine();
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.White;
                            return;
                        }

                    }
                }
                if (xAxis > 38)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    SoundPlayer sounds = new SoundPlayer("error.wav");
                    sounds.Load();
                    sounds.Play();
                    Console.Write("Error 420: Input was not a whole number between 1-38 or was over 32 bits.");
                    Console.WriteLine();
                    Console.WriteLine(errorskull);
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                if (xAxis < 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    SoundPlayer sounds = new SoundPlayer("error.wav");
                    sounds.Load();
                    sounds.Play();
                    Console.Write("Error 420: Input was not a whole number between 1-38 or was over 32 bits.");
                    Console.WriteLine();
                    Console.WriteLine(errorskull);
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
            Console.SetCursorPosition(0, 27);
            Console.WriteLine("Press enter to return to the menu...          ");
            Console.ReadKey();
        }
        static void Eggcelent()
        {
            Console.Clear();
            Console.WriteLine("Clues for easter eggs within the program:");
            if(boron < 1)
            {
                Console.WriteLine(" His last name rhymes with Boron, but what is his first name?");
            }
            if(mt < 1)
            {
                Console.WriteLine(" He is the creator of Amusment with figures, what is his name?");
            }
            if (fourtwenty < 1)
            {
                Console.WriteLine(" This number is the name of a famouse Australian pie company, what is the number?");
            }
            Console.ReadLine();
        }
        static void Stats()
        {
            Console.Clear();
            Console.WriteLine("Here are your statistics of overall use:");
            Console.WriteLine($" Numbers entered: {numbercount}");
            Console.WriteLine($" Total of numbers: {totalnumbers}");
            if (numbercount == 0)
            {
                Console.WriteLine($" Average of numbers: 0");
            }
            else if (numbercount > 1)
            {
                Console.WriteLine($" Average of numbers: {totalnumbers / numbercount}");
            }
            Console.WriteLine($" Smallest number entered: {smallnumber}");
            Console.WriteLine($" Largest number entered: {bignumber}");
            Console.WriteLine($" Coordinates plotted: {coordsplotted}");
            Console.WriteLine($" Easter eggs found: {eggs}");
            Console.ReadKey();
        }
        static void Credits()
        {
            Console.Clear();
            Console.WriteLine("I do not own any of the music and sounds used in this program. Credit goes to the people bellow:");
            Console.WriteLine("Cayden Poop - created by The Odd Man Who Sings About Poop, Puke and Pee June 21, 2019");
            Console.WriteLine("Windows XP Error - Microsft 1975");
            Console.WriteLine("Zelda chest opening - Composed by Koji Kondo 1998");
            Console.WriteLine("");
            Console.WriteLine("These are the Peoples code I took inspiration for parts of my code:");
            Console.WriteLine("Michael Hadley Intro to C#: Extra - SoundPlayer in Console Apps");

            Console.ReadKey();
        }
    }


}