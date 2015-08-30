using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.BreakDependencies
{
    public class AnimalFeedingService
    {
        public IFeederService FeederService { get; set; }

        public AnimalFeedingService(IFeederService feederService)
        {
            FeederService = feederService;
        }

        private bool FoodBowlEmpty { get; set; }

        public void Feed()
        {
            if (FoodBowlEmpty)
                FeederService.ReplenishFood();

            // more code to feed the animal
        }
    }

    public interface IFeederService
    {
        void ReplenishFood();
    }

    public class FeederService : IFeederService
    {
        public void ReplenishFood()
        {
            Feeder.ReplenishFood();
        }
    }

    public static class Feeder
    {
        public static void ReplenishFood()
        {
            // fill up bowl
        }
    }
}
