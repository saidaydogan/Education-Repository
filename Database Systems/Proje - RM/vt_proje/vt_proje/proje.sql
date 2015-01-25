create table MUSTERI(mid numeric,isim varchar(15),adres varchar(30),musteriTipi char(1),primary key(mid));

create table ONLINEMUSTERI(mid numeric,email varchar(30),sonZiyaretTarihi date,primary key(mid));

create table MAGAZAMUSTERI(mid numeric,telNo char(11),primary key(mid));

create table SIPARIS(siparisNo char(3),tarih date,mid numeric,primary key(siparisNo));

create table KITAP(siparisNo char(3),parcaNo numeric,adi varchar(50), birimFiyat numeric, miktar numeric ,depoId char(2),primary key(siparisNo,parcaNo));

create table DEPO(depoId char(2),konum varchar(15),primary key(depoID));

create table FATURA(fatNo char(3),tarihi date ,indirimYuzdesi numeric, siparisNo char(3),primary key(fatNo));

create table ODEMELER(fatNo char(3),taksitNo numeric, odenenMiktar numeric, odemeTipi varchar(15),
krediKartiTipi varchar(6), sonGecerlilikTarihi date, kartNo numeric, cekBankaKodu numeric, cekNo numeric,primary key(fatNo,taksitNo));

insert into MUSTERI(mid,isim,adres,musteriTipi) values(1,'Ahmet','Sultanahmet','O');
insert into MUSTERI(mid,isim,adres,musteriTipi) values(2,'Ali','Fatih','M');
insert into MUSTERI(mid,isim,adres,musteriTipi) values(3,'Ayşe','Eminönü','O');
insert into MUSTERI(mid,isim,adres,musteriTipi) values(4,'Fatma','Beyoğlu','M');
insert into MUSTERI(mid,isim,adres,musteriTipi) values(5,'Hatice','Üsküdar','O');
insert into MUSTERI(mid,isim,adres,musteriTipi) values(6,'Yusuf','Kadıköy','M');
insert into MUSTERI(mid,isim,adres,musteriTipi) values(7,'Emre','Beyazıt','O');
insert into MUSTERI(mid,isim,adres,musteriTipi) values(8,'Sezgin','Esenler','M');
insert into MUSTERI(mid,isim,adres,musteriTipi) values(9,'Buğra','Altunizade','O');
insert into MUSTERI(mid,isim,adres,musteriTipi) values(10,'Muhammet','Altunizade','M');

insert into SIPARIS(siparisNo,tarih,mid) values('s1','01/12/2012',1);
insert into SIPARIS(siparisNo,tarih,mid) values('s2','02/11/2013',2);
insert into SIPARIS(siparisNo,tarih,mid) values('s3','13/12/2013',4);
insert into SIPARIS(siparisNo,tarih,mid) values('s4','08/12/2010',4);
insert into SIPARIS(siparisNo,tarih,mid) values('s5','05/12/2013',8);
insert into SIPARIS(siparisNo,tarih,mid) values('s6','01/12/2011',6);
insert into SIPARIS(siparisNo,tarih,mid) values('s7','16/12/2013',10);
insert into SIPARIS(siparisNo,tarih,mid) values('s8','20/12/2012',8);
insert into SIPARIS(siparisNo,tarih,mid) values('s9','01/12/2013',1);
insert into SIPARIS(siparisNo,tarih,mid) values('s10','21/03/2013',10);
insert into SIPARIS(siparisNo,tarih,mid) values('s11','01/09/2013',1);
insert into SIPARIS(siparisNo,tarih,mid) values('s12','11/10/2013',2);
insert into SIPARIS(siparisNo,tarih,mid) values('s13','18/01/2013',6);
insert into SIPARIS(siparisNo,tarih,mid) values('s14','15/02/2012',4);
insert into SIPARIS(siparisNo,tarih,mid) values('s15','01/03/2012',8);

