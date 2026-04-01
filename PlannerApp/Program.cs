
class Item
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Category { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
    public int Priority { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        List<Item> items = new List<Item>();
        items.Add(new Item { Id = 1, Title = "Buy groceries", Category = "Personal", DueDate = DateTime.Now.AddDays(1), IsCompleted = false, Priority = 2 });
        items.Add(new Item { Id = 2, Title = "Finish project report", Category = "Work", DueDate = DateTime.Now.AddDays(3), IsCompleted = false, Priority = 1 });
        items.Add(new Item { Id = 3, Title = "Call plumber", Category = "Home", DueDate = DateTime.Now.AddDays(2), IsCompleted = false, Priority = 3 });
        Console.WriteLine("To-Do List:");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Id}. {item.Title} - {item.Category} - Due: {item.DueDate.ToShortDateString()} - Completed: {item.IsCompleted} - Priority: {item.Priority}");
        }
       
        var sortedbyDueDate = sortbyDueDate(items);
        var incompleteItems = showIncomplete(items);
    }
    static List<Item> sortbyDueDate(List<Item> items)
    {
        return items.OrderBy(i => i.DueDate).ToList();
    }
    static List<Item> showIncomplete(List<Item> items)
    {
        return items.Where(i => !i.IsCompleted).ToList();
    }
    static List<Item> filterByCategory(List<Item> items, string category)
    {
        return items.Where(i => i.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}