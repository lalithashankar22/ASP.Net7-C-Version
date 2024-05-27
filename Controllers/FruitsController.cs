using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using version.Model;

namespace version.Controllers
{   //[Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class FruitsController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        [Route("fruits")]
        ///http://localhost:5140/api/Fruits/fruits?api-version=1.0
        public IActionResult GetFruitsListV1()
        {
            string[] fruits = { "apple", "grapes" ,"guva","Pine Apple","kiwi" };

            var fruit = fruits[Random.Shared.Next(fruits.Length)];

            FruitModelV1 fruitModelV1 = new FruitModelV1();
            fruitModelV1.FruitName = fruit;

            return Ok(fruitModelV1);

        }
        [MapToApiVersion("2.0")]
        [HttpGet]
        [Route("fruits")]
        ///http://localhost:5140/api/Fruits/fruits?api-version=1.0
        public IActionResult GetFruitsListV2()
        {
            string[] fruits = { "appleee", "grapes", "guva", "Pine Apple", "kiwi" };

            var fruit = fruits[Random.Shared.Next(fruits.Length)];

            FruitModelV2 fruitModelV2 = new FruitModelV2();
            fruitModelV2.FruitNameee = fruit;

            return Ok(fruitModelV2);

        }
    }
}
