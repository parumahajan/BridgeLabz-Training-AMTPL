/*

** MERGE SORT **

It is a Recursion-based algorithm.

We use it to sort a linear structure like Array, Vector in Increasing/Decreasing order.
 
It follows Divide and Conquer approach.

-> We divide our array into two parts, and we try to find its Mid.

mid = s + (e-s)/2
// This prevents integer overflow error.

-> We keep Repeating this breaking down process Recursively, till we have Individual elements each.

-> Now, we Merge these individual elements based to create a Sorted array using Backtracking.
-------------------------------------------
* APRROACH:

STEP 1 - DIVIDING (BREAKING)

mergeSort(arr[], start, end)

Our loop will traverse till: (s<e)

first half of array -> s - mid
-> mergeSort(arr[], s, mid)

second half of array -> mid+1 - e
-> mergeSort(arr[], mid+1, e)
-------------------------------------------
* PSEUDO-CODE:

void mergeSort(vector<int> &arr, int s, int e){
// we pass our array as reference so that all the changes reflect inside our array.

    if(s<e){

        int mid = s + (e-s)/2;
 
        mergeSort(arr[], s, mid);
        mergeSort(arr[], mid+1, e);

        merge(arr[], s, mid, e);
    }
}
-------------------------------------------
The moment: (s == e), that means, its the individual element.

Till here, we just broke (divided) the array to individual elements.

Now, we will merge them.
-------------------------------------------
STEP 2 - MERGING (CONQUER)

Here, we will merge two sorted halves, which we gained through merging the individual elements.

* APPROACH:

We will create 2 pointers: i, j
and a temporary memory: temp

i = s;
j = mid+1;

We'll compare the values of i and j, and see which one is lesser.

The lesser value will be stored in the temp array.

if(i<j) --> i++
if(i>j) --> j++

The moment any one of these reaches its limit, automatically the remaining element is stored as the last element of the sorted array.  
-------------------------------------------
* PSEUDO-CODE:

void merge(vector<int> &arr, int s, int mid, int e){
    vector <int> temp;

    i = s;
    j = mid + 1;
    
    while(i <= mid && j <= e){

        if(arr[i] <= arr[j]){
            temp.push_back(arr[i]);
            i++;
        }

        else{
            temp.push_back(arr[j]);
            j++;
        }
    }
}

// For remaining elts in left half
        while(i <= mid){
            temp.pushback(arr[i]);
            i++;
        }

// For remaining elts in right half
        while(j <= e){
            temp.pushback(arr[j]);
            j++;
        }

// for merging the 2 sorted arrays:

for(int index = 0; index < temp.size(); index++){
    arr[index + s] = temp[index];
-------------------------------------------
1) fns will be static.
2) use list<int> arr.
3) instead of using 'size' method, use ".Count"

 
*/