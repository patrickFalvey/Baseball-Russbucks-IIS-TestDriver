Imports System
Imports System.Data
Imports System.Linq
Imports System.Xml.Linq
Imports System.Globalization

Imports System.Collections.Concurrent
Imports System.Collections.Generic
Imports System.IO
Imports System.IO.Path

Imports System.Threading
Imports System.Threading.Tasks

Class MainWindow

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        StartTest1.Visibility = Windows.Visibility.Hidden

        Dim currentDateTime As New Date
        Dim cDT As String
        Dim sp As String
        Dim currentDate As String
        Dim currentTime As String

        Dim newDateTime As New Date
        Dim nDT As String
        Dim newDate As String
        Dim newTime As String

        Dim myUpdate As XDocument
        Dim mySchedule As XDocument

        System.IO.Directory.SetCurrentDirectory("C:\Users\Larry\Documents\GitHub\Baseball-Russbucks-IIS-TestDriver")

        Dim t1 = 3
        Dim t2 = 3
        Dim t3 = 1

        currentDateTime = DateTime.Now

        cDT = currentDateTime.ToString("g")

        sp = cDT.IndexOf(" ")

        currentDate = cDT.Substring(0, sp)
        currentTime = cDT.Substring(sp + 1)

        ' Create Schedule Files for Day1-3 using new times
        newDateTime = currentDateTime.AddMinutes(t1)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        mySchedule = XDocument.Load("ScheduleFileDay1.xml")

        For Each game In mySchedule.Descendants("schedule").Descendants("day").Descendants("game")

            game.Element("startDate").Value = newDate
            game.Element("startTime").Value = newTime

        Next

        mySchedule.Save("ScheduleFileDay1.xml")

        Process.Start("FtpScheduleFileDay1Script.bat")


        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        mySchedule = XDocument.Load("ScheduleFileDay3.xml")

        For Each game In mySchedule.Descendants("schedule").Descendants("day").Descendants("game")

            game.Element("startDate").Value = newDate
            game.Element("startTime").Value = newTime

        Next

        mySchedule.Save("ScheduleFileDay3.xml")

        Process.Start("FtpScheduleFileDay3Script.bat")


        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        mySchedule = XDocument.Load("ScheduleFileDay5.xml")

        For Each game In mySchedule.Descendants("schedule").Descendants("day").Descendants("game")

            game.Element("startDate").Value = newDate
            game.Element("startTime").Value = newTime

        Next

        mySchedule.Save("ScheduleFileDay5.xml")

        Process.Start("FtpScheduleFileDay5Script.bat")


        'Create Scoring update files using new times

        newDateTime = currentDateTime.AddMinutes(t1)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay1Update0.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay1Update0.xml")



        newDateTime = currentDateTime.AddMinutes(t1 + t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay1Update1.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay1Update1.xml")



        newDateTime = currentDateTime.AddMinutes(t1 + 2 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay1Update2.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay1Update2.xml")



        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay1Update3.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay1Update3.xml")



        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay3Update0.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay3Update0.xml")



        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay3Update1.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay3Update1.xml")



        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 2 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay3Update2.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay3Update2.xml")



        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay3Update3.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay3Update3.xml")


        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay5Update0.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay5Update0.xml")



        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2 + t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay5Update1.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay5Update1.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2 + 2 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay5Update2.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay5Update2.xml")

        newDateTime = currentDateTime.AddMinutes(t1 + 3 * t3 + t2 + 3 * t3 + t2 + 3 * t3)

        nDT = newDateTime.ToString("g")

        sp = nDT.IndexOf(" ")

        newDate = nDT.Substring(0, sp)
        newTime = nDT.Substring(sp + 1)

        myUpdate = XDocument.Load("scoringUpdateDay5Update3.xml")

        myUpdate.Element("scores").Attribute("filetime").Value = newTime
        myUpdate.Element("scores").Attribute("filedate").Value = newDate

        myUpdate.Save("scoringUpdateDay5Update3.xml")


        myUpdate = XDocument.Load("scoringUpdatePreseason.xml")

        Dim queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
                 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                               .homescore = CInt(game.Elements("homescore").Value),
                                               .awayteam = game.Attribute("awayteam").Value,
                                               .awayscore = CInt(game.Elements("awayscore").Value),
                                               .gametime = game.Elements("gametime").Value}).ToList

        Dim allGamesAreFinal As Boolean = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay0.xml")

            Process.Start("FtpsscoringUpdateFinalDay0Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")

        Dim sT As New SleepyThread()

        sT.TD1 = t1
        sT.TD2 = t2
        sT.TD3 = t3


        Dim updateFileThread As New Thread(AddressOf sT.ToSleep)
        updateFileThread.IsBackground = True
        updateFileThread.Start()

        StartTest1.Visibility = Windows.Visibility.Hidden


    End Sub


