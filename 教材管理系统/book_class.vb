Public Class book_class
    Public ISBN, name, author, press As String
    Public price As Double
    Public duplicate, repertory, id As Integer
    Public Sub set_book(ISBN As String, name As String, author As String, press As String, price As Double, duplicate As Integer, repertory As Integer, id As Integer)
        Me.ISBN = ISBN
        Me.name = name
        Me.author = author
        Me.press = press
        Me.price = price
        Me.duplicate = duplicate
        Me.repertory = repertory
        Me.id = id
    End Sub

End Class
