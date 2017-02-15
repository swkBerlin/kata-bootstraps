// needed for regenerator-runtime
import 'babel-polyfill';

import chai, { expect } from 'chai';
import sinon from 'sinon';
import sinonChai from 'sinon-chai';

chai.use(sinonChai);

/*
** Disable truncate for expected and actual values in assertions.
** Remove this line to reset to the default of 40 if the objects
** printed are too big.
*/
chai.config.truncateThreshold = 0;

global.expect = expect;
global.sinon = sinon;
