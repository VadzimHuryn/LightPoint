using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day4WebApiDapper.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Day4WebApiDapper.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DapperController : Controller
    {
        private QueryProcessor queryProcessor;
        
            
        public DapperController()
        {
            queryProcessor = queryProcessor = new QueryProcessor(new DatabaseConnectionProvider());
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

       [HttpGet]
       public IEnumerable<PersonWithSalesPersonModel> GetPersons()
        {
            
            return queryProcessor.GetResultQuery2();
        }

        [HttpGet]
        public IEnumerable<ProductWithPhoto> GetProducts()
        {
            return queryProcessor.GetResultQuery1();
        }

        [HttpGet]
        public IEnumerable<CardVisaModel> GetCards()
        {
            return queryProcessor.GetResultQuery3();
        }
    }
}
