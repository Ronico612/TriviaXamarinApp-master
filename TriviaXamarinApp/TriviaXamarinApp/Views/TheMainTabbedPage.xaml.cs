using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.WindowsSpecific;
using Xamarin.Forms.Xaml;
using TriviaXamarinApp.ViewModels;

namespace TriviaXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TheMainTabbedPage : Xamarin.Forms.TabbedPage
    {
        public Register register;
        public LogIn logIn;
        public AddQuestion addQTab;
        public DeleteQuestion deleteQTab;
        public HomePage home;

        public TheMainTabbedPage()
        {
            this.BindingContext = new TheMainTabbedPageViewModel();
            InitializeComponent();

            home = new HomePage();
            home.Title = "Home";
            this.Children.Add(home);

            logIn = new LogIn();
            logIn.Title = "Login";
            this.Children.Add(logIn);

            register = new Register();
            register.Title = "Register";
            this.Children.Add(register);

            addQTab = new AddQuestion();
            addQTab.Title = "Add Question";

            deleteQTab = new DeleteQuestion();
            deleteQTab.Title = "Delete Question";
        }

        public void AddTab(Xamarin.Forms.Page p)
        {
            if (!this.Children.Contains(p))
                this.Children.Add(p);
        }

        public void RemoveTab(Xamarin.Forms.Page p)
        {
            if (this.Children.Contains(p))
                this.Children.Remove(p);
        }

        public void CurrentTab(Xamarin.Forms.Page p)
        {
            this.CurrentPage = p;
        }
    }
}