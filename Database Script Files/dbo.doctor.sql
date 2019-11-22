USE [D:\C#\C# FINAL PROJECT\HMSFINAL\HOSPITALMGMTSYS\HOSPITALMGMTSYS\HMS.MDF]
GO

/****** Object: Table [dbo].[doctor] Script Date: 4/25/2019 10:03:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[doctor] (
    [doctorid]      INT          IDENTITY (1, 1) NOT NULL,
    [specialty]     VARCHAR (50) NOT NULL,
    [availabledays] VARCHAR (50) NOT NULL,
    [empid]         INT          NOT NULL
);


