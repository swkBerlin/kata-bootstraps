class SomeService:
    def service_call(self, number):
        # going into db looong complex processing
        return f"{number}"


def under_test(service, number):
    return service.service_call(number)


class ServiceStub:

    def service_call(self, number):
        return "42"


def test_stub():
    result = under_test(ServiceStub(), 0)
    assert result == "42"