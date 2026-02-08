using Maximum_Subarray;


var task = new Solution();
Console.WriteLine(task.MaxSubArray(nums: [-2,1,-3,4,-1,2,1,-5,4]));
Console.WriteLine(task.MaxSubArray(nums: [1]));
Console.WriteLine(task.MaxSubArray(nums: [5,4,-1,7,8]));

task = new AlternativeSolution();
Console.WriteLine(task.MaxSubArray(nums: [-2,1,-3,4,-1,2,1,-5,4]));
Console.WriteLine(task.MaxSubArray(nums: [1]));
Console.WriteLine(task.MaxSubArray(nums: [5,4,-1,7,8]));
