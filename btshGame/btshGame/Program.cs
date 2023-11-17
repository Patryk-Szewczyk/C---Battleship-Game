// Battleship Game

using System;   // Użycie podstawowej biblioteki C#.
using OutputProgram;   // Użycie przestrzeni wyjściowej.
using InputWorkProgram;   // Użycie przestrzeni wykonawczej.
using System.Collections.Generic;   // Użycie biblioteki, któa daje typ generyczny "List".   // DLECZEGO TA BIBLIOTEKA?
// Ta biblioteka była mi bardzo potrzebna, bo daje dostęp do typu generycznego "List", który można wykorzystać w celu utworzenia tablicy o elastycznej długości.
// Elastyczna długość tablicy umożliwia kasowanie indeksów tej tablicy, co jest wymagane w programi tej gry. Jednakże można byłoby to obejść, tworząc nową tablicę
// z odpowiednią liczbą indeksów i odpowiednio do nich przypadającymi wartościami, ale nie ma żadnego sensu utrudniać sobie życia i z tego powodu przypiąłem tą bibliotekę.

// Zrobiłem dwie przesrzenie nazw. Pierwsza jest na klasę główną z główną metodę Main(), która z klasą pełni funkcję tworzenia poszczególnych instancji następujących po sobie
// klas wykonawczyh, które pełnią rolę osobnych komponentów. Druga przestrzeń nazw zawiera ów klasy wynonawcze i inne klasy zwracające wartości do klas wykonawczych.
// Dodatkowa klasy wykonawcze zwracają argumenty do metody Main() klasy Program w pierwszej przestrzeni nazw, aby je użyć jako argumenty w kolejnej metodzie.
namespace OutputProgram   /// Przestrzeń wyjściowa - miejce deklaracji obiektów z klas przestrzeni wykonawczej i aktywowania ich metod
{
    public class Program   // Główna i jedyna klasa przestrzeni wyjściowej
    {
        static void Main(string[] args)   // Główna metoda - odpowiednik natychmiastowej samowywołującej się funkcji z JavaScript ("Immediately-invoked")
        {
            // Intro gry:
            GameIntro gameMenu_Obj = new GameIntro();   /// Tworzenie zmiennej z instancją klasy GameMenu
            gameMenu_Obj.intro();   // Ekran tytułowy
            gameMenu_Obj.instruction();   // Instrukcja gry

            // Gra:
            GameLoop gameLoop = new GameLoop();
            gameLoop.activeGameLoop();   // Pętala gry

            // Napisy końcowe:
            GameCredits gameCredits = new GameCredits();
            gameCredits.showCredits();   // Napisy końcowe
        }
    }
}

