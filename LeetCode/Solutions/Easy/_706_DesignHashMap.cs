namespace LeetCode.Solutions.Easy;

public static class _706_DesignHashMap
{
    public static void Solution()
    {
        var myHashMap = new MyHashMap();
        myHashMap.Put(1, 1); // The map is now [[1,1]]
        myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
        myHashMap.Get(1);    // return 1, The map is now [[1,1], [2,2]]
        myHashMap.Get(3);    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
        myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
        myHashMap.Get(2);    // return 1, The map is now [[1,1], [2,1]]
        myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
        myHashMap.Get(2);    // return -1 (i.e., not found), The map is now [[1,1]]
    }

    public class MyHashMap
    {
        private readonly int?[] _map = new int?[1000001];

        public void Put(int key, int value)
        {
            _map[key] = value;
        }

        public int Get(int key)
        {
            var value = _map[key];
            return value != null ? value.Value : -1;
        }

        public void Remove(int key)
        {
            _map[key] = null;
        }
    }
}
