namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            double result = _calculator.Add(10, 20);
            Assert.That(result, Is.EqualTo(30));
        }

        // Start Q13
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtract()
        {
            double result = _calculator.Subtract(30, 20);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiply()
        {
            double result = _calculator.Multiply(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Divide_WhenDivideTwoNumbers_ResultRequalToDivide()
        {
            double result = _calculator.Divide(10, 5);
            Assert.That(result, Is.EqualTo(2));
        }
        // End Q13

       
       
        // End Q14b

        // Start Q15a
        // Test Negative Value
        [Test]
        public void Factorial_WithNegativeAsInput_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Factorial(-1), Throws.ArgumentException);
        }

        // Test Zero
        [Test]
        public void Factorial_WithZeroAsInput_ResultEqualToZeroFactorial()
        {
            double result = _calculator.Factorial(0);
            Assert.That(result, Is.EqualTo(1));
        }

        // Test Positive
        [Test]
        public void Factorial_WithOneAsInput_ResultEqualToFourFactorial()
        {
            double result = _calculator.Factorial(4);
            Assert.That(result, Is.EqualTo(24));
        }
        // End Q15a

        // Start Q16
        // Area of Triangle
        [Test]
        [TestCase(-5, 5)]
        [TestCase(5, -5)]
        [TestCase(0, 0)]
        [TestCase(5, 0)]
        [TestCase(0, 5)]
        public void AreaOfTriangle_WithInvalidInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.AreaOfTriangle(a, b), Throws.ArgumentException);
        }

        [Test]
        public void AreaOfTriangle_WithValidInputs_ResultEqualToTriangleArea()
        {
            double result = _calculator.AreaOfTriangle(5, 5);
            Assert.That(result, Is.EqualTo(12.5));
        }

        // Area Of A Circle
        [Test]
        [TestCase(-5)]
        [TestCase(0)]
        public void AreaOfCircle_WithInvalidInput_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.AreaOfCircle(a), Throws.ArgumentException);
        }

        [Test]
        public void AreaOfCircle_WithValidInput_ResultEqualToCircleArea()
        {
            double result = _calculator.AreaOfCircle(5);
            Assert.That(result, Is.EqualTo(78.539816339744831));
        }
        // End Q16

        // Start Q17
        // Start UnknownFunctionA
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }
        // End UnknownFunctionA

        // Start UnknownFunctionB
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
        // End UnknownFunctionB
        // End Q17
    }
}
