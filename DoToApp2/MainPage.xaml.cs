using DoToApp2.Models;
using System.Collections.ObjectModel;

namespace DoToApp2
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ToDoTask> TasksList => ToDoTaskManager.Tasks;

        public MainPage()
        {
            InitializeComponent();

            ToDoTaskManager.AddTestData();

            ToDoTaskManager.LoadTasks();

            BindingContext = this;
        }

        private void Done_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            ToDoTaskManager.SaveTasks();
        }

        private void DeleteBtn_Clicked(object sender, EventArgs e)
        {
            if(sender is Button kosz && kosz.BindingContext is ToDoTask naszTask && TasksList.Contains(naszTask))
            {
                TasksList.Remove(naszTask);
                ToDoTaskManager.SaveTasks();
            }
        }
    }

}
