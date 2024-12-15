namespace TodoApp.Models
{
    public class TodoItem
    {
        public long id { get; set; }
        public string title { get; set; }

        public bool isCompleted {  get; set; }
    }
}
