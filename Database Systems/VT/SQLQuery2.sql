CREATE TRIGGER MusteriKayit
ON musteri
AFTER INSERT 
AS 
DECLARE @mid int
DECLARE @telNo numeric(11)
SELECT @mid=mid,@telNo='TelNo' from inserted

IF (@mid % 2=0)
	BEGIN
		INSERT INTO magaza values(@mid,@telNo)
	END
ELSE
	BEGIN
		INSERT INTO online values(

