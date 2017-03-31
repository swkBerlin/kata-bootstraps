// use named imports
import { ES6Class } from '../src/ES6Class';

// Use sinon to spy and stub
describe('sinon', () => {
  before(() => {
    sinon.spy(ES6Class.prototype, 'someMethod');
    sinon.stub(ES6Class.prototype, 'otherMethod').returns('yay');
  });
  after(() => {
    ES6Class.prototype.someMethod.restore();
    ES6Class.prototype.otherMethod.restore();
  });

  it('should be able to spy someMethod', () => {
    const es6Class = new ES6Class();
    es6Class.someMethod();
    expect(es6Class.someMethod).to.have.been.calledOnce;
  });
  it('should be able to stub an otherMethod', () => {
    const es6Class = new ES6Class();
    expect(es6Class.otherMethod()).to.equal('yay');
  });
});
