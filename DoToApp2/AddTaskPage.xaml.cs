using DoToApp2.Models;

namespace DoToApp2;

public partial class AddTaskPage : ContentPage
{
	public AddTaskPage()
	{
		InitializeComponent();
	}

    private async void SaveBtn_Clicked(object sender, EventArgs e)
    {
		ToDoTaskManager.AddNewTask(TaskName.Text, TaskDesc.Text);

		await DisplayAlert("Sukces", "Zadanie dodano!", "OK");
    }
}