using System;
using System.Collections.Generic;
using System.Linq;

public class ValueTypeCollection<T> where T : struct, IComparable<T>
{
    private List<T> _collection = new List<T>();

    // Method to add items to the private collection
    public void AddItem(T item)
    {
        _collection.Add(item);
    }

    // Method to return an item from the list by index
    public T GetItem(int index)
    {
        if (index < 0 || index >= _collection.Count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        return _collection[index];
    }

    // Method to return a sorted collection in descending order
    public List<T> GetSortedDescending()
    {
        return _collection.OrderByDescending(item => item).ToList();
    }
}


public class Program
{
    public static void Main()
    {
        var collection = new ValueTypeCollection<int>();
        collection.AddItem(5);
        collection.AddItem(1);
        collection.AddItem(10);
        collection.AddItem(3);

        Console.WriteLine("Item at index 2: " + collection.GetItem(2));

        var sortedCollection = collection.GetSortedDescending();
        Console.WriteLine("Sorted collection in descending order: " + string.Join(", ", sortedCollection));
    }
}
