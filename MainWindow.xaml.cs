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
            if (first == "AX" && second == "CX")
                this.AX = this.CX;
            if (first == "AX" && second == "DX")
                this.AX = this.DX;
            if (first == "BX" && second == "AX")
                this.BX = this.AX;
            if (first == "BX" && second == "BX")
                this.BX = this.BX;
            if (first == "BX" && second == "CX")
                this.BX = this.CX;
            if (first == "BX" && second == "DX")
                this.BX = this.DX;
            if (first == "CX" && second == "AX")
                this.CX = this.AX;
            if (first == "CX" && second == "BX")
                this.CX = this.BX;
            if (first == "CX" && second == "CX")
                this.CX = this.CX;
            if (first == "CX" && second == "DX")
                this.CX = this.DX;
            if (first == "DX" && second == "AX")
                this.DX = this.AX;
            if (first == "DX" && second == "BX")
                this.DX = this.BX;
            if (first == "DX" && second == "CX")
                this.DX = this.CX;
            if (first == "DX" && second == "DX")
                this.DX = this.DX;
        }

        private void Button_xchg_OnClick(object sender, RoutedEventArgs e)
        {
            string third = ComboBoxThird.Text.ToUpper();
            string fourth = ComboBoxFourth.Text.ToUpper();
            string temp = "";

            if (third == "AX" && fourth == "AX")
                this.AX = this.AX;
            if (third == "AX" && fourth == "BX")
            {
                temp = this.AX;
                this.AX = this.BX;
                this.BX = temp;
            }
            if (third == "AX" && fourth == "CX")
            {
                temp = this.AX;
                this.AX = this.CX;
                this.CX = temp;
            }
            if (third == "AX" && fourth == "DX")
            {
                temp = this.AX;
                this.AX = this.DX;
                this.DX = temp;
            }
            if (third == "BX" && fourth == "BX")
                this.BX = this.BX;
            if (third == "BX" && fourth == "AX")
            {
                temp = this.BX;
                this.BX = this.AX;
                this.AX = temp;
            }
            if (third == "BX" && fourth == "CX")
            {
                temp = this.BX;
                this.BX = this.CX;
                this.CX = temp;
            }
            if (third == "BX" && fourth == "DX")
            {
                temp = this.BX;
                this.BX = this.DX;
                this.DX = temp;
            }
            if (third == "CX" && fourth == "CX")
                this.CX = this.CX;
            if (third == "CX" && fourth == "AX")
            {
                temp = this.CX;
                this.CX = this.AX;
                this.AX = temp;
            }
            if (third == "CX" && fourth == "BX")
            {
                temp = this.CX;
                this.CX = this.BX;
                this.BX = temp;
            }
            if (third == "CX" && fourth == "DX")
            {
                temp = this.CX;
                this.CX = this.DX;
                this.DX = temp;
            }
            if (third == "DX" && fourth == "DX")
                this.DX = this.DX;
            if (third == "DX" && fourth == "AX")
            {
                temp = this.DX;
                this.DX = this.AX;
                this.AX = temp;
            }
            if (third == "DX" && fourth == "BX")
            {
                temp = this.DX;
                this.DX = this.BX;
                this.BX = temp;
            }
            if (third == "DX" && fourth == "CX")
            {
                temp = this.DX;
                this.DX = this.CX;
                this.CX = temp;
            }
        }
    }
}