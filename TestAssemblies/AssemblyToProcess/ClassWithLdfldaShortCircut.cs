using System.ComponentModel;
using NotifyPropertyWeaver;

[NotifyForAll]
public class ClassWithLdfldaShortCircut : INotifyPropertyChanged
{
    decimal? property1;
    public event PropertyChangedEventHandler PropertyChanged;

    public decimal? Property1
    {
        get { return property1; }
        set
        {
            if (value == 0.0m)
            {
                if (property1 == null)
                {
                    return;
                }
                property1 = null;
            }
        }
    }
}