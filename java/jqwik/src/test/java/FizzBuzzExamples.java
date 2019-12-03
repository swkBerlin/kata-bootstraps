import net.jqwik.api.*;
import net.jqwik.api.constraints.IntRange;

import static org.assertj.core.api.Assertions.assertThat;

@Label("FizzBuzz...")
class FizzBuzzExamples {

    private String fizzBuzz(int anInt) {
        String fizzBuzzFor = getFizzBuzzFor(anInt);
        System.out.printf("%3d -> %s\n", anInt, fizzBuzzFor);
        return fizzBuzzFor;
    }

    private String getFizzBuzzFor(int anInt) {
        if (anInt % 15 == 0) {
            return "FizzBuzz";
        }
        if (anInt % 3 == 0) {
            return "Fizz";
        }
        if (anInt % 5 == 0) {
            return "Buzz";
        }
        return Integer.toString(anInt);
    }

    @Group
    @Label("Calling fizzBuzz with...")
    class Properties {

        @Property
        @Label("multiple of 3 starts with 'Fizz'")
        boolean multiple3StartsWithFizz(@ForAll("multipleOf3") int anInt) {
            return fizzBuzz(anInt).startsWith("Fizz");
        }

        @Provide
        @SuppressWarnings("unused")
        Arbitrary<Integer> multipleOf3() {
            return Arbitraries.integers().between(1, 33).map(i -> i * 3);
        }

        @Property
        @Label("multiple of 5 ends with 'Buzz'")
        void divisibleBy5EndsWithBuzz(@ForAll @IntRange(min = 1, max = 100) int anInt) {
            Assume.that(anInt % 5 == 0);

            assertThat(fizzBuzz(anInt))
                    .endsWith("Buzz");
        }

        @Property
        @Label("number that is not a multiple of 3 nor 5 returns the number itself")
        void indivisiblesReturnThemselves(@ForAll("notMultiple") int anInt) {
            assertThat(fizzBuzz(anInt))
                    .isEqualTo(Integer.toString(anInt));
        }

        @Property(maxDiscardRatio = 20)
        @Label("a multiple of 3 and 5 returns 'FizzBuzz'")
        @Report(Reporting.GENERATED)
        boolean multipleOf3and5ReturnFizzBuzz(@ForAll @IntRange(min = 1, max = 100) int anInt) {
            Assume.that(anInt % 3 == 0);
            Assume.that(anInt % 5 == 0);
            return fizzBuzz(anInt).equals("FizzBuzz");
        }

        @Provide
        @SuppressWarnings("unused")
        Arbitrary<Integer> notMultiple() {
            return Arbitraries.integers().between(1, 100)
                    .filter(i -> i % 3 != 0)
                    .filter(i -> i % 5 != 0);
        }
    }

    @Group
    @Label("FizzBuzz examples...")
    class Examples {

        @Example
        void fizzBuzzOf2Is2() {
            assertThat(fizzBuzz(2)).isEqualTo("2");
        }

        @Data
        @SuppressWarnings("unused")
        Iterable<Tuple.Tuple2<Integer, String>> fizzBuzzExamples() {
            return Table.of(
                    Tuple.of(1, "1"),
                    Tuple.of(3, "Fizz"),
                    Tuple.of(4, "4"),
                    Tuple.of(5, "Buzz"),
                    Tuple.of(7, "7"),
                    Tuple.of(15, "FizzBuzz")
            );
        }

        @Property
        @FromData("fizzBuzzExamples")
        void fizzBuzzWorks(@ForAll int index, @ForAll String result) {
            assertThat(fizzBuzz(index)).isEqualTo(result);
        }
    }
}
