package io.accelerate.solutions.CHK;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.Matchers.equalTo;

public class CheckoutSolutionTest {
    private CheckoutSolution solution = new CheckoutSolution();

    @BeforeEach
    public void setSolution() { solution = new CheckoutSolution(); }

    @Test
    public void run() {
        assertThat(solution.checkout("BCDAAB"), equalTo(180));
        assertThat(solution.checkout("ADAAB"), equalTo(175));
        assertThat(solution.checkout("ADAABF"), equalTo(-1));
        assertThat(solution.checkout(""), equalTo(0));
        assertThat(solution.checkout("ADAEB"), equalTo(185));
        assertThat(solution.checkout("ADAEEB"), equalTo(195));
        assertThat(solution.checkout("AAAAAEB"), equalTo(270));
    }
}

