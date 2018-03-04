using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;

namespace XToDoList
{
    public class ToDoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Copleted { get; set; }

        public override string ToString()
        {
            return Title + " : " +
                   Description + " [ " +
                   CreationDate.ToShortDateString() + " ] " +
                   Copleted.ToString();
        }
    }

    public class ToDoItemsList
    {
        public ToDoItemsList()
        {
            toDoItems_.Add(new ToDoItem
            {
                Title = "Test1",
                Description = "Test1Description",
                CreationDate = DateTime.Now,
                Copleted = false
            });
            toDoItems_.Add(new ToDoItem
            {
                Title = "Test2",
                Description = "Test2Description",
                CreationDate = DateTime.Now,
                Copleted = true
            });
        }
        private ToDoItem selecteItem_ = null;
        public ToDoItem SelectedToDoItem { get { return selecteItem_; } set { selecteItem_ = value; } }
        private IList<ToDoItem> toDoItems_ = new ObservableCollection<ToDoItem>();
        public IEnumerable<ToDoItem> ToDoItems { get { return toDoItems_; } }
    }
}
