USE [D:\C#\C# FINAL PROJECT\HMSFINAL\HOSPITALMGMTSYS\HOSPITALMGMTSYS\HMS.MDF]
GO

/****** Object: Table [dbo].[person] Script Date: 4/25/2019 10:03:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[person] (
    [personid]   INT          IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (50) NOT NULL,
    [age]        INT          NOT NULL,
    [gender]     VARCHAR (50) NOT NULL,
    [bloodgroup] VARCHAR (50) NULL,
    [phone]      VARCHAR (50) NOT NULL
);


