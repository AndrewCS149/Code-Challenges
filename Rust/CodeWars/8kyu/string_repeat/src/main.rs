// https://www.codewars.com/kata/57a0e5c372292dd76d000d7e/train/rust

fn main() {
    println!("{}", repeat_str("hello", 4));
}

fn repeat_str(src: &str, count: usize) -> String {
    // my way
    // let mut res = String::from("");

    // for i in 0..count {
    //     res.push_str(src);
    // }

    // res

    // online solution:
    src.repeat(count)
}
