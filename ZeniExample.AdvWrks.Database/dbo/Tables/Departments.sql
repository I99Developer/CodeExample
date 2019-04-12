CREATE TABLE [dbo].[Departments] (
    [DepartmentID] INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX) NULL,
    [GroupName]    NVARCHAR (MAX) NULL,
    [ModifiedDate] DATETIME       NOT NULL,
    CONSTRAINT [PK_dbo.Departments] PRIMARY KEY CLUSTERED ([DepartmentID] ASC)
);

