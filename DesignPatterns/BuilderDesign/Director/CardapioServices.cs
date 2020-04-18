using DesignPatterns.BuilderDesign.Builders.Base;
using DesignPatterns.BuilderDesign.Domain;
using DesignPatterns.BuilderDesign.Domain.ValueObject;

namespace DesignPatterns.BuilderDesign.Director
{
    public class CardapioServices
    {
        public void PrepararPizzaSemBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize)
        {
            pizzaBuilder.PreparaMassa(pizzaSize);
            pizzaBuilder.InsereIngradientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }

        public void PrepararPizzaComBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize, Borda borda)
        {
            pizzaBuilder.PreparaMassa(pizzaSize);
            pizzaBuilder.PrepraraBorda(borda);
            pizzaBuilder.InsereIngradientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }
    }
}