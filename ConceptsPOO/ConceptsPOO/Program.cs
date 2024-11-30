
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("------------");
// var date1 = new Date(2024, 11, 29);
// Date? date1 = new Date(2024, 13, 30);
// Console.WriteLine(date1);

try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1974, 9, 23));
	Console.WriteLine(new Date(1985, 11, 31));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}
