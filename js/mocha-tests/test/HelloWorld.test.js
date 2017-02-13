// import default from modules
import HelloWorld from '../src/HelloWorld';

// Write ES6 mocha tests with Chai assertions
describe('Hello World', () => {
  it('should return "Hello World!"', () => {
    expect(HelloWorld()).to.equal('Hello World!');
  });
});
