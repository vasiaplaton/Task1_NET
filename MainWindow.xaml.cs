using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MySet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Task1.models.Set<string> set;
        public MainWindow()
        {
            InitializeComponent();
            set = new Task1.models.Set<string>();
            UpdateSetContent();
        }

        private void AddElement_Click(object sender, RoutedEventArgs e)
        {
            string element = txtElement.Text;
            if (!string.IsNullOrWhiteSpace(element))
            {
                set.Add(element);
                UpdateSetContent();
            }
        }

        private void RemoveElement_Click(object sender, RoutedEventArgs e)
        {
            string element = txtElement.Text;
            if (!string.IsNullOrWhiteSpace(element))
            {
                set.Remove(element);
                UpdateSetContent();
            }
        }

        private void ClearSet_Click(object sender, RoutedEventArgs e)
        {
            set.Clear();
            UpdateSetContent();
        }

        private void GetArray_Click(object sender, RoutedEventArgs e)
        {
            var array = set.ToArray();
            txtArray.Text = "Массив: {" + string.Join(", ", array) + "}";
        }

        private void CheckElement_Click(object sender, RoutedEventArgs e)
        {
            string element = txtCheckElement.Text;
            if (!string.IsNullOrWhiteSpace(element))
            {
                bool contains = set.Contains(element);
                txtContains.Text = $"Содержит элемент: {contains}";
            }
        }

        private void UpdateSetContent()
        {
            txtSetContent.Text = set.ToString();
            txtCount.Text = $"Всего элементов: {set.Count}";
            txtIsEmpty.Text = $"Пустой: {set.IsEmpty}";
            txtArray.Text = "Массив:";
            txtContains.Text = $"Содержит элемент:";
        }
    }
}
