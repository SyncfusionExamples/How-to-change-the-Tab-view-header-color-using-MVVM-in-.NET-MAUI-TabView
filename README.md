This section outlines the step-by-step process to change the Tab view header color using the MVVM pattern within a [.NET MAUI TabView](https://www.syncfusion.com/maui-controls/maui-tab-view). By binding the [TabBarBackground](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.TabView.SfTabView.html#Syncfusion_Maui_TabView_SfTabView_TabBarBackground) property to a color field in the ViewModel, you can dynamically alter the header color.

**Step 1: Initialize TabView in .NET MAUI Page**

 Begin by creating a new sample in .NET MAUI. Initialize the TabView control within the content page and set the BindingContext property to associate it with a ViewModel.

**XAML:**
```
<ContentPage.BindingContext>
    <local:ViewModel/>
</ContentPage.BindingContext>

```

**Step 2: Create Model and ViewModel Classes**

In the code-behind file, create the necessary Model and ViewModel classes. Establish an Observable collection within the ViewModel to represent the items within the TabView.

**C#**
```
public class Model
{
    public string Name { get; set; }
    public long Number { get; set; }
}
```

**Step 3: Define Color Field in ViewModel**

Within the ViewModel, create a new color field that will be used to bind to the `TabBarBackground` property of the TabView. Assign the desired color value to this field and expose it through a public property.

**C#**
```

public class ViewModel
{
    public Color TabHeaderColor { get; set; }
    public ObservableCollection<Model> ContactList { get; set; }

    }
    public ViewModel()
    {
        TabHeaderColor  = Colors.Aqua;
        
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
```

**Step 4: Bind TabBarBackground Property**

In the XAML page, bind the TabBarBackground property of the TabView to the TabHeaderColor property in the ViewModel.

**XAML:**
```
<tabView:SfTabView TabBarBackground="{Binding TabHeaderColor, Mode=TwoWay}" >
    <tabView:SfTabItem Header="Calls">
        <tabView:SfTabItem.Content>
            <Grid BackgroundColor="White" x:Name="AllContactsGrid" >
                <ListView x:Name="ContactListView" 
                          ItemsSource="{Binding ContactList}"
                          RowHeight="75">
                    <ListView.ItemTemplate>
                        <DataTemplate>
                            <ViewCell>
                                <StackLayout Orientation="Vertical" Margin="30,0,0,0">
                                    <Label Text="{Binding Name}"
                                            FontSize="24"/> 
                                    <Label 
                                            Text="{Binding Number}" 
                                            FontSize="20" 
                                            TextColor="LightSlateGray"/>
                                </StackLayout>
                            </ViewCell>
                        </DataTemplate>
                    </ListView.ItemTemplate>
                </ListView>
            </Grid>
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
    <tabView:SfTabItem Header="Favorites">
        <tabView:SfTabItem.Content>
            <Grid BackgroundColor="Green" x:Name="FavoritesGrid" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
    <tabView:SfTabItem Header="Contacts">
        <tabView:SfTabItem.Content>
            <Grid BackgroundColor="Red" x:Name="AllContacts" />
        </tabView:SfTabItem.Content>
    </tabView:SfTabItem>
</tabView:SfTabView>
    
```

**Output:**

![TabColor.png](https://support.bolddesk.com/kb/agent/attachment/article/13621/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEwNTcyIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5ib2xkZGVzay5jb20ifQ.roY508_YQfK6av2IT8SAqzV5oClccvcHWTooiV-MCLU)
