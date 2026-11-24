class Number
{
    // Referans tipli ifadeler başlatılmak zorundadır!
    private int[] _innerList;
    public Number() // ctor
    {
        _innerList = new int[] {61, 23, 44, 52, 38};
    }

    public int GetMin()
    {
        int x = _innerList[0];
        for (int i = 0; i < _innerList.Length; i++)
        {
            if (_innerList[i] < x)
            {
                x = _innerList[i];
            }
        }
        return x;
    }

    // lamda =>
    public int GetMax() =>_innerList.Max();

}