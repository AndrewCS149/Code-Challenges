// https://www.codewars.com/kata/57f781872e3d8ca2a000007e/train/rust

fn main() {
    println!("Hello, world!");
}

fn maps(values: &Vec<i32>) -> Vec<i32> {
    values.iter().map(|n| n * 2).collect()
}
