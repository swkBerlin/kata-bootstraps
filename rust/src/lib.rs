#[allow(dead_code)]
fn say_hello() -> &'static str {
    "not implemented"
}

#[cfg(test)]
mod tests {
    use super::say_hello;

    #[test]
    fn test_say_hello() {
        assert!("hello" == say_hello());
    }

    #[test]
    fn test_should_not_fail() {
        assert!("ok" == "ok");
    }
}
