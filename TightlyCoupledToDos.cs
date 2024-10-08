using TightAndLooseCoupling.Models;
using TightAndLooseCoupling.Services;
using TightAndLooseCoupling.Services.Interfaces;

// namespace TightAndLooseCoupling;

// public class TightlyCoupledToDos
// {
//     public TightlyCoupledToDos()
//     {
//         service = new ToDoService();
//     }

//     public async Task<IEnumerable<ToDo>> All()
//     {
//         IEnumerable<ToDo> todo = await service.GetAllAsync();

//         return todo.ToList<ToDo>();
//     }

//     private readonly ToDoService service;
// }

public class LooselyCoupledToDos
{
    public LooselyCoupledToDos(IToDoService _toDo)
    {
        this._toDo = _toDo;
    }

    public async Task<IEnumerable<ToDo>> All()
    {
        IEnumerable<ToDo> toDos = await _toDo.GetAllAsync();
        return toDos.ToList<ToDo>();
    }

    private readonly IToDoService _toDo;
}