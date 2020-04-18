using DesignPatterns.BuilderDesign.Builders.Base;
using DesignPatterns.BuilderDesign.Domain;
using DesignPatterns.BuilderDesign.Domain.ValueObject;
using DesignPatterns.BuilderDesign.Processors;

namespace DesignPatterns.BuilderDesign.Builders
{
    public sealed class PizzaCalabresa : PizzaBuilderBase, IPizzaBuilder
    {
        public PizzaCalabresa(ICalculaValor calculaValor) : base(calculaValor)
        {
        }

        public void PrepraraBorda(Borda borda)
        {
            this.Pizza.Borda = borda;
        }

        public void PreparaMassa(PizzaSize pizzaSize)
        {
            this.Init();

            this.Pizza.PizzaType = PizzaType.Salgada;
            this.Pizza.PizzaSize = pizzaSize;
        }

        public void InsereIngradientes()
        {
            this.Pizza.Sabor = "Calabresa";
            this.Pizza.IngredientesType =
                IngredientesType.Calabresa |
                IngredientesType.Azeitona |
                IngredientesType.Cebola |
                IngredientesType.Cheddar |
                IngredientesType.Salame;
        }

        public void TempoForno()
        {
            this.Pizza.TempoFornoMin = 20;
        }
    }
}