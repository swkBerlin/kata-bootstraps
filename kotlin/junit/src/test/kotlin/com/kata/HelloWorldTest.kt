package com.kata

import org.junit.jupiter.api.*
import org.junit.jupiter.api.Assertions.*

internal class HelloWorldTest {

    @Test fun greeting() {
        assertEquals("Hello World", HelloWorld().greeting())
    }
}