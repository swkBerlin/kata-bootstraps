import spock.lang.Specification
import spock.lang.Unroll

class HelloWorldTest extends Specification {
    private ClockService clock
    private HelloWorld sut

    @SuppressWarnings('unused')
    // false positive from IntelliJ for some reason
    def setup() {
        // setup method necessary for dependency injection
        clock = Mock(ClockService)
        sut = new HelloWorld(clock)
    }

    @Unroll
    def "greets the specified person #name with #expected"() {
        when: "person is greeted"
        def result = sut.sayHelloTo(name)

        then: "expected greeting is returned"
        result == expected

        where:
        name    | expected
        "Chris" | "Hello, Chris!"
        "World" | "Hello, World!"
    }

    def "fails on empty name"() {
        when: "person is greeted without a name"
        sut.sayHelloTo("")

        then: "exception is thrown"
        def exception = thrown(IllegalArgumentException)
        exception.message == "name must not be empty."
    }

    def "greets with a timestamp"() {
        given: "a name"
        def name = "Timetester"
        and: "some point in time"
        def time = "my time"

        when: "person is greeted with a time spec"
        def result = sut.sayHelloWithTimeTo(name)

        then: "expected greeting is returned"
        result == "Hello, Timetester! The time is $time."
        and: "time was retrieved from the clock"
        1 * clock.formattedTime() >> time
    }
}
