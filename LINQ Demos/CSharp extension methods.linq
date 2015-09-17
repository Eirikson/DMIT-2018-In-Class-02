<Query Kind="Program" />

void Main()
{
	string name = "Eirik";
	string message = name.Sleepy();
	message.Dump();
}

// Define other methods and classes here
public static class StringExtensions
{

	public static string Sleepy(this string text)
	{
		return text + " - Yawn! Yo dawg we gonna get dere soon?";
	}
}