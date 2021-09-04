using Fluent.Http.Dog.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.CosmosRepository;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Fluent.Http.Dog.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogController : ControllerBase
    {
        private readonly IRepository<DogModel> _repository;

        public DogController(IRepository<DogModel> repository) => _repository = repository;

        [HttpGet]
        public async ValueTask<IActionResult> GetDogs() =>
            Ok(await _repository.GetAsync(d => d.Type == nameof(DogModel)));

        [HttpGet("{dogId}")]
        public async ValueTask<IActionResult> GetDog([FromRoute] string dogId)
        {
            try
            {
                return Ok(await _repository.GetAsync(dogId));
            }
            catch (CosmosException e) when (e.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound($"The dog with id {dogId} was not found.");
            }
        }

        [HttpPost]
        public async ValueTask<IActionResult> NewDog([FromBody] DogModel dog)
        {
            if (string.IsNullOrWhiteSpace(dog.Name))
                return BadRequest("A dog must have a name");

            if (string.IsNullOrWhiteSpace(dog.Breed))
                return BadRequest("A dog must have a breed");

            IEnumerable<DogModel> dogs = await _repository.GetAsync(d => d.Name == dog.Name && d.Breed == dog.Breed);

            IEnumerable<DogModel> enumerable = dogs.ToList();

            if (enumerable.Any())
            {
                return BadRequest(
                    $"Sorry the name {enumerable.First().Name} has already been assigned for this breed.");
            }

            await _repository.CreateAsync(dog);

            return Ok(dog);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateDog([FromBody] DogModel dog)
        {
            IEnumerable<DogModel> dogs = await _repository.GetAsync(d => d.Name == dog.Name && d.Breed == dog.Breed);

            IEnumerable<DogModel> dogModels = dogs.ToList();
            if (dogModels.Any())
            {
                DogModel update = dogModels.First();
                update.Age = dog.Age;
                await _repository.UpdateAsync(dog);
                return Ok();
            }

            return NotFound($"The dog with the name {dog.Name} & breed {dog.Breed} was not found");
        }

        [HttpDelete("{dogId}")]
        public async ValueTask<IActionResult> DeleteDog([FromRoute] string dogId)
        {
            try
            {
                await _repository.DeleteAsync(dogId);
            }
            catch (CosmosException e) when (e.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound($"The dog with id {dogId} was not found.");
            }

            return Ok();
        }
    }
}