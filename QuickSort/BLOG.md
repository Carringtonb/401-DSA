# Quick Sort

## QuickSort
* We are creating method that will take in 3 parameters. An array of integers and two integer values defined as `left` and `right`. If the left value is smaller than the right, then we will call our partition method and recursively run this method until the array is sorted low-high.

* The sorted array will be returned once the left value is not less than the right.

## Partition
* This is the meat and potatoes of this DSA.
* This method will take in the same three parameters as the QuickSort method.
* Since this method is only called when the right integer is greater than the left, we know the right value is larger than left.
* We will assign this value to a new integer named `pivot`.
* We will then assign a new integer named `low` to be the one number less than the left integer that is passed in.
* As long as the `left` value is less than the `right`, we will check to see if the array at `left` is less than or equal to array at `right`; which is our `pivot`. When this happens we increment `low`.
* We then call our swap method and pass in `array`, `i`, and `low`.
* Once the `left` value is no longer smaller than the `right`, we will call our swap method again but pass in `array`, `right`, and `low + 1`.

## Swap
* Swap will take in 3 parameters, `array`, `i`, and `low`.
* We will define a new integer to be a temporary value holder, `temp`, and assign it to the integer of `i`.
* We then use this method to switch the values of `i` and `low`.

### Overview

* Essentially these methods work to take in an array, partition the array to move value smaller than the pivot the the left, and larger than the pivot to the right or the pivot value and return the lowest value. The quicksort method recursively calls itself and continues to run partition and then swap those values until the array is sorted low-high.
