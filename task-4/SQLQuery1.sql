create database product ;
use product ;

create table products (
product_id int primary key identity (1,1),
product_name nvarchar (50),
product_quntite int ,
product_price float ,
product_store nvarchar (50),

);


