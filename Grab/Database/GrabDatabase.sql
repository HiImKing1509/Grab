----------------------------------------------------------------------------------------------
--------------------------- Database: Grab Management ----------------------------------
----------------------------------------------------------------------------------------------
create database Grab
go
--
use Grab
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

-- Insert Data
insert into GRAB_TRANSPORT values('GT01', N'GrabTaxi', N'Bắt taxi dễ dàng và an toàn hơn')
insert into GRAB_TRANSPORT values('GT02', N'GrabCar', N'Xe ô tô riêng phục vụ mọi nhu cầu di chuyển của bạn')
insert into GRAB_TRANSPORT values('GT03', N'JustGrab', N'Tìm xe ô tô/ taxi gần bạn nhất chỉ bằng một thao tác chạm')
insert into GRAB_TRANSPORT values('GT04', N'GrabBike', N'Di chuyển nhanh hơn, tiện lợi hơn cùng mức giá phải chăng hơn')
insert into GRAB_TRANSPORT values('GT05', N'Rent', N'Thuê xe cùng tài xế để phục vụ nhu cầu đi lại riêng của bạn')

insert into GRAB_DELIVERY values('GD01', N'GrabFood', N'Mang đến cho bạn món ăn ưa thích, nóng hổi và ngon lành')
insert into GRAB_DELIVERY values('GD02', N'GrabMart', N'Thả ga lựa chọn nguyên liệu tươi sống và nhu yếu phẩm')
insert into GRAB_DELIVERY values('GD03', N'GrabExpress', N'Việc giao và nhận hàng đã trở nên dễ dàng hơn bao giờ hết!')

insert into GRAB_CATEGORY values(N'Di chuyển', N'Tất tần tật về các dịch vụ phục vụ nhu cầu đi lại của bạn')
insert into GRAB_CATEGORY values(N'Dịch vụ phân phối', N'Dịch vụ giao hàng nhanh chóng và tiện lợi, Cần gì đặt là có ngay')

insert into GRAB_CUSTOMER values(N'CU01', N'Huỳnh Viết Tuấn Kiệt', '0796616454', 'kiet123')

-- Query
---- Select all Transport services in grab application
select * from GRAB_TRANSPORT

---- Select all Delivery services in grab application
select * from GRAB_DELIVERY

---- Select all services category in grab application
select * from GRAB_CATEGORY

-- Drop Table
drop table GRAB_TRANSPORT
drop table GRAB_DELIVERY
drop table GRAB_CATEGORY