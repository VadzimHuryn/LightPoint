CREATE PROCEDURE ShowCard 
	@TypeCard Nchar(50) = NULL,
	@NumCard bigint = NULL
AS
BEGIN
	SELECT * FROM Sales.CreditCard
	WHERE CardType = @TypeCard OR CardNumber = @NumCard
END
GO