import HelloWorld from '../src/HelloWorld';

describe('Hello World', () => {
  it('should return "Hello World!"', () => {
    expect(HelloWorld()).to.equal('Hello World!');
  });
});
