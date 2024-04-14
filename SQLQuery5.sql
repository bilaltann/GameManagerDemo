--Select
Select ContactName Adi ,City Sehir from Customers

Select * from Customers where City='London'

--case insensitive(büyük kücük harf duyarsız)
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10