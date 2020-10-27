from app.thing import Thing


def test_correct_greeting():
    thing = Thing("Bob")
    assert "Hello Bob!" == thing.return_hello_name()


def test_fail():
    thing = Thing("Albert")
    assert "Wrong!" == thing.return_hello_name()
