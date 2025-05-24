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

            BindingContext = this;
        }

    }

}
