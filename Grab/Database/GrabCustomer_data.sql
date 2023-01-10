use Grab
go

insert into CUSTOMER values('0796616454', '1', N'Huỳnh Viết Tuấn Kiệt', 'kingtk.1509@gmail.com')
go

select * from CUSTOMER
update CUSTOMER set CUSTOMER_PASSWORD = '12' where CUSTOMER_PHONE_NUMBER = '0796616454'