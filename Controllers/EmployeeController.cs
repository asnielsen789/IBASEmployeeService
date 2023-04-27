namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    using Microsoft.Azure.Cosmos;

    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "GetHenvendelse")]
        public async Task<Henvendelse> GetHenvendelse()
        {
            // CosmosClient should always be a singleton for an application
            using (CosmosClient cosmosClient = new CosmosClient("https://ibas-db-account-13892.documents.azure.com:443/", "RVuFTfQzdP2H7pPfM7d7Iu0rZ7S3OcdSEq5acb7BtauIZ86p8hmZgMvEGDIPFysYGPU05CAki3lYACDbV4SWaw=="))
            {
                Container container = cosmosClient.GetContainer("IBasSupportDB", "ibassupport");
                
                // Read item from container
                ItemResponse<Henvendelse> response = await container.ReadItemAsync<Henvendelse>("ae9a06ce-bec4-425c-8d78-cd868da78df7", new PartitionKey("/category"));
                Henvendelse henvendelse = response.Resource;
                return henvendelse;
                System.Console.WriteLine("test");
            }

            /*var employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            }
        };
            return employees;
            */
        }
    }


}