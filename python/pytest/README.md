# Python with pytest


## Installation
Simply install pytest : 
```
pip install -U pytest
```
or if using python >= 3 on a Mac : 
```
pip3 install -U pytest
```

## Run
 - Write your test in a python file (```test_thing.py``` in the example)
 - Go to the source directory of the test file 
 - run : ```python -m pytest test_thing.py```
 - or if using python >= 3 on a Mac : ```python3 -m pytest test_thing.py```

## Other
An alternate version with before fixture is provided in the ```test_thing_fixture.py``` file.

To run same as before : 
```python -m pytest test_thing_fixture.py``` or ```python3 -m pytest test_thing_fixture.py```

## Resources

 - <http://pythontesting.net/framework/pytest/pytest­introduction/>
 - <http://pytest.org/latest/overview.html>
