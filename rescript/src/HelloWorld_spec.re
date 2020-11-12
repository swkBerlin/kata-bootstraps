open Jest;
open Expect;

test("to life the universe and everything", () => {
   expect(HelloWorld.answer()) |> toEqual(42)
});

