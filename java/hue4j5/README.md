# Java JUnit5


Minimal setup for [hue4junit](https://github.com/mklose/hue4junit) which uses [Philips hue lights](https://www2.meethue.com/en-us/starter-kits) to indicate [JUnit5](https://junit.org/junit5/) test run results by turning light bulbs green or red.

You can use [gradle](https://gradle.org/) or [maven](https://maven.apache.org/)

## Setup

    git clone https://github.com/swkBerlin/kata-bootstraps
    cd java/hue4j5

    **NEED TO SETUP HUE**

    use [this link](http://htmlpreview.github.io/?https://github.com/mklose/hue4junit/blob/master/setup_hue.html) to get a _hue.client_ (long token)
    and set it in _pom.xml_ and/or _build.gradle_

Open as preexisting project in your favorite IDE and choose between gradle or maven nature

## Running Tests

To execute the tests either run `gradle test`, `mvn test` or run the tests from the IDE you are using

## Test Libraries Available from the Get-Go
- JUnit 5.3.2
- hue4junit 0.1.0-SNAPSHOT

This repo was tested with eclipse and idea, if you encounter problems please open a issue or send a pull request.

Have fun!
