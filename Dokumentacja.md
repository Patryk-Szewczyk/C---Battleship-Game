## Dokumentacja

1. Opis ogólny projektu:
Battleship to strategiczno-planszowa gra komputerowa dla dwóch osób. Każdy z graczy posiada po dwie plansze o wielkości, 10x10 pól. Pola oznaczone są poprzez współrzędne literami od "A" do "J" i liczbami "0" do "9". Każdy gracz ustawia swoje statki na planszy. Po ustawieniu statków zaczyna się bitwa, którą wygrywa ten gracz, który zatopi wszystkie statki swojego przeciwnika. Na drugim zaznacza trafione statki przeciwnika i oddane przez siebie strzały. Statki ustawiane są w pionie lub poziomie, w taki sposób, aby nie wychodziły poza planszę oraz nie nakładały się na siebie. Łącznie jest 7 statków o różnej długości. Długość zaczyna się od 2 pól, a kończy na 5 polach. Trafienie okrętu przeciwnika polega na strzale, który jest odgadnięciem położenia jakiegoś statku. Strzały oddawane są naprzemiennie, poprzez podanie współrzędnych pola (np. "B5"). Zatopienie statku ma miejsce wówczas, gdy gracz odgadnie położenie całego statku. O chybieniu informuje gracza znak "O" pojawiający się na polu, które ostrzeliwał. Trafienie jest oznaczane znakiem "X". Wygrywa ten, kto pierwszy zatopi wszystkie statki przeciwnika. 
Gra nieco różni się od oryginału, czego przejawem jest regulacja niektórych zasad. Zabieg ten ma na celu zwiększenie elestyczności i efektywności rozgrywki oraz stanowi swego rodzaju oryginalny pomysł na rozgrywkę.

2. Cele projektu:
Głównym celem projektu jest przede wszystkim wzbudzenie ciekawości i zachwytu u osób rozpoczynających naukę programowania, bądź osób, które planują ów naukę oraz zaprezentowanie im możliwości języka C# wykorzystując do tego podstawową znajomość składni ów języka, w tym: właściwości, metod i klas. Bardzo często, jak nie zawsze programy konsolowe i ich tworzenie wprawia nowicjuszy programowania w osłupienie i agonię, związane z zetknięciem się z nigdy dotąd nieznanym środowiskiem programistycznym oraz językiem programowania, którego działania ci nowicjesze nie rozumią w znacznej części, bądź wcale. Sposób działania gry, jak również jej funkcje mają zachęcić tych ludzi do podjęcia pożądnej i wytęzonej nauki proramowania oraz wzmożyć w nich chęć trwania w tejże nauce. Pomijając główny cel, projekt ten stanowi także źródło rozrywki i relaksu przeznaczone dla dwójki osób.

3. Informacje o autorze:
Autorem programu jest: Patryk Szewczyk - uczeń Akademii Handlowej Nauk Stosowanych 1 semestru na kierunku: Informatyka. Autor zakazuje kopiowania i udostępniania gry, korzystania z niej w celach marketingowych i sprzedawania jej jako samodzielnego produktu.

4. Struktura programu:
Cały program jest napisany w oparciu o programowanie obiektowe. Program składa się z dwóch przestrzeni nazw odpowiedzialnych za dołączenie do programu odpowiednich bibliotek oraz dwóch przestrzeni nazw zawierających na kod programu: "OutputProgram" i "InputWorkProgram". W przestrzeni "OutputProgram" znajduje się główna klasa programu "Program" ze swoją główną metodą "Main(string[] arg)", która wywołuje proceduralnie kod, w którym znajdują się polecenia dotyczące tworzenia instancji klas z przestrzeni "InputWorkProgram", która pełni funkcję przestrzeni wykonawczej. Przestrzeń wykonawcza jest przestrzenią, w której wykonywane są wszystkie operacje odnośnie gry. W grze wielokrotnie jest użyta pętla while, która pełni funkcję ponownego wykonania danego bloku kodu, dzięki czemu możliwe jest wykonanie takich operacji jak ponowne ułożenie statku, jeżeli źle go ułożyliśmym, jak również umożliwia ponowną grę po zakończeniu bieżącej.

