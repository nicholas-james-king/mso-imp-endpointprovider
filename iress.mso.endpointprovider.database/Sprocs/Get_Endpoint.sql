CREATE PROCEDURE [EndPointProvider].[Get_Endpoint]
	@name varchar(MAX)
AS
BEGIN
	SELECT ep.Id, ep.Name, CONCAT(eph.Host, '/', ep.Path) as URI, ep.DateCreated, ep.LastUpdatdDate 
	FROM [EndpointProvider].[Endpoints] ep
	JOIN [EndpointProvider].[EndpointHosts] eph on ep.HostId = eph.Id
	WHERE ep.Name = @name
END
GO
