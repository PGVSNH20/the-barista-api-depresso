using Xunit;


namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_FelixSpeziale(){
            //Pseudo code
            
            // Act
            var beverage = new CoffeeMachine().AddWater(30,85).AddBeans(new Bean(5, Bean.BeanTypes.Arabica)).GrindBeans().AddAlcohol(50).AddMilk(20).ToBeverage();
            // Assert
            Assert.IsType<FelixSpeziale>(beverage);
            
        }
    }
}

//CoffeeMachine felixSpeziale = new CoffeeMachine()
//  .AddWater(30, 85)
//  .AddBeans(new Bean(5, Bean.BeanTypes.Arabica))
//  .GrindBeans()
//  .AddAlcohol(50);