5. Działanie programu:
Działanie programu rozpoczyna się i kończy tylko i wyłącznie w metodzie "Main()" klasy "Program", wyjściowej przestrzeni nazw "OutputProgram". Lecąc od samej góry tworzymy instancje poszczególnych klas z wykonawczej przestrzni nazw "InputWorkProgram". Kiedy wywołamy metodę danej instancji, przechodzimy do danej metody danej klady wykonawczaj przestrzeni nazw. W wykonawczej przestrzeni nazw w celu uporządkowania kodu użyto dziedziczenia do wskazania które klasy są nadrzędna, a które potomne. Mapa dziedziczenia klas przedstawia się następująco:
`Program ---> Game Intro,                                          `
`             GameLoop, -----> GameProper, ---> BoardContentMaker, `
`             GameCredits      Prize            ShipBuildChecker,  `
`                                               ShipCannon         `
W praktyce dziedziczenie nie jest w ogóle potrzebne, ale tak jak napisano powyżej ma ono zasadnicze znaczenie w porządkowaniu klas. 
Kod programu jest kompilowany i wywoływany od góry do dołu tylko i wyłącznie w klasie Program, a jako że znajdują się w niej polecenia dotyczące utworzenia instancji trzech klas potomnych i wywołania ich metod, program zatrzyma się na instancji GameLoop, aby utworzyć wszystkie instancjie klas potomnych z klasy "GameLoop", wykona ich metody i dopiero ruszy dalej do utworzenia instancji klasy GameCredits. Reasumując, patrząc na mapę widać, że zanim program dotrze do utworzenia instancji klasy "GameCredits" i wywołania jej metody, utworzy wszystkie instancje klas podomnych klasy "GameLoop".
Szczególną uwagę trzeba zwrócić na klasę "GameLoop" która jest jedną wielką pętlą, umożliwiającą na ponowną grę, kiedy gracze zdecydują się ponownie zagrać, po uprzednio zakończonej sesji. W klasach potomnych tejże klasy ("GameProper", "Prize") mamy do czynienia z kolejnymi pętlami, a w "GameProper" aż z kilkoma zagnieżdżonymi, dzięki którym przy małym nakładzie kodu można wyznaczyć statki dla dwóch grach, zresetować współrzędne danego statku, jak również całą grę, w celu ponownego zagrania w nią.

6. Technologie i Biblioteki:
Program został napisany w całości w języku programowania C# bez użycia frameworków. W programie znajdują się dwie przestrzenie nazw odpowiedzialnych za dołączanie określonych bibliotek. Są to kolejno: System i System.Collections.Generic.
"System" - zawiera podstawowe typy i klasy, takie jak "Console", czy "String".
"System.Collections.Generic" - oferuje generyczne kolekcje, takie jak "List".

6. Szczegółowy opis zawartości przestrzeni nazw "OutputProgram":
Przestrzeń nazw "OutputProgram" jak to zostało wcześniej napisane posiada tylko jedną klasę i metodę, która wykonuje proceduralnie następjące linie kodu. W "OutputProgram" tworzy się instancje klas z przestrzeni nazw "InputWorkProgram", które pełnią swego rodzaju funkcję poszczególnych komponentów tego programu. Komponenty te można wywołać w dowolnej kolejności z tym samym efektem, co w ustalonej w programie kolejności. Dzieje się tak z tego względu, iż pomiędzy metodami instancji klas przestrzeni nazw "InputWorkProgram" nie ma żadnego przekazywania zwracanych wartości.
W metodzie "Main" klasy "Program" przestrzeni nazw "OutputProgram" są tworzone trzy instancje poszczególnych klas: "GameIntro", "GameLoop" i "GameCredits". Klasy te znajdują się w wykonawczej przestrzni nazw "InputWorkProgram".
Klasa "GameIntro" "intro()" odpowiada za wyświetlenie wprowadzenia do gry, w którym znajdują się kolejno: tytuł gry, licencja, informacja o grze, prośba o maksymalizację okna konsoli i komunikat o przejściu dalej. Komunikatów o przejściu dalej jest cała masa. Aby przejść dalej należy kliknąć przycisk "Enter". Metoda "insruction()", odpowiada za wyświetlenie instrukcji gry, wraz z komunikatem  o przejściu dalej.
Klasa "GameLoop" odpowiada za wywoływanie "właściwego" kodu gry w pętli, dopóki gracze po zakończonej rozgrywce zdecydują się zakończyć grę. Szczegóły odnośnie tej klasy i jej klas potomnych będą omówione dalej.
Klasa "Game Credits" wyświetla informacje o zakończeniu gry, w tym podziękowania, informacje o autorze i komunikat o zakończeniu programu po kliknięciu klawisza "Enter".

