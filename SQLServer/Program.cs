using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            /* SQL Server Komutlari
             
-------------------------------------------------------------------- SELECT / FROM / AS / TOP / WHERE
--select * from Person.Person
--select Title, FirstName, LastName from Person.Person

--select FirstName as Isim, LastName Soyisim from Person.Person

--select top 10 * from Production.Product

--select top 10 percent * from Production.Product

--select * from Production.Product
--where MakeFlag = 1
-------------------------------------------------------------------- AND OR
--select * from Production.Product
--where MakeFlag = 1 and SafetyStockLevel = 800

--select * from Production.Product
--where Color = 'Red' or Color = 'Black' 
-------------------------------------------------------------------- IN NOT
--select * from HumanResources.Employee
--where JobTitle in ('Design Engineer', 'Tool Designer' )

--select * from HumanResources.Employee
--where JobTitle not in ('Design Engineer', 'Tool Designer' )
-------------------------------------------------------------------- BETWEEN / ORDER BY / DESC
--select * from Production.Product
--where SafetyStockLevel between 800 and 1000 order by Name

--select * from Production.Product
--where SafetyStockLevel between 800 and 1000 order by Name desc
-------------------------------------------------------------------- LIKE / % / _
--select * from Production.Product
--where ProductNumber like 'A%'

--select * from person.Person
--where FirstName like 'K_n'


-------------------------------------------------------------------- ODEV
select * from production.products
where model_year = 2016

select * from production.products
where model_year between 2016 and 2018 and product_name like '%cyc%'

select * from sales.customers 
where email like '%yahoo.com' and state in ('NY', 'CA')

select * from sales.customers 
where first_name like 'D%' or last_name like '%s'


---------------------------------------------------------------------- GROUP BY
--select Color, sum(1) from Production.Product
--where color is not null
--group by Color 

--select PersonType, sum(1) from Person.Person
--group by PersonType
---------------------------------------------------------------------- DISTINCT
--select distinct JobTitle from HumanResources.Employee

---------------------------------------------------------------------- INNER JOIN
--select 
--Production.Product.ProductID,
--Production.Product.Name,
--Production.ProductSubcategory.Name as ProductSubCategory
--from Production.Product inner join Production.ProductSubcategory
--on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
----
--select --top 10
--C.AccountNumber,
--count(SOH.SalesOrderNumber) as TotalOrderAmount
--from Sales.SalesOrderHeader SOH inner join Sales.Customer C
--on SOH.CustomerID = C.CustomerID
--group by C.AccountNumber 
--order by TotalOrderAmount desc
----
--select 
--SOH.AccountNumber,
--SOH.SalesOrderNumber,
--PP.Name,
--PSC.Name as SubCategory,
--PC.Name as Category,
--SOD.UnitPrice
--from Sales.SalesOrderDetail SOD 
--inner join Sales.SalesOrderHeader SOH on SOD.SalesOrderID = SOH.SalesOrderID
--inner join Production.Product PP on SOD.ProductID = PP.ProductID
--inner join Production.ProductSubcategory PSC on  PP.ProductSubcategoryID = PSC.ProductSubcategoryID
--inner join Production.ProductCategory PC on PSC.ProductCategoryID = PC.ProductCategoryID

---------------------------------------------------------------------- LEFT JOIN / RIGHT JOIN // FULL JOIN
--select * from Production.Product PP inner join Production.ProductSubcategory PPSC
--on PP.ProductSubcategoryID = PPSC.ProductSubcategoryID	

--select * from Production.Product PP left join Production.ProductSubcategory PPSC
--on PP.ProductSubcategoryID = PPSC.ProductSubcategoryID	

--select * from Production.Product PP right join Production.ProductSubcategory PPSC
--on PP.ProductSubcategoryID = PPSC.ProductSubcategoryID	

--select * from Production.Product PP full join Production.ProductSubcategory PPSC
--on PP.ProductSubcategoryID = PPSC.ProductSubcategoryI

---------------------------------------------------------------------- ODEV
--select PC.category_name, count(brand_id)  from production.products PP
--inner join production.categories PC
--on PP.category_id = PC.category_id
--group by PC.category_name

----

--select concat(SC.first_name, ' ', SC.last_name) as FullName, count(SO.customer_id) from sales.orders SO
--inner join sales.customers SC on SO.customer_id = SC.customer_id
--group by concat(SC.first_name, ' ', SC.last_name)

----
 
--select store_name, count(1) from sales.orders SO
--inner join sales.stores SS on SO.store_id = SS.store_id
--group by store_name

----

--select concat(first_name,' ',last_name), count(1) from sales.orders SO
--inner join sales.staffs SS on SO.store_id = SS.store_id
--group by concat(first_name,' ',last_name)

----

--select brand_name, category_name,count(OI.order_id) from sales.order_items OI
--inner join production.products PP on OI.product_id = PP.product_id
--inner join production.categories PC on PP.category_id = PC.category_id
--inner join production.brands PB on PP.brand_id = PB.brand_id
--group by brand_name, category_name
--order by count(1) desc

----

--select store_name, sum(PS.quantity) as UrunToplam from production.stocks PS
--inner join sales.stores SS on  PS.store_id = SS.store_id
--group by store_name


---------------------------------------------------------------------- CREATE DATABASE / DROP DATABASE
--create database EnisCanYildiz
--drop database EnisCanYildiz

---------------------------------------------------------------------- CREATE TABLE / ALTER TABLE | add,drop,column / DROP TABLE
--create table Urunler
--(
--	id int,
--	urunAdi nvarchar(100),
--	miktar int,
--	olusturmaTarih datetime
--)

--alter table Urunler
--add email nvarchar(200)

--alter table Urunler
--drop column email

--drop table Urunler

---------------------------------------------------------------------- NOT NULL / UNIQUE / PRIMARY KEY / CHECK / DEFAULT
--create table Kisiler
--(
--	id int primary key,
--	isim nvarchar(50),
--	soyisim nvarchar(50) not null,
--	emailAdres nvarchar(50) not null unique,
--	yas int not null check(yas>=16),
--	olusturmaTarihi datetime default getdate()
--)

---------------------------------------------------------------------- FOREIGN KEY
--create table musteri
--(
--	id int primary key,
--	musteriNumara int,
--	tckn nvarchar(15),
--	vkn nvarchar(15),
--	isim nvarchar(50),
--	soyisim nvarchar(50),
--	olusturmaTarih datetime
--)

--create table musteriIletisimBilgileri
--(
--	id int primary key,
--	musteriId  int,
--	iletisimTip int,
--	deger nvarchar(500),
--	olusturmaTarih datetime,
--	foreign key (musteriID) references musteri(id)
--)

---------------------------------------------------------------------- INSERT / UPDATE / DELETE
--select * from tablo_adi
--insert into tablo_adi (id,isim,soyisim) values (1,'Enis','Yildiz')
----
--update tablo_adi 
--set isim = 'Sude',
--	soyisim = 'Hizli'
--where id = 1
----
--delete tablo_adi where id = 2


---------------------------------------------------------------------- STORE PROCEDURE
--create proc procedure_adi
--(
----parametre veya parametreler
--@id int,
--@isim nvarchar(50)
--)

--as
--begin
----procedure body
--end

----

--create proc PersonelKayitEkle
--(
--	@id int,
--	@isim nvarchar(50),
--	@soyisim nvarchar(50),
--	@emailAdres nvarchar(50)
--)
--as
--begin
--insert into Personeller (id,isim,soyisim,emailAdres,olusturmaTarihi,silindimi) 
--values (@id,@isim,@soyisim,@emailAdres,getdate(),0)

--end

--exec PersonelKayitEkle @id=3,@isim='Sevda',@soyisim='Yildiz',@emailAdres='sevdayildiz@gmail.com'

---------------------------------------------------------------------- ALTER PROC / DROP PROC
--alter proc PersonelKayitEkle
--(
--	@id int,
--	@isim nvarchar(50),
--	@soyisim nvarchar(50),
--	@emailAdres nvarchar(50)
--)
--as
--begin
--insert into Personeller (id,isim,soyisim,emailAdres,olusturmaTarihi,degistirmeTarihi,silindimi) 
--values (@id,@isim,@soyisim,@emailAdres,getdate(),getdate(),0)
--end

--drop proc PersonelKayitEkle

------------------------------------------------------------------------
--create proc PersonelGetir
--as
--begin
--select * from Personeller
--end

--exec PersonelGetir

----

--create proc GetHumanResourceEmployee
--(
--	@Gender char(1) = 'F' --deger verilmezse default F degeri atanir.
--)
--as
--begin
--select * from HumanResources.Employee
--where Gender = @Gender
--end


------------------------------------------------------------------------ ODEV
--insert Udemy.dbo.Personeller
--select
--PP.BusinessEntityID,
--PP.FirstName,
--PP.LastName,
--concat(lower(PP.FirstName),'.',lower(PP.LastName),'@hotmail.com'),
--HRE.Gender,
--GETDATE(),
--1
--from AdventureWorks2022.Person.Person PP
--inner join AdventureWorks2022.HumanResources.Employee HRE
--on PP.BusinessEntityID = HRE.BusinessEntityID

------
--create proc PersonelEkle
--(
--	@id int,
--	@isim nvarchar(50),
--	@soyisim nvarchar(50),
--	@emailadres nvarchar(200),
--	@cinsiyet nchar(1),
--	@olusturmaTarihi datetime,
--	@durum bit
--)
--as
--begin
--insert into Personeller(id,isim,soyisim,emailadres,cinsiyet,olusturmaTarihi,durum)
--values (@id,@isim,@soyisim,@emailadres,@cinsiyet,@olusturmaTarihi,@durum)
--return @@rowcount

--end
------
--create proc PersonelDuzenle
--(
--	@id int,
--	@isim nvarchar(50),
--	@soyisim nvarchar(50),
--	@emailadres nvarchar(200),
--	@cinsiyet nchar(1),
--	@olusturmaTarihi datetime,
--	@durum bit
--)
--as
--begin
--update Personeller set
--isim = @isim,
--soyisim = @soyisim,
--emailadres = @emailadres,
--cinsiyet = @cinsiyet,
--olusturmaTarihi = @olusturmaTarihi,
--durum = @durum
--where id = @id
--return @@rowcount
--end
------
--create proc PersonelSil
--(
--	@id int
--)
--as
--begin
--	delete Personeller
--	where id = @id
--	return @@rowcount
--end
------
--create proc PersonelListe
--as
--begin
--select * from Personeller
--end
------
--create proc PersonelGetirId
--(
--	@id int = 0
--)
--as
--begin
--select * from Personeller where id = @id
--end
------
--create proc PersonelGetirEmail
--(
--	@emailAdres nvarchar(200)
--)
--as
--begin
--select * from Personeller where emailadres = @emailAdres
--end

-------------------------------------SAYISAL FONKSIYONLAR---------------------------------- MIN / MAX / COUNT / AVG / SUM

--select max(SafetyStockLevel) as enBuyukDeger, min(SafetyStockLevel) as enKucukDeger from Production.Product group by Color
------
--select count(*) from Production.Product

--select count(*) from HumanResources.Employee
--where LoginID = 'adventure-works\ken0' and NationalIDNumber = '295847284'

--select Color, count(*) from Production.Product
--where Color is not null
--group by Color
------
--select avg(SafetyStockLevel) from Production.Product
------
--select sum(SafetyStockLevel) from Production.Product

--select
--concat(PP.FirstName,' ', PP.LastName) as NameSurname,
--sum(SSOD.LineTotal) as Toplam,
--avg(SSOD.LineTotal) as Ortalama
--from Sales.SalesOrderHeader SSOH
--inner join Sales.SalesOrderDetail SSOD
--on SSOH.SalesOrderID = SSOD.SalesOrderID
--inner join Person.Person PP
--on SSOH.SalesPersonID = PP.BusinessEntityID
--where SSOH.OrderDate = '2011-05-31 00:00:00.000'
--group by concat(PP.FirstName,' ', PP.LastName)

-------------------------------------METINSEL FONKSIYONLAR---------------------------------- UPPER / LOWER / LEN / CONCAT / SPACE / SUBSTRING / LEFT / RIGHT
--select upper(LoginID) from HumanResources.Employee
--select Lower(JobTitle) from HumanResources.Employee
------
--select FirstName, len(FirstName) from Person.Person
------
--select concat(FirstName,SPACE(1),LastName) as [Isim Soyisim]  from Person.Person
------
--select SUBSTRING(Name,1,3) from Production.Product
------
--select right(name,3) from Production.Product
--select left(name,3) from Production.Produ
























             */

        }
    }
}
