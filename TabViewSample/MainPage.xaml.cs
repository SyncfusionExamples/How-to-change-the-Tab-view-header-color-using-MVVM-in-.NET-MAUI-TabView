using Syncfusion.Maui.TabView;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TabViewSample;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

}

public class Model
{
    public string Name { get; set; }
    public long Number { get; set; }
}
public class ViewModel
{

    public Color TabHeaderBackGround { get; set; }

    public ObservableCollection<Model> ContactList { get; set; }   

    public ViewModel()
    {
        TabHeaderBackGround = Colors.Aqua;

        ContactList = new ObservableCollection<Model>();
        ContactList.Add(new Model { Name = "Aaron", Number = 7363750 });
        ContactList.Add(new Model { Name = "Adam", Number = 7323250 });
        ContactList.Add(new Model { Name = "Adrian", Number = 7239121 });
        ContactList.Add(new Model { Name = "Alwin", Number = 2329823 });
        ContactList.Add(new Model { Name = "Alex", Number = 8013481 });
        ContactList.Add(new Model { Name = "Alexander", Number = 7872329 });
        ContactList.Add(new Model { Name = "Barry", Number = 7317750 });
    }

}

