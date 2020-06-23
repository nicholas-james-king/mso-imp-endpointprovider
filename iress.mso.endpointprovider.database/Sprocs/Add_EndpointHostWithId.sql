CREATE PROCEDURE [dbo].[Add_EndpointHostWithId]
	@id varchar(max),
	@host varchar(max),
	@name varchar(max)
AS
BEGIN
	INSERT INTO [EndpointProvider].[EndpointHosts](Id, Host, Name)
	VALUES(@id, @host, @name)
END
GO
