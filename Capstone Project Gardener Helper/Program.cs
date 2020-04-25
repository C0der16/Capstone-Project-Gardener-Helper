using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Capstone_Project_Gardener_Helper
{

    // ****************************************************
    //
    // Title: Gardener Helper
    // Description: A helpful tool for gardeners looking for more information
    // Application Type: Console
    // Author: Thurman, Seth
    // Dated Created: 4/12/2020
    // Last Modified: 4/24/2020
    //
    // *****************************************************

    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Vegitable> vegitables = InitializeVegitableList();

            DisplayTheme();
            DisplayIntro();
            DisplayMenu(vegitables);
        }

        /// <summary>
        /// Intializing The list of Vegitables
        /// </summary>
        /// <returns></returns>
        static List<Vegitable> InitializeVegitableList()
        {

            List<Vegitable> vegitables = new List<Vegitable>( )
            {
                new Vegitable()
                {
                    Name = "basil",
                    Spacing = 10,
                    SeedDepth = 0.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6,
                    PlantTime = "can start indoors before last frost or wait until soil has warmed"
                },
                new Vegitable()
                {
                    Name = "beans",
                    Spacing = 7,
                    SeedDepth = 1,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.75,
                    PlantTime = "after last frost and soil has warmed"
                },
                new Vegitable()
                {
                    Name = "beet",
                    Spacing = 4,
                    SeedDepth = 0.5,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.75,
                    PlantTime = "as soon as the ground can be worked. can also be fall planted"
                },
                new Vegitable()
                {
                    Name = "broccoli",
                    Spacing = 10,
                    SeedDepth = 0.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "indoors before frost or outdoors after last frost"
                },
                new Vegitable()
                {
                    Name = "cabbage",
                    Spacing = 27,
                    SeedDepth = 0.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.75,
                    PlantTime = "indoors before last frost or outside after last frost"
                },
                new Vegitable()
                {
                    Name = "cantaloupe",
                    Spacing = 66,
                    SeedDepth = 1,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "after last frost"
                },
                new Vegitable()
                {
                    Name = "carrot",
                    Spacing = 2,
                    SeedDepth = 0.5,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.25,
                    PlantTime = "early spring. can also be fall planted"
                },
                new Vegitable()
                {
                    Name = "cauliflower",
                    Spacing = 27,
                    SeedDepth = 0.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "indoors before last frost or outside after last frost"
                },
                new Vegitable()
                {
                    Name = "celery",
                    Spacing = 8,
                    SeedDepth = 0.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "indoors before last frost"
                },
                new Vegitable()
                {
                    Name = "chives",
                    Spacing = 4,
                    SeedDepth = 0.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "indoors before last frost or outside as soon as soil can be worked"
                },
                new Vegitable()
                {
                    Name = "corn",
                    Spacing = 7,
                    SeedDepth = 1.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.25,
                    PlantTime = "when soil is at least 65 degrees F"
                },
                new Vegitable()
                {
                    Name = "cucumber",
                    Spacing = 36,
                    SeedDepth = 0.5,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "outside after last frost"
                },
                new Vegitable()
                {
                    Name = "garlic",
                    Spacing = 8,
                    SeedDepth = 1.5,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "mid autumn"
                },
                new Vegitable()
                {
                    Name = "kale",
                    Spacing = 9,
                    SeedDepth = 0.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.75,
                    PlantTime = "early spring. can be fall planted"
                },
                new Vegitable()
                {
                    Name = "lavender",
                    Spacing = 24,
                    SeedDepth = 0.125,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6,
                    PlantTime = "indoors at least 1 month before last frost"
                },
                new Vegitable()
                {
                    Name = "lettuce",
                    Spacing = 10,
                    SeedDepth = 0.125,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "early spring. can also be fall planted"
                },
                new Vegitable()
                {
                    Name = "onion",
                    Spacing = 6,
                    SeedDepth = 0.125,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "indoors 4 - 6 weeks before transplanting"
                },
                new Vegitable()
                {
                    Name = "oregano",
                    Spacing = 8,
                    SeedDepth = 0.125,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 7,
                    PlantTime = "after last frost when soil has reached 70 degrees F"
                },
                new Vegitable()
                {
                    Name = "parsley",
                    Spacing = 8,
                    SeedDepth = 0.125,
                    AmmountOfSun = Vegitable.Sun.partsun,
                    Ph = 6,
                    PlantTime = "indoors 3 - 4 weeks before last frost"
                },
                new Vegitable()
                {
                    Name = "pea",
                    Spacing = 2,
                    SeedDepth = 1,
                    AmmountOfSun = Vegitable.Sun.partsun,
                    Ph = 6.75,
                    PlantTime = "as soon as soil can be worked"
                },
                new Vegitable()
                {
                    Name = "pepper",
                    Spacing = 14,
                    SeedDepth = 0.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.25,
                    PlantTime = "indoors before last frost"
                },
                new Vegitable()
                {
                    Name = "potatoes",
                    Spacing = 30,
                    SeedDepth = 3,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 5.25,
                    PlantTime = "as soon as ground can be worked"
                },
                new Vegitable()
                {
                    Name = "pumpkin",
                    Spacing = 36,
                    SeedDepth = 1,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "wait for soil to be 70F"
                },
                new Vegitable()
                {
                    Name = "spinach",
                    Spacing = 1,
                    SeedDepth = 0.5,
                    AmmountOfSun = Vegitable.Sun.partsun,
                    Ph = 6.75,
                    PlantTime = "early spring. can also be fall planted"
                },
                new Vegitable()
                {
                    Name = "squash",
                    Spacing = 60,
                    SeedDepth = 1,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6,
                    PlantTime = "after last frost"
                },
                new Vegitable()
                {
                    Name = "radish",
                    Spacing = 2,
                    SeedDepth = 0.5,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "early spring. can also be fall planted"
                },
                new Vegitable()
                {
                    Name = "rosemary",
                    Spacing = 36,
                    SeedDepth = 0,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 5.5,
                    PlantTime = "when soil is around 70 degrees F"
                },
                new Vegitable()
                {
                    Name = "sage",
                    Spacing = 24,
                    SeedDepth = 0.125,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6,
                    PlantTime = "up to 2 weeks before last frost"
                },
                new Vegitable()
                {
                    Name = "tomato",
                    Spacing = 24,
                    SeedDepth = 0.25,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "indoors before last frost, then transplant"
                },
                new Vegitable()
                {
                    Name = "watermelon",
                    Spacing = 66,
                    SeedDepth = 0.75,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.5,
                    PlantTime = "after last frost"
                },
                new Vegitable()
                {
                    Name = "zucchini",
                    Spacing = 36,
                    SeedDepth = 0.75,
                    AmmountOfSun = Vegitable.Sun.fullsun,
                    Ph = 6.75,
                    PlantTime = "late spring or early summer"
                },
            };

            return vegitables;
        }

        /// <summary>
        /// Shows the Intro to the app
        /// </summary>
        static void DisplayIntro()
        {
            int pause = 500;


            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                |                ");

            System.Threading.Thread.Sleep(pause); //https://stackoverflow.com/questions/55657216/c-sharp-console-app-how-to-make-the-program-wait-time-in-ms-before-executi 
            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("               \\ /              ");
            Console.WriteLine("                |                ");

            System.Threading.Thread.Sleep(pause);

            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("               \\|/              ");
            Console.WriteLine("                |                ");

            System.Threading.Thread.Sleep(pause);

            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                |                ");
            Console.WriteLine("               \\|/              ");
            Console.WriteLine("                |                ");

            System.Threading.Thread.Sleep(pause);

            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                |                ");
            Console.WriteLine("                |                ");
            Console.WriteLine("               \\|/              ");
            Console.WriteLine("                |                ");

            System.Threading.Thread.Sleep(pause);

            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("               \\|               ");
            Console.WriteLine("                |                ");
            Console.WriteLine("               \\|/              ");
            Console.WriteLine("                |                ");

            System.Threading.Thread.Sleep(pause);

            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                |/               ");
            Console.WriteLine("               \\|               ");
            Console.WriteLine("                |                ");
            Console.WriteLine("               \\|/              ");
            Console.WriteLine("                |                ");

            System.Threading.Thread.Sleep(pause);

            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("              _ |/               ");
            Console.WriteLine("              \\\\|              ");
            Console.WriteLine("                |                ");
            Console.WriteLine("               \\|/              ");
            Console.WriteLine("                |                ");

            System.Threading.Thread.Sleep(pause);
            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                O                ");
            Console.WriteLine("              _ |/               ");
            Console.WriteLine("              \\\\|              ");
            Console.WriteLine("                |                ");
            Console.WriteLine("               \\|/              ");
            Console.WriteLine("                |                ");


            System.Threading.Thread.Sleep(pause);
            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                _                ");
            Console.WriteLine("               (O)               ");
            Console.WriteLine("              _ |/               ");
            Console.WriteLine("              \\\\|              ");
            Console.WriteLine("                |                ");
            Console.WriteLine("               \\|/              ");
            Console.WriteLine("                |                ");


            System.Threading.Thread.Sleep(pause);
            Console.Clear();

            Console.WriteLine("                                 ");
            Console.WriteLine("          Garder Helper          ");
            Console.WriteLine("                                 ");
            Console.WriteLine("               OOO               ");
            Console.WriteLine("              O O O              ");
            Console.WriteLine("               OOO               ");
            Console.WriteLine("              _ |/               ");
            Console.WriteLine("              \\\\|              ");
            Console.WriteLine("                |                ");
            Console.WriteLine("               \\|/              ");
            Console.WriteLine("                |                ");

            System.Threading.Thread.Sleep(pause * 3);

        }

        /// <summary>
        /// The apps menu
        /// </summary>
        /// <param name="vegitables"></param>
        static void DisplayMenu(List<Vegitable> vegitables)
        {
            ConsoleKeyInfo menuChoiceKey;
            char menuChoice;
            bool quitApplication = false;

            do
            {

                DisplayScreenHeader("Garden Helper Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Vegitables/Herbs Information");
                Console.WriteLine("\tb) Ph Calculator");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");

                menuChoiceKey = Console.ReadKey();
                menuChoice = menuChoiceKey.KeyChar;
                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case 'a':
                        DisplaySearchForVegitables(vegitables);
                        break;

                    case 'b':
                        DisplayPhCalculator();
                        break;

                    case 'q':
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }

        #region VEGITABLE/HERB INFORMATION
        /// <summary>
        /// Main Method for asking and then Searching for vegitable details
        /// </summary>
        /// <param name="vegitables"></param>
        static void DisplaySearchForVegitables(List<Vegitable> vegitables)
        {
            bool exit;

            do
            {



                string name = SearchVegitables(vegitables);

                if (name != "exit")
                {
                    Vegitable vegitable = vegitables.FirstOrDefault(v => v.Name == name);


                    DisplayVegitableInfo(vegitable);

                    DisplayContinuePrompt();

                    exit = false;
                }
                else
                {
                    exit = true;
                }


            } while (!exit);




            DisplayContinuePrompt();

        }

        /// <summary>
        /// Searching for Vegitable
        /// </summary>
        /// <param name="vegitables"></param>
        /// <returns></returns>
        static string SearchVegitables(List<Vegitable> vegitables)
        {
            bool validName = false;
            string userInput;

            List<string> validVegitableNames = vegitables.Select(v => v.Name).ToList();

            do
            {
                DisplayScreenHeader("Vegitable Search");
                DisplayListOfVegitables(vegitables);

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Please enter a Vegitable from above that you would like information about or if you would like to exit type \"exit\"");
                userInput = Console.ReadLine().ToLower();

                if (validVegitableNames.Contains(userInput) || userInput == "exit")
                {
                    validName = true;
                }

                else
                {
                    DisplayInvalidResponse();
                }

            } while (!validName);
            

            return userInput;
        }

        /// <summary>
        /// Displaying the list of Vegitables availible
        /// </summary>
        /// <param name="vegitables"></param>
        static void DisplayListOfVegitables(List<Vegitable> vegitables)
        {
            int itemCount = 1;



            foreach (Vegitable vegitable in vegitables)
            {
                Console.Write($"-" + vegitable.Name);

                if (itemCount % 5 == 0)
                {
                    Console.WriteLine("\n");
                }
                itemCount++;
            }

        }

        /// <summary>
        /// Displaying the Vegitable Information
        /// </summary>
        /// <param name="vegitable"></param>
        static void DisplayVegitableInfo(Vegitable vegitable)
        {
            string vegTips;

            DisplayScreenHeader($"{vegitable.Name}'s Information");

            Console.WriteLine($"Spacing: {vegitable.Spacing} inches");
            Console.WriteLine($"Seed Depth: {vegitable.SeedDepth} inches");
            Console.WriteLine($"Ammount of Sun: {vegitable.AmmountOfSun}");
            Console.WriteLine($"Preffered Ph: {vegitable.Ph}");
            Console.WriteLine($"When To Plant: {vegitable.PlantTime}");
            Console.WriteLine();

            vegTips = DisplayGetVegitableTips(vegitable.Name);

            Console.WriteLine($"Extra Tips: " +vegTips);
            
         
        }

        /// <summary>
        /// Getting the extra Vegitable tips
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static string DisplayGetVegitableTips(string name)
        {
            string vegTips = "";

            List<(string name, string tips)> vegInfoTips = new List<(string name, string tips)>();


            vegInfoTips = DisplayReadVegitableTips();

            foreach ((string name, string tips) tipsInfo in vegInfoTips)
            {
                if (tipsInfo.name == name)
                {
                    vegTips = tipsInfo.tips;
                }
            }

            return vegTips;
        }

        /// <summary>
        /// Reading the Text file
        /// </summary>
        /// <returns></returns>
        static List<(string name, string tips)> DisplayReadVegitableTips()
        {
            string dataPath = @"Vegitable Data/Tips.txt";

            string[] vegInfoArray;
            (string name, string tips) vegInfoTuple;

            List<(string name, string tips)> vegInfoTips = new List<(string name, string tips)>();

            vegInfoArray = File.ReadAllLines(dataPath);
            
            foreach (string vegInfoText in vegInfoArray)
            {
                vegInfoArray = vegInfoText.Split(',');

                vegInfoTuple.name = vegInfoArray[0];
                vegInfoTuple.tips = vegInfoArray[1];

                vegInfoTips.Add(vegInfoTuple);
            }


            return vegInfoTips;


        }
        
        #endregion

        #region pH CALCULATOR
        /// <summary>
        /// Displaying the Ph Calculator
        /// </summary>
        static void DisplayPhCalculator()
        {
            string userInput;
            double currentPh;
            double goalPh;
            int squareFeetOfLand;
            bool valid;
            string soilType;

            // getting soil type
            do
            {
                valid = true;

                DisplayScreenHeader("Ph Calculator");

                Console.WriteLine("Please enter your soil type, either \"sand\", \"clay\", or \"loam\"");
                soilType = Console.ReadLine().ToLower();

                if (soilType == "sand" || soilType == "clay" || soilType == "loam")
                {
                    valid = true;
                }
                else
                {
                    DisplayInvalidResponse();
                    valid = false;
                }

            } while (!valid);
            // getting current and goal ph
            do
            {
                valid = true;
                DisplayScreenHeader("Ph Calculator");

                // getting the users current PH
                do
                {
                    DisplayScreenHeader("Ph Calculator");

                    valid = true;

                    Console.WriteLine("enter your current Ph for your area 1-14");
                    userInput = Console.ReadLine().ToLower();

                    if (!double.TryParse(userInput, out currentPh))
                    {
                        valid = false;
                        DisplayInvalidResponse();
                    }
                    if (currentPh < 0 || currentPh > 14)
                    {
                        valid = false;
                        DisplayInvalidResponse();
                    }
                } while (!valid);
                // getting the users goal Ph
                do
                {
                    DisplayScreenHeader("Ph Calculator");

                    valid = true;

                    Console.WriteLine("enter your goal Ph 1-14");
                    userInput = Console.ReadLine().ToLower();

                    if (!double.TryParse(userInput, out goalPh))
                    {
                        valid = false;
                        DisplayInvalidResponse();
                    }
                    if (goalPh < 0 || goalPh > 14)
                    {
                        valid = false;
                        DisplayInvalidResponse();
                    }
                } while (!valid);        

                // if goal and current are the same
                if(goalPh - currentPh == 0)
                {
                    valid = false;
                    Console.WriteLine("Please make sure your goal Ph and current Ph aren not the same");
                    Console.WriteLine();
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                }


            } while (!valid);

            // getting the size of the users land
            do
            {
                DisplayScreenHeader("Ph Calculator");

                valid = true;

                Console.WriteLine("Now enter the size of the area you want changed in square feet");
                userInput = Console.ReadLine().ToLower();

                if (!int.TryParse(userInput, out squareFeetOfLand))
                {
                    valid = false;
                    DisplayInvalidResponse();
                }
                if (squareFeetOfLand < 0)
                {
                    valid = false;
                    DisplayInvalidResponse();
                }
            } while (!valid);


            //Calculation Area

            valid = true;
            double lessOrMore = goalPh - currentPh;
            // if ph needs to be decreased sulfur
            if (lessOrMore <= 0)
            {
                DisplayAmountOfSulfur(soilType, squareFeetOfLand, currentPh, goalPh);
            }
            // if ph needs to be increased limestone
            if (lessOrMore >= 0)
            {
                DisplayAmountOfLimeStone(soilType, squareFeetOfLand, currentPh, goalPh);
            }

            DisplayContinuePrompt();
        }

        /// <summary>
        /// Displaying Amount of Sulfur Needed
        /// </summary>
        /// <param name="soilType"></param>
        /// <param name="squareFeetOfLand"></param>
        /// <param name="currentPh"></param>
        /// <param name="goalPh"></param>
        static void DisplayAmountOfSulfur(
            string soilType, 
            double squareFeetOfLand, 
            double currentPh, 
            double goalPh)
        {
            double poundsOfSulfur;
            double sulfurVarible = 0;

            switch (soilType)
            {
                case "sand":
                    sulfurVarible = 0.02;
                    break;
                case "clay":
                    sulfurVarible = 0.013;
                    break;
                case "loam":
                    sulfurVarible = 0.03;
                    break;
            }

            poundsOfSulfur = sulfurVarible * squareFeetOfLand * (currentPh - goalPh);

            DisplayScreenHeader("Ph Calculator");

            Console.WriteLine($"Current Ph: " + currentPh);
            Console.WriteLine($"Goal Ph: " + goalPh);
            Console.WriteLine($"Area: " + squareFeetOfLand + " square feet");


            Console.WriteLine("{0:F2} pounds of Sulfur", poundsOfSulfur);
        }

        /// <summary>
        /// Displaying Amount of Limestone Needed
        /// </summary>
        /// <param name="soilType"></param>
        /// <param name="squareFeetOfLand"></param>
        /// <param name="currentPh"></param>
        /// <param name="goalPh"></param>
        static void DisplayAmountOfLimeStone(
            string soilType, 
            double squareFeetOfLand, 
            double currentPh, 
            double goalPh)
        {
            double poundsOfLimestone;
            double limeStoneVarible = 0;

            switch (soilType)
            {
                case "sand":
                    limeStoneVarible = 0.025;
                    break;
                case "clay":
                    limeStoneVarible = 0.075;
                    break;
                case "loam":
                    limeStoneVarible = 0.1;
                    break;
            }

            poundsOfLimestone = limeStoneVarible * squareFeetOfLand * (goalPh - currentPh);

            DisplayScreenHeader("Ph Calculator");

            Console.WriteLine($"Current Ph: " + currentPh);
            Console.WriteLine($"Goal Ph: " + goalPh);
            Console.WriteLine($"Area: " + squareFeetOfLand + " square feet");


            Console.WriteLine("{0:F2} pounds of Limestone", poundsOfLimestone);
        }
        #endregion

        #region EXTRA METHODS
        /// <summary>
        /// Continue Promt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// Custom Screen Header
        /// </summary>
        /// <param name="headerText"></param>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        /// <summary>
        /// Sets the Theme for the app
        /// </summary>
        static void DisplayTheme()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

        }

        /// <summary>
        /// Invalid Response
        /// </summary>
        static void DisplayInvalidResponse()
        {
            Console.WriteLine("I am sorry but it seems that you have not given a valid answer");
            Console.WriteLine("");
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
        #endregion

    }
}
