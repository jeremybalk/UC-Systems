Imports System.Configuration
Imports System.Data.Common
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Imports System.Text.RegularExpressions

Public Class Tool

    Private Sub datagridview()
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.PerformStep()
        '' SQL query's voor elke filter is er een aparte query
        Dim sql As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],                          CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 3) AS numeric(36, 3)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,                          RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],                          TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,                          WorkOrderToDescription.FULLDESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,                          Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],                          Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],                          TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN                         Department_Account RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN                         WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON                          Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN                         Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN                         RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser AS AaaUser_3 INNER JOIN                         RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID   WHERE (WorkOrder.WORKORDERID Like '" & Trim(TextBox1.Text) & "') or (RequestCharges.CHARGETYPE Like'" & Trim(ComboBox1.SelectedItem) & "') or (AaaOrganization.NAME like '" & Trim(TextBox2.Text) & "') or (TimeEntry_Fields.UDF_CHAR3 Like'" & Trim(ComboBox1.SelectedItem) & "') ORDER BY WorkOrder.WORKORDERID"
        Dim sql2 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],                          CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 3) AS numeric(36, 3)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,                          RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],                          TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,                          WorkOrderToDescription.FULLDESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,                          Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],                          Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],                          TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN                         Department_Account RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN                         WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON                          Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN                         Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN                         RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser AS AaaUser_3 INNER JOIN                         RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID  WHERE (WorkOrder.WORKORDERID Like '" & Trim(TextBox1.Text) & "') or (CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, '19700101'), 102) between '" & Trim(DateTimePicker2.Text) & "' and '" & Trim(DateTimePicker3.Text) & "') ORDER BY WorkOrder.WORKORDERID"
        Dim sql3 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],                          CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 3) AS numeric(36, 3)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,                          RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],                          TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,                          WorkOrderToDescription.FULLDESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,                          Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],                          Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],                          TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN                         Department_Account RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN                         WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON                          Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN                         Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN                         RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser AS AaaUser_3 INNER JOIN                         RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID   WHERE (WorkOrder.WORKORDERID Like '" & Trim(TextBox1.Text) & "') or (CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, '19700101'), 102) between '" & Trim(DateTimePicker2.Text) & "' and '" & Trim(DateTimePicker3.Text) & "') and (AaaOrganization.NAME like '" & Trim(TextBox2.Text) & "') ORDER BY WorkOrder.WORKORDERID"
        Dim sql4 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],                          CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 3) AS numeric(36, 3)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,                          RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],                          TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,                          WorkOrderToDescription.FULLDESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,                          Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],                          Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],                          TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN                         Department_Account RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN                         WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON                          Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN                         Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN                         RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser AS AaaUser_3 INNER JOIN                         RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID   WHERE (WorkOrder.WORKORDERID Like '" & Trim(TextBox1.Text) & "') or (AaaOrganization.NAME like '" & Trim(TextBox2.Text) & "') and (TimeEntry_Fields.UDF_CHAR3 Like'" & Trim(ComboBox1.SelectedItem) & "')   ORDER BY WorkOrder.WORKORDERID"
        Dim sql5 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],                          CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 3) AS numeric(36, 3)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,                          RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],                          TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,                          WorkOrderToDescription.FULLDESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,                          Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],                          Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],                          TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN                         Department_Account RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN                         WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON                          Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN                         Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN                         RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser AS AaaUser_3 INNER JOIN                         RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID   WHERE (WorkOrder.WORKORDERID Like '" & Trim(TextBox1.Text) & "') or (AaaOrganization.NAME like '" & Trim(TextBox2.Text) & "') and (RequestCharges.CHARGETYPE Like'" & Trim(ComboBox1.SelectedItem) & "')  ORDER BY WorkOrder.WORKORDERID"
        Dim sql6 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],                          CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 3) AS numeric(36, 3)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,                          RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],                          TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,                          WorkOrderToDescription.FULLDESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,                          Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],                          Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],                          TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN                         Department_Account RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN                         WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON                          Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN                         Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN                         RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser AS AaaUser_3 INNER JOIN                         RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID   WHERE (WorkOrder.WORKORDERID Like '" & Trim(TextBox1.Text) & "') or  (TimeEntry_Fields.UDF_CHAR3 ='" & Trim(ComboBox1.SelectedItem) & "')  ORDER BY WorkOrder.WORKORDERID"
        Dim sql7 As String = "SELECT        WorkOrder.WORKORDERID AS [Call ID], CONVERT(VARCHAR(20), DATEADD(ss, WorkOrder.CREATEDTIME / 1000 + 3600, CONVERT(DATETIME,'1970-01-01 00:00:00', 102)), 102) AS [Aanmaak Datum], AaaOrganization.NAME AS Bedrijf, RequestCharges.DESCRIPTION AS [Ondernomen Acties],AaaUser_2.FIRST_NAME AS SupportVertegewoordiger, TimeEntry_Fields.UDF_CHAR1 AS Voorrijkosten, TimeEntry_Fields.UDF_CHAR2 AS [Buiten Kantooruren],                          CAST(ROUND(RequestCharges.MM2COMPLETEREQUEST / 1000 / 60 / 60.0, 3) AS numeric(36, 3)) AS [Tijd in uren], CONVERT(VARCHAR(20), DATEADD(ss,                          RequestCharges.EXECUTEDTIME / 1000 + 3600, CONVERT(DATETIME, '1970-01-01 00:00:00', 102)), 102) AS [Datum Uitvoering],                          TimeEntry_Fields.UDF_CHAR3 AS [Akkoord status], RequestCharges.CHARGETYPE AS [Rekening status], WorkOrder.TITLE AS Titel,                          WorkOrderToDescription.FULLDESCRIPTION AS Omschrijving, RequestResolution.RESOLUTION AS Oplossing, TimeEntry_Fields.TIMEENTRYID AS TimeEntryID,                          Customer_Fields.UDF_LONG1 AS Debtor, Customer_Fields.UDF_CHAR2 AS [Strippenkaart-Voorrijden], Customer_Fields.UDF_CHAR1 AS [Strippenkaart-Uren],                          Customer_Fields.UDF_LONG2 AS Voorrijkosten, AaaUser_1.FIRST_NAME, Customer_Fields.UDF_LONG3 AS [Aangepast uurtarief],                          TimeEntry_Fields.UDF_LONG1 AS [Voorrijkosten andere locatie] FROM            StatusDefinition RIGHT OUTER JOIN                         Department_Account RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN                         WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON                          Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN                         Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN                         RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser AS AaaUser_3 INNER JOIN                         RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID   WHERE (WorkOrder.WORKORDERID Like '" & Trim(TextBox1.Text) & "') or  (RequestCharges.CHARGETYPE ='" & Trim(ComboBox1.SelectedItem) & "')  ORDER BY WorkOrder.WORKORDERID"
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        '' Dataadapters voor elke filter is er een aparte dataadapter met bijbehorende query
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim dataadapter2 As New SqlDataAdapter(sql2, connection)
        Dim dataadapter3 As New SqlDataAdapter(sql3, connection)
        Dim dataadapter4 As New SqlDataAdapter(sql4, connection)
        Dim dataadapter5 As New SqlDataAdapter(sql5, connection)
        Dim dataadapter6 As New SqlDataAdapter(sql6, connection)
        Dim dataadapter7 As New SqlDataAdapter(sql7, connection)
        Dim ds As New DataSet()
        ''Een 'if ... then ... else' om te kijken welke filter er is geselecteerd.
        ''Afhankelijk van welke filter er is geselecteerd word er een query uitgevoerd.
        If ComboBox1.SelectedItem = "Akkoord - Service" And TextBox2.Text.Count > 1 _
       Or ComboBox1.SelectedItem = "Akkoord - Te factureren" And TextBox2.Text.Count > 1 Or ComboBox1.SelectedItem = "Afgehandeld - Gefactureerd" And TextBox2.Text.Count > 1 Or ComboBox1.SelectedItem = "Afgehandeld - Service" And TextBox2.Text.Count > 1 _
       Or ComboBox1.SelectedItem = "Afgehandeld - Niet gefactureerd" And TextBox2.Text.Count > 1 Then
            Try
                ToolStripProgressBar1.PerformStep()
                connection.Open()
                dataadapter4.Fill(ds, "WorkOrder")
                connection.Close()
                DataGridView1.DataSource = (ds)
                DataGridView1.DataMember = "WorkOrder"
               
            Catch ex As Exception
                System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
            End Try
        ElseIf ComboBox1.SelectedItem = "Billed" And TextBox2.Text.Count > 1 Or ComboBox1.SelectedItem = "Billable" And TextBox2.Text.Count > 1 Or ComboBox1.SelectedItem = "Non-Billable" And TextBox2.Text.Count > 1 Then
            Try
                ToolStripProgressBar1.PerformStep()
                connection.Open()
                dataadapter5.Fill(ds, "WorkOrder")
                connection.Close()
                DataGridView1.DataSource = (ds)
                DataGridView1.DataMember = "WorkOrder"
             
            Catch ex As Exception
                System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
            End Try
        ElseIf ComboBox1.SelectedItem = "Akkoord - Service" _
