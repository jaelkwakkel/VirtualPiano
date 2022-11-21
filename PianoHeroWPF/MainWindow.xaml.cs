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
using Controller;
using Model;

namespace PianoHeroWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Piano Piano { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Piano = PianoController.CreatePiano();
            this.PreviewKeyDown += Piano.KeyDownEventHandler;
        }

    }
}
