// needed for regenerator-runtime
import 'babel-polyfill';

// If we need to use Chai, we'll have already chaiEnzyme loaded
import chai from 'chai';
import chaiEnzyme from 'chai-enzyme';
chai.use(chaiEnzyme());
chai.config.truncateThreshold = 0;
