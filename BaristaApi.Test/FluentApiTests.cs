using Xunit;


namespace BaristaApi.Tests
{
    public class FluentApiTests
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso()
        {
            //Pseudo code

            // Act
            var beverage = new CoffeeMachine().AddWater(50, 90).AddBeans(new Bean(10, Bean.BeanTypes.Robusta)).GrindBeans().ToBeverage();
            // Assert
            Assert.IsType<Espresso>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeans_Expect_Cappuccino()
        {
            //Pseudo code

            // Act
            var beverage = new CoffeeMachine().AddWater(50, 85).AddBeans(new Bean(5, Bean.BeanTypes.Arabica)).GrindBeans().AddMilk(25).AddFoamMilk(10).ToBeverage();
            // Assert
            Assert.IsType<Cappuccino>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeans_Expect_Americano()
        {
            //Pseudo code

            // Act
            var beverage = new CoffeeMachine().AddWater(50, 85).AddBeans(new Bean(5, Bean.BeanTypes.Arabica)).GrindBeans().ToBeverage();
            // Assert
            Assert.IsType<Americano>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeans_Expect_Macchiato()
        {
            //Pseudo code

            // Act
            var beverage = new CoffeeMachine().AddWater(50, 90).AddBeans(new Bean(3, Bean.BeanTypes.Robusta)).GrindBeans().AddFoamMilk(30).ToBeverage();
            // Assert
            Assert.IsType<Macchiato>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeans_Expect_Mocha()
        {
            //Pseudo code

            // Act
            var beverage = new CoffeeMachine().AddWater(30, 90).AddBeans(new Bean(3, Bean.BeanTypes.Excelsa)).GrindBeans().AddChocolateSyrup(10).AddMilk(30).ToBeverage();
            // Assert
            Assert.IsType<Mocha>(beverage);
        }

        [Fact]
        public void When_AddingWaterAndBeans_Expect_FelixSpeziale()
        {
            //Pseudo code

            // Act
            var beverage = new CoffeeMachine().AddWater(30, 85).AddBeans(new Bean(5, Bean.BeanTypes.Arabica)).GrindBeans().AddAlcohol(50).AddMilk(20).ToBeverage();
            // Assert
            Assert.IsType<FelixSpeziale>(beverage);
        }
    }
}