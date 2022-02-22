using System.Windows.Controls;
using WpfMvvmTest.Core.ViewModels;

namespace WpfMvvmTest
{
    public partial class InvokeCommandPage : Page
    {
        public InvokeCommandPage()
        {
            InitializeComponent();
            DataContext = new InvokeCommandPageViewModel();
        }
    }
}
