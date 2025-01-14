using MauiApp1.Models;

namespace MauiApp1;

public partial class ShopPage : ContentPage
{
	public ShopPage()
	{
		InitializeComponent();
        lbTotal.Text = TotalInfo.Price.ToString();
        Usr_List_View.ItemsSource = App.DBTrans.GetAllUsers();
        MemBtnMin.IsEnabled = false;
        StrBtnMin.IsEnabled = false;
        MonBtnMin.IsEnabled = false;
    }

    private void MemBtnMin_Clicked(object sender, EventArgs e)
    {
        int meminus;
        int.TryParse(lbMem.Text, out meminus);
        if (meminus == 4)
        {
            meminus = 0;
            lbMem.Text = "0";
            TotalInfo.Price -= 150;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (meminus == 8)
        {
            meminus = 4;
            lbMem.Text = "4";
            TotalInfo.Price -= 150;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (meminus == 12)
        {
            meminus = 8;
            lbMem .Text = "8";
            TotalInfo.Price -= 150;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (meminus == 16)
        {
            meminus = 12;
            lbMem.Text = "12";
            MemBtnMax.IsEnabled = true;
            TotalInfo.Price -= 150;
            lbTotal.Text = TotalInfo.Price.ToString();
        }

    }

    private void MemBtnMax_Clicked(object sender, EventArgs e)
    {
        int memplus;
        int.TryParse(lbMem.Text, out memplus);

        if (memplus == 0)
        {
            memplus = 4;
            lbMem.Text = "4";
            MemBtnMin.IsEnabled = true;
            TotalInfo.Price += 150;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (memplus == 4)
        {
            memplus = 8;
            lbMem.Text = "8";
            TotalInfo.Price += 150;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (memplus == 8)
        {
            memplus = 12;
            lbMem.Text = "12";
            TotalInfo.Price += 150;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (memplus == 12)
        {
            memplus = 16;
            lbMem.Text = "16";
            MemBtnMax.IsEnabled = false;
            TotalInfo.Price += 150;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
    }

    private void StrBtnMin_Clicked(object sender, EventArgs e)
    {
        int strmin;
        int.TryParse(lbStr.Text, out strmin);

        if (strmin == 500)
        {
            strmin = 0;
            lbStr.Text = "0";
            StrBtnMin.IsEnabled = false;

            if (TotalInfo.StType==1)
            {
                TotalInfo.Price -= 500;
                lbTotal.Text = TotalInfo.Price.ToString();
            }
            else if (TotalInfo.StType == 2)
            {
                TotalInfo.Price -= 300;
                lbTotal.Text = TotalInfo.Price.ToString();
            }
        }
        else if (strmin == 1000)
        {
            strmin = 500;
            lbStr.Text = "500";
            StrBtnMax.IsEnabled = true;
            if (TotalInfo.StType == 1)
            {
                TotalInfo.Price -= 500;
                lbTotal.Text = TotalInfo.Price.ToString();
            }
            else if (TotalInfo.StType == 2)
            {
                TotalInfo.Price -= 300;
                lbTotal.Text = TotalInfo.Price.ToString();
            }
        }
    }

    private void StrBtnMax_Clicked(object sender, EventArgs e)
    {
        int strmax;
        int.TryParse(lbStr.Text, out strmax);

        if (strmax == 0)
        {
            strmax = 500;
            lbStr.Text = "500";
            StrBtnMin.IsEnabled = true;
            if (TotalInfo.StType == 1)
            {
                TotalInfo.Price += 500;
                lbTotal.Text = TotalInfo.Price.ToString();
            }
            else if (TotalInfo.StType == 2)
            {
                TotalInfo.Price += 300;
                lbTotal.Text = TotalInfo.Price.ToString();
            }
        }
        else if (strmax == 500)
        {
            strmax = 1000;
            lbStr.Text = "1000";
            StrBtnMax.IsEnabled = false;
            if (TotalInfo.StType == 1)
            {
                TotalInfo.Price += 500;
                lbTotal.Text = TotalInfo.Price.ToString();
            }
            else if (TotalInfo.StType == 2)
            {
                TotalInfo.Price += 300;
                lbTotal.Text = TotalInfo.Price.ToString();
            }
        }
    }

    private void MonBtnMin_Clicked(object sender, EventArgs e)
    {
        int monmin;
        int.TryParse (lbMon.Text, out monmin);
        if (monmin == 17)
        {
            monmin = 0;
            lbMon.Text = "0";
            MonBtnMin.IsEnabled = false;
            TotalInfo.Price -= 450;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (monmin == 20)
        {
            monmin = 17;
            lbMon.Text = "17";
            TotalInfo.Price -= 450;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (monmin == 23)
        {
            monmin = 20;
            lbMon.Text = "20";
            TotalInfo.Price -= 450;
            MonBtnMax.IsEnabled = true;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
    }

    private void MonBtnMax_Clicked(object sender, EventArgs e)
    {
        int monmax;
        int.TryParse(lbMon.Text, out monmax);
        if (monmax == 0)
        {
            monmax = 17;
            lbMon.Text = "17";
            MonBtnMin.IsEnabled = true;
            TotalInfo.Price += 450;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (monmax == 17)
        {
            monmax = 20;
            lbMon.Text = "20";
            TotalInfo.Price += 450;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
        else if (monmax == 20)
        {
            monmax = 23;
            lbMon.Text = "23";
            TotalInfo.Price += 450;
            MonBtnMax.IsEnabled = false;
            lbTotal.Text = TotalInfo.Price.ToString();
        }
    }
}