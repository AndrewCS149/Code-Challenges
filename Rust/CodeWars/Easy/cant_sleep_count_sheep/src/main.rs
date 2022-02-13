// https://www.codewars.com/kata/5b077ebdaf15be5c7f000077/rust

fn main() {
    let result = count_sheep(0);

    println!("{}", result);
}

fn count_sheep(u: i32) -> String {
    let mut result = String::from("");
    for i in 1..u + 1 {
        result.push_str(&i.to_string());
        result.push_str(" sheep...");
    }

    return result;
}
