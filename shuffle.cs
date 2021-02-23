public class Solution {
    
    // Shuffle takes in an array organized x x x y y y
    //returns array xy xy xy
    //nums : integer array 
    //xyArray is returned
    public int[] Shuffle(int[] nums, int n) {
        
        //built array lenth of nums to make our xy pairs
        int[]xyArray = new int[nums.Length];
        
        int curr = 0;
        //loop through lenth of nums, and build  x y or xyArray
        //TODO : can't do odd index
        for (int i = 0; i < nums.Length / 2; i++){
            //check even index
                xyArray[curr] = nums[i];
                curr++;
                xyArray[curr] = nums[i + n];
                curr++;

        }//end for lenght of nums
        
        return xyArray;
    }//end of shuffle
}//end of solution
