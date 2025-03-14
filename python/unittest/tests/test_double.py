from app.some_service import interact_with_service, SomeService
import unittest
import unittest.mock as mock

#   TestDouble concep
#   - https://martinfowler.com/bliki/TestDouble.html


#
#   Example of using stubs
#   1. Hand written class - ServiceStub
#   2. using unittest.mock patch facilities
#


class ServiceStub:
    @staticmethod
    def service_call(number):
        return "42"

class TestDouble(unittest.TestCase):

    def test_stub(self):
        result = interact_with_service(ServiceStub(), 0)
        self.assertEqual(result, "42")

    def test_stub_2(self):
        expected = 'foo'

        def method_stub(self, some_number):
            return 'foo'

        mock.patch(
            'app.some_service.SomeService.service_call',
            method_stub
        )

        actual = SomeService().service_call(expected)
        self.assertEqual(expected, actual)

    #
    #   Example of using mock:
    #
    @mock.patch('app.some_service.SomeService.service_call')
    def test_mock_service_call_class(self, service_call) -> None:
        rpc = SomeService()
        rpc.service_call(-135)
        SomeService.service_call.assert_called_with(-135)


    @mock.patch('app.some_service.SomeService.service_call')
    def test_mock_service_call_function(self, service_call) -> None:
        rpc = SomeService()
        interact_with_service(rpc, 100500)
        SomeService.service_call.assert_called_once_with(100500)


    def test_mock_service_call_object(self) -> None:
        expected = 'foo'
        rpc = SomeService()

        mock.patch.object(
            rpc,
            'service_call',
            return_value=expected,
            autospec=True)

        self.assertEqual(interact_with_service(rpc, expected), expected)

