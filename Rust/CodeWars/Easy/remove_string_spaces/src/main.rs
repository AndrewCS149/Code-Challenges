// https://www.codewars.com/kata/57eae20f5500ad98e50002c5/train/rust

fn main() {
    let test = " hello all ".to_string();
    println!("{}", no_space(test));
}

fn no_space(x: String) -> String {
    // let mut res = "".to_string();

    // for c in x.chars() {
    //     if c != ' ' {
    //         res.push(c);
    //     }
    // }

    // res

    x.replace(" ", "")
}
