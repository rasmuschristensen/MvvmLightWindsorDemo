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
using GalaSoft.MvvmLight.Messaging;
using TradeApp.ViewModels;

namespace TradeApp.Views
{
    /// <summary>
    /// Interaction logic for TraderView.xaml
    /// </summary>
    public partial class TraderView : UserControl, IView
    {
        public TraderView(TraderViewModel viewModel)
        {
            this.DataContext = viewModel;
            InitializeComponent();

            Messenger.Default.Register<NotificationMessageAction<TradeDetails>>(this, action => action.Execute(new TradeDetails() {Price = 5000}));
        }

       
    }
}
