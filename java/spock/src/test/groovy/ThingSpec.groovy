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
}
