using System.Text.Json.Serialization;
using Newtonsoft.Json;
using TightAndLooseCoupling.Models;
using TightAndLooseCoupling.Services.Interfaces;

namespace TightAndLooseCoupling.Services;

public class ToDoService : IToDoService
{
    public async Task<IEnumerable<ToDo>> GetAllAsync()
    {
        using (HttpClient http = new())
        {
            var json = await http.GetStringAsync(url);
            
            return JsonConvert.DeserializeObject<IEnumerable<ToDo>>(json);
        }

        
    }

    private readonly string url = "https://jsonplaceholder.typicode.com/todos";
}

public class TestToDoService : IToDoService
{
    public async Task<IEnumerable<ToDo>> GetAllAsync()
    {
        List<ToDo> toDo =
        [
            new ToDo() {ID = 1, Title = "Washing", Completed = false},
            new ToDo() {ID = 2, Title = "Cooking", Completed = true},
            new ToDo() {ID = 3, Title = "Bathing", Completed = false}
        ];

        return toDo;
    }
}