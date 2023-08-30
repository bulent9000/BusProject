create database omka
go
use omka

create table yetkiliGiris
(
id int identity(1,1) primary key,
kullaniciAdi nvarchar(30),
sifre nvarchar(30)
)

insert into yetkiliGiris values('m�d�r.giris','m�d�r')
insert into yetkiliGiris values('calisan.giris','calisan')

select * from yetkiliGiris


delete from m�steriKayit
drop table m�steriKayit


create table m�steriKayit
(
tcKimlikNo nvarchar(40) unique,
isim nvarchar(40) not null,
soyisim nvarchar(40) not null,
telefonNo nvarchar(40) not null,
odaNo nvarchar(40) not null,
kalinacakG�n nvarchar(40) not null,
girisTarihi datetime,
cikisTarihi datetime,
kayitTipi nvarchar(40) not null
)

create proc m�steriKayit
(
@tcKimlikNo nvarchar(40),
@isim nvarchar(40),
@soyisim nvarchar(40),
@telefonNo nvarchar(40),
@odaNo nvarchar(40),
@kalinacakG�n nvarchar(40),
@girisTarihi datetime
)
as begin
insert into m�steriKayit(tcKimlikNo,isim,soyisim,telefonNo,odaNo,kalinacakG�n,getdate())
values()


end



drop table m�steriKayit



alter table m�steriKayit
ADD 
girisTarihi datetime



select * from m�steriKayit















create proc m�steriG�ncel
(
@tcKimlikNo nvarchar(40),
@isim nvarchar(40),
@soyisim nvarchar(40),
@telefonNo nvarchar(40),
@odaNo nvarchar(40),
@kalinacakG�n nvarchar(40)
)
as begin
update m�steriKayit
set 
tcKimlikNo=@tcKimlikNo,
isim=@isim,
soyisim=@soyisim,
telefonNo=@telefonNo,
odaNo=@odaNo,
kalinacakG�n=@kalinacakG�n
where 
odaNo=@odaNo
return
end









select * from m�steriKayit















