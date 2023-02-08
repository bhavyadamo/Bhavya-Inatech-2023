use Adventureworks
go

--Task1

select FirstName,LastName
from Person.Person where Title is not null

--Task2

select FirstName,LastName
from Person.Person where FirstName like '%a%' AND LastName like'%a%' 


--Task3 

select cur.currencycode,Name
from Sales.CountryRegionCurrency sal,Sales.Currency cur  



--Task4

select * into Humanresources.hr_dept
from HumanResources.Department

select * from HumanResources.hr_dept

--Task5

create table insertcolumn
(sno int identity(1,1),firstname varchar(20),lname varchar(20),phno int,city varchar(20))
select * from insertcolumn
insert insertcolumn values
('bhavya','D',7687797,'chennai')
select * from insertcolumn
insert insertcolumn values
('kavya','H',9898078,'chittoor')

--Task6

select BusinessEntityID,AddressTypeID
from HumanResources.Department dept
inner join Person.BusinessEntityAddress per
on dept.ModifiedDate=per.ModifiedDate

sp_help 'HumanResources.Department'
select * from Person.BusinessEntityAddress


--Task7

select distinct GroupName
from HumanResources.Department

--Task8

select StandardCost
from Production.ProductCostHistory ch
join Production.Product pp
on ch.ProductID=pp.ProductID
join Production.ProductCategory pc
on pc.ModifiedDate=pp.ModifiedDate
group by ProductSubcategoryID



select * from Production.Product
select * from Production.ProductCostHistory
select * from Production.ProductCategory
select * from Production.ProductSubcategory

--Task9 

select DATEDIFF(YEAR ,StartDate,EndDate)
from HumanResources.EmployeeDepartmentHistory

--Task10




--Task11

SELECT MAX(TaxRate) AS "Max_taxrate"  
FROM Sales.SalesTaxRate  


--Task12 

Select dep.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate, getdate() as CurrentDate, year(getdate())-year(emp.BirthDate) as age 
from HumanResources.Department dep 
join HumanResources.Employee emp 
on dep.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

--Task13

create view Name_age
as
Select dep.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate, getdate() as CurrentDate, year(getdate())-year(emp.BirthDate) as age 
from HumanResources.Department dep 
join HumanResources.Employee emp 
on dep.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

select * from Name_age


--Task14 

select count(*) [No_of_rows] from HumanResources.Department, HumanResources.Employee
  
--Task15 

select max(Rate) Max_Rate,Name
from HumanResources.EmployeePayHistory pay join
HumanResources.Department dep
on pay.BusinessEntityID = dep.DepartmentID
group by Name


--Task16

select FirstName,MiddleName,Title,AddressTypeID,pb.BusinessEntityID
from Person.Person pp
left join Person.BusinessEntityAddress pb
on pp.BusinessEntityID=pb.BusinessEntityID
where Title is not null


--Task17

select ProductID,pl.LocationID,Shelf
from Production.ProductInventory pi
join Production.Location pl
on pi.LocationID=pl.LocationID
where ProductID>=300 and ProductID<=350 and pl.LocationID=50 or Shelf='E'

--Task18

select Shelf,Name,pp.LocationID
from Production.ProductInventory pp
join Production.Location pl
on pp.LocationID=pl.LocationID

--Task19

select AddressID,AddressLine1,AddressLine2,sp.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince sp
join Person.Address pa
on sp.StateProvinceID=pa.StateProvinceID

--Task20

select  CurrencyCode,Sum(SubTotal+TaxAmt) as total
from Sales.SalesOrderHeader so
join Sales.SalesTerritory st
on st.TerritoryID=so.TerritoryID
join Sales.CountryRegionCurrency cr
on cr.CountryRegionCode=st.CountryRegionCode
group by CurrencyCode


