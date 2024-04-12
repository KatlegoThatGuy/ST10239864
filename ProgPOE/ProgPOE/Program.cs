using System;

namespace RecipeApplication
{
    class Recipe
    {
        // Properties
        public Ingredient[] Ingredients { get; private set; }
        public Step[] Steps { get; private set; }
        private double[] OriginalIngredientQuantities { get; set; }

        // Constructor
        public Recipe()
        {
            Ingredients = new Ingredient[0];
            Steps = new Step[0];
            OriginalIngredientQuantities = new double[0];
        }

        // Method to display the entire recipe
        public void DisplayRecipe()
        {
            DisplayRecipe(1);
        }

        // Method to display the recipe with a given scale factor
        public void DisplayRecipe(double scaleFactor)
        {
            Console.WriteLine("\nRecipe:");
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Ingredients[i].Quantity = OriginalIngredientQuantities[i] * scaleFactor;
                Console.WriteLine($"- {Ingredients[i].Quantity} {Ingredients[i].Unit} {Ingredients[i].Name}");
            }
            Console.WriteLine("Steps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }

        // Method to add ingredients
        public void AddIngredients(int numIngredients)
        {
            Ingredients = new Ingredient[numIngredients];
            OriginalIngredientQuantities = new double[numIngredients];
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter ingredient {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit: ");
                string unit = Console.ReadLine();

                Ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
                OriginalIngredientQuantities[i] = quantity;
            }
        }

        // Method to add steps
        public void AddSteps(int numSteps)
        {
            Steps = new Step[numSteps];
            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                Steps[i] = new Step { Description = Console.ReadLine() };
            }
        }

        // Method to reset quantities to original values and set scale factor to 1
        public void ResetQuantity()
        {
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Ingredients[i].Quantity = OriginalIngredientQuantities[i];
            }

            ScaleRecipe(1);
        }

        // Method to scale the recipe by a given factor
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }
    }

    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }

    class Step
    {
        public string Description { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Recipe Application!");
            Recipe recipe = new Recipe();

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. Enter Ingredients");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2. Display Recipe");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("3. Scale Recipe");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("4. Reset Quantity");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("5. Clear All Data");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("6. Exit");
                Console.ResetColor();
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                int num;
                if (int.TryParse(choice, out num))
                {
                    switch (num)
                    {
                        case 1:
                            Console.Write("Enter the number of ingredients: ");
                            if (int.TryParse(Console.ReadLine(), out int numIngredients))
                            {
                                recipe.AddIngredients(numIngredients);

                                Console.Write("Enter the number of steps: ");
                                if (int.TryParse(Console.ReadLine(), out int numSteps))
                                {
                                    recipe.AddSteps(numSteps);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a valid number of steps.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number of ingredients.");
                            }
                            break;
                        case 2:
                            recipe.DisplayRecipe(); // Display original recipe
                            break;
                        case 3:
                            Console.Write("Enter scale factor (0.5, 2, or 3): ");
                            if (double.TryParse(Console.ReadLine(), out double scaleFactor))
                            {
                                recipe.ScaleRecipe(scaleFactor);
                                recipe.DisplayRecipe(scaleFactor);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid scale factor.");
                            }
                            break;
                        case 4:
                            recipe.ResetQuantity();
                            recipe.DisplayRecipe(); // Reset quantities to original values
                            break;
                        case 5:
                            recipe = new Recipe(); // Clear all data
                            Console.WriteLine("All data cleared.");
                            break;
                        case 6:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                }
            }
        }
    }
}