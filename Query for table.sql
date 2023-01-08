create database Pharmacy
create table Supplier_t(
SupplierID int identity(1,1) primary key,
SupplierName varchar (24) not null,
Saddress varchar (70) not null,
Cell varchar(20) not null,
Company varchar (30) not null 

);

drop table Supplier_t


insert into Supplier_t values('Ali','Lahore','0333775544','GSK');

 select*
 from Supplier_t;
  select Barcode,ItemName,Descriptionn,Price,NoOfBoxes,Carton,SupplierID
 from Item_t;

create table Item_t(
Barcode varchar(30) primary key ,
ItemName varchar (30) not null,
Descriptionn varchar (29) not null,
Price int not null,
NoOfBoxes int not null,
Carton int not null,
SupplierID int foreign key references Supplier_t(SupplierID) on update cascade 
);


insert into Item_t values('ba112345','Panadol','Tablet',2000,3,4,null);


delete from Item_t
 select*
 from Item_t;


create table Purchase_t(
Barcode varchar(30) foreign key references Item_t(Barcode) on delete cascade ,
SupplierID int foreign key references Supplier_t(SupplierID) on delete cascade ,
primary key(Barcode,SupplierID,PurchaseDate),
Carton int,
NoOfBoxes int not null,
PurchasePrice int not null,
PurchaseDate date default getdate(),
ExpiryDate date not null
 );

 
insert into Purchase_t values('ba112345',1,6,30,200,default,'2015-12-17');


 select*
 from Purchase_t;
 drop table Purchase_t

 create table Sale_t(
 InvoiceNo int identity(1,1) primary key, 
 CustomerName varchar(30) not null,
 Barcode varchar(30) foreign key references Item_t(Barcode) on update cascade on delete cascade,
 NoOfBoxes int not null,
 SaleDate date default getdate(),
 SalePrice int not null
 );
 create table inventory(
 Barcode varchar(30) foreign key references item_t(Barcode) primary key,
 ItemName varchar (30) not null,
 Descriptionn varchar(30),
 SalePrice int not null,
 PurchasePrice int not null,
 NoofBoxes int not null,
 ExpiryDate date ,
);


insert into Sale_t values('Mufti','ba112345',25,default,2300);


select* from Sale_t;


----create  table Inventory 
--		( Barcode ,Item_t.ItemName,Item_t.Descriptionn,
--		Sale_t.SalePrice,Purchase_t.PurchasePrice ,Purchase_t.NoOfBoxes-Sale_t.NoOfBoxes
--		from Item_t inner join Purchase_t  ON Item_t.Barcode = Purchase_t.Barcode
--		 inner join Sale_t on Purchase_t.Barcode=Sale_t.Barcode;
		 select* 
		 from Inventory;
drop table Purchase_t;
drop database Pharmacy
drop  view Inventory
drop table Item_t
drop table Sale_t

select SupplierID,SupplierName,Saddress,Cell,Company
from Supplier_t

update Supplier_t 
set 
Saddress='Lahore',
Company='DsdBA',
SupplierName='AHmadHassan',
Cell='3231312232'
where SupplierID=10;
;

select*
from Item_t
select barcode,SupplierID,Carton,NoofBOxes,purchaseprice,PurchaseDate,ExpiryDate
from purchase_T
"Update Student_Record set regNO ='"+regNo+"',Name='"+Name+"',quiz='"+quiz+"',mid='"+mid+"',final='"+final+"'where regNO='"+regNo+"' ";


select *
from Sale_t

select *
from purchase_T

select*
from Item_t
select barcode,itemName,SalePrice,PurchasePrice,NoofBoxes,ExpiryDate 
		 from Inventory;




		 select I.NoofBoxes, t.itemName,t.noofboxes,t.price from Item_t t full join Inventory I on t.barcode=I.Barcode  where I.Barcode='20-1137';

		 alter table item_t
		 drop column carton

		 drop view inventory
		
		select InvoiceNo,customerName,Barcode,NoOfBoxes,SaleDate,Saleprice
		from Sale_t;


		alter table inventory
		drop column descriptionn

		delete from Sale_t
		delete from purchase_T
		delete from inventory