using System.Text.Json;
using AOIEquipmentControlSystem.Models;

namespace AOIEquipmentControlSystem.Services
{
    public class RecipeService
    {
        private readonly string _recipeFilePath;

        public RecipeService()
        {
            _recipeFilePath = GetDefaultRecipeFilePath();
        }

        public bool TryLoadRecipe(out Recipe recipe, out string message)
        {
            recipe = new Recipe();

            if (!File.Exists(_recipeFilePath))
            {
                message = $"Recipe file not found: {_recipeFilePath}";
                return false;
            }

            try
            {
                string jsonText = File.ReadAllText(_recipeFilePath);

                JsonSerializerOptions options = new()
                {
                    PropertyNameCaseInsensitive = true
                };

                Recipe? loadedRecipe = JsonSerializer.Deserialize<Recipe>(jsonText, options);

                if (loadedRecipe == null)
                {
                    message = "Recipe file is empty or invalid.";
                    return false;
                }

                recipe = loadedRecipe;
                message = "Recipe loaded successfully.";
                return true;
            }
            catch (JsonException ex)
            {
                message = $"Recipe JSON format error: {ex.Message}";
                return false;
            }
            catch (IOException ex)
            {
                message = $"Recipe file read error: {ex.Message}";
                return false;
            }
            catch (UnauthorizedAccessException ex)
            {
                message = $"Recipe file access error: {ex.Message}";
                return false;
            }
        }

        public bool TrySaveRecipe(Recipe recipe, out string message)
        {
            string? recipeFolderPath = Path.GetDirectoryName(_recipeFilePath);

            if (string.IsNullOrWhiteSpace(recipeFolderPath) || !Directory.Exists(recipeFolderPath))
            {
                message = $"Recipe folder not found: {recipeFolderPath}";
                return false;
            }

            if (!File.Exists(_recipeFilePath))
            {
                message = $"Recipe file path does not exist: {_recipeFilePath}";
                return false;
            }

            try
            {
                JsonSerializerOptions options = new()
                {
                    WriteIndented = true
                };

                string jsonText = JsonSerializer.Serialize(recipe, options);
                File.WriteAllText(_recipeFilePath, jsonText + Environment.NewLine);

                message = "Recipe saved successfully.";
                return true;
            }
            catch (JsonException ex)
            {
                message = $"Recipe JSON serialization error: {ex.Message}";
                return false;
            }
            catch (NotSupportedException ex)
            {
                message = $"Recipe JSON serialization error: {ex.Message}";
                return false;
            }
            catch (IOException ex)
            {
                message = $"Recipe file write error: {ex.Message}";
                return false;
            }
            catch (UnauthorizedAccessException ex)
            {
                message = $"Recipe file write permission error: {ex.Message}";
                return false;
            }
        }

        private static string GetDefaultRecipeFilePath()
        {
            DirectoryInfo? currentDirectory = new(AppDomain.CurrentDomain.BaseDirectory);

            while (currentDirectory != null)
            {
                string projectFilePath = Path.Combine(currentDirectory.FullName, "AOIEquipmentControlSystem.csproj");
                string projectRecipePath = Path.Combine(currentDirectory.FullName, "Config", "recipe.json");

                if (File.Exists(projectFilePath) && File.Exists(projectRecipePath))
                {
                    return projectRecipePath;
                }

                currentDirectory = currentDirectory.Parent;
            }

            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "recipe.json");
        }
    }
}
