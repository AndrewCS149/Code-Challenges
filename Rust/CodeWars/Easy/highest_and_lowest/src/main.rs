// https://www.codewars.com/kata/554b4ac871d6813a03000035/solutions/rust

fn main() {
    let mut nums = "8 3 -5 42 -1 0 0 -9 4 7 4 -4";
    println!("{}", high_and_low(nums));
}

fn high_and_low(numbers: &str) -> String {
    let arr: Vec<i32> = numbers
        .split(" ")
        .into_iter()
        .map(|x| x.parse().unwrap())
        .collect();

    format!(
        "{} {}",
        arr.iter().max().unwrap(),
        arr.iter().min().unwrap()
    )
}
