﻿using DesignPatterns.BuilderDesign.Domain.ValueObject;

namespace DesignPatterns.BuilderDesign.Domain
{
    public class Pizza
    {
        public string Sabor { get; set; }
        public Borda Borda { get; set; }
        public double Valor { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public PizzaType PizzaType { get; set; }
        public IngredientesType IngredientesType { get; set; }
        public int TempoFornoMin { get; set; }
    }
}