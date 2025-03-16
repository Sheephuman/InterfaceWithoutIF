using System.Windows;

namespace SuperDataClassTest;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window 
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void RegisterFarmData(object sender, RoutedEventArgs e)
    {


        var farmData = new FarmDataImpl(
            FarmNameTextBox.Text,
            int.Parse(SheepCountTextBox.Text), OwnerPersonalityTextBox.Text,
            OwnerPersonalityTextBox.Text);
  



        FarmOutputTextBlock.Text = farmData.GetData();


    }
    private void RegisterEmployeeData(object sender, RoutedEventArgs e)
    {
        // Measurements のタプルを作成
        var measurements = (
      Bust: int.Parse(BustTextBox.Text),
      Waist: int.Parse(WaistTextBox.Text),
      Hip: int.Parse(HipTextBox.Text)
  );

        var empleyData = new FemaleEmployeeImpl(EmployeeNameTextBox.Text,int.Parse(HeightTextBox.Text),
            measurements, SheepBreedTextBox.Text);


         

        EmployeeOutputTextBlock.Text = empleyData.GetData();
    }

}