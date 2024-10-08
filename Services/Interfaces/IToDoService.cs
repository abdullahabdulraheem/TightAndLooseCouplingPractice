using TightAndLooseCoupling.Models;

namespace TightAndLooseCoupling.Services.Interfaces;

public interface IToDoService
{
    public Task<IEnumerable<ToDo>> GetAllAsync();
}