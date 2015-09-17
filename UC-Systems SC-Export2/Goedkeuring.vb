Imports System.Windows.Forms
Imports System.Text.RegularExpressions

Module Module2
    '' module om html tags uit text te filteren
    Sub Main()
        ' Input.
        Dim html As String = "<div lang=NL link=blue vlink=purple> <div class=WordSection1> <p class=MsoNormal>Hoessein,<o:p></o:p></p> <p class=MsoNormal><o:p>&nbsp;</o:p></p> <p class=MsoNormal>Na de reboot gisteren van server03 &amp; server04 volgt niet meer automatisch de invoegtoepassing voor het opslaan in U4 DM vanuit Outlook.<o:p></o:p></p> <p class=MsoNormal><o:p>&nbsp;</o:p></p> <p class=MsoNormal>Wil je dit bezien? Alvast bedankt.<o:p></o:p></p> <p class=MsoNormal><o:p>&nbsp;</o:p></p> <p class=MsoNormal><span style=mso-fareast-language:NL>Met vriendelijke groet,<o:p></o:p></span></p> <p class=MsoNormal><span style=mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal><span style=mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal><span style=mso-fareast-language:NL>J. (Jan) Smit<o:p></o:p></span></p> <p class=MsoNormal><span style=mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal><span style=font-size:9.0pt;mso-fareast-language:NL>(afwezig op donderdag)</span><span style=mso-fareast-language:NL><o:p></o:p></span></p> <p class=MsoNormal><span style=font-size:9.0pt;mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal><span style=mso-fareast-language:NL><img src=/inlineimages/WorkOrder/Jan2014/5713/0.jpg><o:p></o:p></span></p> <p class=MsoNormal><span style=font-size:4.5pt;mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal><span style=font-size:9.0pt;mso-fareast-language:NL>Maseratilaan 4<o:p></o:p></span></p> <p class=MsoNormal><span style=font-size:9.0pt;mso-fareast-language:NL>3261 NA&nbsp; Oud-Beijerland<o:p></o:p></span></p> <p class=MsoNormal><span style=font-size:4.5pt;mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal><span style=font-size:9.0pt;mso-fareast-language:NL>Postbus 1230<o:p></o:p></span></p> <p class=MsoNormal><span style=font-size:9.0pt;mso-fareast-language:NL>3260 AE&nbsp; Oud-Beijerland<o:p></o:p></span></p> <p class=MsoNormal><span style=font-size:4.5pt;mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal><b><span style=font-size:9.0pt;color:#A82800;mso-fareast-language:NL>T</span></b><span style=font-size:9.0pt;mso-fareast-language:NL> 0186-615450<o:p></o:p></span></p> <p class=MsoNormal><b><span style=font-size:9.0pt;color:#A82800;mso-fareast-language:NL>F</span></b><span style=font-size:9.0pt;mso-fareast-language:NL> 0186-613559<o:p></o:p></span></p> <p class=MsoNormal><span style=font-size:9.0pt;mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal><span lang=EN-GB style=font-size:7.0pt;font-family:Webdings;color:green;mso-fareast-language:NL>P </span><span lang=EN-GB style=font-size:7.0pt;color:green;mso-fareast-language:NL>&nbsp;</span><span style=font-size:7.0pt;color:green;mso-fareast-language:NL>denk aan het milieu - dit mailbericht printen is niet altijd nodig</span><span style=font-size:7.0pt;mso-fareast-language:NL><o:p></o:p></span></p> <div class=MsoNormal align=center style=text-align:center><span style=mso-fareast-language:NL> <hr size=2 width=100% align=center> </span></div> <p class=MsoNormal style=text-align:justify><span style=font-size:7.0pt;mso-fareast-language:NL>De informatie verzonden met dit e-mailbericht is uitsluitend bestemd voor de geadresseerde[n] en kan persoonlijke of vertrouwelijke informatie bevatten, beschermd  door een beroepsgeheim. Gebruik van deze informatie door anderen dan de geadresseerde[n] en gebruik door hen die niet gerechtigd zijn van deze informatie kennis te nemen, is verboden. Indien u niet de geadresseerde bent of niet gerechtigd bent tot kennisneming,  is openbaarmaking, vermenigvuldiging, verspreiding en / of verstrekking van deze informatie aan derden niet toegestaan en wordt u verzocht dit bericht terug te sturen en het origineel te vernietigen. Tenzij uitdrukkelijk anders vermeld, is op dit bericht of  in enige bijlage opgenomen verantwoording(en) door ons geen accountantscontrole toegepast.<o:p></o:p></span></p> <p class=MsoNormal style=text-align:justify><span style=font-size:7.0pt;mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal style=text-align:justify><span style=font-size:7.0pt;mso-fareast-language:NL>Op onze dienstverlening zijn onze algemene voorwaarden van toepassing, waarin een beperking van onze aansprakelijkheid is opgenomen. Op uw eerste verzoek zal  u gratis een exemplaar worden toegezonden.<o:p></o:p></span></p> <p class=MsoNormal style=text-align:justify><span style=font-size:7.0pt;mso-fareast-language:NL><o:p>&nbsp;</o:p></span></p> <p class=MsoNormal style=text-align:justify><span style=font-size:7.0pt;mso-fareast-language:NL>Troost Accountantskantoor v.o.f. te Oud Beijerland, ingeschreven bij de KvK te&nbsp;Dordrecht onder nummer 24301517.<o:p></o:p></span></p> <p class=MsoNormal><o:p>&nbsp;</o:p></p> </div> </div>"

        ' Call Function.
        Dim tagless As String = StripTags(html)

        ' Write.
        Console.WriteLine(tagless)
    End Sub

    ''' <summary>
    ''' Strip HTML tags.
    ''' </summary>
    Function StripTags(ByVal html As String) As String
        ' Remove HTML tags.
        Return Regex.Replace(html, "<.*?>""<BR>", "")
    End Function

End Module

Public Class Goedkeuring

    Dim NR As Long = 0
    Dim NR2 As Long = 0
    Dim scrollval As Integer
    '' SQL Query met alleen de call ID's , aanmaak datum , bedrijf en titel
    Dim sql As String = "SELECT DISTINCT WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,     '1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, WorkOrder.TITLE AS Titel FROM            AaaUser INNER JOIN                          RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID RIGHT OUTER JOIN                          PriorityDefinition RIGHT OUTER JOIN                          StatusDefinition RIGHT OUTER JOIN                         WorkOrder INNER JOIN                    AaaOrgPostalAddr INNER JOIN                          AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                          AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID LEFT OUTER JOIN                         RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID ON                          PriorityDefinition.PRIORITYID = WorkOrderStates.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON                          WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (RequestCharges.CHARGETYPE = 'Billable') OR (RequestCharges.CHARGETYPE = 'Non-Billable') ORDER BY AaaOrganization.NAME,WorkOrder.WORKORDERID"
    Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
    Dim dataadapter As New SqlDataAdapter(sql, connection)
    Dim ds As New DataSet()
    Dim x As Integer = 0

    '' SQL query uitvoren en de data in de tabel plaatsen ''
    Private Sub dataverkrijgen()
        '' SQL query uitvoren en de data in de tabel plaatsen.
        Try
            connection.Open()
            ds.Clear()
            dataadapter.Fill(ds, "WorkOrder")
            connection.Close()
            DataGridView1.DataSource = (ds)
            DataGridView1.DataMember = "WorkOrder"
            ''vraag de functie start aan.
            Start()
        Catch ex As Exception
            System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
        End Try


    End Sub

    '' laad het startscherm als het formulier word gesloten ''
    Private Sub Goedkeuring_close(sender As Object, e As EventArgs) Handles Me.FormClosing
        StartScherm.Show()
    End Sub

    'Private Sub Link_Click(sender As Object, e As EventArgs)
    '    Call dataverkrijgen() '' verwijzing naar functie dataverkrijgen()
    'End Sub

    '' start procedure ''
    Private Sub Start()
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        '' SQL Query die de data uit de db haalt waar het call ID uit datagridview1 komt.
        Dim sql3 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, WorkOrder.TITLE AS Titel, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten,                          TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren], RequestCharges.DESCRIPTION AS [Ondernomen Acties],          RequestCharges.MM2COMPLETEREQUEST / 60 / 1000 AS [Tijd in MIN], CONVERT(VARCHAR(20), DATEADD(ss, RequestCharges.EXECUTEDTIME / 1000 + 3600,                          CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering], TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status],                          AaaUser_2.FIRST_NAME AS Expr1, RequestCharges.CHARGETYPE, WorkOrderToDescription.FULLDESCRIPTION, RequestResolution.RESOLUTION,         WorkOrder.DESCRIPTION, TimeEntry_Fields.TIMEENTRYID, StatusDefinition.STATUSNAME,TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            ModeDefinition RIGHT OUTER JOIN                         StatusDefinition RIGHT OUTER JOIN                        RequestResolution RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN                         WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON                          RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN                         AaaUser INNER JOIN                         RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (WorkOrder.WORKORDERID='" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString) & "') ORDER BY AaaOrganization.NAME, RequestCharges.CHARGETYPE,WorkOrder.WORKORDERID"
        Dim dataadapter3 As New SqlDataAdapter(sql3, connection)
        Dim ds2 As New DataSet
        Try

            clear()
            connection.Open()
            dataadapter3.Fill(ds2, "TimeEntry_Fields")
            connection.Close()
            DataGridView2.DataSource = (ds2)
            DataGridView2.DataMember = "TimeEntry_Fields"
        Catch ex As Exception
            System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
        End Try
        '' verwijzing naar functie voorrijkosten (berekend hoevaak er voorrijkosten zijn geboekt)
        voorrijkosten()
        '' verwijzing naar functie Buitenkantooruren (berekend hoevaak er uren buiten kantoor tijd zijn geboekt)
        Buitenkantooruren()
        '' verwijzing naar functie tijd (berekend alle uren) 
        Tijd()
        '' verwijzing naar functie vullen20 (Vult alle velden met data)
        vullen20()
        '' verwijzing naar functie knoppen (Maak velden/knoppen die geen data hebben grijs.)
        knoppen()

    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call dataverkrijgen() ''verwijzing naar functie dataverkrijgen
    End Sub

    '' Ga terug naar het hoofdmenu ''
    Private Sub Hoofdmenu_Click(sender As Object, e As EventArgs) Handles Hoofdmenu.Click
        Close() '' sluit het formulier
    End Sub

    '' Vult alle velden met data ''
    Private Sub vullen20()



        Tijdenskantoor.Text = GetHoursMinutes(TextBox14.Text)
        Buitenkantoor.Text = GetHoursMinutes(TextBox13.Text)
        voorrijkosten2.Text = TextBox8.Text

        CallID.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(0).Value.ToString()
        Support.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(10).Value.ToString()
        Datum.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(1).Value.ToString()
        Bedrijf.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(2).Value.ToString()
        Titel.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(3).Value.ToString()
        Try
            Actie1.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(6).Value.ToString(), "<BR>", "")
            Actie1.Text = Regex.Replace(Actie1.Text, "&lt;BR&gt;", "")

            actie2.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie2.Text = Regex.Replace(actie2.Text, "&lt;BR&gt;", "")

            actie3.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie3.Text = Regex.Replace(actie3.Text, "&lt;BR&gt;", "")

            actie4.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie4.Text = Regex.Replace(actie4.Text, "&lt;BR&gt;", "")

            actie5.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie5.Text = Regex.Replace(actie5.Text, "&lt;BR&gt;", "")

            actie6.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie6.Text = Regex.Replace(actie6.Text, "&lt;BR&gt;", "")

            actie7.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie7.Text = Regex.Replace(actie7.Text, "&lt;BR&gt;", "")

            actie8.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie8.Text = Regex.Replace(actie8.Text, "&lt;BR&gt;", "")

            actie9.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie9.Text = Regex.Replace(actie9.Text, "&lt;BR&gt;", "")

            actie10.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie10.Text = Regex.Replace(actie10.Text, "&lt;BR&gt;", "")
           
            actie11.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie11.Text = Regex.Replace(actie11.Text, "&lt;BR&gt;", "")

            actie12.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie12.Text = Regex.Replace(actie12.Text, "&lt;BR&gt;", "")

            actie13.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie13.Text = Regex.Replace(actie13.Text, "&lt;BR&gt;", "")

            actie14.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie14.Text = Regex.Replace(actie14.Text, "&lt;BR&gt;", "")

            actie15.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie15.Text = Regex.Replace(actie15.Text, "&lt;BR&gt;", "")

            actie16.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie16.Text = Regex.Replace(actie16.Text, "&lt;BR&gt;", "")

            actie17.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie17.Text = Regex.Replace(actie17.Text, "&lt;BR&gt;", "")

            actie18.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie18.Text = Regex.Replace(actie18.Text, "&lt;BR&gt;", "")

            actie19.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie19.Text = Regex.Replace(actie19.Text, "&lt;BR&gt;", "")

            actie20.Text = Regex.Replace(DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(6).Value.ToString(), "<BR>", "")
            actie20.Text = Regex.Replace(actie20.Text, "&lt;BR&gt;", "")
        Catch ex As Exception

        End Try
        Try
            rekening1.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(11).Value.ToString()
            rekening2.Text = DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(11).Value.ToString()
            rekening3.Text = DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(11).Value.ToString()
            rekening4.Text = DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(11).Value.ToString()
            rekening5.Text = DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(11).Value.ToString()
            rekening6.Text = DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(11).Value.ToString()
            rekening7.Text = DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(11).Value.ToString()
            rekening8.Text = DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(11).Value.ToString()
            rekening9.Text = DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(11).Value.ToString()
            rekening10.Text = DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(11).Value.ToString()
            rekening11.Text = DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(11).Value.ToString()
            rekening12.Text = DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(11).Value.ToString()
            rekening13.Text = DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(11).Value.ToString()
            rekening14.Text = DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(11).Value.ToString()
            rekening15.Text = DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(11).Value.ToString()
            rekening16.Text = DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(11).Value.ToString()
            rekening17.Text = DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(11).Value.ToString()
            rekening18.Text = DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(11).Value.ToString()
            rekening19.Text = DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(11).Value.ToString()
            rekening20.Text = DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(11).Value.ToString()
        Catch ex As Exception

        End Try
        Try
            tijd1.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(7).Value.ToString())
            tijd2.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(7).Value.ToString())
            tijd3.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(7).Value.ToString())
            tijd4.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(7).Value.ToString())
            tijd5.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(7).Value.ToString())
            tijd6.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(7).Value.ToString())
            tijd7.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(7).Value.ToString())
            tijd8.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(7).Value.ToString())
            tijd9.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(7).Value.ToString())
            tijd10.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(7).Value.ToString())
            tijd11.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(7).Value.ToString())
            tijd12.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(7).Value.ToString())
            tijd13.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(7).Value.ToString())
            tijd14.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(7).Value.ToString())
            tijd15.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(7).Value.ToString())
            tijd16.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(7).Value.ToString())
            tijd17.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(7).Value.ToString())
            tijd18.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(7).Value.ToString())
            tijd19.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(7).Value.ToString())
            tijd20.Text = GetHoursMinutes(DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(7).Value.ToString())
        Catch ex As Exception

        End Try
        Try

            kantoor1.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(5).Value.ToString()
            kantoor2.Text = DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(5).Value.ToString()
            kantoor3.Text = DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(5).Value.ToString()
            kantoor4.Text = DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(5).Value.ToString()
            kantoor5.Text = DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(5).Value.ToString()
            kantoor6.Text = DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(5).Value.ToString()
            kantoor7.Text = DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(5).Value.ToString()
            kantoor8.Text = DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(5).Value.ToString()
            kantoor9.Text = DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(5).Value.ToString()
            kantoor10.Text = DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(5).Value.ToString()
            kantoor11.Text = DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(5).Value.ToString()
            kantoor12.Text = DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(5).Value.ToString()
            kantoor13.Text = DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(5).Value.ToString()
            kantoor14.Text = DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(5).Value.ToString()
            kantoor15.Text = DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(5).Value.ToString()
            kantoor16.Text = DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(5).Value.ToString()
            kantoor17.Text = DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(5).Value.ToString()
            kantoor18.Text = DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(5).Value.ToString()
            kantoor19.Text = DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(5).Value.ToString()
            kantoor20.Text = DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(5).Value.ToString()
        Catch ex As Exception


        End Try
        Try

            timeentry1.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(15).Value.ToString()
            timeentry2.Text = DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(15).Value.ToString()
            timeentry3.Text = DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(15).Value.ToString()
            timeentry4.Text = DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(15).Value.ToString()
            timeentry5.Text = DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(15).Value.ToString()
            timeentry6.Text = DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(15).Value.ToString()
            timeentry7.Text = DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(15).Value.ToString()
            timeentry8.Text = DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(15).Value.ToString()
            timeentry9.Text = DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(15).Value.ToString()
            timeentry10.Text = DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(15).Value.ToString()
            timeentry11.Text = DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(15).Value.ToString()
            timeentry12.Text = DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(15).Value.ToString()
            timeentry13.Text = DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(15).Value.ToString()
            timeentry14.Text = DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(15).Value.ToString()
            timeentry15.Text = DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(15).Value.ToString()
            timeentry16.Text = DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(15).Value.ToString()
            timeentry17.Text = DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(15).Value.ToString()
            timeentry18.Text = DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(15).Value.ToString()
            timeentry19.Text = DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(15).Value.ToString()
            timeentry20.Text = DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(15).Value.ToString()
        Catch ex As Exception


        End Try
       

        Try

            TextBox6.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(12).Value.ToString()
            TextBox6.Text = Module1.StripTags(TextBox6.Text)
            TextBox6.Text = TextBox6.Text.Replace("&#43;", "+")
            TextBox6.Text = TextBox6.Text.Replace("&amp;", "&")
            TextBox6.Text = TextBox6.Text.Replace("&lt;", "<")
            TextBox6.Text = TextBox6.Text.Replace("&gt;", ">")
            TextBox6.Text = TextBox6.Text.Replace("&#8216;", "'")
            TextBox6.Text = TextBox6.Text.Replace("&#8217;", "'")
            TextBox6.Text = TextBox6.Text.Replace("&#8226;", "")
            TextBox6.Text = TextBox6.Text.Replace("&#8220;", "")
            TextBox6.Text = TextBox6.Text.Replace("&#8221;", "")
            TextBox6.Text = TextBox6.Text.Replace("&#8230;", "")
            TextBox6.Text = TextBox6.Text.Replace("&quot;", "'")
            TextBox6.Text = TextBox6.Text.Replace("&middot;", "•")
            TextBox6.Text = TextBox6.Text.Replace("<br>", Environment.NewLine)
            TextBox6.Text = TextBox6.Text.Replace("<BR>", Environment.NewLine)
            TextBox6.Text = TextBox6.Text.Replace("&nbsp;", Environment.NewLine)
            StripHTML(TextBox6.Text)
            

            TextBox2.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(13).Value.ToString()
            TextBox2.Text = Module1.StripTags(TextBox2.Text)
            TextBox2.Text = TextBox2.Text.Replace("&#43;", "+")
            TextBox2.Text = TextBox2.Text.Replace("&amp;", "&")
            TextBox2.Text = TextBox2.Text.Replace("&lt;", "<")
            TextBox2.Text = TextBox2.Text.Replace("&gt;", ">")
            TextBox2.Text = TextBox2.Text.Replace("&#8216;", "'")
            TextBox2.Text = TextBox2.Text.Replace("&#8217;", "'")
            TextBox2.Text = TextBox2.Text.Replace("&#8226;", "")
            TextBox2.Text = TextBox2.Text.Replace("&#8220;", "")
            TextBox2.Text = TextBox2.Text.Replace("&#8221;", "")
            TextBox2.Text = TextBox2.Text.Replace("&#8230;", "")
            TextBox2.Text = TextBox2.Text.Replace("&quot;", "'")
            TextBox2.Text = TextBox2.Text.Replace("&middot;", "•")
            TextBox2.Text = TextBox2.Text.Replace("<br>", Environment.NewLine)
            TextBox2.Text = TextBox2.Text.Replace("<BR>", Environment.NewLine)
            TextBox2.Text = TextBox2.Text.Replace("&nbsp;", Environment.NewLine)
            StripHTML(TextBox2.Text)

         
            TextBox2.Text = "Omschrijving: " & Environment.NewLine & TextBox6.Text.Trim(" ") & Environment.NewLine & Environment.NewLine & "Oplossing: " & Environment.NewLine & TextBox2.Text


        Catch ex As Exception

        End Try

       

        If DataGridView2.Rows(DataGridView2.SelectedRows(0).Index).Cells(16).Value = "Closed" Then
            statuslabel.BackColor = System.Drawing.Color.Red
            statuslabel.Text = "Closed"
        Else
            statuslabel.BackColor = System.Drawing.Color.Green
            statuslabel.Text = "Open"
        End If
    End Sub

    '' Maak alle velden leeg ''
    Private Sub clear()
        '' maakt alle velden leeg
        TextBox1.Clear()
        kantoor1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()

        TextBox20.Clear()
        TextBox21.Clear()

        binnen1.Clear()
        binnen2.Clear()
        binnen3.Clear()
        binnen4.Clear()
        binnen5.Clear()
        binnen6.Clear()
        binnen7.Clear()
        binnen8.Clear()
        binnen9.Clear()
        binnen10.Clear()
        binnen11.Clear()
        binnen12.Clear()
        binnen13.Clear()
        binnen14.Clear()
        binnen15.Clear()
        binnen16.Clear()
        binnen17.Clear()
        binnen18.Clear()
        binnen19.Clear()
        binnen20.Clear()
        buiten1.Clear()
        buiten2.Clear()
        buiten3.Clear()
        buiten4.Clear()
        buiten5.Clear()
        buiten6.Clear()
        buiten7.Clear()
        buiten8.Clear()
        buiten9.Clear()
        buiten10.Clear()
        buiten11.Clear()
        buiten12.Clear()
        buiten13.Clear()
        buiten14.Clear()
        buiten15.Clear()
        buiten16.Clear()
        buiten17.Clear()
        buiten18.Clear()
        buiten19.Clear()
        buiten20.Clear()
        Actie1.Clear()
        actie2.Clear()
        actie3.Clear()
        actie4.Clear()
        actie5.Clear()
        actie6.Clear()
        actie7.Clear()
        actie8.Clear()
        actie9.Clear()
        actie10.Clear()
        actie11.Clear()
        actie12.Clear()
        actie13.Clear()
        actie14.Clear()
        actie15.Clear()
        actie16.Clear()
        actie17.Clear()
        actie18.Clear()
        actie19.Clear()
        actie20.Clear()
        rekening1.Clear()
        rekening2.Clear()
        rekening3.Clear()
        rekening4.Clear()
        rekening5.Clear()
        rekening6.Clear()
        rekening7.Clear()
        rekening8.Clear()
        rekening9.Clear()
        rekening10.Clear()
        rekening11.Clear()
        rekening12.Clear()
        rekening13.Clear()
        rekening14.Clear()
        rekening15.Clear()
        rekening16.Clear()
        rekening17.Clear()
        rekening18.Clear()
        rekening19.Clear()
        rekening20.Clear()
        tijd1.Clear()
        tijd2.Clear()
        tijd3.Clear()
        tijd4.Clear()
        tijd5.Clear()
        tijd6.Clear()
        tijd7.Clear()
        tijd8.Clear()
        tijd9.Clear()
        tijd10.Clear()
        tijd11.Clear()
        tijd12.Clear()
        tijd13.Clear()
        tijd14.Clear()
        tijd15.Clear()
        tijd16.Clear()
        tijd17.Clear()
        tijd18.Clear()
        tijd19.Clear()
        tijd20.Clear()
        kantoor1.Clear()
        kantoor2.Clear()
        kantoor3.Clear()
        kantoor4.Clear()
        kantoor5.Clear()
        kantoor6.Clear()
        kantoor7.Clear()
        kantoor8.Clear()
        kantoor9.Clear()
        kantoor10.Clear()
        kantoor11.Clear()
        kantoor12.Clear()
        kantoor13.Clear()
        kantoor14.Clear()
        kantoor15.Clear()
        kantoor16.Clear()
        kantoor17.Clear()
        kantoor18.Clear()
        kantoor19.Clear()
        kantoor20.Clear()
        timeentry1.Clear()
        timeentry2.Clear()
        timeentry3.Clear()
        timeentry4.Clear()
        timeentry5.Clear()
        timeentry6.Clear()
        timeentry7.Clear()
        timeentry8.Clear()
        timeentry9.Clear()
        timeentry10.Clear()
        timeentry11.Clear()
        timeentry12.Clear()
        timeentry13.Clear()
        timeentry14.Clear()
        timeentry15.Clear()
        timeentry16.Clear()
        timeentry17.Clear()
        timeentry18.Clear()
        timeentry19.Clear()
        timeentry20.Clear()
    End Sub

    '' Ga naar de vorige call ''
    Private Sub Vorige_Click(ByVal sender As Object, e As EventArgs) Handles Vorige.Click

        If x < 1 Then x = 0
        If Actie1.Enabled = False And Service1.Enabled = False And factureren1.Enabled = False And kantoor1.Enabled = False And rekening1.Enabled = False And tijd1.Enabled = False And actie2.Enabled = False And Service2.Enabled = False And factureren2.Enabled = False And kantoor2.Enabled = False And rekening2.Enabled = False And tijd2.Enabled = False And actie3.Enabled = False And Service3.Enabled = False And factureren3.Enabled = False And kantoor3.Enabled = False And rekening3.Enabled = False And tijd3.Enabled = False And actie4.Enabled = False And Service4.Enabled = False And factureren4.Enabled = False And kantoor4.Enabled = False And rekening4.Enabled = False And tijd4.Enabled = False And _
                actie5.Enabled = False And Service5.Enabled = False And factureren5.Enabled = False And kantoor5.Enabled = False And rekening5.Enabled = False And tijd5.Enabled = False And actie6.Enabled = False And Service6.Enabled = False And factureren6.Enabled = False And kantoor6.Enabled = False And rekening6.Enabled = False And tijd6.Enabled = False And actie7.Enabled = False And Service7.Enabled = False And factureren7.Enabled = False And kantoor7.Enabled = False And rekening7.Enabled = False And tijd7.Enabled = False And actie8.Enabled = False And Service8.Enabled = False And factureren8.Enabled = False And kantoor8.Enabled = False And rekening8.Enabled = False And tijd8.Enabled = False And _
                actie9.Enabled = False And Service9.Enabled = False And factureren9.Enabled = False And kantoor9.Enabled = False And rekening9.Enabled = False And tijd9.Enabled = False And actie10.Enabled = False And Service10.Enabled = False And factureren10.Enabled = False And kantoor10.Enabled = False And rekening10.Enabled = False And tijd10.Enabled = False And actie11.Enabled = False And Service11.Enabled = False And factureren11.Enabled = False And kantoor11.Enabled = False And rekening11.Enabled = False And tijd11.Enabled = False And actie13.Enabled = False And Service13.Enabled = False And factureren13.Enabled = False And kantoor13.Enabled = False And rekening13.Enabled = False And tijd13.Enabled = False And actie12.Enabled = False And Service12.Enabled = False And factureren12.Enabled = False And kantoor12.Enabled = False And rekening12.Enabled = False And tijd12.Enabled = False And _
                actie14.Enabled = False And Service14.Enabled = False And factureren14.Enabled = False And kantoor14.Enabled = False And rekening14.Enabled = False And tijd14.Enabled = False And actie15.Enabled = False And Service15.Enabled = False And factureren15.Enabled = False And kantoor15.Enabled = False And rekening15.Enabled = False And tijd15.Enabled = False And actie16.Enabled = False And Service16.Enabled = False And factureren16.Enabled = False And kantoor16.Enabled = False And rekening16.Enabled = False And tijd16.Enabled = False And actie17.Enabled = False And Service17.Enabled = False And factureren17.Enabled = False And kantoor17.Enabled = False And rekening17.Enabled = False And tijd17.Enabled = False And _
                actie18.Enabled = False And Service18.Enabled = False And factureren18.Enabled = False And kantoor18.Enabled = False And rekening18.Enabled = False And tijd18.Enabled = False And actie19.Enabled = False And Service19.Enabled = False And factureren19.Enabled = False And kantoor19.Enabled = False And rekening19.Enabled = False And tijd19.Enabled = False And actie20.Enabled = False And Service20.Enabled = False And factureren20.Enabled = False And kantoor20.Enabled = False And rekening20.Enabled = False And tijd20.Enabled = False Then
            x = x
        Else : x = x - 1
        End If
        If x < 0 Then x = 0




        dataverkrijgen()
        DataGridView1.Rows(x).Selected = True
        Start()

    End Sub
    ''Ga naar de volgende call ""
    Private Sub Volgende_Click(ByVal sender As Object, e As EventArgs) Handles Volgende.Click

        If x < 1 Then x = 0
        If Actie1.Enabled = False And Service1.Enabled = False And factureren1.Enabled = False And kantoor1.Enabled = False And rekening1.Enabled = False And tijd1.Enabled = False And actie2.Enabled = False And Service2.Enabled = False And factureren2.Enabled = False And kantoor2.Enabled = False And rekening2.Enabled = False And tijd2.Enabled = False And actie3.Enabled = False And Service3.Enabled = False And factureren3.Enabled = False And kantoor3.Enabled = False And rekening3.Enabled = False And tijd3.Enabled = False And actie4.Enabled = False And Service4.Enabled = False And factureren4.Enabled = False And kantoor4.Enabled = False And rekening4.Enabled = False And tijd4.Enabled = False And _
                actie5.Enabled = False And Service5.Enabled = False And factureren5.Enabled = False And kantoor5.Enabled = False And rekening5.Enabled = False And tijd5.Enabled = False And actie6.Enabled = False And Service6.Enabled = False And factureren6.Enabled = False And kantoor6.Enabled = False And rekening6.Enabled = False And tijd6.Enabled = False And actie7.Enabled = False And Service7.Enabled = False And factureren7.Enabled = False And kantoor7.Enabled = False And rekening7.Enabled = False And tijd7.Enabled = False And actie8.Enabled = False And Service8.Enabled = False And factureren8.Enabled = False And kantoor8.Enabled = False And rekening8.Enabled = False And tijd8.Enabled = False And _
                actie9.Enabled = False And Service9.Enabled = False And factureren9.Enabled = False And kantoor9.Enabled = False And rekening9.Enabled = False And tijd9.Enabled = False And actie10.Enabled = False And Service10.Enabled = False And factureren10.Enabled = False And kantoor10.Enabled = False And rekening10.Enabled = False And tijd10.Enabled = False And actie11.Enabled = False And Service11.Enabled = False And factureren11.Enabled = False And kantoor11.Enabled = False And rekening11.Enabled = False And tijd11.Enabled = False And actie13.Enabled = False And Service13.Enabled = False And factureren13.Enabled = False And kantoor13.Enabled = False And rekening13.Enabled = False And tijd13.Enabled = False And actie12.Enabled = False And Service12.Enabled = False And factureren12.Enabled = False And kantoor12.Enabled = False And rekening12.Enabled = False And tijd12.Enabled = False And _
                actie14.Enabled = False And Service14.Enabled = False And factureren14.Enabled = False And kantoor14.Enabled = False And rekening14.Enabled = False And tijd14.Enabled = False And actie15.Enabled = False And Service15.Enabled = False And factureren15.Enabled = False And kantoor15.Enabled = False And rekening15.Enabled = False And tijd15.Enabled = False And actie16.Enabled = False And Service16.Enabled = False And factureren16.Enabled = False And kantoor16.Enabled = False And rekening16.Enabled = False And tijd16.Enabled = False And actie17.Enabled = False And Service17.Enabled = False And factureren17.Enabled = False And kantoor17.Enabled = False And rekening17.Enabled = False And tijd17.Enabled = False And _
                actie18.Enabled = False And Service18.Enabled = False And factureren18.Enabled = False And kantoor18.Enabled = False And rekening18.Enabled = False And tijd18.Enabled = False And actie19.Enabled = False And Service19.Enabled = False And factureren19.Enabled = False And kantoor19.Enabled = False And rekening19.Enabled = False And tijd19.Enabled = False And actie20.Enabled = False And Service20.Enabled = False And factureren20.Enabled = False And kantoor20.Enabled = False And rekening20.Enabled = False And tijd20.Enabled = False Then
            x = x
        Else : x = x + 1
        End If

        If x > DataGridView1.Rows.Count - 1 Then x = DataGridView1.Rows.Count - 1




        dataverkrijgen()
        DataGridView1.Rows(x).Selected = True
        Start()



    End Sub

    '' bereken hoevaak er voorrijkosten worden geboekt ''
    Private Sub voorrijkosten()
        '' Kijkt hoe vaak er voorrijkosten zijn geboekt.
        NR = 0
        For Each DataGridViewRow In DataGridView2.Rows
            Try
                If DataGridViewRow.Cells(4).Value = "Ja klantlocatie" Then
                    NR += 1
                ElseIf DataGridViewRow.Cells(4).Value = "Ja service" Then
                    NR += 1
                ElseIf DataGridViewRow.Cells(4).Value = "Ja andere locatie" Then
                    NR += 1
                End If
            Catch ex As Exception
            End Try

        Next
        TextBox8.Text = NR & " keer"
    End Sub

    '' Kijkt hoe vaak er buiten kantoor uren is geboekt ''
    Private Sub Buitenkantooruren()

        NR2 = 0
        For Each DataGridViewRow In DataGridView2.Rows
            Try
                If DataGridViewRow.Cells(5).Value = "Weekend" Then
                    NR2 += 1
                ElseIf DataGridViewRow.Cells(5).Value = "Avond" Then
                    NR2 += 1
                End If
            Catch ex As Exception
            End Try

        Next
        TextBox18.Text = NR2
    End Sub

    '' berekening voor alle uren ''
    Private Sub Tijd()
        Try
            '' 1 Rij
            If DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(5).Value = "Weekend" Then
                buiten1.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(5).Value = "Avond" Then
                buiten1.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(5).Value = " " Then
                binnen1.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(7).Value
            Else : binnen1.Text = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(7).Value
            End If
            '' 2 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(5).Value = "Weekend" Then
                buiten2.Text = DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(5).Value = "Avond" Then
                buiten2.Text = DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(7).Value
            Else : binnen2.Text = DataGridView2.Rows(DataGridView2.Rows(1).Index).Cells(7).Value
            End If
            '' 3 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(5).Value = "Weekend" Then
                buiten3.Text = DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(5).Value = "Avond" Then
                buiten3.Text = DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(7).Value
            Else : binnen3.Text = DataGridView2.Rows(DataGridView2.Rows(2).Index).Cells(7).Value
            End If
            '' 4 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(5).Value = "Weekend" Then
                buiten4.Text = DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(5).Value = "Avond" Then
                buiten4.Text = DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(7).Value
            Else : binnen4.Text = DataGridView2.Rows(DataGridView2.Rows(3).Index).Cells(7).Value
            End If
            '' 5 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(5).Value = "Weekend" Then
                buiten5.Text = DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(5).Value = "Avond" Then
                buiten5.Text = DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(7).Value
            Else : binnen5.Text = DataGridView2.Rows(DataGridView2.Rows(4).Index).Cells(7).Value
            End If
            '' 6 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(5).Value = "Weekend" Then
                buiten6.Text = DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(5).Value = "Avond" Then
                buiten6.Text = DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(7).Value
            Else : binnen6.Text = DataGridView2.Rows(DataGridView2.Rows(5).Index).Cells(7).Value
            End If
            '' 7 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(5).Value = "Weekend" Then
                buiten7.Text = DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(5).Value = "Avond" Then
                buiten7.Text = DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(7).Value
            Else : binnen7.Text = DataGridView2.Rows(DataGridView2.Rows(6).Index).Cells(7).Value
            End If
            '' 8 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(5).Value = "Weekend" Then
                buiten8.Text = DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(5).Value = "Avond" Then
                buiten8.Text = DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(7).Value
            Else : binnen8.Text = DataGridView2.Rows(DataGridView2.Rows(7).Index).Cells(7).Value
            End If
            '' 9 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(5).Value = "Weekend" Then
                buiten9.Text = DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(5).Value = "Avond" Then
                buiten9.Text = DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(7).Value
            Else : binnen9.Text = DataGridView2.Rows(DataGridView2.Rows(8).Index).Cells(7).Value
            End If
            '' 10 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(5).Value = "Weekend" Then
                buiten10.Text = DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(5).Value = "Avond" Then
                buiten10.Text = DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(7).Value
            Else : binnen10.Text = DataGridView2.Rows(DataGridView2.Rows(9).Index).Cells(7).Value
            End If
            '' 11 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(5).Value = "Weekend" Then
                buiten11.Text = DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(5).Value = "Avond" Then
                buiten11.Text = DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(7).Value
            Else : binnen11.Text = DataGridView2.Rows(DataGridView2.Rows(10).Index).Cells(7).Value
            End If
            '' 12 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(5).Value = "Weekend" Then
                buiten12.Text = DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(5).Value = "Avond" Then
                buiten12.Text = DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(7).Value
            Else : binnen12.Text = DataGridView2.Rows(DataGridView2.Rows(11).Index).Cells(7).Value
            End If
            '' 13 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(5).Value = "Weekend" Then
                buiten13.Text = DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(5).Value = "Avond" Then
                buiten13.Text = DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(7).Value
            Else : binnen13.Text = DataGridView2.Rows(DataGridView2.Rows(12).Index).Cells(7).Value
            End If
            '' 14 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(5).Value = "Weekend" Then
                buiten14.Text = DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(5).Value = "Avond" Then
                buiten14.Text = DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(7).Value
            Else : binnen14.Text = DataGridView2.Rows(DataGridView2.Rows(13).Index).Cells(7).Value
            End If
            '' 15 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(5).Value = "Weekend" Then
                buiten15.Text = DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(5).Value = "Avond" Then
                buiten15.Text = DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(7).Value
            Else : binnen15.Text = DataGridView2.Rows(DataGridView2.Rows(14).Index).Cells(7).Value
            End If
            '' 16 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(5).Value = "Weekend" Then
                buiten16.Text = DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(5).Value = "Avond" Then
                buiten16.Text = DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(7).Value
            Else : binnen16.Text = DataGridView2.Rows(DataGridView2.Rows(15).Index).Cells(7).Value
            End If
            '' 17 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(5).Value = "Weekend" Then
                buiten17.Text = DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(5).Value = "Avond" Then
                buiten17.Text = DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(7).Value
            Else : binnen17.Text = DataGridView2.Rows(DataGridView2.Rows(16).Index).Cells(7).Value
            End If
            '' 18 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(5).Value = "Weekend" Then
                buiten18.Text = DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(5).Value = "Avond" Then
                buiten18.Text = DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(7).Value
            Else : binnen18.Text = DataGridView2.Rows(DataGridView2.Rows(17).Index).Cells(7).Value
            End If
            '' 19 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(5).Value = "Weekend" Then
                buiten19.Text = DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(5).Value = "Avond" Then
                buiten19.Text = DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(7).Value
            Else : binnen19.Text = DataGridView2.Rows(DataGridView2.Rows(18).Index).Cells(7).Value
            End If
            '' 20 Rijen
            If DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(5).Value = "Weekend" Then
                buiten20.Text = DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(7).Value
            ElseIf DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(5).Value = "Avond" Then
                buiten20.Text = DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(7).Value
            Else : binnen20.Text = DataGridView2.Rows(DataGridView2.Rows(19).Index).Cells(7).Value
            End If
        Catch ex As Exception
        End Try
        '' berekening voor alle uren binnen kantoor tijd.
        TextBox14.Text = (Val(binnen1.Text) + Val(binnen2.Text) + Val(binnen3.Text) + Val(binnen4.Text) + Val(binnen5.Text) + Val(binnen6.Text) + Val(binnen7.Text) + Val(binnen8.Text) + Val(binnen9.Text) + Val(binnen10.Text) + Val(binnen11.Text) + Val(binnen12.Text) + Val(binnen13.Text) + Val(binnen14.Text) + Val(binnen15.Text) + Val(binnen16.Text) + Val(binnen17.Text) + Val(binnen18.Text) + Val(binnen19.Text) + Val(binnen20.Text))
        '' berekening voor alle uren buiten kantoor tijd.
        TextBox13.Text = (Val(buiten1.Text) + Val(buiten2.Text) + Val(buiten3.Text) + Val(buiten4.Text) + Val(buiten5.Text) + Val(buiten6.Text) + Val(buiten7.Text) + Val(buiten8.Text) + Val(buiten9.Text) + Val(buiten10.Text) + Val(buiten11.Text) + Val(buiten12.Text) + Val(buiten13.Text) + Val(buiten14.Text) + Val(buiten15.Text) + Val(buiten16.Text) + Val(buiten17.Text) + Val(buiten18.Text) + Val(buiten19.Text) + Val(buiten20.Text))
    End Sub

    '' buttons Die niet werken.
    'Private Sub Button4_Click_1(sender As Object, e As EventArgs)
    '    Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
    '    Dim command As New System.Data.SqlClient.SqlCommand
    '    connection.Open()
    '    command.Connection = connection
    '    command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (WorkOrder.WORKORDERID='" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString) & "')"
    '    Try
    '        If System.Windows.MessageBox.Show("Weet je zeker dat je Call ID '" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString) & "' wilt markeren als 'Akkoord - te factureren' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then

    '            command.ExecuteNonQuery()
    '            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE='Billed' WHERE (WORKORDERID='" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString) & "')"
    '            command.ExecuteNonQuery()
    '            connection.Close()
    '            System.Windows.MessageBox.Show("Call ID '" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString) & "' is nu gemarkeerd als 'Akkoord - te factureren' ", "Klaar")
    '            ''Dit is de melding die je krijgt als je nee antwoord.
    '        Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
    '        End If
    '    Catch ex As Exception
    '        System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
    '    End Try

    'End Sub

    'Private Sub Button5_Click_1(sender As Object, e As EventArgs)
    '    Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
    '    Dim command As New System.Data.SqlClient.SqlCommand
    '    connection.Open()
    '    command.Connection = connection
    '    command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (WorkOrder.WORKORDERID='" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(2).Value.ToString) & "')"
    '    Try
    '        If System.Windows.MessageBox.Show("Weet je zeker dat je Call ID '" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString) & "' wilt markeren als 'Akkoord - service' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
    '            command.ExecuteNonQuery()
    '            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE='Billed' WHERE (WORKORDERID='" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString) & "')"
    '            command.ExecuteNonQuery()
    '            connection.Close()
    '            System.Windows.MessageBox.Show("Call ID '" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value.ToString) & "' is nu gemarkeerd als 'Akkoord - service' ", "Klaar")
    '            ''Dit is de melding die je krijgt als je nee antwoord.
    '        Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
    '        End If
    '    Catch ex As Exception
    '        System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
    '    End Try
    'End Sub
  

    '' 20 Functies om een actie te markeren als "Akkoord - Service"
    '' Voor elke actie een eigen knop '' 
    Private Sub Service1_Click(sender As Object, e As EventArgs) Handles Service1.Click


        'If DataGridViewRow.Cells(4).Value = "Ja andere locatie" And DataGridViewRow.Cells(16).Value = "" Then
        ' MessageBox.Show("'Voorrijkosten andere locatie' gekozen maar er is geen bedrag voor ' Voorrijkosten andere locatie' ingevuld", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
        ' GoTo line3
        ' End If
        If Actie1.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening1.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry1.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry1.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service1.Enabled = False
            factureren1.Enabled = False
            Actie1.Enabled = False
            kantoor1.Enabled = False
            rekening1.Enabled = False
            tijd1.Enabled = False
            uren1.Enabled = False
            afgehandeld1.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        Start()
line3:
    End Sub
    Private Sub service2_Click(sender As Object, e As EventArgs) Handles Service2.Click
        If actie2.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg en kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening2.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry2.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry2.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service2.Enabled = False
            factureren2.Enabled = False
            actie2.Enabled = False
            kantoor2.Enabled = False
            rekening2.Enabled = False
            tijd2.Enabled = False
            uren2.Enabled = False
            afgehandeld2.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service3_Click(sender As Object, e As EventArgs) Handles Service3.Click
        If actie3.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening3.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry3.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry3.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service3.Enabled = False
            factureren3.Enabled = False
            actie3.Enabled = False
            kantoor3.Enabled = False
            rekening3.Enabled = False
            tijd3.Enabled = False
            uren3.Enabled = False
            afgehandeld3.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service4_Click(sender As Object, e As EventArgs) Handles Service4.Click
        If actie4.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening4.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry4.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry4.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service4.Enabled = False
            factureren4.Enabled = False
            actie4.Enabled = False
            kantoor4.Enabled = False
            rekening4.Enabled = False
            tijd4.Enabled = False
            uren4.Enabled = False
            afgehandeld4.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service5_Click(sender As Object, e As EventArgs) Handles Service5.Click
        If actie5.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening5.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry5.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry5.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service5.Enabled = False
            factureren5.Enabled = False
            actie5.Enabled = False
            kantoor5.Enabled = False
            rekening5.Enabled = False
            tijd5.Enabled = False
            uren5.Enabled = False
            afgehandeld5.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
Line3:
    End Sub
    Private Sub service6_Click(sender As Object, e As EventArgs) Handles Service6.Click
        If actie6.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening6.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry6.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry6.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service6.Enabled = False
            factureren6.Enabled = False
            actie6.Enabled = False
            kantoor6.Enabled = False
            rekening6.Enabled = False
            tijd6.Enabled = False
            uren6.Enabled = False
            afgehandeld6.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service7_Click(sender As Object, e As EventArgs) Handles Service7.Click
        If actie7.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening7.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry7.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry7.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            System.Windows.MessageBox.Show("De actie is nu gemarkeerd als 'Akkoord - Service' ", "Klaar")
            Service7.Enabled = False
            factureren7.Enabled = False
            actie7.Enabled = False
            kantoor7.Enabled = False
            rekening7.Enabled = False
            tijd7.Enabled = False
            uren7.Enabled = False
            afgehandeld7.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service8_Click(sender As Object, e As EventArgs) Handles Service8.Click
        If actie8.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening8.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry8.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry8.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service8.Enabled = False
            factureren8.Enabled = False
            actie8.Enabled = False
            kantoor8.Enabled = False
            rekening8.Enabled = False
            tijd8.Enabled = False
            uren8.Enabled = False
            afgehandeld8.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service9_Click(sender As Object, e As EventArgs) Handles Service9.Click
        If actie9.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening9.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry9.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry9.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            factureren9.Enabled = False
            Service9.Enabled = False
            actie9.Enabled = False
            kantoor9.Enabled = False
            rekening9.Enabled = False
            tijd9.Enabled = False
            uren9.Enabled = False
            afgehandeld9.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service10_Click(sender As Object, e As EventArgs) Handles Service10.Click
        If actie10.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening10.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry10.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry10.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service10.Enabled = False
            factureren10.Enabled = False
            actie10.Enabled = False
            kantoor10.Enabled = False
            rekening10.Enabled = False
            tijd10.Enabled = False
            uren10.Enabled = False
            afgehandeld10.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service11_Click(sender As Object, e As EventArgs) Handles Service11.Click
        If actie11.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening11.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry11.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry11.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service11.Enabled = False
            factureren11.Enabled = False
            actie11.Enabled = False
            kantoor11.Enabled = False
            rekening11.Enabled = False
            tijd11.Enabled = False
            uren11.Enabled = False
            afgehandeld11.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service12_Click(sender As Object, e As EventArgs) Handles Service12.Click
        If actie12.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening12.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry12.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry12.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service12.Enabled = False
            factureren12.Enabled = False
            actie12.Enabled = False
            kantoor12.Enabled = False
            rekening12.Enabled = False
            tijd12.Enabled = False
            uren12.Enabled = False
            afgehandeld12.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service13_Click(sender As Object, e As EventArgs) Handles Service13.Click
        If actie13.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening13.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry13.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry13.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service13.Enabled = False
            factureren13.Enabled = False
            actie13.Enabled = False
            kantoor13.Enabled = False
            rekening13.Enabled = False
            tijd13.Enabled = False
            uren13.Enabled = False
            afgehandeld13.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service14_Click(sender As Object, e As EventArgs) Handles Service14.Click
        If actie14.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening14.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry14.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry14.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service14.Enabled = False
            factureren14.Enabled = False
            actie14.Enabled = False
            kantoor14.Enabled = False
            rekening14.Enabled = False
            tijd14.Enabled = False
            uren14.Enabled = False
            afgehandeld14.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service15_Click(sender As Object, e As EventArgs) Handles Service15.Click
        If actie15.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening15.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry15.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry15.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service15.Enabled = False
            factureren15.Enabled = False
            actie15.Enabled = False
            kantoor15.Enabled = False
            rekening15.Enabled = False
            tijd15.Enabled = False
            uren15.Enabled = False
            afgehandeld15.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service16_Click(sender As Object, e As EventArgs) Handles Service16.Click
        If actie16.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening16.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry16.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry16.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service16.Enabled = False
            factureren16.Enabled = False
            actie16.Enabled = False
            kantoor16.Enabled = False
            rekening16.Enabled = False
            tijd16.Enabled = False
            uren16.Enabled = False
            afgehandeld16.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service17_Click(sender As Object, e As EventArgs) Handles Service17.Click
        If actie17.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening17.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry17.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry17.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service17.Enabled = False
            factureren17.Enabled = False
            actie17.Enabled = False
            kantoor17.Enabled = False
            rekening17.Enabled = False
            tijd17.Enabled = False
            uren17.Enabled = False
            afgehandeld17.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service18_Click(sender As Object, e As EventArgs) Handles Service18.Click
        If actie18.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening18.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry18.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry18.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service18.Enabled = False
            factureren18.Enabled = False
            actie18.Enabled = False
            kantoor18.Enabled = False
            rekening18.Enabled = False
            tijd18.Enabled = False
            uren18.Enabled = False
            afgehandeld18.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service19_Click(sender As Object, e As EventArgs) Handles Service19.Click
        If actie19.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening19.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry19.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry19.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service19.Enabled = False
            factureren19.Enabled = False
            actie19.Enabled = False
            kantoor19.Enabled = False
            rekening19.Enabled = False
            tijd19.Enabled = False
            uren19.Enabled = False
            afgehandeld19.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub service20_Click(sender As Object, e As EventArgs) Handles Service20.Click
        If actie20.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Service'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening20.Text = "Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Service' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry20.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry20.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service20.Enabled = False
            factureren20.Enabled = False
            actie20.Enabled = False
            kantoor20.Enabled = False
            rekening20.Enabled = False
            tijd20.Enabled = False
            uren20.Enabled = False
            afgehandeld20.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show(ErrorToString)
        End Try
line3:
    End Sub

    '' 20 Functies om een actie te markeren als "Akkoord - Te factureren"
    '' Voor elke actie een eigen knop
    Private Sub factureren1_Click(sender As Object, e As EventArgs) Handles factureren1.Click
        If Actie1.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening1.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry1.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry1.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service1.Enabled = False
            factureren1.Enabled = False
            Actie1.Enabled = False
            kantoor1.Enabled = False
            rekening1.Enabled = False
            tijd1.Enabled = False
            uren1.Enabled = False
            afgehandeld1.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren2_Click(sender As Object, e As EventArgs) Handles factureren2.Click
        If actie2.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening2.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry2.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry2.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service2.Enabled = False
            factureren2.Enabled = False
            actie2.Enabled = False
            kantoor2.Enabled = False
            rekening2.Enabled = False
            tijd2.Enabled = False
            uren2.Enabled = False
            afgehandeld2.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren3_Click(sender As Object, e As EventArgs) Handles factureren3.Click
        If actie3.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening3.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry3.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry3.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service3.Enabled = False
            factureren3.Enabled = False
            actie3.Enabled = False
            kantoor3.Enabled = False
            rekening3.Enabled = False
            tijd3.Enabled = False
            uren3.Enabled = False
            afgehandeld3.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren4_Click(sender As Object, e As EventArgs) Handles factureren4.Click
        If actie4.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening4.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry4.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry4.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service4.Enabled = False
            factureren4.Enabled = False
            actie4.Enabled = False
            kantoor4.Enabled = False
            rekening4.Enabled = False
            tijd4.Enabled = False
            uren4.Enabled = False
            afgehandeld4.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren5_Click(sender As Object, e As EventArgs) Handles factureren5.Click
        If actie5.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening5.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry5.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry5.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service5.Enabled = False
            factureren5.Enabled = False
            actie5.Enabled = False
            kantoor5.Enabled = False
            rekening5.Enabled = False
            tijd5.Enabled = False
            uren5.Enabled = False
            afgehandeld5.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren6_Click(sender As Object, e As EventArgs) Handles factureren6.Click
        If actie6.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening6.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry6.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry6.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service6.Enabled = False
            factureren6.Enabled = False
            actie6.Enabled = False
            kantoor6.Enabled = False
            rekening6.Enabled = False
            tijd6.Enabled = False
            uren6.Enabled = False
            afgehandeld6.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren7_Click(sender As Object, e As EventArgs) Handles factureren7.Click
        If actie7.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening7.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry7.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry7.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service7.Enabled = False
            factureren7.Enabled = False
            actie7.Enabled = False
            kantoor7.Enabled = False
            rekening7.Enabled = False
            tijd7.Enabled = False
            uren7.Enabled = False
            afgehandeld7.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren8_Click(sender As Object, e As EventArgs) Handles factureren8.Click
        If actie8.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening8.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry8.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry8.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service8.Enabled = False
            factureren8.Enabled = False
            actie8.Enabled = False
            kantoor8.Enabled = False
            rekening8.Enabled = False
            tijd8.Enabled = False
            uren8.Enabled = False
            afgehandeld8.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren9_Click(sender As Object, e As EventArgs) Handles factureren9.Click
        If actie9.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening9.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry9.Text) & "')"
        Try
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry9.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service9.Enabled = False
            factureren9.Enabled = False
            actie9.Enabled = False
            kantoor9.Enabled = False
            rekening9.Enabled = False
            tijd9.Enabled = False
            uren9.Enabled = False
            afgehandeld9.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren10_Click(sender As Object, e As EventArgs) Handles factureren10.Click
        If actie10.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening10.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry10.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry10.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service10.Enabled = False
            factureren10.Enabled = False
            actie10.Enabled = False
            kantoor10.Enabled = False
            rekening10.Enabled = False
            tijd10.Enabled = False
            uren10.Enabled = False
            afgehandeld10.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren11_Click(sender As Object, e As EventArgs) Handles factureren11.Click
        If actie11.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening11.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry11.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry11.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service11.Enabled = False
            factureren11.Enabled = False
            actie11.Enabled = False
            kantoor11.Enabled = False
            rekening11.Enabled = False
            tijd11.Enabled = False
            uren11.Enabled = False
            afgehandeld11.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren12_Click(sender As Object, e As EventArgs) Handles factureren12.Click
        If actie12.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening12.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry12.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry12.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service12.Enabled = False
            factureren12.Enabled = False
            actie12.Enabled = False
            kantoor12.Enabled = False
            rekening12.Enabled = False
            tijd12.Enabled = False
            uren12.Enabled = False
            afgehandeld12.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren13_Click(sender As Object, e As EventArgs) Handles factureren13.Click
        If actie13.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening13.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry13.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry13.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service13.Enabled = False
            factureren13.Enabled = False
            actie13.Enabled = False
            kantoor13.Enabled = False
            rekening13.Enabled = False
            tijd13.Enabled = False
            uren13.Enabled = False
            afgehandeld13.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren14_Click(sender As Object, e As EventArgs) Handles factureren14.Click
        If actie14.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening14.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry14.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry14.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service14.Enabled = False
            factureren14.Enabled = False
            actie14.Enabled = False
            kantoor14.Enabled = False
            rekening14.Enabled = False
            tijd14.Enabled = False
            uren14.Enabled = False
            afgehandeld14.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren15_Click(sender As Object, e As EventArgs) Handles factureren15.Click
        If actie15.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening15.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry15.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry15.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service15.Enabled = False
            factureren15.Enabled = False
            actie15.Enabled = False
            kantoor15.Enabled = False
            rekening15.Enabled = False
            tijd15.Enabled = False
            uren15.Enabled = False
            afgehandeld15.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren16_Click(sender As Object, e As EventArgs) Handles factureren16.Click
        If actie16.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening16.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry16.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry16.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service16.Enabled = False
            factureren16.Enabled = False
            actie16.Enabled = False
            kantoor16.Enabled = False
            rekening16.Enabled = False
            tijd16.Enabled = False
            uren16.Enabled = False
            afgehandeld16.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren17_Click(sender As Object, e As EventArgs) Handles factureren17.Click
        If actie17.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening17.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry17.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry17.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service17.Enabled = False
            factureren17.Enabled = False
            actie17.Enabled = False
            kantoor17.Enabled = False
            rekening17.Enabled = False
            tijd17.Enabled = False
            uren17.Enabled = False
            afgehandeld17.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren18_Click(sender As Object, e As EventArgs) Handles factureren18.Click
        If actie18.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening18.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry18.Text) & "')"
        Try

            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry18.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service18.Enabled = False
            factureren18.Enabled = False
            actie18.Enabled = False
            kantoor18.Enabled = False
            rekening18.Enabled = False
            tijd18.Enabled = False
            uren18.Enabled = False
            afgehandeld18.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren19_Click(sender As Object, e As EventArgs) Handles factureren19.Click
        If actie19.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening19.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry19.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry19.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service19.Enabled = False
            factureren19.Enabled = False
            actie19.Enabled = False
            kantoor19.Enabled = False
            rekening19.Enabled = False
            tijd19.Enabled = False
            uren19.Enabled = False
            afgehandeld19.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub
    Private Sub factureren20_Click(sender As Object, e As EventArgs) Handles factureren20.Click
        If actie20.Text = Nothing Then
            MessageBox.Show("Het 'Actie' veld is leeg, kan niet worden gemarkeerd als 'Akkoord - Te factureren'", "Let op!", MessageBoxButtons.OK, MessageBoxIcon.Question)
            GoTo line3
        End If
        If rekening20.Text = "Non-Billable" Then
            Dim response = MessageBox.Show("De supportmedewerker heeft aangeveven dat deze actie 'Non-Billable' is wil je alsnog doorgaan en deze actie markeren als 'Akkoord - Te factureren' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                GoTo line2
            Else
                GoTo line3
            End If
        End If
line2:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry20.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry20.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service20.Enabled = False
            factureren20.Enabled = False
            actie20.Enabled = False
            kantoor20.Enabled = False
            rekening20.Enabled = False
            tijd20.Enabled = False
            uren20.Enabled = False
            afgehandeld20.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line3:
    End Sub

    '' 20 Functies om een actie te markeren als "Afgehandeld - Niet gefactureerd"
    '' Voor elke actie een eigen knop
    Private Sub afgehandeld1_Click(sender As Object, e As EventArgs) Handles afgehandeld1.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry1.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry1.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service1.Enabled = False
            afgehandeld1.Enabled = False
            Actie1.Enabled = False
            kantoor1.Enabled = False
            rekening1.Enabled = False
            tijd1.Enabled = False
            factureren1.Enabled = False
            uren1.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld2_Click(sender As Object, e As EventArgs) Handles afgehandeld2.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry2.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry2.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service2.Enabled = False
            afgehandeld2.Enabled = False
            actie2.Enabled = False
            kantoor2.Enabled = False
            rekening2.Enabled = False
            tijd2.Enabled = False
            factureren2.Enabled = False
            uren2.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld3_Click(sender As Object, e As EventArgs) Handles afgehandeld3.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry3.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry3.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service3.Enabled = False
            afgehandeld3.Enabled = False
            actie3.Enabled = False
            kantoor3.Enabled = False
            rekening3.Enabled = False
            tijd3.Enabled = False
            factureren3.Enabled = False
            uren3.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld4_Click(sender As Object, e As EventArgs) Handles afgehandeld4.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry4.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry4.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service4.Enabled = False
            afgehandeld4.Enabled = False
            actie4.Enabled = False
            kantoor4.Enabled = False
            rekening4.Enabled = False
            tijd4.Enabled = False
            factureren4.Enabled = False
            uren4.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld5_Click(sender As Object, e As EventArgs) Handles afgehandeld5.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry5.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry5.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service5.Enabled = False
            afgehandeld5.Enabled = False
            actie5.Enabled = False
            kantoor5.Enabled = False
            rekening5.Enabled = False
            tijd5.Enabled = False
            factureren5.Enabled = False
            uren5.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld6_Click(sender As Object, e As EventArgs) Handles afgehandeld6.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry6.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry6.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service6.Enabled = False
            afgehandeld6.Enabled = False
            actie6.Enabled = False
            kantoor6.Enabled = False
            rekening6.Enabled = False
            tijd6.Enabled = False
            factureren6.Enabled = False
            uren6.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld7_Click(sender As Object, e As EventArgs) Handles afgehandeld7.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry7.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry7.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service7.Enabled = False
            afgehandeld7.Enabled = False
            actie7.Enabled = False
            kantoor7.Enabled = False
            rekening7.Enabled = False
            tijd7.Enabled = False
            factureren7.Enabled = False
            uren7.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
Line2:
    End Sub
    Private Sub afgehandeld8_Click(sender As Object, e As EventArgs) Handles afgehandeld8.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry8.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry8.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service8.Enabled = False
            afgehandeld8.Enabled = False
            actie8.Enabled = False
            kantoor8.Enabled = False
            rekening8.Enabled = False
            tijd8.Enabled = False
            factureren8.Enabled = False
            uren8.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld9_Click(sender As Object, e As EventArgs) Handles afgehandeld9.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry9.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry9.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service9.Enabled = False
            afgehandeld9.Enabled = False
            actie9.Enabled = False
            kantoor9.Enabled = False
            rekening9.Enabled = False
            tijd9.Enabled = False
            factureren9.Enabled = False
            uren9.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
Line2:
    End Sub
    Private Sub afgehandeld10_Click(sender As Object, e As EventArgs) Handles afgehandeld10.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry10.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry10.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service10.Enabled = False
            afgehandeld10.Enabled = False
            actie10.Enabled = False
            kantoor10.Enabled = False
            rekening10.Enabled = False
            tijd10.Enabled = False
            factureren10.Enabled = False
            uren10.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld11_Click(sender As Object, e As EventArgs) Handles afgehandeld11.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry11.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry11.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service11.Enabled = False
            afgehandeld11.Enabled = False
            actie11.Enabled = False
            kantoor11.Enabled = False
            rekening11.Enabled = False
            tijd11.Enabled = False
            factureren11.Enabled = False
            uren11.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld12_Click(sender As Object, e As EventArgs) Handles afgehandeld12.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry12.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry12.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service12.Enabled = False
            afgehandeld12.Enabled = False
            actie12.Enabled = False
            kantoor12.Enabled = False
            rekening12.Enabled = False
            tijd12.Enabled = False
            factureren12.Enabled = False
            uren12.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld13_Click(sender As Object, e As EventArgs) Handles afgehandeld13.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry13.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry13.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service13.Enabled = False
            afgehandeld13.Enabled = False
            actie13.Enabled = False
            kantoor13.Enabled = False
            rekening13.Enabled = False
            tijd13.Enabled = False
            factureren13.Enabled = False
            uren13.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld14_Click(sender As Object, e As EventArgs) Handles afgehandeld14.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry14.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry14.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service14.Enabled = False
            afgehandeld14.Enabled = False
            actie14.Enabled = False
            kantoor14.Enabled = False
            rekening14.Enabled = False
            tijd14.Enabled = False
            factureren14.Enabled = False
            uren14.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld15_Click(sender As Object, e As EventArgs) Handles afgehandeld15.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry15.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry15.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service15.Enabled = False
            afgehandeld15.Enabled = False
            actie15.Enabled = False
            kantoor15.Enabled = False
            rekening15.Enabled = False
            tijd15.Enabled = False
            factureren15.Enabled = False
            uren15.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld16_Click(sender As Object, e As EventArgs) Handles afgehandeld16.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry16.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry16.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service16.Enabled = False
            afgehandeld16.Enabled = False
            actie16.Enabled = False
            kantoor16.Enabled = False
            rekening16.Enabled = False
            tijd16.Enabled = False
            factureren16.Enabled = False
            uren16.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld17_Click(sender As Object, e As EventArgs) Handles afgehandeld17.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry17.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry17.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service17.Enabled = False
            afgehandeld17.Enabled = False
            actie17.Enabled = False
            kantoor17.Enabled = False
            rekening17.Enabled = False
            tijd17.Enabled = False
            factureren17.Enabled = False
            uren17.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub
    Private Sub afgehandeld18_Click(sender As Object, e As EventArgs) Handles afgehandeld18.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry18.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry18.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service18.Enabled = False
            factureren18.Enabled = False
            actie18.Enabled = False
            kantoor18.Enabled = False
            rekening18.Enabled = False
            tijd18.Enabled = False
            afgehandeld18.Enabled = False
            uren18.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
LINE2:
    End Sub
    Private Sub afgehandeld19_Click(sender As Object, e As EventArgs) Handles afgehandeld19.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry19.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry19.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service19.Enabled = False
            factureren19.Enabled = False
            actie19.Enabled = False
            kantoor19.Enabled = False
            rekening19.Enabled = False
            tijd19.Enabled = False
            afgehandeld19.Enabled = False
            uren19.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
LINE2:
    End Sub
    Private Sub afgehandeld20_Click(sender As Object, e As EventArgs) Handles afgehandeld20.Click
        Dim response = MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als " & "Afgehandeld - Niet gefactureerd", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry20.Text) & "')"
            command.ExecuteNonQuery()
            command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry20.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()
            Service20.Enabled = False
            afgehandeld20.Enabled = False
            actie20.Enabled = False
            kantoor20.Enabled = False
            rekening20.Enabled = False
            tijd20.Enabled = False
            afgehandeld20.Enabled = False
            uren20.Enabled = False
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
line2:
    End Sub

    '' 20 Functies om de tijd van een actie te markeren als "Binnen kantoor uren"
    '' Voor elke actie een eigen knop
    Private Sub uren1_Click(sender As Object, e As EventArgs) Handles uren1.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand

        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry1.Text) & "')"
            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren1.Enabled = False
line2:
    End Sub
    Private Sub uren2_Click(sender As Object, e As EventArgs) Handles uren2.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry2.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren2.Enabled = False
line2:
    End Sub
    Private Sub uren3_Click(sender As Object, e As EventArgs) Handles uren3.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry3.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren3.Enabled = False
line2:
    End Sub
    Private Sub uren4_Click(sender As Object, e As EventArgs) Handles uren4.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry4.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren4.Enabled = False
line2:
    End Sub
    Private Sub uren5_Click(sender As Object, e As EventArgs) Handles uren5.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry5.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren5.Enabled = False
line2:
    End Sub
    Private Sub uren6_Click(sender As Object, e As EventArgs) Handles uren6.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry6.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren6.Enabled = False
line2:
    End Sub
    Private Sub uren7_Click(sender As Object, e As EventArgs) Handles uren7.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry7.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren7.Enabled = False
line2:
    End Sub
    Private Sub uren8_Click(sender As Object, e As EventArgs) Handles uren8.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry8.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren8.Enabled = False
line2:
    End Sub
    Private Sub uren9_Click(sender As Object, e As EventArgs) Handles uren9.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry9.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren9.Enabled = False
line2:
    End Sub
    Private Sub uren10_Click(sender As Object, e As EventArgs) Handles uren10.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry10.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren10.Enabled = False
line2:
    End Sub
    Private Sub uren11_Click(sender As Object, e As EventArgs) Handles uren11.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry11.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren11.Enabled = False
line2:
    End Sub
    Private Sub uren12_Click(sender As Object, e As EventArgs) Handles uren12.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry12.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren12.Enabled = False
line2:
    End Sub
    Private Sub uren13_Click(sender As Object, e As EventArgs) Handles uren13.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry13.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren13.Enabled = False
line2:
    End Sub
    Private Sub uren14_Click(sender As Object, e As EventArgs) Handles uren14.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry14.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren14.Enabled = False
line2:
    End Sub
    Private Sub uren15_Click(sender As Object, e As EventArgs) Handles uren15.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry15.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren15.Enabled = False
line2:
    End Sub
    Private Sub uren16_Click(sender As Object, e As EventArgs) Handles uren16.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry16.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren16.Enabled = False
line2:
    End Sub
    Private Sub uren17_Click(sender As Object, e As EventArgs) Handles uren17.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry17.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren17.Enabled = False
line2:
    End Sub
    Private Sub uren18_Click(sender As Object, e As EventArgs) Handles uren18.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry18.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren18.Enabled = False
line2:
    End Sub
    Private Sub uren19_Click(sender As Object, e As EventArgs) Handles uren19.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry19.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren19.Enabled = False
line2:
    End Sub
    Private Sub uren20_Click(sender As Object, e As EventArgs) Handles uren20.Click
        Dim response = MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als " & "'Binnen kantoor' ?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = MsgBoxResult.Yes Then
            GoTo line1
        Else
            GoTo line2
        End If
line1:
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        connection.Open()
        command.Connection = connection
        command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(timeentry20.Text) & "')"
        Try

            command.ExecuteNonQuery()
            connection.Close()

        Catch ex As Exception
            System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
        End Try
        uren20.Enabled = False
line2:
    End Sub

    '' functie om de knoppen grijs te maken als bv een call billed is kan je niet akkoorderen.
    '' en worden de knoppen dus grijs gemaakt zodat je ze niet kan gebruiken.
    Private Sub knoppen()
        If rekening1.Text = "Billed" Then
            Service1.Enabled = False
            factureren1.Enabled = False
            Actie1.Enabled = False
            kantoor1.Enabled = False
            rekening1.Enabled = False
            tijd1.Enabled = False
            afgehandeld1.Enabled = False
        Else
            Service1.Enabled = True
            factureren1.Enabled = True
            Actie1.Enabled = True
            kantoor1.Enabled = True
            rekening1.Enabled = True
            tijd1.Enabled = True
            afgehandeld1.Enabled = True
        End If
        If kantoor1.Text = "Avond" Or kantoor1.Text = "Weekend" Then
            uren1.Enabled = True
        Else
            uren1.Enabled = False
        End If
        If tijd1.Text = "00:00" Then
            Service1.Enabled = False
            factureren1.Enabled = False
            afgehandeld1.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------

        If tijd2.Text = Nothing Then
            Service2.Enabled = False
            factureren2.Enabled = False
            actie2.Enabled = False
            kantoor2.Enabled = False
            rekening2.Enabled = False
            tijd2.Enabled = False
            afgehandeld2.Enabled = False
        Else
            Service2.Enabled = True
            factureren2.Enabled = True
            actie2.Enabled = True
            kantoor2.Enabled = True
            rekening2.Enabled = True
            tijd2.Enabled = True
            afgehandeld2.Enabled = True
        End If
        If kantoor2.Text = "Avond" Or kantoor2.Text = "Weekend" Then
            uren2.Enabled = True
        Else
            uren2.Enabled = False
        End If
        If rekening2.Text = "Billed" Then
            Service2.Enabled = False
            factureren2.Enabled = False
            actie2.Enabled = False
            kantoor2.Enabled = False
            rekening2.Enabled = False
            tijd2.Enabled = False
            afgehandeld2.Enabled = False
            uren2.Enabled = False

        End If

        If tijd2.Text = "00:00" Then
            Service2.Enabled = False
            factureren2.Enabled = False
            afgehandeld2.Enabled = True
        End If

        ''--------------------------------
        ''-------------------------------
        If tijd3.Text = Nothing Then
            Service3.Enabled = False
            factureren3.Enabled = False
            actie3.Enabled = False
            kantoor3.Enabled = False
            rekening3.Enabled = False
            tijd3.Enabled = False
            afgehandeld3.Enabled = False
        Else
            Service3.Enabled = True
            factureren3.Enabled = True
            actie3.Enabled = True
            kantoor3.Enabled = True
            rekening3.Enabled = True
            tijd3.Enabled = True
            afgehandeld3.Enabled = True
        End If
        If kantoor3.Text = "Avond" Or kantoor3.Text = "Weekend" Then
            uren3.Enabled = True
        Else
            uren3.Enabled = False
        End If
        If rekening3.Text = "Billed" Then
            Service3.Enabled = False
            factureren3.Enabled = False
            actie3.Enabled = False
            kantoor3.Enabled = False
            rekening3.Enabled = False
            tijd3.Enabled = False
            afgehandeld3.Enabled = False
            uren3.Enabled = False
        End If
        If tijd3.Text = "00:00" Then
            Service3.Enabled = False
            factureren3.Enabled = False
            afgehandeld3.Enabled = True
        End If

        ''--------------------------------
        ''-------------------------------
        If tijd4.Text = Nothing Then
            Service4.Enabled = False
            factureren4.Enabled = False
            actie4.Enabled = False
            kantoor4.Enabled = False
            rekening4.Enabled = False
            tijd4.Enabled = False
            afgehandeld4.Enabled = False
        Else
            Service4.Enabled = True
            factureren4.Enabled = True
            actie4.Enabled = True
            kantoor4.Enabled = True
            rekening4.Enabled = True
            tijd4.Enabled = True
            afgehandeld4.Enabled = True
        End If
        If kantoor4.Text = "Avond" Or kantoor4.Text = "Weekend" Then
            uren4.Enabled = True
        Else
            uren4.Enabled = False
        End If
        If rekening4.Text = "Billed" Then
            Service4.Enabled = False
            factureren4.Enabled = False
            actie4.Enabled = False
            kantoor4.Enabled = False
            rekening4.Enabled = False
            tijd4.Enabled = False
            afgehandeld4.Enabled = False
            uren4.Enabled = False
        End If
        If tijd4.Text = "00:00" Then
            Service4.Enabled = False
            factureren4.Enabled = False
            afgehandeld4.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If tijd5.Text = Nothing Then

            Service5.Enabled = False
            factureren5.Enabled = False
            actie5.Enabled = False
            kantoor5.Enabled = False
            rekening5.Enabled = False
            tijd5.Enabled = False
            afgehandeld5.Enabled = False
        Else
            Service5.Enabled = True
            factureren5.Enabled = True
            actie5.Enabled = True
            kantoor5.Enabled = True
            rekening5.Enabled = True
            tijd5.Enabled = True
            afgehandeld5.Enabled = True
        End If
        If kantoor5.Text = "Avond" Or kantoor5.Text = "Weekend" Then
            uren5.Enabled = True
        Else
            uren5.Enabled = False
        End If
        If rekening5.Text = "Billed" Then
            Service5.Enabled = False
            factureren5.Enabled = False
            actie5.Enabled = False
            kantoor5.Enabled = False
            rekening5.Enabled = False
            tijd5.Enabled = False
            afgehandeld5.Enabled = False
            uren5.Enabled = False
        End If
        If tijd5.Text = "00:00" Then
            Service5.Enabled = False
            factureren5.Enabled = False
            afgehandeld5.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If tijd6.Text = Nothing Then

            Service6.Enabled = False
            factureren6.Enabled = False
            actie6.Enabled = False
            kantoor6.Enabled = False
            rekening6.Enabled = False
            tijd6.Enabled = False
            afgehandeld6.Enabled = False
        Else
            Service6.Enabled = True
            factureren6.Enabled = True
            actie6.Enabled = True
            kantoor6.Enabled = True
            rekening6.Enabled = True
            tijd6.Enabled = True
            afgehandeld6.Enabled = True
        End If
        If kantoor6.Text = "Avond" Or kantoor6.Text = "Weekend" Then
            uren6.Enabled = True
        Else
            uren6.Enabled = False
        End If
        If rekening6.Text = "Billed" Then
            Service6.Enabled = False
            factureren6.Enabled = False
            actie6.Enabled = False
            kantoor6.Enabled = False
            rekening6.Enabled = False
            tijd6.Enabled = False
            afgehandeld6.Enabled = False
            uren6.Enabled = False
        End If
        If tijd6.Text = "00:00" Then
            Service6.Enabled = False
            factureren6.Enabled = False
            afgehandeld6.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening7.Text = Nothing Then
            uren7.Enabled = False
            Service7.Enabled = False
            factureren7.Enabled = False
            actie7.Enabled = False
            kantoor7.Enabled = False
            rekening7.Enabled = False
            tijd7.Enabled = False
            afgehandeld7.Enabled = False
        Else : uren7.Enabled = True
            Service7.Enabled = True
            factureren7.Enabled = True
            actie7.Enabled = True
            kantoor7.Enabled = True
            rekening7.Enabled = True
            tijd7.Enabled = True
            afgehandeld7.Enabled = True
        End If
        If kantoor7.Text = "Avond" Or kantoor7.Text = "Weekend" Then
            uren7.Enabled = True
        Else
            uren7.Enabled = False
        End If
        If rekening7.Text = "Billed" Then
            Service7.Enabled = False
            factureren7.Enabled = False
            actie7.Enabled = False
            kantoor7.Enabled = False
            rekening7.Enabled = False
            tijd7.Enabled = False
            afgehandeld7.Enabled = False
            uren7.Enabled = False
        End If
        If tijd7.Text = "00:00" Then
            Service7.Enabled = False
            factureren7.Enabled = False
            afgehandeld7.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening8.Text = Nothing Then
            uren8.Enabled = False
            Service8.Enabled = False
            factureren8.Enabled = False
            actie8.Enabled = False
            kantoor8.Enabled = False
            rekening8.Enabled = False
            tijd8.Enabled = False
            afgehandeld8.Enabled = False
        Else : uren8.Enabled = True
            Service8.Enabled = True
            factureren8.Enabled = True
            actie8.Enabled = True
            kantoor8.Enabled = True
            rekening8.Enabled = True
            tijd8.Enabled = True
            afgehandeld8.Enabled = True
        End If
        If kantoor8.Text = "Avond" Or kantoor8.Text = "Weekend" Then
            uren8.Enabled = True
        Else
            uren8.Enabled = False
        End If
        If rekening8.Text = "Billed" Then
            Service8.Enabled = False
            factureren8.Enabled = False
            actie8.Enabled = False
            kantoor8.Enabled = False
            rekening8.Enabled = False
            tijd8.Enabled = False
            afgehandeld8.Enabled = False
            uren8.Enabled = False
        End If
        If tijd8.Text = "00:00" Then
            Service8.Enabled = False
            factureren8.Enabled = False
            afgehandeld8.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening9.Text = Nothing Then

            Service9.Enabled = False
            factureren9.Enabled = False
            actie9.Enabled = False
            kantoor9.Enabled = False
            rekening9.Enabled = False
            tijd9.Enabled = False
            afgehandeld9.Enabled = False
        Else
            Service9.Enabled = True
            factureren9.Enabled = True
            actie9.Enabled = True
            kantoor9.Enabled = True
            rekening9.Enabled = True
            tijd9.Enabled = True
            afgehandeld9.Enabled = True
        End If
        If kantoor9.Text = "Avond" Or kantoor9.Text = "Weekend" Then
            uren9.Enabled = True
        Else
            uren9.Enabled = False
        End If
        If rekening9.Text = "Billed" Then
            Service9.Enabled = False
            factureren9.Enabled = False
            actie9.Enabled = False
            kantoor9.Enabled = False
            rekening9.Enabled = False
            tijd9.Enabled = False
            afgehandeld9.Enabled = False
            uren9.Enabled = False
        End If
        If tijd9.Text = "00:00" Then
            Service9.Enabled = False
            factureren9.Enabled = False
            afgehandeld9.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening10.Text = Nothing Then

            Service10.Enabled = False
            factureren10.Enabled = False
            actie10.Enabled = False
            kantoor10.Enabled = False
            rekening10.Enabled = False
            tijd10.Enabled = False
            afgehandeld10.Enabled = False
        Else
            Service10.Enabled = True
            factureren10.Enabled = True
            actie10.Enabled = True
            kantoor10.Enabled = True
            rekening10.Enabled = True
            tijd10.Enabled = True
            afgehandeld10.Enabled = True
        End If
        If kantoor10.Text = "Avond" Or kantoor10.Text = "Weekend" Then
            uren10.Enabled = True
        Else
            uren10.Enabled = False
        End If
        If rekening10.Text = "Billed" Then
            Service10.Enabled = False
            factureren10.Enabled = False
            actie10.Enabled = False
            kantoor10.Enabled = False
            rekening10.Enabled = False
            tijd10.Enabled = False
            afgehandeld10.Enabled = False
            uren10.Enabled = False
        End If
        If tijd10.Text = "00:00" Then
            Service10.Enabled = False
            factureren10.Enabled = False
            afgehandeld10.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening11.Text = Nothing Then

            Service11.Enabled = False
            factureren11.Enabled = False
            actie11.Enabled = False
            kantoor11.Enabled = False
            rekening11.Enabled = False
            tijd11.Enabled = False
            afgehandeld11.Enabled = False
        Else
            Service11.Enabled = True
            factureren11.Enabled = True
            actie11.Enabled = True
            kantoor11.Enabled = True
            rekening11.Enabled = True
            tijd11.Enabled = True
            afgehandeld11.Enabled = True
        End If
        If kantoor11.Text = "Avond" Or kantoor11.Text = "Weekend" Then
            uren11.Enabled = True
        Else
            uren11.Enabled = False
        End If
        If rekening11.Text = "Billed" Then
            Service11.Enabled = False
            factureren11.Enabled = False
            actie11.Enabled = False
            kantoor11.Enabled = False
            rekening11.Enabled = False
            tijd11.Enabled = False
            afgehandeld11.Enabled = False
            uren11.Enabled = False
        End If
        If tijd11.Text = "00:00" Then
            Service11.Enabled = False
            factureren11.Enabled = False
            afgehandeld11.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening12.Text = Nothing Then

            Service12.Enabled = False
            factureren12.Enabled = False
            actie12.Enabled = False
            kantoor12.Enabled = False
            rekening12.Enabled = False
            tijd12.Enabled = False
            afgehandeld12.Enabled = False
        Else
            Service12.Enabled = True
            factureren12.Enabled = True
            actie12.Enabled = True
            kantoor12.Enabled = True
            rekening12.Enabled = True
            tijd12.Enabled = True
            afgehandeld12.Enabled = True
        End If
        If kantoor12.Text = "Avond" Or kantoor12.Text = "Weekend" Then
            uren12.Enabled = True
        Else
            uren12.Enabled = False
        End If
        If rekening12.Text = "Billed" Then
            Service12.Enabled = False
            factureren12.Enabled = False
            actie12.Enabled = False
            kantoor12.Enabled = False
            rekening12.Enabled = False
            tijd12.Enabled = False
            afgehandeld12.Enabled = False
            uren12.Enabled = False
        End If
        If tijd12.Text = "00:00" Then
            Service12.Enabled = False
            factureren12.Enabled = False
            afgehandeld12.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening13.Text = Nothing Then

            Service13.Enabled = False
            factureren13.Enabled = False
            actie13.Enabled = False
            kantoor13.Enabled = False
            rekening13.Enabled = False
            tijd13.Enabled = False
            afgehandeld13.Enabled = False
        Else
            Service13.Enabled = True
            factureren13.Enabled = True
            actie13.Enabled = True
            kantoor13.Enabled = True
            rekening13.Enabled = True
            tijd13.Enabled = True
            afgehandeld13.Enabled = True
        End If
        If kantoor13.Text = "Avond" Or kantoor13.Text = "Weekend" Then
            uren13.Enabled = True
        Else
            uren13.Enabled = False
        End If
        If rekening13.Text = "Billed" Then
            Service13.Enabled = False
            factureren13.Enabled = False
            actie13.Enabled = False
            kantoor13.Enabled = False
            rekening13.Enabled = False
            tijd13.Enabled = False
            afgehandeld13.Enabled = False
            uren13.Enabled = False
        End If
        If tijd13.Text = "00:00" Then
            Service13.Enabled = False
            factureren13.Enabled = False
            afgehandeld13.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening14.Text = Nothing Then
            Service14.Enabled = False
            factureren14.Enabled = False
            actie14.Enabled = False
            kantoor14.Enabled = False
            rekening14.Enabled = False
            tijd14.Enabled = False
            afgehandeld14.Enabled = False
        Else : Service14.Enabled = True
            factureren14.Enabled = True
            actie14.Enabled = True
            kantoor14.Enabled = True
            rekening14.Enabled = True
            tijd14.Enabled = True
            afgehandeld14.Enabled = True
        End If
        If kantoor14.Text = "Avond" Or kantoor14.Text = "Weekend" Then
            uren14.Enabled = True
        Else
            uren14.Enabled = False
        End If
        If rekening14.Text = "Billed" Then
            Service14.Enabled = False
            factureren14.Enabled = False
            actie14.Enabled = False
            kantoor14.Enabled = False
            rekening14.Enabled = False
            tijd14.Enabled = False
            afgehandeld14.Enabled = False
            uren14.Enabled = False
        End If
        If tijd14.Text = "00:00" Then
            Service14.Enabled = False
            factureren14.Enabled = False
            afgehandeld14.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening15.Text = Nothing Then
            Service15.Enabled = False
            factureren15.Enabled = False
            actie15.Enabled = False
            kantoor15.Enabled = False
            rekening15.Enabled = False
            tijd15.Enabled = False
            afgehandeld15.Enabled = False
        Else : Service15.Enabled = True
            factureren15.Enabled = True
            actie15.Enabled = True
            kantoor15.Enabled = True
            rekening15.Enabled = True
            tijd15.Enabled = True
            afgehandeld15.Enabled = True
        End If
        If kantoor15.Text = "Avond" Or kantoor15.Text = "Weekend" Then
            uren15.Enabled = True
        Else
            uren15.Enabled = False
        End If
        If rekening15.Text = "Billed" Then
            Service15.Enabled = False
            factureren15.Enabled = False
            actie15.Enabled = False
            kantoor15.Enabled = False
            rekening15.Enabled = False
            tijd15.Enabled = False
            afgehandeld15.Enabled = False
            uren15.Enabled = False
        End If
        If tijd15.Text = "00:00" Then
            Service15.Enabled = False
            factureren15.Enabled = False
            afgehandeld15.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening16.Text = Nothing Then
            Service16.Enabled = False
            factureren16.Enabled = False
            actie16.Enabled = False
            kantoor16.Enabled = False
            rekening16.Enabled = False
            tijd16.Enabled = False
            afgehandeld16.Enabled = False
        Else : Service16.Enabled = True
            factureren16.Enabled = True
            actie16.Enabled = True
            kantoor16.Enabled = True
            rekening16.Enabled = True
            tijd16.Enabled = True
            afgehandeld16.Enabled = True
        End If
        If kantoor16.Text = "Avond" Or kantoor16.Text = "Weekend" Then
            uren16.Enabled = True
        Else
            uren16.Enabled = False
        End If
        If rekening16.Text = "Billed" Then
            Service16.Enabled = False
            factureren16.Enabled = False
            actie16.Enabled = False
            kantoor16.Enabled = False
            rekening16.Enabled = False
            tijd16.Enabled = False
            afgehandeld16.Enabled = False
            uren16.Enabled = False
        End If
        If tijd16.Text = "00:00" Then
            Service16.Enabled = False
            factureren16.Enabled = False
            afgehandeld16.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening17.Text = Nothing Then
            Service17.Enabled = False
            factureren17.Enabled = False
            actie17.Enabled = False
            kantoor17.Enabled = False
            rekening17.Enabled = False
            tijd17.Enabled = False
            afgehandeld17.Enabled = False
        Else : Service17.Enabled = True
            factureren17.Enabled = True
            actie17.Enabled = True
            kantoor17.Enabled = True
            rekening17.Enabled = True
            tijd17.Enabled = True
            afgehandeld17.Enabled = True
        End If
        If kantoor17.Text = "Avond" Or kantoor17.Text = "Weekend" Then
            uren17.Enabled = True
        Else
            uren17.Enabled = False
        End If
        If rekening17.Text = "Billed" Then
            Service17.Enabled = False
            factureren17.Enabled = False
            actie17.Enabled = False
            kantoor17.Enabled = False
            rekening17.Enabled = False
            tijd17.Enabled = False
            afgehandeld17.Enabled = False
            uren17.Enabled = False
        End If
        If tijd17.Text = "00:00" Then
            Service17.Enabled = False
            factureren17.Enabled = False
            afgehandeld17.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening18.Text = Nothing Then
            Service18.Enabled = False
            factureren18.Enabled = False
            actie18.Enabled = False
            kantoor18.Enabled = False
            rekening18.Enabled = False
            tijd18.Enabled = False
            afgehandeld18.Enabled = False
        Else : Service18.Enabled = True
            factureren18.Enabled = True
            actie18.Enabled = True
            kantoor18.Enabled = True
            rekening18.Enabled = True
            tijd18.Enabled = True
            afgehandeld18.Enabled = True
        End If
        If kantoor18.Text = "Avond" Or kantoor18.Text = "Weekend" Then
            uren18.Enabled = True
        Else
            uren18.Enabled = False
        End If
        If rekening18.Text = "Billed" Then
            Service18.Enabled = False
            factureren18.Enabled = False
            actie18.Enabled = False
            kantoor18.Enabled = False
            rekening18.Enabled = False
            tijd18.Enabled = False
            afgehandeld18.Enabled = False
            uren18.Enabled = False
        End If
        If tijd18.Text = "00:00" Then
            Service18.Enabled = False
            factureren18.Enabled = False
            afgehandeld18.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening19.Text = Nothing Then
            Service19.Enabled = False
            factureren19.Enabled = False
            actie19.Enabled = False
            kantoor19.Enabled = False
            rekening19.Enabled = False
            tijd19.Enabled = False
            afgehandeld19.Enabled = False
        Else : Service19.Enabled = True
            factureren19.Enabled = True
            actie19.Enabled = True
            kantoor19.Enabled = True
            rekening19.Enabled = True
            tijd19.Enabled = True
            afgehandeld19.Enabled = True
        End If
        If kantoor19.Text = "Avond" Or kantoor19.Text = "Weekend" Then
            uren19.Enabled = True
        Else
            uren19.Enabled = False
        End If
        If rekening19.Text = "Billed" Then
            Service19.Enabled = False
            factureren19.Enabled = False
            actie19.Enabled = False
            kantoor19.Enabled = False
            rekening19.Enabled = False
            tijd19.Enabled = False
            afgehandeld19.Enabled = False
            uren19.Enabled = False
        End If
        If tijd19.Text = "00:00" Then
            Service19.Enabled = False
            factureren19.Enabled = False
            afgehandeld19.Enabled = True
        End If
        ''--------------------------------
        ''-------------------------------
        If rekening20.Text = Nothing Then
            Service20.Enabled = False
            factureren20.Enabled = False
            actie20.Enabled = False
            kantoor20.Enabled = False
            rekening20.Enabled = False
            tijd20.Enabled = False
            afgehandeld20.Enabled = False
        Else : Service20.Enabled = True
            factureren20.Enabled = True
            actie20.Enabled = True
            kantoor20.Enabled = True
            rekening20.Enabled = True
            tijd20.Enabled = True
            afgehandeld20.Enabled = True
        End If
        If kantoor20.Text = "Avond" Or kantoor20.Text = "Weekend" Then
            uren20.Enabled = True
        Else
            uren20.Enabled = False
        End If
        If rekening20.Text = "Billed" Then
            Service20.Enabled = False
            factureren20.Enabled = False
            actie20.Enabled = False
            kantoor20.Enabled = False
            rekening20.Enabled = False
            tijd20.Enabled = False
            afgehandeld20.Enabled = False
            uren20.Enabled = False
        End If
        If tijd20.Text = "00:00" Then
            Service20.Enabled = False
            factureren20.Enabled = False
            afgehandeld20.Enabled = True
        End If
        ''--------------------------------
    End Sub


    '' Functie om de tijd te berekenen ''
    Function GetHoursMinutes(ByVal lMinutes As Long) As String
        Dim lHours As Long
        lHours = lMinutes \ 60
        lMinutes = lMinutes Mod 60
        GetHoursMinutes = Format(lHours, "0#") & ":" & Format(lMinutes, "0#")
    End Function

    '' Link naar de call ''
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Link.Click
        '' link naar de call
        Dim fullpath As String = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
        If System.IO.File.Exists(fullpath) Then
            Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://service.ucsystems.net/WorkOrder.do?woMode=viewWO&woID=" & Trim(DataGridView2.Rows(DataGridView2.SelectedRows(0).Index).Cells(0).Value.ToString()) & "&" & "")
        Else
            Dim ie As Object
            Dim url As String = "http://service.ucsystems.net/WorkOrder.do?woMode=viewWO&woID=" & Trim(DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(0).Value.ToString()) & "&" & ""
            ie = CreateObject("INTERNETEXPLORER.APPLICATION")
            ie.Visible = True
            ie.NAVIGATE(url)
        End If
    End Sub

    '' Functie om HTML tags uit de text te filteren ''
    Function StripHTML(sInput As String) As String
        '' functie om html tags uit text te filteren.
        Dim RegEx As Object
        RegEx = CreateObject("vbscript.regexp")

        Dim sOut As String
        With RegEx
            .Global = True
            .IgnoreCase = True
            .MultiLine = True
            .Pattern = "<[^>]+>" 'Regular Expression for HTML Tags.
        End With

        sOut = RegEx.Replace(sInput, "")
        StripHTML = sOut
        RegEx = Nothing
    End Function


End Class