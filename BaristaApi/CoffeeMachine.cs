using BaristaApi;
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
        private List<Bean> _beans = new List<Bean>();
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
            _beans.Add(bean);
            return this;
        }

        public CoffeeMachine GrindBeans()
        {
            if (_beans.Count < 0)
            {
                throw new Exception("No beans were found");
            }

            isGrinded = true;
            return this;
        }

        public void HeatWater()
        {
            Random rand = new Random();
            int temperature = rand.Next(10, 40); // Luke-warm water
            while (temperature < perfectTemperature)
            {
                temperature += rand.Next(4, 10);
                if (temperature > perfectTemperature)
                {
                    temperature = perfectTemperature;
                }
                Thread.Sleep(1000);
                Console.WriteLine($"Water temperature is: {temperature}c");
            }
        }

        public string ToBeverage()
        {
            if (_beans.Count <= 0 || _water <= 0)
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
                    return CoffeeType.Cappuccino.ToString();
                }
                else
                {
                    return CoffeeType.Macchiato.ToString();
                }
            }

            if (_ChocolateSyrup > 0)
            {
                return CoffeeType.Mocha.ToString();
            }

            if (_extraWater > 0)
            {
                return CoffeeType.Americano.ToString();
            }

            if (_alcohol > 0 && _milk > 0)
            {
                return CoffeeType.felixSpeziale.ToString();
            }

            if (_milk > 0)
            {
                return CoffeeType.Latte.ToString();
            }
            else
            {
                return CoffeeType.Espresso.ToString();
            }
        }
    }
}