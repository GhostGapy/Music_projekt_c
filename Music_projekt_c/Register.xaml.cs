using System;
using System.Windows;

namespace Music_projekt_c
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = username_box.Text;
            string password1 = password2_box.Password;
            string password2 = password2_box.Password;

            if (username == "" || password1 == "" || password2 == "")
            {
                MessageBox.Show("Prosim izplonite vsa polja");
            }
            else
            {
                if (password1 == password2)
                {
                    string passHash = hash.GetHashString(password1);

                    if (SQL_code.freeUsername(username) == true)
                    {
                        SQL_code.Register(username, passHash);
                        MessageBox.Show("Registracija uspešna");
                    }
                    else
                    {
                        MessageBox.Show("Uporabniško ime je že zasedeno");
                    }
                }
                else
                {
                    MessageBox.Show("Gesli se ne ujemata");
                }
            }
        }
    }
}
