CREATE TABLE Account 
(
	
	DisplayName NVARCHAR(100) NOT NULL,
	UserName NVARCHAR(100) PRIMARY KEY ,
	PassWord NVARCHAR(100) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 3,--1/admin	2/giaovien 3/hocsinh
)
GO

INSERT INTO dbo.Account
        ( DisplayName ,
          UserName ,
          PassWord ,
          Type
        )
VALUES  ( N'Admin' , -- DisplayName - nvarchar(100)
          N'Admin' , -- UserName - nvarchar(100)
          N'1' , -- PassWord - nvarchar(100)
          1  -- Type - int
        ) 

INSERT INTO dbo.Account
        ( DisplayName ,
          UserName ,
          PassWord ,
          Type
        )
VALUES  ( N'TienChung' , -- DisplayName - nvarchar(100)
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
