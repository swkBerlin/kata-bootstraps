import time


class SomeService:
    def service_call(self, number):
        # going into db looong complex processing
        time.sleep(3)
        return f"{number}"


def interact_with_service(service, number):
    return service.service_call(number)
