package io.accelerate.solutions.HLO;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.Matchers.equalTo;

public class HelloSolutionTest {
    private HelloSolution hello;

    @BeforeEach
    public void setUp() {
        hello = new HelloSolution();
    }

    @Test
    public void return_string() {
        assertThat(hello.hello("Rita"), equalTo("Hello, World!"));
    }
}