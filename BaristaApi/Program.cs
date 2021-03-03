using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IBeverage cappuccino = new CoffeeMachine()
                    .AddWater(50, 85)
                    .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                    .GrindBeans()
                    .AddMilk(25)
                    .AddFoamMilk(10);

                IBeverage americano = new CoffeeMachine()
                    .AddWater(50, 85)
                    .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                    .GrindBeans()

                 IBeverage espresso = new CoffeeMachine()
                    .AddWater(50, 90)
                    .AddBeans(new Bean(10, Bean.BeanTypes.Arabica.Robusta))
                    .GrindBeans()
                   
                IBeverage macchiato = new CoffeeMachine()
                    .AddWater(30, 90)
                    .AddBeans(new Bean(3, Bean.BeanTypes.Robusta))
                    .GrindBeans()
                    .AddFoamMilk(30);
              
                IBeverage mocha = new CoffeeMachine()
                    .AddWater(30, 90)
                    .AddBeans(new Bean(3, Bean.BeanTypes.Excelsa))
                    .GrindBeans()
                    .AddChocolateSyrup(10)
                    .AddMilk(30);

                 IBeverage cappuccino = new CoffeeMachine()
                    .AddWater(30, 85)
                    .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                    .GrindBeans()
                    .AddMilk(50)

                  IBeverage felixSpeziale = new CoffeeMachine()
                    .AddWater(30, 85)
                    .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                    .GrindBeans()
                    .AddAlcohol(50)
                    .AddCream(50)

                Console.WriteLine("You have made a: " + cappuccino.ToBeverage());
                Console.WriteLine("You have made a: " + mocha.ToBeverage());
                Console.WriteLine("You have made a: " + felixSpeziale.ToBeverage());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

[TestClass]
    public class CoffeeTests
    {
        FluentEspresso beverage;

        [TestMethod]
        public void CappuccinoTest()
        {
            beverage = new FluentEspresso().AddWater(50, 80).AddBeans(new Bean(5, Bean.BeanTypes.Arabica)).GrindBeans().AddMilk(15).AddFoamMilk(10);
            Assert.AreEqual("Cappuccino", beverage.ToBeverage());
        }
    }
}