using CodingChallenge;

namespace CodingChallengeTest;
using NUnit.Framework;

[TestFixture]
public class FibonacciTests {
    [Test]
    public void TestFibonacciZero() {
        Assert.AreEqual(0, Program.Fibonacci(0));
    }

    [Test]
    public void TestFibonacciOne() {
        Assert.AreEqual(1, Program.Fibonacci(1));
    }

    [Test]
    public void TestFibonacciTwo() {
        Assert.AreEqual(1, Program.Fibonacci(2));
    }

    [Test]
    public void TestFibonacciFive() {
        Assert.AreEqual(5, Program.Fibonacci(5));
    }

    [Test]
    public void TestFibonacciTen() {
        Assert.AreEqual(55, Program.Fibonacci(10));
    }
}
