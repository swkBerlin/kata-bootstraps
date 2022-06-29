public struct Speaker {
    public let text: String

    public init(text: String = "Default text") {
        self.text = text
    }

    public func saySomething() -> String {
        text
    }
}
