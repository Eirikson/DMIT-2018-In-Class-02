<Query Kind="Expression">
  <Connection>
    <ID>27255e89-96c0-4659-8a70-c07e1a67433d</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

from info in Reservations
where info.ReservationDate.Year == 2014
  &&  info.ReservationDate.Month == 9
  &&  info.ReservationDate.Day == 20
  && info.ReservationStatus != 'C'
group info by info.ReservationDate into result
select result