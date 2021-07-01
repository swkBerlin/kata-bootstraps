# kata-bootstraps

This is a collection of testing setups for katas in different programming languages. The goal is, to make it easy for everyone to try katas in different languages.

| Language | Testing framework | README | Succeeding Test | Failing Test | CI check                         | Property-based testing | Test doubles | ... |
|----------|-------------------|--------|-----------------|--------------|----------------------------------|------------------------|--------------|-----|
| Java     | Assert_j          | ✔️      |                 |              | [![java-ci-badge]][ci-actions]   |                        |              |     |
|          | Cucumber          | ✔️      |                 |              |                                  |                        |              |     |
| PHP      |                   | ✔️      |                 |              | [![php-ci-badge]][ci-actions]    |                        |              |     |
| Rust     |                   | ✔️      |                 |              | [![rust-ci-badge]][ci-actions]   |                        |              |     |
| Python   |                   | ✔️      |                 |              | [![python-ci-badge]][ci-actions] |                        |              |     |
| Scala    |                   | ✔️      |                 |              | [![scala-ci-badge]][ci-actions]  |                        |              |     |
| JS       |                   | ✔️      | ✔️               | ❌            | [![js-ci-badge]][ci-actions]     | ❌                      |              |     |
| TS       |                   | ✔️      |                 |              | [![ts-ci-badge]][ci-actions]     |                        |              |     |
| Go       |                   | ✔️      |                 |              | [![go-ci-badge]][ci-actions]     |                        |              |     |

## Features

The following features are available per language (see table above):

### README

In each directory for a particular framework, there is always `README.md` file
that contains various useful information. At minimum it contains the
information on how to install the dependencies and run the tests.

### Succeeding test

### Failing test

### Automatic CI check

### Property based testing framework

### Test doubles

???

### ...

## Contributing

You are welcome to contribute by submitting likewise a min setup for your language or framework of choice with a pull request. Please add it to the table above. We require README, a succeeding test and CI setup that confirms the succeding test as a minimum, but are happy for any additional features. You can also add missing features to existing languages. Please look into one of the languages with many checkmarks in the table above as an example first.

----
[Cookiecutter](https://github.com/audreyr/cookiecutter) has a similar goal and also supports multiple languages for setting up a bare project.

[java-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/Java%20CI/badge.svg "CI build status"
[php-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/PHP%20CI/badge.svg "CI build status"
[rust-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/Rust%20CI/badge.svg "CI build status"
[python-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/Python%20CI/badge.svg "CI build status"
[scala-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/Scala%20CI/badge.svg "CI build status"
[js-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/js%20CI/badge.svg "CI build status"
[ts-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/ts%20CI/badge.svg "CI build status"
[go-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/GO%20CI/badge.svg "CI build status"
