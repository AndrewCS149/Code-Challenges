// https://www.codewars.com/kata/57f780909f7e8e3183000078/train/rust

fn main() {
    let test = vec![1, 2, 3, 4];
    let res = grow(test);
    println!("{}", res);
}

fn grow(nums: Vec<i32>) -> i32 {
    nums.iter().product()
}
