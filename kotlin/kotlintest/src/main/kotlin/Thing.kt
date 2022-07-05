class Thing {

    fun callForAction(): String {
        return "Dog"
    }

    fun callForAction(food: String): String {
        println("sleep")
        return "Dog eats $food."
    }
}
