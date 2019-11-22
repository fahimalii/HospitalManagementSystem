USE [D:\C#\C# FINAL PROJECT\HMSFINAL\HOSPITALMGMTSYS\HOSPITALMGMTSYS\HMS.MDF]
GO

/****** Object: Table [dbo].[login] Script Date: 4/25/2019 10:03:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[login] (
    [username]    VARCHAR (50) NOT NULL,
    [password]    VARCHAR (50) NOT NULL,
    [designation] VARCHAR (50) NOT NULL,
    [empid]       INT          NOT NULL
);


