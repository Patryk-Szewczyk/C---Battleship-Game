// Battleship Game

using System;
using OutputProgram;
using InputWorkProgram;

namespace OutputProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Intro gry:
            GameMenu gameMenu_Obj = new GameMenu();
            gameMenu_Obj.intro();

            // Instrukcja gry
            Console.WriteLine("To continue with the instructions, click ENTER key");
            Console.WriteLine("");
            string nothing_1 = "";
            string someVal_1 = Console.ReadLine();
            if (someVal_1 != nothing_1 || someVal_1 == "")
            {
                gameMenu_Obj.instruction();
            }
            else { }
            // Pozycjonowanie statków - gracz 1
            Console.WriteLine("To continue with the ship positing, click ENTER key");
            Console.WriteLine("");
            string nothing_2 = "";
            string someVal_2 = Console.ReadLine();
            if (someVal_2 != nothing_2 || someVal_2 == "")
            {
                gameMenu_Obj.shipPositing_P1();
            }
            else { }
        }
    }
}

namespace InputWorkProgram
{
    public class GameMenu : Program
    {
        public void intro()
        {
            Console.WriteLine("BBBBBBB     BBBB    BBBBBBBB  BBBBBBBB  BB        BBBBBBBB   BBBBBBB  BB    BB  BB  BBBBBBB");
            Console.WriteLine("BB    BB   BB  BB      BB        BB     BB        BB        BB        BB    BB  BB  BB    BB");
            Console.WriteLine("BB    BB  BB    BB     BB        BB     BB        BB        BB        BB    BB  BB  BB    BB");
            Console.WriteLine("BBBBBBBB  BBBBBBBB     BB        BB     BB        BBBBBBBB   BBBBBB   BBBBBBBB  BB  BBBBBBB");
            Console.WriteLine("BB    BB  BB    BB     BB        BB     BB        BB              BB  BB    BB  BB  BB");
            Console.WriteLine("BB    BB  BB    BB     BB        BB     BB        BB              BB  BB    BB  BB  BB");
            Console.WriteLine("BBBBBBB   BB    BB     BB        BB     BBBBBBBB  BBBBBBBB  BBBBBBB   BB    BB  BB  BB");
            Console.WriteLine("");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("");
            Console.WriteLine("Battleship Game is simple game which depend of sunking shipse between players.");
            Console.WriteLine("To start game you must do a few activites to mainly set ships.");
            Console.WriteLine("");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("");
        }
        public void instruction()
        {
            Console.Clear();
            Console.WriteLine("BB  BBBB  BB   BBBBBBB  BBBBBBBB  BBBBBBB   BB    BB   BBBBBBB  BBBBBBBB  BB   BBBBBB   BBBB  BB");
            Console.WriteLine("BB  BB BB BB  BB           BB     BB    BB  BB    BB  BB           BB     BB  BB    BB  BB BB BB");
            Console.WriteLine("BB  BB BB BB  BB           BB     BB    BB  BB    BB  BB           BB     BB  BB    BB  BB BB BB");
            Console.WriteLine("BB  BB BB BB   BBBBBB      BB     BBBBBBB   BB    BB  BB           BB     BB  BB    BB  BB BB BB");
            Console.WriteLine("BB  BB BB BB        BB     BB     BB    BB  BB    BB  BB           BB     BB  BB    BB  BB BB BB");
            Console.WriteLine("BB  BB BB BB        BB     BB     BB    BB  BB    BB  BB           BB     BB  BB    BB  BB BB BB");
            Console.WriteLine("BB  BB  BBBB  BBBBBBB      BB     BB    BB   BBBBBB    BBBBBBB     BB     BB   BBBBBB   BB  BBBB");
            Console.WriteLine("");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("");
            Console.WriteLine("1. Every player must set our every ship on our board.");
            Console.WriteLine("2. Every player have a 7 ships.");
            Console.WriteLine("3. Each ship has a certain length and direction.");
            Console.WriteLine("4. Ships can be placed on board in two types of positions: horizontal and vertical.");
            Console.WriteLine("5. The player boards have dimensions of 10 x 10 fields.");
            Console.WriteLine("6. When placing ships, ships canNOT leave the board and canNOT overlap each other.");
            Console.WriteLine("7. After placing the ships on the boards, you can start the game.");
            Console.WriteLine("8. At the beginning, all squares of the board are marked with the sign: \"#\" on the board.");
            Console.WriteLine("9. A hit ship is marked with an \"H\" on the board.");
            Console.WriteLine("10. The sunken ship is marked with a series of \"S\" characters, relative to its position on the board.");
            Console.WriteLine("11. The miss is marked with an \"M\" on the board.");
            Console.WriteLine("12. To attack an opponent, the player must enter coordinates such like: \"H8\" and click ENTER.");
            Console.WriteLine("13. Players take turns shooting.");
            Console.WriteLine("14. The winner is the one who defeats his enemy.");
            Console.WriteLine("15. The winner wins \"PAngular\". (Traditional programmer's christmas meal)");
            Console.WriteLine("16. After game players can play game again.");
            Console.WriteLine("");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("");
        }
        public void shipPositing_P1()
        {
            int shipPage = 0;
            int shipPageIncrement = 0;
            string selectDirection = "";
            //int selDirSwich = 0;
            bool isDirCoor = false;
            bool isDir = false;
            bool isCoor = true;  // 0 - none | 1 - stop | 2 - yes
            string selectCoordinates = "";
            string wantSave = "none";
            bool saveQuery = true;
            while (shipPage < 7)
            {
                Console.Clear();
                Console.WriteLine("PLAYER 1");
                Console.WriteLine("");
                Console.WriteLine("- - - - - - - - - - - - -");
                Console.WriteLine("");
                Console.WriteLine("Set " + (shipPage + 1).ToString() + "/7 ship:");
                Console.WriteLine("Type: Submarine");
                Console.WriteLine("Length: 2");
                if (isDir == false)
                {
                    Console.WriteLine("Direction: ?");
                } 
                else if (isDir == true)
                {
                    Console.WriteLine("Direction: " + selectDirection);
                }
                if (isCoor == false)
                {
                    Console.WriteLine("Coordination: ?");
                } 
                else if (isCoor == true)
                {
                    Console.WriteLine("Coordinates: " + selectCoordinates);
                }
                Console.WriteLine("");
                Console.WriteLine("- - - - - - - - - - - - -");
                Console.WriteLine("");
                if (isDirCoor == false)
                {
                    if (isDir == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Set " + (shipPage + 1).ToString() + "/7 ship direction: ");
                        Console.WriteLine("");
                        Console.WriteLine("\"B\" - vertical position");
                        Console.WriteLine("\"R\" - horizontal position");
                        Console.WriteLine("");
                        selectDirection = Console.ReadLine();
                        if (selectDirection == "B" || selectDirection == "R")
                        {
                            shipPageIncrement = 0;
                            isDir = true;
                            isCoor = false;
                        }
                        else if (selectDirection != "B" || selectDirection != "R")
                        {
                            shipPageIncrement = 0;
                            Console.WriteLine("");
                            Console.WriteLine("- - - - - - - - - - - - -");
                            Console.WriteLine("");
                            Console.WriteLine("You write uncorrect value. Direction value must be \"B\" or \"R\" !");
                            Console.WriteLine("To continue click ENTER key");
                            Console.WriteLine("");
                            string any = Console.ReadLine();
                        }
                    } else { }
                    if (isCoor == false)
                    {
                        Console.Clear();
                        Console.WriteLine("Set " + (shipPage + 1).ToString() + "/7 ship coordinates: ");
                        Console.WriteLine("");
                        Console.WriteLine("Value from A0 to J9:");
                        Console.WriteLine("");
                        selectCoordinates = Console.ReadLine();
                        if (selectCoordinates == null)   /// Sprawdzenie czy współrzędna początkowa nie jest pusta.
                        {
                            Console.WriteLine("");
                            Console.WriteLine("- - - - - - - - - - - - -");
                            Console.WriteLine("");
                            Console.WriteLine("You don\'t left empty value. You can write correct value.");
                            Console.WriteLine("Click ENTER key to continue:");
                            Console.WriteLine("");
                            string any = Console.ReadLine();

                        } else if (selectCoordinates != null) {
                            if (selectCoordinates.Length != 2)   /// Sprawdzenie czy współrzędna początkowa ma odpowiednią długość.
                            {
                                Console.WriteLine("");
                                Console.WriteLine("- - - - - - - - - - - - -");
                                Console.WriteLine("");
                                Console.WriteLine("Your value\'s length is uncorrect. You must change it.");
                                Console.WriteLine("Click ENTER key to continue:");
                                Console.WriteLine("");
                                string any = Console.ReadLine();
                            }
                            else if (selectCoordinates.Length == 2)   /// Jeżeli wartość i odpowiednia długość jest, wprawdź poprawność wartości.
                            {
                                ///string validVal = selectCoordinates;
                                string letter = selectCoordinates.Substring(0, 1);
                                string number = selectCoordinates.Substring(1, 1);
                                string[] avalLet_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                                string[] avalNum_AR = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                                bool isIn_avalLet_AR = false;
                                bool isIn_avalNum_AR = false;
                                for (int i = 0; i < avalLet_AR.Length; i++)
                                {
                                    /// Sprawdzenie czy pierwszy substringowany indeks współrzędnej początekowej istnieje w tablicy liter:
                                    if (avalLet_AR[i] == letter)
                                    {
                                        isIn_avalLet_AR = true;
                                    }
                                    else { }
                                    /// Sprawdzenie czy drugi substringowany indeks współrzędnej początekowej istnieje w tablicy cyfr:
                                    if (avalNum_AR[i] == number)
                                    {
                                        isIn_avalNum_AR = true;
                                    }
                                    else { }
                                }
                                if (isIn_avalLet_AR == true && isIn_avalNum_AR == true)
                                {
                                    shipPageIncrement = 0;
                                    isCoor = true;
                                    isDirCoor = true;
                                    Console.WriteLine("");
                                    Console.WriteLine("- - - - - - - - - - - - -");
                                    Console.WriteLine("");
                                    Console.WriteLine("This point exitst in our board!");
                                    Console.WriteLine("Click ENTER key to continue:");
                                    Console.WriteLine("");
                                    string any = Console.ReadLine();
                                }
                                else if (isIn_avalLet_AR == false && isIn_avalNum_AR == false)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("- - - - - - - - - - - - -");
                                    Console.WriteLine("");
                                    Console.WriteLine("This point doesn\'t exists in our board!");
                                    Console.WriteLine("Click ENTER key to continue:");
                                    Console.WriteLine("");
                                    string any = Console.ReadLine();
                                }
                                else { }
                            }
                        }
                    }
                    else { }
                }
                else if (isDirCoor == true)   // JESTEŚ MNIEJ WIĘCEJ TUTAJ - ALE WIESZ.. MUSISZ OGARNĄĆ WSZYSTKO OD NOWA... XD
                {
                    if (saveQuery == true)
                    {
                        Console.WriteLine("Do you want save this ship data?");
                        wantSave = Console.ReadLine();
                        if (wantSave == "yes")
                        {
                            // Reset wszytskich słiczów i przejście do kolejnego statku
                            Console.WriteLine("");
                            Console.WriteLine("- - - - - - - - - - - - -");
                            Console.WriteLine("");
                            Console.WriteLine("Your ship data is saved!");
                            Console.WriteLine("Click ENTER key to continue:");
                            Console.WriteLine("");
                            string any = Console.ReadLine();
                        }
                        else if (wantSave == "no")
                        {
                            // Reset wszystkich słiczów i ponowne pozycjonowanie statku
                            Console.WriteLine("");
                            Console.WriteLine("- - - - - - - - - - - - -");
                            Console.WriteLine("");
                            Console.WriteLine("Your ship data is deleted. You must posite ship again.");
                            Console.WriteLine("Click ENTER key to continue:");
                            Console.WriteLine("");
                            string any = Console.ReadLine();
                        }
                    }
                    else if (saveQuery == false)
                    {
                         //
                    }
                    shipPageIncrement = 1;

                }
                shipPage += shipPageIncrement;
            }
        }
    }
}