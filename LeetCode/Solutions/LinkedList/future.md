## Доп. задачи

### Бинарный поиск по ответу

- [**Sqrt(x)**](https://leetcode.com/problems/sqrtx)
    - Java
        
        ```java
        class Solution {
            // time: O(log n)
            // mem:  O(1)
            public int mySqrt(int x) {
                // Note: работаем именно с целыми числами
                // если работать с не целыми, то получим неточный ответ
                // из-за накаплавающейся неточности во float
                int l = 0;
                long r = (long) x + 1; 
                while (r - l > 1) {
                    long m = (l + r) / 2;
                    if (good(m, x)) {
                        l = (int) m;
                    } else {
                        r = m;
                    }
                }
                return l;
            }
        
            private boolean good(long i, int x) { 
                return i * i <= x;
            }
        }
        ```
        
### Binary Search

- [ ]  [**Find K Closest Elements**](https://leetcode.com/problems/find-k-closest-elements/) - нетривиальная задача на подумать, нужно добиться O(logN)
- [ ]  [**81. Search in Rotated Sorted Array II**](https://leetcode.com/problems/search-in-rotated-sorted-array-ii/description/?envType=problem-list-v2&envId=binary-search)
- [ ]  [**153. Find Minimum in Rotated Sorted Array**](https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/description/)
- [ ]  [**367. Valid Perfect Square**](https://leetcode.com/problems/valid-perfect-square/description/)
- [ ]  [**Дискретное ускорение (CF)**](https://codeforces.com/problemset/problem/1408/C?locale=ru) - нетривиальная задача на подумать

### Linked List

Нужно изучить сначала [**“Floyd’s Cycle Detection Algorithm”**](https://www.interviewbit.com/blog/detect-loop-in-linked-list/)

- [ ]  [**141. Linked List Cycle**](https://leetcode.com/problems/linked-list-cycle/description/)
- [ ]  [**142. Linked List Cycle II**](https://leetcode.com/problems/linked-list-cycle-ii/)