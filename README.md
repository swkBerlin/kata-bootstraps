# kata-bootstraps

[![csharp-ci-badge]][ci-actions]
[![go-ci-badge]][ci-actions]
[![java-ci-badge]][ci-actions]
[![js-ci-badge]][ci-actions]
[![php-ci-badge]][ci-actions]
[![python-ci-badge]][ci-actions]
[![rust-ci-badge]][ci-actions]
[![ruby-ci-badge]][ci-actions]
[![scala-ci-badge]][ci-actions]
[![ts-ci-badge]][ci-actions]



Empty projects for e.g. Katas with testing support in different languages
(usually with a failing test, in order to know where to start)

On the top level you can find different languages that are supported.

On the second level (in a particular language's directory) you'll find
different testing frameworks that are supported.

In each directory for a particular framework, there is always a `README.md` file
that contains various useful information. At minimum it contains the
information on how to install the dependencies and run the tests.

You are welcome to contribute by submitting likewise a min setup for your language or framework of choice with a pull request. If possible please also create a [github workflow](https://docs.github.com/en/actions/concepts/workflows-and-actions/workflows).

----
[Cookiecutter](https://github.com/audreyr/cookiecutter) has a similar goal and also supports multiple languages for setting up a bare project.

[csharp-ci-badge]:../../../kata-bootstraps/workflows/C%23%20CI/badge.svg "CI build status"
[go-ci-badge]:../../../kata-bootstraps/workflows/GO%20CI/badge.svg "CI build status"
[java-ci-badge]:../../../kata-bootstraps/workflows/Java%20CI/badge.svg "CI build status"
[js-ci-badge]:../../../kata-bootstraps/workflows/js%20CI/badge.svg "CI build status"
[php-ci-badge]:../../../kata-bootstraps/workflows/PHP%20CI/badge.svg "CI build status"
[python-ci-badge]:../../../kata-bootstraps/workflows/Python%20CI/badge.svg "CI build status"
[rust-ci-badge]:../../../kata-bootstraps/workflows/Rust%20CI/badge.svg "CI build status"
[ruby-ci-badge]:../../../kata-bootstraps/workflows/Ruby%20CI/badge.svg "CI build status"
[scala-ci-badge]:../../../kata-bootstraps/workflows/Scala%20CI/badge.svg "CI build status"
[ts-ci-badge]:../../../kata-bootstraps/workflows/ts%20CI/badge.svg "CI build status"
[ci-actions]:../../../kata-bootstraps/actions
