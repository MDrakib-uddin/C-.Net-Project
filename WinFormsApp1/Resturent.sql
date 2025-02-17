create table users(
  id int primary key identity(1,1),
  username varchar(max),
  password varchar(max),
  role varchar(max),
  status varchar (max),
  date_reg date,
);
insert into users values('admin','admin123','Admin','Active','2025-01-12')
select * from users 

create table food(
   Foodid int primary key,
   Foodname varchar(50),
   Price varchar (100),
   Quantity varchar (50),
   Status varchar (50),
);
select * from food
create table customer(
   Customerid int primary key,
   Customername varchar(50),
   Phone varchar (100),
   Email varchar (50),
   Address varchar (50),
);
select * from customer

create table orders(
   Orderid int primary key,
   Customername varchar(50),
   Food1 varchar (100),
   Food2 varchar (50),
   Food3 varchar (50),
   Orderdate datetime,
);
select * from orders
create table payment(
   Pid int primary key,
   Customername varchar(50),
   Food1 varchar (100),
   Food2 varchar (50),
   Food3 varchar (50),
   PaymentMethod varchar(50),
   Amount varchar(50),
);
select * from payment