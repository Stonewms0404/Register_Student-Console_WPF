using System;
using System.Windows;

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");

            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);

            this.textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);
            if (choice.IsRegisteredAlready())
            {
                label3.Content = $"You have already registered for this {choice.getName()} course.";
                return;
            }
            else if (Course.GetTotalCredits() >= 9)
            {
                label3.Content = "You can not register for more than 9 credit hours.";
                return;
            }

            choice.SetToRegistered();
            listBox.Items.Add(choice);
            textBox.Text = Convert.ToString(Course.GetTotalCredits());
        }
    }
}
