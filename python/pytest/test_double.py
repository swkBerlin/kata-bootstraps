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


def test_mock():
    result = under_test(ServiceStub(), 0)
    assert result == "42"


def slow_function():
    return 123


@mock.patch('slow_function')
def test_expectation():
    mock.patch(
        # api_call is from slow.py but imported to main.py
        'slow_function',
        return_value=0
    )


    #
    expected = 0
    actual = slow_function()
    assert expected == actual

