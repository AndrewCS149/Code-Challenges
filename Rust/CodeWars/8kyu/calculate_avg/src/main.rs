//https://www.codewars.com/kata/57a2013acf1fa5bfc4000921/train/rust

fn main() {
    let test = [
        17.0, 16.0, 16.0, 16.0, 16.0, 15.0, 17.0, 17.0, 15.0, 5.0, 17.0, 17.0, 16.0,
    ];

    let test_2: [f64; 0] = [];

    let result = find_average(&test);
    let result_2 = find_average(&test_2);

    println!("{}", result);
    println!("{}", result_2);
}

fn find_average(slice: &[f64]) -> f64 {
    let mut sum = 0.0;

    if slice.len() == 0 {
        return sum;
    }

    for num in slice {
        sum += num;
    }

    sum / (slice.len() as f64)
}
