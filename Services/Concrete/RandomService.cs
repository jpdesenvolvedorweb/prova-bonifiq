using ProvaPub.Services.Abstract;

namespace ProvaPub.Services.Concrete
{
    public class RandomService : IRandomService
    {
        
        public RandomService()
        {     
        }
        public int GetRandom()
        {
           var seed = Guid.NewGuid().GetHashCode();
            return new Random(seed).Next(100);
        }

    }
}
