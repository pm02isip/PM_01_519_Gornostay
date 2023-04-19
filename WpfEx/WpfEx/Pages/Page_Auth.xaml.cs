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
	/// Логика взаимодействия для Page_Auth.xaml
	/// </summary>
	public partial class Page_Auth : Page
	{

		private void TextBoxLogin_Changed(object sender, RoutedEventArgs e) // Убирает текст при заполнений значений
		{
			txtHintLogin.Visibility = Visibility.Visible;
			if (TextBoxLogin.Text.Length > 0)
			{
				txtHintLogin.Visibility = Visibility.Hidden;
			}
		}

		private void ButtonEnter_OnClick(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(TextBoxLogin.Text)) // Проверяет на проверку пустого текста
			{
				MessageBox.Show("Введите логин и пароль!");
				return;
			}
			using (var db = new WpfExEntities())
			{
				var user = db.User
					.AsNoTracking()
					.FirstOrDefault(u => u.Login == TextBoxLogin.Text && u.Password == PasswordBox.Password); // Сверяет логин и пароль пользователя

				if (user == null)
				{
					MessageBox.Show("Пользователь с такими данными не найден!");
					return;
				}

				MessageBox.Show("Пользователь успешно найден");

				switch (user.Role)
				{
					case "Жюри":
						NavigationService?.Navigate(new Page_Juri()); // Переводит на страницу для Жюри
						break;
					case "Участник":
						NavigationService?.Navigate(new Page_Part()); // Переводит на страницу для Участника
						break;
					case "Организатор":
						NavigationService?.Navigate(new Page_Admi()); // Переводит на страницу для Организатора
						break;
				}
			}
		}
		public Page_Auth()
		{
			InitializeComponent();
		}
	}
}
