using TightAndLooseCoupling.Models;
using TightAndLooseCoupling.Services;
using TightAndLooseCoupling.Services.Interfaces;

namespace TightAndLooseCoupling;

class Program
{

    static void Main(string[] args)
    {
        try
        {
            if(_testMode)
            {
                Console.WriteLine("TestData:");
                CallerToDo(new TestToDoService());
            }
            else
            {
                Console.WriteLine("RealData:");
                CallerToDo(new ToDoService());
            }
        }
        catch(Exception inCaseItIsNull)
        {
            Console.WriteLine($"An exception occured: {inCaseItIsNull.Message}");
        }

        Console.ReadLine();
    }
    static async void CallerToDo(IToDoService service)
    {
        LooselyCoupledToDos caller = new(service);
        IEnumerable<ToDo> callerToDo = await caller.All();
        foreach (ToDo item in callerToDo)
        {
            Console.WriteLine(item);
        }
    }

    private static bool _testMode = false;
}
