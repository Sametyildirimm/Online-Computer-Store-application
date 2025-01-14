using MauiApp1.Models;

namespace MauiApp1;

public partial class PaymentPage : ContentPage
{
	public PaymentPage()
	{
		InitializeComponent();
		lbTotal.Text = TotalInfo.Price.ToString();
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();
    }
}