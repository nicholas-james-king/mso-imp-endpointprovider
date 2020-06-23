CREATE PROCEDURE [EndPointProvider].[Update_Endpoint]
	@enpointname varchar(max),
	@newhostname varchar(max)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @hostid uniqueidentifier
		DECLARE @endpointid uniqueidentifier
		SELECT TOP 1 @hostid = eph.Id
		FROM [EndpointProvider].[EndpointHosts] eph
		WHERE eph.Name = @newhostname

		IF @hostid IS NULL
		BEGIN
			ROLLBACK TRANSACTION
			RETURN
		END

		SELECT TOP 1 @endpointid = ep.id
		FROM [EndpointProvider].[Endpoints] ep
		WHERE ep.Name = @endpointid

		IF @endpointid IS NULL
		BEGIN
			ROLLBACK TRANSACTION
			RETURN
		END

		UPDATE [EndpointProvider].[Endpoints]
		SET HostId = @hostid
		WHERE [Name] = @newhostname
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END
GO
