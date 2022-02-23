fn main() {
    let test = [1, 2, 3, -4, -5];
    let res = invert(&test);
    for num in res {
        println!("{}", num);
    }
}

fn invert(values: &[i32]) -> Vec<i32> {
    let mut res = vec![];

    for num in values {
        res.push(-num);
    }

    res
}
