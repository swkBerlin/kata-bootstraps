# Java hue4junit


Minimal setup for [hue4junit](https://github.com/mklose/hue4junit) which uses [Philips hue lights](https://www2.meethue.com/en-us/starter-kits) to indicate [JUnit5](https://junit.org/junit5/) test run results by turning light bulbs green or red.

You can use [gradle](https://gradle.org/) or [maven](https://maven.apache.org/)

## Setup

```
    git clone https://github.com/swkBerlin/kata-bootstraps
    cd java/hue4j5
```

### Setup Hue
open [setup_hue.html](http://htmlpreview.github.io/?https://github.com/mklose/hue4junit/blob/master/setup_hue.html) and use returned value of __username__ as `hue.username` (you will need to press the button on your hue bridge).

`hue.username` will be retrieved in this order from :

 1. [src/test/resources/hue4junit.properties](src/test/resources/hue4junit.properties) 
 1. [hue4junit.properties](hue4junit.properties) in the project folder
 1. system property
 
    which can be set also in  
    
    `pom.xml` or `build.gradle` 

## Running Tests

To execute the tests either run `./gradlew test`, `mvn test` or run the tests from the IDE you are using

## Test Libraries Available from the Get-Go
- JUnit 5.5.2
- hue4junit 0.2.0
- AssertJ 3.14.0

This repo was tested with eclipse and idea, if you encounter problems please open a issue or send a pull request.

Have fun!

