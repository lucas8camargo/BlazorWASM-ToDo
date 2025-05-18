using BlazorToDoWASM.Models;

namespace BlazorToDoWASM.Services
{
    public class ToDoService
    {
        private List<ToDoItem> items = new();
        private int nextId = 1;

        public List<ToDoItem> GetAll() => items;

        public void Add(string title)
        {
            items.Add(new ToDoItem { Id = nextId++, Title = title, IsDone = false });
        }

        public void Update(ToDoItem item)
        {
            var existing = items.FirstOrDefault(x => x.Id == item.Id);
            if (existing != null)
            {
                existing.Title = item.Title;
                existing.IsDone = item.IsDone;
            }
        }

        public void Delete(int id)
        {
            var item = items.FirstOrDefault(x => x.Id == id);
            if (item != null)
                items.Remove(item);
        }
    }
}
