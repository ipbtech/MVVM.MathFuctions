using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace MVVM.MathFunctions.Models
{
    public class GetSumList
    {
        private readonly ObservableCollection<double> _myValues = new ObservableCollection<double>();
        public readonly ReadOnlyObservableCollection<double> MyPublicValues;
        public GetSumList()
        {
            MyPublicValues = new ReadOnlyObservableCollection<double>(_myValues);
        }
        public void AddValue(double value)
        {
            _myValues.Add(value);
        }
        public void RemoveValue(int index)
        {
            if (index >= 0 && index < _myValues.Count)
            {
                _myValues.RemoveAt(index);                
            }
        }
        public double GetSumOfList()
        {
            return Math.Round(MyPublicValues.Sum());
        }
    }
}
