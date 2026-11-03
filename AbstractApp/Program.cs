var heap = new MaxHeap();

heap.Insert(350); // bilet
heap.Insert(250); // mısır
heap.Insert(100); // kola
heap.Insert(300); // tatlı
heap.Insert(220); // kahve

int n = 5;
while(n>0)
{
     System.Console.WriteLine(heap.Extract());
     n--;
}