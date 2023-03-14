using CodeHomeWork_3_1;

MyList<int> list = new MyList<int>();

list.Add(10);
list.Add(2);
list.Add(63);
list.Add(27);
list.Add(30);

int[] a = new int[] { 23, 3, 14, 25 };

list.AddRange(a);

list.Remove(10);

list.RemoveAt(5);

list.Sort();

Console.WriteLine();