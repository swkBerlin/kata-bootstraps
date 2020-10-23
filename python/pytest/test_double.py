import mock

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


def test_stub_mocker_(mocker):

    stub = mocker.stub(name='service.service_call_stub')

    under_test(stub, 0)
    stub.assert_called_once_with(0)


def test_stub_mocker(mocker):
    def foo(on_something):
        on_something('foo', 'bar')

    stub = mocker.stub(name='on_something_stub')

    foo(stub)
    stub.assert_called_once_with('foo', 'bar')


def test_mock():
    result = under_test(ServiceStub(), 0)
    assert result == "42"


def slow_function():
    return 123

