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

create table CUSTOMER (
	CUSTOMER_PHONE_NUMBER nvarchar(11),
	CUSTOMER_PASSWORD nvarchar(50),
	CUSTOMER_NAME nvarchar(100),
	CUSTOMER_EMAIL nvarchar(50),
	constraint PK_CUSTOMER primary key (CUSTOMER_PHONE_NUMBER)
)
go


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
	GRAB_CAR_SCORE integer NOT NULL
)

create table GRAB_BIKE (
	GRAB_BIKE_ID char(4) NOT NULL,
	GRAB_BIKE_ID_PROVINCE nvarchar(20) NOT NULL,
	GRAB_BIKE_NAME nvarchar(255) NOT NULL,
	GRAB_BIKE_START integer NOT NULL,
	GRAB_BIKE_END integer NOT NULL,
	GRAB_BIKE_COST integer NOT NULL,
	GRAB_BIKE_NUMBER nvarchar(10) NOT NULL,
	GRAB_BIKE_DRIVER_NAME nvarchar(255) NOT NULL,
	GRAB_BIKE_DRIVER_AGE integer NOT NULL,
	GRAB_BIKE_SCORE integer NOT NULL,
)

create table HISTORY (
	SERVICE_ID char(4) NOT NULL,
	CUSTOMER_ID char(10) NOT NULL,
	PROVINCE_ID nvarchar(20) NOT NULL,
	LOCATION_START nvarchar(255) NOT NULL,
	LOCATION_END nvarchar(255) NOT NULL,
	DISTANCE float NOT NULL,
	SERVICE_TIME datetime,
	SERVICE_EVALUATE_SCORE integer
)

create table RENT_CAR (
	SERVICE_CATEGORY nvarchar(20) NOT NULL,
	SERVICE_NUMBER_CAR nvarchar(20) NOT NULL,
	SERVICE_NUMBER_SEATS nvarchar(20) NOT NULL,
	PROVINCE_CODE nvarchar(20) NOT NULL,
	STATUS_RENT int NOT NULL,
)

create table RENT_CAR_HISTORY (
	CUSTOMER_ID nvarchar(10) NOT NULL,
	SERVICE_NUMBER_CAR nvarchar(20) NOT NULL,
	SERVICE_TIME datetime,
	SERVICE_TIME_RENT int,
	SERVICE_COST int,
)

create table COMMENT (
	DRIVER_ID varchar(4) NOT NULL,
	CUSTOMER_ID nvarchar(10) NOT NULL,
	COMMENT_TIME datetime,
	COMMENT_CONTENT nvarchar(1000),
	COMMENT_RATE int,
)

insert into COMMENT values ('GB01', '0796616454', '12-18-2022 15:45:21 PM', N'Bác này lái xe hơi chiến :))))', 4);

select * from RENT_CAR
select * from RENT_CAR_HISTORY
truncate table RENT_CAR_HISTORY

INSERT INTO RENT_CAR_HISTORY (CUSTOMER_ID, SERVICE_NUMBER_CAR, SERVICE_TIME, SERVICE_TIME_RENT, SERVICE_COST) VALUES 
	('0796616454', '06-C5 0877', '12-11-2021 15:45:21 PM', 12, 600),
	('0796616454', '45-N6 4577', '08-22-2021 15:45:21 PM', 2, 100),
	('0796616454', '68-K6 1827', '04-04-2021 15:45:21 PM', 12, 600),
	('0796616454', '09-P2 7961', '09-02-2020 15:45:21 PM', 8, 360),
	('0796616454', '14-X9 9315', '10-11-2019 15:45:21 PM', 8, 360),
	('0796616454', '06-O5 5515', '10-12-2019 15:45:21 PM', 8, 360),
	('0796616454', '20-G5 6298', '10-11-2021 15:45:21 PM', 8, 360),
	('0796616454', '15-R9 7559', '10-04-2020 15:45:21 PM', 12, 600);

select * from RENT_CAR_HISTORY join RENT_CAR on RENT_CAR_HISTORY.SERVICE_NUMBER_CAR = RENT_CAR.SERVICE_NUMBER_CAR where RENT_CAR_HISTORY.CUSTOMER_ID = '0796616454' and STATUS_RENT = 0 order by SERVICE_TIME asc

select * from RENT_CAR where SERVICE_CATEGORY = 'GrabCar' and SERVICE_NUMBER_SEATS = 4 and STATUS_RENT = 0 and PROVINCE_CODE = '01'

select * from RENT_CAR

select * from GRAB_TRANSPORT where dbo.LanguageComprehension(GRAB_NAME) like '%bike%'

select * from GRAB_BIKE 

drop table RENT_CAR

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
select * from GRAB_CAR where GRAB_CAR_ID_PROVINCE = 1 and GRAB_CAR_COST < 400 and GRAB_CAR_COST > 200 and GRAB_CAR_SEATS = 4 order by GRAB_CAR_COST asc

select PROVINCE_CODE from PROVINCES