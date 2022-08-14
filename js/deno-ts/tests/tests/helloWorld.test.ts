// helloWorld.test.ts
import { assertEquals } from "https://deno.land/std@0.152.0/testing/asserts.ts";
import { hello } from "../lib/helloWorld.ts";

Deno.test("helloWord test", () => {
  assertEquals(hello("World"), "Hello World!");
});
