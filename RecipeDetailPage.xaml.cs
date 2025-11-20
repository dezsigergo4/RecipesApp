using RecipesApp.Models;
using System.Xml;

namespace RecipesApp;

public partial class RecipeDetailPage : ContentPage
{
    public RecipeDetailPage(Recipe r)
    {
        InitializeComponent();

        RecipeImage.Source = r.Image;
        NameLabel.Text = r.Name;
        CuisineLabel.Text = "Konyha: " + r.Cuisine;
        TimeLabel.Text = "Előkészítési idő: " + r.PrepTimeMinutes + " perc";
        InstructionsLabel.Text = "Utasítások:\n" + r.Instructions;
    }
}
