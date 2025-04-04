## A minimal setup with Python's unittest to get you started

#### Setup

Does not need any additional libraries, as unittest and unittest.mock are part of the
standard Python library.


#### Running the tests

To execute the tests run `python -m unittest` from this directory `py -m unittest` on windows.

The methods starting with 'test_' are going to be discovered automatically.

Adding to vscode:

Navigate to beaker tab on the sidebar. Choose configure. Python tests may be supported out of the box on vs code. Choose unittest flavour. Choose test_* detection pattern. The test tab should now populate with all tests, and you can run and debug from the test tab.
