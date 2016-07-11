--CREATE DATABASE Carts

USE Carts

CREATE TABLE [dbo].[Cart]
(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[CartName] NVARCHAR(120) NOT NULL,
	[CreateDate] datetime DEFAULT(GETDATE()) NOT NULL,
	CONSTRAINT [PR_Cart_Id] PRIMARY KEY CLUSTERED ([Id] ASC)

);


CREATE TABLE [dbo].[Order] (
    [Id] INT IDENTITY(1, 1) NOT NULL,
	[CartId] INT NOT NULL,
    [OrderName] NVARCHAR(120) DEFAULT('') NOT NULL,
  
    CONSTRAINT [PK_Order_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Order_CartId_Cart_Id] FOREIGN KEY ([CartId]) REFERENCES [dbo].[Cart] ([Id])
);

CREATE TABLE [dbo].[OrderItem] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [OrderId] INT NOT NULL,
    [UnitPrice] MONEY DEFAULT(0) NOT NULL,

    CONSTRAINT [PK_OrderItem_Id] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrderItem_OrderId_Order_Id] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([Id])
);


--INSERT INTO [Cart] (CartName, CreateDate)
--VALUES ('NameOne', GETDATE())
--INSERT INTO [Cart] (CartName, CreateDate)
--VALUES ('NameTwo', GETDATE())
--INSERT INTO [Cart] (CartName, CreateDate)
--VALUES ('NameFive', GETDATE())

--SELECT * FROM [Cart]

--INSERT INTO [Order] (CartId, OrderName)
--VALUES (1, 'Order1')
--INSERT INTO [Order] (CartId, OrderName)
--VALUES (2, 'Order1')
--INSERT INTO [Order] (CartId, OrderName)
--VALUES (3, 'Order1')
--INSERT INTO [Order] (CartId, OrderName)
--VALUES (1, 'Order2')
--INSERT INTO [Order] (CartId, OrderName)
--VALUES (2, 'Order2')
--INSERT INTO [Order] (CartId, OrderName)
--VALUES (3, 'Order2')
--INSERT INTO [Order] (CartId, OrderName)
--VALUES (1, 'Order3')
--INSERT INTO [Order] (CartId, OrderName)
--VALUES (2, 'Order3')
--INSERT INTO [Order] (CartId, OrderName)
--VALUES (3, 'Order3')

SELECT * FROM [Order]

SELECT * FROM [OrderItem]