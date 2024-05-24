using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace viragokZsK
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Flower> flowers = new();
		List<Flower> name = new();
		
		public MainWindow()
		{
			InitializeComponent();
			using StreamReader sr = new StreamReader(
				path: @"..\..\..\src\flowers.txt",
				encoding: Encoding.UTF8
				);
			while ( !sr.EndOfStream ) 
			{
                flowers.Add(new Flower(sr.ReadLine()));
			}
		
		//flowers.OrderBy(flower => flower.Name.Reverse());


			sr.Close();
			if (flowers != null)
			{
				foreach (var item in flowers)
				{
					
					FlowerList.Items.Add(item.Name);

					PriceList.Items.Add(item.Price);
					ColorList.Items.Add(item.Color);
				}				
			}	

		}

		private void deletButton_Click(object sender, RoutedEventArgs e)
		{
            if (FlowerList.SelectedItem != null || ColorList.SelectedItem != null || PriceList.SelectedItem != null)
			{
				int index = FlowerList.SelectedIndex;
				FlowerList.Items.Remove(FlowerList.SelectedItem);
				ColorList.Items.Remove(ColorList.SelectedItem);
				PriceList.Items.Remove(PriceList.SelectedItem);
			}
            else
            {
				MessageBox.Show("nem jelöltél ki semmit");
            }

        }

		private void copyButton_Click(object sender, RoutedEventArgs e)
		{
            if (FlowerList.SelectedItem != null)
            {
				CopyList.Items.Add(FlowerList.SelectedItem); 
            }
            else
            {
				MessageBox.Show("nem jelöltél ki semmit a virágok közül");
            }
        }

	
	}
}