--Select
--ANSI
Select ContactName İsim,CompanyName SirketAdi,City Sehir from Customers 

Select * from Customers where City ='Berlin' 

--case insensitive -- ilk harfi büyük yazma ve devamını doğru yazma zorunluluğun yok!
seLecT * from Products where categoryId=1 or categoryId=3

seLecT * from Products where categoryId=1 and UnitPrice>=10

seLecT * from Products where CategoryID=1 order by UnitPrice desc --ascending asc      --descending  desc

Select count(*) from Products 

select CategoryID,COUNT(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select  Products.ProductId, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where products.UnitPrice>10

--DTO Data Transformation Object //

select * from Products p inner join [Order Details] od	
on p.ProductID = od.ProductID
inner join orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null 






