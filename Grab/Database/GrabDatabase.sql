----------------------------------------------------------------------------------------------
--------------------------- Database: Grab Management ----------------------------------
----------------------------------------------------------------------------------------------
create database Grab
go
--
use Grab
go

-- Convert languague
CREATE FUNCTION [dbo].[LanguageComprehension](@inputVar NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-', 0)
    RETURN @inputVar
END
go


-- Create Table
create table GRAB_TRANSPORT (
	GRAB_ID char(4),
	GRAB_NAME nvarchar(20),
	GRAB_DESCRIPTION nvarchar(200),
	constraint PK_GRAB_TRANSPORT primary key (GRAB_ID)
)
go

create table GRAB_DELIVERY (
	GRAB_ID char(4),
	GRAB_NAME nvarchar(20),
	GRAB_DESCRIPTION nvarchar(200),
	constraint PK_GRAB_DELIVERY primary key (GRAB_ID)
)
go

create table GRAB_CATEGORY (
	GRAB_CATEGORY_NAME nvarchar(20),
	GRAB_CATEGORY_DESCRIPTION nvarchar(200),
	constraint PK_GRAB_CATEGORY primary key (GRAB_CATEGORY_NAME)
)
go

create table GRAB_CUSTOMER (
	GRAB_CUSTOMER_ID char(4),
	GRAB_CUSTOMER_NAME nvarchar(100),
	GRAB_CUSTOMER_PHONE_NUMBER nvarchar(11),
	GRAB_CUSTOMER_PASSWORD nvarchar(50),
	constraint PK_CUSTOMER primary key (GRAB_CUSTOMER_ID)
)

-- CREATE provinces TABLE
create table PROVINCES (
	PROVINCE_CODE nvarchar(20) NOT NULL,
	PROVINCE_NAME nvarchar(255) NOT NULL,
	PROVINCE_NAME_ENG nvarchar(255) NULL,
	PROVINCE_FULLNAME nvarchar(255) NOT NULL,
	PROVINCE_FULLNAME_ENG nvarchar(255) NULL,
	PROVINCE_CODE_NAME nvarchar(255) NULL,
	ADMIN_UNIT_ID integer NULL,
	ADMIN_REGION_ID integer NULL,
	PROVINCE_LATITUDE float NULL,
	PROVINCE_LONGITUDE float NULL,
	CONSTRAINT PROVINCES_PK PRIMARY KEY (PROVINCE_CODE)
)


-- CREATE districts TABLE
create table DISTRICTS (
	DISTRICTS_CODE nvarchar(20) NOT NULL,
	DISTRICTS_NAME nvarchar(255) NOT NULL,
	DISTRICTS_NAME_ENG nvarchar(255) NULL,
	DISTRICTS_FULLNAME nvarchar(255) NULL,
	DISTRICTS_FULLNAME_ENG nvarchar(255) NULL,
	DISTRICTS_CODE_NAME nvarchar(255) NULL,
	PROVINCE_CODE nvarchar(20) NULL,
	ADMIN_UNIT_ID integer NULL,
	CONSTRAINT DISTRICTS_PK PRIMARY KEY (DISTRICTS_CODE)
);

-- CREATE wards TABLE
create table WARDS (
	WARDS_CODE nvarchar(20) NOT NULL,
	WARDS_NAME nvarchar(255) NOT NULL,
	WARDS_NAME_ENG nvarchar(255) NULL,
	WARDS_FULLNAME nvarchar(255) NULL,
	WARDS_FULLNAME_ENG nvarchar(255) NULL,
	WARDS_CODE_NAME nvarchar(255) NULL,
	DISTRICTS_CODE nvarchar(20) NULL,
	ADMIN_UNIT_ID integer NULL,
	CONSTRAINT WARDS_PK PRIMARY KEY (WARDS_CODE)
);

create table GRAB_CAR (
	GRAB_CAR_ID char(4) NOT NULL,
	GRAB_CAR_ID_PROVINCE nvarchar(20) NOT NULL,
	GRAB_CAR_NAME nvarchar(255) NOT NULL,
	GRAB_CAR_SEATS integer NOT NULL,
	GRAB_CAR_START integer NOT NULL,
	GRAB_CAR_END integer NOT NULL,
	GRAB_CAR_COST integer NOT NULL,
	GRAB_CAR_NUMBER nvarchar(10) NOT NULL,
	GRAB_CAR_DRIVER_NAME nvarchar(255) NOT NULL,
	GRAB_CAR_DRIVER_AGE integer NOT NULL,
)


-- Drop Table
drop table GRAB_CAR
drop table GRAB_DELIVERY
drop table GRAB_CATEGORY

-- Query
---- Select all Transport services in grab application
select * from GRAB_TRANSPORT
go
---- Select all Delivery services in grab application
select * from GRAB_DELIVERY
go
---- Select all services category in grab application
select * from GRAB_CATEGORY
go

-- Select all Provinces
select * from PROVINCES
go

-- Select all Districts
select * from DISTRICTS
go

-- Select all Wards
select * from WARDS
go

-- Join Location
SELECT PROVINCE_CODE, WARDS_CODE, A.LOCATION, PROVINCE_LATITUDE, PROVINCE_LONGITUDE FROM
(
	SELECT
		WARDS.WARDS_CODE,
		PROVINCES.PROVINCE_CODE,
		PROVINCES.PROVINCE_LATITUDE,
		PROVINCES.PROVINCE_LONGITUDE,
		CONCAT(WARDS.WARDS_NAME,', ',DISTRICTS.DISTRICTS_NAME, ', ', PROVINCES.PROVINCE_NAME) as LOCATION,
		CONCAT(WARDS.WARDS_CODE_NAME,', ',DISTRICTS.DISTRICTS_CODE_NAME, ', ', PROVINCES.PROVINCE_CODE_NAME) as LOCATION_CODE_A,
		CONCAT(WARDS.WARDS_CODE_NAME,', ',PROVINCES.PROVINCE_CODE_NAME, ', ', DISTRICTS.DISTRICTS_CODE_NAME) as LOCATION_CODE_B,
		CONCAT(DISTRICTS.DISTRICTS_CODE_NAME,', ',WARDS.WARDS_CODE_NAME, ', ', PROVINCES.PROVINCE_CODE_NAME) as LOCATION_CODE_C,
		CONCAT(PROVINCES.PROVINCE_CODE_NAME,', ',WARDS.WARDS_CODE_NAME, ', ', DISTRICTS.DISTRICTS_CODE_NAME) as LOCATION_CODE_D,
		CONCAT(DISTRICTS.DISTRICTS_CODE_NAME,', ',PROVINCES.PROVINCE_CODE_NAME, ', ', WARDS.WARDS_CODE_NAME) as LOCATION_CODE_E,
		CONCAT(PROVINCES.PROVINCE_CODE_NAME,', ',DISTRICTS.DISTRICTS_CODE_NAME, ', ', WARDS.WARDS_CODE_NAME) as LOCATION_CODE_F
	FROM PROVINCES
	JOIN DISTRICTS
		ON PROVINCES.PROVINCE_CODE = DISTRICTS.PROVINCE_CODE
	JOIN WARDS
		ON DISTRICTS.DISTRICTS_CODE = WARDS.DISTRICTS_CODE
) A
WHERE A.LOCATION_CODE_A like N'%%'
	or A.LOCATION_CODE_B like N'%%'
	or A.LOCATION_CODE_C like N'%%'
	or A.LOCATION_CODE_D like N'%%'
	or A.LOCATION_CODE_E like N'%%'
	or A.LOCATION_CODE_F like N'%%'

-- Select all GrabCar services
select * from GRAB_CAR where GRAB_CAR_ID_PROVINCE = 1 and 