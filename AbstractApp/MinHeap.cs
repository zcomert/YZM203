class MinHeap : Heap
{
    public override int Extract()
    {
        var min = _innerList.Min();
        _innerList.Remove(min);
        return min;
    }
}