insert into DEPO(depoId,konum) values('d1','Sultanahmet');
insert into DEPO(depoId,konum) values('d2','Üsküdar');
insert into DEPO(depoId,konum) values('d3','Beşiktaş');

insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s1',3,'Efsane',20,3,'d1');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s2',1,'Uçurtma Avcısı',20,1,'d1');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s11',2,'Çalıkuşu',10,2,'d1');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s4',1,'Tutunamayanlar',30,1,'d1');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s10',2,'Kayıp Gül',20,2,'d1');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s3',1,'Nar Ağacı',30,1,'d2');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s2',2,'Ve Dağlar Yankılandı',24,2,'d2');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s15',3,'Soğuk Kahve',20,3,'d2');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s7',2,'Bukre',20,2,'d2');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s8',2,'Böğürtlen Kışı',30,2,'d3');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s9',1,'Efsane',20,1,'d3');
insert into KITAP(siparisNo,parcaNo,adi,birimFiyat,miktar,depoId) values('s5',1,'Senden Önce Ben',20,1,'d3');

insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f1','01/12/2012',10,'s1');
insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f2','08/12/2010',10,'s4');
insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f3','05/12/2013',10,'s5');
insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f4','01/12/2011',10,'s7');
insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f5','02/11/2013',10,'s2');
insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f6','13/12/2013',10,'s3');
insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f7','21/03/2013',10,'s10');
insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f8','01/09/2013',10,'s11');
insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f9','01/09/2013',10,'s5');
insert into FATURA(fatNo,tarihi,indirimYuzdesi,siparisNo) values('f10','18/01/2013',10,'s15');

insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f1',1,54,'NAKİT',null,null,null,null,null);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f1',2,54,'KREDİKARTI','VISA','01/01/2017',123456789,null,null);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f2',1,27,'NAKİT',null,null,null,null,null);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f3',3,18,'CEK',null,null,null,10001,1001);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f5',1,62,'NAKİT',null,null,null,null,null);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f6',2,27,'KREDİKARTI','MASTER','01/01/2018',1234456780,null,null);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f7',1,36,'NAKİT',null,null,null,null,null);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f7',3,36,'CEK',null,null,null,10002,1002);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f8',1,18,'NAKİT',null,null,null,null,null);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f10',2,54,'KREDİKARTI','VISA','01/01/2016',123456781,null,null);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f9',1,null,null,null,null,null,null,null);
insert into ODEMELER(fatNo,taksitNo,odenenMiktar,odemeTipi,krediKartiTipi,sonGecerlilikTarihi,kartNo,cekBankaKodu,cekNo)
values('f4',3,null,null,null,null,null,null,null);

insert into ONLINEMUSTERI(mid,email,sonZiyaretTarihi)
values(1,'ahmet123@gmail.com','03/12/2012');
insert into ONLINEMUSTERI(mid,email,sonZiyaretTarihi)
values(3,'ayse123@gmail.com','12/10/2012');
insert into ONLINEMUSTERI(mid,email,sonZiyaretTarihi)
values(5,'hatice123@gmail.com','09/01/2013');
insert into ONLINEMUSTERI(mid,email,sonZiyaretTarihi)
values(7,'emre123@gmail.com','01/05/2012');
insert into ONLINEMUSTERI(mid,email,sonZiyaretTarihi)
values(9,'bugra123@gmail.com','13/11/2012');

insert into MAGAZAMUSTERI(mid,telNo)
values(2,'05334657880');
insert into MAGAZAMUSTERI(mid,telNo)
values(4,'05334657881');
insert into MAGAZAMUSTERI(mid,telNo)
values(6,'05334657882');
insert into MAGAZAMUSTERI(mid,telNo)
values(8,'05334657883');
insert into MAGAZAMUSTERI(mid,telNo)
values(10,'05334657884');

drop table MUSTERI;
drop table SIPARIS;
drop table DEPO;
drop table ONLINEMUSTERI;
drop table MAGAZAMUSTERI;
drop table KITAP;
drop table FATURA;
drop table ODEMELER;
