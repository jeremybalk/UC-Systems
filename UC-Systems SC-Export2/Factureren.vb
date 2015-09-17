Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Access
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Core
Imports System.Xml
Imports System.Threading
Imports System.Math

Module Module1
    '' Module om html tags uit de text te krijgen.
    Sub Main()
        ' Input.
        Dim html As String = Tool.DataGridView1.Rows(Tool.DataGridView1.SelectedRows(0).Index).Cells(12).Value

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
        Return Regex.Replace(html, "<.*?>", "")
    End Function

End Module

Public Class Factureren
    Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
    Dim NR As Long = 0
    Dim NR2 As Long = 0
    Dim scrollval As Integer
    Dim dataadapter As SqlDataAdapter
    Dim dataadapter2 As SqlDataAdapter
    Dim ds As New DataSet()


    Private Sub datagridview0()
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        ''                                                             [0]                                                                                                                                         [1]                                                                                [2]                                               [3]                                            [4]                                          [5]                                                                                                         [6]                                                                                                                                                 [7]                                              [8]                                               [9]                                                            [10]                                          [11]                                                                             [12]                                           [13]                                                    [14]                                        [15]                   [16]                                         [17]                                                [18]                                                                        
        '' SQL Query met alle data voor calls met de status "Akkoord - Service"
        Dim sql As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 2) AS numeric(36, 2)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,WorkOrder.DESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN Department_Account RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN            WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN AaaUser AS AaaUser_3 INNER JOIN RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN  AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (AaaOrganization.NAME = '" & Trim(ComboBox1.SelectedItem) & "') AND (TimeEntry_Fields.UDF_CHAR3 = N'Akkoord - Service') and (RequestCharges.CHARGETYPE= N'Billed') ORDER BY bedrijf "
        '' SQL Query met alle data voor calls met de status "Akkoord - Te Factureren"
        Dim sql2 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 2) AS numeric(36, 2)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,WorkOrder.DESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN Department_Account RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN            WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN AaaUser AS AaaUser_3 INNER JOIN RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN  AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (AaaOrganization.NAME = '" & Trim(ComboBox1.SelectedItem) & "') AND (TimeEntry_Fields.UDF_CHAR3 = N'Akkoord - Te factureren') and (RequestCharges.CHARGETYPE= N'Billed') ORDER BY bedrijf "
        dataadapter = New SqlDataAdapter(sql, connection)
        dataadapter2 = New SqlDataAdapter(sql2, connection)
        ds = New DataSet
        Try
            '' verberg colommen die overbodig zijn.
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(13).Visible = True
            DataGridView1.Columns(12).Visible = True
            DataGridView1.Columns(11).Visible = True
            DataGridView1.Columns(10).Visible = True
            DataGridView1.Columns(9).Visible = True
            DataGridView1.Columns(8).Visible = True
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(6).Visible = True
            DataGridView1.Columns(5).Visible = True
        Catch ex As Exception
        End Try
        DataGridView1.MultiSelect = True

        Try


            connection.Open()
            '' vul de tabel met de data van bijde Query's
            dataadapter.Fill(ds, "WorkOrder")
            dataadapter2.Fill(ds, "WorkOrder")
            connection.Close()
            DataGridView1.DataSource = (ds)
            DataGridView1.DataMember = "WorkOrder"
        Catch ex As Exception
            System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!", MessageBoxButton.OK, MessageBoxImage.Error)
        End Try
        '' Minimale uren.
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(8).Value >= "0,01" And row.Cells(8).Value <= "0,08" Then
                row.Cells(8).Value = "0,08"
            End If
        Next
        Try
            '' HTML tags uit de text filteren.
            For Each row As DataGridViewRow In DataGridView1.Rows
                Module2.StripTags(row.Cells(6).Value)
                row.Cells(6).Value = row.Cells(6).Value.Replace("&#43;", "+")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&amp;", "&")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&lt;", "<")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&gt;", ">")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&#8216;", "'")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&#8217;", "'")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&#8226;", "")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&#8220;", "")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&#8221;", "")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&#8230;", "")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&quot;", "'")
                row.Cells(6).Value = row.Cells(6).Value.Replace("&middot;", "•")
                row.Cells(6).Value = row.Cells(6).Value.Replace(".&lt;BR&gt;", ".")
                row.Cells(6).Value = row.Cells(6).Value.Replace("<br>", Environment.NewLine)
                row.Cells(6).Value = row.Cells(6).Value.Replace("<BR>", Environment.NewLine)
                row.Cells(6).Value = row.Cells(6).Value.Replace("&nbsp;", Environment.NewLine)
                row.Cells(6).Value = StripHTML(row.Cells(6).Value.ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
        Try
            '' HTML tags uit de text filteren.
            For Each row As DataGridViewRow In DataGridView1.Rows
                Try
                    Module2.StripTags(row.Cells(13).Value)
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&#43;", "+")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&amp;", "&")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&lt;", "<")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&gt;", ">")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&#8216;", "'")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&#8217;", "'")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&#8226;", "")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&#8220;", "")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&#8221;", "")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&#8230;", "")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&quot;", "'")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&middot;", "")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace(".&lt;BR&gt;", ".")
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("<br>", Environment.NewLine)
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("<BR>", Environment.NewLine)
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = row.Cells(13).Value.Replace("&nbsp;", Environment.NewLine)
                Catch ex As Exception
                End Try
                Try
                    row.Cells(13).Value = StripHTML(row.Cells(13).Value.ToString)
                Catch ex As Exception
                End Try

            Next
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try

        Try
            '' HTML tags uit de text filteren.
            For Each row As DataGridViewRow In DataGridView1.Rows
                Module2.StripTags(row.Cells(12).Value)
                row.Cells(12).Value = row.Cells(12).Value.Replace("&#43;", "+")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&amp;", "&")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&lt;", "<")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&gt;", ">")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&#8216;", "'")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&#8217;", "'")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&#8226;", "")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&#8220;", "")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&#8221;", "")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&#8230;", "")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&quot;", "'")
                row.Cells(12).Value = row.Cells(12).Value.Replace("&middot;", "•")
                row.Cells(12).Value = row.Cells(12).Value.Replace(".&lt;BR&gt;", ".")
                row.Cells(12).Value = row.Cells(12).Value.Replace("<br>", Environment.NewLine)
                row.Cells(12).Value = row.Cells(12).Value.Replace("<BR>", Environment.NewLine)
                row.Cells(12).Value = row.Cells(12).Value.Replace("&nbsp;", Environment.NewLine)
                row.Cells(12).Value = row.Cells(12).Value.Replace("&nbs", Environment.NewLine)
                row.Cells(12).Value = row.Cells(12).Value.Replace("&n", "")
                row.Cells(12).Value = StripHTML(row.Cells(12).Value.ToString)

            Next
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub Factureren_Load(sender As Object, e As EventArgs) Handles Me.FormClosing
        StartScherm.Show() ''Laad het startscherm zien zodra het formulier word gesloten
    End Sub

    Private Sub Button1_Click() Handles Button5.Click
        '' Vernieuwd de tabel , voert de query's opnieuw uit
        If ComboBox1.Items.Count = "0" Then
            MessageBox.Show("Geen calls om te laten zien", "Fout !", MessageBoxButtons.OK)
        Else
            Call combobox()
            Call ComboBox1_SelectedIndexChanged()
        End If
    End Sub

    Private Sub tijd()
        '' functie die alle tijden uitleest en kijkt wat voor een uren het zijn en dan het totaal aantal berekend.
        Dim B1 As Decimal = "0,000"
        Dim B2 As Decimal = "0,000"
        Dim B3 As Decimal = "0,000"
        Dim B4 As Decimal = "0,000"
        Dim B5 As Decimal = "0,000"
        Dim B6 As Decimal = "0,000"
        Dim B7 As Decimal = "0,000"
        Dim B8 As Decimal = "0,000"
        Dim B9 As Decimal = "0,000"
        Dim B10 As Decimal = "0,000"
        Dim A1 As Decimal = "0,000"
        Dim A2 As Decimal = "0,000"
        Dim A3 As Decimal = "0,000"
        Dim A4 As Decimal = "0,000"
        Dim A5 As Decimal = "0,000"
        Dim A6 As Decimal = "0,000"
        Dim A7 As Decimal = "0,000"
        Dim A8 As Decimal = "0,000"
        Dim A9 As Decimal = "0,000"
        Dim A10 As Decimal = "0,000"
        Dim Ax1 As Decimal = "0,000"
        Dim Ax2 As Decimal = "0,000"
        Dim Ax3 As Decimal = "0,000"
        Dim Ax4 As Decimal = "0,000"
        Dim Ax5 As Decimal = "0,000"
        Dim Ax6 As Decimal = "0,000"
        Dim Ax7 As Decimal = "0,000"
        Dim Ax8 As Decimal = "0,000"
        Dim Ax9 As Decimal = "0,000"
        Dim Ax10 As Decimal = "0,000"
        Dim W1 As Decimal = "0,000"
        Dim W2 As Decimal = "0,000"
        Dim W3 As Decimal = "0,000"
        Dim W4 As Decimal = "0,000"
        Dim W5 As Decimal = "0,000"
        Dim W6 As Decimal = "0,000"
        Dim W7 As Decimal = "0,000"
        Dim W8 As Decimal = "0,000"
        Dim W9 As Decimal = "0,000"
        Dim W10 As Decimal = "0,000"
        Dim Wx1 As Decimal = "0,000"
        Dim Wx2 As Decimal = "0,000"
        Dim Wx3 As Decimal = "0,000"
        Dim Wx4 As Decimal = "0,000"
        Dim Wx5 As Decimal = "0,000"
        Dim Wx6 As Decimal = "0,000"
        Dim Wx7 As Decimal = "0,000"
        Dim Wx8 As Decimal = "0,000"
        Dim Wx9 As Decimal = "0,000"
        Dim Wx10 As Decimal = "0,000"
        Dim tot1 As Decimal = "0,000"
        Dim tot2 As Decimal = "0,000"
        Dim tot3 As Decimal = "0,000"
        Dim tot4 As Decimal = "0,000"
        Dim tot5 As Decimal = "0,000"
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            If row.Cells(6).Value = "Nee" Then
                Try
                    binnen.Text += row.Cells(7).Value.ToString & Environment.NewLine
                Catch ex As Exception
                End Try
            End If
            If row.Cells(6).Value = "Avond" And row.Cells(17).Value.ToString.StartsWith("AS94-10") Then
                Try
                    avondx.Text += row.Cells(7).Value.ToString & Environment.NewLine
                Catch ex As Exception
                End Try
            ElseIf row.Cells(6).Value = "Avond" Then
                Try
                    avond.Text += row.Cells(7).Value.ToString & Environment.NewLine
                Catch ex As Exception
                End Try

            End If
            If row.Cells(6).Value = "Weekend" And row.Cells(17).Value.ToString.StartsWith("AS94-10") Then
                Try
                    weekendx.Text += row.Cells(7).Value.ToString & Environment.NewLine
                Catch ex As Exception
                End Try
            ElseIf row.Cells(6).Value = "Weekend" Then
                Try
                    Weekend.Text += row.Cells(7).Value.ToString & Environment.NewLine
                Catch ex As Exception

                End Try
            End If
            Try
                binnen1.Text = binnen.Lines(0).ToString
            Catch ex As Exception
            End Try
            Try
                binnen2.Text = binnen.Lines(1).ToString
            Catch ex As Exception
            End Try
            Try
                binnen3.Text = binnen.Lines(2).ToString
            Catch ex As Exception
            End Try
            Try
                binnen4.Text = binnen.Lines(3).ToString
            Catch ex As Exception
            End Try
            Try
                binnen5.Text = binnen.Lines(4).ToString
            Catch ex As Exception
            End Try
            Try
                binnen6.Text = binnen.Lines(5).ToString
            Catch ex As Exception
            End Try
            Try
                binnen7.Text = binnen.Lines(6).ToString
            Catch ex As Exception
            End Try
            Try
                binnen8.Text = binnen.Lines(7).ToString
            Catch ex As Exception
            End Try
            Try
                binnen9.Text = binnen.Lines(8).ToString
            Catch ex As Exception
            End Try
            Try

                binnen10.Text = binnen.Lines(9).ToString
            Catch ex As Exception
            End Try
            Try
                avond1.Text = avond.Lines(0).ToString
            Catch ex As Exception
            End Try
            Try
                avond2.Text = avond.Lines(1).ToString
            Catch ex As Exception
            End Try
            Try
                avond3.Text = avond.Lines(2).ToString
            Catch ex As Exception
            End Try
            Try
                avond4.Text = avond.Lines(3).ToString
            Catch ex As Exception
            End Try
            Try
                avond5.Text = avond.Lines(4).ToString
            Catch ex As Exception
            End Try
            Try
                avond6.Text = avond.Lines(5).ToString
            Catch ex As Exception
            End Try
            Try
                avond7.Text = avond.Lines(6).ToString
            Catch ex As Exception
            End Try
            Try
                avond8.Text = avond.Lines(7).ToString
            Catch ex As Exception
            End Try
            Try
                avond9.Text = avond.Lines(8).ToString
            Catch ex As Exception
            End Try
            Try

                avond10.Text = avond.Lines(9).ToString
            Catch ex As Exception
            End Try
            Try

                weekend1.Text = Weekend.Lines(0).ToString
            Catch ex As Exception
            End Try
            Try
                weekend2.Text = Weekend.Lines(1).ToString
            Catch ex As Exception
            End Try
            Try
                weekend3.Text = Weekend.Lines(2).ToString
            Catch ex As Exception
            End Try
            Try
                weekend4.Text = Weekend.Lines(3).ToString
            Catch ex As Exception
            End Try
            Try
                weekend5.Text = Weekend.Lines(4).ToString
            Catch ex As Exception
            End Try
            Try
                weekend6.Text = Weekend.Lines(5).ToString
            Catch ex As Exception
            End Try
            Try
                weekend7.Text = Weekend.Lines(6).ToString
            Catch ex As Exception
            End Try
            Try
                weekend8.Text = Weekend.Lines(7).ToString
            Catch ex As Exception
            End Try
            Try
                weekend9.Text = Weekend.Lines(8).ToString
            Catch ex As Exception
            End Try
            Try
                weekend10.Text = Weekend.Lines(9).ToString
            Catch ex As Exception
            End Try
            Try

                weekendx1.Text = weekendx.Lines(0).ToString
            Catch ex As Exception
            End Try
            Try
                weekendx2.Text = weekendx.Lines(1).ToString
            Catch ex As Exception
            End Try
            Try
                weekendx3.Text = weekendx.Lines(2).ToString
            Catch ex As Exception
            End Try
            Try
                weekendx4.Text = weekendx.Lines(3).ToString
            Catch ex As Exception
            End Try
            Try
                weekendx5.Text = weekendx.Lines(4).ToString
            Catch ex As Exception
            End Try
            Try
                weekendx6.Text = weekendx.Lines(5).ToString
            Catch ex As Exception
            End Try
            Try
                weekendx7.Text = weekendx.Lines(6).ToString
            Catch ex As Exception
            End Try
            Try
                weekendx8.Text = weekendx.Lines(7).ToString
            Catch ex As Exception
            End Try
            Try
                weekendx9.Text = weekendx.Lines(8).ToString
            Catch ex As Exception
            End Try
            Try
                weekendx10.Text = weekendx.Lines(9).ToString
            Catch ex As Exception
            End Try
            Try

                avondx1.Text = avondx.Lines(0).ToString
            Catch ex As Exception
            End Try
            Try
                avondx2.Text = avondx.Lines(1).ToString
            Catch ex As Exception
            End Try
            Try
                avondx3.Text = avondx.Lines(2).ToString
            Catch ex As Exception
            End Try
            Try
                avondx4.Text = avondx.Lines(3).ToString
            Catch ex As Exception
            End Try
            Try
                avondx5.Text = avondx.Lines(4).ToString
            Catch ex As Exception
            End Try
            Try
                avondx6.Text = avondx.Lines(5).ToString
            Catch ex As Exception
            End Try
            Try
                avondx7.Text = avondx.Lines(6).ToString
            Catch ex As Exception
            End Try
            Try
                avondx8.Text = avondx.Lines(7).ToString
            Catch ex As Exception
            End Try
            Try
                avondx9.Text = avondx.Lines(8).ToString
            Catch ex As Exception
            End Try
            Try
                avondx10.Text = avondx.Lines(9).ToString
            Catch ex As Exception
            End Try
        Next

        Try
            B1 = binnen.Lines(0).ToString
            B2 = binnen.Lines(1).ToString
            B3 = binnen.Lines(2).ToString
            B4 = binnen.Lines(3).ToString
            B5 = binnen.Lines(4).ToString
            B6 = binnen.Lines(5).ToString
            B7 = binnen.Lines(6).ToString
            B8 = binnen.Lines(7).ToString
            B9 = binnen.Lines(8).ToString
            B10 = binnen.Lines(9).ToString
        Catch ex As Exception
        End Try
        Try
            A1 = avond.Lines(0).ToString
            A2 = avond.Lines(1).ToString
            A3 = avond.Lines(2).ToString
            A4 = avond.Lines(3).ToString
            A5 = avond.Lines(4).ToString
            A6 = avond.Lines(5).ToString
            A7 = avond.Lines(6).ToString
            A8 = avond.Lines(7).ToString
            A9 = avond.Lines(8).ToString
            A10 = avond.Lines(9).ToString
        Catch ex As Exception
        End Try
        Try
            Ax1 = avondx.Lines(0).ToString
            Ax2 = avondx.Lines(1).ToString
            Ax3 = avondx.Lines(2).ToString
            Ax4 = avondx.Lines(3).ToString
            Ax5 = avondx.Lines(4).ToString
            Ax6 = avondx.Lines(5).ToString
            Ax7 = avondx.Lines(6).ToString
            Ax8 = avondx.Lines(7).ToString
            Ax9 = avondx.Lines(8).ToString
            Ax10 = avondx.Lines(9).ToString
        Catch ex As Exception
        End Try
        Try
            W1 = Weekend.Lines(0).ToString
            W2 = Weekend.Lines(1).ToString
            W3 = Weekend.Lines(2).ToString
            W4 = Weekend.Lines(3).ToString
            W5 = Weekend.Lines(4).ToString
            W6 = Weekend.Lines(5).ToString
            W7 = Weekend.Lines(6).ToString
            W8 = Weekend.Lines(7).ToString
            W9 = Weekend.Lines(8).ToString
            W10 = Weekend.Lines(9).ToString
        Catch ex As Exception
        End Try
        Try
            Wx1 = weekendx.Lines(0).ToString
            Wx2 = weekendx.Lines(1).ToString
            Wx3 = weekendx.Lines(2).ToString
            Wx4 = weekendx.Lines(3).ToString
            Wx5 = weekendx.Lines(4).ToString
            Wx6 = weekendx.Lines(5).ToString
            Wx7 = weekendx.Lines(6).ToString
            Wx8 = weekendx.Lines(7).ToString
            Wx9 = weekendx.Lines(8).ToString
            Wx10 = weekendx.Lines(9).ToString
        Catch ex As Exception
        End Try
        Try
            Totaalbinnen.Text = (B1 + B2 + B3 + B4 + B5 + B6 + B7 + B8 + B9 + B10).ToString
        Catch ex As Exception

        End Try
        Try
            totaalavond.Text = (A1 + A2 + A3 + A4 + A5 + A6 + A7 + A8 + A9 + A10).ToString
            totaalavondx15.Text = ((Ax1 + Ax2 + Ax3 + Ax4 + Ax5 + Ax6 + Ax7 + Ax8 + Ax9 + Ax10) * 1.5).ToString
        Catch ex As Exception

        End Try
        Try
            totaalweekend.Text = (W1 + W2 + W3 + W4 + W5 + W6 + W7 + W8 + W9 + W10).ToString
            totaalweekendx2.Text = ((Wx1 + Wx2 + Wx3 + Wx4 + Wx5 + Wx6 + Wx7 + Wx8 + Wx9 + Wx10) * 2.0).ToString
        Catch ex As Exception
        End Try
        Try
            tot1 = Totaalbinnen.Text.ToString
            tot2 = totaalavond.Text.ToString
            tot3 = totaalweekend.Text.ToString
            tot4 = totaalweekendx2.Text.ToString
            tot5 = totaalavondx15.Text.ToString
        Catch ex As Exception

        End Try
        Try
            totaal.Text = (tot1 + tot2 + tot3 + tot4 + tot5).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click() Handles DataGridView1.SelectionChanged
        
        clear()
        Call voorrijkosten()
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            '' plaats de info in de tekstvelden.
            TextBoxinfo.Text = "Call ID: " & row.Cells(0).Value.ToString & Environment.NewLine & _
            "Supportvertegewoordiger: " & row.Cells(4).Value.ToString & Environment.NewLine & _
            "Aanmaak Datum: " & row.Cells(1).Value.ToString & Environment.NewLine & _
              "Bedrijf: " & row.Cells(2).Value.ToString & Environment.NewLine & _
              "Titel: " & row.Cells(11).Value.ToString & Environment.NewLine

            '' HTML tags uit de tekst filteren.
            TextBoxactie.Text = row.Cells(3).Value.ToString
            TextBoxactie.Text = Regex.Replace(TextBoxactie.Text, "<BR>", "")
            TextBoxactie.Text = Regex.Replace(TextBoxactie.Text, ".&lt;BR&g", "")
            TextBoxactie.Text = Regex.Replace(TextBoxactie.Text, ".&lt;BR&g", "")
            TextBoxactie.Text = Regex.Replace(TextBoxactie.Text, "<br>", "")
            TextBoxactie.Text = Regex.Replace(TextBoxactie.Text, "</div>", "")
            TextBoxactie.Text = Regex.Replace(TextBoxactie.Text, "&nbsp;", " ")
            TextBoxactie.Text = Regex.Replace(TextBoxactie.Text, "<(.|\n)*?>", "")
            TextBoxrekening.Text = row.Cells(10).Value.ToString
            TextBoxkantoor.Text = row.Cells(6).Value.ToString
            TextBoxtijd.Text = row.Cells(7).Value.ToString
            '' plaats de data in de tekstvelden
            textboxoplossing.Text = "Omschrijving: " & row.Cells(12).Value.ToString & Environment.NewLine & Environment.NewLine & "Oplossing: " & row.Cells(13).Value.ToString

            '' HTML tags uit de tekst filteren.
            textboxoplossing.Text = Regex.Replace(textboxoplossing.Text, "<BR>", "")
            textboxoplossing.Text = Regex.Replace(textboxoplossing.Text, ".&lt;BR&g", "")
            textboxoplossing.Text = Regex.Replace(textboxoplossing.Text, ".&lt;BR&g", "")
            textboxoplossing.Text = Regex.Replace(textboxoplossing.Text, "<br>", "")
            textboxoplossing.Text = Regex.Replace(textboxoplossing.Text, "</div>", "")
            textboxoplossing.Text = Regex.Replace(textboxoplossing.Text, "&nbsp;", " ")
            textboxoplossing.Text = Regex.Replace(textboxoplossing.Text, "<(.|\n)*?>", "")

        Next
        '' verwijzing naar de functie tijd()
        tijd()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged() Handles ComboBox1.SelectedIndexChanged
        Try
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(13).Visible = True
            DataGridView1.Columns(12).Visible = True
            DataGridView1.Columns(11).Visible = True
            DataGridView1.Columns(10).Visible = True
            DataGridView1.Columns(9).Visible = True
            DataGridView1.Columns(8).Visible = True
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(6).Visible = True
            DataGridView1.Columns(5).Visible = True
        Catch ex As Exception
        End Try
        DataGridView1.MultiSelect = True
        '' SQL Query met alle data voor calls met de status "Akkoord - Service"
        Dim sql2 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 2) AS numeric(36, 2)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,WorkOrder.DESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN Department_Account RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN            WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN AaaUser AS AaaUser_3 INNER JOIN RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN  AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (AaaOrganization.NAME = '" & Trim(ComboBox1.SelectedItem) & "') AND (TimeEntry_Fields.UDF_CHAR3 = N'Akkoord - Service') and (RequestCharges.CHARGETYPE= N'Billed') ORDER BY bedrijf "
        '' SQL Query met alle data voor calls met de status "Akkord - Te Factureren"
        Dim sql3 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 2) AS numeric(36, 2)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,WorkOrder.DESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN Department_Account RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN            WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN AaaUser AS AaaUser_3 INNER JOIN RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN  AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (AaaOrganization.NAME = '" & Trim(ComboBox1.SelectedItem) & "') AND (TimeEntry_Fields.UDF_CHAR3 = N'Akkoord - Te factureren') and (RequestCharges.CHARGETYPE= N'Billed') ORDER BY bedrijf "

        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim dataadapter As New SqlDataAdapter(sql2, connection)
        Dim dataadapter2 As New SqlDataAdapter(sql3, connection)
        scrollval = 0
        Try
            ds.Clear()
            connection.Open()
            dataadapter2.Fill(ds, "WorkOrder")
            dataadapter.Fill(ds, "WorkOrder")
            connection.Close()
            DataGridView1.DataSource = (ds)
            DataGridView1.DataMember = "WorkOrder"
        Catch ex As Exception
            System.Windows.MessageBox.Show("Er zijn geen calls voor dit bedrijf.", "Fout!", MessageBoxButton.OK, MessageBoxImage.Information)
        End Try
        Button2_Click()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(8).Value >= "0,01" And row.Cells(8).Value <= "0,08" Then
                row.Cells(8).Value = "0,08"
            End If
        Next
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' start van het programma 
        Try
            '' verwijzing naar de functie combobox()
            combobox()
            If ComboBox1.Items.Count = "0" Then
                MessageBox.Show("Geen calls om te laten zien", "Fout !", MessageBoxButtons.OK)
            Else
                ComboBox1.SelectedIndex = "0"
                '' verwijzing naar de functie datagridview0()
                Call datagridview0()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click() Handles Button1.Click
        Close() ''sluit het formulier
    End Sub

    Private Sub clear()
        '' Reset alle tekstvelden
        avondx.Clear()
        weekendx.Clear()
        TextBox8.Clear()
        TextBox34.Clear()
        Totaalbinnen.Clear()
        binnen.Clear()
        TextBoxDebtor.Clear()
        TextBox1.Clear()
        TextBoxinfo.Clear()
        Aactie.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBoxactie.Clear()
        TextBox7.Clear()
        voorrrijden.Clear()
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
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox21.Clear()
        TextBox22.Clear()
        TextBox23.Clear()
        TextBox24.Clear()
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
        avond1.Clear()
        avond2.Clear()
        avond3.Clear()
        avond4.Clear()
        avond5.Clear()
        avond6.Clear()
        avond7.Clear()
        avond8.Clear()
        avond9.Clear()
        avond10.Clear()
        avond11.Clear()
        buiten12.Clear()
        buiten13.Clear()
        buiten14.Clear()
        buiten15.Clear()
        buiten16.Clear()
        buiten17.Clear()
        buiten18.Clear()
        buiten19.Clear()
        buiten20.Clear()
        TextBoxrekening.Clear()
        TextBoxkantoor.Clear()
        TextBoxtijd.Clear()
        textboxoplossing.Clear()
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
        Totaalbinnen.Clear()
        totaalavond.Clear()
        binnen.Clear()
        avond.Clear()
        Weekend.Clear()
        totaal.Clear()
        totaalavond.Clear()
        Totaalbinnen.Clear()
        totaalweekend.Clear()
    End Sub

    Private Sub voorrijkosten()
        '' kijkt hoevaak er voorrijkosten zijn geboekt.
        NR = 0
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            Try
                If row.Cells(5).Value = "Ja klantlocatie" Then
                    NR += 1
                ElseIf row.Cells(5).Value = "Ja service" Then
                    NR += 1
                ElseIf row.Cells(5).Value = "Ja andere locatie" Then
                    NR += 1
                End If
            Catch ex As Exception
            End Try

        Next
        voorrrijden.Text = NR
    End Sub

    Private Sub combobox()
        Dim ITEM As String = ComboBox1.SelectedItem
        ComboBox1.Items.Clear()
        '' SQL Query die een lijst met bedrijven ophaalt die tickets open hebben staan met de status "Akkoord - service" en "Akkoord - te factureren"
        Dim sql2 As String = "SELECT DISTINCT AaaOrganization.NAME AS Bedrijf FROM            AaaUser INNER JOIN                         RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID RIGHT OUTER JOIN                         PriorityDefinition RIGHT OUTER JOIN                         StatusDefinition RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID LEFT OUTER JOIN                         RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID ON                          PriorityDefinition.PRIORITYID = WorkOrderStates.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE        (TimeEntry_Fields.UDF_CHAR3 = N'Akkoord - service') OR                         (TimeEntry_Fields.UDF_CHAR3 = N'Akkoord - Te factureren')ORDER BY Bedrijf"
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim dataadapter2 As New SqlDataAdapter(sql2, connection)
        Dim ds3 As New DataSet()
        Try
            connection.Open()
            dataadapter2.Fill(ds3, "TimeEntry_Fields")

            DataGridView2.DataSource = (ds3)
            DataGridView2.DataMember = "TimeEntry_Fields"

        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
        Try
            '' vult de combobox met de bedrijven
            For Each row As DataGridViewRow In DataGridView2.Rows
                ComboBox1.Items.Add(row.Cells(0).Value.ToString)
            Next
        Catch ex As Exception
        End Try
        If ComboBox1.SelectedIndex.Equals(ComboBox1.Items.Count) Then
            MessageBox.Show("Geen calls om te laten zien", "Fout !", MessageBoxButtons.OK)
            Me.Close()
        End If
        Try
            ComboBox1.SelectedIndex = 0
        Catch ex As Exception

        End Try

    End Sub

    Private Sub afhandelen() Handles Button2.Click
        '' functie die het afhandelen van tickets regelt.
        Dim command As New System.Data.SqlClient.SqlCommand
        Dim X As Integer
        X = 0
        connection.Open()
        Do
            '' een check die kijkt wat de status nu is en afhankelijk van het antwoord word er een update uitgevoerd.
            If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(9).Value = "Akkoord - Te factureren" Then
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(14).Value.ToString) & "')"
                command.ExecuteNonQuery()
            ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(9).Value = "Akkoord - Service" Then
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(14).Value.ToString) & "')"
                command.ExecuteNonQuery()
            End If
            X = X + 1
        Loop Until X > DataGridView1.SelectedRows.Count - 1

        connection.Close()
        '' verwijst naar de functie button5 (vernieuwd de tabel)
        Button5.PerformClick()

    End Sub

    Private Sub exportexcel() Handles Button7.Click

        Dim xlApp As Excel.Application
        Dim xlWorkbook As Excel.Workbook
        Dim xlWorksheet As Excel.Worksheet
        Dim misvalue As Object = System.Reflection.Missing.Value
        If DataGridView1.RowCount = 0 Then
            GoTo line1
