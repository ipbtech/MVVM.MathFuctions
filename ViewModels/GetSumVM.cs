using MVVM.MathFunctions.Models;
using System.ComponentModel;

namespace MVVM.MathFunctions.ViewModels
{
    public class GetSumVM : INotifyPropertyChanged
    {
        private double _number1;
        public double Number1
        {
            get { return _number1; }
            set{ _number1 = value; OnPropertyChanged("Number3"); }
        }

        private double _number2;
        public double Number2
        {
            get { return _number2; }
            set { _number2 = value; OnPropertyChanged("Number3"); }
        }
        public double Number3 
        { 
            get { return MathFuncModel.GetSumOf(Number1, Number2); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
