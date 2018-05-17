CREATE TABLE Account 
(
	UserName NVARCHAR(100) PRIMARY KEY ,
	PassWord NVARCHAR(100) NOT NULL DEFAULT 0,
	TypeAccount INT NOT NULL DEFAULT 3--1/admin	2/giaovien 3/hocsinh


)
GO

INSERT INTO dbo.Account
        ( UserName ,
          PassWord ,
          Type
        )
VALUES  ( 
          N'Admin' , -- UserName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(100)
          1  -- Type - int
        ) 

INSERT INTO dbo.Account
        ( 
          UserName ,
          PassWord ,
          Type
        )
VALUES  ( 
          N'TienChung' , -- UserName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(100)
          3  -- Type - int
        ) 

SELECT * FROM dbo.Account WHERE UserName=N'Admin' AND PassWord=1
GO

CREATE PROC GetAccountByUserName
@username NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@username
END	
GO

CREATE PROC Login
@username NVARCHAR(100), @passWord NVARCHAR(100) AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName=@username AND PassWord=@passWord
END
GO

ALTER PROC UpdateAccount
@username NVARCHAR(100), @passWord NVARCHAR(100), @newpassWord VARCHAR(100) AS
BEGIN
	DECLARE @isRightPass INT
    SELECT @isRightPass=COUNT(*) FROM dbo.Account WHERE UserName=@username AND PassWord=@passWord
	IF(@isRightPass=1)
	BEGIN
		UPDATE dbo.Account SET PassWord=@newpassWord WHERE UserName=@username AND PassWord=@passWord
	END 
END
GO 
---------
CREATE TABLE AccountType
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100),
	typef INT NOT NULL
)

INSERT dbo.AccountType
        ( Typename, typeid )
VALUES  ( N'Admin', -- Typename - nvarchar(100)
          1  -- typeid - int
          )

INSERT dbo.AccountType
        ( Typename, typeid )
VALUES  ( N'Giáo viên', -- Typename - nvarchar(100)
          2  -- typeid - int
          )
INSERT dbo.AccountType
        ( Typename, typeid )
VALUES  ( N'Snh viên', -- Typename - nvarchar(100)
          3  -- typeid - int
          )


ALTER PROC GetListAccount as
BEGIN	
	SELECT UserName [Tên đăng nhập], Typename [Kiểu tài khoản] FROM dbo.Account,dbo.AccountType
	WHERE dbo.Account.Type=dbo.AccountType.typeid
END	
GO

EXEC GetListAccount
GO

SELECT b.UserName,a.Typename
FROM dbo.AccountType a,dbo.Account b 
WHERE a.typeid=b.Type AND b.UserName=N'admin'

GO

SELECT a.Ma_hoc_phan,b.Ten_hoc_phan,b.So_tin_chi,a.Diem_cuoi_ky,a.Diemchu,a.Diemhe4,c.Ten_hoc_ky 
FROM dbo.Bang_diem a,dbo.Hoc_phan b,dbo.Hoc_ky c 
WHERE a.Ma_hoc_phan=b.Ma_hoc_phan AND c.Ma_hoc_ky=b.Ma_hoc_ky AND b.Ma_hoc_ky=1
ORDER BY c.Ten_hoc_ky

SELECT * FROM dbo.Hoc_ky
GO
CREATE PROC GetKetQuabyHocKy
@mahocky CHAR(10)
AS
BEGIN
	SELECT a.Ma_hoc_phan,b.Ten_hoc_phan,b.So_tin_chi,a.Diem_cuoi_ky,a.Diemchu,a.Diemhe4,c.Ten_hoc_ky 
FROM dbo.Bang_diem a,dbo.Hoc_phan b,dbo.Hoc_ky c 
WHERE a.Ma_hoc_phan=b.Ma_hoc_phan AND c.Ma_hoc_ky=b.Ma_hoc_ky AND b.Ma_hoc_ky=@mahocky
ORDER BY c.Ten_hoc_ky
END
GO 
ALTER PROC GetKetQuaCaNam
AS
BEGIN
	SELECT a.Ma_hoc_phan,b.Ten_hoc_phan,b.So_tin_chi,a.Diem_cuoi_ky,a.Diemchu,a.Diemhe4,c.Ten_hoc_ky 
FROM dbo.Bang_diem a,dbo.Hoc_phan b,dbo.Hoc_ky c 
WHERE a.Ma_hoc_phan=b.Ma_hoc_phan AND c.Ma_hoc_ky=b.Ma_hoc_ky
ORDER BY c.Ten_hoc_ky
END
GO 

EXEC dbo.GetKetQuabyHocKy @mahocky = '1' -- char(10)
EXEC dbo.GetKetQuaCaNam @mahocky = '' -- char(10)

GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

SELECT * FROM dbo.Hoc_phan WHERE dbo.fuConvertToUnsign1(Ten_hoc_phan) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + N'%'

SELECT*FROM ((dbo.GetLopHocPhan) AS a) WHERE Ma_lop_hoc_phan LIKE N'%1%'

EXEC dbo.GetLopHocPhan

GO
SELECT * FROM dbo.Hoc_phan WHERE dbo.fuConvertToUnsign1(Ten_hoc_phan) LIKE N'%' + dbo.fuConvertToUnsign1(N'a') + '%'