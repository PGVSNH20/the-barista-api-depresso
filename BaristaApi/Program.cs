using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CoffeeMachine brew = new CoffeeMachine().AddWater(25, 85).AddMilk(20).AddAlcohol(50).AddBeans(new Bean(4, Bean.BeanTypes.Arabica)).GrindBeans().AddWater(15, false);

                Console.WriteLine("\nBrew is done!");
                Console.WriteLine("\nEnjoy your " + brew.ToBeverage() + " :)");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);


            }

            Console.ReadKey();
        }
    }
}



//IBeverage cappuccino = new CoffeeMachine()
//                    .AddWater(50, 85)
//                    .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
//                    .GrindBeans()
//                    .AddMilk(25)
//                    .AddFoamMilk(10);

//IBeverage americano = new CoffeeMachine()
//    .AddWater(50, 85)
//    .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
//    .GrindBeans()

//                 IBeverage espresso = new CoffeeMachine()
//                    .AddWater(50, 90)
//                    .AddBeans(new Bean(10, Bean.BeanTypes.Arabica.Robusta))
//                    .GrindBeans()


//                IBeverage macchiato = new CoffeeMachine()
//                    .AddWater(30, 90)
//                    .AddBeans(new Bean(3, Bean.BeanTypes.Robusta))
//                    .GrindBeans()
//                    .AddFoamMilk(30);

//IBeverage mocha = new CoffeeMachine()
//    .AddWater(30, 90)
//    .AddBeans(new Bean(3, Bean.BeanTypes.Excelsa))
//    .GrindBeans()
//    .AddChocolateSyrup(10)
//    .AddMilk(30);

//IBeverage cappuccino = new CoffeeMachine()
//   .AddWater(30, 85)
//   .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
//   .GrindBeans()
//   .AddMilk(50)

//                  IBeverage felixSpeziale = new CoffeeMachine()
//                    .AddWater(30, 85)
//                    .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
//                    .GrindBeans()
//                    .AddAlcohol(50)
//                    .AddCream(50)
