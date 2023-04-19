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
	/// Логика взаимодействия для Page_Admi.xaml
	/// </summary>
	public partial class Page_Admi : Page
	{
		public Page_Admi()
		{
			InitializeComponent();

			DataGridUser.ItemsSource = WpfExEntities.GetContext().User.ToList(); // Выводит информацию таблицы с SQL
		}

		private void ButtonRed_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new Pages.Page_Red((sender as Button).DataContext as User)); // Переводит на страницу для Редактирования пользователя
		}
	}
}
