CREATE TABLE [dbo].[Students](
	[ID] [int] NOT NULL PRIMARY KEY DEFAULT (ABS(CHECKSUM(NEWID())) % 90000000 + 10000000),
	[FirstName] [varchar](100) NOT NULL,
	[MiddleName] [varchar](100) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[fullName] [nvarchar](100) NULL,
	[Course] [varchar](100) NOT NULL,
	[CurriculumYear] [varchar](50) NOT NULL,
	[YearLevel] [int] NOT NULL,
	[Semester] [int] NULL,
);


