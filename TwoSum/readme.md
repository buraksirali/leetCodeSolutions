My first try was to do 2 loops which resulted in O(n).
Below is my first solution.
```
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int firstNumIndex = 0; firstNumIndex < nums.Length; firstNumIndex++) {
            var firstNum = nums[firstNumIndex];
            var numToSearch = target - firstNum;

            for (int secondNumIndex = firstNumIndex + 1; secondNumIndex < nums.Length; secondNumIndex++) {
                if (nums[secondNumIndex] == numToSearch)
                    return new int[] { firstNumIndex, secondNumIndex };
            }
        }

        return new int[2];
    }
}
```

The better solution is to improve the lookup mechanism by using an IDictionary implementation.
Below is my second solution.
```
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var complements = new Dictionary<int, int>();
        for(int firstNumIndex = 0; firstNumIndex < nums.Length; firstNumIndex++) {
            var currentNumber = nums[firstNumIndex];
            var neededNumber = target - currentNumber;

            if (complements.Keys.Contains(neededNumber))
            {
                return new int[2] { firstNumIndex, complements[neededNumber] };
            }
            else
            {
                complements[currentNumber] = firstNumIndex;
            }
        }

        return new int[2];
    }
}
```

Here is its pseudo code to compare.
```
create empty dictionary called complements

loop through each number in nums (index i)
    let currentNumber = nums[i]
    let neededNumber = target - currentNumber

    if the dictionary contains neededNumber
        return the index from the dictionary[neededNumber] and the current index i
    else
        add key=currentNumber and value=i into the dictionary

return an empty pair of indexes if not found
```

Below are the questions I had on this approach.

**1. How IDictionary.Keys Works Under the Microscope**
When you call something like complements.Keys, you’re getting an object called a KeyCollection. This KeyCollection is a specialized view into the underlying dictionary data. Here’s what happens conceptually:

***1.1 Dictionary Underpinnings***
    The Dictionary<TKey, TValue> in .NET is usually implemented as a hash table. It has:
        An array of buckets, each bucket containing either an index into an entries array (which holds the key-value pairs) or a sentinel indicating the bucket is empty.
        A series of entry structs/objects (in an array) that store the actual key-value pairs, along with some book-keeping for collisions.
    Each KeyCollection is essentially a “window” that lets you iterate the keys without letting you modify the dictionary structure.

***1.2 Accessing Keys***
    Dictionary<TKey, TValue>.Keys returns a KeyCollection. The collection does not physically copy all keys out into a new list. Instead, it holds a reference to the same dictionary data structure, which you can enumerate.
    In pseudo-assembly or lower-level terms (on any CPU architecture, including x86), the dictionary object resides in memory (on the heap). When you request .Keys, the runtime:
        Loads the reference to the dictionary object.
        Reads the location of the dictionary’s KeyCollection object (which may be created lazily or simply references the dictionary).
        Returns that reference to your code.

***1.3 Registers vs. Memory***
    The CPU’s registers are a very scarce resource. Typically, a large data structure—like a dictionary with many buckets—lives in memory, not in registers.
    At the CPU (assembly) level, you might see the runtime pass around object references (pointers). It would place those pointers in registers momentarily to do computations (like pointer arithmetic), but the actual “collection of keys” remains in memory.
    You do not get O(1) access because “keys are in registers.” You get close to O(1) average lookups because the dictionary is using hashing, which amortizes to constant time (provided your hash function distributes keys uniformly and collisions remain low).

**2. How Contains Works for ICollection Types in .NET**
***2.1. Contains in General***

    ICollection<T>.Contains(T item) is just a method signature that different collections implement differently.
    For List<T> or basic ICollection<T> implementations, Contains might indeed be O(n) because it iterates internally until it finds a match.
    For Dictionary<TKey, TValue>.KeyCollection, the Contains method is typically short-handed to Dictionary<TKey, TValue>.ContainsKey(item) behind the scenes.

***2.2. Contains in Dictionary’s KeyCollection***

    If you call complements.Keys.Contains(neededNumber), it typically delegates to the dictionary’s internal hashing logic, which:
        Computes the hash code for neededNumber.
        Determines which bucket the neededNumber might be in.
        Checks for equality in that bucket’s chain (or slot).
    This approach is amortized O(1) because, on average, you do a constant amount of work to find the correct bucket and confirm a match.
    In pathological cases where many keys collide, you could degrade to O(n). However, for a good hash function and capacity management, collisions remain rare, making the average cost still O(1).

Hence, even though Keys returns a KeyCollection, it isn’t doing a naive iteration of all keys to see if something exists. Under the covers, it typically performs the same hashing-based membership test as ContainsKey.
