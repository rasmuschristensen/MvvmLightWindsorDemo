using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;

namespace TradeApp.ViewModels
{
    public class TraderViewModel : ViewModelBase
    {
        private string _tradeAmount;
        public RelayCommand MakeTrade { get; private set; }

        public string TradeAmount
        {
            get { return _tradeAmount; }
            set
            {
                _tradeAmount = value;
                RaisePropertyChanged(()=> TradeAmount);
            }
        }

        public TraderViewModel()
        {
            MakeTrade = new RelayCommand(OnTradeMade);
        }

        private void OnTradeMade()
        {
            MessengerInstance.Send( new NotificationMessageAction<TradeDetails>("make my trade",OnTradeComplete));
        }

        private void OnTradeComplete(TradeDetails data)
        {
            TradeAmount = string.Format("New Trade {0}", data.Price);
            MessengerInstance.Send(new NotificationMessage<double>(data.Price, "new trade made"));
        }
        
    }

    internal class TradeDetails
    {
        public double Price { get; set; }
    }
}