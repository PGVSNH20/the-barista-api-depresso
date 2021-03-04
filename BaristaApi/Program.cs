using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            try

            {
                IBeverage Espresso = new CoffeeMachine()
                .AddWater(50, 90)
                .AddBeans(new Bean(10, Bean.BeanTypes.Robusta))
                .GrindBeans()
                .ToBeverage();

                IBeverage Cappuccino = new CoffeeMachine()
                                             .AddWater(50, 85)
                                             .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                                             .GrindBeans()
                                             .AddMilk(25)
                                             .AddFoamMilk(10)
                                             .ToBeverage();

                IBeverage Americano = new CoffeeMachine()
                    .AddWater(50, 85)
                    .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                    .AddWater(20, true)
                    .GrindBeans()
                    .ToBeverage();

                IBeverage Macchiato = new CoffeeMachine()
                    .AddWater(30, 90)
                    .AddBeans(new Bean(3, Bean.BeanTypes.Robusta))
                    .GrindBeans()
                    .AddFoamMilk(30)
                    .ToBeverage();


                IBeverage Mocha = new CoffeeMachine()
                    .AddWater(30, 90)
                    .AddBeans(new Bean(3, Bean.BeanTypes.Excelsa))
                    .GrindBeans()
                    .AddChocolateSyrup(10)
                    .AddMilk(30)
                    .ToBeverage();

                IBeverage FelixSpeziale = new CoffeeMachine()
                 .AddWater(30, 85)
                 .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                 .GrindBeans()
                 .AddAlcohol(50)
                 .AddMilk(20)
                 .ToBeverage();

               ;

                Console.WriteLine("\nBrew is done!");
                Console.WriteLine("\nEnjoy your " + FelixSpeziale.ToString() + " :)");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Read();
        }
    }
}