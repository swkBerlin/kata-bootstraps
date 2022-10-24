import HelloWorld from "../src/HelloWorld.js";
import { test } from "node:test";
import assert from "node:assert/strict";

test('Hello World should return "Hello World!"', () => {
  assert.equal(HelloWorld(), "Oh oh ...");
});
