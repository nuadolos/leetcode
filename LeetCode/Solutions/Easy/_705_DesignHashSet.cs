using System.Collections;

namespace LeetCode.Solutions.Easy;

public static class _705_DesignHashSet
{
    public static void Solution()
    {
        var myHashSet = new MyHashSet();
        myHashSet.Add(1);      // set = [1]
        myHashSet.Add(2);      // set = [1, 2]
        myHashSet.Contains(1); // return True
        myHashSet.Contains(3); // return False, (not found)
        myHashSet.Add(2);      // set = [1, 2]
        myHashSet.Contains(2); // return True
        myHashSet.Remove(2);   // set = [1]
        myHashSet.Contains(2); // return False, (already removed)
    }

    public class MyHashSet
    {
        private readonly BitArray _set;

        public MyHashSet()
        {
            _set = new BitArray(1000001);
        }

        public void Add(int key)
        {
            _set[key] = true;
        }

        public void Remove(int key)
        {
            _set[key] = false;
        }

        public bool Contains(int key)
        {
            return _set[key];
        }
    }
}
