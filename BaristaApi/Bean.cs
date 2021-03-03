namespace BaristaApi
{
    public class Bean
    {
        public double weightInGrams;
        public BeanTypes beanType;
        public enum BeanTypes
        {
            Arabica,
            Robusta,
            Liberica,
            Excelsa
        }

        public Bean(double weightInGrams, BeanTypes beanType)
        {
            this.weightInGrams = weightInGrams;
            this.beanType = beanType;
        }
    }
}