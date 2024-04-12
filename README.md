# ST10239864
Programming POE
Recipe Application
This is a simple console-based recipe application written in C#. The application allows users to create and manage recipes, including adding ingredients and steps, scaling recipes, and resetting quantities.

Features
Add ingredients and steps to a recipe
Display the recipe with original quantities or scaled quantities
Scale the recipe by a given factor
Reset quantities to original values
Clear all data
Classes
Recipe: Represents a recipe with ingredients and steps. Provides methods to add ingredients and steps, display the recipe, scale the recipe, reset quantities, and clear all data.
Ingredient: Represents an ingredient with a name, quantity, and unit.
Step: Represents a step in the recipe with a description.
Usage
To use the application, run the Program.cs file. The application will display a menu with the following options:

Enter Ingredients
Display Recipe
Scale Recipe
Reset Quantity
Clear All Data
Exit
Select an option by entering the corresponding number. Follow the prompts to enter ingredients, steps, and scale factors.

Example
Here is an example of how to use the application:

Enter Ingredients
Display Recipe
Scale Recipe
Reset Quantity
Clear All Data
Exit
Enter your choice: 1

Enter the number of ingredients: 3

Enter ingredient 1:

Name: Flour

Quantity: 2

Unit: cups

Enter ingredient 2:

Name: Sugar

Quantity: 1

Unit: cup

Enter ingredient 3:

Name: Butter

Quantity: 1

Unit: stick

Enter the number of steps: 2

Enter step 1: Mix ingredients together

Enter step 2: Bake at 350 degrees for 30 minutes

Enter your choice: 2

Recipe:

Ingredients:

2 cups Flour

1 cup Sugar

1 stick Butter

Steps:

Mix ingredients together

Bake at 350 degrees for 30 minutes

Enter your choice: 3

Enter scale factor (0.5, 2, or 3): 2

Recipe:

Ingredients:

4 cups Flour

2 cups Sugar

2 sticks Butter

Steps:

Mix ingredients together

Bake at 350 degrees for 30 minutes

Enter your choice: 4

Recipe:

Ingredients:

2 cups Flour

1 cup Sugar

1 stick Butter

Steps:

Mix ingredients together

Bake at 350 degrees for 30 minutes

Enter your choice: 5

All data cleared.

Enter your choice: 6

Exiting...

License
This project is licensed under the MIT License.
