using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
using WpfEx.Pages;

namespace WpfEx
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private void ButtonExit_OnClick(object sender, RoutedEventArgs e) // Кнопка для выхода из приложения
		{
			MessageBoxResult Result = MessageBox.Show("Закрыть приложение ?", "Выход", MessageBoxButton.YesNo);
			if (Result == MessageBoxResult.Yes)
			{
				Close();
			}
			else if (Result == MessageBoxResult.No)
			{
				// При отказе убираем диалоговое окно
			}
		}

		private void ButtonAuth_OnClick(object sender, RoutedEventArgs e) // Переводит на страницу для Авторизаций
		{
			MainFrame.Content = new Page_Auth();
		}

		public MainWindow()
		{
			InitializeComponent();
		}
	}
}
