  namespace Snacks
  {
    static class Hunger
    {
        public static int hungry(int hungervalue)
        {
            switch (hungervalue) //je hungriger desto mehr essen
            {
                case 0:
                    return 2;
                case 1:
                    return 1;
                case 2:
                    return 0;
                default:
                    return -1;
            }

        }
        public static int weight(int weightvalue)
        {
            switch (weightvalue) //um so schwerer desto weniger || Index ist falsch rum .... 
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                case 2:
                    return 2;
                default:
                    return -1;
            }

        }
    }
  }
