using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrivateReflectionUsingDynamic;
using LibraryWithPrivateMembers;
using System.Web.UI;

namespace PrivateReflectionUsingDynamicTests {
    
    [TestClass]
    public class UnitTest {
        private dynamic dynamicFoo;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext) {
        }

        [TestInitialize()]
        public void TestInitialize() {
            var foo = new Foo();
            //dynamicFoo = foo;
            dynamicFoo = foo.AsDynamic();
        }

        [TestMethod]
        public void TestPropertyGetAndSetInternalInteger() {
            dynamicFoo.SomeInternalInteger = 17;
            Assert.AreEqual(17, dynamicFoo.SomeInternalInteger);
        }

        [TestMethod]
        public void TestPropertyGetAndSetPublicBool() {
            dynamicFoo.SomePublicBool = true;
            Assert.AreEqual(true, dynamicFoo.SomePublicBool);
        }

        [TestMethod]
        public void TestPropertyGetAndSetPrivateString() {
            dynamicFoo.SomePrivateString = "Hello";
            Assert.AreEqual("Hello", dynamicFoo.SomePrivateString);
        }

        [TestMethod]
        public void TestPrivateIntegerField() {
            Assert.AreEqual(-1, dynamicFoo._somePrivateIntegerField);
            dynamicFoo._somePrivateIntegerField = 12;
            Assert.AreEqual(12, dynamicFoo._somePrivateIntegerField);
        }

        [TestMethod]
        public void TestOperatorOnIntegers() {
            dynamicFoo.SomeInternalInteger = 17;
            Assert.AreEqual(35, dynamicFoo.SomeInternalInteger * 2 + 1);
        }

        [TestMethod]
        public void TestOperatorOnStrings() {
            dynamicFoo.SomePrivateString = "Hello";
            Assert.AreEqual("Hello world", dynamicFoo.SomePrivateString + " world");
            Assert.AreEqual("Say Hello", "Say " + dynamicFoo.SomePrivateString);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMissingProperty() {
            dynamicFoo.NotExist = "Hello";
        }

        [TestMethod]
        public void TestMethodCalls() {
            dynamicFoo.SomeInternalInteger = 17;

            // This one is defined on the base type
            var sum = dynamicFoo.AddIntegers(dynamicFoo.SomeInternalInteger, 3);
            Assert.AreEqual(20, sum);

            // Different overload defined on the type itself
            sum = dynamicFoo.AddIntegers(dynamicFoo.SomeInternalInteger, 3, 4);
            Assert.AreEqual(24, sum);
        }

        [TestMethod]
        public void TestPropertyGetAndSetOnSubObject() {
            dynamicFoo._bar.SomeBarStringProperty = "Blah";
            Assert.AreEqual("Blah", dynamicFoo._bar.SomeBarStringProperty);
        }

        [TestMethod]
        public void TestNullSubObject() {
            Assert.AreEqual(null, dynamicFoo._barNull);
        }

        [TestMethod]
        public void TestIndexedProperty() {
            dynamicFoo["Hello"] = "qqq";
            dynamicFoo["Hello2"] = "qqq2";
            Assert.AreEqual("qqq", dynamicFoo["Hello"]);
            Assert.AreEqual("qqq2", dynamicFoo["Hello2"]);
        }

        [TestMethod]
        public void TestDictionaryAccess() {
            dynamicFoo._dict["Hello"] = "qqq";
            dynamicFoo._dict["Hello2"] = "qqq2";
            Assert.AreEqual("qqq", dynamicFoo._dict["Hello"]);
            Assert.AreEqual("qqq2", dynamicFoo._dict["Hello2"]);
        }

        [TestMethod]
        public void TestMiscSystemWebCode() {
            var page = (new Page()).AsDynamic();

            var control1 = new Control() { ID = "foo1" };
            page.Controls.Add(control1);
            dynamic control2 = (new Control() { ID = "foo2" }).AsDynamic();
            page._controls.Add((Control)control2);


            Assert.AreEqual("foo1", control2._page._controls[0]._id);

            control2._page._maxResourceOffset = 77;
            Assert.AreEqual(77, page._maxResourceOffset);

            Assert.AreEqual(ClientIDMode.Inherit, (ClientIDMode)page.EffectiveClientIDModeValue);

            page.GetDelegateInformation(null);

            Assert.AreEqual("__Page", page.GetClientID());
        }
    }
}
