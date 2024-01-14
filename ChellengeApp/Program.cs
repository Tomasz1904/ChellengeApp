bool isWoman = true;
var age = 18;
string name = "EWA";

if (isWoman == true && age < 30)
{
     Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "EWA" && age == 30)
{
     Console.WriteLine("Ewa lat 30");
}
else if (isWoman == false && age < 18)
{
     Console.WriteLine("Niepełnoletni meżczyzna");
}
else
{
     Console.WriteLine("Ktoś inny");
}
