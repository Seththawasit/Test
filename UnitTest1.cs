namespace TestGrading.NUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TS101_GradeBelowZero()
        {
            // Arrange
            int score = -2;
            // Act
            string grade = Grading.GradeCalculator(score);

            // Assert
            Assert.AreEqual("Invalid", grade);
        }

        [Test]
        public void TS102_GradeA()
        {
            int score = 84;
            String grade = Grading.GradeCalculator(score);
            Assert.AreEqual("A", grade);
        }
        [Test]
        public void TS103_GradeB()
        {
            // Arrange
            int score = 78;
            // Act
            string grade = Grading.GradeCalculator(score);

            // Assert
            Assert.AreEqual("B", grade);
        }
        [Test]
        public void TS104_GradeC()
        {
            // Arrange
            int score = 62;
            // Act
            string grade = Grading.GradeCalculator(score);

            // Assert
            Assert.AreEqual("C", grade);
        }
        [Test]
        public void TS105_GradeD()
        {
            // Arrange
            int score = 58;
            // Act
            string grade = Grading.GradeCalculator(score);

            // Assert
            Assert.AreEqual("D", grade);
        }
        [Test]
        public void TS106_GradeF()
        {
            // Arrange
            int score = 42;
            // Act
            string grade = Grading.GradeCalculator(score);

            // Assert
            Assert.AreEqual("F", grade);
        }
        [Test]
        public void TS201_OutputBelowZero()
        {
            int score = -2;
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Grading.PrintOut(score);
            string exp = "Error: Score is lower than zero\r\n";
            Assert.AreEqual(exp, sw.ToString());
        }
        [Test]
        public void TS202_OutputAboveHundred()
        {
            int score = 110;
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            Grading.PrintOut(score);
            string exp = "Error: Score is higher than 100\r\n";
            Assert.AreEqual(exp, sw.ToString());
        }
        
    }
}