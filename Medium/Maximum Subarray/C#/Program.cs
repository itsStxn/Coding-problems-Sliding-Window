using Maximum_Subarray;

var task = new Solution();

Console.WriteLine(task.MaxSubArray(nums: [-2,1,-3,4,-1,2,1,-5,4]));
Console.WriteLine(task.MaxSubArray(nums: [1]));
Console.WriteLine(task.MaxSubArray(nums: [5,4,-1,7,8]));

Console.WriteLine(task.MaxSubArray_DivideAndConq(nums: [-2,1,-3,4,-1,2,1,-5,4]));
Console.WriteLine(task.MaxSubArray_DivideAndConq(nums: [1]));
Console.WriteLine(task.MaxSubArray_DivideAndConq(nums: [5,4,-1,7,8]));