End Class

Public Class SleepyThread

    Public Property TD1 As Int32
    Public Property TD2 As Int32
    Public Property TD3 As Int32

    Public Property FP As String

    Public Sub New()

    End Sub

    Public Sub ToSleep()

        'System.IO.Directory.SetCurrentDirectory("C:\Users\Larry\Documents\GitHub\Russbucks-IIS-FTPTestDriver")

        Thread.Sleep(TimeSpan.FromMinutes(Me.TD1))

        Dim myUpdate = XDocument.Load("scoringUpdateDay1Update0.xml")

        Dim queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
                 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                               .homescore = CInt(game.Elements("homescore").Value),
                                               .awayteam = game.Attribute("awayteam").Value,
                                               .awayscore = CInt(game.Elements("awayscore").Value),
                                               .gametime = game.Elements("gametime").Value}).ToList

        Dim allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay1.xml")

            Process.Start("FtpsscoringUpdateFinalDay1Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD3))


        myUpdate = XDocument.Load("scoringUpdateDay1Update1.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
                 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                               .homescore = CInt(game.Elements("homescore").Value),
                                               .awayteam = game.Attribute("awayteam").Value,
                                               .awayscore = CInt(game.Elements("awayscore").Value),
                                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay1.xml")

            Process.Start("FtpsscoringUpdateFinalDay1Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD3))

        myUpdate = XDocument.Load("scoringUpdateDay1Update2.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay1.xml")

            Process.Start("FtpsscoringUpdateFinalDay1Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD3))

        myUpdate = XDocument.Load("scoringUpdateDay1Update3.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay1.xml")

            Process.Start("FtpsscoringUpdateFinalDay1Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD2))

        myUpdate = XDocument.Load("scoringUpdateDay3Update0.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay3.xml")

            Process.Start("FtpsscoringUpdateFinalDay3Script.bat")

        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD3))

        myUpdate = XDocument.Load("scoringUpdateDay3Update1.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay3.xml")

            Process.Start("FtpsscoringUpdateFinalDay3Script.bat")

        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD3))

        myUpdate = XDocument.Load("scoringUpdateDay3Update2.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                               .homescore = CInt(game.Elements("homescore").Value),
                               .awayteam = game.Attribute("awayteam").Value,
                               .awayscore = CInt(game.Elements("awayscore").Value),
                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay3.xml")

            Process.Start("FtpsscoringUpdateFinalDay2Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD3))

        myUpdate = XDocument.Load("scoringUpdateDay3Update3.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
 Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                               .homescore = CInt(game.Elements("homescore").Value),
                               .awayteam = game.Attribute("awayteam").Value,
                               .awayscore = CInt(game.Elements("awayscore").Value),
                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay3.xml")

            Process.Start("FtpsscoringUpdateFinalDay3Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD2))

        myUpdate = XDocument.Load("scoringUpdateDay5Update0.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay3.xml")

            Process.Start("FtpsscoringUpdateFinalDay5Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD3))

        myUpdate = XDocument.Load("scoringUpdateDay5Update1.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                               .homescore = CInt(game.Elements("homescore").Value),
                               .awayteam = game.Attribute("awayteam").Value,
                               .awayscore = CInt(game.Elements("awayscore").Value),
                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay5.xml")

            Process.Start("FtpsscoringUpdateFinalDay5Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD3))

        myUpdate = XDocument.Load("scoringUpdateDay5Update2.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
                    Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                               .homescore = CInt(game.Elements("homescore").Value),
                               .awayteam = game.Attribute("awayteam").Value,
                               .awayscore = CInt(game.Elements("awayscore").Value),
                               .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay5.xml")

            Process.Start("FtpsscoringUpdateFinalDay5Script.bat")

        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")


        Thread.Sleep(TimeSpan.FromMinutes(Me.TD3))

        myUpdate = XDocument.Load("scoringUpdateDay5Update3.xml")

        queryGame = (From game In myUpdate.Descendants("scores").Descendants("game")
         Select New GameUpdateXML With {.hometeam = game.Attribute("hometeam").Value,
                                       .homescore = CInt(game.Elements("homescore").Value),
                                       .awayteam = game.Attribute("awayteam").Value,
                                       .awayscore = CInt(game.Elements("awayscore").Value),
                                       .gametime = game.Elements("gametime").Value}).ToList

        allGamesAreFinal = True
        For Each game In queryGame
            If game.gametime <> "final" Then
                allGamesAreFinal = False
            End If
        Next

        If allGamesAreFinal = True Then
            myUpdate.Save("scoringUpdateFinalDay5.xml")

            Process.Start("FtpsscoringUpdateFinalDay5Script.bat")
        End If

        myUpdate.Save("scoringUpdate.xml")

        Process.Start("FtpScoringUpdateScript.bat")

    End Sub

End Class