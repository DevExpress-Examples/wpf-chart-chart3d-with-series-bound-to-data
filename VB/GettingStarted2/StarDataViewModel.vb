Imports System.Collections.ObjectModel
Imports System.Globalization
Imports System.IO
Imports System.Windows.Resources

Public Class StarDataViewModel
    Dim mStars As IEnumerable(Of Star)
    Public ReadOnly Property Stars As IEnumerable(Of Star)
        Get
            Return mStars
        End Get
    End Property

    Public Sub New()
        mStars = StarStatisticsLoader.Load("/Data/starsdata.csv")
    End Sub
End Class

Public Module StarStatisticsLoader
    Public Function Load(ByVal filepath As String) As IEnumerable(Of Star)
        Dim streamInfo As StreamResourceInfo = Application.GetResourceStream(
                New Uri(filepath, UriKind.RelativeOrAbsolute)
            )
        Dim reader As StreamReader = New StreamReader(streamInfo.Stream)
        Dim stars As Collection(Of Star) = New Collection(Of Star)()
        While (Not reader.EndOfStream)
            Dim dataLine As String = reader.ReadLine()
            Dim serializedValues As String() = dataLine.Split(";")
            stars.Add(
                    New Star(
                        id:=Convert.ToInt32(serializedValues(0), CultureInfo.InvariantCulture),
                        x:=Convert.ToDouble(serializedValues(3), CultureInfo.InvariantCulture),
                        y:=Convert.ToDouble(serializedValues(4), CultureInfo.InvariantCulture),
                        z:=Convert.ToDouble(serializedValues(5), CultureInfo.InvariantCulture),
                        spectr:=serializedValues(1),
                        luminocity:=Convert.ToDouble(serializedValues(6), CultureInfo.InvariantCulture),
                        colorIndex:=Convert.ToDouble(serializedValues(2), CultureInfo.InvariantCulture)
                    )
                )
        End While
        Return stars
    End Function
End Module