7. Klasy przestrzeni nazw "InputWorkProgram":
W "InputWorkProgram" realizowane są wszytskie operacje związane z grą. Działanie programu w tej przestrzeni opiera się na tworzeniu danych instancji klas i wywoływaniu ich metod. Tak przedstawia się plan klas i kierunek wywoływania kodu odnośnie klas:
`Game Intro,                                          `
`GameLoop, -----> GameProper, ---> BoardContentMaker, `
`GameCredits      Prize            ShipBuildChecker,  `
`                                  ShipCannon         `
Zaczynając od samej góry program tworzy instancję klasy "GameIntro" i wywołuje jej metody. Następnie idzie do klasy "GameLoop" i robi dokładnie to samo, z tą różnicą, iż tworzy w niej instancje klas "GameProper" i Prize, gdzie wywołuje także ich metody. Po wywołaniu ich metod program przechodzi do "GameCredits", gdzie kończy się gra. W "GameProper" dzieje się to samo co w "GameLoop" - program tworzy instancje klas podomnych "BoardContentMaker", "ShipBuildChecker" i "ShipCannon" klasy nadrzędnej "GameProper".
Poniżej znajduje się szczegółowy opis wszystkich klas i ich metod z przestrzeni nazw "InputWorkProgram".

8. "GameIntro":
"GameIntro" odpowiada za wyświetlenie wprowadzenie do gry oraz instrukcji obsługi gry. Klasa ta ma dwie metody, którymi są "intro()" i "instruction()".
Metoda "intro()" wyświetla na samej górze tytuł gry, który jest napiany w znakach "B". Dalej wyświetla tytuł gry pisany "normalnie" oraz informacje o prawach autorskich. Następnie ukazuje krótki opis gry, wyjaśniający na czy ona polega. Następnie ostrzega użytkownika o błędach, które pojawią się, gdy ten nie zmaksymalizuje swojego ekranu konsoli, w celu pełniego kasowania jej zawartości. Na końcu tej metody znajduje się komnikat, który informuje gracza, że aby przejść dalej trzeba nacisnąć klawisz "Enter". Takich komunikatów jest bardzo dużo w programie, gdyż odpowiadają one za uniemożliwienie niekontrolowanego przejścia dalej, aby np. gracz nie został przeniesiony automatycznie dalej, czego skutkiem byłoby nie dostrzeżenie przez niego przykładowo instrukcji obsługi gry, gdyż zmiana strony nastąpiłaby w zbyt którkim odstępie czasu, aby gracz mógł wychwycić stronę z instrukcją.
Metoda "instruction()" powoduje wyświetlenie się napisu "INSTRUCTION" składającego się ze znaków "B" i 17 punktów, które mówią o zasadach gry. Na końcu tak jak przy każdej stronie, bądź przy danym etapie pojawia się komunikat o przejściu dalej - tutaj o przejściu do pozycjonowania statków na planszach graczy.

9. "GameLoop":

10. "GameCredits":
Klasa"GameCredits" zawiera tylko jedną metodę - "showCredits()", która wyświetla napis "GAME CREDITS", składający się ze znaków "B", za pod nim podziękowanie za grę, wraz z informacją o autorze gry. Na dole znajduje się komunikat, informujący o końcu programu, który nastąpi, jeśli zostanie naciśnięty klawisz "Enter".

11. Testy:
Program ten był wielokrotnie testowany na różnych etapach produkcji. Celem testów było sprawdzenie poprawności działania programu i znalezienie wszystkich możliwych do wystąpienia błędów, z zamiarem likwidacji ich. W celu osiągnięcia jak największej wydajności pracy oraz związanego z tym zminimalizowania występowania błędów, program był często poddawany testom jednostkowym, poszczególnych części metod danych klas i finalnie przy testowaniu działania całych metod oraz zwracania z nich przetworzinych (w nich) zmiennych do innych metod tej samej klasy. Linie kodu odpowiedzialne za testy zostały usunięte, z powodu przejścia przez program wszystkich testów oraz w celu zwiększenia estetyki kodu.

12. Bibliografia:
Do utworzenia programu użyto wiedzy z następujących źródeł:
C# 9.0 Leksykon Kieszonkowy - Joseph Albahari, Ben Albahari
W3School




Klasa "GameLoop" posiada dwie klasy potomne "GameProper" i "Prize". "GameProper" jak wskazuje nazwa jest grą "właściwą", innymi słowy ta klasa odpowiada za wywoływanie wszystkich funkcji odnośnie gry z udziełem obu graczy: ustawianie statków na planszach przez graczy oraz bitwa pomiędzy nimi. Klasa "Prize" odpowiada za informowanie który gracz zwyciężył oraz za pytanie czy gracze chcą zagrać ponownie. Zapytanie o ponowną grę jest kluczowym momentem całej klasy "GameLoop", ponieważ podjęcie przez graczy decyzji w tej sprawie spowoduje, albo zakończenie działania pętli w głóenej i jedynej metodzie klasy "GameLoop" i tym samy program przejdzie do klasy "GameCredits", a dokłądniej utworzy jej instancję i wykona metodę odpowiedzialną za pokazanie "napisów końcowych", albo spowoduje ponowną grę, zaczynając od ustawiania przez graczy statków na planszy.


