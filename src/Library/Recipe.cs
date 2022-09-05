//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public double QuantityTotal {get; set;}
        public double HourlyCostTotal {get; set;}
        public double Total {get; set;}

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public ArrayList GetSteps()
        {
            return steps;
        }

        public void CalculateTotal()
        {
            this.QuantityTotal = 0;
            this.HourlyCostTotal = 0;
            this.Total = 0;

            foreach (Step step in this.steps)
            {
                double Time = step.Time;
                this.QuantityTotal += step.Input.UnitCost * (step.Quantity/1000);
                this.HourlyCostTotal += step.Equipment.HourlyCost * (Time/3600);
            }
            this.Total = this.QuantityTotal + this.HourlyCostTotal;
        }
    }
}