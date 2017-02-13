# Mocha tests

## Installation

Go to the root directory (where the `package.json` is located) and run:

```bash
npm install
```

## Running tests

Run the tests once:

```bash
npm test
```

Run the test and re-run them once a file changes:

```bash
npm run test:watch
```

## Lint

Lint your code and tests using:

```bash
npm run lint
```

### What's included

* Support for ES-2015 and stage-0 using Babel presets
* Linting, based on `airbnb-base` with customization to use `chai` without pain
* [Sinon JS](http://sinonjs.org/) for all stub, spy and mocking needs
* Mocha to run tests