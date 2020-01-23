using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarintableView
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {

        public ICommand ButtonCommand { get; private set; }
        public string ButtonCommandResult { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            ButtonCommand = new Command<string>(CommandCallMethod);
            BindingContext = this;
        }

        private void CommandCallMethod(string value) {
            ButtonCommandResult = value;
            OnPropertyChanged("ButtonCommandResult");
        }

    }
}
