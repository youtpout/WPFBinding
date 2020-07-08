using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

namespace WPFBinding
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Data> Datas { get; set; }

        public RelayCommand<Data> DeleteCommand { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Datas = new ObservableCollection<Data>();
            Datas.Add(new Data() { Date = DateTime.Now.AddDays(-2), Name = "Fichier Toto" });
            Datas.Add(new Data() { Date = DateTime.Now, Name = "Fichier uno" });
            Datas.Add(new Data() { Date = DateTime.Now.AddDays(-25), Name = "Folder empty" });

            DeleteCommand = new RelayCommand<Data>(DeleteItem);

            this.DataContext = this;
        }

        private void DeleteItem(Data item)
        {
            Datas.Remove(item);
        }
    }
}
