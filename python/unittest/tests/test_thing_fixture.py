import unittest
from app.thing import Thing

class TestThingFixture(unittest.TestCase):
    def setUp(self):
        self.thing=Thing("Bob")

    def test_correct_greeting(self):
        self.assertEqual("Hello Bob!", self.thing.return_hello_name())


    def test_fail(self):
        self.assertEqual("Wrong!", self.thing.return_hello_name())

