from app.thing import Thing
import unittest

class TestThing(unittest.TestCase):

    def test_correct_greeting(self):
        thing = Thing("Bob")
        self.assertEqual("Hello Bob!", thing.return_hello_name())


    def test_fail(self):
        thing = Thing("Albert")
        self.assertEqual("Wrong!", thing.return_hello_name())
