import XCTest
@testable import Kata

final class SpeakerTests: XCTestCase {
    private var speaker = Speaker()

    override func setUpWithError() throws {
        speaker = Speaker()
    }

    func testSaySaySomething() throws {
        XCTAssertEqual(speaker.saySomething(), "Hello?")
    }

    func testTextValueInSaySomething() throws {
        XCTAssertEqual(speaker.saySomething(), speaker.text)
    }

    func testDefaultText() throws {
        speaker = Speaker()

        XCTAssertEqual(speaker.text, "Default text")
    }
}
