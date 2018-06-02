CREATE TABLE [dbo].[Table]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Description] VARCHAR(500) NOT NULL, 
    [Price] DECIMAL(6, 3) NOT NULL, 
    [Catagory] NVARCHAR(50) NOT NULL
)
