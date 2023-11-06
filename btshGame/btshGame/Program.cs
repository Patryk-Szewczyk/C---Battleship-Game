/// Battleship Game

using System;
using OutputProgram;   /// Użycie przestrzeni wyjściowej
using InputWorkProgram;   /// Użycie przestrzeni wykonawczej
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Runtime.Versioning;

/// Zrobiłem dwie przesrzenie nazw. Pierwsza jest na klasę główną z główną metodę Main(), która z klasą pełni funkcję tworzenia poszczególnych instancji następujących po sobie
/// klas wykonawczyh, które pełnią rolę osobnych komponentów. Druga przestrzeń nazw zawiera ów klasy wynonawcze i inne klasy zwracające wartości do klas wykonawczych.
/// Dodatkowa klasy wykonawcze zwracają argumenty do metody Main() klasy Program w pierwszej przestrzeni nazw, aby je użyć jako argumenty w kolejnej metodzie.
namespace OutputProgram   /// Przestrzeń wyjściowa - miejce deklaracji obiektów z klas przestrzeni wykonawczej i aktywowania ich metod
{
    public class Program   /// Główna i jedyna klasa przestrzeni wyjściowej
    {
        static void Main(string[] args)   /// Główna metoda - odpowiednik natychmiastowej samowywołującej się funkcji z JavaScript ("Immediately-invoked")
        {
            /// Intro gry:
            GameMenu gameMenu_Obj = new GameMenu();   /// Tworzenie zmiennej z instancją klasy GameMenu
            gameMenu_Obj.intro();   /// Ekran tytułowy

            /// Instrukcja gry
            Console.WriteLine("To continue with the instructions, click ENTER key");
            Console.WriteLine("");
            Console.ReadLine();   /// Aby przejść dalej do kolejnej pseudo-strony konsoli (metoda "Console.Clear()") trzeba kliknąć ENTER
            gameMenu_Obj.instruction();   /// Byle tylko był kliknięty ENTER
            //
            // WEŹ PÓŹNIEJ POZYCJONOWANIE STATKÓW GRACZA 1 I 2 ORAZ ICH GRĘ W PĘTLĘ WHILE I ODTWARZAJ PONOWNIE JAKO PONOWNĄ GRĘ!
            // Na końcu tej instrukcji warunkowej będzie zapytanie co robimy po grze.
            // Jeżeli gracz wybierze opcję ponowna gra, pętla wykona się ponownie, a z nią od nowa wszystkie punkty.
            // Jeżeli gracz wybierze napisy końcowe, zostaną puszczone napisy końcowe tak jak to sobie zaplanowałeś w głowie...
            //
            // Gra "właściwa"
            Console.WriteLine("To continue with the ship positing, click ENTER key");
            Console.WriteLine("");
            Console.ReadLine();
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Gra zapętlona
            GameLoop gameLoop = new GameLoop();   /// Tworzenie zmiennej z instancją klasy GameMenu
            (string[,], string[,,]) playersData_AR = gameLoop.setPlayersShips();
            string[,] playersShipCoor_AR = new string[2, 7];
            /// Użyłem tego typu tablicy ([,,]), gdyż wyświetlanie danych z tablic i wkładanie do nich zmodyfikowanych wartości jest 
            /// łatwiejsze, niż w przypadku innych (do już określonych indeksowo na każdą zagnieżdżoną tablicę, nie tak jak w 
            /// generyku List<typ>, gdzie swobodnie można dodawać wartości do indeksów tak jak w JS z .appendChild())
            string[,,] playersBoardContent_AR = new string[2, 10, 10];
            playersShipCoor_AR = playersData_AR.Item1;   /// DO SPRAWDZENIA!
            playersBoardContent_AR = playersData_AR.Item2;   /// DO SPRAWDZENIA!
            // metoda: fight()   // argument: playersShipCoor_AR & playersBoardContent_AR
            // metoda: prize()   // argument: winner
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Ekran końcowy i napisy końcowe
        }
    }
}

