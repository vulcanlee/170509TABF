using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFSingle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            fooButton.Clicked +=
                (s, e) =>
                {
                    fooLabel.Text =
                    "Hello XF, " +
                    fooEntry.Text;
                };
        }
    }
}
