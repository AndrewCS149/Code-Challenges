use std::collections::HashMap;

/*
Write a program that takes a phone number as input and prints out all the letter
combinations corresponding to that number. For example, if 227-8255 is the input, one of
the printed combinations will be "CAR-TALK"
*/

fn main() {
    letter_combos("1(815)-995-2241");
}

pub fn letter_combos(digits: &str) {
    let key_map = HashMap::from([
        (2, "abc"),
        (3, "def"),
        (4, "ghi"),
        (5, "jkl"),
        (6, "mno"),
        (7, "pqrs"),
        (8, "tuv"),
        (9, "wxyz"),
    ]);

    let idx = 0;
    letter_combos_recurse(&digits, &key_map, idx, String::from(""));
}

pub fn letter_combos_recurse(
    digits: &str,
    key_map: &HashMap<u8, &str>,
    mut idx: u8,
    mut cur_str: String,
) {
    if cur_str.len() == digits.len() {
        println!("{}", cur_str);
        return;
    }

    let valid_keys = ['2', '3', '4', '5', '6', '7', '8', '9'];
    let mut key = digits.chars().nth(idx as usize).unwrap();

    while !valid_keys.contains(&key) {
        cur_str.push(key);
        idx += 1;

        if cur_str.len() == digits.len() {
            println!("{}", cur_str);
            return;
        }

        key = digits.chars().nth(idx as usize).unwrap();
    }

    let cur_keys = key_map[&(key as u8 - '0' as u8)];
    let cur_keys: Vec<char> = cur_keys.chars().collect();

    for i in 0..cur_keys.len() {
        let mut tmp = cur_str.clone();
        tmp.push(cur_keys[i]);

        letter_combos_recurse(digits, key_map, idx + 1, tmp);
    }
}
