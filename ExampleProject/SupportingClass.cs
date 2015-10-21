using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject
{
   public class SupportingClass
   {
      public static string FormatLogText( string text )
      {
         return string.Format( "[{0}] {1}", DateTime.Now, text );
      }

      public static void PrintLine( string text )
      {
         Console.WriteLine( FormatLogText( text ) );
      }
   }
}
