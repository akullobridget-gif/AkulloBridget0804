Module Program
    Sub Main(args As String())
        Dim acc As New BankAccount(50000)
        Console.WriteLine("Starting: " & acc.Balance)
        acc.Deposit(10000)
        Console.WriteLine("After Deposit 10000: " & acc.Balance)
        acc.Withdraw(20000)
        Console.WriteLine("After Withdraw 20000: " & acc.Balance)
        Try
            acc.Withdraw(100000)
        Catch ex As Exception
            Console.WriteLine("Blocked overdraft: " & ex.Message)
        End Try
        Try
            acc.Deposit(-500)
        Catch ex As Exception
            Console.WriteLine("Blocked negative: " & ex.Message)
        End Try
            Console.WriteLine("Final Balance: " & acc.Balance)
        End Sub
        End Module

        Public Class BankAccount
        Private _balance As Decimal
        Public Sub New(initialBalance As Decimal)
        _balance = initialBalance
    End Sub
    Public ReadOnly Property Balance As Decimal
    Get
        Return _balance
    End Get
End Property
Public Sub Deposit(amount As Decimal)
If amount < 0 Then 
    Throw  New ArgumentException("Deposit canno be Negative.")
End If
_balance += amount
End Sub
Public Sub Withdraw(amount As Decimal)
   If amount < 0 Then
    Throw New ArgumentException("Withdraw cannot be Negative.")
   End If
   If amount > _balance Then
     Throw New InvalidOperationException("Insufficient funds.")
   End If
     _balance -= amount
   End Sub
End Class
