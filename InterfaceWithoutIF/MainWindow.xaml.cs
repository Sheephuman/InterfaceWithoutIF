using InterfaceWithoutIF;
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
        try
        {

            var farmData = new FarmDataImpl(
            FarmNameTextBox.Text,
            int.Parse(SheepCountTextBox.Text), OwnerPersonalityTextBox.Text,
            OwnerPersonalityTextBox.Text, true);


            //Dataを持っているか判定
            //三項演算子かNull合体演算子
            EmployeeOutputTextBlock.Text = farmData.HasFarmData ? farmData.GetData() : farmData.GetData();

            FarmOutputTextBlock.Text = farmData.GetData();
        }
        catch (FormatException ex)
        {
            MessageBox.Show(ex.Message + "空欄の箇所があります");
            //debug.Writelineも可

        }
    }
    private void RegisterEmployeeData(object sender, RoutedEventArgs e)
    {
        try
        {
            // Measurements のタプルを作成
            var measurements = (
          Bust: int.Parse(BustTextBox.Text),
          Waist: int.Parse(WaistTextBox.Text),
          Hip: int.Parse(HipTextBox.Text)
      );


            var empleyData = new FemaleEmployeeImpl(EmployeeNameTextBox.Text, int.Parse(HeightTextBox.Text),
                measurements, SheepBreedTextBox.Text, true);

                
            var emptydata = new EmptyDataContainer();
                
            EmployeeOutputTextBlock.Text = empleyData.HasEmployeeData ?  empleyData.GetData(): emptydata.GetData();
        }
        catch (FormatException ex)
        {
            MessageBox.Show(ex.Message + "空欄の箇所があります");
                //debug.Writelineも可
        
        }
    }

}