using System.Net.Http.Json;
using RecipesApp.Models;

namespace RecipesApp;

public partial class MainPage : ContentPage
{
    HttpClient client = new HttpClient();

    public MainPage()
    {
        InitializeComponent();
        LoadRecipes();
    }

    private async void LoadRecipes()
    {
        try
        {
            var data = await client.GetFromJsonAsync<RecipeResponse>("https://dummyjson.com/recipes");
            RecipesList.ItemsSource = data.Recipes;

            RecipesList.SelectionChanged += RecipesList_SelectionChanged;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Hiba", ex.Message, "OK");
        }
    }

    private async void RecipesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as Recipe;

        if (item != null)
        {
            await Navigation.PushAsync(new RecipeDetailPage(item));
        }
    }
}
