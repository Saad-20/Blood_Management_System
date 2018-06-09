CREATE TABLE [dbo].[DONATE_BLOOD] (
    [ID]               INT           NOT NULL,
    [First_Name]       CHAR (50)     NOT NULL,
    [Last_Name]        CHAR (50)     NOT NULL,
    [Cell_Number]      VARCHAR (20)  NOT NULL,
    [Address]          VARCHAR (120) NOT NULL,
    [Blood_type]       VARCHAR (10)  NOT NULL,
    [Date_Of_Donation] VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