Or ComboBox1.SelectedItem = "Akkoord - Te factureren" Or ComboBox1.SelectedItem = "Afgehandeld - Gefactureerd" Or ComboBox1.SelectedItem = "Afgehandeld - Service" _
Or ComboBox1.SelectedItem = "Afgehandeld - Niet gefactureerd" Then
            Try
                ToolStripProgressBar1.PerformStep()
                connection.Open()
                dataadapter6.Fill(ds, "WorkOrder")
                connection.Close()
                DataGridView1.DataSource = (ds)
                DataGridView1.DataMember = "WorkOrder"
             
            Catch ex As Exception
                System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
            End Try
        ElseIf ComboBox1.SelectedItem = "Billed" Or ComboBox1.SelectedItem = "Billable" Or ComboBox1.SelectedItem = "Non-Billable" Then
            Try
                ToolStripProgressBar1.PerformStep()
                connection.Open()
                dataadapter7.Fill(ds, "WorkOrder")
                connection.Close()
                DataGridView1.DataSource = (ds)
                DataGridView1.DataMember = "WorkOrder"
               
            Catch ex As Exception
                System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
            End Try
        ElseIf ComboBox1.SelectedItem = "Datum" And TextBox2.Text.Count > 1 Then
            Try
                ToolStripProgressBar1.PerformStep()
                connection.Open()
                dataadapter3.Fill(ds, "WorkOrder")
                connection.Close()
                DataGridView1.DataSource = (ds)
                DataGridView1.DataMember = "WorkOrder"
              
            Catch ex As Exception
                System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
            End Try
        ElseIf ComboBox1.SelectedItem = "Datum" Then
            Try
                ToolStripProgressBar1.PerformStep()
                connection.Open()
                dataadapter2.Fill(ds, "WorkOrder")
                connection.Close()
                DataGridView1.DataSource = (ds)
                DataGridView1.DataMember = "WorkOrder"
             
            Catch ex As Exception
                System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
            End Try
        Else
            Try
                ToolStripProgressBar1.PerformStep()
                connection.Open()
                dataadapter.Fill(ds, "WorkOrder")
                connection.Close()
                DataGridView1.DataSource = (ds)
                DataGridView1.DataMember = "WorkOrder"
              
            Catch ex As Exception
                System.Windows.MessageBox.Show("Kan geen verbinding maken met de SQL Server.", "Fout!")
            End Try
        End If

        ToolStripProgressBar1.PerformStep()
        Try
            '' Filtert de HTML code uit de text.
            For Each row As DataGridViewRow In DataGridView1.Rows
                Module2.StripTags(row.Cells(3).Value)
                row.Cells(3).Value = row.Cells(3).Value.Replace("&#43;", "+")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&amp;", "&")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&lt;", "<")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&gt;", ">")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&#8216;", "'")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&#8217;", "'")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&#8226;", "")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&#8220;", "")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&#8221;", "")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&#8230;", "")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&quot;", "'")
                row.Cells(3).Value = row.Cells(3).Value.Replace("&middot;", "•")
                row.Cells(3).Value = row.Cells(3).Value.Replace("<br>", Environment.NewLine)
                row.Cells(3).Value = row.Cells(3).Value.Replace("<BR>", Environment.NewLine)
                row.Cells(3).Value = row.Cells(3).Value.Replace("&nbsp;", Environment.NewLine)

            Next
        Catch ex As Exception

        End Try
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells(3).Value = StripHTML(row.Cells(3).Value.ToString)
            Next
        Catch ex As Exception

        End Try
        Try

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


            Next
        Catch ex As Exception

        End Try
        Try
            '' Filtert de HTML code uit de text.
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells(13).Value = StripHTML(row.Cells(13).Value.ToString)
            Next
        Catch ex As Exception
        End Try

        Try
            '' Filtert de HTML code uit de text.
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
                row.Cells(12).Value = row.Cells(12).Value.Replace("<br>", Environment.NewLine)
                row.Cells(12).Value = row.Cells(12).Value.Replace("<BR>", Environment.NewLine)
                row.Cells(12).Value = row.Cells(12).Value.Replace("&nbsp;", Environment.NewLine)
                row.Cells(12).Value = row.Cells(12).Value.Replace("&nbs", Environment.NewLine)


            Next
        Catch ex As Exception

        End Try
        Try
            '' Filtert de HTML code uit de text.
            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Cells(12).Value = StripHTML(row.Cells(12).Value.ToString)
            Next
        Catch ex As Exception

        End Try
        ToolStripProgressBar1.PerformStep()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '' Een 'if ... then ... else' om te kijken of er een Call ID/Filter is ingevoerd.
        '' Textbox1 is voor Call ID en Combobox is voor de filter.
        '' Als er niks is ingevoerd word er een foutmelding laten zien zoniet gaat de applicatie verder met de sub datagridview.
        If TextBox1.Text = Nothing And ComboBox1.SelectedItem = Nothing And TextBox2.Text = Nothing Then
            System.Windows.MessageBox.Show("Er zijn geen filters ingevuld.", "Fout!")
        Else
            Call datagridview()
        End If
    End Sub

    Private Sub bedrijven()
        '' SQL query 
        '' Haalt een lijst op met bedrijven die een ticket op hun naam hebben.
        Dim sql As String = "SELECT DISTINCT AaaOrganization.NAME AS Bedrijf FROM            StatusDefinition RIGHT OUTER JOIN                         Department_Account RIGHT OUTER JOIN                         WorkOrder INNER JOIN                         AaaOrgPostalAddr INNER JOIN                         AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN                         AaaOrganization INNER JOIN                         WorkOrder_Account INNER JOIN                         Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON                          AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN                         WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN                         AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN                         WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON                          Department_Account.ACCOUNTID = Customer.CUSTOMER_ID LEFT OUTER JOIN                         Customer_Fields ON Department_Account.DEPARTMENT_ACCOUNTID = Customer_Fields.DEPARTMENT_ACCOUNTID LEFT OUTER JOIN                        RequestResolution ON WorkOrder.WORKORDERID = RequestResolution.REQUESTID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN                         PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN                         CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID LEFT OUTER JOIN                         ModeDefinition ON WorkOrder.MODEID = ModeDefinition.MODEID LEFT OUTER JOIN                         AaaUser AS AaaUser_3 INNER JOIN                         RequestCharges ON AaaUser_3.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN                         TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN                         AaaUser AS AaaUser_1 LEFT OUTER JOIN                         AaaContactInfo RIGHT OUTER JOIN                         AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON         WorkOrder.REQUESTERID = AaaUser_1.USER_ID        WHERE(WorkOrder.WORKORDERID Is Not NULL)"
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        Try
            connection.Open()
            ds.Clear()
            dataadapter.Fill(ds, "WorkOrder")
            connection.Close()
            '' Plaats alle data in een tabel die niet zichtbaar is.
            DataGridView2.DataSource = (ds)
            DataGridView2.DataMember = "WorkOrder"
            For Each row As DataGridViewRow In DataGridView2.Rows
                '' plaats de bedrijven in de autocompleet lijst
                TextBox2.AutoCompleteCustomSource.Add(row.Cells(0).Value.ToString)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As EventArgs) Handles AllesToolStripMenuItem.Click
        '' Een 'if ... then ... else' om te kijken of er data in de tabel staat.
        '' zo niet word de foutmelding laten zien, anders gaat de applicatie verder.
        If DataGridView1.SelectedRows.Count = 0 Then
            System.Windows.MessageBox.Show("Niks geselecteerd om te exporteren.", "Fout!")
        Else
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.PerformStep()
            Dim xlApp As Excel.Application
            Dim misvalue As Object = System.Reflection.Missing.Value
            xlApp = New Excel.Application
            If xlApp Is Nothing Then
                MsgBox("Er is geen excel geïnstalleerd!", MsgBoxStyle.Critical)
                Return
            End If
            ''Maak excel ontzichtbaar voor nu.
            xlApp.Visible = False
            ''Maak de excel sheet.
            ToolStripProgressBar1.PerformStep()
            With xlApp
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()
                ''kopieert de headers uit de tabel naar excel.
                Dim Col As DataGridViewColumn
                Dim i As Integer = 1
                For Each Col In DataGridView1.Columns
                    .Cells(1, i).Value = Col.HeaderText
                    i += 1
                Next
                ToolStripProgressBar1.PerformStep()
                ''Data naar excel kopieren. 
                i = 2
                Dim RowItem As DataGridViewRow
                Dim Cell As DataGridViewCell
                For Each RowItem In DataGridView1.Rows
                    xlApp.Cells.Columns.AutoFit()
                    Dim j As Integer = 1
                    For Each Cell In RowItem.Cells
                        .Cells(i, j).Value = Cell.Value
                        j += 1
                    Next
                    i += 1
                Next
            End With
            ''Maak excel zichtbaar zodat je kunt opslaan.
            xlApp.Visible = True
            ToolStripProgressBar1.PerformStep()
            ''Een melding weergeven als alles klaar is.
            MsgBox("Export naar excel klaar!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ExporteerSelectieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectieToolStripMenuItem.Click
        '' Een 'if ... then ... else' om te kijken of er data in de tabel staat.
        '' zo niet word de foutmelding laten zien, anders gaat de applicatie verder.
        If DataGridView1.SelectedRows.Count = "0" Then
            System.Windows.MessageBox.Show("Niks geselecteerd om te exporteren.", "Fout!")
        Else
            ToolStripProgressBar1.Value = 0
            ToolStripProgressBar1.PerformStep()
            Dim xlApp As Excel.Application
            Dim misvalue As Object = System.Reflection.Missing.Value
            xlApp = New Excel.Application
            '' een check om te kijken of excel is geintalleerd
            If xlApp Is Nothing Then
                MsgBox("Er is geen excel geïnstalleerd!", MsgBoxStyle.Critical)
                Return
            End If
            ''Maak excel ontzichtbaar voor nu.
            xlApp.Visible = False
            ''Maak de excel sheet.
            ToolStripProgressBar1.PerformStep()
            With xlApp
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()
                ''kopieert de headers uit de tabel naar excel.
                Dim Col As DataGridViewColumn
                Dim i As Integer = 1
                For Each Col In DataGridView1.Columns
                    .Cells(1, i).Value = Col.HeaderText
                    i += 1
                Next
                ToolStripProgressBar1.PerformStep()
                ''Data naar excel kopieren. 
                i = 2
                Dim RowItem As DataGridViewRow
                Dim Cell As DataGridViewCell
                For Each RowItem In DataGridView1.SelectedRows
                    .Cells.Columns.AutoFit()
                    Dim j As Integer = 1
                    For Each Cell In RowItem.Cells
                        .Cells(i, j).Value = Cell.Value
                        j += 1
                    Next
                    i += 1
                Next
            End With
            ''Maak excel zichtbaar zodat je kunt opslaan.
            xlApp.Visible = True
            ToolStripProgressBar1.PerformStep()
            ''Een melding weergeven als alles klaar is.
            MsgBox("Export naar excel klaar!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub releaseobject(ByVal obj As Object)
        '' Dit is voor het sluiten van Excel
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing

        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.FormClosing
        StartScherm.Show() '' Laat het startscherm weer zien zodra het formulier word gesloten.
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close() '' sluit het formulier
    End Sub

    Private Sub start() Handles MyBase.Load
        bedrijven() ''Een verwijzing naar de functie bedrijven(laad een lijst van alle bedrijven)
    End Sub

    Private Sub BilledToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BilledToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        '' Een 'if ... then ... else' om te kijken of er data in de tabel staat.
        '' zo niet word de foutmelding laten zien, anders gaat de applicatie verder.
        If DataGridView1.RowCount = 0 Then
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                ''SQL Query 
                ''deze query maakt gebruik van de tabel, het haalt zelf de call id uit de tabel.
                command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                ''Een melding met een resultaat , er word gevraagt of je het zeker weet.
                ''antwoord je ja dan word de query uitgevoerd.
                ''antwoord je nee dan word er een melding weergegeven.
                If System.Windows.MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als 'Billed' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                    command.ExecuteNonQuery()
                    connection.Close()
                    System.Windows.MessageBox.Show("De actie is nu gemarkeerd als 'Billed' ", "Klaar")
                    ''Dit is de melding die je krijgt als je nee antwoord.
                Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                End If
            Next
        End If
    End Sub

    Private Sub BillableGeenStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillableGeenStatusToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        ''een check die kijkt of er iets is geselecteerd.
        If DataGridView1.RowCount = 0 Then
            '' foutmelding als er geen selectie is gemaakt.
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                '' sql query
                '' update de status naar geen status
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Geen status' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    '' een controle fase.
                    If System.Windows.MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als 'Billable / Geen status' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        '' als je ja antwoord word de update uitgevoerd
                        command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billable' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("De actie is nu gemarkeerd als 'Billable / Geen status' ", "Klaar")
                        ''Dit is de melding die je krijgt als je nee antwoord.
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    '' foutmelding als er iets mis gaat met de query
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub NonBillableGeenStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NonBillableGeenStatusToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        ''een check die kijkt of er iets is geselecteerd.
        If DataGridView1.RowCount = 0 Then
            '' foutmelding als er niks is geselecteerd
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                '' sql query
                '' update de status naar geen status
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Geen status' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    '' een controle fase.
                    If System.Windows.MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als 'Non-Billable / Geen status' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        '' als je ja antwoord word de update uitgevoerd
                        command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Non-Billable' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("De actie is nu gemarkeerd als 'Non-Billable / Geen status' ", "Klaar")
                        ''Dit is de melding die je krijgt als je nee antwoord.
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    '' foutmelding als er iets mis gaat met de query
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        If DataGridView1.RowCount = 0 Then
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    If System.Windows.MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als 'Akkoord - Service' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("De actie is nu gemarkeerd als 'Akkoord - Service' ", "Klaar")
                        ''Dit is de melding die je krijgt als je nee antwoord.
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub TeFacturerenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeFacturerenToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        If DataGridView1.RowCount = 0 Then
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Akkoord - Te factureren' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    If System.Windows.MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als 'Akkoord - Te factureren' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        command.CommandText = "UPDATE RequestCharges SET CHARGETYPE = N'Billed' FROM ModeDefinition RIGHT OUTER JOIN StatusDefinition RIGHT OUTER JOIN RequestResolution RIGHT OUTER JOIN WorkOrder INNER JOIN AaaOrgPostalAddr INNER JOIN AaaPostalAddress ON AaaOrgPostalAddr.POSTALADDR_ID = AaaPostalAddress.POSTALADDR_ID INNER JOIN AaaOrganization INNER JOIN WorkOrder_Account INNER JOIN Customer ON WorkOrder_Account.ACCOUNTID = Customer.CUSTOMER_ID ON AaaOrganization.ORG_ID = Customer.CUSTOMER_ID ON AaaOrgPostalAddr.ORG_ID = AaaOrganization.ORG_ID ON WorkOrder.WORKORDERID = WorkOrder_Account.WORKORDERID INNER JOIN WorkOrderStates ON WorkOrder.WORKORDERID = WorkOrderStates.WORKORDERID INNER JOIN AaaUser AS AaaUser_2 ON WorkOrderStates.OWNERID = AaaUser_2.USER_ID INNER JOIN WorkOrderToDescription ON WorkOrder.WORKORDERID = WorkOrderToDescription.WORKORDERID ON RequestResolution.REQUESTID = WorkOrder.WORKORDERID ON StatusDefinition.STATUSID = WorkOrderStates.STATUSID LEFT OUTER JOIN PriorityDefinition ON WorkOrderStates.PRIORITYID = PriorityDefinition.PRIORITYID LEFT OUTER JOIN CategoryDefinition ON WorkOrderStates.CATEGORYID = CategoryDefinition.CATEGORYID ON ModeDefinition.MODEID = WorkOrder.MODEID LEFT OUTER JOIN AaaUser INNER JOIN RequestCharges ON AaaUser.USER_ID = RequestCharges.OWNERID ON WorkOrder.WORKORDERID = RequestCharges.WORKORDERID LEFT OUTER JOIN TimeEntry_Fields ON RequestCharges.REQUESTCHARGEID = TimeEntry_Fields.TIMEENTRYID LEFT OUTER JOIN AaaUser AS AaaUser_1 LEFT OUTER JOIN AaaContactInfo RIGHT OUTER JOIN AaaUserContactInfo ON AaaContactInfo.CONTACTINFO_ID = AaaUserContactInfo.CONTACTINFO_ID ON AaaUser_1.USER_ID = AaaUserContactInfo.USER_ID ON WorkOrder.REQUESTERID = AaaUser_1.USER_ID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("De actie is nu gemarkeerd als 'Akkoord - Te factureren' ", "Klaar")
                        ''Dit is de melding die je krijgt als je nee antwoord.
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub ServiceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ServiceToolStripMenuItem1.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        If DataGridView1.RowCount = 0 Then
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Service' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    If System.Windows.MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als 'Afgehandeld - Service' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("Deze actie is nu gemarkeerd als 'Afgehandeld - Service' ", "Klaar")
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub GefactureerdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GefactureerdToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        If DataGridView1.RowCount = 0 Then
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    If System.Windows.MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als 'Afgehandeld - Gefactureerd' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("Deze actie is nu gemarkeerd als 'Afgehandeld - gefactureerd' ", "Klaar")
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub AvondUrenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AvondUrenToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        If DataGridView1.RowCount = 0 Then
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Avond' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    If System.Windows.MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als 'Avond' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("De uren van deze actie zijn nu gemarkeerd als 'Avond' ", "Klaar")
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub WeekendUrenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeekendUrenToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        If DataGridView1.RowCount = 0 Then
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Weekend' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    If System.Windows.MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als 'Weekend' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("De uren van deze actie zijn nu gemarkeerd als 'Weekend' ", "Klaar")
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub NormalenUrenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalenUrenToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        If DataGridView1.RowCount = 0 Then
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR2 ='Nee' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    If System.Windows.MessageBox.Show("Weet je zeker dat je de uren van deze actie wilt markeren als 'Normaal' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("De uren van deze actie zijn nu gemarkeerd als 'Normaal' ", "Klaar")
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub NietGeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NietGeToolStripMenuItem.Click
        Dim connection As New SqlConnection(UC_Systems_SC_Export2.My.Settings.SCconnect)
        Dim command As New System.Data.SqlClient.SqlCommand
        If DataGridView1.RowCount = 0 Then
            System.Windows.MessageBox.Show("Geen selectie.", "Fout!")
        Else
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                connection.Open()
                command.Connection = connection
                command.CommandText = "UPDATE TimeEntry_Fields SET UDF_CHAR3 ='Afgehandeld - Niet gefactureerd' FROM TimeEntry_Fields INNER JOIN RequestCharges ON TimeEntry_Fields.TIMEENTRYID = RequestCharges.REQUESTCHARGEID INNER JOIN WorkOrder ON RequestCharges.WORKORDERID = WorkOrder.WORKORDERID WHERE (TimeEntry_Fields.TIMEENTRYID='" & Trim(row.Cells(14).Value) & "')"
                Try
                    If System.Windows.MessageBox.Show("Weet je zeker dat je deze actie wilt markeren als 'Afgehandeld - Niet gefactureerd' ?", "Bevestigen", MessageBoxButtons.YesNo) = System.Windows.MessageBoxResult.Yes Then
                        command.ExecuteNonQuery()
                        connection.Close()
                        System.Windows.MessageBox.Show("Deze actie is nu gemarkeerd als 'Afgehandeld - Niet gefactureerd' ", "Klaar")
                    Else : System.Windows.MessageBox.Show("Er zijn geen wijzigen gedaan", "Bevestiging")
                    End If
                Catch ex As Exception
                    System.Windows.MessageBox.Show("Er ging iets fout met het uitvoeren van de update query.", "Fout!")
                End Try
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '' Reset alle velden
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        ComboBox1.SelectedItem = Nothing
    End Sub

    Function StripHTML(sInput As String) As String
        '' functie om html tags uit text te filteren
        Dim RegEx As Object
        RegEx = CreateObject("vbscript.regexp")

        Dim sOut As String
        With RegEx
            .Global = True
            .IgnoreCase = True
            .MultiLine = True
            .Pattern = "<[^>]+>"
        End With

        sOut = RegEx.Replace(sInput, "")
        StripHTML = sOut
        RegEx = Nothing
    End Function


End Class
