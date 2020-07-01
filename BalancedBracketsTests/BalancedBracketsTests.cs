using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void test1()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        [TestMethod]
        public void test2()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void test3()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }
        [TestMethod]
        public void test4()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
        [TestMethod]
        public void test5()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        public void test6()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]][]["));
        }
        [TestMethod]
        public void test7()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void test8()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }
        [TestMethod]
        public void test9()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void test10()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }
        [TestMethod]
        public void test11()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
        [TestMethod]
        public void test12()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        [TestMethod]
        public void test13()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[sth]mvmv [khg]"));
        }
    }
}
