import codewars_test as test


@test.describe('Example Tests')
def example_tests():
    @test.it('Example Test Case')
    def example_test_case():
        test.assert_equals(42, 42, 'Optional Message on Failure')
