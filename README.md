#  04-01-02-inheritence-books feladat
## BooksProjekt 
A Books egy abstract osztály! A kódja elkészíthető az UML diagram alapján!
Az EBooks a diagitális könyvtárak osztálya! A digitális könyveket a könyvesbolt weboldaláról le lehet tölrteni. Az osztály számontartja a letöltések számát!
A PaperBook a papír alapú könyveket jelenti. A könyvesbol beszerez és elad könyveket. Az osztály nyilvántartaja az aktuális könyvmennyiséget egy könyv esetén!
A PaperBook metóudsainak megvalósításakor kivételek keletkezhetnek! Ezek a kivételek láthatók az UML diagram alján!
A kód megírását tesztek segítik! Ha bizonytalan a megírandó kódba, nézze át a teszteket!
A Program.cs állományban teszt kód található!
A származtatott osztályok ToString metódusa végrehajtja az ős osztály ToString metódusát is!
A Book osztály ToString metóduának kimenete:
```
önyv szerzője: Andrew Troelsen
Könyv címe: Pro C# 7
Könyv oldalszáma: 155
```
Az EBook osztály ToString metódusának kiemente:
```
Könyv szerzője: Reiter István
Könyv címe: C# programozás lépésről lépésre
Könyv oldalszáma: 340
Könyv letöltésszáma: 3 db.
```
A PaperBook osztály ToString meótusának kiemenete:
```
Könyv szerzője: Andrew Troelsen
Könyv címe: Pro C# 7
Könyv oldalszáma: 155
Könyv készlet: 100 db
```