line1:      MessageBox.Show("Er zijn geen calls geselecteerd.", "Fout")
        Else

            xlApp = New Excel.Application
            xlWorkbook = xlApp.Workbooks.Add(misvalue)
            xlWorksheet = xlWorkbook.Sheets(1)

            Try
                With xlApp
                    .Cells(1, 1) = "Call ID"
                    .Cells(1, 2) = "Support vertegenwoordiger"
                    .Cells(1, 3) = "Aanmaak datum"
                    .Cells(1, 4) = "Bedrijf"
                    .Cells(1, 5) = "Titel"
                    .Cells(1, 6) = "Minuten tijdens kantooruren"
                    .Cells(1, 7) = "Minuten buiten kantooruren"
                    .Cells(1, 8) = "Voorrij kosten"
                    .Cells(1, 9) = "Acties"
                    .Cells(1, 10) = "Rekening status"
                    .Cells(1, 11) = "Buiten kantooruren"
                    .Cells(1, 12) = "Tijd in minuten"


                    .Cells(2, 1) = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(0).Value.ToString()
                    .Cells(2, 2) = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(10).Value.ToString()
                    .Cells(2, 3) = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(1).Value.ToString()
                    .Cells(2, 4) = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(2).Value.ToString()
                    .Cells(2, 5) = DataGridView2.Rows(DataGridView2.Rows(0).Index).Cells(3).Value.ToString()
                    .Cells(2, 6) = TextBox14.Text
                    .Cells(2, 7) = TextBox13.Text
                    .Cells(2, 8) = voorrrijden.Text
                    .Cells(2, 9) = TextBoxactie.Text
                    .Cells(2, 10) = TextBoxrekening.Text
                    .Cells(2, 11) = TextBoxkantoor.Text
                    .Cells(2, 12) = Clipboard.GetText.ToString

                End With
            Catch ex As Exception


            End Try

            Try
                xlApp.DisplayAlerts = False
                xlWorkbook.SaveAs("C:\exports", Excel.XlFileFormat.xlXMLSpreadsheet, misvalue, misvalue, misvalue, misvalue, _
                                  Excel.XlSaveAsAccessMode.xlNoChange, misvalue, misvalue, misvalue, misvalue, misvalue)
                xlWorkbook.Close(True, misvalue, misvalue)
                xlApp.DisplayAlerts = True
                MessageBox.Show("Klaar, het bestand is te vinden in C:\", "Export")
                xlApp.Workbooks.Close()
                xlApp.Quit()
                xlApp.Quit()
                releaseobject(xlWorksheet)
                releaseobject(xlWorkbook)
                releaseobject(xlApp)

            Catch ex As Exception
                MessageBox.Show("Geen toegang tot het bestand", "Fout")
            End Try
        End If
    End Sub

    Private Sub releaseobject(ByVal obj As Object)
        ''word gebruikt bij het sluiten van Excel
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing

        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub exportxml(sender As System.Object, e As System.EventArgs)
        '' word niet gebuikt.
        Dim settings As New XmlWriterSettings()
        Try
            ' Initialize the XmlWriter.
            Dim XmlWrt As XmlWriter = XmlWriter.Create("XMLExport\export.xml", settings)
            With XmlWrt
                .WriteStartDocument()
                .WriteStartElement("eExact")
                .WriteAttributeString("xsi", "noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "eExact-Schema.xsd")
                .WriteStartElement("Orders")
                .WriteStartElement("Order")
                .WriteAttributeString("type", "V")
                .WriteElementString("Description", "SR")
                .WriteElementString("YourRef", "Servicerapport")
                .WriteStartElement("OrderedBy")
                .WriteStartElement("Debtor")
                .WriteAttributeString("code", DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(15).Value.ToString())
                .WriteString(" ")
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("OrderLine")
                .WriteAttributeString("lineNo", "1")
                .WriteStartElement("Text")
                For Each row As DataGridViewRow In DataGridView1.SelectedRows


                    .WriteString(row.Cells(0).Value.ToString & "    -   " & row.Cells(8).Value.ToString & "    -   " & row.Cells(7).Value.ToString)

                Next

                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("OrderLine")
                .WriteAttributeString("lineNo", "2")
                .WriteStartElement("Item")
                .WriteAttributeString("code", "AS90-08")
                .WriteString(" ")
                .WriteEndElement()
                .WriteStartElement("Quantity")
                .WriteString(Totaalbinnen.Text)
                .WriteEndElement()
                .WriteEndElement()
                .WriteStartElement("OrderLine")
                .WriteAttributeString("lineNo", "3")
                .WriteElementString("Text", "Betreft digitale servicerapporten. Voor uitgebreide specificatie verwijzen wij naar http://service.ucsystems.net/portal")
                .WriteEndElement()
                .WriteEndElement()

                .WriteEndElement()
                .WriteEndElement()
                .WriteEndDocument()
                .Close()
            End With
            MessageBox.Show("XML bestand is opgeslagen in .\XMLExport\", "Klaar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch ex As Exception
            MessageBox.Show(ErrorToString, "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Alleskopieren(sender As Object, e As EventArgs) Handles Button8.Click
        ''kopieert alle data uit de tekstvelden naar het clipboard
        Clipboard.SetDataObject(TextBoxinfo.Text & Environment.NewLine & Environment.NewLine & "Acties: " & Environment.NewLine & TextBoxactie.Text & Environment.NewLine & Environment.NewLine & "Rekening status: " & Environment.NewLine & TextBoxrekening.Text & Environment.NewLine & Environment.NewLine & "Buiten kantooruren: " & Environment.NewLine & TextBoxkantoor.Text & Environment.NewLine & Environment.NewLine & "Tijd in minuten: " & Environment.NewLine & TextBoxtijd.Text & Environment.NewLine & Environment.NewLine & textboxoplossing.Text)
    End Sub

    Private Sub Infokopieren(sender As Object, e As EventArgs) Handles Button9.Click
        ''kopieert de data uit het "info" tekstveld
        Clipboard.SetDataObject(TextBoxinfo.Text)
    End Sub

    Private Sub oplossingkopieren(sender As Object, e As EventArgs) Handles Button10.Click
        ''kopieert de data uit het "Oplossing" tekstveld
        Clipboard.SetDataObject(textboxoplossing.Text)
    End Sub

    Private Sub actieskopieren(sender As Object, e As EventArgs) Handles Button11.Click
        ''kopieert de data uit het "Acties" tekstveld
        Clipboard.SetDataObject(TextBoxactie.Text)
    End Sub

    Private Sub rekeningkopieren(sender As Object, e As EventArgs) Handles Button12.Click
        ''kopieert de data uit het "Rekening Status" tekstveld
        Clipboard.SetDataObject(TextBoxrekening.Text)
    End Sub

    Private Sub kantoorkopieren(sender As Object, e As EventArgs) Handles Button13.Click
        ''kopieert de data uit het "Buitenkantoor" tekstveld
        Clipboard.SetDataObject(TextBoxkantoor.Text)
    End Sub

    Private Sub Tijdkopieren(sender As Object, e As EventArgs) Handles Button14.Click
        ''kopieert de data uit het "Tijd" tekstveld
        Clipboard.SetDataObject(TextBoxtijd.Text)
    End Sub

    Private Sub Button15_Click() Handles Button6.Click
        '' verwijzing naar de appendxmlbackup functie
        AppendXmlbackup("dsa", "dsa", "das")
        '' verwijzing naar de appendxml functie
        AppendXml("dsa", "dsa", "das")
    End Sub

    Public Function help()
        '' controle voor de strippenkaart
        Try
            '' Haalt de strippenkaart code uit de tabel.
            Dim code As String = DataGridView1.Rows(DataGridView1.Rows(0).Index).Cells(17).Value.ToString
            '' MYSQL Query om het aantal beschikbare uren uit een db te lezen.
            Dim sql2 As String = "SELECT        items.itemcode, CAST(ROUND(voorraad.Quantity , 2) AS numeric(36, 2)) AS Voorraad FROM            [100].[dbo].[Items] OUTER APPLY(SELECT        gbkmut.warehouse, ISNULL(SUM(gbkmut.aantal), 0) AS Quantity FROM            [100].[dbo].[gbkmut] WHERE        gbkmut.reknr = Items.GLAccountDistribution AND gbkmut.transtype IN ('X', 'N', 'C', 'P') AND gbkmut.artcode = items.itemcode GROUP BY gbkmut.warehouse) voorraad WHERE        (Items.Condition IN ('A', 'F') AND Items.Type IN ('S', 'B') AND Items.ItemCode ='" & Trim(code) & "')"
            Dim connection2 As New SqlConnection(UC_Systems_SC_Export2.My.Settings.Exactconnect)
            Dim dataadapter2 As New SqlDataAdapter(sql2, connection2)
            Dim ds As New DataSet()
            Try
                connection2.Open()
                ds.Clear()
                dataadapter2.Fill(ds, "Items")
                connection2.Close()
                DataGridView3.DataSource = (ds)
                DataGridView3.DataMember = "Items"

            Catch ex As Exception

            End Try
        Catch ex As Exception
        End Try
        returnq.Clear()
        Dim tijd As Decimal = "0,00"
        Dim tot As Decimal = "0,00"
        Dim blad As Boolean
        Dim strippenkaart As Decimal = "0,00"

        '' totaal aantal uren aan de variable wijzen.
        tot = totaal.Text

        tijd = DataGridView3.Rows(DataGridView3.Rows(0).Index).Cells(1).Value.ToString()
        strippenkaart = (tijd - tot)
        Math.Round(strippenkaart, 2)
        strippenkaart2.Text = FormatNumber(strippenkaart, 2)
    
        '' een check om te kijken of er genoeg uren beschikbaar zijn.
        If tot > tijd Then
            '' De vraag of je wilt doorgaan ook al zijn er niet genoeg uren bechikbaar.
            Dim response = MessageBox.Show("Er zijn niet genoeg uren beschikbaar op de strippenkaart, wil je alsnog doorgaan?", "Let op!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = MsgBoxResult.Yes Then
                blad = True
                returnq.Text = "1"
            Else
                returnq.Text = "0"
                blad = False
            End If
        End If
        Return blad
    End Function

    Public Function AppendXml(ByVal project As String, ByVal method As String, ByVal msg As String)
        '' Functie om te exporteren naar een XML bestand.
        Try
            '' een check die kijkt of er een debiteur nummer is.
            If DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(15).Value.ToString = "" Then
                '' zo niet gaat het programma naar "line1:" die helemaal onderaan de code staat.
                GoTo line1
            End If
        Catch ex As Exception
            MessageBox.Show("Geen call geselecteerd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




        Try
            '' check om te kijken of je wilt doorgaan of niet.
            '' word aangevraagt door een andere functie maar het resultaat blijft staan.
            If returnq.Text = "1" Then
                '' als je "ja" hebt geantwoord ga je door met het exporteren.
                GoTo line2
            ElseIf returnq.Text = "0" Then
                '' als je "nee"hebt geantwoord ga je niet door met het exporteren.
                GoTo line3
            End If

        Catch ex As Exception
        End Try

line2:
        ''start van de export
        Dim tw As System.Xml.XmlTextWriter
        Dim found As Boolean = False
        '' pad waar het xml bestand moet worden opgeslagen.
        Dim FullPath As String = "XMLExport\export.xml"
        Dim id As Long = Now.Ticks
        Try
            '' endtags die moeten worden gevonden.
            Dim endtag2 As Byte() = System.Text.Encoding.UTF8.GetBytes("</Orders></eExact>")
            ''een check die kijkt of het bestand al bestaat
            If System.IO.File.Exists(FullPath) Then
                ''als het bestand al bestaat, haal de endtags weg zodat het bestand kan worden aangevuld.
                found = True
                Dim fs As System.IO.FileStream = System.IO.File.OpenWrite(FullPath)
                fs.Seek(-endtag2.Length, System.IO.SeekOrigin.End)
                tw = New System.Xml.XmlTextWriter(fs, System.Text.Encoding.UTF8)
            Else
                '' anders word er een nieuw bestand aangemaakt.
                tw = New System.Xml.XmlTextWriter(FullPath, System.Text.Encoding.UTF8)
                tw.WriteStartDocument(True)
                tw.WriteStartElement("eExact") 'start eExact
                tw.WriteAttributeString("xsi", "noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "eExact-Schema.xsd")
                tw.WriteStartElement("Orders") 'start orders
            End If
            With tw

                .WriteStartElement("Order") 'start order
                .WriteAttributeString("type", "V")
                .WriteElementString("Description", "SR")
                .WriteElementString("YourRef", "Servicerapport")
                .WriteStartElement("OrderedBy") 'start orderedby
                .WriteStartElement("Debtor") ' start debtor
                '' haalt het debiteur nummer uit de database
                .WriteAttributeString("code", DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(15).Value.ToString())
                .WriteString(" ")
                .WriteEndElement() 'end debtor
                .WriteEndElement() 'end orderedby
                .WriteStartElement("OrderLine") 'start orderline 1
                .WriteAttributeString("lineNo", "1")
                .WriteElementString("Text", "Betreft digitale servicerapporten. Voor uitgebreide specificatie verwijzen wij naar http://service.ucsystems.net/portal")
                .WriteEndElement() 'end orderline 1

                Dim X As Integer
                Dim Z As Integer
                Z = 1
                X = 0
                Do
                    '' voor elke orderline word Z + 1
                    Z = Z + 1
                    .WriteStartElement("OrderLine") 'start orderline 2
                    .WriteAttributeString("lineNo", Z)
                    .WriteStartElement("Text") 'start text
                    .WriteString("-")
                    .WriteEndElement() 'end text
                    .WriteEndElement() 'end orderline 2
                    Z = Z + 1
                    .WriteStartElement("OrderLine") 'start orderline1
                    .WriteAttributeString("lineNo", Z)
                    .WriteStartElement("Text") 'start text
                    '' een check die kijkt wat voor een uren er geboekt zijn.
                    If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Weekend" Then
                        ''als het weekend uren zijn  word de volgende regel weggeschreven
                        .WriteString("Aanvraag: " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(0).Value.ToString & " - " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(3).Value.ToString & " " & "(" & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(19).Value.ToString & ") " & "(incl. toeslag weekenduren)")
                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Avond" Then
                        ''als het avond uren zijn  word de volgende regel weggeschreven
                        .WriteString("Aanvraag: " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(0).Value.ToString & " - " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(3).Value.ToString & " " & "(" & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(19).Value.ToString & ") " & "(incl. toeslag avonduren)")
                    Else
                        ''als het andere uren zijn  word de volgende regel weggeschreven
                        .WriteString("Aanvraag: " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(0).Value.ToString & " - " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(3).Value.ToString & " " & "(" & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(19).Value.ToString & ")")

                    End If

                    .WriteEndElement() 'end text
                    .WriteEndElement() 'end orderline
                    Z = Z + 1
                    If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(9).Value = "Akkoord - Service" Then

                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", "AS90-06")
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        'MIKE15102014 '' een check die kijkt of er iets is ingevoerd in de colom "aangepaste uurtarief" < MIKE15102014 BUITEN WERKING IVM BUG DIE UURTARIEF OP SERVICEUREN BOEKT
                        'MIKE15102014 If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                        'MIKE15102014 '' als er niks is ingevoerd worden de volgende regels uitgevoerd.
                        .WriteEndElement() 'end quantity
                        .WriteEndElement() 'end orderline 2
                        'MIKE15102014 Else
                        'MIKE15102014 '' als er wel iets is ingevoerd worden de volgende regels uitgevoerd.
                        'MIKE15102014 .WriteEndElement() 'end quantity
                        'MIKE15102014 .WriteStartElement("Price")
                        'MIKE15102014 .WriteAttributeString("type", "S")
                        'MIKE15102014 .WriteStartElement("Currency")
                        'MIKE15102014 .WriteAttributeString("code", "EUR")
                        'MIKE15102014 .WriteEndElement() 'end currency
                        'MIKE15102014 .WriteStartElement("Value")
                        'MIKE15102014 .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                        'MIKE15102014 .WriteEndElement() 'end value
                        'MIKE15102014 .WriteEndElement() 'end price
                        'MIKE15102014 .WriteStartElement("Amount")
                        'MIKE15102014 .WriteAttributeString("type", "S")
                        'MIKE15102014 .WriteStartElement("Currency")
                        'MIKE15102014 .WriteAttributeString("code", "EUR")
                        'MIKE15102014 .WriteEndElement() 'end currency
                        'MIKE15102014 .WriteStartElement("Value")
                        'MIKE15102014 .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                        'MIKE15102014 .WriteEndElement() 'end value
                        'MIKE15102014 .WriteEndElement() 'end amount
                        'MIKE15102014 .WriteEndElement() 'end orderline 2
                        'MIKE15102014 End If

                        '' een check die kijkt of er een strippenkaart beschikbaar is.
                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(17).Value.ToString.StartsWith("AS94-10") Then
                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(17).Value.ToString)
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        '' een check die kijkt of er een strippenkaart is en weekend uren zijn geboekt.
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(17).Value.ToString.StartsWith("AS94-10") And DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Weekend" Then
                            '' zo ja worden de uren x 2 gedaan.
                            TextBox8.Text = DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString
                            TextBox8.Text = TextBox8.Text.ToString * 2
                            TextBox8.Text = Regex.Replace(TextBox8.Text.ToString, ",", ".")
                            .WriteString(TextBox8.Text)
                            '' een check die kijkt of er een strippenkaart is en avond uren zijn geboekt.
                        ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(17).Value.ToString.StartsWith("AS94-10") And DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Avond" Then
                            '' zo ja worden de uren x 1,5 gedaan.
                            TextBox8.Text = DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString
                            TextBox8.Text = TextBox8.Text.ToString * 1.5
                            TextBox8.Text = Regex.Replace(TextBox8.Text.ToString, ",", ".")
                            .WriteString(TextBox8.Text)

                            '' anders word alleen de comma's vervangen door punten.
                        Else : .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        End If
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                            .WriteEndElement() 'end quantity
                            .WriteEndElement() 'end orderline 2
                        Else
                            .WriteEndElement() 'end quantity
                            .WriteStartElement("Price")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end price
                            .WriteStartElement("Amount")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end amount

                            .WriteEndElement() 'end orderline 2
                        End If
                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(9).Value = "Akkoord - Te factureren" And DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Avond" Then
                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", "AS90-03")
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                            .WriteEndElement() 'end quantity
                            .WriteEndElement() 'end orderline 2
                        Else
                            .WriteEndElement() 'end quantity
                            .WriteStartElement("Price")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end price
                            .WriteStartElement("Amount")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end amount
                            .WriteEndElement() 'end orderline 2
                        End If

                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(9).Value = "Akkoord - Te factureren" And DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Weekend" Then
                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", "AS90-04")
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                            .WriteEndElement() 'end quantity
                            .WriteEndElement() 'end orderline 2
                        Else
                            .WriteEndElement() 'end quantity
                            .WriteStartElement("Price")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end price
                            .WriteStartElement("Amount")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end amount
                            .WriteEndElement() 'end orderline 2
                        End If
                    Else
                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", "AS90-08")
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                            .WriteEndElement() 'end quantity
                            .WriteEndElement() 'end orderline 2
                        Else
                            .WriteEndElement() 'end quantity
                            .WriteStartElement("Price")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end price
                            .WriteStartElement("Amount")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end amount
                            .WriteEndElement() 'end orderline 2
                        End If


                    End If

                    Try
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(5).Value = "Ja klantlocatie" Then
                            Z = Z + 1
                            .WriteStartElement("OrderLine") 'start orderline 5
                            .WriteAttributeString("lineNo", Z)
                            .WriteStartElement("Item") 'start item

                            If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(16).Value.ToString.StartsWith("AS94-20") Then
                                .WriteAttributeString("code", DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(16).Value.ToString)
                                .WriteString(" ")
                                .WriteEndElement() 'end item
                                .WriteStartElement("Quantity") 'start quantity
                                .WriteString("1")
                                .WriteEndElement() 'end quantity
                                .WriteEndElement() 'end orderline 5
                            Else : .WriteAttributeString("code", "AS90-99")
                                .WriteString(" ")
                                .WriteEndElement() 'end item
                                .WriteStartElement("Quantity") 'start quantity
                                .WriteString("1")
                                .WriteEndElement() 'end quantity
                                .WriteStartElement("Price")
                                .WriteAttributeString("type", "S")
                                .WriteStartElement("Currency")
                                .WriteAttributeString("code", "EUR")
                                .WriteEndElement() 'end currency
                                .WriteStartElement("Value")
                                .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(18).Value.ToString)
                                .WriteEndElement() 'end value
                                .WriteEndElement() 'end price
                                .WriteStartElement("Amount")
                                .WriteAttributeString("type", "S")
                                .WriteStartElement("Currency")
                                .WriteAttributeString("code", "EUR")
                                .WriteEndElement() 'end currency
                                .WriteStartElement("Value")
                                .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(18).Value.ToString)
                                .WriteEndElement() 'end value
                                .WriteEndElement() 'end amount
                                .WriteEndElement() 'end orderline 5
                            End If



                        ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(5).Value = "Ja andere locatie" Then
                            Z = Z + 1
                            .WriteStartElement("OrderLine") 'start orderline 5
                            .WriteAttributeString("lineNo", Z)
                            .WriteStartElement("Item") 'start item

                            If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(16).Value.ToString.StartsWith("AS94-20") Then
                                .WriteAttributeString("code", DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(16).Value.ToString)
                                .WriteString(" ")
                                .WriteEndElement() 'end item
                                .WriteStartElement("Quantity") 'start quantity
                                .WriteString("1")
                                .WriteEndElement() 'end quantity
                                .WriteEndElement() 'end orderline 5
                            Else : .WriteAttributeString("code", "AS90-99")
                                .WriteString(" ")
                                .WriteEndElement() 'end item
                                .WriteStartElement("Quantity") 'start quantity
                                .WriteString("1")
                                .WriteEndElement() 'end quantity
                                .WriteStartElement("Price")
                                .WriteAttributeString("type", "S")
                                .WriteStartElement("Currency")
                                .WriteAttributeString("code", "EUR")
                                .WriteEndElement() 'end currency
                                .WriteStartElement("Value")
                                .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(21).Value.ToString)
                                .WriteEndElement() 'end value
                                .WriteEndElement() 'end price
                                .WriteStartElement("Amount")
                                .WriteAttributeString("type", "S")
                                .WriteStartElement("Currency")
                                .WriteAttributeString("code", "EUR")
                                .WriteEndElement() 'end currency
                                .WriteStartElement("Value")
                                .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(21).Value.ToString)
                                .WriteEndElement() 'end value
                                .WriteEndElement() 'end amount
                                .WriteEndElement() 'end orderline 5
                            End If
                            GoTo line5
                        End If
                    Catch ex As Exception
                    End Try
line5:
                    X = X + 1
                Loop Until X > DataGridView1.SelectedRows.Count - 1

                Z = Z + 1
                X = 0
                Try
                    If DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(9).Value = "Akkoord - Te factureren" And DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(17).Value.ToString.StartsWith("AS94-10") Then
                        .WriteStartElement("OrderLine") 'start orderline
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Text") 'start text
                        .WriteString("-")
                        .WriteEndElement() 'end text
                        .WriteEndElement() 'end orderline
                        Z = Z + 1
                        .WriteStartElement("OrderLine") 'start orderline
                        .WriteAttributeString("lineNo", Z)
                        .WriteElementString("Text", "Aantal beschikbare uren : " & strippenkaart2.Text)
                        .WriteEndElement() 'end orderline
                        Z = Z + 1
                        .WriteStartElement("OrderLine") 'start orderline 
                        .WriteAttributeString("lineNo", Z)
                        .WriteElementString("Text", "BETREFT HET AFSCHRIJVEN VAN UREN EN KOSTEN VAN UW DETACHERINGSOVEREENKOMST.")
                        .WriteEndElement() 'end orderline 7

                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(1).Index).Cells(9).Value = "Akkoord - Te factureren" And DataGridView1.Rows(DataGridView1.SelectedRows(1).Index).Cells(17).Value.ToString.StartsWith("AS94-10") Then
                        .WriteStartElement("OrderLine") 'start orderline
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Text") 'start text
                        .WriteString("-")
                        .WriteEndElement() 'end text
                        .WriteEndElement() 'end orderline
                        Z = Z + 1
                        .WriteStartElement("OrderLine") 'start orderline
                        .WriteAttributeString("lineNo", Z)
                        .WriteElementString("Text", "Aantal beschikbare uren : " & strippenkaart2.Text)
                        .WriteEndElement() 'end orderline
                        Z = Z + 1
                        .WriteStartElement("OrderLine") 'start orderline 
                        .WriteAttributeString("lineNo", Z)
                        .WriteElementString("Text", "BETREFT HET AFSCHRIJVEN VAN UREN EN KOSTEN VAN UW DETACHERINGSOVEREENKOMST.")
                        .WriteEndElement() 'end orderline 7
                    End If
                Catch ex As Exception
                End Try

                .WriteEndElement()




                If Not found Then

                    .WriteEndElement() ' end orders
                    .WriteEndElement() 'end eExact
                    .WriteEndDocument()
                Else
                    .Flush()
                    '' scrijf de endtags weer aan het einde van het bestand.
                    tw.BaseStream.Write(endtag2, 0, endtag2.Length)
                End If
            End With
            '' verwijzing naar de functie "Afhandelen"
            Call afhandelen()
            '' melding die je krijgt als het exporteren klaar is.
            MessageBox.Show("XML bestand is opgeslagen in .\XMLExport\", "Klaar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch ex As System.IO.FileNotFoundException
            Throw New System.IO.FileNotFoundException("File " & FullPath & " not found")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Try
                If Not tw Is Nothing Then
                    tw.Flush()
                    If Not tw.WriteState = System.Xml.WriteState.Closed Then tw.Close()
                End If
            Catch ex As Exception
            End Try
        End Try
        Return id

line1:  MessageBox.Show("Geen Debiteurnummer voor dit bedrijf.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Information)

line3:
    End Function

    Public Function AppendXmlbackup(ByVal project As String, ByVal method As String, ByVal msg As String)

        Try
            If DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(15).Value.ToString = "" Then
                GoTo line1
            End If
        Catch ex As Exception
            MessageBox.Show("Geen call geselecteerd", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Try

            Call help()
            If returnq.Text = "1" Then
                GoTo line2
            ElseIf returnq.Text = "0" Then
                GoTo line3
            End If

        Catch ex As Exception

        End Try

line2:
        Dim tw As System.Xml.XmlTextWriter
        Dim found As Boolean = False
        Dim FullPath As String = "XMLExport\exportbackup.xml"
        Dim id As Long = Now.Ticks
        Try
            Dim endtag2 As Byte() = System.Text.Encoding.UTF8.GetBytes("</Orders></eExact>")
            If System.IO.File.Exists(FullPath) Then
                found = True
                Dim fs As System.IO.FileStream = System.IO.File.OpenWrite(FullPath)
                fs.Seek(-endtag2.Length, System.IO.SeekOrigin.End)
                tw = New System.Xml.XmlTextWriter(fs, System.Text.Encoding.UTF8)
            Else
                tw = New System.Xml.XmlTextWriter(FullPath, System.Text.Encoding.UTF8)
                tw.WriteStartDocument(True)
                tw.WriteStartElement("eExact") 'start eExact
                tw.WriteAttributeString("xsi", "noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "eExact-Schema.xsd")
                tw.WriteStartElement("Orders") 'start orders
            End If
            With tw

                .WriteStartElement("Order") 'start order
                .WriteAttributeString("type", "V")
                .WriteElementString("Description", "SR")
                .WriteElementString("YourRef", "Servicerapport")
                .WriteStartElement("OrderedBy") 'start orderedby
                .WriteStartElement("Debtor") ' start debtor
                .WriteAttributeString("code", DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(15).Value.ToString())
                .WriteString(" ")
                .WriteEndElement() 'end debtor
                .WriteEndElement() 'end orderedby
                .WriteStartElement("OrderLine") 'start orderline 1
                .WriteAttributeString("lineNo", "1")
                .WriteElementString("Text", "Betreft digitale servicerapporten. Voor uitgebreide specificatie verwijzen wij naar http://service.ucsystems.net/portal")
                .WriteEndElement() 'end orderline 1

                Dim X As Integer
                Dim Z As Integer
                Z = 1
                X = 0
                Do
                    Z = Z + 1
                    .WriteStartElement("OrderLine") 'start orderline 2
                    .WriteAttributeString("lineNo", Z)
                    .WriteStartElement("Text") 'start text
                    .WriteString("-")
                    .WriteEndElement() 'end text
                    .WriteEndElement() 'end orderline 2
                    Z = Z + 1
                    .WriteStartElement("OrderLine") 'start orderline1
                    .WriteAttributeString("lineNo", Z)
                    .WriteStartElement("Text") 'start text
                    If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Weekend" Then
                        .WriteString("Aanvraag: " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(0).Value.ToString & " - " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(3).Value.ToString & " " & "(" & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(19).Value.ToString & ") " & "(incl. toeslag weekenduren)")
                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Avond" Then
                        .WriteString("Aanvraag: " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(0).Value.ToString & " - " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(3).Value.ToString & " " & "(" & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(19).Value.ToString & ") " & "(incl. toeslag avonduren)")
                    Else
                        .WriteString("Aanvraag: " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(0).Value.ToString & " - " & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(3).Value.ToString & " " & "(" & DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(19).Value.ToString & ")")

                    End If

                    .WriteEndElement() 'end text
                    .WriteEndElement() 'end orderline
                    Z = Z + 1
                    If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(9).Value = "Akkoord - Service" Then

                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", "AS90-06")
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        'MIKE15102014 If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                        .WriteEndElement() 'end quantity
                        .WriteEndElement() 'end orderline 2
                        'MIKE15102014 Else
                        'MIKE15102014 .WriteEndElement() 'end quantity
                        'MIKE15102014 .WriteStartElement("Price")
                        'MIKE15102014 .WriteAttributeString("type", "S")
                        'MIKE15102014 .WriteStartElement("Currency")
                        'MIKE15102014 .WriteAttributeString("code", "EUR")
                        'MIKE15102014 .WriteEndElement() 'end currency
                        'MIKE15102014 .WriteStartElement("Value")
                        'MIKE15102014 .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                        'MIKE15102014 .WriteEndElement() 'end value
                        'MIKE15102014 .WriteEndElement() 'end price
                        'MIKE15102014 .WriteStartElement("Amount")
                        'MIKE15102014 .WriteAttributeString("type", "S")
                        'MIKE15102014 .WriteStartElement("Currency")
                        'MIKE15102014 .WriteAttributeString("code", "EUR")
                        'MIKE15102014 .WriteEndElement() 'end currency
                        'MIKE15102014 .WriteStartElement("Value")
                        'MIKE15102014 .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                        'MIKE15102014 .WriteEndElement() 'end value
                        'MIKE15102014 .WriteEndElement() 'end amount
                        'MIKE15102014 .WriteEndElement() 'end orderline 2
                        'MIKE15102014 End If


                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(17).Value.ToString.StartsWith("AS94-10") Then
                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(17).Value.ToString)
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(17).Value.ToString.StartsWith("AS94-10") And DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Weekend" Then
                            TextBox8.Text = DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString
                            TextBox8.Text = TextBox8.Text.ToString * 2
                            TextBox8.Text = Regex.Replace(TextBox8.Text.ToString, ",", ".")
                            .WriteString(TextBox8.Text)
                        ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(17).Value.ToString.StartsWith("AS94-10") And DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Avond" Then
                            TextBox8.Text = DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString
                            TextBox8.Text = TextBox8.Text.ToString * 1.5
                            TextBox8.Text = Regex.Replace(TextBox8.Text.ToString, ",", ".")
                            .WriteString(TextBox8.Text)


                        Else : .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        End If
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                            .WriteEndElement() 'end quantity
                            .WriteEndElement() 'end orderline 2
                        Else
                            .WriteEndElement() 'end quantity
                            .WriteStartElement("Price")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end price
                            .WriteStartElement("Amount")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end amount

                            .WriteEndElement() 'end orderline 2
                        End If
                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(9).Value = "Akkoord - Te factureren" And DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Avond" Then
                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", "AS90-03")
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                            .WriteEndElement() 'end quantity
                            .WriteEndElement() 'end orderline 2
                        Else
                            .WriteEndElement() 'end quantity
                            .WriteStartElement("Price")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end price
                            .WriteStartElement("Amount")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end amount
                            .WriteEndElement() 'end orderline 2
                        End If

                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(9).Value = "Akkoord - Te factureren" And DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(6).Value = "Weekend" Then
                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", "AS90-04")
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                            .WriteEndElement() 'end quantity
                            .WriteEndElement() 'end orderline 2
                        Else
                            .WriteEndElement() 'end quantity
                            .WriteStartElement("Price")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end price
                            .WriteStartElement("Amount")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end amount
                            .WriteEndElement() 'end orderline 2
                        End If
                    Else
                        .WriteStartElement("OrderLine") 'start orderline 2
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Item") 'start item
                        .WriteAttributeString("code", "AS90-08")
                        .WriteString(" ")
                        .WriteEndElement() 'end item
                        .WriteStartElement("Quantity") 'start quantity
                        .WriteString(Regex.Replace(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(7).Value.ToString, ",", "."))
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString.Count < 1 Then
                            .WriteEndElement() 'end quantity
                            .WriteEndElement() 'end orderline 2
                        Else
                            .WriteEndElement() 'end quantity
                            .WriteStartElement("Price")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end price
                            .WriteStartElement("Amount")
                            .WriteAttributeString("type", "S")
                            .WriteStartElement("Currency")
                            .WriteAttributeString("code", "EUR")
                            .WriteEndElement() 'end currency
                            .WriteStartElement("Value")
                            .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(20).Value.ToString)
                            .WriteEndElement() 'end value
                            .WriteEndElement() 'end amount
                            .WriteEndElement() 'end orderline 2
                        End If


                    End If

                    Try
                        If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(5).Value = "Ja klantlocatie" Then
                            Z = Z + 1
                            .WriteStartElement("OrderLine") 'start orderline 5
                            .WriteAttributeString("lineNo", Z)
                            .WriteStartElement("Item") 'start item

                            If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(16).Value.ToString.StartsWith("AS94-20") Then
                                .WriteAttributeString("code", DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(16).Value.ToString)
                                .WriteString(" ")
                                .WriteEndElement() 'end item
                                .WriteStartElement("Quantity") 'start quantity
                                .WriteString("1")
                                .WriteEndElement() 'end quantity
                                .WriteEndElement() 'end orderline 5
                            Else : .WriteAttributeString("code", "AS90-99")
                                .WriteString(" ")
                                .WriteEndElement() 'end item
                                .WriteStartElement("Quantity") 'start quantity
                                .WriteString("1")
                                .WriteEndElement() 'end quantity
                                .WriteStartElement("Price")
                                .WriteAttributeString("type", "S")
                                .WriteStartElement("Currency")
                                .WriteAttributeString("code", "EUR")
                                .WriteEndElement() 'end currency
                                .WriteStartElement("Value")
                                .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(18).Value.ToString)
                                .WriteEndElement() 'end value
                                .WriteEndElement() 'end price
                                .WriteStartElement("Amount")
                                .WriteAttributeString("type", "S")
                                .WriteStartElement("Currency")
                                .WriteAttributeString("code", "EUR")
                                .WriteEndElement() 'end currency
                                .WriteStartElement("Value")
                                .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(18).Value.ToString)
                                .WriteEndElement() 'end value
                                .WriteEndElement() 'end amount
                                .WriteEndElement() 'end orderline 5
                            End If



                        ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(5).Value = "Ja andere locatie" Then
                            Z = Z + 1
                            .WriteStartElement("OrderLine") 'start orderline 5
                            .WriteAttributeString("lineNo", Z)
                            .WriteStartElement("Item") 'start item

                            If DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(16).Value.ToString.StartsWith("AS94-20") Then
                                .WriteAttributeString("code", DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(16).Value.ToString)
                                .WriteString(" ")
                                .WriteEndElement() 'end item
                                .WriteStartElement("Quantity") 'start quantity
                                .WriteString("1")
                                .WriteEndElement() 'end quantity
                                .WriteEndElement() 'end orderline 5
                            Else : .WriteAttributeString("code", "AS90-99")
                                .WriteString(" ")
                                .WriteEndElement() 'end item
                                .WriteStartElement("Quantity") 'start quantity
                                .WriteString("1")
                                .WriteEndElement() 'end quantity
                                .WriteStartElement("Price")
                                .WriteAttributeString("type", "S")
                                .WriteStartElement("Currency")
                                .WriteAttributeString("code", "EUR")
                                .WriteEndElement() 'end currency
                                .WriteStartElement("Value")
                                .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(21).Value.ToString)
                                .WriteEndElement() 'end value
                                .WriteEndElement() 'end price
                                .WriteStartElement("Amount")
                                .WriteAttributeString("type", "S")
                                .WriteStartElement("Currency")
                                .WriteAttributeString("code", "EUR")
                                .WriteEndElement() 'end currency
                                .WriteStartElement("Value")
                                .WriteString(DataGridView1.Rows(DataGridView1.SelectedRows(X).Index).Cells(21).Value.ToString)
                                .WriteEndElement() 'end value
                                .WriteEndElement() 'end amount
                                .WriteEndElement() 'end orderline 5
                            End If
                            GoTo line5
                        End If
                    Catch ex As Exception
                    End Try
