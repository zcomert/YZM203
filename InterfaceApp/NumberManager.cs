using System.Collections;

class NumberManager : IEnumerable
{
    private List<int> _numbers;
    public NumberManager()
    {
        _numbers = new List<int>();
    }
    public NumberManager(params int[] items) : this()
    {
       _numbers.AddRange(items);
    }

    public void Add(int item)
    {
        _numbers.Add(item);
    }

    public IEnumerator GetEnumerator()
    {
        // return _numbers.GetEnumerator();
        return new NumberManagerEnumerator(_numbers);
    }
}