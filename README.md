# XamarinFormsButton
Button click event sample

## Pickuped code
### Page1.xaml
```xml
  ....
  <Label x:Name="MainLabel" Text="hoge" />
  <Button x:Name="Plus"  Text="Plus"  Clicked="Button_Clicked" />
  <Button x:Name="Minus" Text="Minus" Clicked="Button_Clicked" />
  ....
```

### Page1.xaml.cs
```cs
public void Button_Clicked(object sender, EventArgs e)
{
    Button button = sender as Button;
    switch (button.Text)
    {
        case "Plus":
            m_count++;
            break;
        case "Minus":
            m_count--;
            break;
    }
    MainLabel.Text = "Count: " + m_count;
}
```

## Screenshot
![screenshot](https://raw.githubusercontent.com/xamarin-samples/XamarinFormsButton/master/screenshots/screenshot.png)
