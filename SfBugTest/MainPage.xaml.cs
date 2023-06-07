using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfBugTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Screen_Display_Width = 100;
            BindingContext = this;
        }
        
        public double Screen_Display_Width { get; set; }
    }
}