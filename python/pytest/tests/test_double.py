from app.some_service import interact_with_service, SomeService


#
#   Example of using stubs
#   1. Hand written class - ServiceStub
#   2. using pytest-mock patch facilities
#

class ServiceStub:
    @staticmethod
    def service_call(number):
        return "42"


def test_stub():
    result = interact_with_service(ServiceStub(), 0)
    assert result == "42"


def test_stub_using_pytest(mocker):
    expected = 'foo'

    def method_stub(self, some_number):
        return 'foo'

    mocker.patch(
        'app.some_service.SomeService.service_call',
        method_stub
    )

    actual = SomeService().service_call(expected)
    assert expected == actual


def test_stub_mocker_(mocker):

    stub = mocker.stub(name='service.service_call_stub')

    interact_with_service(stub, 0)
    stub.assert_called_once_with(0)


def test_stub_mocker(mocker):
    def foo(on_something):
        on_something('foo', 'bar')

    stub = mocker.stub(name='on_something_stub')

    foo(stub)
    stub.assert_called_once_with('foo', 'bar')


def test_mock():
    result = interact_with_service(ServiceStub(), 0)
    assert result == "42"


def slow_function():
    return 123

