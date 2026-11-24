using System.Collections;

class NumberManagerEnumerator : IEnumerator<int>
{
    private List<int> _innerList;
    private int _index = -1;

    public NumberManagerEnumerator(List<int> items)
    {
        _innerList = items;
    }
    public int Current => _innerList[_index];


    object IEnumerator.Current => Current;

    public void Dispose()
    {
        // GB halleder; bırakılacak kaynak yok!

    }

    public bool MoveNext()
    {
        _index++;
        if (_index >= 0 && _index < _innerList.Count)
            return true;
        return false;
    }

    public void Reset()
    {
        _index = -1;
    }
}