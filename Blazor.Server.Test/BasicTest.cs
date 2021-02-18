using System;
using System.Collections.Generic;
using System.Text;
using Blazor.Server.Pages;
using Bunit;
using Xunit;
using Telerik.JustMock;
using Telerik;

namespace Blazor.Server.Test
{
    //public class HelloWorldTest1
    //{
    //    [Fact]
    //    public void HelloWorldComponentRendersCorrectly()
    //    {
    //        // Arrange
    //        using var ctx = new TestContext();

    //        // Act
    //        var cut = ctx.RenderComponent<HelloWorld>();

    //        // Assert
    //        cut.MarkupMatches("<h1>Hello world from Blazor</h1>");
    //    }
    //}
    //public class BasicTest: TestContext
    //{
    //    [Fact]
    //    public void CounterShouldIncrementWhenClicked()
    //    {
    //        // Arrange: render the Counter.razor component
          
    //        var cut = RenderComponent<Counter>();

    //        // Act: find and click the <button> element to increment
    //        // the counter in the <p> element
    //        cut.Find("button").Click();

    //        // Assert: first find the <p> element, then verify its content
    //        cut.Find("p").MarkupMatches("<p>Current count: 1</p>");
    //    }
    //}
    ///// <summary>
    ///// This class does not need testcontext initialization in functions
    ///// </summary>
    //public class HelloWorldImplicitContextTest : TestContext
    //{
    //    [Fact]
    //    public void HelloWorldComponentRendersCorrectly()
    //    {
    //        // Act
    //        var cut = RenderComponent<HelloWorld>();

    //        // Assert
    //        cut.MarkupMatches("<h1>Hello world from Blazor</h1>");
    //    }
    //}
}
