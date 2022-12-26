----------------------------------------------------------------------------------------------
--------------------------- Database: Grab Management ----------------------------------
----------------------------------------------------------------------------------------------
create database Grab
go
--
use Grab
go

-- Create Table 
create table GRAB_SERVICES (
	GRAB_SERVICE_ID char(4),
	GRAB_SERVICE_NAME nvarchar(100),
)

-- Insert Data
insert into GRAB_SERVICES values('SV01', N'Car')
insert into GRAB_SERVICES values('SV02', N'Bike')

-- Query
---- Select all services in grab application
select * from GRAB_SERVICES

-- Drop Table