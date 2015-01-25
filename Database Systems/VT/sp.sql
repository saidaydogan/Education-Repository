alter procedure sp_MusteriKayit
@mid int,
@isim varchar(100),
@email nvarchar(100),
@szt datetime,
@telNo numeric(11)

as
insert into musteri values(@mid,@isim);

if(@mid % 2=0)
	begin
		insert into magaza values(@mid,@telNo);
	end
else
	begin
		insert into online values(@mid,@email,@szt);
	end

go

create procedure sp_SiparisEkle
@sipNo int,
@parcaNo int,
@miktar smallint,
@birimFiyat money,
@adi nvarchar(300),
@hangiDepo int,
@tarih datetime,
@musteri int

as
insert into siparis values(@sipNo,@tarih,@musteri);
insert into kitap values(@sipNo,@parcaNo,@miktar,@birimFiyat,@adi,@hangiDepo);

go

alter procedure sp_SiparisGuncelle
@sipNo int,
@parcaNo int,
@miktar smallint,
@birimFiyat money,
@adi nvarchar(300),
@hangiDepo int,
@tarih datetime,
@musteri int

as

if ((select count(*) from fatura where @sipNo=sipNo) > 0 )
	begin
		RAISERROR('%d nolu Siparis, faturasý olduðu için degistirilemez.',10,1,@sipNo)
	end
	else
	begin
		update kitap set
		miktar=@miktar,
		birimFiyat=@birimFiyat,
		adi=@adi,
		hangiDepo=@hangiDepo
		where sipNo=@sipNo

		update siparis set
		musteri=@musteri,
		tarih=@tarih
	end
	