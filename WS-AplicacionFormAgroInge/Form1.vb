Public Class Form1
    Private Sub btnMetodoGET_Click(sender As Object, e As EventArgs) Handles btnMetodoGET.Click

        Dim url As String = "https://localhost:44386/WebService-Agroinge.asmx/Suma?numero="

        Dim HttpRequest As New MSXML2.XMLHTTP30

        HttpRequest.open("GET", url + (txtNumero.Text.ToString))
        HttpRequest.send()

        Dim xml As MSXML2.DOMDocument
        xml = HttpRequest.ResponseXML

        Try
            MessageBox.Show("Resultado: " + xml.DocumentELement.text)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un problema: " + ex.Message)
        End Try

    End Sub

End Class
