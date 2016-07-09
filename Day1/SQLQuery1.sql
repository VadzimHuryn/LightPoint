SELECT Product.Name, Quantity, LargePhotoFileName FROM Production.Product

INNER JOIN Production.ProductInventory on Production.Product.ProductID = Production.ProductInventory.ProductID 
INNER JOIN Production.ProductProductPhoto on Production.Product.ProductID = Production.ProductProductPhoto.ProductID
INNER JOIN Production.ProductPhoto on Production.ProductProductPhoto.ProductPhotoID = Production.ProductPhoto.ProductPhotoID
 WHERE LargePhotoFileName != 'no_image_available_large.gif' AND Quantity >= 150

