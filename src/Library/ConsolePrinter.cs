using System.Collections;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void ConsolePrint(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Valor de pasos: {recipe.QuantityTotal}\nValor del equipamiento: {recipe.HourlyCostTotal}\nTotal: {recipe.Total}");
        }
    }
}