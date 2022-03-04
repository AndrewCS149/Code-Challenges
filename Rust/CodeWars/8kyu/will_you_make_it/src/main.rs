//https://www.codewars.com/kata/5861d28f124b35723e00005e/train/rust

fn main() {
    println!("{}", zero_fuel(100, 50, 1))
}

fn zero_fuel(distance_to_pump: u32, mpg: u32, gallons: u32) -> bool {
    mpg * gallons >= distance_to_pump
}
