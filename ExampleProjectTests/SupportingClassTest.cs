using System;
using ExampleProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleProjectTests
{
   [TestClass]
   public class SupportingClassTest
   {
      [TestMethod]
      public void FormatLogText_OutputContainsExpectedString()
      {
         string _expectedStringContents = "Some test string";
         string _actualString = SupportingClass.FormatLogText( "Some test string" );
         Assert.IsTrue( _actualString.Contains( _expectedStringContents ) );
      }
   }
}
