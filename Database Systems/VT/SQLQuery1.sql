USE[KitapciDB]
GO
drop table onlineMusteri;
drop table magazaMusteri;
drop table odemeler;
drop table fatura;
drop table siparisler;
drop table musteri;
drop table kitap;
drop table depo;

GO

create table musteri(
mid int primary key,
isim varchar(100) not null
);

create table onlineMusteri(
mid int primary key,
email nvarchar(100) null,
szt datetime,
foreign key(mid) references musteri);

create table magazaMusteri(
mid int not null,
telNo numeric(11) null,
foreign key(mid) references musteri);

create table siparisler(
siparisNo int not null primary key,
tarih datetime not null,
musteriNo int not null,
foreign key(musteriNo) references musteri);

create table depo(
did int not null primary key,
konum nvarchar(100) not null
);

create table kitap(
sipNo int not null,
parcaNo int not null,
miktar smallint not null,
birimFiyat money not null,
adi nvarchar(300) not null,
hangiDepo int not null,
primary key(sipNo,parcaNo),
foreign key(hangiDepo) references depo,
foreign key(sipNo) references siparisler);


create table fatura(
fatNo int primary key,
sipNo int not null,
tarih datetime not null,
indirim decimal null,
foreign key(sipNo) references siparisler);

create table odemeler(
fatNo int,
takNo int,
odemeMiktari money not null,
odemeTipi nvarchar(100) not null,
kartTipi nvarchar(100) null,
son_kul_tar datetime null,
kartNo int null,
bankaKodu nvarchar(30) null,
cekNo int null,
primary key(fatNo,takNo),
foreign key (fatNo) references fatura);


insert into depo values(0,'d1');
insert into depo values(1,'d2');
insert into depo values(2,'d3');