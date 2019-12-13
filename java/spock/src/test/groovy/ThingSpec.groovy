import spock.lang.Specification

  class ThingSpec extends Specification {

  def "it should call for action"() {
    given: "some Thing"
    Thing thing = new Thing()

    when: "an action is called on it"
    String value = thing.callForAction()

    then: "it should return 'Food'"
    "Food" == value
  }

  def notfail() {
    given: "1"
    def value = 1

    when: "I add 1 to it"
    value +=1

    then: "it should be 2"
    2 == value
  }
}
