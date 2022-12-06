using System;
using System.Reflection.PortableExecutable;
using Xunit;
using Delegate;
using static Delegate.Program;
using Moq;
using System.ComponentModel.DataAnnotations;
using static Delegate.ConsoleReader;

namespace DelegateTesting
{
    public class DelegateTest
    {
       // ConsoleReader reader = new ConsoleReader();
       // Display d = new Display();
        [Fact]
        public void Testforstring()

        {
            string str = "@@@@";
            ConsoleReader reader = new ConsoleReader();
            Iconsolereader d = new Display();
            NewDelegate word = new NewDelegate(d.Onword);
            NewDelegate num = new NewDelegate(d.Onnum);
            NewDelegate junk = new NewDelegate(d.Onjunk);
           reader.Run(str, word, num, junk);

            
            var mockCallback = new Mock<Iconsolereader>();
            

           // var subject = new Program();
            //mockCallback;
            //var actual = d.Onjunk("123");
           // var result = subject.On("123");
            // Assert.Equal("onword", result);
             mockCallback.Setup(x => x.Onjunk(It.IsAny<string>()));
            //var result = d.Onnum("123");
            mockCallback.Verify(x=> x.Onjunk(It.IsAny<string>()), Times.Once());


           // var subject = new ConsoleReader();
            
            //var actual = ConsoleReader.Run();
            //var result = subject.Run(mockCallback.Object, "omword");
            //Assert.Equal("onword", result);
            //mockDoSomething.Verify(_ => _(1.1, "x"), Times.Once);
        }
    }
}