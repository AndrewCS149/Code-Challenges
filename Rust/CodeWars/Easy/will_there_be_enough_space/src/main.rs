// https://www.codewars.com/kata/5875b200d520904a04000003/train/rust
fn main() {
    println!("Hello, world!");
}

fn enough(cap: i32, on: i32, wait: i32) -> i32 {
    let left = wait - (cap - on);

    if left <= 0 {
        return 0;
    } else {
        return left;
    }
}
