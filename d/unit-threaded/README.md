d/unit-threaded setup
==========

This is a simple bootstrap project for D with unit-threaded. unit-threaded is an advanced multi-threaded unit testing framework with a minimal to no boilerplate using built-in unittest blocks.

Using DUB just run

```
dub test

```

If you want to change unit-threaded's options (e.g. run only certain tests, single-threaded execution, …), this might help
```
dub test -- --help
```
(note the `--` before(!) `--help`)

You may also want to visit [unit-threaded's GitHub-repo](https://github.com/atilaneves/unit-threaded) for examples on how to use fluent assertions and mocks.