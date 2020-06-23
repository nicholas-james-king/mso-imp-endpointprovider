CREATE PROCEDURE [EndPointProvider].[Add_EndpointHost]
	@host varchar(max),
	@name varchar(max)
AS
BEGIN
	INSERT INTO [EndpointProvider].[EndpointHosts](Host, Name)
	VALUES(@host, @name)
END
GO
