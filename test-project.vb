Module Module1

    Sub Main()
        Dim name As String 'name is declared'
        Dim marks As Integer 'marks is declared'
        FileOpen(1, My.Application.Info.DirectoryPath & "\StFile.txt", OpenMode.Append) 'file is opened, append is used for existing file'
        For x = 1 To 10 'entries upto 10/loop starts with IF statement'
            Console.Write("enter your name") 'question displayed'
            name = Console.ReadLine 'input taken'
            Console.Write(" enter your marks")
            marks = Console.ReadLine
            If marks < 30 Then 'marks below 30 are saved to file'
                WriteLine(1, name)

            End If

        Next
        FileClose(1)
        Console.ReadKey()




    End Sub

End Module
