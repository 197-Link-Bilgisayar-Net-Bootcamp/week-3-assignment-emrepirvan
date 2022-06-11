--Create database Den12
USE [Den12]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 6.06.2022 18:14:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductFeatures](
	[PFeatureId] [int] IDENTITY(1,1) NOT NULL,
	[PFeatureName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductFeature] PRIMARY KEY CLUSTERED 
(
	[PFeatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[Cat_Id] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductFeatures]  WITH CHECK ADD  CONSTRAINT [FK_ProductFeature_Products] FOREIGN KEY([PFeatureId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[ProductFeatures] CHECK CONSTRAINT [FK_ProductFeature_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([Cat_Id])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO


Insert Into Categories Values ('Steel')
Insert Into Categories Values ('Copper')
Insert Into Categories Values ('Plastic')
Insert Into Categories Values ('Gold')
Insert Into Categories Values ('Silver')
Insert Into Categories Values ('Mercury')


Insert Into Products Values ('Steel',1)
Insert Into Products Values ('Copper product',2)
Insert Into Products Values ('Plastic product',3)
Insert Into Products Values ('Ring',4)
Insert Into Products Values ('Silver Ring',5)

Insert Into ProductFeatures values ('spoon maded w/steel')
Insert Into ProductFeatures values ('Wire maded w/Copper')
Insert Into ProductFeatures values ('rope maded w/Plastic')
Insert Into ProductFeatures values ('Ring maded w/Gold')

Select * from Categories
Select * from ProductFeatures
Select * from Products


Select p.ProductName,pf.PFeatureName from Products p join ProductFeatures pf on p.ProductId = pf.PFeatureId 
Select c.CategoryName, count(p.ProductName) from Categories c join Products p on c.CategoryId = p.Cat_Id group by CategoryName,  p.ProductName
Select * from Products where ProductName ='Steel'


CREATE PROC sp_Product_Feature
AS
BEGIN
       Select p.ProductName,pf.PFeatureName from Products p join ProductFeatures pf on p.ProductId = pf.PFeatureId 
END
EXEC sp_Product_Feature


CREATE View View_Category_Product
AS
Select c.CategoryName, count(p.ProductName) from Categories c join Products p on c.CategoryId = p.Cat_Id group by CategoryName,  p.ProductName
