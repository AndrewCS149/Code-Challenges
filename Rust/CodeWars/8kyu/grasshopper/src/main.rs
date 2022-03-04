// https://www.codewars.com/kata/586c1cf4b98de0399300001d/train/rust

fn main() {
    println!("Hello, world!");
}

fn combat(health: f32, damage: f32) -> f32 {
    let mut new_health = health - damage;

    if new_health < 0. {
        new_health = 0.
    }

    new_health
}
