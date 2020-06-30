class HelloWorld(private val clock: ClockService) {
    fun sayHelloTo(name: String) =
        require(name.isNotEmpty()) { "name must not be empty." }
            .let { "Hello, $name!" }

    fun sayHelloWithTimeTo(name: String) =
        "${sayHelloTo(name)} The time is ${clock.formattedTime()}."
}
