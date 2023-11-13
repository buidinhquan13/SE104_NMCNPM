CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Drink
-- DrinkTable
-- DrinkCategory
-- Account
-- Bill
-- BillInfo
-- Customer

CREATE TABLE DrinkTable
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	Number INT NOT NULL DEFAULT 0,
	Status NVARCHAR(100) NOT NULL DEFAULT N'Trống',	-- Trống || Có người
	isEnabled BIT NOT NULL DEFAULT 1
)
GO

CREATE TABLE Account
(
	Username NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL,
	Password NVARCHAR(1000) NOT NULL DEFAULT 'MA==',
	Type INT NOT NULL  DEFAULT 0 -- 1: admin || 0: staff
)
INSERT INTO Account (Username, DisplayName, Password, Type) VALUES('QWRtaW4=', 'Admin', 'QWRtaW4=', 1)
GO

CREATE TABLE DrinkCategory
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	isEnabled BIT NOT NULL DEFAULT 1
)
GO

CREATE TABLE Drink
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	IDCategory INT NOT NULL,
	Price FLOAT NOT NULL DEFAULT 0,
	isEnabled BIT NOT NULL DEFAULT 1

	FOREIGN KEY (IDCategory) REFERENCES DrinkCategory(ID)
)
GO

CREATE TABLE Bill
(
	ID INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	IDTable INT,
	Discount FLOAT DEFAULT 0,
	TotalPrice FLOAT DEFAULT 0,
	Status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (IDTable) REFERENCES DrinkTable(ID)
)
GO

CREATE TABLE BillInfo
(
	ID INT IDENTITY PRIMARY KEY,
	IDBill INT NOT NULL,
	IDDrink INT NOT NULL,
	Count INT NOT NULL DEFAULT 0,
	Total INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (IDBill) REFERENCES Bill(ID),
	FOREIGN KEY (IDDrink) REFERENCES Drink(ID)
)
GO

CREATE TABLE Customer
(
	Username NVARCHAR(100) PRIMARY KEY,
	RegisterDate DATE NOT NULL DEFAULT GETDATE(),
	Point FLOAT NOT NULL DEFAULT 0
)
GO

CREATE PROC USP_GetAccountByUsername
@username nvarchar(100)
AS 
BEGIN
	SELECT * FROM Account WHERE Username = @username
END
GO

CREATE PROC USP_Login
@username nvarchar(100), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM Account WHERE Username = @username AND Password = @password
END
GO

CREATE PROC USP_GetTableList
AS
SELECT * FROM DrinkTable WHERE isEnabled = 1
GO

CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT Bill (DateCheckIn, DateCheckOut, IDTable, Status, Discount) VALUES (GETDATE(), NULL, @idTable, 0, 0)
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idDrink INT, @count INT
AS
BEGIN
	DECLARE @isExistBillInfo INT
	DECLARE @DrinkCount INT = 1

	SELECT @isExistBillInfo = ID, @DrinkCount = BillInfo.Count FROM BillInfo WHERE IDBill = @idBill AND IDDrink = @idDrink

	IF (@isExistBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @DrinkCount + @count
		IF (@newCount > 0) 
			UPDATE BillInfo SET Count = @DrinkCount + @count WHERE IDDrink = @idDrink
		ELSE
			DELETE BillInfo WHERE IDBill = @idBill AND IDDrink = @idDrink
	END
	ELSE
	BEGIN
	INSERT BillInfo (IDBill, IDDrink, Count) VALUES (@idBill, @idDrink, @count)
	END
END
GO

CREATE TRIGGER UTG_UpdateBillInfo
ON BillInfo 
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = IDBill FROM INSERTED

	DECLARE @idTable INT
	SELECT @idTable = IDTable FROM Bill WHERE ID = @idBill AND Status = 0

	IF (@idTable IS NOT NULL)
		UPDATE DrinkTable SET Status = N'Có người' WHERE ID = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON Bill
FOR UPDATE, DELETE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = ID FROM INSERTED

	DECLARE @idTable INT
	SELECT @idTable = IDTable FROM Bill WHERE ID = @idBill
	
	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM Bill WHERE IDTable = @idTable AND STATUS = 0

	IF (@idTable IS NOT NULL)
	BEGIN
		IF (@count <= 0)
			UPDATE DrinkTable SET Status = N'Trống' WHERE ID = @idTable AND isEnabled = 1
		ELSE
			UPDATE DrinkTable SET Status = N'Có người' WHERE ID = @idTable AND isEnabled = 1 
	END
END
GO

CREATE PROC USP_SwitchTable
@idFirstTable INT, @idSecondTable INT
AS
BEGIN
	DECLARE @idFirstBill INT
	SELECT @idFirstBill = ID FROM Bill WHERE IDTable = @idFirstTable AND Status = 0

	DECLARE @idSecondBill INT
	SELECT @idSecondBill = ID FROM Bill WHERE IDTable = @idSecondTable AND Status = 0

	IF (@idFirstBill IS NOT NULL AND @idSecondBill IS NOT NULL)
	BEGIN
		UPDATE Bill
		SET IDTable = @idFirstTable
		WHERE ID = @idSecondBill

		UPDATE Bill
		SET IDTable = @idSecondTable
		WHERE ID = @idFirstBill
	END

	IF (@idFirstBill IS NOT NULL AND @idSecondBill IS NULL)
	BEGIN
		UPDATE Bill
		SET IDTable = @idSecondTable
		WHERE ID = @idFirstBill

		UPDATE DrinkTable
		SET Status = N'Trống'
		WHERE ID = @idFirstTable AND isEnabled = 1
	END
	
END
GO

CREATE PROC USP_GetListBillByDate
@checkIn DATE, @checkOut DATE
AS
BEGIN
	SELECT TotalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], Discount AS [Giảm giá]
	FROM Bill
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND Status = 1
END
GO

CREATE PROC USP_GetCustomerList
AS
BEGIN
	SELECT * FROM Customer
END
GO

CREATE PROC USP_UpdateAccount
@username NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM Account WHERE Username = @username AND Password = @password

	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE Account SET DisplayName = @displayName WHERE Username = @username
		END
		ELSE
			UPDATE Account SET DisplayName = @displayName, Password = @newPassword WHERE Username = @username
	END
END
GO

CREATE TRIGGER UTG_DeleteBillInfo
ON BillInfo
FOR DELETE
AS
BEGIN
	DECLARE @idBillInfo INT
	SELECT @idBillInfo = ID FROM DELETED

	DECLARE @idBill INT
	SELECT @idBill = IDBill FROM DELETED

	DECLARE @idTable INT
	SELECT @idTable = IDTable FROM Bill WHERE ID = @idBill

	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM BillInfo, Bill WHERE Bill.ID = IDBill AND IDBill = @idBill AND STATUS = 0

	IF (@count = 0)
		UPDATE DrinkTable SET Status = N'Trống' WHERE ID = @idTable AND isEnabled = 1
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
