// https://www.codewars.com/kata/57d814e4950d8489720008db/train/rust

fn main() {
    println!("Hello, world!");
}

fn index(nums: &[u64], n: usize) -> Option<u64> {
    // my solution:
    // if n >= nums.len() {
    //     None
    // } else {
    //     Some(nums[n].pow(n as u32))
    // }

    // online:
    nums.get(n).map(|x| x.pow(n as u32))
}
