DateTime cas = DateTime.Now;
int cisloMesice = cas.Month;
string[] poleMesicu = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Září", "Říjen", "Listopad", "Prosinec" };
//Zjišťujeme co je to za měsíc dá se do proměnné a potom jsem si udělal string s měsící z kterého je pak budou vypisovat 

int cisloAktualniMesic = cisloMesice - 1;
int cisloDalsiMesic = cisloMesice;
int cisloPredeslyMesic = cisloMesice - 2;
//Toto dělá to aby to upravdu vypsalo správně daný měsíc takže třeba 2 Únor

if (cisloPredeslyMesic < 0)
    cisloPredeslyMesic = 11;
if (cisloDalsiMesic == 12) 
    cisloDalsiMesic = 0;
//Tohle hlídá aby když někdo napíše 12 aby to nehodilo error 

Console.WriteLine($"Nyní je {poleMesicu[cisloAktualniMesic]}, další měsíc bude {poleMesicu[cisloDalsiMesic]}, předchozí měsíc byl {poleMesicu[cisloPredeslyMesic]}");

Console.WriteLine($"Zadejte číslo měsíce od 1 do 12");
int zadanyMesic = Convert.ToInt32(Console.ReadLine());
int zadaneCisloAktualniMesic = zadanyMesic - 1;
int zadaneCisloDalsiMesic = zadanyMesic;
int zadaneCisloPredeslyMesic = zadanyMesic - 2;

if (zadaneCisloPredeslyMesic < 0)
    zadaneCisloPredeslyMesic = 11;
if (zadaneCisloDalsiMesic == 12)
    zadaneCisloDalsiMesic = 0;
Console.WriteLine($"Nyní je {poleMesicu[zadaneCisloAktualniMesic]}, další měsíc bude {poleMesicu[zadaneCisloDalsiMesic]}, předchozí měsíc byl {poleMesicu[zadaneCisloPredeslyMesic]}");

Console.WriteLine($"Chceš vypsat všechny měsíce? Y/N");
string YessOrNo = Console.ReadLine();
if (YessOrNo == "Y" | YessOrNo == "y") 
    //Tohle je aby fungovalo y a Y
{
    for (int forMesic = 0; forMesic < 12; forMesic++)
    {
        Console.WriteLine(poleMesicu[forMesic]);
    }
}