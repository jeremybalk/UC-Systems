Imports System.Configuration
Imports System.Data.Common
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel

Public Class Controle

    Private Sub Controle_Load(sender As Object, e As EventArgs) Handles Me.FormClosing
        StartScherm.Show() '' laad het startscherm zodra het formulier word gesloten.
    End Sub

    Private Sub datagridview()
        ''SQL Query voor bedrijven die wel calls op hun naam hebben maar geen debiteur nummer hebben
        Dim sql2 As String = "SELECT DISTINCT AaaOrganization.NAME AS Bedrijf, Customer_Fields.UDF_LONG1, Department_Account.ACCOUNTID FROM            CategoryDefinition RIGHT OUTER JOIN                         RequestResolution RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrganization.ORG_ID = AaaOrgPostalAddr.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrderStates.WORKORDERID = WorkOrder.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID LEFT OUTER JOIN                         Customer_Fields RIGHT OUTER JOIN                         Department_Account ON Customer_Fields.DEPARTMENT_ACCOUNTID = Department_Account.DEPARTMENT_ACCOUNTID ON                          AaaOrganization.ORG_ID = Department_Account.ACCOUNTID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID LEFT OUTER JOIN                         StatusDefinition ON WorkOrderStates.STATUSID = StatusDefinition.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID ON                          CategoryDefinition.CATEGORYID = WorkOrderStates.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser INNER JOIN                         RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE        (WorkOrder.WORKORDERID IS NOT NULL) AND (Customer_Fields.UDF_LONG1 IS NULL)"
        '' SQL Query voor calls die nog geen klant hebben toegewezen
        Dim sql As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaUser_2.FIRST_NAME AS [Support Medewerker], AaaOrganization.NAME AS Bedrijf,                          WorkOrder.TITLE AS Titel, WorkOrder.DESCRIPTION AS Omschrijving, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten,                          RequestResolution.RESOLUTION AS Oplossing, RequestCharges.DESCRIPTION AS [Ondernomen Acties],                          RequestCharges.MM2COMPLETEREQUEST / 60 / 1000 AS [Tijd in MIN.], Customer_Fields.UDF_LONG1 FROM            CategoryDefinition RIGHT OUTER JOIN                         RequestResolution RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID LEFT OUTER JOIN                         Customer_Fields INNER JOIN                         Department_Account ON Customer_Fields.DEPARTMENT_ACCOUNTID = Department_Account.DEPARTMENT_ACCOUNTID ON                         Customer.CUSTOMER_ID = Department_Account.ACCOUNTID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID LEFT OUTER JOIN                       StatusDefinition ON WorkOrderStates.STATUSID = StatusDefinition.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID ON                          CategoryDefinition.CATEGORYID = WorkOrderStates.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser INNER JOIN                         RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE        (AaaOrganization.NAME = N'* KLANT NOG TOEWIJZEN *')ORDER BY [Call ID]"
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim dataadapter2 As New SqlDataAdapter(sql2, connection)
        Dim ds2 As New DataSet()
        Dim ds As New DataSet()
        Try

            connection.Open()
            dataadapter.Fill(ds, "WorkOrder")
            dataadapter2.Fill(ds, "WorkOrder")
            connection.Close()
            DataGridView1.DataSource = (ds)
            DataGridView1.DataMember = "WorkOrder"

        Catch ex As Exception
            System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
        End Try
        Try
            '' een check die kijkt of er de text "* KLANT NOG TOEWIJZEN *" in de tabel staat als dat zo is 
            '' word er de regel "Geen klant voor deze call" in de colom "info" geplaats.
            '' anders word er de regel "Geen debiteurnummer voor deze klant" in de colom "info" geplaatst.
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(5).Value.ToString = "* KLANT NOG TOEWIJZEN *" Then
                    row.Cells(1).Value = "Geen klant voor deze call"
                Else
                    row.Cells(1).Value = "Geen debiteurnummer voor deze klant"
                End If
            Next
        Catch ex As Exception
        End Try
        Try
            '' verberg colommen die overbodig zijn.
            DataGridView1.Columns(5).DefaultCellStyle.Alignment = "32"
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = True
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Controle_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Call datagridview() '' verwijzing naar de functie datagridview()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim ie As Object
        '' een check die kijkt wat er in de colom "info" staat , als er "* KLANT NOG TOEWIJZEN *" staat word er gekeken 
        '' of er google chrome is geintalleerd zo ja word de link geopend in chrome en gaat ie naar de call
        '' als er  iets anders staat dan "* KLANT NOG TOEWIJZEN *" word er gelinked naar het account want dan gaan we er van uit
        '' dat het bedrijf geen debiteur nummer heeft.
        '' Mocht google chrome niet aanwezig zijn word er IE gebruikt.
        If DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(5).Value.ToString = "* KLANT NOG TOEWIJZEN *" Then
            If e.ColumnIndex = 0 Then
               Dim fullpath As String = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
                If System.IO.File.Exists(fullpath) Then
                    Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://service.ucsystems.net/WorkOrder.do?woMode=viewWO&woID=" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(13).Value.ToString()) & "&" & "")
                Else
                    Dim url As String = "http://service.ucsystems.net/WorkOrder.do?woMode=viewWO&woID=" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(13).Value.ToString) & ""
                    ie = CreateObject("INTERNETEXPLORER.APPLICATION")
                    ie.Visible = True
                    ie.NAVIGATE(url)
                End If
            End If
        Else
            If e.ColumnIndex = 0 Then
                 Dim fullpath As String = "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
                If System.IO.File.Exists(fullpath) Then
                    Process.Start("C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://service.ucsystems.net/WorkOrder.do?woMode=viewWO&woID=" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(13).Value.ToString()) & "&" & "")
                Else
                    Dim url As String = "http://service.ucsystems.net/WorkOrder.do?woMode=viewWO&woID=" & Trim(DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(13).Value.ToString) & ""
                    ie = CreateObject("INTERNETEXPLORER.APPLICATION")
                    ie.Visible = True
                    ie.NAVIGATE(url)
                End If
            End If
        End If



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Call datagridview() '' verwijzing naar de functie datagridview()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Close() '' sluit het formulier
    End Sub

End Class