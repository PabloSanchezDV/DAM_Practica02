namespace DAM_Practica02.Views;

public partial class Settings : ContentPage
{
    public Settings()
    {
        InitializeComponent();
    }

    #region Primary Font
    /// <summary>
    /// Upon Picker Selection, changes the font of the PrimaryTextStyle.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnPrimaryFontChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedItem == null)
            return;

        string selectedFont = picker.SelectedItem.ToString();

        Application.Current.Resources["PrimaryFontFamily"] = selectedFont;
    }

    /// <summary>
    /// Upon Slider Value Changed, changed the size of the PrimaryTextStyle.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnPrimaryFontSizeSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        Application.Current.Resources["PrimaryFontSize"] = e.NewValue;
    }

    /// <summary>
    /// Upon Picker Selection, changed the color of the PrimaryTextStyle.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnPrimaryColorChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedItem == null)
            return;

        string selectedColor;
        switch (picker.SelectedItem.ToString())
        {
            case "Yellow":
                selectedColor = "#EBE4A7";
                break;
            case "Pink":
                selectedColor = "#E8A7EB";
                break;
            case "Blue":
                selectedColor = "#A7E9EB";
                break;
            case "Purple":
                selectedColor = "#BEA7EB";
                break;
            case "Red":
                selectedColor = "#EBA7A7";
                break;
            case "White":
                selectedColor = "#FFFFFF";
                break;
            default:
                selectedColor = "#EBE4A7";
                break;
        }

        Application.Current.Resources["PrimaryDark"] = selectedColor;
    }
    #endregion

    #region Secondary Font
    /// <summary>
    /// Upon Picker Selection, changes the font of the SecondaryTextStyle.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnSecondaryFontChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedItem == null)
            return;

        string selectedFont = picker.SelectedItem.ToString();

        Application.Current.Resources["SecondaryFontFamily"] = selectedFont;
    }

    /// <summary>
    /// Upon Slider Value Changed, changed the size of the SecondaryTextStyle.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnSecondaryFontSizeSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        Application.Current.Resources["SecondaryFontSize"] = e.NewValue;
    }


    /// <summary>
    /// Upon Picker Selection, changed the color of the SecondaryTextStyle.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnSecondaryColorChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedItem == null)
            return;

        string selectedColor;
        switch (picker.SelectedItem.ToString())
        {
            case "Yellow":
                selectedColor = "#EBE4A7";
                break;
            case "Pink":
                selectedColor = "#E8A7EB";
                break;
            case "Blue":
                selectedColor = "#A7E9EB";
                break;
            case "Purple":
                selectedColor = "#BEA7EB";
                break;
            case "Red":
                selectedColor = "#EBA7A7";
                break;
            case "White":
                selectedColor = "#FFFFFF";
                break;
            default:
                selectedColor = "#EBE4A7";
                break;
        }

        Application.Current.Resources["SecondaryDarkText"] = selectedColor;
    }
    #endregion

    #region Tertiary Font
    /// <summary>
    /// Upon Picker Selection, changes the font of the TertiaryTextStyle.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnTertiaryFontChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedItem == null)
            return;

        string selectedFont = picker.SelectedItem.ToString();

        Application.Current.Resources["TertiaryFontFamily"] = selectedFont;
    }

    /// <summary>
    /// Upon Slider Value Changed, changed the size of the TertiaryTextStyle.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnTertiaryFontSizeSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        Application.Current.Resources["TertiaryFontSize"] = e.NewValue;
    }


    /// <summary>
    /// Upon Picker Selection, changed the color of the TertiaryTextStyle.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnTertiaryColorChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        if (picker.SelectedItem == null)
            return;

        string selectedColor;
        switch (picker.SelectedItem.ToString())
        {
            case "Yellow":
                selectedColor = "#EBE4A7";
                break;
            case "Pink":
                selectedColor = "#E8A7EB";
                break;
            case "Blue":
                selectedColor = "#A7E9EB";
                break;
            case "Purple":
                selectedColor = "#BEA7EB";
                break;
            case "Red":
                selectedColor = "#EBA7A7";
                break;
            case "White":
                selectedColor = "#FFFFFF";
                break;
            default:
                selectedColor = "#EBE4A7";
                break;
        }

        Application.Current.Resources["TertiaryDarkText"] = selectedColor;
    }
    #endregion
}