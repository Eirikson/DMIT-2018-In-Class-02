<Query Kind="Program">
  <Connection>
    <ID>935ea04f-82e3-48d5-bcc7-822530af3a7d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

// C# Primer on nullable-types and extension methods
void Main()
{
	int? totalCount = null;
	totalCount.Dump();
	
	if(totalCount.HasValue)
	{
		"It has a value".Dump();
	}
	else
	{
		"It does not have a value - it is 'null'".Dump();
	}
	totalCount = 99;
	totalCount.Dump();
}

// Define other methods and classes here
