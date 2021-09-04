using Microsoft.Azure.CosmosRepository;

namespace Fluent.Http.Dog.Api.Models
{
    public class DogModel : Item
    {
        public string Breed { get; set; } = "Cocker Spaniel";

        public string Name { get; set; } = "Dasher";

        public int Age { get; set; } = 12;
    }
}