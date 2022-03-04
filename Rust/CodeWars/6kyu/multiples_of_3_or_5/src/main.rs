// https://www.codewars.com/kata/514b92a657cdc65150000006/train/rust

fn main() {
    println!("Hello, world!");
}

fn solution(num: i32) -> i32 {
    // my solution
    // let mut sum = 0;

    // for i in 1..num {
    //     if i % 3 == 0 || i % 5 == 0 {
    //         sum += i;
    //     }
    // }

    // sum

    // online solution
    (1..num).filter(|x| x % 3 == 0 || x % 5 == 0).sum()
}
