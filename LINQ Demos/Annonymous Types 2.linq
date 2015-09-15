<Query Kind="Expression">
  <Connection>
    <ID>7210f38d-d4ee-4e42-b42d-0fe20a1018fb</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from person in Waiters
where person.ReleaseDate == null
select new
{
	Name = person.FirstName + ' ' + person.LastName,
	Phone = person.Phone,
	DaysEmployed = (DateTime.Today - person.HireDate).Days
}