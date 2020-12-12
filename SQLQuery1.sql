create database project
create table staff(
id nvarchar(6) PRIMARY KEY not null,
city nvarchar(50),
last_name nvarchar(50),
firt_name nvarchar(10),
states bit default '1',
date_of_birth nvarchar(50),
gender nvarchar(5) default 'Nam',
phone_number nvarchar(10),
email varchar(255) unique,
position nvarchar(20) default 'Nhân viên',
username nvarchar(50) unique not null,
pass nvarchar(100) not null,
create_at nvarchar(50)
)

create table customer(
id nvarchar(7) PRIMARY KEY not null,
city nvarchar(50),
last_name nvarchar(50),
firt_name nvarchar(10),
states bit default '1',
date_of_birth nvarchar(50),
gender nvarchar(5) default 'Nam',
phone_number nvarchar(10),
email varchar(255) unique
)

create table product(
product_id nvarchar(7) PRIMARY KEY not null,
full_name nvarchar(100),
hard_drive nvarchar(10),
ram nvarchar(10),
CPU nvarchar(100),
states bit default '1',
color nvarchar(30),
descriptions nvarchar(200),
images nvarchar(100),
date_of_manufacture nvarchar(50),
total int,
amount int,
supplier_id nvarchar(10) not null,
)

create table invoice(
invoice_id nvarchar(7) PRIMARY KEY not null,
staff_id nvarchar(6),
customer_id nvarchar(7),
create_at nvarchar(50),
states bit default '1'
)

create table details(
invoice_id nvarchar(7) not null,
product_id nvarchar(7) not null,
amount int,
CONSTRAINT details_pk PRIMARY KEY (invoice_id,product_id)
)

create table supplier(
id nvarchar(10) PRIMARY KEY not null,
name nvarchar(50),
)

ALTER TABLE [dbo].[invoice] ADD CONSTRAINT PK_staff FOREIGN KEY(staff_id) REFERENCES [dbo].[Staff](id)
ALTER TABLE [dbo].[details] ADD CONSTRAINT PK_invoice FOREIGN KEY(invoice_id) REFERENCES [dbo].[Invoice](invoice_id)
ALTER TABLE [dbo].[details] ADD CONSTRAINT PK_product FOREIGN KEY(product_id) REFERENCES [dbo].[Product](product_id)
ALTER TABLE [dbo].[invoice] ADD CONSTRAINT PK_customer FOREIGN KEY(customer_id) REFERENCES [dbo].[customer](id)
ALTER TABLE [dbo].[product] ADD CONSTRAINT PK_supppro FOREIGN KEY(supplier_id) REFERENCES [dbo].[supplier](id)


INSERT INTO [dbo].[staff](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email,username,pass,create_at,position) VALUES ('NV1',N'Quách Công',N'Hải',N'TP HCM',N'12/01/2000',N'Nam',037871215,N'admin@gmail.com','admin','$2a$12$qwoPg7iutH7dbVzhofa1rON1pQD678excBuNsj/1bXm096hxmyxw2','07/18/2020',N'Quản lý')
INSERT INTO [dbo].[staff](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email,username,pass,create_at,position) VALUES ('NV2',N'Hồ Kim',N'Hạnh',N'Ninh Thuận',N'10/10/2000',N'Nam',037811225,N'hokimhanh@gmail.com','hokimhanh','$2a$12$qwoPg7iutH7dbVzhofa1rON1pQD678excBuNsj/1bXm096hxmyxw2','07/18/2020',N'Quản lý')
INSERT INTO [dbo].[staff](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email,username,pass,create_at,position) VALUES ('NV3',N'Bùi Xuân',N'Đức',N'Bình Phước',N'03/12/2000',N'Nam',037123215,N'buixuanduc@gmail.com','buixuanduc','$2a$12$qwoPg7iutH7dbVzhofa1rON1pQD678excBuNsj/1bXm096hxmyxw2','07/18/2020',N'Quản lý')
INSERT INTO [dbo].[staff](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email,username,pass,create_at,position) VALUES ('NV4',N'Nguyễn Văn',N'Hậu',N'Phú Thọ',N'02/10/2000',N'Nam',036541215,N'nguyenvanhau@gmail.com','nguyenvanhau','$2a$12$qwoPg7iutH7dbVzhofa1rON1pQD678excBuNsj/1bXm096hxmyxw2','07/18/2020',default)
INSERT INTO [dbo].[staff](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email,username,pass,create_at,position) VALUES ('NV5',N'Nguyễn Thị',N'Hoa',N'Lào Cai',N'10/10/2000',N'Nữ',037987225,N'nguyenthihoa@gmail.com','nguyenthihoa','$2a$12$qwoPg7iutH7dbVzhofa1rON1pQD678excBuNsj/1bXm096hxmyxw2','07/18/2020',default)
INSERT INTO [dbo].[staff](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email,username,pass,create_at,position) VALUES ('NV6',N'Bùi Thị',N'Xuân',N'Yên Bái',N'03/12/2000',N'Nữ',037369215,N'buithixuan@gmail.com','buthixuan','$2a$12$qwoPg7iutH7dbVzhofa1rON1pQD678excBuNsj/1bXm096hxmyxw2','07/18/2020',default)

