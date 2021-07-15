Select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID


Select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

Select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o on o.OrderID=od.OrderID