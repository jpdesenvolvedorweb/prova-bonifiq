using ProvaPub.Services.Abstract;

namespace ProvaPub.Services.Concrete
{
    public class RandomService : IRandomService
    {
        int seed;
        public RandomService()
        {
            seed = Guid.NewGuid().GetHashCode();
        }
        public int GetRandom()
        {
            return new Random(seed).Next(100);
        }

    }
}
