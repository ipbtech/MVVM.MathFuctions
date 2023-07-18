using MVVM.MathFunctions.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MVVM.MathFunctions.ViewModels
{
    public class GetSumListVM : INotifyPropertyChanged
    {
        private readonly GetSumList _myModel = new GetSumList();
        public ReadOnlyObservableCollection<double> Values
        {
            get { return _myModel.MyPublicValues; }
        }
        public double NewItem { get; set; }
        public int IndexSelectedItem { get; set; }

        private RelayCommand? _addNewItemCommand;
        public RelayCommand AddNewItemCommand
        {
            get
            {
                return _addNewItemCommand = new RelayCommand(obj =>
                {
                    _myModel.AddValue(NewItem);
                    OnPropertyChanged("SumValue");
                });
            }
        }
        private RelayCommand? _removeNewItemCommand;
        public RelayCommand RemoveNewItemCommand
        {
            get
            {
                return _removeNewItemCommand = new RelayCommand(obj =>
                {
                    _myModel.RemoveValue(IndexSelectedItem);
                    OnPropertyChanged("SumValue");
                });
            }
        }
        public double SumValue
        {
            get { return _myModel.GetSumOfList(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
