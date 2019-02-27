using System;
using NUnit.Framework;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White;
namespace TestUI
{
    [TestFixture]
    public class UnitTest1
    { 
    TestStack.White.Application leraApp;
    Window mainWindow;
    Button btn, btn1;
    TextBox lb, dep;

    [TestFixtureSetUp]
    public void SetUp()
    {

        leraApp = Application.Launch("..\\..\\..\\MyPoker\\bin\\Debug\\MyPoker.exe");
        mainWindow = leraApp.GetWindow("NLP");

    }

    [Test]
    public void DB()
    {
        Console.WriteLine("********START TEST DB()********");

        lb = mainWindow.Get<TextBox>(SearchCriteria.ByAutomationId("PlayerName"));
        lb.Text = "Jack";
        dep = mainWindow.Get<TextBox>(SearchCriteria.ByAutomationId("PlayerAmount"));
        Assert.IsNotNull(dep.Text);
        btn = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("button5"));
        btn.Click();
        var messageBox = mainWindow.MessageBox("");
        var mbLabel = messageBox.Get<TestStack.White.UIItems.Label>(SearchCriteria.Indexed(0));
        Assert.AreEqual("С возвращением Jack", mbLabel.Text);
        messageBox.Close();
        System.Threading.Thread.Sleep(1000);

        Console.WriteLine("********SUCCESS TEST DB()********");
    }

    [Test]
    public void Deal()
    {
        Console.WriteLine("********START TEST Deal()********");

        btn = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("button1"));
        btn.Click();
        System.Threading.Thread.Sleep(3000);
        btn1 = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("FlopButton"));
        btn1.Click();

        System.Threading.Thread.Sleep(3000);

        btn1 = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("TernButton"));
        if (btn1.Enabled == false)
        {
            btn = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("button2"));
            btn.Click();
            System.Threading.Thread.Sleep(1000);

        }
        btn1.Click();

        System.Threading.Thread.Sleep(2000);

        btn = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("RiverButton"));
        if (btn.Enabled == false)
        {
            btn1 = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("button2"));
            btn1.Click();
            System.Threading.Thread.Sleep(1000);

        }
        btn.Click();
        System.Threading.Thread.Sleep(1000);

        var messageBox = mainWindow.MessageBox("");
        var mbLabel = messageBox.Get<TestStack.White.UIItems.Label>(SearchCriteria.Indexed(0));
        Assert.IsNotNull(mbLabel.Text);
        messageBox.Close();

        Console.WriteLine("********SUCCESS TEST Deal()********");

    }

    [Test]
    public void Fold()
    {
        Console.WriteLine("********START TEST Fold()********");

        btn1 = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("FlopButton"));
        btn1.Click();

        System.Threading.Thread.Sleep(1000);

        btn1 = mainWindow.Get<Button>(SearchCriteria.ByAutomationId("button3"));
        btn1.Click();
        dep = mainWindow.Get<TextBox>(SearchCriteria.ByAutomationId("textBox3"));
        System.Threading.Thread.Sleep(1000);
        Assert.AreEqual("", dep.Text);

        Console.WriteLine("********SUCCESS TEST Fold()********");

    }

    [TestFixtureTearDown]
    public void Close()
    {


        mainWindow.Dispose();
        var messageBox = mainWindow.MessageBox("Bye");
        var mbLabel = messageBox.Get<TestStack.White.UIItems.Label>(SearchCriteria.Indexed(0));
        messageBox.Close();


    }
}
}


