// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

KlasseRum treB = new KlasseRum();
treB.SemesterStart = new DateTime(2022, 09, 01);
treB.Klasseliste.Add(new Studerende("Cem Turan", 02, 14));
treB.Klasseliste.Add(new Studerende("Sami Rherbi", 10, 10));

Console.WriteLine(treB);
foreach (Studerende s in treB.Klasseliste)
{
    Console.WriteLine(s);
}