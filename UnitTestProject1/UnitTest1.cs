using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitConverter;
using System;
using System.IO;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTagInformation()
        {
            string expected = "information";
            Form1 f = new Form1();
            string actual = f.test_1(expected);
            Assert.AreEqual(expected, actual, "NO");
        }
        [TestMethod]
        public void TestIfPrintAreaisEmpty()
        {
            string expected = "";
            Form1 f = new Form1();
            string actual = f.textBox1.Text;
            Assert.AreNotEqual(expected, actual, "Textbox is empty");
        }
        [TestMethod]
        public void TestWillProgramBrokeifPrintAreaWillEmpty()
        {
            Form1 f = new Form1();
            string[] listitems = { "нанометр, нм", "микрометр, мкм", "миллиметр, млм", "сантиметр, см", "дециметр, дм", "метр, м", "километр, км", "миля", "аршин", "вершок", "дюйм", "локоть", "пядь", "сажень", "фут" };
            try
            {
                f.textBox1.Text = "";
                f.listBox1.Items.AddRange(listitems);
                f.listBox1.SetSelected(0, true);
            }
            catch (Exception)
            {
                Assert.Fail("Fatal: Error");
            }
        }
        [TestMethod]
        public void CorrectlyEnter()
        {
            Form1 f = new Form1();
            f.textBox1.Text = "12";
            Object actual = Convert.ToInt32(f.textBox1.Text);
            if (!(actual is Int32))
            {
                Assert.Fail("Fatal: Error");
            }
        }
        [TestMethod]
        public void CorrectlyComputing()
        {
            Form1 f = new Form1();
            f.textBox1.Text = "1";
            string[] listitems = { "градус Цельсия, °С ", "градус Фаренгейта, F", "градус Кельвина, K" };
            f.listBox1.Items.AddRange(listitems);
            f.listBox1.SetSelected(0, true);
            string text = "1 °С" + Environment.NewLine + "33,8 F" + Environment.NewLine +"274,15 K" + Environment.NewLine;
            Assert.AreEqual(text, f.textBox2.Text, "Computing Incorrect");
        }
    }
}
