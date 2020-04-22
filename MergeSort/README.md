# MergeSort

* `ALGORITHM Mergesort(arr)`
    `DECLARE n <-- arr.length`
           
   ` if n > 1`
    `  DECLARE mid <-- n/2`
    `  DECLARE left <-- arr[0...mid]`
      `DECLARE right <-- arr[mid...n]`
    `  // sort the left side`
    `  Mergesort(left)`
    `  // sort the right side`
     ` Mergesort(right)`
     ` // merge the sorted left and right sides together`
     ` Merge(left, right, arr)`

`ALGORITHM Merge(left, right, arr)`
    `DECLARE i <-- 0`
   ` DECLARE j <-- 0`
   ` DECLARE k <-- 0`

   ` while i < left.length && j < right.length`
       ` if left[i] <= right[j]`
          `  arr[k] <-- left[i]`
           ` i <-- i + 1`
       ` else`
            `arr[k] <-- right[j]`
           ` j <-- j + 1`   
      `  k <-- k + 1`
    `if i = left.length`
      ` set remaining entries in arr to remaining values in right`
  `  else`
      ` set remaining entries in arr to remaining values in left`

### MergeSort

* As long as the length of the array is larger than 1, split the the array into two new arrays based on the middle value, which is found by dividing the length by 2.
* Iterate through the original array and put values lower in index than the mid into the new left array, put values higher in index into the new right array.
* Run the merge method on the three arrays in the order of left, right, original. Return the array.

### Merge

* Create method with parameters of three arrays of integers; left, right, and original.
* Create three integers i,j,k, all equal to 0.
* As long as integers *i* and *j* are smaller than the lengths of the arrays - 
    * check the value at the current index of left array against the current index of the right array. If left is smaller or equal, assign the value of array *i* to the original array at current index and increment *i* array.
    * If the value in the left array is larger than in the right array, assign the value of the original array to the index of *j* and increment *j*.
    * We then increment integer *k* by 1.
    * If the index of *i* is equal to the length of the left array the value at the array *j* index will be assigned to the original array as long as *j* is less than the right arrays length. Both integer *i* and *j* will be incremented.
    * If the index of *i* is less than the length of the left array the value at the array *i* index will be assigned to the original array as long as *i* is less than the left arrays length. Both integer *i* and *j* will be incremented.