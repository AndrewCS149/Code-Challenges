// https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097/solutions/rust

fn main() {
    println!("{}", century(111));
}

fn century(year: u32) -> u32 {
    let result = year as f64 / 100.;
    return result.ceil() as u32;
}
