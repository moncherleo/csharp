using csharp.main.utils;
using csharp.Properties;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.classwork.lesson05
{
    //[TestFixture]
    //class TestCaseWithFileReader
    //{
    //    TestDataProvider expectedResultTestData = new TestDataProvider();
    //    static int[][][] expectedResultsArray;

    //    private string inputDataPath = Resources.PathToResources + "input.txt";
    //    private string expectedResultPath = Resources.PathToResources + "expected.txt";
    //    private static int[] inputData = null;
    //    private static int[] expectedResults = null;

    //    [OneTimeSetUp] // input data the same for all tests_    
    //    public void OneTimeSetUp()
    //    {
    //        int [][] expectedArray = TestDataProvider.ReadTestData("");
    //        expectedResultsArray[0] = expectedArray;
    //        expectedResultTestData.setArrayOfIntArrays(expectedArray);
    //    }

    //    [SetUp]
    //    public void SetUp()
    //    {
    //        expectedResultTestData.getNextIntArray();
    //    }

    //    [TestCaseSource("DivideCases")]
    //    [Ignore("Should be fixed later")]
    //    public void FirstTest(int expectedArray)
    //    {
    //        Console.WriteLine("Simple sorting test");
    //        Array.Sort(inputData);
    //        Assert.AreEqual(expectedResults, inputData);
    //    }

    //    [Test, Timeout(1000)]
    //    public void InfinityTest()
    //    {
    //        while (true) ;
    //    }

    //    [Test, Timeout(1000)]
    //    [Ignore("This test is not ready yet")]
    //    public void ThisTestIsNotReadyYet() { }

    //    [TearDown]
    //    public void TearDown()
    //    {
    //        inputData = null;
    //    }

    //    [OneTimeTearDown]
    //    public void OneTimeTearDown()
    //    {
    //        expectedResults = null;
    //    }
    //}
}
