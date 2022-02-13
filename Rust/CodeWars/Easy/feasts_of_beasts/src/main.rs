// https://www.codewars.com/kata/5aa736a455f906981800360d

fn main() {}

fn feast(beast: &str, dish: &str) -> bool {
    return beast.chars().nth(0) == dish.chars().nth(0)
        && beast.chars().nth(beast.len() - 1) == dish.chars().nth(dish.len() - 1);
}
