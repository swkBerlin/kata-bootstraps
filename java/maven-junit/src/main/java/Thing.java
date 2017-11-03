public class Thing {

    private final AnotherThing anotherThing;

    public Thing(AnotherThing anotherThing) {
        this.anotherThing = anotherThing;
    }

    public String callForAction() {
        return anotherThing.callForData();
    }
}
