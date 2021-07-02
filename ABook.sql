create database AddressBookService;
use AddressBookService;
create table Addressdetails(
firstName varchar(255),
lastName varchar(255),
addresss varchar(255),
city varchar(255),
statee varchar(255),
zipcode int,
PhoneNumber varchar(255),
email varchar(255),
);
insert into Addressdetails
values ('Ravi','kumar','RRcomplex','Nellore','AndhraPradesh',524001,'6546546541','254asd@gmail.com'),
('Mohan','Reddy','Balaji Street','Vizag','Andhrapradesh','500036','7644566278','mohan@gmail.com'),
('Madhu','Roy','abc Street','Vizayawada','Andhrapradesh','500056','7644565778','madhu@gmail.com'),
('yeshwanth','Jona','def Street','Banglore','Karnataka','500066','7645676278','john@gmail.com'),
('Martin','Setty','hij Street','Indore','Punjab','505536','7644564568','martin@gmail.com')
select*from Addressdetails
update Addressdetails set firstName='Pavan' where firstName='Ravi';
delete from Addressdetails where firstName = 'Ravi';
