// https://www.codewars.com/kata/5c8bfa44b9d1192e1ebd3d15

fn main() {
    let test = [
        "sheep", "sheep", "sheep", "sheep", "sheep", "wolf", "sheep", "sheep",
    ];

    let result = warn_the_sheep(&test);
    println!("{}", result);
}

fn warn_the_sheep(queue: &[&str]) -> String {
    let mut result = String::from("");
    let mut i = 1;

    for sheep in queue {
        if sheep == &"wolf" && i == queue.len() {
            result.push_str("Pls go away and stop eating my sheep");
            break;
        } else if sheep == &"wolf" {
            let i = queue.len() - i;
            result.push_str(&format!(
                "Oi! Sheep number {i}! You are about to be eaten by a wolf!"
            ));
            break;
        }

        i += 1;
    }

    return result;
}
