namespace Proyecto_Programacion2.View;

public partial class TodoItemPage : ContentPage
{
	public TodoItemPage()
	{
		InitializeComponent();
	}
    async void OnSaveClicked(Object sender, EventArgs e)
    {
        var todoItem = (TodoItem)BindingContext;
        TodoItemDatabase database = await TodoItemDatabase.Instance;
        await database.SaveItemAsync(todoItem);
        await Navigation.PopAsync();

    }

    async void OnDeleteClicked(Object sender, EventArgs e)
    {
        var todoItem = (TodoItem)BindingContext;
        TodoItemDatabase database = await TodoItemDatabase.Instance;
        await database.DeleteItemAsync(todoItem);
        await Navigation.PopAsync();

    }

    async void OnCancelClicked(Object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
