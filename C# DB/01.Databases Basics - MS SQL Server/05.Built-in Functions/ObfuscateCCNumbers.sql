SELECT CustomerID, 
	   FirstName, 
	   LastName, 
	   LEFT(PaymentNumber, 6) + '**********' 
FROM Customers