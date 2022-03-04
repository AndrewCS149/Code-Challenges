// https://www.codewars.com/kata/5ce9c1000bab0b001134f5af/solutions/rust

fn main() {}

fn quarter_of(month: u8) -> u8 {
    match month {
        1..=3 => return 1,
        4..=6 => return 2,
        7..=9 => return 3,
        _ => 4,
    }
}
