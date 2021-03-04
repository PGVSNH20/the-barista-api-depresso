using System;
using System.Collections.Generic;
using System.Threading;

namespace BaristaApi
{
    public class CoffeeMachine
    {
        private int _water, _extraWater;
        private int _milk;
        private int _foamedMilk;
        private int _ChocolateSyrup;
        private int _alcohol;
        private readonly List<Bean> Bean = new List<Bean>();
        private bool isGrinded;
        private int perfectTemperature;



        public enum CoffeeType
        {
            Cappuccino,
            Americano,
            Espresso,
            Macchiato,
            Mocha,
            Latte,
            felixSpeziale
        }

        public CoffeeMachine AddWater(int amount, int perfectTemperature = 35)
        {
            _water += amount;
            this.perfectTemperature = perfectTemperature;
            HeatWater();
            return this;
        }

        public CoffeeMachine AddWater(int amount, bool extraWater)
        {
            if (extraWater)
            {
                _extraWater += amount;
            }
            return this;
        }

        public CoffeeMachine AddMilk(int amount)
        {
            _milk += amount;
            return this;
        }

        public CoffeeMachine AddAlcohol(int amount)
        {
            _alcohol += amount;
            return this;
        }

        public CoffeeMachine AddFoamMilk(int amount)
        {
            _foamedMilk += amount;
            return this;
        }

        public CoffeeMachine AddChocolateSyrup(int amount)
        {
            _ChocolateSyrup += amount;
            return this;
        }

        public CoffeeMachine AddBeans(Bean bean)
        {
            Bean.Add(bean);
            return this;
        }

        public CoffeeMachine GrindBeans()
        {
            if (Bean.Count < 0)
            {
                throw new Exception("No beans were found");
            }

            isGrinded = true;
            return this;
        }

        public void HeatWater()
        {
            Random rand = new();
            int temperature = rand.Next(10, 40);
            while (temperature < perfectTemperature)
            {
                temperature += rand.Next(4, 10);
                if (temperature > perfectTemperature)
                {
                    temperature = perfectTemperature;
                }
               
                Console.WriteLine($"Water temperature is: {temperature}c");
            }


            }

            public IBeverage ToBeverage()
        {
            if (Bean.Count <= 0 || _water <= 0)
            {
                throw new Exception("Key elements not found in beverage");
            }

            if (!isGrinded)
            {
                throw new Exception("Beans have not been grinded");
            }

            if (_foamedMilk > 0)
            {
                if (_milk > 0)
                {
                    return new Cappuccino();
                }

                else
                {
                    return new Macchiato();
                }
            }

            if (_ChocolateSyrup > 0)
            {
                return new Mocha();
            }

            if (_extraWater > 0)
            {
                return new Americano();
            }

            if (_alcohol > 0 && _milk > 0)
            {
                return new FelixSpeziale();
            }

            if (_milk > 0)
            {
                return new Latte();
            }
            else
            {
                return new Espresso();
            }
        }
    }
}