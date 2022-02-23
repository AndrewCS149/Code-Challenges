// https://www.codewars.com/kata/5a00e05cc374cb34d100000d/train/rust

fn main() {
    let res = reverse_seq(5);

    for n in res {
        println!("{}", n);
    }
}

fn reverse_seq(n: u32) -> Vec<u32> {
    // let mut res = vec![];
    // for num in (1..=n).rev() {
    // 	res.push(num);
    // }

    // res
    (1..=n).rev().collect()
}
