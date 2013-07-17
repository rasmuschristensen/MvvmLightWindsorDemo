using System.Globalization;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace TradeApp.ViewModels
{
    public class BossViewModel : ViewModelBase
    {
        private string _balanceAccount;

        public BossViewModel()
        {
            MessengerInstance.Register<NotificationMessage<double>>(this, message =>
                {
                    BalanceAccount = message.Content.ToString(CultureInfo.InvariantCulture);
                });
        }

        public string BalanceAccount
        {
            get { return _balanceAccount; }
            set { _balanceAccount = value; RaisePropertyChanged(() => BalanceAccount);}
        }
    }
}