namespace InputWorkProgram   /// Przestrzeń wykonawcza - miejsce deklaracji klas z określonymi metodami.
{
    public class GameMenu : Program   // Klasa dziedziczna menu gry
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
            Console.WriteLine("I yery please YOU about enable full screen.");
            Console.WriteLine("In else case you see errors in figure of NOT clearing console code (in console top).");
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
            // POPRAW INSTRUKCJĘ OBSŁUGI GRY!!!
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
            Console.WriteLine("15. The winner wins \"PAngular\". (traditional programmer's christmas meal)");
            Console.WriteLine("16. After game players can play game again or get in game credits.");
            Console.WriteLine("");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("");
        }
    }
    public class GameLoop
    {
        public (string[,], string[,,]) setPlayersShips()
        {
            /// Tworzenie instancji klasy "BoardContentMaker" i wywołanie metoda odpowiadaojący za tablice związane z plansza:
            BoardContentMaker boardContentMaker_Obj = new BoardContentMaker();
            //string[,] fieldAreaContent_AR = boardContentMaker_Obj.set_fieldAreaContent_AR();
            string[,] playersShipCoor_AR = new string[2, 7];   /// {player_1_AR, player_2_AR}
            //playersShipCoor_AR = boardContentMaker_Obj.setPlayersShipCoor(playersShipCoor_AR);


            //List<List<string>>  player_1_ShipCoor_AR = new List<List<string>>();
            //List<List<string>> player_2_ShipCoor_AR = new List<List<string>>();
            //playersShipCoor_AR.Add(player_1_ShipCoor_AR);
            //playersShipCoor_AR.Add(player_2_ShipCoor_AR);
            string[,,] playersBoardContent_AR = boardContentMaker_Obj.set_fieldAreaContent_AR();   // [2, 10, 10]
            List<List<int>> fullIndex_AR = boardContentMaker_Obj.set_fullIndex_AR();   /// Osobna metoda z return
            List<List<List<int>>> availableFields_AR = boardContentMaker_Obj.set_availableFields_AR();   /// Osobna metoda z return
            int players = 0;
            int shipPage = 0;
            int shipPageIncrement = 0;
            string[] shipTypeName_AR = { "submarine", "submarine", "submarine", "destroyer", "destroyer", "battleship", "aircraft carrier" };
            string[] shipLengthName_AR = { "2", "2", "2", "3", "3", "4", "5" };
            string selectDirection = "";
            bool isSetPlayerShipCoor = false;
            bool isDirCoor = false;
            bool isDir = false;
            bool isBegAgn_FromDir = true;
            bool isCoor = true;  /// true - musi być niewidozne dopóki kierunke nie jest określony
            string firstCoor = "";
            string[] shipFullCoor = { "" };
            string wantSave = "none";
            string[] letCoorName_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            while (players < 2)
            {
                players += 1;
                shipPage = 0;
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Set ships on board for player " + players.ToString());
                Console.WriteLine("To continue you must click ENTER key.");
                Console.WriteLine("");
                Console.ReadLine();
                // Ustawianie statków dla każdego gracza:
                while (shipPage < 8)   /// - do 6 ustawianie | 7 - komunikat o zakończeniu ustawiania statków dla gracza
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("            PLAYER " + players);
                    Console.WriteLine("");
                    Console.WriteLine("- - - - - - - - - - - - - - - - -");
                    Console.WriteLine("  _____________________________  ");
                    Console.WriteLine(" |                             | ");
                    Console.WriteLine(" |                             | ");
                    Console.WriteLine(" |      0 1 2 3 4 5 6 7 8 9    | ");
                    Console.Write(" |    ");   /// lewa strona planszy
                                               /// Wyświetlanie  planszy tablicy za pomocą pętli zagnieżdżonej iterującej tablicę dwuwymiarową:
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(letCoorName_AR[i] + " ");
                        for (int j = 0; j < 10; j++)
                        {
                            /// tablica trzywymiarowa, (players - 1) - players jest inkrementowane na początku pętli,
                            /// a indeksy rozpoczynają się od zera, więc daltego mamy (players - 1)
                            Console.Write(playersBoardContent_AR[(players - 1), i, j]);
                        }
                        Console.Write("");
                        Console.WriteLine("   | ");   /// prawa strona planszy
                        if (i < 9)   /// w iteracji dobijamy maksymalnie do 9, bo [i] ma być < 10
                        {
                            Console.Write(" |    ");   /// lewa strona planszy
                        }
                        else if (i >= 9) { }
                    }
                    Console.WriteLine(" |                             | ");
                    Console.WriteLine(" |_____________________________| ");
                    Console.WriteLine("");
                    Console.WriteLine("- - - - - - - - - - - - - - - - -");
                    Console.WriteLine("");
                    if (shipPage < 7)   /// 7 jest przeznaczone tylko dla komunikato o zakończeniu ustawianai statków dla gracza. W poniższych sytuacjach trzeba zmniejszyć o 1, gdyż w przeciwnym razie lecimy o 1 statek do góry, przez co mam złe wartości liczbowe i błąd w Array (RangeOf)
                    {
                        Console.WriteLine("Set " + (shipPage + 1).ToString() + "/7 ship:");
                        Console.WriteLine("Type: " + shipTypeName_AR[shipPage]);
                        Console.WriteLine("Length: " + shipLengthName_AR[shipPage]);
                    }
                    else if (shipPage == 7)
                    {
                        Console.WriteLine("Set " + shipPage.ToString() + "/7 ship:");
                        Console.WriteLine("Type: " + shipTypeName_AR[shipPage - 1]);
                        Console.WriteLine("Length: " + shipLengthName_AR[shipPage - 1]);
                    }
                    if (isDir == false)
                    {
                        Console.WriteLine("Direction: ?");
                    }
                    else if (isDir == true)
                    {
                        Console.WriteLine("Direction: " + selectDirection);
                    }
                    if (isCoor == true)
                    {
                        Console.WriteLine("Coordination: ?");
                    }
                    else if (isCoor == false)
                    {
                        Console.Write("Coordination:");
                        for (int i = 0; i < shipFullCoor.Length; i++)
                        {
                            Console.Write(" | " + shipFullCoor[i]);
                        }
                        Console.Write(" |");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("");
                    if (isBegAgn_FromDir == true && shipPage < 7)
                    {
                        Console.WriteLine("You must set " + (shipPage + 1).ToString() + " ship now.");
                        Console.WriteLine("To continue you must click ENTER key.");
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    else { }
                    if (isDirCoor == false || shipFullCoor[0] == "?")   /// {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                    {
                        if (isDir == false && shipPage < 7)
                        {
                            Console.Clear();
                            Console.WriteLine("Set " + (shipPage + 1).ToString() + "/7 ship direction: ");
                            Console.WriteLine("Type: " + shipTypeName_AR[shipPage]);
                            Console.WriteLine("Length: " + shipLengthName_AR[shipPage]);
                            Console.WriteLine("");
                            Console.WriteLine("\"B\" - vertical position (from top to bottom: A2 -> A2, B2 , ...)");
                            Console.WriteLine("\"R\" - horizontal position (from left to right: A2 -> A2, A3, ...)");
                            Console.WriteLine("");
                            selectDirection = Console.ReadLine();
                            if (selectDirection == "B" || selectDirection == "R")
                            {
                                shipPageIncrement = 0;
                                isBegAgn_FromDir = false;
                                isDir = true;
                                isCoor = false;
                                Console.WriteLine("");
                                Console.WriteLine("- - - - - - - - - - - - - - - - -");
                                Console.WriteLine("");
                                Console.WriteLine("Direction is set!");
                                Console.WriteLine("To continue click ENTER key");
                                Console.WriteLine("");
                                Console.ReadLine();
                            }
                            else if (selectDirection != "B" || selectDirection != "R")
                            {
                                shipPageIncrement = 0;
                                isBegAgn_FromDir = false;
                                Console.WriteLine("");
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                                Console.WriteLine("");
                                Console.WriteLine("You write uncorrect value. Direction value must be \"B\" or \"R\" !");
                                Console.WriteLine("To continue click ENTER key");
                                Console.WriteLine("");
                                Console.ReadLine();
                            }
                        }
                        else { }
                        if ((isCoor == false && shipPage < 7) || (shipFullCoor[0] == "?" && shipPage < 7))   /// {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                        {
                            Console.Clear();
                            Console.WriteLine("Set " + (shipPage + 1).ToString() + "/7 ship coordinates: ");
                            Console.WriteLine("Type: " + shipTypeName_AR[shipPage]);
                            Console.WriteLine("Length: " + shipLengthName_AR[shipPage]);
                            Console.WriteLine("");
                            Console.WriteLine("Value from A0 to J9:");
                            Console.WriteLine("");
                            firstCoor = Console.ReadLine();
                            if (firstCoor == null)   /// Sprawdzenie czy współrzędna początkowa nie jest pusta.
                            {
                                Console.WriteLine("");
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                                Console.WriteLine("");
                                Console.WriteLine("You don\'t left empty value. You can write correct value.");
                                Console.WriteLine("Click ENTER key to continue:");
                                Console.WriteLine("");
                                Console.ReadLine();

                            }
                            else if (firstCoor != null)
                            {
                                if (firstCoor.Length != 2)   /// Sprawdzenie czy współrzędna początkowa ma odpowiednią długość.
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                                    Console.WriteLine("");
                                    Console.WriteLine("Your value\'s length is uncorrect. You must change it.");
                                    Console.WriteLine("Click ENTER key to continue:");
                                    Console.WriteLine("");
                                    Console.ReadLine();
                                }
                                else if (firstCoor.Length == 2)   /// Jeżeli wartość i odpowiednia długość jest, wprawdź poprawność wartości.
                                {
                                    ///string validVal = selectCoordinates;
                                    string letter = firstCoor.Substring(0, 1);
                                    string number = firstCoor.Substring(1, 1);
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
                                        isCoor = false;
                                        isDirCoor = true;
                                        //Console.WriteLine("");
                                        //Console.WriteLine("- - - - - - - - - - - - - - - - -");
                                        //Console.WriteLine("");
                                        //Console.WriteLine("This area exitst in our board!");
                                        //Console.WriteLine("Click ENTER key to continue:");
                                        //Console.WriteLine("");
                                        // Przekazywanie wszystkich potrzebnych argumaentów do medoty (obiektu danej klasy) tworzącej statek i jednocześnie sprawdzającej
                                        // czy ów statek wychodzi poza pole planszy oraz czy nakłada się na inny / inne statki:
                                        ShipBuildChecker shipBuildChecker_Obj = new ShipBuildChecker();
                                        /// Za każdym ułożeniem statku, tabela pozycji pól planszy ma skracać się o współrzędne statku i z tego powodu potrzebne było aktualizowanie
                                        /// ów tabeli poza pętlą while, aby zachować jej zaktualizowany stan i ponownie ją przekazać do obróbki. W tym celu użyłem krotki ze standardu 7.0:
                                        (string[], List<List<int>>) tuples_1 = shipBuildChecker_Obj.shipCoorBuildChecker(firstCoor, selectDirection, shipLengthName_AR[shipPage], availableFields_AR, fullIndex_AR, avalLet_AR, avalNum_AR, players);
                                        shipFullCoor = tuples_1.Item1;
                                        fullIndex_AR = tuples_1.Item2;
                                        string playerShipCoor = "";
                                        for (int i = 0; i < shipFullCoor.Length; i++)
                                        {
                                            playerShipCoor += " | " + shipFullCoor[i];
                                        }
                                        playersShipCoor_AR[players - 1, shipPage] = playerShipCoor;
                                        //List<string> playerOnceShipCoor = new List<string>();
                                        //playerOnceShipCoor = shipFullCoor.Select(x => x.ToString()).ToList();
                                        //playersShipCoor_AR;
                                    }
                                    else if (isIn_avalLet_AR == false || isIn_avalNum_AR == false)
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                                        Console.WriteLine("");
                                        Console.WriteLine("This area NOT exists in our board!");
                                        Console.WriteLine("Click ENTER key to continue:");
                                        Console.WriteLine("");
                                        Console.ReadLine();
                                    }
                                    else { }
                                }
                            }
                        }
                        else { }
                    }
                    else if (isDirCoor == true && shipFullCoor[0] != "?")   /// {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                    {
                        Console.WriteLine("Do you want save this ship data? Write \"yes\" or \"no\".");
                        wantSave = Console.ReadLine();
                        if (wantSave == "yes" && shipPage < 7)
                        {
                            // TWORZENIE OBIEKTU STATKU - INSTANCJI KLASY FABRYKI STATKÓW - PRZEKAZUJĄC WSZYSTKIE POTRZEBNE DO TEGO PARAMERY:
                            // kod
                            /// Aktualizacja planszy poprzez umieszczeni na niej nowego statku
                            BoardContentMaker shipBuildChecker_Obj = new BoardContentMaker();
                            (string[,,], List<List<int>>) updBrdData = shipBuildChecker_Obj.updateBoardContent(fullIndex_AR, shipFullCoor, playersBoardContent_AR, players);
                            playersBoardContent_AR = updBrdData.Item1;
                            fullIndex_AR = updBrdData.Item2;
                            // Koniec ustawiania statków dla danego gracza: (switch)
                            if (shipPage == 6)
                            {
                                isSetPlayerShipCoor = true;
                            }
                            else { }
                            // Reset wszytskich słiczów i przejście do kolejnego statku
                            Console.WriteLine("");
                            Console.WriteLine("- - - - - - - - - - - - - - - -");
                            Console.WriteLine("");
                            Console.WriteLine("Your ship data is saved!");
                            Console.WriteLine("Click ENTER key to continue:");
                            Console.WriteLine("");
                            Console.ReadLine();
                            // Przejście do kolejnego statku:
                            shipPageIncrement = 1;
                            /// Reset zmiennych potrzebnych do wypełniania informacji o kolejnym statku i związanych z nimi przełączników:
                            isDir = false;
                            isBegAgn_FromDir = true;
                            isCoor = true;   /// Niewidoczne, bo najpierw trzeba ogarnąć kierunek, a potem wyświetlić zapytanie o współrzędną początkową
                            isDirCoor = false;
                            firstCoor = "";
                            Array.Clear(shipFullCoor, 0, shipFullCoor.Length);
                            wantSave = "none";
                        }
                        else if (wantSave == "no" && shipPage < 7)
                        {
                            /// Reset wszystkich słiczów i ponowne pozycjonowanie statku
                            Console.WriteLine("");
                            Console.WriteLine("- - - - - - - - - - - - - - - - -");
                            Console.WriteLine("");
                            Console.WriteLine("Your ship data is deleted. You must posite ship again.");
                            Console.WriteLine("Click ENTER key to continue:");
                            Console.WriteLine("");
                            Console.ReadLine();
                            /// Reset zmiennych potrzebnych do wypełniania informacji o bieżącym statu i związanych z nimi przełączników:
                            isDir = false;
                            isBegAgn_FromDir = true;
                            isCoor = true;   /// Niewidoczne, bo najpierw trzeba ogarnąć kierunek, a potem wyświetlić zapytanie o współrzędną początkową
                            isDirCoor = false;
                            firstCoor = "";
                            Array.Clear(shipFullCoor, 0, shipFullCoor.Length);
                            wantSave = "none";
                        }
                    }
                    if (shipPage == 7 && isSetPlayerShipCoor == true)
                    {
                        /// Informacja o ustawieniu wszystkich statków:
                        Console.WriteLine("");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine("");
                        Console.WriteLine("You set all ships. Now you make a mental note yours ship with them coordinates");
                        Console.WriteLine("and next to second player and next to second player ship setting.");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();
                        /// Aktualizowanie tablic graczy:
                        //playersShipCoor_AR.Add();
                        //playersBoardContent_AR.Add();
                        /// Reset wszystkigo co potrzebne do ponownego ustawienia statków dla kolejnego gracza:
                        isSetPlayerShipCoor = false;
                        // - - - - - - - - - - - - -
                        isDir = false;
                        isBegAgn_FromDir = true;
                        isCoor = true;   /// Niewidoczne, bo najpierw trzeba ogarnąć kierunek, a potem wyświetlić zapytanie o współrzędną początkową
                        isDirCoor = false;
                        firstCoor = "";
                        Array.Clear(shipFullCoor, 0, shipFullCoor.Length);
                        wantSave = "none";
                    }
                    shipPage += shipPageIncrement;
                }
            }
            return (playersShipCoor_AR, playersBoardContent_AR);
        }
    }
    public class BoardContentMaker
    {
        //public List<List<List<List<string>>>> setPlayersShipCoor(List<List<List<List<string>>>> playersShipCoor_AR)
        //{
        /// Tworzenie indeksów (do czterowymiarowego List) na współrzędne statków dla obu graczy:
        //List<List<List<List<string>>>> result = playersShipCoor_AR;
        //return result;
        //}
        public string[,,] set_fieldAreaContent_AR()
        {
            /// Tworzenie tablic z graficzną zawartością stanu gry dla wszystkich graczy:
            /// Użyłem tu typu zagnieżdżonej tablicy array[,,], a nie List<List<List<string>>>
            /// z tego powodu, iż łatwiej jest mi modyfikować tablicę i wyświetlać ją w konsoli
            string[,,] array = new string[2, 10, 10];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        array[i, j, k] = "~ ";
                    }
                }
            }
            return array;
        }
        public List<List<int>> set_fullIndex_AR()
        {
            List<List<int>> array = new List<List<int>>();
            List<int> player_1 = new List<int>();
            List<int> player_2 = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                player_1.Add(i);
                player_2.Add(i);
            }
            array.Add(player_1);
            array.Add(player_2);
            return array;
        }
        public List<List<List<int>>> set_availableFields_AR()
        {
            /// Deklaracja tablicy trójwymiarowej o nieznanej liczbie wszystkich indeksów mieszczącej
            /// wszstkie zestawy dostępnych pól na daną długość w zależności od kierunku statku:
            List<List<List<int>>> mainArray = new List<List<List<int>>>();
            /// Poszczególne zestawy dostępnych pól w danym kierunku statku w zależności od jego długości
            List<List<int>> length_B = new List<List<int>>();
            List<List<int>> length_R = new List<List<int>>();
            /// Operacje na tablicach:
            /// Kierunek: w dół:
            int startToIncValue = 89;
            for (int i = 0; i < 4; i++)
            {
                List<int> lengthType = new List<int>();
                /// Z miejscami na kolejne ineksy obchodzimy się tak samo jak w JavaScript z tworzeniem elementów-tagów i wrzucaniem ich do elementów-rodziców. 
                /// W JavaScript deklarujemy zmienną o wartości documnet.createElement('div'), który później Appendujemy do określonego kontenera-rodzica, 
                /// który ma być kontenerem na ten właśnie element i możliwie inne potomne. Dokładnie tak samo postępujemy w C# z tablicami zagnieżdżonymi 
                /// zadeklarowanymi za pomocą generyka List<typ>. Najpierw deklarujemy tablicę, później dodajemy do niej wartość, tak jak byśmy używali metody 
                /// .createTextNode() obiektu document (i wkładali tam stringa), a następnie wkładamy ów tablicę do tablicy nadrzędnej i w JS jest to .appendChild()
                int shipValue = 0;
                shipValue = startToIncValue;
                for (int j = 0; j < 10; j++)
                {
                    lengthType.Add(shipValue += 1);
                }
                length_B.Add(lengthType);
                startToIncValue -= 10;
            }

            /// Kierunek w prawo:
            int decrement = -1;
            for (int i = 0; i < 4; i++)
            {
                List<int> lengthType = new List<int>();
                int shipValue = 0;
                shipValue = decrement;
                for (int j = 0; j < 10; j++)
                {
                    lengthType.Add(shipValue += 10);
                }
                length_R.Add(lengthType);
                decrement -= 1;
            }

            /// Tworzenie tablic tymczasowych na pola zakazane:
            List<List<int>> new_B_FusionVal_AR = new List<List<int>>();
            List<List<int>> new_R_FusionVal_AR = new List<List<int>>();
            /// Łączenie poszczególnych tablic w celu uzyskania poprawnych zestawów dostępnych pól względem długości i statku:
            /// WYJAŚNIENIE: 
            /// Jeżeli mam statek o długości 3 i pionowej pozycji położenia, to kiedy kładę go na np. I7 i mam jako
            /// ogranicznik TYLKO tablicę odpowiadającej początkowi współrzędnej początkowej tego statku (przy długości 3 - linia pól H), 
            /// która leżąc od dolnej krawędzi planszy znajdowałaby się na pozycji H7, to ogranicznik dotyczyłby tylko wyspółrzędnych z 
            /// cyframi należącymi do H, a nie wszystkich pól w dół poczynając od H (H0 -> J9). Użytkownik kładąc więc statek na pozycji
            /// I7, gdzie jest ZAKAZ ustawiania statków tej długości położyłby statek, który teoretycznie wychodziłby z planszy, a w 
            /// praktyce dawałby błąd w konsoli... W celu ominięca tego problemu trzeba połączyć poszczególne tablice w taki sposób aby
            /// pasowały do danego typu statku - jego długości.
            List<int> L3_DB = length_B[1].Concat(length_B[0]).ToList();   /// Ograniczenie dla statków o długości 3 i pozycji pionowej
            List<int> L4_DB = length_B[2].Concat(length_B[1]).Concat(length_B[0]).ToList();   /// Ograniczenie dla statków o długości 4 i pozycji pionowej
            List<int> L5_DB = length_B[3].Concat(length_B[2]).Concat(length_B[1]).Concat(length_B[0]).ToList();   /// Ograniczenie dla statków o długości 5 i pozycji pionowej
            List<int> L3_DR = length_R[1].Concat(length_R[0]).ToList();   /// Ograniczenie dla statków o długości 3 i pozycji poziomej
            List<int> L4_DR = length_R[2].Concat(length_R[1]).Concat(length_R[0]).ToList();   /// Ograniczenie dla statków o długości 4 i pozycji poziomej
            List<int> L5_DR = length_R[3].Concat(length_R[2]).Concat(length_R[1]).Concat(length_R[0]).ToList();   /// Ograniczenie dla statków o długości 5 i pozycji poziomej                                                                                                     /// Sortowanie tablicy length_R, w celu zwiększenia estetyki:
            L3_DR.Sort();
            L4_DR.Sort();
            L5_DR.Sort();

            /// Wkładanie poszczególnych zestawów pól zakazanych kolejno do indeksów poszczególnych tablic tymczasowych:
            new_B_FusionVal_AR.Add(L3_DB);
            new_B_FusionVal_AR.Add(L4_DB);
            new_B_FusionVal_AR.Add(L5_DB);
            new_R_FusionVal_AR.Add(L3_DR);
            new_R_FusionVal_AR.Add(L4_DR);
            new_R_FusionVal_AR.Add(L5_DR);

            /// Aktualizowanie tablic dwuwymiarowych, wkładają do nich poszczególne tablice tymczasowe, względem danego kierunku położenia statku:
            /// Aktualizowanie nastepuje od 1 indeksu obu tabel "length", gdyż dane w ich pierwszym indeksie (tablicy zagnieżdżonej) są poprawne (względwm długości statku).
            for (int i = 0; i < new_B_FusionVal_AR.Count; i++)
            {
                length_B[i + 1] = new_B_FusionVal_AR[i];
                length_R[i + 1] = new_R_FusionVal_AR[i];
            }

            /// Wkładanie gotowych grup zestawów pól zakazanych do głównej tablicy
            mainArray.Add(length_B);
            mainArray.Add(length_R);

            /// Test poprawności danych: OK
            /**Console.Clear();
            Console.WriteLine("Checking - R");
            for (int i = 0; i < mainArray[1].Count; i++)   // 0 - B | 1 - R
            {
                Console.WriteLine("");
                for (int j = 0; j < mainArray[1][i].Count; j++)
                {
                    Console.WriteLine((mainArray[1][i][j]).ToString());
                }
            }
            Console.WriteLine("");
            Console.ReadLine();**/

            return mainArray;
        }
        public (string[,,], List<List<int>>) updateBoardContent(List<List<int>> fullIndex_AR, string[] shipFullCoor, string[,,] playersBoardContent_AR, int players)
        {
            // Deklaracja gółwnych zmiennych:
            List<List<int>> splicedBoard_AR = new List<List<int>>();   /// RUCHOMA fizyczna tablica dostępnych pól na statki
            splicedBoard_AR = fullIndex_AR;
            string[,,] outputBoardData = playersBoardContent_AR;   /// STAŁA graficzna tablica na statki (zmiany w wartościach STAŁEJ tablicy)
            int player = players - 1;   // players będzie zawyżone o 1, bo od razu w pętli nastepuje inkrementacja, a indeksy zaczynają się od 0

            // Konwersja stringowej formy współrzędnej początkowej na formę intową: (B2 -> A = 0, B = 10, C = 20, ... więc B2 = 10 + 2 = 12)
            string[] brdLetCor_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            string[] brdNumCor_AR = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            List<string> fullCoor_string = new List<string>();
            fullCoor_string = shipFullCoor.Select(x => x.ToString()).ToList();
            List<string> fullCoor_string_1_let = new List<string>();
            List<string> fullCoor_string_2_num = new List<string>();
            List<string> fullCoor_string_1_num = new List<string>();
            List<string> result_string = new List<string>();
            List<int> result_int = new List<int>();
            //Console.WriteLine("");
            for (int i = 0; i < fullCoor_string.Count; i++)
            {
                fullCoor_string_1_let.Add(fullCoor_string[i].Substring(0, 1));
                fullCoor_string_2_num.Add(fullCoor_string[i].Substring(1, 1));

                for (int j = 0; j < brdLetCor_AR.Length; j++)
                {
                    if (fullCoor_string_1_let[i] == brdLetCor_AR[j])
                    {
                        fullCoor_string_1_num.Add(brdNumCor_AR[j]);
                    }
                    else { }
                }
                result_string.Add(fullCoor_string_1_num[i] + fullCoor_string_2_num[i]);
                result_int = result_string.Select(x => int.Parse(x)).ToList();
                //Console.WriteLine(result_int[i]);
                /// Aktualizowanie tablicy   /// UWAGA: "outputBoardData" to tablica dwuwymiarowa 10x10
                outputBoardData[player, int.Parse(fullCoor_string_1_num[i]), int.Parse(fullCoor_string_2_num[i])] = "S ";
            }

            // WEŹ PRZEKAŻ PARAMETR NUMERU STATKU I PRZEKAŻ JEGO WARTOŚĆ DO STRINGA WARTOŚCI POJAWIENIA SIĘ STATKU, ABY BYŁO WIADOMO GDZIE KTÓRY JEST!
            // DODATKOWO ZMODYFIKUJ WYGLĄD PLANSZY TAK, ABY * OTACZAŁA OBWÓDKA


            /// Usuwanie indeksów statków:
            for (int i = 0; i < result_int.Count; i++)
            {
                int startIndex = splicedBoard_AR[player].IndexOf(result_int[i]);
                splicedBoard_AR[player].RemoveRange(startIndex, 1);
            }
            //Console.ReadLine();

            /// Test poprawności danych: OK
            /*Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(fieldAreaContent_AR[i, j]);
                }
                Console.Write("");
                Console.WriteLine("");
                if (i < 9)   /// w iteracji dobijamy maksymalnie do 9, bo [i] ma być < 10
                {
                    Console.Write("");
                }
                else if (i >= 9) { }
            }
            Console.ReadLine();*/

            return (outputBoardData, splicedBoard_AR);
        }
    }
    public class ShipBuildChecker
    {
        public (string[], List<List<int>>) shipCoorBuildChecker(string firstCor, string direction, string length, List<List<List<int>>> availableFields, List<List<int>> fullIndexArray, string[] avalLet_AR, string[] avalNum_AR, int players)
        {
            // Konwersja stringowej formy współrzędnej początkowej na formę intową: (B2 -> A = 0, B = 10, C = 20, ... więc B2 = 10 + 2 = 12)
            string[] brdLetCor_AR = avalLet_AR;
            string[] brdNumCor_AR = avalNum_AR;
            string fstCoor_string = firstCor;
            string fstCoor_1_let = fstCoor_string.Substring(0, 1);
            string fstCoor_2_num = fstCoor_string.Substring(1, 1);
            string fstCoor_1_num = "";
            int player = players - 1;
            for (int i = 0; i < avalLet_AR.Length; i++)
            {
                if (fstCoor_1_let == brdLetCor_AR[i])
                /// Jeżeli np.: B == arr[i], to "wynik" = [i] | B jest wartością drugiego indeksu tablicy arr, więc instrukcja spełnia się
                ///na indeksie 2, tej tabeli, a więc [i] wynosi 1 (bo [i] inkrementuje się o jeden po zakończeniu wykonywania jedenj iteracji tej pętli) - wartość B to 1.
                {
                    fstCoor_1_num = i.ToString();
                }
                else { }
            }
            fstCoor_string = fstCoor_1_num + fstCoor_2_num;
            int fstCoor = int.Parse(fstCoor_string);
            /// W sytuacji konwersji stringa "04" na int, C# zignoruje 0 i da samą 4, więc nie trzeba tworzyć nowej zmiennej z 
            /// substringowaną wartością jeżeli pierwszym indeksem (wartości tego typu) "09" będzie "0". Kiedy mamy A0 nie będzie na szczęście błędu, a 0.
            /// Test poprawności: OK
            ///Console.WriteLine(firstCor + " = " + fstCoor);

            /// Deklarowanie zmiennych na podstawie otrzymanych parametrów:
            string dir = direction;
            string lgt = length;
            List<List<int>> fullIndex_AR = fullIndexArray;
            string[] result = { firstCor };   /// Inicjowanie wyniku z tymczasową wartością, byle tylko spełaniała wymóg returnowania przed ogarnięciem wartości wynikowej
            List<List<List<int>>> dangerFieldsGroup_ARS = availableFields;
            /// Wyznaczanie odpowiedniej tabeli zakazanych pól w zależności od długości i kierunku położenia statku:
            int dngFldIdx = int.Parse(lgt) - 2;
            List<List<int>> dangerFieldsGroup_B_ARS = dangerFieldsGroup_ARS[0];
            List<List<int>> dangerFieldsGroup_R_ARS = dangerFieldsGroup_ARS[1];
            List<int> dangerFields_AR = new List<int>();
            if (dir == "B")
            {
                dangerFields_AR = dangerFieldsGroup_B_ARS[dngFldIdx];
            }
            else if (dir == "R")
            {
                dangerFields_AR = dangerFieldsGroup_R_ARS[dngFldIdx];
            }
            /// Test poprawności: OK
            //for (int i = 0; i < dangerFields_AR.Count; i++)
            //{
            //    Console.Write(dangerFields_AR[i] + " | ");
            //}
            /// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            List<int> shipCoordinates = new List<int>();
            /// Jeżeli licznik dobije do 10 niespełnionych warunków - istnienia współrzędnej początkowej w  tablicy pól zakazanych, 
            /// można przekazać ów współrzędną dalej, jeżeli nie, współrzędna zostaje zastąpiona zmienną RESETOWĄ "?".
            int notIsIn_availableFields = 0;
            /// Sprawdzanie czy statek nie wyjdzie poza planszę na podstawie lokalizacji współrzędnej początkowej, względem jego długości i kierunku położenia
            /// (jedyne co mi jest tu potrzebne, to "STAŁA" tablica dostępnych pól, którą zreturnowałem wcześniej, żeby nie robić tu bałaganu)
            for (int i = 0; i < dangerFields_AR.Count; i++)
            {
                if (fstCoor != dangerFields_AR[i])
                {
                    notIsIn_availableFields += 1;
                }
                else if (fstCoor == dangerFields_AR[i])
                {
                    /// Sytuacja: Statek znajduje się poza planszą
                }
            }
            /// Sytuacja: Statek znajduje się poza planszą
            if (notIsIn_availableFields == dangerFields_AR.Count)
            {
                // Sprawdzenie czy punkt początkowy statku jest dostępny w "fullIndex_AR": (tablica dostępnych pól, tablica ruchoma)
                int notIsIn_fullAreasBoardAR = 0;
                for (int j = 0; j < fullIndex_AR[player].Count; j++)
                {
                    if (fstCoor == fullIndex_AR[player][j])
                    {
                        // Dostępne pole do rozpoczęcie tworzenia statku
                    }
                    else if (fstCoor != fullIndex_AR[player][j])
                    {
                        /// Sytuacja: Statek nakłada się na inny statek lub statki
                        notIsIn_fullAreasBoardAR += 1;
                    }
                }
                if (notIsIn_fullAreasBoardAR < fullIndex_AR[player].Count)   /// Dostępne pole do rozpoczęcie tworzenia statku
                {
                    // Włożenie pierwszej współrzędnej
                    shipCoordinates.Add(fstCoor);

                    /// Tworzenie dalszych współrzędnych statku w zależnośći od jego długości i kierunku:
                    /// Ustawianie wartości zmiennnej inkrementującej współrzędne statku, w zależności od kireunku jego położenia:
                    int incrVal = 0;
                    if (dir == "B")
                    {
                        incrVal = 10;
                    }
                    else if (dir == "R")
                    {
                        incrVal = 1;
                    }
                    // Tworzenie dalszych współrzędnych:
                    int nextCoor = fstCoor;   // Utworzenie zmiennej przechowującej nową aktualną współrzędną (później w FORze)
                    for (int k = 1; k < int.Parse(lgt); k++)
                    {
                        nextCoor += incrVal;
                        shipCoordinates.Add(nextCoor);
                    }
                    /// Sprawdzenie czy aktualnie utworzone współrzędne istnieją już w RUCHOMEJ tablicy dostęppnych pół "fullIndex_AR"
                    /// Jeżei istnieją, nie twórz statku i poinformuj gracza o nakładaniu się statków.
                    /// Jeżeli nie istnieją, twórz statki i poinformuj gracza o udanej operacji.
                    int IS_In_fullIndex_AR_nextCoor = 0;
                    for (int i = 0; i < shipCoordinates.Count; i++)
                    {
                        for (int j = 0; j < fullIndex_AR[player].Count; j++)
                        {
                            if (shipCoordinates[i] == fullIndex_AR[player][j])
                            {
                                IS_In_fullIndex_AR_nextCoor += 1;
                                if (IS_In_fullIndex_AR_nextCoor == shipCoordinates.Count)
                                {
                                    for (int k = 0; k < shipCoordinates.Count; k++)
                                    {
                                        /// Usuwanie indeksów z RUCHOMEJ tablicy dostępnych pól, aby dzięki temu móc określić czy statki nie nakładają się na siebie, robiąc odpowiedniego IFa z FORem.
                                        /// Zrobiłem to w metodzie update, GDYŻ kiedy zrobiłbym to tutaj, to tablica została by zmodyfikowana przed decyzją gracza, czy chce ustawić
                                        /// statek z jego współrzędnymi na planszy. Jeżeli napisałby, że nie, to dane zresetowałyby się, ALE tablica pozostałaby zmodyfikowana.
                                        /// Wowczas kiedy gracz chciałby ustawić statek o jedną współrzędną początkową przed usuniętymi indeksami, to kiedy współrzędne dalsze 
                                        /// statku wskazywałyby indeksy usunięte przez położenie pprzedniego statku - mięlibyćmy komunikat o nakładaniu się statkuw, co byłoby 
                                        /// oczywiści błędem.
                                        /// Jako że w instrukcji warunkwej poprzedzającej zapyatnie czy gracz chce zapisać dane mamy specjalną zmienną {?}, którą opisałem wcześniej,
                                        /// nie musimy się martwić o to, że tablica zostanie zmodyfikowana przed sprawdzeniem bezkolizyjności, wychodzenia statku z planszy oraz
                                        /// przedewszsytkim przed naszą niekontrolowaną decyzją w sprawie ustawienia statku, czyli inaczej zmodyfokowania tabeli.
                                    }
                                }
                            }
                        }
                    }
                    if (IS_In_fullIndex_AR_nextCoor < int.Parse(lgt))   // Jeżeli współrzędne statku NIE są dostępne w tablicy RUCHOMEJ - statek nakłada się na inny statek
                    {
                        Console.WriteLine("");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine("");
                        Console.WriteLine("Ship canNOT overlap other ship or ships!");
                        Console.WriteLine("You must give new coordinates.");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();
                        string[] result_STOP = { "?" };   /// {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                        result = result_STOP;
                        // Musiałem użyć tu retunr, gdyż inaczej 
                        //return;
                    }
                    else if (IS_In_fullIndex_AR_nextCoor == int.Parse(lgt))   // Jeżeli współrzędne statku są dostępne w tablicy RUCHOMEJ - na planszy jest wolne miejsce
                    {
                        Console.WriteLine("");
                        Console.WriteLine("- - - - - - - - - - - - - - -");
                        Console.WriteLine("");
                        Console.WriteLine("Ship coordinates are set!");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    /// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
                    /// DO TESTÓW:
                    /// Konwertowanie cyfrowego int[] na string[], aby można było włożyć do go string[] resutl:
                    //int[] result_int = shipCoordinates.ToArray();
                    //string[] result_string = result_int.Select(x => x.ToString()).ToArray();
                    //result = result_string;
                    /// - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
                    //Console.WriteLine("");
                    //Console.WriteLine("- - - - - - - - - - - - - - -");
                    //Console.WriteLine("");
                    //Console.Write("| ");
                    // Test poprawności danych: OK
                    /*for (int z = 0; z < shipCoordinates.Count; z++)
                    {
                        Console.Write(shipCoordinates[z] + " |");
                    }*/
                    //Console.WriteLine("");
                    //Console.WriteLine("Ship coordinates are set!");
                    //Console.WriteLine("Click ENTER key to continue:");
                    //Console.WriteLine("");
                    //Console.ReadLine();
                }
                else if (notIsIn_fullAreasBoardAR == fullIndex_AR[player].Count)
                {
                    Console.WriteLine("");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("");
                    Console.WriteLine("Ship canNOT overlap other ship or ships!");
                    Console.WriteLine("You must give new coordinates.");
                    Console.WriteLine("Click ENTER key to continue:");
                    Console.WriteLine("");
                    Console.ReadLine();
                    string[] result_STOP = { "?" };   /// {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                    result = result_STOP;
                }
            }
            else if (notIsIn_availableFields < dangerFields_AR.Count)   /// Sytuacja: Statek znajduje się poza planszą
            {
                Console.WriteLine("");
                Console.WriteLine("- - - - - - - - - - - - - - - -");
                Console.WriteLine("");
                Console.WriteLine("Ship canNOT located over board!");
                Console.WriteLine("You must give new coordinates.");
                Console.WriteLine("Click ENTER key to continue:");
                Console.WriteLine("");
                Console.ReadLine();
                string[] result_STOP = { "?" };   /// {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                result = result_STOP;
            }

            /// Sprawdzenie czy współrzędna początkowa istnieje w "RUCHOMEJ" tablicy współrzędnych



            /// Konwersja intowej formy współrzędnej początkowej na formę stringową: (24 -> 20 = C, 4 = 4, ... więc 24 = C + "4" = C4)
            if (result[0] != "?")
            {
                string[] returnLetCor_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                string[] returnNumCor_AR = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                List<int> fullCoor_int = new List<int>();
                fullCoor_int = shipCoordinates;
                List<string> fullCoor_string = new List<string>();
                fullCoor_string = fullCoor_int.Select(x => x.ToString()).ToList();
                List<string> fullCoor_string_1_num = new List<string>();
                List<string> fullCoor_string_2_num = new List<string>();
                List<string> fullCoor_string_1_let = new List<string>();
                List<string> result_list = new List<string>();
                //Console.WriteLine("");
                for (int i = 0; i < fullCoor_string.Count; i++)
                {
                    if (fullCoor_string[i].Length == 1)
                    {
                        fullCoor_string_1_num.Add("0");
                        fullCoor_string_2_num.Add(fullCoor_string[i].Substring(0, 1));
                    }
                    else if (fullCoor_string[i].Length == 2)
                    {
                        fullCoor_string_1_num.Add(fullCoor_string[i].Substring(0, 1));
                        fullCoor_string_2_num.Add(fullCoor_string[i].Substring(1, 1));
                    }
                    for (int j = 0; j < returnLetCor_AR.Length; j++)
                    {
                        if (fullCoor_string_1_num[i] == returnNumCor_AR[j])
                        {
                            fullCoor_string_1_let.Add(returnLetCor_AR[j]);
                        }
                        else { }
                    }
                    result_list.Add(fullCoor_string_1_let[i] + fullCoor_string_2_num[i]);
                }
                result = result_list.Select(x => x.ToString()).ToArray();
                //Console.ReadLine();
            }
            else { }
            return (result, fullIndex_AR);
        }
    }
}
