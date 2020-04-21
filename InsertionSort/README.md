# Insertion Sort

### Step Through of Psuedo code

* We are creating a function that takes in an array of integers, and returns the same array but sorted smallest to largest.

* The psuedo code has a `while loop` nested inside of a `for loop`.

* It is assigning i a value of 1, and saying to iterate over the `while loop` for as long as i is less than the length of the array.
    * `for (int i = 1; i < arr.Length; i++)`

* Inside the `for loop`, but outside the `while`, it is assigning an integer of j to i - 1. We are also assigning an integer of time the location of i in the array.
    * `int j = i -1;`
    * `int temp = arr[i];`

* The above two integers are then passed into the nested `while loop` to iterate as long as j is less than or equal to 0, *AND* temp is less than the array at index j.
    * `while (j >= 0 && temp < arr[j])`

* Inside the `while loop` we are redefining `arr[j]` to be equal to `arr[j + 1]` and then decrementing j by 1 for every iteration.
    * `arr[j + 1] = arr[j]:`
    * `j -= 1;`

* Outside of the `while loop`, but still inside of the `for loop`; we will assign `arr[j+1]` to the temp integer.

* So in the first iteration, i will be 1, j will be 0 (i - 1) and the temp will be 4 (index postion 1). Since j = 0, `arr[j + 1] j -= 1` is equal to 8 which is index 0. We then increase `arr[j+1]` to be index position 1, which is 4, which assigns the value of 4 to the temp, index i is then incremented in the for loop which increases the index values by 1 the entire way through the loops.

* At this point `i = 2`, `j = i - 1`, so `j = 1` and temp is equal to the value at index of i, which is 2, so the third value, which is 23. The value of j is index 1, which is 4 and the value of temp is 23. Since 23 is not less than 4, the while loop does not happen. The value of `arr[j + 1]` is assigned to temp, which keeps temp at 23.

* This cycle will continue until the array is sorted with the lowest values starting at index 0.