USE [D:\C#\C# FINAL PROJECT\HMSFINAL\HOSPITALMGMTSYS\HOSPITALMGMTSYS\HMS.MDF]
GO

/****** Object: Table [dbo].[appointment] Script Date: 4/25/2019 10:02:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[appointment] (
    [appointmentid] INT      IDENTITY (1, 1) NOT NULL,
    [starttime]     TIME (7) NOT NULL,
    [date]          DATE     NOT NULL,
    [personid]      INT      NOT NULL,
    [doctorid]      INT      NOT NULL,
    [complete]      INT      NOT NULL
);


