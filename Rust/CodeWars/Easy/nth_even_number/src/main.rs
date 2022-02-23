// https://www.codewars.com/kata/5933a1f8552bc2750a0000ed/train/rust
fn main() {
    println!("{}", nth_even(1));
    println!("{}", nth_even(3));
    println!("{}", nth_even(100));
    println!("{}", nth_even(200));
    println!("{}", nth_even(500));

    println!("{}", nth_even(1298734));
}

fn nth_even(n: u32) -> u32 {
    n * 2 - 2

    // let mut res = 0;

    // let mut i = 1;
    // loop {
    //     if i == n {
    //         break;
    //     }

    //     res += 2;
    //     i += 1;
    // }

    // res
}
