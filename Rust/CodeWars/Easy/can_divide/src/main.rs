// https://www.codewars.com/kata/5a2b703dc5e2845c0900005a/train/rust

fn main() {
	let result = is_divide_by(-12, 2, -6);
	println!("{}", result);
}

fn is_divide_by(number: i32, a: i32, b: i32) -> bool {
	number % a == 0 && number % b == 0
}
