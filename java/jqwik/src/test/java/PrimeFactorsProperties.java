import net.jqwik.api.*;
import net.jqwik.api.constraints.IntRange;
import org.apache.commons.math3.primes.Primes;

import java.util.Collections;
import java.util.List;

import static org.apache.commons.math3.primes.Primes.isPrime;
import static org.assertj.core.api.Assertions.assertThat;
import static org.assertj.core.api.Assertions.assertThatThrownBy;

class PrimeFactorsProperties {

    private static final int FIRST_PRIME_NUMBER = 2;

    @Property
    @Label("0 and 1 have no prime factors")
    void noPrimeFactors(@ForAll @IntRange(max = 1) int anInt) {
        assertThat(primeFactors(anInt)).isEmpty();
    }

    @Property
    @Report(Reporting.GENERATED)
    void all_factors_are_primes(@ForAll @IntRange(min = FIRST_PRIME_NUMBER) int anInt) {
        List<Integer> primeFactors = primeFactors(anInt);

        primeFactors.forEach(
                factor -> assertThat(isPrime(factor)).isTrue()
        );
    }

    @Property
    void product_of_primes_is_factorized_to_original_primes(
            @ForAll("primes") List<Integer> primes) {
        long product = primes.stream().mapToLong(Long::valueOf)
                .reduce(1L, (a, b) -> a * b);
        Assume.that(product <= Integer.MAX_VALUE);

        List<Integer> integers = primeFactors(Math.toIntExact(product));
        primes.sort(Integer::compareTo);
        assertThat(integers).isEqualTo(primes);
    }

    @Provide
    Arbitrary<List<Integer>> primes() {
        return Arbitraries.of(2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31)
                .list()
                .ofMaxSize(10);
    }

    @Property
    @Label("multiply all factors")
    void multiplyAllFactors(@ForAll @IntRange(min = FIRST_PRIME_NUMBER) int anInt) {
        List<Integer> primeFactors = primeFactors(anInt);

        Integer allMultiply = primeFactors.stream()
                .reduce(1, (a, b) -> a * b);
        assertThat(allMultiply).isEqualTo(anInt);
    }

    @Property(maxDiscardRatio = 10)
    @Label("a prime number is the only prime factor")
    void primeIsOnlyFactor(@ForAll @IntRange(min = FIRST_PRIME_NUMBER) int anInt) {
        Assume.that(Primes.isPrime(anInt));

        List<Integer> primeFactor = primeFactors(anInt);
        assertThat(primeFactor).containsExactly(anInt);
    }

    @Property
    @Label("IAE for numbers < 0")
    void iaeForNegativeNumbers(@ForAll @IntRange(min = Integer.MIN_VALUE, max = -1) int anInt) {
        assertThatThrownBy(() -> primeFactors(anInt))
                .isInstanceOf(IllegalArgumentException.class)
                .hasMessage(anInt + " is an invalid input.");
    }

    List<Integer> primeFactors(int number) {
        if (number < 0) {
            throw new IllegalArgumentException(number + " is an invalid input.");
        }
        if (number < 2) {
            return Collections.emptyList();
        }
        List<Integer> integers = Primes.primeFactors(number);
        System.out.println(number + " -> " + integers + "\n");
        return integers;

    }

}
