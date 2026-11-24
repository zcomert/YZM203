class MaxHeap : Heap
{
    public override int Extract()
    {
        var max = _innerList.Max();
        _innerList.Remove(max);
        return max;
    }
}