# TypeScript Jest boilerplate

This boilerplate uses TypeScript and Jest as testing framework.
Test files should are picked based on their name, here's a few examples that will get picked up by Jest:

- `MyClass.test.ts`
- `MyJavaScriptModule.test.js`
- `MyComponent.test.tsx`
- `SubFolder/MyClass.test.ts`

You can customize the regexp and jest configuration by editing the `package.json` file.

## Installing dependencies

```bash
# Get Yarn
npm install -g yarn

# Install dependencies
yarn install
```

## Running tests

```bash
# Run tests once
yarn test

# Run tests with Jest-CLI custom arguments (https://jestjs.io/docs/en/cli.html)
yarn test --clearCache --debug

# Run tests for a specific file
yarn test MyFile.test.ts
```

A few other NPM scripts are provided for convenience, they all support custom arguments as described above.

```
# Run tests once with coverage
# Coverage report available in ./coverage/index.html
yarn test:cover

# Run all tests in watch mode without coverage
yarn test:watch

# Run the tests with watch mode only for files changed since the last Git commit
yarn test:changed

# Run tests for CI environment (optimized for TravisCI)
yarn test:ci
```