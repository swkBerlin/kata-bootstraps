class SomeService:
    def __init__(self, msg):
        self.msg = msg

    def service_call(self):
        # going into db looong complex processing
        return f"{self.msg}"


#def echo_


def test_return_smth():
    a = SomeService("w")
    assert a.service_call() == "w"
