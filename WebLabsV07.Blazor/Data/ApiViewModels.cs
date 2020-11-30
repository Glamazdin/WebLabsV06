using System.Text.Json.Serialization;

namespace WebLabsV07.Blazor.Data
{
    public class DishListViewModel
    {
        [JsonPropertyName("dishId")]
        public int DishId { get; set; } // id блюда
        [JsonPropertyName("dishName")]
        public string DishName { get; set; } // название блюда

    }

    public class DishDetailsViewModel
    {
        [JsonPropertyName("dishName")]
        public string DishName { get; set; } // название блюда
        [JsonPropertyName("description")]
        public string Description { get; set; } // описание блюда
        [JsonPropertyName("calories")]
        public int Calories { get; set; } // кол. калорий на порцию
        [JsonPropertyName("image")]
        public string Image { get; set; } // имя файла изображения   
    }
}
