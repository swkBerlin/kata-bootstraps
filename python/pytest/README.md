# Project layout

- `app` contains dummy package to be tested 
- `tests` contains tests definitions 

# Python with pytest


## Installation
Simply install pytest & pytest-mock :
```
pip install -U pytest
pip install -U pytest-mock
```
or if using python >= 3 on a Mac :
```
pip3 install -U pytest
pip3 install -U pytest-mock
```

or alternatively:
Create virtual environment...
```bash
python3 -m venv VENV
```
...activate it:
```bash
source VENV/bin/activate
```
...and install requirements listed in requirements.txt file:
```
pip install -r requirements.txt
```

## Run
 - Write your test in a python file (```test_thing.py``` in the example)
 - run : ```python -m pytest tests/test_thing.py```
 - run tests with coverage: ```python3 -m pytest --cov=app tests/```
 - or if using python >= 3 on a Mac : ```python3 -m pytest tests/test_thing.py```
 - or if using VSCode + Python extension, right-click any test and select 'Run All Tests' (select 'pytest' when prompted to configure a test framework)
 - or if using PyCharm:
   - First you would need to [set up test runner](https://www.jetbrains.com/help/pycharm/testing-your-first-python-application.html#choose-test-runner) for project:
     - Open Project preferences (On Mac - ⌘,)
     - Navigate into `Tools -> Python integrated tools -> Testing -> Test runner`
     - Choose `pytest`
   - After that you can click on `tests` folder or individual test and either choose to
     - Run default runner using shortcut (On Mac - ⇧^R)
     - Manually choose test configuration under `More Run/Debug` menu - for example, in order to run tests with coverage

## Other
An alternate version with before fixture is provided in the ```test_thing_fixture.py``` file.

To run same as before :
```python -m pytest tests/test_thing_fixture.py``` or ```python3 -m pytest tests/test_thing_fixture.py```

## Resources

 - <http://pythontesting.net/framework/pytest/pytest-introduction/>
 - <https://docs.pytest.org/en/latest/getting-started.html>

## run from docker

 ```
 './docker_test.sh'
 ```
