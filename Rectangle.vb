Imports System
Public Class Rectangle 
'    Instance variable
   private length as Double 
   private width as Double


   public Sub AcceptDetail()
      Console.WriteLine("Enter height of the rectangle ")
      length =Console.ReadLine
      Console.WriteLine("Enter Width of the rectangle ")
       width = console.ReadLine
    End Sub


    ' function that calculate Area of the rectangle 
    Public Function GetArea() as Double
        GetArea = length* width 


    End Function

    Public Sub Display()
       console.writeline("Length: " &length)
       console.writeline("Width: {0}", width)
       console.writeline("Area: {0}", GetArea())
    End Sub


    ' Entry point of VB.Net Program
    Shared Sub Main()
        Dim r as New Rectangle()
        r.AcceptDetail()
        r.Display()
        console.readkey()
    End Sub
End Class
