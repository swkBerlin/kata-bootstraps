// use named imports
import { ES6Class } from "../src/ES6Class.js";
import assert from "node:assert/strict";
import { before, after, it, describe } from "node:test";

const someMethodTracker = new assert.CallTracker();
const someOtherMethodTracker = new assert.CallTracker();

const someMethodImpl = ES6Class.prototype.someMethod;
const otherMethodImpl = ES6Class.prototype.otherMethod;

describe("spy and stub with node:test", async () => {
  before(() => {
    ES6Class.prototype.someMethod = someMethodTracker.calls(() => undefined, 1);
    ES6Class.prototype.otherMethod = someOtherMethodTracker.calls(
      () => "yay",
      1
    );
  });
  after(() => {
    ES6Class.prototype.someMethod = someMethodImpl;
    ES6Class.prototype.otherMethod = otherMethodImpl;
  });

  it("should be able to spy someMethod", () => {
    const es6Class = new ES6Class();
    es6Class.someMethod = es6Class.someMethod();
    someMethodTracker.verify();
  });

  it("should be able to stub an otherMethod", () => {
    const es6Class = new ES6Class();
    assert.equal(es6Class.otherMethod(), "yay");
    someOtherMethodTracker.verify();
  });
});
