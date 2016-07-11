using Dapper;
using System.Collections.Generic;

namespace DapperApplication
{
    public class QueryProcessor
    {
        private const string ConnectionStringName = "AdventureWorks";

        private readonly DatabaseConnectionProvider _connectionProvider;
        private readonly ConfigurationProvider _configurationProvider;

        public QueryProcessor(DatabaseConnectionProvider connectionProvider, ConfigurationProvider configurationProvider)
        {
            _connectionProvider = connectionProvider;
            _configurationProvider = configurationProvider;
        }

        public IEnumerable<Product> GetResultQuery1()
        {
            IEnumerable<Product> result;
            var connectionString = _configurationProvider.GetConnectionString(ConnectionStringName);
            using (var connection = _connectionProvider.GetConnection(connectionString))
            {
                connection.Open();
                result = connection.Query<Product>("SELECT Product.Name, Quantity, LargePhotoFileName FROM Production.Product"+
                    " INNER JOIN Production.ProductInventory on Production.Product.ProductID = Production.ProductInventory.ProductID"+
                    " INNER JOIN Production.ProductProductPhoto on Production.Product.ProductID = Production.ProductProductPhoto.ProductID"+
                    " INNER JOIN Production.ProductPhoto on Production.ProductProductPhoto.ProductPhotoID = Production.ProductPhoto.ProductPhotoID"+
                    " WHERE LargePhotoFileName != 'no_image_available_large.gif' AND Quantity >= 150");
                connection.Close();
            }
            return result;
        }

        public IEnumerable<Person> GetResultQuery2()
        {
            IEnumerable<Person> result;
            var connectionString = _configurationProvider.GetConnectionString(ConnectionStringName);
            using (var connection = _connectionProvider.GetConnection(connectionString))
            {
                connection.Open();
                result = connection.Query<Person>("SELECT t1.FirstName + ' ' + t1.LastName AS FIO, t1.BusinessEntityID AS PERSON_ID, t2.BusinessEntityID AS Sales_Person_ID, t3.BusinessEntityID AS STHID FROM Person.Person t1"+
                " LEFT JOIN Sales.SalesPerson t2 on t1.BusinessEntityID = t2.BusinessEntityID"+
                " JOIN Sales.SalesTerritoryHistory t3 on t1.BusinessEntityID = t3.BusinessEntityID"+
                " WHERE t2.Bonus > 1000 AND t2.Bonus < 3600" );
                connection.Close();
            }
            return result;
        }

        public IEnumerable<Card> GetResultQuery3()
        {
            IEnumerable<Card> result;
            var connectionString = _configurationProvider.GetConnectionString(ConnectionStringName);
            using (var connection = _connectionProvider.GetConnection(connectionString))
            {
                connection.Open();
                result = connection.Query<Card>("SELECT t3.FirstName+' ' + t3.LastName AS Name, t1.CardType, t1.CardNumber FROM Sales.CreditCard t1"+
                " INNER JOIN Sales.PersonCreditCard t2 on t1.CreditCardID = t2.CreditCardID"+
                " RIGHT JOIN Person.Person t3 on t3.BusinessEntityID = t2.BusinessEntityID"+
                " WHERE CardType is NULL or CardType = 'Vista'");
                connection.Close();
            }
            return result;
        }
    }
}