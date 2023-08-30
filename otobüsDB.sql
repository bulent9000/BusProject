create database omka
go
use omka

create table yetkiliGiris
(
id int identity(1,1) primary key,
kullaniciAdi nvarchar(30),
sifre nvarchar(30)
)

insert into yetkiliGiris values('müdür.giris','müdür')
insert into yetkiliGiris values('calisan.giris','calisan')

select * from yetkiliGiris


delete from müsteriKayit
drop table müsteriKayit


create table müsteriKayit
(
tcKimlikNo nvarchar(40) unique,
isim nvarchar(40) not null,
soyisim nvarchar(40) not null,
telefonNo nvarchar(40) not null,
odaNo nvarchar(40) not null,
kalinacakGün nvarchar(40) not null,
girisTarihi datetime,
cikisTarihi datetime,
kayitTipi nvarchar(40) not null
)

create proc müsteriKayit
(
@tcKimlikNo nvarchar(40),
@isim nvarchar(40),
@soyisim nvarchar(40),
@telefonNo nvarchar(40),
@odaNo nvarchar(40),
@kalinacakGün nvarchar(40),
@girisTarihi datetime
)
as begin
insert into müsteriKayit(tcKimlikNo,isim,soyisim,telefonNo,odaNo,kalinacakGün,getdate())
values()


end



drop table müsteriKayit



alter table müsteriKayit
ADD 
girisTarihi datetime



select * from müsteriKayit















create proc müsteriGüncel
(
@tcKimlikNo nvarchar(40),
@isim nvarchar(40),
@soyisim nvarchar(40),
@telefonNo nvarchar(40),
@odaNo nvarchar(40),
@kalinacakGün nvarchar(40)
)
as begin
update müsteriKayit
set 
tcKimlikNo=@tcKimlikNo,
isim=@isim,
soyisim=@soyisim,
telefonNo=@telefonNo,
odaNo=@odaNo,
kalinacakGün=@kalinacakGün
where 
odaNo=@odaNo
return
end









select * from müsteriKayit















