// See https://aka.ms/new-console-template for more information

List<int> lst  = new List<int>
{
    1,2,3,4,7,10,3213,13,12,312,34,6,5,32,3,22,11
};

int x  = 10;

foreach (var t in lst)
{
    if (t == x)
    {
        Console.WriteLine("found");
        break;
    }
}

var el = lst.Find(y => y == 10);
lst.Count(x => x == 10);//count element which are equal to 10 
lst.RemoveAll(x => x == 5);

var first = lst.First(i => i == 5);