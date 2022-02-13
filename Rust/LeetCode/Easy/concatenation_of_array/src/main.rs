// https://leetcode.com/problems/concatenation-of-array/

fn main() {
    let test = vec![1, 2, 1, 1];
    get_concatenation(test);
}

pub fn get_concatenation(nums: Vec<i32>) -> Vec<i32> {
    let mut result: Vec<i32> = Vec::new();

    for num in nums.iter() {
        result.push(*num);
    }

    for num in nums.iter() {
        result.push(*num);
    }

    return result;
}
