using Minimum_Size_Subarray_Sum;

var task = new Solution();
Console.WriteLine(task.MinSubArrayLen(target: 7, nums: [2,3,1,2,4,3]));
Console.WriteLine(task.MinSubArrayLen(target: 4, nums: [1,4,4]));
Console.WriteLine(task.MinSubArrayLen(target: 11, nums: [1,1,1,1,1,1,1,1]));

task = new AlternativeSolution();
Console.WriteLine(task.MinSubArrayLen(target: 7, nums: [2,3,1,2,4,3]));
Console.WriteLine(task.MinSubArrayLen(target: 4, nums: [1,4,4]));
Console.WriteLine(task.MinSubArrayLen(target: 11, nums: [1,1,1,1,1,1,1,1]));
