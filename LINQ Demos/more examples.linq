<Query Kind="Expression">
  <Connection>
    <ID>935ea04f-82e3-48d5-bcc7-822530af3a7d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from category in MenuCategories
select new
{
	Category = category.Description,
	Items = category.Items.Count()
}