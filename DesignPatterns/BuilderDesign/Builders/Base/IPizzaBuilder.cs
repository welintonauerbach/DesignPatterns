using DesignPatterns.BuilderDesign.Domain;
using DesignPatterns.BuilderDesign.Domain.ValueObject;

namespace DesignPatterns.BuilderDesign.Builders.Base
{
    public interface IPizzaBuilder
    {
        void PrepraraBorda(Borda borda);

        void PreparaMassa(PizzaSize pizzaSize);

        void InsereIngradientes();

        void DefineValor();

        void TempoForno();

        Pizza GetPizza();
    }
}