using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            try


            {
                //CoffeeMachine espresso = new CoffeeMachine()
                //                                            .AddWater(50, 90)
                //                                            .AddBeans(new Bean(10, Bean.BeanTypes.Robusta))
                //                                            .GrindBeans();
                //CoffeeMachine cappuccino = new CoffeeMachine()
                //                            .AddWater(50, 85)
                //                            .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                //                            .GrindBeans()
                //                            .AddMilk(25)
                //                            .AddFoamMilk(10);

                //CoffeeMachine americano = new CoffeeMachine()
                //    .AddWater(50, 85)
                //    .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                //    .GrindBeans();




                //                        CoffeeMachine macchiato = new CoffeeMachine()
                //                            .AddWater(30, 90)
                //                            .AddBeans(new Bean(3, Bean.BeanTypes.Robusta))
                //                            .GrindBeans()
                //                            .AddFoamMilk(30);

                //CoffeeMachine mocha = new CoffeeMachine()
                //    .AddWater(30, 90)
                //    .AddBeans(new Bean(3, Bean.BeanTypes.Excelsa))
                //    .GrindBeans()
                //    .AddChocolateSyrup(10)
                //    .AddMilk(30);



                CoffeeMachine FelixSpeziale = new CoffeeMachine()
                  .AddWater(30, 85)
                  .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
                  .GrindBeans()
                  .AddAlcohol(50)
                  .AddMilk(20);



                //CoffeeMachine brew1 = new CoffeeMachine().AddWater(25, 85).AddMilk(20).AddAlcohol(50).AddBeans(new Bean(4, Bean.BeanTypes.Arabica)).GrindBeans();

                //CoffeeMachine brew2 = new CoffeeMachine().AddWater(25, 85).AddMilk(20).AddChocolateSyrup(10).AddBeans(new Bean(4, Bean.BeanTypes.Arabica)).GrindBeans();

                Console.WriteLine("\nBrew is done!");
                //Console.WriteLine("\nEnjoy your " + brew1.ToBeverage() + " :)");
                //Console.WriteLine("\nEnjoy your " + brew2.ToBeverage() + " :)");
                Console.WriteLine("\nEnjoy your " + FelixSpeziale.ToBeverage() + " :)");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);


            }

            Console.ReadKey();
        }
    }
}