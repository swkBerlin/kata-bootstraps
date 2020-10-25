from app.some_service import interact_with_service, SomeService
from pytest_mock import mock, MockerFixture

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

#
#   Example of using mock:
#   NOTE:
#       We can move patching into function's decorators
#       but we still need to pass reference of mocker framework into
#       method to use mock package functionality
#


@mock.patch('app.some_service.SomeService.service_call')
def test_stub_mocker(mocker: MockerFixture) -> None:
    rpc = SomeService()
    rpc.service_call(-135)
    SomeService.service_call.assert_called_with(-135)


@mock.patch('app.some_service.SomeService.service_call')
def test_stub_mocker1(mocker: MockerFixture) -> None:
    rpc = SomeService()
    interact_with_service(rpc, 100500)
    SomeService.service_call.assert_called_once_with(100500)


def test_stub_mocker2(mocker: MockerFixture) -> None:
    expected = 'foo'
    rpc = SomeService()

    mocker.patch.object(
        rpc,
        'service_call',
        return_value=expected,
        autospec=True)

    assert interact_with_service(rpc, expected) == expected
