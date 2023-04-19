using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfEx.Pages
{
	/// <summary>
	/// Логика взаимодействия для Page_Juri.xaml
	/// </summary>
	public partial class Page_Juri : Page
	{

		WpfExEntities db = new WpfExEntities();
		public Page_Juri()
		{
			InitializeComponent();

			DataGridUser.ItemsSource = WpfExEntities.GetContext().User.ToList(); // Выводит информацию таблицы с SQL
		}
	}
}
