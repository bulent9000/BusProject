create database sehirler
go
use sehirler

select * from kalkisIller
create table kalkisIller
(
sehirIsmi nvarchar(40)

)
insert into kalkisIller(sehirIsmi) 
values('�stanbul')
insert into kalkisIller(sehirIsmi) 
values('Ankara')
insert into kalkisIller(sehirIsmi) 
values('�zmir')
insert into kalkisIller(sehirIsmi) 
values('Bursa')
select * from kalkisIller

create table varisIller
(
sehirIsmi nvarchar(40)

)
insert into varisIller(sehirIsmi) 
values('�stanbul')
insert into varisIller(sehirIsmi) 
values('Ankara')
insert into varisIller(sehirIsmi) 
values('�zmir')
insert into varisIller(sehirIsmi) 
values('Bursa')

