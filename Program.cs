// ELSO FELADAT 

Console.Write("Add meg a csoki sorszamat: ");
int sorszam =  int.Parse(Console.ReadLine());

int oszt = 1;

if (sorszam <= 1)
{
    Console.WriteLine("Sajnos nem nyert");
}


for (int i = 1; i < sorszam; i++) 
    {
        if (sorszam % i == 0)
        {
            oszt+= 1;
        }

    }
if (oszt == 2)
    {
        Console.WriteLine("Nyert!");

    }
else
    {
        Console.WriteLine("Sajnos nem nyert");
    Console.WriteLine(oszt);
    }




// MASODIK FELADAT 


Console.Write("Az intervallum also vegpontja: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Az intervallum felso vegpontja: ");
int b = int.Parse( Console.ReadLine());


int szum = 0;

for (int i = a; i <= b; i++)
{
    if (i % 2 == 0)
    {
        szum += i;
    }
    
}


Console.WriteLine($"A {a} tol {b} intervallum osszege: {szum} ");




