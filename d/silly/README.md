d/silly setup
==========

This is a simple bootstrap project for D with silly. silly is a no-nonsense test runner for the D programming language. Instead of re-inventing the wheel and adding more and more levels of abstraction it just works, requiring as little effort from the programmer as possible. 

Using DUB just run

```
dub test

```

If you want to change silly's options (e.g. run only certain tests, change number of threads, …), this might help
```
dub test -- --help
```
(note the `--` before(!) `--help`)
