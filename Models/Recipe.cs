namespace RecipesApp.Models;

public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Cuisine { get; set; }
    public string Difficulty { get; set; }
    public int PrepTimeMinutes { get; set; }
    public string Instructions { get; set; }
    public string Image { get; set; }
}

public class RecipeResponse
{
    public List<Recipe> Recipes { get; set; }
}
