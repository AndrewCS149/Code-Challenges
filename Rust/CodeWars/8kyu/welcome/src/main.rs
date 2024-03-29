/// https://www.codewars.com/kata/577ff15ad648a14b780000e7/train/rust

fn main() {
    println!("Test";)
}

fn greet(language: &str -> &str) {
    match language {
        "english" => "Welcome",
        "czech" => "Vitejte",
        "danish" => "Velkomst",
        "dutch" => "Welkom",
        "estonian" => "Tere tulemast",
        "finnish" => "Tervetuloa",
        "flemish" => "Welgekomen",
        "french" => "Bienvenue",
        "german" => "Willkommen",
        "irish" => "Failte",
        "italian" => "Benvenuto",
        "latvian" => "Gaidits",
        "lithuanian" => "Laukiamas",
        "polish" => "Witamy",
        "spanish" => "Bienvenido",
        "swedish" => "Valkommen",
        "welsh" => "Croeso",
        "english" | _ => "Welcome"
    }
}
