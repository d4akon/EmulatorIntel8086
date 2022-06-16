using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Intel8086Emulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private string AXValue;
        public string AX
        {
            get { return AXValue; }
            set
            {
                AXValue = value;
                OnPropertyChanged();
            }
        }

        private string BXValue;
        public string BX
        {
            get { return BXValue; }
            set
            {
                BXValue = value;
                OnPropertyChanged();
            }
        }
        private string CXValue;
        public string CX
        {
            get { return CXValue; }
            set
            {
                CXValue = value;
                OnPropertyChanged();
            }
        }
        private string DXValue;
        public string DX
        {
            get { return DXValue; }
            set
            {
                DXValue = value;
                OnPropertyChanged();
            }
        }

        // public string AX { get; set; }
        // public string BX { get; set; }
        // public string CX { get; set; }
        // public string DX { get; set; }


        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void Button_all_OnClick(object sender, RoutedEventArgs e)
        {
            this.AX = TextBox_AX.Text.ToString() ?? throw new InvalidOperationException();
            this.BX = TextBox_BX.Text.ToString() ?? throw new InvalidOperationException();
            this.CX = TextBox_CX.Text.ToString() ?? throw new InvalidOperationException();
            this.DX = TextBox_DX.Text.ToString() ?? throw new InvalidOperationException();
        }

        private void Button_mov_OnClick(object sender, RoutedEventArgs e)
        {
            string first = ComboBoxFirst.Text.ToUpper();
            string second = ComboBoxSecond.Text.ToUpper();

            if (first == "AX" && second == "AX")
                this.AX = this.AX;
            if (first == "AX" && second == "BX")
                this.AX = this.BX;
            else if (first == "AX" && second == "CX")
                this.AX = this.CX;
            else if (first == "AX" && second == "DX")
                this.AX = this.DX;
            else if (first == "BX" && second == "AX")
                this.BX = this.AX;
            else if (first == "BX" && second == "BX")
                this.BX = this.BX;
            else if (first == "BX" && second == "CX")
                this.BX = this.CX;
            else if (first == "BX" && second == "DX")
                this.BX = this.DX;
            else if (first == "CX" && second == "AX")
                this.CX = this.AX;
            else if (first == "CX" && second == "BX")
                this.CX = this.BX;
            else if (first == "CX" && second == "CX")
                this.CX = this.CX;
            else if (first == "CX" && second == "DX")
                this.CX = this.DX;
            else if (first == "DX" && second == "AX")
                this.DX = this.AX;
            else if (first == "DX" && second == "BX")
                this.DX = this.BX;
            else if (first == "DX" && second == "CX")
                this.DX = this.CX;
            else if (first == "DX" && second == "DX")
                this.DX = this.DX;
        }
    }
}