select * from staff

INSERT INTO [dbo].[customer](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email) VALUES ('KH1',N'Trần Văn',N'Nam',N'Lào Cai',N'10/08/1998',N'Nam',0313910229,N'tranvannam@gmail.com')
INSERT INTO [dbo].[customer](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email) VALUES ('KH2',N'Nguyễn Quang',N'Hải',N'Hà Nội',N'10/08/1995',N'Nam',0370788229,N'nguyenquanghai@gmail.com')
INSERT INTO [dbo].[customer](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email) VALUES ('KH3',N'Trần Duy',N'Nhân',N'Hà Tĩnh',N'10/08/1999',N'Nam',0378980229,N'nguyenduynhan@gmail.com')
INSERT INTO [dbo].[customer](id,last_name,firt_name,city,date_of_birth,gender,phone_number,email) VALUES ('KH4',N'Chu Nguyên',N'Chương',N'Hà Tĩnh',N'10/08/1990',N'Nam',0378985890,N'chunguyenchuong@gmail.com')

select * from customer


INSERT INTO [dbo].[supplier](id,name) VALUES (N'DELL',N'DELL')
INSERT INTO [dbo].[supplier](id,name) VALUES (N'ASUS',N'ASSUS')
INSERT INTO [dbo].[supplier](id,name) VALUES (N'HP',N'HP')
INSERT INTO [dbo].[supplier](id,name) VALUES (N'MSI',N'MSI')
INSERT INTO [dbo].[supplier](id,name) VALUES (N'APPLE',N'APPLE')
INSERT INTO [dbo].[supplier](id,name) VALUES (N'RAZER',N'RAZER')
INSERT INTO [dbo].[supplier](id,name) VALUES (N'ACER',N'ACER')
INSERT INTO [dbo].[supplier](id,name) VALUES (N'LENOVO',N'LENOVO')
INSERT INTO [dbo].[supplier](id,name) VALUES (N'SAMSUNG',N'SAMSUNG')



INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions) 
				VALUES ('SP1',N'Lenovo ThinkPad T480s',N'LENOVO',N'16GB',N'SSD 512GB',N'Intel Core i7-8650U 1.9GHz, 8MB SmartCache Cache, Upto 4.2GHz',N'Black',N'29/12/2019',27000000,N' i7-8650U RAM 16GB SSD 512GB FHD IPS')
INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions)  
				VALUES ('SP2',N'Latitude 5400',N'DELL',N'8GB',N'SSD 512GB',N'Intel Core i5-8365U 1.60 GHz, 6 MB Intel® Smart Cache Cache, Upto 4.10 GHz',N'Black',N'01/01/2019',19000000,N' i5-8365U RAM 8GB SSD 512GB 14" FHD IPS')
INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions)  
				VALUES ('SP3',N'HP Elitebook 830 G5',N'HP',N'8GB',N'SSD 128GB',N'Intel® Core™ i3-8130U 2.20 GHz, 4MB SmartCache Cache, Upto 3.40 GHz',N'White',N'01/08/2019',15000000,N' i3-8130U SSD 128GB RAM 8GB FHD')
INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions)  
				VALUES ('SP4',N'ASUS ZenBook 14 UM433DA',N'ASUS',N'8GB',N'SSD 256GB',N'Intel® Core™ i5-8130U 2.20 GHz, 4MB SmartCache Cache, Upto 3.40 GHz',N'White',N'01/08/2019',20000000,N' i5-8130U SSD 256GB RAM 8GB FHD')
INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions) 
				VALUES ('SP5',N'Lenovo IdeaPad Slim 3 15IIL05',N'LENOVO',N'4GB',N'SSD 128GB',N'Intel Core i3-8650U 1.9GHz, 8MB SmartCache Cache, Upto 4.2GHz',N'Black',N'29/12/2019',12900000,N' i3-8650U RAM 4GB SSD 128GB FHD IPS')
INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions)  
				VALUES ('SP6',N'Dell Inspiron 5593',N'DELL',N'8GB',N'SSD 128GB',N'Intel Core i5-8365U 1.60 GHz, 6 MB Intel® Smart Cache Cache, Upto 4.10 GHz',N'Black',N'01/01/2019',19000000,N' i5-8365U RAM 8GB SSD 128GB 14" FHD IPS')
INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions)  
				VALUES ('SP7',N'Laptop HP 15s du1039TX',N'HP',N'8GB',N'SSD 256GB',N'Intel® Core™ i7-8130U 2.20 GHz, 4MB SmartCache Cache, Upto 3.40 GHz',N'White',N'01/08/2019',18000000,N' i7-8130U SSD 256GB RAM 8GB FHD')
INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions)  
				VALUES ('SP8',N' MSI Gaming Leopard 10SDK GL65',N'MSI',N'16GB',N'SSD 512GB',N'Intel® Core™ i7-10750H 2.20 GHz, 4MB SmartCache Cache, Upto 3.40 GHz',N'Black',N'10/08/2019',32000000,N' i7-10750H SSD 512GB RAM 16GB FHD')
INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions)  
				VALUES ('SP9',N'Laptop Acer Aspire A514 53G 513J',N'ACER',N'8GB',N'SSD 512GB',N'Intel® Core™ i5-1035G1 2.20 GHz, 4MB SmartCache Cache, Upto 3.40 GHz',N'White',N'01/08/2019',15000000,N' i5-1035G1 SSD 512GB RAM 8GB FHD')
INSERT INTO [dbo].[product](product_id,full_name,supplier_id,ram,hard_drive,CPU,color,date_of_manufacture,total,descriptions)  
				VALUES ('SP10',N'Newest Samsung - Galaxy TabPro S 2-in-1 12',N'SAMSUNG',N'8GB',N'SSD 256GB',N'Intel® Core™ i5-1035G1 2.20 GHz, 4MB SmartCache Cache, Upto 3.40 GHz',N'White',N'01/08/2019',15000000,N' i5-1035G1 SSD 256GB RAM 8GB FHD')

INSERT INTO [dbo].[invoice](invoice_id,staff_id,customer_id,create_at) VALUES('HD1','NV1','KH1',N'11/22/19')
INSERT INTO [dbo].[invoice](invoice_id,staff_id,customer_id,create_at) VALUES('HD2','NV3','KH2',N'10/22/19')
INSERT INTO [dbo].[invoice](invoice_id,staff_id,customer_id,create_at) VALUES('HD3','NV1','KH4',N'11/25/19')
INSERT INTO [dbo].[invoice](invoice_id,staff_id,customer_id,create_at) VALUES('HD4','NV2','KH2',N'01/02/19')

INSERT INTO [dbo].[details](invoice_id,product_id,amount) VALUES('HD1','SP1',2)
INSERT INTO [dbo].[details](invoice_id,product_id,amount) VALUES('HD1','SP2',1)
INSERT INTO [dbo].[details](invoice_id,product_id,amount) VALUES('HD3','SP1',3)
INSERT INTO [dbo].[details](invoice_id,product_id,amount) VALUES('HD3','SP2',1)



create proc list_invoice
AS
BEGIN
select *
from invoice i, details d , product p ,staff s, customer c where (d.invoice_id = 'hd1' and d.product_id = p.product_id)
and(i.staff_id = s.id and i.invoice_id = d.invoice_id) and (i.customer_id = c.id)
END