using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MU2.RefactorCode.BreakDependencies
{
    public class AnimalFeedingServiceBefore
    {
        private bool FoodBowlEmpty { get; set; }

        public void Feed()
        {
            if (FoodBowlEmpty)
                FeederBefore.ReplenishFood();

            // more code to feed the animal
        }
    }

    public static class FeederBefore
    {
        public static void ReplenishFood()
        {
            // fill up bowl
        }
    }
}
