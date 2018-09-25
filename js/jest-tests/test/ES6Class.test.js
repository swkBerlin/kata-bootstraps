// use named imports
import { ES6Class } from '../src/ES6Class';

beforeAll(() => {
  ES6Class.prototype.someMethod = jest.fn();
  ES6Class.prototype.otherMethod = jest.fn();
  ES6Class.prototype.otherMethod.mockReturnValue('yay');
});
afterAll(() => {
  ES6Class.prototype.someMethod.mockReset();
  ES6Class.prototype.otherMethod.mockReset();
});

test('Jest should be able to spy someMethod', () => {
  const es6Class = new ES6Class();
  es6Class.someMethod();
  expect(es6Class.someMethod.mock.calls.length).toBe(1);
});
test('Jest should be able to stub an otherMethod', () => {
  const es6Class = new ES6Class();
  expect(es6Class.otherMethod()).toBe('yay');
});