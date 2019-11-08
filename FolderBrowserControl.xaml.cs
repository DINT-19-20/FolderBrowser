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

namespace FolderBrowser
{
    /// <summary>
    /// Lógica de interacción para FolderBrowserControl.xaml
    /// </summary>
    public partial class FolderBrowserControl : UserControl
    {

        //Propiedades de dependencia
        public string FolderPath
        {
            get { return (string)GetValue(FolderPathProperty); }
            set { SetValue(FolderPathProperty, value); }
        }

        public static readonly DependencyProperty FolderPathProperty =
    DependencyProperty.Register("FolderPath", typeof(string), typeof(FolderBrowserControl), new PropertyMetadata(""));


        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty =
    DependencyProperty.Register("Label", typeof(string), typeof(FolderBrowserControl), new PropertyMetadata(""));


        public bool IsReadOnly
        {
            get { return (bool)GetValue(IsReadOnlyProperty); }
            set { SetValue(IsReadOnlyProperty, value); }
        }

        public static readonly DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(FolderBrowserControl), new PropertyMetadata(true));



        public bool AllowNewFolder
        {
            get { return (bool)GetValue(AllowNewFolderProperty); }
            set { SetValue(AllowNewFolderProperty, value); }
        }

        public static readonly DependencyProperty AllowNewFolderProperty =
            DependencyProperty.Register("AllowNewFolder", typeof(bool), typeof(FolderBrowserControl), new PropertyMetadata(true));


        public FolderBrowserControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void SeleccionarButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialogo = new System.Windows.Forms.FolderBrowserDialog
            {
                ShowNewFolderButton = AllowNewFolder,
                SelectedPath = FolderPath
            };

            if (dialogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FolderPath = dialogo.SelectedPath;
            }

        }
    }
}
