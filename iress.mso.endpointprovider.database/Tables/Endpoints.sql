﻿CREATE TABLE [EndPointProvider].[Endpoints]
(
    [Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
    [Name] VARCHAR(MAX) NOT NULL, 
    [Path] VARCHAR(MAX) NOT NULL, 
    [HostId] UNIQUEIDENTIFIER NOT NULL,
    [IsIntegrationPoint] BIT NOT NULL DEFAULT 0,
    [DateCreated] DATETIME NOT NULL DEFAULT GETDATE(), 
    [LastUpdatdDate] DATETIME NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_Endpoints_EndpointHosts] FOREIGN KEY ([HostId]) REFERENCES [EndpointProvider].[EndPointHosts](Id) ON DELETE CASCADE
)