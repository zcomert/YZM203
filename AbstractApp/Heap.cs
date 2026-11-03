public abstract class Heap
{
    protected List<int> _innerList;
    public Heap()
    {
        _innerList = new List<int>();
    } 

    public void Insert(int value)
    {
        _innerList.Add(value);
    }

    public abstract int Extract();
 
}
