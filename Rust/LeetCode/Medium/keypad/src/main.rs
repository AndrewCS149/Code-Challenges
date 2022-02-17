use std::{collections::HashMap, str::Chars};

// https://leetcode.com/problems/letter-combinations-of-a-phone-number/submissions/
fn main() {
    let mut map: HashMap<&str, &str> = HashMap::new();
    map.insert("2", "abc");
    map.insert("3", "def");
    map.insert("4", "ghi");
    map.insert("5", "jkl");
    map.insert("6", "mno");
    map.insert("7", "pqrs");
    map.insert("8", "tuv");
    map.insert("9", "wxyz");

    let wrd = "hello";
    let arr = wrd.chars();
}

fn combinations(digits: &str) -> Vec<String> {
    let mut result = vec![];

    let mut map: HashMap<&str, &str> = HashMap::new();
    map.insert("2", "abc");
    map.insert("3", "def");
    map.insert("4", "ghi");
    map.insert("5", "jkl");
    map.insert("6", "mno");
    map.insert("7", "pqrs");
    map.insert("8", "tuv");
    map.insert("9", "wxyz");

    let mut idx = 0;
    backtrack(
        digits.chars().collect(),
        &mut result,
        &mut String::from(""),
        &mut idx,
        map,
    );

    result
}

fn backtrack(
    digits: Vec<char>,
    result: &mut Vec<String>,
    current: &mut String,
    idx: &mut i32,
    map: HashMap<&str, &str>,
) {
}
