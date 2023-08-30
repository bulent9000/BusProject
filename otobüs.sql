create database sehirler
go
use sehirler

select * from kalkisIller
create table kalkisIller
(
sehirIsmi nvarchar(40)

)
insert into kalkisIller(sehirIsmi) 
values('Ýstanbul')
insert into kalkisIller(sehirIsmi) 
values('Ankara')
insert into kalkisIller(sehirIsmi) 
values('Ýzmir')
insert into kalkisIller(sehirIsmi) 
values('Bursa')
select * from kalkisIller

create table varisIller
(
sehirIsmi nvarchar(40)

)
insert into varisIller(sehirIsmi) 
values('Ýstanbul')
insert into varisIller(sehirIsmi) 
values('Ankara')
insert into varisIller(sehirIsmi) 
values('Ýzmir')
insert into varisIller(sehirIsmi) 
values('Bursa')

