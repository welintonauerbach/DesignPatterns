﻿using DesignPatterns.BuilderDesign.Builders.Base;
using DesignPatterns.BuilderDesign.Domain;
using DesignPatterns.BuilderDesign.Domain.ValueObject;
using DesignPatterns.BuilderDesign.Processors;

namespace DesignPatterns.BuilderDesign.Builders
{
    public sealed class PizzaModaCasa : PizzaBuilderBase, IPizzaBuilder
    {
        public PizzaModaCasa(ICalculaValor calculaValor) : base(calculaValor)
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
            this.Pizza.Sabor = "Moda da Casa";
            this.Pizza.IngredientesType =
                IngredientesType.Alho |
                IngredientesType.Calabresa |
                IngredientesType.Cebola |
                IngredientesType.Mussarela |
                IngredientesType.Provolone |
                IngredientesType.Pimentao |
                IngredientesType.Majericao |
                IngredientesType.Cheddar |
                IngredientesType.Catupiry;
        }

        public void TempoForno()
        {
            this.Pizza.TempoFornoMin = 28;
        }
    }
}