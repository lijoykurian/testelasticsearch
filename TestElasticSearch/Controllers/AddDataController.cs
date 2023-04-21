using Microsoft.AspNetCore.Mvc;
using TestElasticSearch.Models;

namespace TestElasticSearch.Controllers;
[ApiController]
[Route("[controller]")]
public class AddDataController
{
    
//add a post method to controller
    [HttpPost]
    public  ActionResult<DataObject>  Post([FromBody] DataObject dataObject)
    {
        return dataObject;

    }
    
}