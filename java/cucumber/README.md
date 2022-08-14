# Java cucumber

A minimal setup with Java [Cucumber](https://cucumber.io/docs/guides/10-minute-tutorial/) to get you started.

You can use [maven](https://maven.apache.org/)

## Setup

    git clone https://github.com/swkBerlin/kata-bootstraps
    cd java/cucumber

Open as preexisting project in your favorite IDE.

## Running Tests

To execute the tests run `mvn integration-test` or run the tests from the IDE you are using

## Running with docker compose

With this method you don't have to install java on your computer. 
The tests will be run inside a docker container.
It may be slower to run than having a real Jdk installed on your machine.

Prerequisites : install a recent version on docker.
At first, the docker image and the maven dependencies wil download.
Then, when running again, it will be fast to run.

```shell
# Run with java 8
docker compose run java8
# Run with java 11
docker compose run java11
# Run with java 17
docker compose run java17
# Run with java 18
docker compose run java18
```

## IDEA hint

in order to display scenario outline steps correctly: ![](docs/feature_steps.png)

use **IDEA >= 2019.3** and click on the feature files, or the package with in **src/test/resources** to run all features

![](docs/run_all_features.png)

## Test Libraries Available from the Get-Go

- [Cucumber 5.1.2](https://github.com/cucumber/cucumber-jvm/tree/v5.1.2)

This repo was tested with idea, if you encounter problems please open an issue or send a pull request.

Have fun!
