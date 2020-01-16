# kata-bootstraps

[![GitSpo Mentions](https://gitspo.com/badges/mentions/swkBerlin/kata-bootstraps?style=flat-square)](https://gitspo.com/mentions/swkBerlin/kata-bootstraps)
[![java-ci-badge]][ci-actions]
[![php-ci-badge]][ci-actions]
[![rust-ci-badge]][ci-actions]
[![python-ci-badge]][ci-actions]
[![scala-ci-badge]][ci-actions]


Empty projects for e.g. Katas with testing support in different languages
(usually with a failing test, in order to know where to start)

On the top level you can find different languages that are supported.

On the second level (in a particular language's directory) you'll find
different testing frameworks that are supported.

In each directory for a particular framework, there is always `README.md` file
that contains various useful information. At minimum it contains the
information on how to install the dependencies and run the tests.

You are welcome to contribute by submitting likewise a min setup for your language or framework of choice with a pull request. If possible please also create a [github workflow](https://help.github.com/en/actions/automating-your-workflow-with-github-actions/configuring-a-workflow#in-this-article).

----
[Cookiecutter](https://github.com/audreyr/cookiecutter) has a similar goal and also supports multiple languages for setting up a bare project.

[java-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/java/badge.svg "CI build status"
[php-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/php/badge.svg "CI build status"
[rust-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/rust/badge.svg "CI build status"
[python-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/python/badge.svg "CI build status"
[scala-ci-badge]:https://github.com/swkBerlin/kata-bootstraps/workflows/scala/badge.svg "CI build status"
[ci-actions]: https://github.com/swkBerlin/kata-bootstraps/actions
