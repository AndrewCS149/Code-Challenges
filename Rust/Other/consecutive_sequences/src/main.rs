// Technical Interview Question: Consecutive Count

//// CHALLENGE

// Write a function that takes in two inputs: 1. A list ('data'), and 2. An Integer ('N') and returns a count representing the number of times the target repetition length is detected in the input data list. A target repetition of 'N' is achieved if there are N consecutive values that are identical in the input data list. Also note, that a single sequence can include 'overlaps', meaning you can reuse items from one repetition sequence in another. See the example below...

//// EXAMPLE

// Sample Input:
// 1. data = ['D', 'G', 'C', 'C', 'C', 'C', 'E', 'E', 'E', 'G', 'B', 'B', 'B', 'B', 'B', 'B', 'D', 'G', 'G', 'G']
// 2. target repetition length (N) = 4

// Expected Output: 4 ... because there is a consecutive sequence of ['C', 'C', 'C', 'C'], and three unique consecutive sequences of ['B', 'B', 'B', 'B'] in the input data

fn main() {
    let arr = [
        'D', 'G', 'C', 'C', 'C', 'C', 'E', 'E', 'E', 'G', 'B', 'B', 'B', 'B', 'B', 'B', 'D', 'G',
        'G', 'G',
    ];
    let answer = sequences(&arr, 4);
    println!("{}", answer);
}

fn sequences(data: &[char], target: u32) -> u32 {
    let mut result = 0;
    let mut counter = 1;
    let mut tmp = data.first().unwrap();
    let mut cur_idx = 0;

    for mut i in 1..data.len() {
        if counter == target {
            counter = 1;
            result += 1;
        }

        if tmp == &data[i] {
            counter += 1;
        } else {
            // tmp = &data[i];
            tmp = &data[cur_idx + 1];
            i = cur_idx + 1;
            cur_idx = i;
        }
    }

    result
}
