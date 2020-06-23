CREATE PROCEDURE [EndPointProvider].[Add_Endpoint]
	@path varchar(max),
	@host varchar(max),
	@name varchar(max),
	@isIntegrationPoint BIT
AS
BEGIN
	INSERT INTO [EndpointProvider].[EndPoints](Name, Path, HostId, IsIntegrationPoint)
	VALUES(@name, @path, @host, @isIntegrationPoint);
END
GO