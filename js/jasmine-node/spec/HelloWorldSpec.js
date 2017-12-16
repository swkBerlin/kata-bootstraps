const HelloWorld = require('../src/HelloWorld');

describe('HelloWorld', () => {
  describe('#greet', () => {
    it('returns the classic hello world', () => {
      const expectedGreet = 'Hello, world!';

      expect(HelloWorld.greet()).toEqual(expectedGreet);
    });
  });
});