line5:
                    X = X + 1
                Loop Until X > DataGridView1.SelectedRows.Count - 1

                Z = Z + 1
                X = 0
                Try
                    If DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(9).Value = "Akkoord - Te factureren" And DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(17).Value.ToString.StartsWith("AS94-10") Then
                        .WriteStartElement("OrderLine") 'start orderline
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Text") 'start text
                        .WriteString("-")
                        .WriteEndElement() 'end text
                        .WriteEndElement() 'end orderline
                        Z = Z + 1
                        .WriteStartElement("OrderLine") 'start orderline
                        .WriteAttributeString("lineNo", Z)
                        .WriteElementString("Text", "Aantal beschikbare uren : " & strippenkaart2.Text)
                        .WriteEndElement() 'end orderline
                        Z = Z + 1
                        .WriteStartElement("OrderLine") 'start orderline 
                        .WriteAttributeString("lineNo", Z)
                        .WriteElementString("Text", "BETREFT HET AFSCHRIJVEN VAN UREN EN KOSTEN VAN UW DETACHERINGSOVEREENKOMST.")
                        .WriteEndElement() 'end orderline 7

                    ElseIf DataGridView1.Rows(DataGridView1.SelectedRows(1).Index).Cells(9).Value = "Akkoord - Te factureren" And DataGridView1.Rows(DataGridView1.SelectedRows(1).Index).Cells(17).Value.ToString.StartsWith("AS94-10") Then
                        .WriteStartElement("OrderLine") 'start orderline
                        .WriteAttributeString("lineNo", Z)
                        .WriteStartElement("Text") 'start text
                        .WriteString("-")
                        .WriteEndElement() 'end text
                        .WriteEndElement() 'end orderline
                        Z = Z + 1
                        .WriteStartElement("OrderLine") 'start orderline
                        .WriteAttributeString("lineNo", Z)
                        .WriteElementString("Text", "Aantal beschikbare uren : " & strippenkaart2.Text)
                        .WriteEndElement() 'end orderline
                        Z = Z + 1
                        .WriteStartElement("OrderLine") 'start orderline 
                        .WriteAttributeString("lineNo", Z)
                        .WriteElementString("Text", "BETREFT HET AFSCHRIJVEN VAN UREN EN KOSTEN VAN UW DETACHERINGSOVEREENKOMST.")
                        .WriteEndElement() 'end orderline 7
                    End If
                Catch ex As Exception
                End Try

                .WriteEndElement()




                If Not found Then

                    .WriteEndElement() ' end orders
                    .WriteEndElement() 'end eExact
                    .WriteEndDocument()
                Else
                    .Flush()
                    tw.BaseStream.Write(endtag2, 0, endtag2.Length)
                End If
            End With

        Catch ex As System.IO.FileNotFoundException
            Throw New System.IO.FileNotFoundException("File " & FullPath & " not found")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            Try
                If Not tw Is Nothing Then
                    tw.Flush()
                    If Not tw.WriteState = System.Xml.WriteState.Closed Then tw.Close()
                End If
            Catch ex As Exception
            End Try
        End Try
        Return id


line1:  MessageBox.Show("Geen Debiteurnummer voor dit bedrijf.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Information)

line3:
    End Function

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        '' start het import process van exact.
        Process.Start("C:\Program Files (x86)\Exact Software\bin\AsImport.exe", "-rDC-133 -D100 -u -~ I -URL\\DC-131\UC\Applications\SC-Export\XMLExport\export.xml -Torders -Oauto")
    End Sub

    Function StripHTML(sInput As String) As String
        '' functie om HTML tags uit tekst te filteren.
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
