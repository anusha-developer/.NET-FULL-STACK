Create database  Practice;
Create Table Tbl_Company(
 CompanyId int Identity(1,1) primary key,
 CompanyName  varchar(200),
 CompanyCode int,
 CompanyOpeningDate date,
 CompanyMembers int,
 CompanyAddress varchar(200),
 CompanyMobileno bigint,
 CompanyStatus varchar(100));

 select * from Tbl_Company;

 ---Insert into table values---
 insert into Tbl_Company values('Capgemini',0151,'4-15-2007',5000,'Banglore',
                                 9837782787,'Active');
insert into Tbl_Company values('Accenture',1151,'2-22-2009',6000,'Hyderabad',
                                 9016277262,'DeActive');
insert into Tbl_Company values('IBM',0273,'9-13-2012',9000,'Delhi',
                                 8097318738,'Active');
insert into Tbl_Company values('TCS',1290,'8-29-2001',2000,'London',
                                 9075216272,'DeActive');
insert into Tbl_Company values('Google',2051,'5-18-2019',1000,'chenni',
                                 8043657278,'Active');
----delete the single records by using id----
delete from Tbl_Company where CompanyId=2;
delete from Tbl_Company where CompanyName='Capgemini';

---delete the total table with column names---
drop table Tbl_Company;

---truncate can delete the  only inserted rows not delete column names---
truncate table Tbl_Company;

--update if u  want to update any values by using Id based---
Update Tbl_Company set CompanyName='TechMahendra' where CompanyId=4;

---if u want Add a new Column By using  Alter--
Alter  table  Tbl_Company Add CompanyEmailId varchar(400);

--In that updated column we can  insert values--
Update Tbl_Company1 set CompanyEmailId='TechMahendra@gmail.com' where CompanyId=4;
Update Tbl_Company1 set CompanyEmailId='Google@gmail.com' where CompanyId=5;

---- if u want to delete the particular column  we use this syntax---
Alter table Tbl_Company1 drop column CompanyEmailId;

Alter  table Tbl_Company1 modify  CompanyName(200);


-- if u want to rename the table name--
sp_rename 'Tbl_Company', 'Tbl_Company1'
select * from Tbl_Company1;

--Alter table Tbl_Company Rename  Tbl_Company1;
--delete from Tbl_Company where CompanyId=6;
--insert into Tbl_Company(CompanyEmailId)values('Capgemini@gmail.com');

Create table Tbl_Student1(
Student_Id int,
Student_Name varchar(100),
Student_Branch varchar(200),
Student_DOB date,
Student_emailId varchar(400),
Student_MobileNo bigint,
CompanyCode int,
CompanyAddress varchar(200));

select * from Tbl_Student1;

 insert into Tbl_Student1 values(1,'Anusha','CSE','8-23-1998','anushachitty@gmail.com',8288882882,0433,'Banglore');
 insert into Tbl_Student1 values(2,'Binnu','EEE','10-8-2006','binnu@gmail.com',9087657776,1020,'Hyderabad');
 insert into Tbl_Student1 values(3,'Fruity','ECE','3-2-2008','Fruity@gmail.com',9027273833,2992,'Chenni');
   
   truncate table Tbl_Student1;
 ---JOINS---

 ---inner Join--
 select * from  Tbl_Company1 as A inner join Tbl_Student1 C on 
 A.CompanyCode=C.CompanyCode

 ---Left Join---
 select * from Tbl_Company1  as A left join Tbl_Student1 C on 
 A.CompanyCode=C.CompanyCode

 ---Right Join---
select * from Tbl_Company1 as A right join  Tbl_Student1 C on
A.CompanyCode=C.CompanyCode
