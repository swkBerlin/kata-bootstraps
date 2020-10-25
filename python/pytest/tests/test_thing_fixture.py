import pytest
from app.thing import Thing


@pytest.fixture
def thing():
    return Thing("Bob")


def test_correct_greeting(thing):
    assert "Hello Bob!" == thing.return_hello_name()


def test_fail(thing):
    assert "Wrong!" == thing.return_hello_name()
