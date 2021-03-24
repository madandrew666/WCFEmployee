CREATE TABLE [dbo].[Employee]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(50) NOT NULL, 
    [HireDate] DATETIME NOT NULL, 
    [Salary] INT NOT NULL, 
    [DepartmentID] INT NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL
)