namespace InputWorkProgram   // Przestrzeń wykonawcza - miejsce deklaracji klas z określonymi metodami.
{
    public class GameIntro : Program
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
            Console.WriteLine("Battleship [Version 1.00]");
            Console.WriteLine("Copyright (c) Patryk Szewczyk. All rights reserved.");   // Prawa autorskie zastrzeżone. Tylko do własnego użytku. Zakaz kopiowana i zarabiania na tym produkcie.
            Console.WriteLine("");
            Console.WriteLine("Battleship Game is simple game which depend of sunking ships between players.");
            Console.WriteLine("To start game you must do a few activites to mainly set ships.");
            Console.WriteLine("");
            Console.WriteLine("I yery please YOU about enable full screen.");
            Console.WriteLine("In else case you see errors in figure of NOT clearing console code (in console top).");
            Console.WriteLine("");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("");
            Console.WriteLine("To continue with the instructions, click ENTER key");
            Console.WriteLine("");
            Console.ReadLine();   // Aby przejść dalej do kolejnej pseudo-strony konsoli (metoda "Console.Clear()") trzeba kliknąć ENTER
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
            Console.WriteLine("1. Every player have a 7 ships.");
            Console.WriteLine("2. Every player must set our every ship on our board.");
            Console.WriteLine("3. Each ship has a certain length and direction.");
            Console.WriteLine("4. Ships can be placed on board in two types of positions: horizontal and vertical.");
            Console.WriteLine("5. The player boards have dimensions of 10 x 10 fields.");
            Console.WriteLine("6. When placing ships, ships canNOT leave the board and canNOT overlap each other.");
            Console.WriteLine("7. After placing the ships on the boards, you can start the game.");
            Console.WriteLine("8. At the beginning, all squares of the board are marked with the sign \"~\" on the board.");
            Console.WriteLine("9. A hit ship is marked with a series of number from 1 to 7 according to ship number on the board.");
            Console.WriteLine("10. The hit is marked with an \"X\" on the board.");
            Console.WriteLine("11. The miss is marked with an \"O\" on the board.");
            Console.WriteLine("12. If you sink enemy ship, this ship coordinates emerge under boards in players ships info.");
            Console.WriteLine("13. To attack an opponent, the player must enter coordinates such like: \"H8\".");
            Console.WriteLine("14. Players shooting together by turns.");
            Console.WriteLine("15. The winner is this one who defeats his enemy.");
            Console.WriteLine("16. The winner get prize in the image of 10 000 $");
            Console.WriteLine("17. After game players can play game again or get in game credits.");
            Console.WriteLine("");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("");
            Console.WriteLine("To continue with the ships positing on the players boards, click ENTER key");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
    public class GameLoop : Program
    {
        public void activeGameLoop()
        {
            // Gra - zapętlenie gry: (w celu umożliwienia ponownej gry)
            string isGameLoop = "yes";
            while (isGameLoop == "yes")   // Zapętlenie gry, w celu umożliwienia ponownego zagrania  w nią:
            {
                // Tworzenie instancji klasy GameMenu:
                GameProper gameProper = new GameProper();

                // Ustawianie statków:
                string[,] playersShipCoorData_AR = gameProper.setPlayersShips();

                // Walka:
                string winner = gameProper.fight(playersShipCoorData_AR);

                // Nagroda:
                Prize prize = new Prize();
                isGameLoop = prize.winnerInfo(winner);
            }
        }
    }
    public class GameCredits : Program
    {
        public void showCredits()
        {
            Console.Clear();
            Console.WriteLine(" BBBBBB     BBBB    BBBBBBBB  BBBBBBBB     BBBBBBB  BBBBBBB   BBBBBBBB  BBBBBB    BB  BBBBBBBB   BBBBBBB");
            Console.WriteLine("BB    BB   BB  BB   BB BB BB  BB          BB        BB    BB  BB        BB   BB   BB     BB     BB      ");
            Console.WriteLine("BB        BB    BB  BB BB BB  BB          BB        BB    BB  BB        BB    BB  BB     BB     BB      ");
            Console.WriteLine("BB  BBBB  BBBBBBBB  BB BB BB  BBBBBBBB    BB        BBBBBBB   BBBBBBBB  BB    BB  BB     BB      BBBBBB ");
            Console.WriteLine("BB    BB  BB    BB  BB BB BB  BB          BB        BB    BB  BB        BB    BB  BB     BB           BB");
            Console.WriteLine("BB    BB  BB    BB  BB BB BB  BB          BB        BB    BB  BB        BB   BB   BB     BB           BB");
            Console.WriteLine(" BBBBBB   BB    BB  BB BB BB  BBBBBBBB     BBBBBBB  BB    BB  BBBBBBBB  BBBBBB    BB     BB     BBBBBBB ");
            Console.WriteLine("");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine("");
            Console.WriteLine("Thank you very much for the time, which you spent playing my game.");
            Console.WriteLine("");
            Console.WriteLine("Game author: Patryk Szewczyk - AHNS computer science's student - 1 INF");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Click ENTER key to end program:");
            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();
        }
    }
    public class GameProper : GameLoop
    {
        public string[,] setPlayersShips()
        {
            // Tworzenie instancji klasy "BoardContentMaker" i wywołanie metoda odpowiadaojący za tablice związane z plansza:
            BoardContentMaker boardContentMaker_Obj = new BoardContentMaker();
            string[,] playersShipCoor_AR = new string[2, 7];   // Tablica na współrzędne statków wszystkich graczy (współrzędne statku są jednym stringiem, który później jest rozdzielany i konwertowany według potrzeb.)
            string[,,] playersBoardContent_AR = boardContentMaker_Obj.set_fieldAreaContent_AR();   // [2, 10, 10]
            List<List<int>> fullIndex_AR = boardContentMaker_Obj.set_fullIndex_AR();   // Osobna metoda z return
            List<List<List<int>>> dangerFields_AR = boardContentMaker_Obj.set_dangerFields_AR();   // Osobna metoda z return
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
            bool isCoor = true;  // true - musi być niewidozne dopóki kierunek nie jest określony
            string firstCoor = "";
            string[] shipFullCoor = { "" };
            bool isDone = false;
            string wantSave = "none";
            string[] letCoorName_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            while (players < 2)
            {
                players += 1;
                shipPage = 0;
                // Ustawianie statków dla każdego gracza:
                while (shipPage < 8)   // - do 6 ustawianie | 7 - komunikat o zakończeniu ustawiania statków dla gracza
                {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("               PLAYER " + players);
                    Console.WriteLine("                                     ");
                    Console.WriteLine("         0 1 2 3 4 5 6 7 8 9         ");
                    Console.WriteLine("         -------------------         ");
                    Console.Write("     ");   // lewa strona planszy
                                              // Wyświetlanie  planszy tablicy za pomocą pętli zagnieżdżonej iterującej tablicę dwuwymiarową:
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(letCoorName_AR[i] + " | ");
                        for (int j = 0; j < 10; j++)
                        {
                            // tablica trzywymiarowa, (players - 1) - players jest inkrementowane na początku pętli,
                            // a indeksy rozpoczynają się od zera, więc daltego mamy (players - 1)
                            Console.Write(playersBoardContent_AR[(players - 1), i, j]);
                        }
                        Console.Write("|");
                        Console.WriteLine("    ");   // prawa strona planszy
                        if (i < 9)   // w iteracji dobijamy maksymalnie do 9, bo [i] ma być < 10
                        {
                            Console.Write("     ");   // lewa strona planszy
                        }
                        else if (i >= 9) { }
                    }
                    Console.WriteLine("         -------------------         ");
                    Console.WriteLine("                                     ");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("");
                    if (shipPage < 7)   // 7 jest przeznaczone tylko dla komunikato o zakończeniu ustawianai statków dla gracza. W poniższych sytuacjach trzeba zmniejszyć o 1, gdyż w przeciwnym razie lecimy o 1 statek do góry, przez co mam złe wartości liczbowe i błąd w Array (RangeOf)
                    {
                        Console.WriteLine("Set " + (shipPage + 1).ToString() + "/7 ship:");
                        Console.WriteLine("Type: " + shipTypeName_AR[shipPage]);
                        Console.WriteLine("Length: " + shipLengthName_AR[shipPage]);
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
                    }
                    else { }
                    if (isBegAgn_FromDir == true && shipPage == 0)
                    {
                        Console.WriteLine("You must set all 7 ships to continue.");
                        Console.WriteLine("");
                        Console.WriteLine("To continue you must click ENTER key.");
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    else { }
                    if (isDirCoor == false || shipFullCoor[0] == "?")   // {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                    {
                        if (isDir == false && shipPage < 7)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("               PLAYER " + players);
                            Console.WriteLine("                                     ");
                            Console.WriteLine("         0 1 2 3 4 5 6 7 8 9         ");
                            Console.WriteLine("         -------------------         ");
                            Console.Write("     ");   // lewa strona planszy
                                                      // Wyświetlanie  planszy tablicy za pomocą pętli zagnieżdżonej iterującej tablicę dwuwymiarową:
                            for (int i = 0; i < 10; i++)
                            {
                                Console.Write(letCoorName_AR[i] + " | ");
                                for (int j = 0; j < 10; j++)
                                {
                                    // tablica trzywymiarowa, (players - 1) - players jest inkrementowane na początku pętli,
                                    // a indeksy rozpoczynają się od zera, więc daltego mamy (players - 1)
                                    Console.Write(playersBoardContent_AR[(players - 1), i, j]);
                                }
                                Console.Write("|");
                                Console.WriteLine("    ");   // prawa strona planszy
                                if (i < 9)   // w iteracji dobijamy maksymalnie do 9, bo [i] ma być < 10
                                {
                                    Console.Write("     ");   // lewa strona planszy
                                }
                                else if (i >= 9) { }
                            }
                            Console.WriteLine("         -------------------         ");
                            Console.WriteLine("                                     ");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("");
                            if (shipPage < 7)   // 7 jest przeznaczone tylko dla komunikato o zakończeniu ustawianai statków dla gracza. W poniższych sytuacjach trzeba zmniejszyć o 1, gdyż w przeciwnym razie lecimy o 1 statek do góry, przez co mam złe wartości liczbowe i błąd w Array (RangeOf)
                            {
                                Console.WriteLine("Set " + (shipPage + 1).ToString() + "/7 ship:");
                                Console.WriteLine("Type: " + shipTypeName_AR[shipPage]);
                                Console.WriteLine("Length: " + shipLengthName_AR[shipPage]);
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
                            }
                            else { }
                            Console.WriteLine("\"B\" - vertical position (from top to bottom: A2 -> B2, C2)");
                            Console.WriteLine("\"R\" - horizontal position (from left to right: A2 -> A3, A4)");
                            Console.WriteLine("");
                            selectDirection = Console.ReadLine();
                            if (selectDirection == "B" || selectDirection == "R")
                            {
                                shipPageIncrement = 0;
                                isBegAgn_FromDir = false;
                                isDir = true;
                                isCoor = false;
                                Console.WriteLine("");
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                                Console.WriteLine("");
                                Console.WriteLine("Direction is saved!");
                                Console.WriteLine("");
                                Console.WriteLine("To continue click ENTER key");
                                Console.WriteLine("");
                                Console.ReadLine();
                            }
                            else if (selectDirection != "B" || selectDirection != "R")
                            {
                                shipPageIncrement = 0;
                                isBegAgn_FromDir = false;
                                Console.WriteLine("");
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                                Console.WriteLine("");
                                Console.WriteLine("You write uncorrect value.");
                                Console.WriteLine("Direction value must be \"B\" or \"R\" !");
                                Console.WriteLine("");
                                Console.WriteLine("To continue click ENTER key");
                                Console.WriteLine("");
                                Console.ReadLine();
                            }
                        }
                        else { }
                        if ((isCoor == false && shipPage < 7) || (shipFullCoor[0] == "?" && shipPage < 7))
                            // "?" Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego
                            // wyznaczenia współrzędnej początkowej. "?" Jest inaczej odpowiednikiem zmiennej "isDone". "?" to zwracana wartość współrzędnych
                            // statku z "ShipCheckerBuildera" w przypadku niespełanienia warunków walidacji. Zastosowano ją w powyższym warunku, aby dokładniej
                            // określić w jakiej sytuacji warunek ten ma być spełniony, aby wykonać poniższe instrukcje.
                            // 
                            // UWAGA! {?} oznacza to co u góry zapisane, natopiast isDone jest dla wartością wyniku informacji o współrzędnych statku "?".
                            // Użyłem isDone, gdyż nie dało się tego zrobić na sanmym shipFullCoolp[], gdyż [bla bla bla] i z tego powodu musiałem zastosować tą zmienną
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("               PLAYER " + players);
                            Console.WriteLine("                                     ");
                            Console.WriteLine("         0 1 2 3 4 5 6 7 8 9         ");
                            Console.WriteLine("         -------------------         ");
                            Console.Write("     ");   // lewa strona planszy
                            // Wyświetlanie  planszy tablicy za pomocą pętli zagnieżdżonej iterującej tablicę dwuwymiarową:
                            for (int i = 0; i < 10; i++)
                            {
                                Console.Write(letCoorName_AR[i] + " | ");
                                for (int j = 0; j < 10; j++)
                                {
                                    // tablica trzywymiarowa, (players - 1) - players jest inkrementowane na początku pętli,
                                    // a indeksy rozpoczynają się od zera, więc daltego mamy (players - 1)
                                    Console.Write(playersBoardContent_AR[(players - 1), i, j]);
                                }
                                Console.Write("|");
                                Console.WriteLine("    ");   // prawa strona planszy
                                if (i < 9)   // w iteracji dobijamy maksymalnie do 9, bo [i] ma być < 10
                                {
                                    Console.Write("     ");   // lewa strona planszy
                                }
                                else if (i >= 9) { }
                            }
                            Console.WriteLine("         -------------------         ");
                            Console.WriteLine("                                     ");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("");
                            // Użyłęm to boola, ponieważ kiedy wyznaczę ostatni statek normalnie pojawi się niewiadomy stan 7 statku,
                            // który jest już ustawiony, a dobrze byłoby gdyby te informacje wraz z kreską "- - " zniknęły.
                            if (shipPage < 7)   // 7 jest przeznaczone tylko dla komunikato o zakończeniu ustawianai statków dla gracza. W poniższych sytuacjach trzeba zmniejszyć o 1, gdyż w przeciwnym razie lecimy o 1 statek do góry, przez co mam złe wartości liczbowe i błąd w Array (RangeOf)
                            {
                                Console.WriteLine("Set " + (shipPage + 1).ToString() + "/7 ship:");
                                Console.WriteLine("Type: " + shipTypeName_AR[shipPage]);
                                Console.WriteLine("Length: " + shipLengthName_AR[shipPage]);
                                if (isDir == false)
                                {
                                    Console.WriteLine("Direction: ?");
                                }
                                else if (isDir == true)
                                {
                                    Console.WriteLine("Direction: " + selectDirection);
                                }
                                if (isCoor == true || isDone == false)   // isDone - kiedy nie ma określonych współrzędnych, lub nie przeszły testu poprawności
                                {
                                    Console.WriteLine("Coordination: ?");
                                }
                                else if (isCoor == false && isDone == true)   // isDone - współrzędne przeszły testy poprawności i są ustalone. Musiałem to zrobić, gdyż w pewnym momencie pojawiało się niechciane puste pole bez "?".
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
                                Console.WriteLine("Write value from A0 to J8:");
                                Console.WriteLine("");
                                firstCoor = Console.ReadLine();
                            }
                            else { }
                            if (firstCoor.Length != 2)   // Sprawdzenie czy współrzędna początkowa ma odpowiednią długość.
                            {
                                Console.WriteLine("");
                                Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                                Console.WriteLine("");
                                Console.WriteLine("Your value\'s length is uncorrect. ");
                                Console.WriteLine("You must change it.");
                                Console.WriteLine("");
                                Console.WriteLine("Click ENTER key to continue:");
                                Console.WriteLine("");
                                Console.ReadLine();
                            }
                            else if (firstCoor.Length == 2)   // Jeżeli wartość i odpowiednia długość jest, wprowadź poprawność wartości.
                            {
                                string letter = firstCoor.Substring(0, 1);
                                string number = firstCoor.Substring(1, 1);
                                string[] avalLet_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                                string[] avalNum_AR = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                                bool isIn_avalLet_AR = false;
                                bool isIn_avalNum_AR = false;
                                for (int i = 0; i < avalLet_AR.Length; i++)
                                {
                                    // Sprawdzenie czy pierwszy substringowany indeks współrzędnej początekowej istnieje w tablicy liter:
                                    if (avalLet_AR[i] == letter)
                                    {
                                        isIn_avalLet_AR = true;
                                    }
                                    else { }
                                    // Sprawdzenie czy drugi substringowany indeks współrzędnej początekowej istnieje w tablicy cyfr:
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
                                    // Przekazywanie wszystkich potrzebnych argumaentów do medoty (obiektu danej klasy) tworzącej statek i jednocześnie sprawdzającej
                                    // czy ów statek wychodzi poza pole planszy oraz czy nakłada się na inny / inne statki:
                                    ShipBuildChecker shipBuildChecker_Obj = new ShipBuildChecker();
                                    // Za każdym ułożeniem statku, tabela pozycji pól planszy ma skracać się o współrzędne statku i z tego powodu potrzebne było aktualizowanie
                                    // ów tabeli poza pętlą while, aby zachować jej zaktualizowany stan i ponownie ją przekazać do obróbki. W tym celu użyłem krotki ze standardu 7.0:
                                    (string[], List<List<int>>, bool) tuples_1 = shipBuildChecker_Obj.shipCoorBuildChecker(firstCoor, selectDirection, shipLengthName_AR[shipPage], dangerFields_AR, fullIndex_AR, players, isDone);
                                    shipFullCoor = tuples_1.Item1;
                                    fullIndex_AR = tuples_1.Item2;
                                    isDone = tuples_1.Item3;
                                    string playerShipCoor = "";
                                    for (int i = 0; i < shipFullCoor.Length; i++)
                                    {
                                        if (i == 0)
                                        {
                                            playerShipCoor += shipFullCoor[i];
                                        }
                                        else if (i > 0)
                                        {
                                            playerShipCoor += "|" + shipFullCoor[i];
                                        }
                                    }
                                    playersShipCoor_AR[players - 1, shipPage] = playerShipCoor;
                                }
                                else if (isIn_avalLet_AR == false || isIn_avalNum_AR == false)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                                    Console.WriteLine("");
                                    Console.WriteLine("This area NOT exists in our board!");
                                    Console.WriteLine("");
                                    Console.WriteLine("Click ENTER key to continue:");
                                    Console.WriteLine("");
                                    Console.ReadLine();
                                }
                                else { }
                            }
                        }
                        else { }
                    }
                    else if (isDirCoor == true && shipFullCoor[0] != "?")   // {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                    {
                        Console.WriteLine("Do you want save this ship data?");
                        Console.WriteLine("Write \"yes\" or \"no\".");
                        Console.WriteLine("");
                        wantSave = Console.ReadLine();
                        if (wantSave == "yes" && shipPage < 7)
                        {
                            // Aktualizacja planszy poprzez umieszczeni na niej nowego statku
                            BoardContentMaker shipBuildChecker_Obj = new BoardContentMaker();
                            (string[,,], List<List<int>>) updBrdData = shipBuildChecker_Obj.updateBoardContent(fullIndex_AR, shipFullCoor, playersBoardContent_AR, players, shipPage);
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
                            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("");
                            Console.WriteLine("Your ship data is saved!");
                            Console.WriteLine("");
                            Console.WriteLine("Click ENTER key to continue:");
                            Console.WriteLine("");
                            Console.ReadLine();
                            // Przejście do kolejnego statku:
                            shipPageIncrement = 1;
                            // Reset zmiennych potrzebnych do wypełniania informacji o kolejnym statku i związanych z nimi przełączników:
                            isDir = false;
                            isBegAgn_FromDir = true;
                            isCoor = true;   // Niewidoczne, bo najpierw trzeba ogarnąć kierunek, a potem wyświetlić zapytanie o współrzędną początkową
                            isDone = false;
                            isDirCoor = false;
                            firstCoor = "";
                            Array.Clear(shipFullCoor, 0, shipFullCoor.Length);
                            wantSave = "none";
                        }
                        else if (wantSave == "no" && shipPage < 7)
                        {
                            // Reset wszystkich słiczów i ponowne pozycjonowanie statku
                            Console.WriteLine("");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("");
                            Console.WriteLine("Your ship data is deleted.");
                            Console.WriteLine("You must posite ship again.");
                            Console.WriteLine("");
                            Console.WriteLine("Click ENTER key to continue:");
                            Console.WriteLine("");
                            Console.ReadLine();
                            // Reset zmiennych potrzebnych do wypełniania informacji o bieżącym statu i związanych z nimi przełączników:
                            isDir = false;
                            isBegAgn_FromDir = true;
                            isCoor = true;   // Niewidoczne, bo najpierw trzeba ogarnąć kierunek, a potem wyświetlić zapytanie o współrzędną początkową
                            isDone = false;
                            isDirCoor = false;
                            firstCoor = "";
                            Array.Clear(shipFullCoor, 0, shipFullCoor.Length);
                            wantSave = "none";
                        }
                        else if (wantSave != "yes" || wantSave != "no")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
                            Console.WriteLine("");
                            Console.WriteLine("You write uncorrect value.");
                            Console.WriteLine("");
                            Console.WriteLine("Click ENTER key to continue:");
                            Console.WriteLine("");
                            Console.ReadLine();
                        }
                    }
                    if (shipPage == 7 && isSetPlayerShipCoor == true)
                    {
                        // Informacja o ustawieniu wszystkich statków:
                        if (players == 1)
                        {
                            Console.WriteLine("You set all ships. Now you make a");
                            Console.WriteLine("mental note yours ship with them");
                            Console.WriteLine("coordinates and next to second player.");
                        }
                        else if (players == 2)
                        {
                            Console.WriteLine("You set all ships. Now you go to");
                            Console.WriteLine("game and you begin fight for life!");
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();
                        // Reset wszystkigo co potrzebne do ponownego ustawienia statków dla kolejnego gracza:
                        isSetPlayerShipCoor = false;   // ustawione współrzędne statków
                        isDir = false;   // usunięty kierunek ostatniego statku
                        isBegAgn_FromDir = true;
                        isCoor = true;   // Niewidoczne, bo najpierw trzeba ogarnąć kierunek, a potem wyświetlić zapytanie o współrzędną początkową
                        isDone = false;
                        isDirCoor = false;
                        firstCoor = "";
                        Array.Clear(shipFullCoor, 0, shipFullCoor.Length);
                        wantSave = "none";
                    }
                    shipPage += shipPageIncrement;
                }
            }
            return playersShipCoor_AR;
        }
        public string fight(string[,] playersShipCoor_AR)
        {
            // Deklaracja głównych zmiennych:
            string[,] playersShips_AR_toConvert = new string[2, 7];
            playersShips_AR_toConvert = playersShipCoor_AR;
            string winner = "";

            // Konwersja tablicy [,] współrzędnych statków dla danego gracza na tablicę "List" w celu rozdzielenia stringowych "połączonych" 
            // współrzędnych w rozdzielone stringowe znajdujące się w doatkowej tablicy. 
            List<List<List<string>>> playersShips_string_AR = new List<List<List<string>>>();   // gracz -> statek -> współrzędne -> współrzędna
            List<List<string>> player_1_Ships_string_AR = new List<List<string>>();
            List<List<string>> player_2_Ships_string_AR = new List<List<string>>();
            playersShips_string_AR.Add(player_1_Ships_string_AR);
            playersShips_string_AR.Add(player_2_Ships_string_AR);
            List<string> onceShipCoor_string_AR = new List<string>();
            string[] splitVal_string_AR = { };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    splitVal_string_AR = playersShips_AR_toConvert[i, j].Split("|");
                    onceShipCoor_string_AR = splitVal_string_AR.Select(x => x.ToString()).ToList();
                    playersShips_string_AR[i].Add(onceShipCoor_string_AR);
                }
                playersShips_string_AR.Add(playersShips_string_AR[i]);
            }

            // Tablica zanaków zapytania "?":
            List<List<List<string>>> playersShips_unknown_AR = new List<List<List<string>>>();
            for (int i = 0; i < 2; i++)
            {
                List<List<string>> playersShips_unknown_NS1_AR = new List<List<string>>();
                for (int j = 0; j < 7; j++)
                {
                    List<string> playersShips_unknown_NS2_AR = new List<string>();
                    for (int k = 0; k < playersShips_string_AR[i][j].Count; k++)
                    {
                        playersShips_unknown_NS2_AR.Add("??");
                    }
                    playersShips_unknown_NS1_AR.Add(playersShips_unknown_NS2_AR);
                }
                playersShips_unknown_AR.Add(playersShips_unknown_NS1_AR);
            }

            // Konwersja tablicy współrzędnych typu: "C2" na współrzędne typu: "22" i konwersja ze sring na int:
            List<List<List<int>>> playersShips_int_AR = new List<List<List<int>>>();   // gracz -> statek -> współrzędne -> współrzędna
            for (int i = 0; i < 2; i++)   // gracze
            {
                List<List<int>> playerShips_int_AR = new List<List<int>>();
                for (int j = 0; j < 7; j++)   // statek
                {
                    List<int> onceShipCoor_int_AR = new List<int>();
                    for (int k = 0; k < playersShips_string_AR[i][j].Count; k++)   // współrzędne
                    {
                        // Podmienianie liter na cyfry, łączenie i konwersja na int:
                        string toSliceVal = playersShips_string_AR[i][j][k];
                        string sign_1_let = toSliceVal.Substring(0, 1);
                        string sign_2_num = toSliceVal.Substring(1, 1);
                        string sign_1_num = "";
                        string result_string = "";
                        int result_int = 0;
                        string[] let_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                        string[] num_AR = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                        for (int l = 0; l < let_AR.Length; l++)
                        {
                            if (sign_1_let == let_AR[l])
                            {
                                sign_1_num = num_AR[l];
                            }
                            else { }
                        }
                        result_string = sign_1_num + sign_2_num;
                        result_int = int.Parse(result_string);
                        onceShipCoor_int_AR.Add(result_int);
                    }
                    playerShips_int_AR.Add(onceShipCoor_int_AR);
                }
                playersShips_int_AR.Add(playerShips_int_AR);
            }

            // Zmienne potrzebne do walki
            bool isFight = true;
            int attackPlayer = 0;
            int gamePlayer = attackPlayer;
            string playerReadLine = "";
            bool isPlayerChoose = false;   // Do resetu do GAME AGAIN dodatkoweo swich ten uniemożliwia przejścia do strzelania, przed usunięciem wybierania gracza z konsoli.
            bool isReturn = true;   // Przełącznik - zrobiłem go, aby zatrzymywać się na tym samym graczu, kiedy poda niepoprawną współrzędną i poda współrzędną, którą już podał.
            bool isMiss = true;   // Jeżeli gracz trafił wroga, następny strzał będzie tego bracza. Gracz strzela dokpóki nie trafi. Jeżeli nie trafi, strzelać zaczyna wróg. I odnośnie wroga jest tak samo.
            bool isWinner = false;   // Jeżeli jest zwycięzca, to zatrzymaj zapytnia o atakowanie gracza i aktykuj komunikat o wygranej.
            BoardContentMaker boardContentMaker_Obj = new BoardContentMaker();
            // Tworzenie dwóch graficznych tablic na status walki dla graczy:
            string[,,] playersBoardFight_AR = boardContentMaker_Obj.set_fieldAreaContent_AR();   // [2, 10, 10]
            List<List<int>> playersBoardFight_intToSplice_AR = new List<List<int>>();
            playersBoardFight_intToSplice_AR = boardContentMaker_Obj.set_fullIndex_AR();

            // Pętla walki:
            while (isFight == true)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("                  PLAYER 1                         PLAYER 2              ");
                Console.WriteLine("                                                                         ");
                Console.WriteLine("            0 1 2 3 4 5 6 7 8 9              0 1 2 3 4 5 6 7 8 9         ");
                Console.WriteLine("            -------------------              -------------------         ");
                Console.Write("     ");
                string[] letCoorName_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("   " + letCoorName_AR[i] + " | ");
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(playersBoardFight_AR[0, i, j]);
                    }
                    Console.Write("|        ");
                    Console.Write(letCoorName_AR[i] + " | ");
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write(playersBoardFight_AR[1, i, j]);
                    }
                    Console.Write("|");
                    Console.WriteLine("   ");
                    if (i < 9)
                    {
                        Console.Write("     ");
                    }
                    else if (i >= 9) { }
                }
                Console.WriteLine("            -------------------              -------------------         ");
                Console.WriteLine("");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("");
                string[] space_AR = {"                   ", "              ", "         ", "    "};
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("        " + (j + 1).ToString() + ". | ");
                    for (int k = 0; k < playersShips_unknown_AR[0][j].Count; k++)
                    {
                        // Zrobiłem to na dwie pętle, gyż chciałem mieć odstęp pomiędzy poszczególnyi statkami danego gracza oraz przejście do nowej linii,
                        // a to wszystko w tym samym zakresie (FORy).
                        // Gracz 1:
                        if (k == 0)
                        {
                            Console.Write(playersShips_unknown_AR[0][j][k]);
                        }
                        else if (k > 0)
                        {
                            Console.Write(" | " + playersShips_unknown_AR[0][j][k]);
                        }
                    }
                    Console.Write(" |");
                    // Użyłem instrukcji switch, ponieważ mam dużo opcji z daną wartością do osiągnięcia za pomocą operatora porównania (==):
                    switch (playersShips_unknown_AR[0][j].Count)
                    {
                        case 2:
                            Console.Write(space_AR[0]);
                            break;
                        case 3:
                            Console.Write(space_AR[1]);
                            break;
                        case 4:
                            Console.Write(space_AR[2]);
                            break;
                        case 5:
                            Console.Write(space_AR[3]);
                            break;
                    }
                    Console.Write((j + 1).ToString() + ". | ");
                    for (int k = 0; k < playersShips_unknown_AR[1][j].Count; k++)
                    {
                        // Gracz 2:
                        if (k == 0)
                        {
                            Console.Write(playersShips_unknown_AR[1][j][k]);
                        }
                        else if (k > 0)
                        {
                            Console.Write(" | " + playersShips_unknown_AR[1][j][k]);
                        }
                    }
                    Console.Write(" |");
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("");
                if (isWinner == true)
                {
                    isFight = false;
                    // "isFigth" jest odpowiedzialny za robienie pętli, w której są plansze i informacje o statkach, graczy i z tego powidyj nie mogę użyć
                    // bezpoścrednio switcha isFight. Gdybym go użył, pętal zakończyłaby działanie, zanim pojawiłby się komunikat o wygranej.
                    // Mogłem to obejść, nie robiąc takiej mechaniki, a poprostu w metodzie fire() lub tej dać u dołu infrmacje o wygranej
                    // kopiując plansze i informacje o statkach, ALE po co, skoro mogę rozwiązać to, zaoszczędzając kilkadziesiąt linijek kodu?
                    // Dodatkowo gdybym zrobił to w pętli z "isFight", to informacja o wygranej wyświetliłąby sie po informacji o zapisanej wspólrzędnej, 
                    // a ja chcę ją mieś osobno.
                }
                if (isPlayerChoose == false && isFight == true)
                {
                    Console.WriteLine("Choose which player begin game as first.");
                    Console.WriteLine("Write: \"P1\" (player 1) or \"P2\" (player 2)");
                    playerReadLine = Console.ReadLine();
                    if (playerReadLine == "P1")
                    {
                        isPlayerChoose = true;
                        attackPlayer = 0;
                        gamePlayer = 1;
                        // Dlaczego 1, a nie zero i u dołu tak samo? Bo w atakowaniu wroga za każdym razem zmieniane tą zmienną: 0 -> 1 | 0 -> 1,
                        // (odpowiedni indeks od razu) kiedy gracze atakują się nawzajem i nie chciałem robić dodatkowego tam bool'a.
                        Console.WriteLine("");
                        Console.WriteLine("You choose: PLAYER 1");
                        Console.WriteLine("");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    else if (playerReadLine == "P2")
                    {
                        isPlayerChoose = true;
                        attackPlayer = 1;
                        gamePlayer = 0;
                        Console.WriteLine("");
                        Console.WriteLine("You choose: PLAYER 2");
                        Console.WriteLine("");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("You write uncorrect value.");
                        Console.WriteLine("");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                }
                else if (isPlayerChoose == true && isFight == true)
                {
                    if (isReturn == true)
                    {
                        isReturn = false;
                        // "isMiss" - jeżeli gracz trafił wroga, następny strzał będzie tego bracza. Gracz strzela dokpóki nie trafi.
                        // Jeżeli nie trafi, strzelać zaczyna wróg. I odnośnie wroga jest tak samo.
                        if (isMiss == true)
                        {
                            gamePlayer = attackPlayer;
                            if (attackPlayer == 0)
                            {
                                attackPlayer = 1;
                            }
                            else if (attackPlayer == 1)
                            {
                                attackPlayer = 0;
                            }
                        }
                        else { }
                    }
                    else { }
                    Console.WriteLine("PLAYER " + (gamePlayer + 1).ToString());
                    Console.WriteLine("");
                    Console.WriteLine("Attack: PLAYER " + (attackPlayer + 1));
                    Console.WriteLine("Choose field, which you want attack.");
                    Console.WriteLine("Write value from A0 to J9:");
                    Console.WriteLine("");
                    string fireCoor = Console.ReadLine();
                    if (fireCoor == null)   // Sprawdzenie czy współrzędna początkowa nie jest pusta.
                    {
                        isReturn = false;
                        Console.WriteLine("");
                        Console.WriteLine("You can\'t left empty value.");
                        Console.WriteLine("");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();

                    }
                    else if (fireCoor != null)
                    {
                        if (fireCoor.Length != 2)   // Sprawdzenie czy współrzędna początkowa ma odpowiednią długość.
                        {
                            isReturn = false;
                            Console.WriteLine("");
                            Console.WriteLine("Your value\'s length is uncorrect.");
                            Console.WriteLine("");
                            Console.WriteLine("Click ENTER key to continue:");
                            Console.WriteLine("");
                            Console.ReadLine();
                        }
                        else if (fireCoor.Length == 2)   // Jeżeli wartość i odpowiednia długość jest, wprawdź poprawność wartości.
                        {
                            string letter = fireCoor.Substring(0, 1);
                            string number = fireCoor.Substring(1, 1);
                            string[] avalLet_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                            string[] avalNum_AR = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                            bool isIn_avalLet_AR = false;
                            bool isIn_avalNum_AR = false;
                            for (int i = 0; i < avalLet_AR.Length; i++)
                            {
                                // Sprawdzenie czy pierwszy substringowany indeks współrzędnej początekowej istnieje w tablicy liter:
                                if (avalLet_AR[i] == letter)
                                {
                                    isIn_avalLet_AR = true;
                                }
                                else { }
                                // Sprawdzenie czy drugi substringowany indeks współrzędnej początekowej istnieje w tablicy cyfr:
                                if (avalNum_AR[i] == number)
                                {
                                    isIn_avalNum_AR = true;
                                }
                                else { }
                            }
                            if (isIn_avalLet_AR == true && isIn_avalNum_AR == true)
                            {
                                // Konwersja: "D2" -> "32" (część potrzebnych rzeczy znajduje się na górze)
                                string letToNum = "";
                                string joinVal = "";
                                int fireCoorConv = 0;
                                for (int i = 0; i < avalLet_AR.Length; i++)
                                {
                                    if (letter == avalLet_AR[i])
                                    {
                                        letToNum = avalNum_AR[i];
                                        joinVal = letToNum + number;
                                        fireCoorConv = int.Parse(joinVal);
                                    }
                                    else { }
                                }

                                // Sprawdzanie czy wybrana współrzędna istnieje w tablicy współrzędnych: (tablica stringoaw [,,])
                                if (playersBoardFight_AR[attackPlayer, int.Parse(letToNum), int.Parse(number)] == "X " || playersBoardFight_AR[attackPlayer, int.Parse(letToNum), int.Parse(number)] == "O ")
                                {
                                    isReturn = false;
                                    Console.WriteLine("");
                                    Console.WriteLine("You already attacked this field.");
                                    Console.WriteLine("");
                                    Console.WriteLine("Click ENTER key to continue:");
                                    Console.WriteLine("");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    isReturn = true;
                                    Console.WriteLine("");
                                    Console.WriteLine("Choosed coordinate: " + fireCoor.ToString());
                                    Console.WriteLine("");
                                    Console.WriteLine("Click ENTER key to continue:");
                                    Console.WriteLine("");
                                    Console.ReadLine();
                                }

                                // Tworzenie instancji klasy strzelania i odpalanie medoty odpowiedzialnej za logikę strzelania:
                                ShipCannon shipCannon = new ShipCannon();
                                (List<List<List<int>>>, List<List<List<string>>>, string[,,], List<List<int>>, bool, bool, string) tuples_2 = shipCannon.fire(playersShips_int_AR, playersShips_string_AR, playersShips_unknown_AR, playersBoardFight_AR, playersBoardFight_intToSplice_AR, fireCoorConv, attackPlayer);
                                playersShips_int_AR = tuples_2.Item1;
                                playersShips_unknown_AR = tuples_2.Item2;
                                playersBoardFight_AR = tuples_2.Item3;
                                playersBoardFight_intToSplice_AR = tuples_2.Item4;
                                isMiss = tuples_2.Item5;
                                isWinner = tuples_2.Item6;
                                winner = tuples_2.Item7;
                            }
                            else if (isIn_avalLet_AR == false || isIn_avalNum_AR == false)
                            {
                                isReturn = false;
                                Console.WriteLine("");
                                Console.WriteLine("This area NOT exists in enemy board!");
                                Console.WriteLine("");
                                Console.WriteLine("Click ENTER key to continue:");
                                Console.WriteLine("");
                                Console.ReadLine();
                            }
                        }
                    }
                }
                if (isFight == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Game is finish. The winner is: PLAYER " + (gamePlayer + 1).ToString());
                    Console.WriteLine("");
                    Console.WriteLine("Click ENTER key to continue:");
                    Console.WriteLine("");
                    Console.ReadLine(); 
                }
            }
            return winner;
        }
    }
    public class Prize : GameLoop
    {
        public string winnerInfo(string winner)
        {
            string winPlayer = winner;
            string wantGameAgain = "";
            bool isChoose = true;
            while (isChoose == true)
            {
                Console.Clear();
                if (winPlayer == "P1")
                {
                    Console.WriteLine("BB BB BB  BB  BBBB  BB  BBBB  BB  BBBBBBBB  BBBBBBB         BBBBBBB   BB          BBBB    BB    BB  BBBBBBBB  BBBBBBB       BBB     ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BB        BB    BB  BB    BB    BB  BB         BB  BB    BB  BB   BB        BB    BB     BB BB    ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BB        BB    BB        BB    BB  BB        BB    BB    BBBB    BB        BB    BB    BB  BB    ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BBBBBBBB  BBBBBBB         BBBBBBB   BB        BBBBBBBB     BB     BBBBBBBB  BBBBBBB         BB    ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BB        BB    BB        BB        BB        BB    BB     BB     BB        BB    BB        BB    ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BB        BB    BB  BB    BB        BB        BB    BB     BB     BB        BB    BB        BB    ");
                    Console.WriteLine("BBBBBBBB  BB  BB  BBBB  BB  BBBB  BBBBBBBB  BB    BB        BB        BBBBBBBB  BB    BB     BB     BBBBBBBB  BB    BB       BBBB   ");
                    Console.WriteLine("");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("");
                    Console.WriteLine("The battle wins PLAYER 1. This player get prize in the image of 10 000 $");
                }
                else if (winPlayer == "P2")
                {
                    Console.WriteLine("BB BB BB  BB  BBBB  BB  BBBB  BB  BBBBBBBB  BBBBBBB         BBBBBBB   BB          BBBB    BB    BB  BBBBBBBB  BBBBBBB      BBBBBB   ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BB        BB    BB  BB    BB    BB  BB         BB  BB    BB  BB   BB        BB    BB    BB    BB  ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BB        BB    BB        BB    BB  BB        BB    BB    BBBB    BB        BB    BB         BB   ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BBBBBBBB  BBBBBBB         BBBBBBB   BB        BBBBBBBB     BB     BBBBBBBB  BBBBBBB        BBB    ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BB        BB    BB        BB        BB        BB    BB     BB     BB        BB    BB      BB      ");
                    Console.WriteLine("BB BB BB  BB  BB BB BB  BB BB BB  BB        BB    BB  BB    BB        BB        BB    BB     BB     BB        BB    BB     BB       ");
                    Console.WriteLine("BBBBBBBB  BB  BB  BBBB  BB  BBBB  BBBBBBBB  BB    BB        BB        BBBBBBBB  BB    BB     BB     BBBBBBBB  BB    BB     BBBBBBB  ");
                    Console.WriteLine("");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("");
                    Console.WriteLine("The battle wins PLAYER 2. This player get prize in the image of 10 000 $");
                }
                Console.WriteLine("");
                Console.WriteLine("Do you want game again? If no, you will pass to game credits. Write \"yes\" or \"no\":");
                Console.WriteLine("");
                wantGameAgain = Console.ReadLine();
                if (wantGameAgain == "yes")
                {
                    isChoose = false;
                    // Nic, bo returnowana wartość jest wartością, któa znajduje się w zmiennej "wantGameAgain".
                }
                else if (wantGameAgain == "no")
                {
                    isChoose = false;
                    // Nic, bo returnowana wartość jest wartością, któa znajduje się w zmiennej "wantGameAgain".
                }
                else if (wantGameAgain != "yes" || wantGameAgain != "no")
                {
                    Console.WriteLine("");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("");
                    Console.WriteLine("You write uncorrect value.");
                    Console.WriteLine("");
                    Console.WriteLine("Click ENTER key to continue:");
                    Console.WriteLine("");
                    Console.ReadLine();
                }
            }
            // Nie zrobiłem tu resetu zmienny, bo nie było to potrzebne. Zmienne nadpiszą się przy ponownym wywołaniu funkcji.
            // W przypadku ustawiania statków musiałem zrobić reset zmiennych, ALE w celu zresetowania zmiennych dla ustawienia
            // kolejnego statku, nie w celu ponownej gry. W metodzie fire() jest podobnie jak w tej. Nie ma resetu zmiennych.

            return wantGameAgain;
        }
    }
    public class BoardContentMaker : GameProper
    {
        public string[,,] set_fieldAreaContent_AR()   /// TWORZY: Tablica graficzna planszy:
        {
            // Tworzenie tablic z graficzną zawartością stanu gry dla wszystkich graczy:
            // Użyłem tu typu zagnieżdżonej tablicy array[,,], a nie List<List<List<string>>>
            // z tego powodu, iż łatwiej jest mi modyfikować tablicę i wyświetlać ją w konsoli
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
        public List<List<int>> set_fullIndex_AR()   // TWORZY: Dynamiczna lista elementów odpowiedzialnych za prawidłową walidację określonych danych
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
        public List<List<List<int>>> set_dangerFields_AR()   // TWORZY: Lista dostępnych pól dla statków o określonym kierunku położenie i długości:
        {
            // Deklaracja tablicy trójwymiarowej o nieznanej liczbie wszystkich indeksów mieszczącej
            // wszstkie zestawy dostępnych pól na daną długość w zależności od kierunku statku:
            List<List<List<int>>> mainArray = new List<List<List<int>>>();   // kierunek -> długość -> zestaw niedostępnych pól -> niedstępne pole
            // Poszczególne zestawy dostępnych pól w danym kierunku statku w zależności od jego długości
            List<List<int>> length_B = new List<List<int>>();
            List<List<int>> length_R = new List<List<int>>();
            // Operacje na tablicach:
            // Kierunek: w dół:
            int startToIncValue = 89;
            for (int i = 0; i < 4; i++)
            {
                List<int> lengthType = new List<int>();
                // Z miejscami na kolejne ineksy obchodzimy się tak samo jak w JavaScript z tworzeniem elementów-tagów i wrzucaniem ich do elementów-rodziców. 
                // W JavaScript deklarujemy zmienną o wartości documnet.createElement('div'), który później Appendujemy do określonego kontenera-rodzica, 
                // który ma być kontenerem na ten właśnie element i możliwie inne potomne. Dokładnie tak samo postępujemy w C# z tablicami zagnieżdżonymi 
                // zadeklarowanymi za pomocą generyka List<typ>. Najpierw deklarujemy tablicę, później dodajemy do niej wartość, tak jak byśmy używali metody 
                // .createTextNode() obiektu document (i wkładali tam stringa), a następnie wkładamy ów tablicę do tablicy nadrzędnej i w JS jest to .appendChild()
                int shipValue = 0;
                shipValue = startToIncValue;
                for (int j = 0; j < 10; j++)
                {
                    lengthType.Add(shipValue += 1);
                }
                length_B.Add(lengthType);
                startToIncValue -= 10;
            }

            // Kierunek w prawo:
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

            // Tworzenie tablic tymczasowych na pola zakazane:
            List<List<int>> new_B_FusionVal_AR = new List<List<int>>();
            List<List<int>> new_R_FusionVal_AR = new List<List<int>>();
            // Łączenie poszczególnych tablic w celu uzyskania poprawnych zestawów dostępnych pól względem długości i statku:
            // WYJAŚNIENIE: Jeżeli mam statek o długości 3 i pionowej pozycji położenia, to kiedy kładę go na np. I7 i mam jako
            // ogranicznik TYLKO tablicę odpowiadającej początkowi współrzędnej początkowej tego statku (przy długości 3 - linia pól H), 
            // która leżąc od dolnej krawędzi planszy znajdowałaby się na pozycji H7, to ogranicznik dotyczyłby tylko wyspółrzędnych z 
            // cyframi należącymi do H, a nie wszystkich pól w dół poczynając od H (H0 -> J9). Użytkownik kładąc więc statek na pozycji
            // I7, gdzie jest ZAKAZ ustawiania statków tej długości położyłby statek, który teoretycznie wychodziłby z planszy, a w 
            // praktyce dawałby błąd w konsoli... W celu ominięca tego problemu trzeba połączyć poszczególne tablice w taki sposób aby
            // pasowały do danego typu statku - jego długości.
            List<int> L3_DB = length_B[1].Concat(length_B[0]).ToList();   // Ograniczenie dla statków o długości 3 i pozycji pionowej
            List<int> L4_DB = length_B[2].Concat(length_B[1]).Concat(length_B[0]).ToList();   // Ograniczenie dla statków o długości 4 i pozycji pionowej
            List<int> L5_DB = length_B[3].Concat(length_B[2]).Concat(length_B[1]).Concat(length_B[0]).ToList();   // Ograniczenie dla statków o długości 5 i pozycji pionowej
            List<int> L3_DR = length_R[1].Concat(length_R[0]).ToList();   // Ograniczenie dla statków o długości 3 i pozycji poziomej
            List<int> L4_DR = length_R[2].Concat(length_R[1]).Concat(length_R[0]).ToList();   // Ograniczenie dla statków o długości 4 i pozycji poziomej
            List<int> L5_DR = length_R[3].Concat(length_R[2]).Concat(length_R[1]).Concat(length_R[0]).ToList();   // Ograniczenie dla statków o długości 5 i pozycji poziomej                                                                                                     /// Sortowanie tablicy length_R, w celu zwiększenia estetyki:
            L3_DR.Sort();
            L4_DR.Sort();
            L5_DR.Sort();

            // Wkładanie poszczególnych zestawów pól zakazanych kolejno do indeksów poszczególnych tablic tymczasowych:
            new_B_FusionVal_AR.Add(L3_DB);
            new_B_FusionVal_AR.Add(L4_DB);
            new_B_FusionVal_AR.Add(L5_DB);
            new_R_FusionVal_AR.Add(L3_DR);
            new_R_FusionVal_AR.Add(L4_DR);
            new_R_FusionVal_AR.Add(L5_DR);

            // Aktualizowanie tablic dwuwymiarowych, wkładają do nich poszczególne tablice tymczasowe, względem danego kierunku położenia statku:
            // Aktualizowanie nastepuje od 1 indeksu obu tabel "length", gdyż dane w ich pierwszym indeksie (tablicy zagnieżdżonej) są poprawne (względwm długości statku).
            for (int i = 0; i < new_B_FusionVal_AR.Count; i++)
            {
                length_B[i + 1] = new_B_FusionVal_AR[i];
                length_R[i + 1] = new_R_FusionVal_AR[i];
            }
            
            // Wkładanie gotowych grup zestawów pól zakazanych do głównej tablicy
            mainArray.Add(length_B);
            mainArray.Add(length_R);

            return mainArray;
        }
        public (string[,,], List<List<int>>) updateBoardContent(List<List<int>> fullIndex_AR, string[] shipFullCoor, string[,,] playersBoardContent_AR, int players, int shipPage)
        {
            // Deklaracja gółwnych zmiennych:
            List<List<int>> splicedBoard_AR = new List<List<int>>();   // RUCHOMA fizyczna lista dostępnych pól na statki
            splicedBoard_AR = fullIndex_AR;
            string[,,] outputBoardData = playersBoardContent_AR;   // STAŁA graficzna tablica na statki (zmiany w wartościach STAŁEJ tablicy)
            int player = players - 1;   // players będzie zawyżone o 1, bo od razu w pętli nastepuje inkrementacja, a indeksy zaczynają się od 0
            string currentShip = (shipPage + 1).ToString() + " ";   // aktualna strona, dlatego + 1

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
                // Aktualizowanie tablicy:   /// UWAGA: "outputBoardData" to tablica string[,,] o strukturze [2, 10, 10]
                outputBoardData[player, int.Parse(fullCoor_string_1_num[i]), int.Parse(fullCoor_string_2_num[i])] = currentShip;   // np.: "6 "
            }

            // Usuwanie indeksów statków:
            for (int i = 0; i < result_int.Count; i++)
            {
                int startIndex = splicedBoard_AR[player].IndexOf(result_int[i]);
                splicedBoard_AR[player].RemoveRange(startIndex, 1);
            }

            return (outputBoardData, splicedBoard_AR);
        }
    }
    public class ShipBuildChecker : GameProper
    {
        public (string[], List<List<int>>, bool) shipCoorBuildChecker(string firstCor, string direction, string length, List<List<List<int>>> dangerFields, List<List<int>> fullIndexArray, int players, bool isDone)
        {
            // Konwersja stringowej formy współrzędnej początkowej na formę intową: (B2 -> A = 0, B = 10, C = 20, ... więc B2 = 10 + 2 = 12)
            string[] brdLetCor_AR = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            string[] brdNumCor_AR = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string fstCoor_string = firstCor;
            string fstCoor_1_let = fstCoor_string.Substring(0, 1);
            string fstCoor_2_num = fstCoor_string.Substring(1, 1);
            string fstCoor_1_num = "";
            int player = players - 1;
            bool isResult = isDone;
            for (int i = 0; i < brdLetCor_AR.Length; i++)
            {
                if (fstCoor_1_let == brdLetCor_AR[i])
                // Jeżeli np.: B == arr[i], to "wynik" = [i] | B jest wartością drugiego indeksu tablicy arr, więc instrukcja spełnia się
                // na indeksie 2, tej tabeli, a więc [i] wynosi 1 (bo [i] inkrementuje się o jeden po zakończeniu wykonywania jedenj iteracji tej pętli) - wartość B to 1.
                {
                    fstCoor_1_num = i.ToString();
                }
                else { }
            }
            fstCoor_string = fstCoor_1_num + fstCoor_2_num;
            int fstCoor = int.Parse(fstCoor_string);
            // W sytuacji konwersji stringa "04" na int, C# zignoruje 0 i da samą 4, więc nie trzeba tworzyć nowej zmiennej z 
            // substringowaną wartością jeżeli pierwszym indeksem (wartości tego typu) "09" będzie "0". Kiedy mamy A0 nie będzie na szczęście błędu, a 0.

            // Deklarowanie zmiennych na podstawie otrzymanych parametrów:
            string dir = direction;
            string lgt = length;
            List<List<int>> fullIndex_AR = fullIndexArray;
            string[] result = { firstCor };   // Inicjowanie wyniku z tymczasową wartością, byle tylko spełaniała wymóg returnowania przed ogarnięciem wartości wynikowej
            List<List<List<int>>> dangerFieldsGroup_ARS = dangerFields;

            // Wyznaczanie odpowiedniej tabeli zakazanych pól w zależności od długości i kierunku położenia statku:
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
            List<int> shipCoordinates = new List<int>();
            // Jeżeli licznik dobije do 10 niespełnionych warunków - istnienia współrzędnej początkowej w  tablicy pól zakazanych, 
            // można przekazać ów współrzędną dalej, jeżeli nie, współrzędna zostaje zastąpiona zmienną RESETOWĄ "?".
            int notIsIn_availableFields = 0;
            // Sprawdzanie czy statek nie wyjdzie poza planszę na podstawie lokalizacji współrzędnej początkowej, względem jego długości i kierunku położenia
            // (jedyne co mi jest tu potrzebne, to "STAŁA" tablica dostępnych pól, którą zreturnowałem wcześniej, żeby nie robić tu bałaganu)
            for (int i = 0; i < dangerFields_AR.Count; i++)
            {
                if (fstCoor != dangerFields_AR[i])
                {
                    notIsIn_availableFields += 1;
                }
                else if (fstCoor == dangerFields_AR[i])
                {
                    // Sytuacja: Statek znajduje się poza planszą
                }
            }
            // Sytuacja: Statek znajduje się na planszy
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
                        // Sytuacja: Statek nakłada się na inny statek lub statki
                        notIsIn_fullAreasBoardAR += 1;
                    }
                }
                if (notIsIn_fullAreasBoardAR < fullIndex_AR[player].Count)   // Dostępne pole do rozpoczęcie tworzenia statku
                {
                    // Włożenie pierwszej współrzędnej
                    shipCoordinates.Add(fstCoor);

                    // Tworzenie dalszych współrzędnych statku w zależnośći od jego długości i kierunku:
                    // Ustawianie wartości zmiennnej inkrementującej współrzędne statku, w zależności od kireunku jego położenia:
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
                    // Sprawdzenie czy aktualnie utworzone współrzędne istnieją już w RUCHOMEJ tablicy dostęppnych pół "fullIndex_AR"
                    // Jeżei istnieją, nie twórz statku i poinformuj gracza o nakładaniu się statków.
                    // Jeżeli nie istnieją, twórz statki i poinformuj gracza o udanej operacji.
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
                                        // Usuwanie indeksów z RUCHOMEJ tablicy dostępnych pól, aby dzięki temu móc określić czy statki nie nakładają się na siebie, robiąc odpowiedniego IFa z FORem.
                                        // Zrobiłem to w metodzie update, GDYŻ kiedy zrobiłbym to tutaj, to tablica została by zmodyfikowana przed decyzją gracza, czy chce ustawić
                                        // statek z jego współrzędnymi na planszy. Jeżeli napisałby, że nie, to dane zresetowałyby się, ALE tablica pozostałaby zmodyfikowana.
                                        // Wowczas kiedy gracz chciałby ustawić statek o jedną współrzędną początkową przed usuniętymi indeksami, to kiedy współrzędne dalsze 
                                        // statku wskazywałyby indeksy usunięte przez położenie pprzedniego statku - mięlibyćmy komunikat o nakładaniu się statkuw, co byłoby 
                                        // oczywiści błędem.
                                        // Jako że w instrukcji warunkwej poprzedzającej zapyatnie czy gracz chce zapisać dane mamy specjalną zmienną {?}, którą opisałem wcześniej,
                                        // nie musimy się martwić o to, że tablica zostanie zmodyfikowana przed sprawdzeniem bezkolizyjności, wychodzenia statku z planszy oraz
                                        // przedewszsytkim przed naszą niekontrolowaną decyzją w sprawie ustawienia statku, czyli inaczej zmodyfokowania tabeli.
                                    }
                                }
                            }
                        }
                    }
                    if (IS_In_fullIndex_AR_nextCoor < int.Parse(lgt))   // Jeżeli współrzędne statku NIE są dostępne w tablicy RUCHOMEJ - statek nakłada się na inny statek
                    {
                        Console.WriteLine("");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine("");
                        Console.WriteLine("Ship canNOT overlap other ship or ships!");
                        Console.WriteLine("You must give new coordinates.");
                        Console.WriteLine("");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();
                        string[] result_STOP = { "?" };   // {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                        result = result_STOP;
                        // Musiałem użyć tu retunr, gdyż inaczej 
                        //return;
                    }
                    else if (IS_In_fullIndex_AR_nextCoor == int.Parse(lgt))   // Jeżeli współrzędne statku SĄ dostępne w tablicy RUCHOMEJ - na planszy jest wolne miejsce
                    {
                        isResult = true;
                        Console.WriteLine("");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
                        Console.WriteLine("");
                        Console.WriteLine("Ship coordinates are saved!");
                        Console.WriteLine("");
                        Console.WriteLine("Click ENTER key to continue:");
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                }
                else if (notIsIn_fullAreasBoardAR == fullIndex_AR[player].Count)
                {
                    Console.WriteLine("");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
                    Console.WriteLine("");
                    Console.WriteLine("Ship canNOT overlap other ship or ships!");
                    Console.WriteLine("You must give new coordinates.");
                    Console.WriteLine("");
                    Console.WriteLine("Click ENTER key to continue:");
                    Console.WriteLine("");
                    Console.ReadLine();
                    string[] result_STOP = { "?" };   // {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                    result = result_STOP;
                }
            }
            else if (notIsIn_availableFields < dangerFields_AR.Count)   // Sytuacja: Statek znajduje się poza planszą
            {
                Console.WriteLine("");
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
                Console.WriteLine("");
                Console.WriteLine("Ship canNOT located over board!");
                Console.WriteLine("You must give new coordinates.");
                Console.WriteLine("");
                Console.WriteLine("Click ENTER key to continue:");
                Console.WriteLine("");
                Console.ReadLine();
                string[] result_STOP = { "?" };   // {"?"} Specjalna wartość informująca o wykryciu umieszczenia statku w niedozowlonym miejscu. Jest to wartość RESETOWA ponownego wyznaczenia współrzędnej początkowej
                result = result_STOP;
            }

            // Konwersja intowej formy współrzędnej początkowej na formę stringową: (24 -> 20 = C, 4 = 4, ... więc 24 = C + "4" = C4)
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
            }
            else { }
            return (result, fullIndex_AR, isResult);
        }
    }
    public class ShipCannon : GameProper
    {
        public (List<List<List<int>>>, List<List<List<string>>>, string[,,], List<List<int>>, bool, bool, string) fire(List<List<List<int>>> playersShips_int_AR, List<List<List<string>>> playersShips_string_AR, List<List<List<string>>> playersShips_unknown_AR, string[,,] playersBoardFight_AR, List<List<int>> playersBoardFight_intToSplice_AR, int fireCoorConv, int player)
        {
            // Deklaracja głównych zmiennych:
            List<List<List<int>>> playerShips_Coor_AR = new List<List<List<int>>>();
            playerShips_Coor_AR = playersShips_int_AR;
            List<List<List<string>>> playerShip_Stat_AR = new List<List<List<string>>>();
            playerShip_Stat_AR = playersShips_string_AR;
            List<List<List<string>>> unknownSign_AR = new List<List<List<string>>>();
            unknownSign_AR = playersShips_unknown_AR;
            string[,,] playersBoard_Fight_AR = new string[2, 10, 10];
            List<List<int>> playerBoardFight_toSplice_AR = new List<List<int>>();
            playerBoardFight_toSplice_AR = playersBoardFight_intToSplice_AR;
            playersBoard_Fight_AR = playersBoardFight_AR;
            bool isWinner = false;
            string winner = "?";

            // Logika strzelania:
            bool isHit = false;
            bool isMiss = false;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < playerShips_Coor_AR[player][i].Count; j++)
                {
                    if (fireCoorConv == playerShips_Coor_AR[player][i][j])   // Czy wybran współrzędna jest w RUCHOMEJ tablicy współrzędnych przeciwnika?
                    {
                        // TRAFIENIE
                        isHit = true;
                    }
                    else if (fireCoorConv != playerShips_Coor_AR[player][i][j])
                    {
                        // PUDŁO
                    }
                }
            }
            if (isHit == true)   // Jednorazowe wyznaczanie wartości "isMiss":
            {
                isMiss = false;
            }
            else {
                isMiss = true;
            }

            // Usuwanie indeksów listy w celu uniknięcia nakładania się oznaczeń odnośnie statków:
            for (int i = 0; i < playerBoardFight_toSplice_AR[player].Count; i++)   // Czy wybrana współrzęnda jest w RUCHOMEJ tablicy dostępnych pól graficznego stanu biewy?
            {
                if (fireCoorConv == playerBoardFight_toSplice_AR[player][i])
                {
                    // Pole to istnieje - czyli strzał był dostępny:
                    
                    // Usuwanie indeksów:
                    int startIndex_1 = playerBoardFight_toSplice_AR[player].IndexOf(fireCoorConv);
                    playerBoardFight_toSplice_AR[player].RemoveRange(startIndex_1, 1);
                    
                    // Logika strzału: (dalsza część)
                    if (isHit == false)
                    {
                        // Pudło - aktualizacja tablicy zawartości stanu bitwy:
                        string fireCoorToSlice = fireCoorConv.ToString();
                        if (fireCoorToSlice.Length == 1)
                        {
                            int fireCoorConv_s1 = 0;
                            int fireCoorConv_s2 = int.Parse(fireCoorToSlice.Substring(0, 1));
                            playersBoard_Fight_AR[player, fireCoorConv_s1, fireCoorConv_s2] = "O ";
                        }
                        else if (fireCoorToSlice.Length == 2)
                        {
                            int fireCoorConv_s1 = int.Parse(fireCoorToSlice.Substring(0, 1));
                            int fireCoorConv_s2 = int.Parse(fireCoorToSlice.Substring(1, 1));
                            playersBoard_Fight_AR[player, fireCoorConv_s1, fireCoorConv_s2] = "O ";
                        }
                    }
                    else if (isHit == true)
                    {
                        isHit = false;
                        // Trafienie - aktualizacja tablicy zawartości stanu bitwy:
                        string fireCoorToSlice = fireCoorConv.ToString();
                        if (fireCoorToSlice.Length == 1)
                        {
                            int fireCoorConv_s1 = 0;
                            int fireCoorConv_s2 = int.Parse(fireCoorToSlice.Substring(0, 1));
                            playersBoard_Fight_AR[player, fireCoorConv_s1, fireCoorConv_s2] = "X ";
                        }
                        else if (fireCoorToSlice.Length == 2)
                        {
                            int fireCoorConv_s1 = int.Parse(fireCoorToSlice.Substring(0, 1));
                            int fireCoorConv_s2 = int.Parse(fireCoorToSlice.Substring(1, 1));
                            playersBoard_Fight_AR[player, fireCoorConv_s1, fireCoorConv_s2] = "X ";
                        }

                        // Usuwanie indeksu RUCHOMEJ tablicy intowej:
                        int[,] allShipsLength_AR = new int[2, 7];
                        // Tablica na długości ainekdów statków w tablicy splicowanej - w celu ustalenia czy 
                        // dany statek jest zatopiony (jeśli jego długość w tablicy wynosi 0 [usuwanie indeksu])
                        for (int x = 0; x < 7; x++)
                        {
                            for (int y = 0; y < playerShips_Coor_AR[player][x].Count; y++)
                            {
                                if (playerShips_Coor_AR[player][x][y] == fireCoorConv)
                                {
                                    int startIndex_2 = playerShips_Coor_AR[player][x].IndexOf(fireCoorConv);
                                    playerShips_Coor_AR[player][x].RemoveRange(startIndex_2, 1);
                                }
                                else { }
                            }
                            // Pobranie zaktualizowanej długości tablicy danego statku
                            int curShipLength = playerShips_Coor_AR[player][x].Count;
                            allShipsLength_AR[player, x] = curShipLength;
                        }

                        // Sprawdzenie w której planszy jakiego gracza są zatopione wszystkie statki
                        int isSunken = 0;
                        // Wziąłem 7, bo nie wiem czy w ogóle da się przeitrować względem długości string[,], a dokładniej względem pierwszego wymiar, tzn. według "player".
                        for (int x = 0; x < 7; x++)   // Jeżeli któryś ze statków jest pusty (chodzi o tablicę) - inaczej zatopiony, to wartość nieznana statku "??" jest usupełniana o współrzędne:
                        {
                            if (allShipsLength_AR[player, x] == 0)
                            {
                                isSunken += 1;
                                int shipIndex = x;   // Statek, którego długość wynosi 0 (pusta tablica współrzędnych statku [trafienie = usunięcie danej współrzędnej]), czyli który jest zatopony
                                for (int y = 0; y < unknownSign_AR[player][shipIndex].Count; y++)   // Dla statkó którego długość wynosi 0 wpisz w "??" jest współrzędne.
                                {
                                    unknownSign_AR[player][shipIndex][y] = playerShip_Stat_AR[player][shipIndex][y];
                                }
                            }
                            else { }
                        }
                        if (isSunken == 7)   // Jeżeli zatopiono 7 statków, dany gracz wygrywa":
                        {
                            if (player == 0)
                            {
                                player = 1;
                            }
                            else if (player == 1)
                            {
                                player = 0;
                            }
                            winner = "P" + (player + 1).ToString();
                            isWinner = true;
                        }
                        else { }
                    }
                }
                else if (fireCoorConv != playerBoardFight_toSplice_AR[player][i])
                {
                    // Pole to nie istnieje czyli strzał był niedostępny:
                }
            }
            return (playerShips_Coor_AR, unknownSign_AR, playersBoard_Fight_AR, playerBoardFight_toSplice_AR, isMiss, isWinner, winner);
        }
    }
}
