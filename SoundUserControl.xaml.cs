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

namespace _2508Class_Exrices___Exrice1__Sound_
{
    /// <summary>
    /// Interaction logic for SoundUserControl.xaml
    /// </summary>
    public partial class SoundUserControl : UserControl
    {
        public SoundUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string SoundType { get; set; }
        public double MaxSliderValue { get; set; }
    }
}
