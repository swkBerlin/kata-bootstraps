import { test, expect } from 'vitest';
import HelloWorld from '../src/HelloWorld';

test('Hello World should return "Hello World!"', () => {
  expect(HelloWorld()).toBe('Oh oh ...');
});

test('Hello World should return "Hello World!"', () => {
  expect(HelloWorld()).toBe('Hello World!');
});
