Imports System.Configuration
Imports System.Data.Odbc
Imports System.IO
Imports System.Text
Imports Zebra.Sdk.Comm
Imports Zebra.Sdk.Printer
Imports Zebra.Sdk.Printer.Discovery

Public Class Form1
    Dim second As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        Label6.Visible = False
        'Timer1.Interval = 1000
        'Timer1.Start() 'Timer starts functioning
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Label6.Text = DateTime.Now.ToString
        Label6.Visible = False
        'second = second + 1
        'If second >= 10 Then
        '    Timer1.Stop() 'Timer stops functioning
        '    MsgBox("Timer Stopped....")
        'End If

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub
    Private startcnt As Integer = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = "3" Then
            gbCL60.Visible = True
        Else
            gbCL60.Visible = False
        End If
        startcnt = 1
        Machine.Text = getmachinelist()
        Button2.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        GOODCOUNT.Text = ""
        BADCOUNT.Text = ""
        TOTALCOUNT.Text = ""

        DataGridView1.Rows.Clear()
        Button3.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        Button4.Enabled = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TARGETCOUNT.Text = TextBox2.Text
    End Sub
    Private Function getprintbyTCP() As Boolean
        If Machine.Text = "" Then
            MessageBox.Show("Machine Details not available".ToUpper)
            Return False
        End If
        Dim pFlag As Boolean = True

        Dim thePrinterConn As TcpConnection = New TcpConnection(Machine.Text,
                                                                TcpConnection.DEFAULT_ZPL_TCP_PORT)
        Try
            thePrinterConn.Open()
            'CALIBRATE
            thePrinterConn.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("CalibrateZPL")), 500, 500, "null")
        Catch ex As Exception
            pFlag = False
        Finally
            thePrinterConn.Close()
        End Try

        Return pFlag
    End Function
    Private Function getprintbyTCPread() As Boolean
        If Machine.Text = "" Then
            MessageBox.Show("Machine Details not available".ToUpper)
            Return False
        End If
        Dim pFlag As Boolean = True

        Dim thePrinterConn As TcpConnection = New TcpConnection(Machine.Text,
                                                                TcpConnection.DEFAULT_ZPL_TCP_PORT)

        'Dim pFlag As Boolean
        'Dim pUsb As UsbConnection = New UsbConnection(txtPrinter)

        Try

            thePrinterConn.Open()


            '    ProgressBar1.Minimum = 0
            '    ProgressBar1.Maximum = TextBox2.Text


            '    DataGridView1.ColumnCount = 3
            '    DataGridView1.Columns(0).Name = "SR ID"
            '    DataGridView1.Columns(0).Width = 50
            '    DataGridView1.Columns(1).Name = "TID DETAILS"
            '    DataGridView1.Columns(1).Width = 300
            '    DataGridView1.Columns(2).Name = "TID LENGTH"
            '    DataGridView1.Columns(2).Width = 50
            '    Dim row As String()
            '    Dim strTID As String
            '    For I As Integer = startcnt To TextBox2.Text
            '        Dim tid As Byte() = thePrinterConn.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("QCZPL1")), 1500, 1500, "null")
            '        If System.Text.Encoding.UTF8.GetString(tid) = "" Then
            '            startcnt = I + 1
            '            BADCOUNT.Text = Val(BADCOUNT.Text) + 1
            '            MessageBox.Show("Response not received.", "Bad Label found")
            '            Exit For
            '        Else
            '            strTID = System.Text.Encoding.UTF8.GetString(tid) '"E280117210602198B" + I.ToString
            '            row = New String() {I, strTID, strTID.ToString.Length}
            '            DataGridView1.Rows.Add(row)
            '            ProgressBar1.Value = I
            '            GOODCOUNT.Text = Val(GOODCOUNT.Text) + I.ToString
            '        End If
            '        TOTALCOUNT.Text = Val(GOODCOUNT.Text) + Val(BADCOUNT.Text)
            '    Next
            '    TOTALCOUNT.Text = Val(GOODCOUNT.Text) + Val(BADCOUNT.Text)

            'Catch ex As ConnectionException
            '    MessageBox.Show(ex.Message)
            'Catch ex2 As ZebraPrinterLanguageUnknownException
            '    MessageBox.Show(ex2.Message)
            'Catch ex1 As Exception
            '    MessageBox.Show(ex1.Message)
            'Finally
            '    thePrinterConn.Close()
            'End Try
            'Return pFlag


            '------------------------

            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = (Val(TextBox2.Text) + Val(BADCOUNT.Text))

            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            DataGridView1.ColumnCount = 3
            DataGridView1.Columns(0).Name = "SR ID"
            DataGridView1.Columns(0).Width = 50
            DataGridView1.Columns(1).Name = "TID DETAILS"
            DataGridView1.Columns(1).Width = 300
            DataGridView1.Columns(2).Name = "TID LENGTH"
            DataGridView1.Columns(2).Width = 50
            Dim row As String()
            Dim strTID As String
            For I As Integer = startcnt To TextBox2.Text
                Dim tid As Byte() = thePrinterConn.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("QCZPL11")), 1800, 1800, "null")
                ' MessageBox.Show(System.Text.Encoding.UTF8.GetString(tid))
                If System.Text.Encoding.UTF8.GetString(tid) = "" Then
                    startcnt = I + 1
                    BADCOUNT.Text = Val(BADCOUNT.Text) + 1
                    MessageBox.Show("Response not received.Bad Label found", "Bad Label found")
                    Exit For
                Else
                    'If (System.Text.Encoding.UTF8.GetString(tid).ToString.Contains("JJ")) Then
                    '    strTID = System.Text.Encoding.UTF8.GetString(tid).ToString.Substring(11, System.Text.Encoding.UTF8.GetString(tid).ToString.Length - 1)
                    'Else
                    '    strTID = System.Text.Encoding.UTF8.GetString(tid).ToString '"E280117210602198B" + I.ToString
                    'End If
                    strTID = System.Text.Encoding.UTF8.GetString(tid).ToString '"E280117210602198B" + I.ToString
                    row = New String() {I, strTID, strTID.ToString.Length}
                    DataGridView1.Rows.Add(row)

                    GOODCOUNT.Text = Val(GOODCOUNT.Text) + 1
                End If
                ProgressBar1.Value = I
                TOTALCOUNT.Text = Val(GOODCOUNT.Text) + Val(BADCOUNT.Text)
            Next
            If BADCOUNT.Text = "" Then
                BADCOUNT.Text = "0"
            End If
            ProgressBar1.Value = (Val(TextBox2.Text) + Val(BADCOUNT.Text))
            TOTALCOUNT.Text = Val(GOODCOUNT.Text) + Val(BADCOUNT.Text)

        Catch ex As ConnectionException
            MessageBox.Show(ex.Message)
        Catch ex2 As ZebraPrinterLanguageUnknownException
            MessageBox.Show(ex2.Message)
        Catch ex1 As Exception
            MessageBox.Show(ex1.Message)
        Finally
            thePrinterConn.Close()
        End Try
        If Val(TARGETCOUNT.Text) > Val(TOTALCOUNT.Text) Then

        Else
            ' Button3.Enabled = False
            Button4.Enabled = True
        End If
        Return pFlag
    End Function
    Private Function getprintbyUSBread() As Boolean

        Dim txtPrinter As String = ""
        For Each usbPrinter In UsbDiscoverer.GetZebraUsbPrinters(New ZebraPrinterFilter())
            txtPrinter = usbPrinter.Address
        Next
        Dim pFlag As Boolean
        Dim pUsb As UsbConnection = New UsbConnection(txtPrinter)
        '  Using sw As New StreamWriter(File.Create("QCReport_" + Today.Day.ToString() + Today.Month.ToString() + Date.Now.Minute.ToString() + Date.Now.Second.ToString() + ".xls", FileMode.CreateNew))
        ' MessageBox.Show(ConfigurationManager.AppSettings("QCZPL11"))
        Try

                pUsb.Open()

                'Dim tid1 As Byte() = pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("QCZPL11")), 1800, 1800, "null")
                'MessageBox.Show(System.Text.Encoding.UTF8.GetString(tid1))

                ProgressBar1.Minimum = 0
                ProgressBar1.Maximum = (Val(TextBox2.Text) + Val(BADCOUNT.Text))

                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                DataGridView1.ColumnCount = 3
                DataGridView1.Columns(0).Name = "SR ID"
                DataGridView1.Columns(0).Width = 40
                DataGridView1.Columns(1).Name = "TID DETAILS"
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Name = "TID LENGTH"
                DataGridView1.Columns(2).Width = 60
                Dim row As String()
                Dim strTID As String

                Dim startcntBAD As Integer = 0
            'sw.WriteLine("  ")
            'sw.WriteLine("QC Reading For Customer-  " + TextBox1.Text)
            'sw.WriteLine("  ")
            'sw.WriteLine("Qunatity -  " + TextBox2.Text)
            'sw.WriteLine("  ")
            'sw.WriteLine("Roll -  " + TextBox3.Text)
            'sw.WriteLine("  ")
            'sw.WriteLine("QC Reading Start at " + Date.Now.ToString)
            'sw.WriteLine("  ")
            Dim srno As Integer = 1
                If startcnt > 1 Then
                    srno = startcnt
                End If
                For I As Integer = startcnt To (Val(TextBox2.Text) + Val(BADCOUNT.Text))
                    Dim tid As Byte() = pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("QCZPL_1")), Val(TextBox4.Text), Val(TextBox5.Text), "null")
                    ' MessageBox.Show(System.Text.Encoding.UTF8.GetString(tid))
                    '  srno = srno + 1
                    If System.Text.Encoding.UTF8.GetString(tid) = "" Then
                        '  MessageBox.Show(ConfigurationManager.AppSettings("QCZPL_RMN"))
                        'Dim tidn As Byte() = pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes("^XA~JA^XZ"), Val(TextBox4.Text), Val(TextBox5.Text), "null")
                        'MessageBox.Show(System.Text.Encoding.UTF8.GetString(tidn))
                        'Dim tid1 As Byte() = pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("QCZPL_RMN")), Val(TextBox4.Text) + 200, Val(TextBox5.Text), "null")
                        MessageBox.Show("Please take action against the bad label, and then continue QC process", "Bad tag found")
                        '  MessageBox.Show(System.Text.Encoding.UTF8.GetString(tid1))
                        Dim tid1n As Byte() = pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("QCZPL_RMN")), Val(TextBox4.Text), Val(TextBox5.Text), "null")

                        Dim QCZPL_28n As Byte() = pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("QCZPL_28n")), Val(TextBox4.Text), Val(TextBox5.Text), "null")
                        ' MessageBox.Show(System.Text.Encoding.UTF8.GetString(QCZPL_28n))
                        Try
                            If (System.Text.Encoding.UTF8.GetString(QCZPL_28n).ToString.Length > 28) Then
                                strTID = System.Text.Encoding.UTF8.GetString(QCZPL_28n).ToString
                                If (strTID.Trim.Split("+,0").Length > 1) Then
                                    For iii As Integer = 0 To strTID.Trim.Split("+,0").Length - 1
                                        'MessageBox.Show(strTID.Trim.Split("+,0")(iii))
                                        'MessageBox.Show(strTID.Trim.Split("+,0")(iii).Length)
                                        If (strTID.Trim.Split("+,0")(iii).Length > 26) Then
                                            row = New String() {srno, " +" + strTID.Trim.Split("+,0")(iii), (" +" + strTID.Trim.Split("+,0")(iii)).ToString.Length}
                                            DataGridView1.Rows.Add(row)
                                        End If
                                    Next
                                End If



                            End If
                        Catch ex As Exception

                        End Try
                    ' pUsb.Close()

                    startcnt = I + 1
                        startcntBAD = startcntBAD + 1
                        BADCOUNT.Text = Val(BADCOUNT.Text) + 1

                        '  MessageBox.Show("Please take action against the bad label, and then continue QC process", "Bad tag found")

                        Exit For

                        'ElseIf System.Text.Encoding.UTF8.GetString(tid).ToString.Contains("-,") Then
                        '    startcntBAD = startcntBAD + 1
                        '    startcnt = I + 1
                        '    BADCOUNT.Text = Val(BADCOUNT.Text) + 1
                        '    MessageBox.Show("Response not received.Bad Label found", "Bad Label found")
                        '    Exit For
                        '    'If (System.Text.Encoding.UTF8.GetString(tid).ToString.Contains("JJ")) Then
                        '    strTID = System.Text.Encoding.UTF8.GetString(tid).ToString.Substring(11, System.Text.Encoding.UTF8.GetString(tid).ToString.Length - 1)
                        'Else
                        '    strTID = System.Text.Encoding.UTF8.GetString(tid).ToString '"E280117210602198B" + I.ToString
                        'End If
                        'If (System.Text.Encoding.UTF8.GetString(tid).ToString.Length > 24) Then
                        '    strTID = System.Text.Encoding.UTF8.GetString(tid).ToString.Substring(11, System.Text.Encoding.UTF8.GetString(tid).ToString.Length - 11)
                        'Else
                        '        strTID = System.Text.Encoding.UTF8.GetString(tid).ToString '"E280117210602198B" + I.ToString
                        '    End If
                        ' Exit For
                    Else


                        'If (strTID.Contains("JJ")) Then
                        '    strTID = System.Text.Encoding.UTF8.GetString(tid).ToString.Substring(11, System.Text.Encoding.UTF8.GetString(tid).ToString.Length - 11)
                        'Else
                        '    strTID = System.Text.Encoding.UTF8.GetString(tid).ToString.Replace("HEADER", "").Replace("TERMINATION", "")
                        'End If
                        strTID = System.Text.Encoding.UTF8.GetString(tid).ToString
                    If (strTID.Trim.Split("+,0").Length > 1) Then
                        For iii As Integer = 0 To strTID.Trim.Split("+,0").Length - 1
                            'MessageBox.Show(strTID.Trim.Split("+,0")(iii))
                            'MessageBox.Show(strTID.Trim.Split("+,0")(iii).Length)
                            If (strTID.Trim.Split("+,0")(iii).Length > 26) Then
                                row = New String() {srno, " +" + strTID.Trim.Split("+,0")(iii), (" +" + strTID.Trim.Split("+,0")(iii)).ToString.Length}
                                DataGridView1.Rows.Add(row)
                            End If
                        Next
                    Else
                        row = New String() {srno, strTID, strTID.ToString.Length}
                        ' 
                        DataGridView1.Rows.Add(row)
                    End If


                    '  sw.WriteLine("Tid  -  " + strTID.ToString)
                    GOODCOUNT.Text = Val(GOODCOUNT.Text) + 1

                    End If
                    srno = srno + 1
                    ProgressBar1.Value = I
                    TOTALCOUNT.Text = Val(GOODCOUNT.Text) + Val(BADCOUNT.Text)
                Next

                If BADCOUNT.Text = "" Then
                    BADCOUNT.Text = "0"
                End If
                Try
                    ProgressBar1.Value = (Val(TextBox2.Text) + Val(BADCOUNT.Text))
                Catch ex As Exception
                    ProgressBar1.Value = Val(TextBox2.Text)
                End Try
                TOTALCOUNT.Text = (Val(TextBox2.Text) + Val(BADCOUNT.Text))
            'sw.WriteLine("  ")
            'sw.WriteLine("  ")
            'sw.WriteLine("Good Count " + GOODCOUNT.Text)
            'sw.WriteLine("  ")
            'sw.WriteLine("Bad Count " + BADCOUNT.Text)
            'sw.WriteLine("  ")
            'sw.WriteLine("Total Count " + TOTALCOUNT.Text)
            'sw.WriteLine("  ")
            'sw.WriteLine("QC Reading END at " + Date.Now.ToString)

        Catch ex As ConnectionException
            ' sw.WriteLine("QC Reading Error ConnectionException " + ex.Message)
            MessageBox.Show(ex.Message)
            Catch ex2 As ZebraPrinterLanguageUnknownException
            '    sw.WriteLine("QC Reading  Error ZebraPrinterLanguageUnknownException -  " + ex2.Message)
            MessageBox.Show(ex2.Message)
            Catch ex1 As Exception
            '    sw.WriteLine("QC Reading Error Exception - " + ex1.Message)
            MessageBox.Show(ex1.Message)
            Finally
                pUsb.Close()
            End Try
            If Val(TARGETCOUNT.Text) > Val(TOTALCOUNT.Text) Then

            Else
                ' Button3.Enabled = False
                Button4.Enabled = True
            End If
        'End Using
        Return pFlag
    End Function
    Private Function getprintbyUSBR() As Boolean
        If Machine.Text = "" Then
            MessageBox.Show("Machine Details not available".ToUpper)
            Return False
        End If
        Dim txtPrinter As String = ""
        For Each usbPrinter In UsbDiscoverer.GetZebraUsbPrinters(New ZebraPrinterFilter())

            txtPrinter = usbPrinter.Address
        Next
        Dim pFlag As Boolean
        Dim pUsb As UsbConnection = New UsbConnection(txtPrinter)

        Try

            pUsb.Open()
            pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("CalibrateZPLR")), 1000, 1000, "null")
            'Dim p11 As ZebraPrinter = ZebraPrinterFactory.GetInstance(pUsb)
            ''  p11.SendCommand(TextBox1.Text)
            'p11.Calibrate()
            ''MessageBox.Show("Calibrated by usbconnection")
            ''p11.GetCurrentStatus()
            ''MessageBox.Show(p11.GetCurrentStatus().ToString)
            ''Dim tid As Byte() = pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes("^XA^FN1^RFR,H,0,12,2^FS^FH_^HV1,256^FS^RFW,H,1,14,1^FD3000313233343536373839414243^FS^XZ"), 1500, 1500, "null")
            ''^XA^RS8^RFW,H^FD_BARCODE^FS^RFR,H^FD_BARCODE^FS^HV1,256,_BARCODE,_BARCODE,L^FS^fo50,150^fdPRIYAUPKARE_BARCODE^XZ
            ''Dim strzpl As String
            ''strzpl = ConfigurationManager.AppSettings("CalibrateZPL")

            ''  MessageBox.Show("SendAndWaitForResponse" + System.Text.Encoding.UTF8.GetString(tid))
        Catch ex As ConnectionException
            MessageBox.Show(ex.Message)
        Catch ex2 As ZebraPrinterLanguageUnknownException
            MessageBox.Show(ex2.Message)
        Catch ex1 As Exception
            MessageBox.Show(ex1.Message)
        Finally
            pUsb.Close()
        End Try
        Return pFlag
    End Function
    Private Function getprintbyUSBC() As Boolean
        If Machine.Text = "" Then
            MessageBox.Show("Machine Details not available".ToUpper)
            Return False
        End If
        Dim txtPrinter As String = ""
        For Each usbPrinter In UsbDiscoverer.GetZebraUsbPrinters(New ZebraPrinterFilter())

            txtPrinter = usbPrinter.Address
        Next
        Dim pFlag As Boolean
        Dim pUsb As UsbConnection = New UsbConnection(txtPrinter)

        Try

            pUsb.Open()
            pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes(ConfigurationManager.AppSettings("CalibrateZPLC")), 1000, 1000, "null")
            'Dim p11 As ZebraPrinter = ZebraPrinterFactory.GetInstance(pUsb)
            ''  p11.SendCommand(TextBox1.Text)
            'p11.Calibrate()
            ''MessageBox.Show("Calibrated by usbconnection")
            ''p11.GetCurrentStatus()
            ''MessageBox.Show(p11.GetCurrentStatus().ToString)
            ''Dim tid As Byte() = pUsb.SendAndWaitForResponse(Encoding.UTF8.GetBytes("^XA^FN1^RFR,H,0,12,2^FS^FH_^HV1,256^FS^RFW,H,1,14,1^FD3000313233343536373839414243^FS^XZ"), 1500, 1500, "null")
            ''^XA^RS8^RFW,H^FD_BARCODE^FS^RFR,H^FD_BARCODE^FS^HV1,256,_BARCODE,_BARCODE,L^FS^fo50,150^fdPRIYAUPKARE_BARCODE^XZ
            ''Dim strzpl As String
            ''strzpl = ConfigurationManager.AppSettings("CalibrateZPL")

            ''  MessageBox.Show("SendAndWaitForResponse" + System.Text.Encoding.UTF8.GetString(tid))
        Catch ex As ConnectionException
            MessageBox.Show(ex.Message)
        Catch ex2 As ZebraPrinterLanguageUnknownException
            MessageBox.Show(ex2.Message)
        Catch ex1 As Exception
            MessageBox.Show(ex1.Message)
        Finally
            pUsb.Close()
        End Try
        Return pFlag
    End Function
    Private Function GetConnectionString() As String
        Dim strConn As String
        'If GlobalVariables.logProd = 1 Then
        strConn = ConfigurationManager.AppSettings("dbconn") '"Driver={PostgreSQL ANSI};database=tagid;server=portal.tagid.co.in;port=5432;uid=root;sslmode=disable;readonly=0;protocol=7.4;User ID=root;password=OOghksRHGVtvn67t8vu;"
        ' End If
        Return strConn
    End Function

    Private Function InsertDBCL60K() As String
        If GOODCOUNT.Text = "" Then
            GOODCOUNT.Text = "0"
        End If
        If BADCOUNT.Text = "" Then
            BADCOUNT.Text = "0"
        End If
        Dim CL60KSEQ As String = ""
        Try
            Dim DataTable As New Data.DataTable
            Using OdbcConnection As New Odbc.OdbcConnection(GetConnectionString())
                OdbcConnection.Open()
                Try
                    Using cmdDups As New OdbcCommand("Select  MAX(""CL60id"") aa from ""public"".""CL60K_MASTER""  ", OdbcConnection)
                        DataTable.Load(cmdDups.ExecuteReader)
                    End Using
                    OdbcConnection.Close()
                    Dim c1 As New ComboBox
                    c1.DataSource = DataTable
                    c1.DisplayMember = DataTable.Columns("aa").ToString
                    c1.ValueMember = DataTable.Columns("aa").ToString
                    CL60KSEQ = (Val(DataTable.Rows(0).Item("aa")) + 1).ToString
                Catch ex As Exception
                    CL60KSEQ = 0
                End Try
                OdbcConnection.Close()
            End Using
        Catch ex As Exception
            CL60KSEQ = 0
        End Try
        Try
            Using DupConn As New Odbc.OdbcConnection(GetConnectionString())
                DupConn.Open()

                Using cmd As New OdbcCommand("    INSERT INTO ""public"".""CL60K_MASTER""  VALUES (" + CL60KSEQ + ", '" + TextBox1.Text + "', " + TextBox2.Text + ", '" + ConfigurationManager.AppSettings("CREATEDBY") + "', current_timestamp, 'QCDONE', " + GOODCOUNT.Text + ", " + BADCOUNT.Text + ", '" + TextBox3.Text + "', '" + Machine.Text + "')", DupConn)
                    cmd.ExecuteNonQuery()
                End Using
                DupConn.Close()
            End Using

        Catch ex As Exception

            MessageBox.Show(" Error at update : " + ex.Message)
        End Try
        Return CL60KSEQ


    End Function
    Private Function InsertDBCL60KDetails(tiddetails As String, CL60KSEQ As String, CL60KSEQd As String) As String

        Try
            Using DupConn As New Odbc.OdbcConnection(GetConnectionString())
                DupConn.Open()
                Using cmd As New OdbcCommand("    INSERT INTO ""public"".""CL60K_MASTER_DETAILS""  VALUES (" + CL60KSEQd + ", " + CL60KSEQ + ", '" + tiddetails + "', current_timestamp)", DupConn)

                    cmd.ExecuteNonQuery()
                End Using
                DupConn.Close()
            End Using

        Catch ex As Exception

            MessageBox.Show(" Error at update : " + ex.Message)
        End Try
        Return ""
    End Function
    Private Function ValidateCL60K() As String
        Dim pFlag As String = "0"

        Dim dt As New Data.DataTable
        Using DupConn As New Odbc.OdbcConnection(GetConnectionString())
            DupConn.Open()
            ' Dim j As Integer = 0
            Try
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(0, i).Value = True Then
                        Using cmdDups As New OdbcCommand("Select  * from Public.CL60K_MASTER  where   CustomerName='" + TextBox1.Text + "' and CL60KRollID='" + TextBox3.Text + "'", DupConn)
                            'cmdDups.Parameters.Add("@auction_name", OdbcType.VarChar).Value = txt_auction_name.Text
                            dt.Load(cmdDups.ExecuteReader)
                        End Using
                    End If
                Next

                If dt.Rows.Count > 0 Then
                    MessageBox.Show("Duplicate CL60K RollID found")
                    pFlag = "1"
                End If
            Catch ex As Exception

            End Try
            DupConn.Close()
        End Using
        Return pFlag
    End Function
    Private Function getmachinelist() As String
        Dim strMachine As String
        strMachine = ConfigurationManager.AppSettings("MachineIPAddress")
        Return strMachine
        'Dim DupMessage As String
        'Dim DupTitle As String
        'Try
        '    Dim dt As New Data.DataTable
        '    Using DupConn As New Odbc.OdbcConnection(GetConnectionString())
        '        DupConn.Open()

        '        Using cmdDups As New OdbcCommand("select machine_id,machine_ip from  public.machine_master", DupConn)
        '            'cmdDups.Parameters.Add("@auction_name", OdbcType.VarChar).Value = txt_auction_name.Text
        '            dt.Load(cmdDups.ExecuteReader)
        '        End Using
        '        DupConn.Close()
        '    End Using
        '    ComboBox2.DataSource = dt
        '    ComboBox2.DisplayMember = dt.Columns("machine_id").ToString
        '    ComboBox2.ValueMember = dt.Columns("machine_ip").ToString ' dt.Columns("machine_ip").ToString

        '    ' Label4.Text = ComboBox2.SelectedValue
        '    If dt.Rows.Count = 0 Then
        '        DupTitle = "Unique Record - Save Allowed"
        '        'If strEditType = "Edit" Then
        '        '    DupMessage = "This will save changes to an existing Unique record for Auction ID " + txt_auction_id.Text + " and Auction Name " + txt_auction_name.Text + " and Location Name " + txt_location_address.Text
        '        '    UpdateAuction()
        '        'Else
        '        '    DupMessage = "This will create a Unique record for Auction ID " + txt_auction_id.Text + " and Auction Name " + txt_auction_name.Text + " and Location Name " + txt_location_address.Text
        '        '    InsertAuction()
        '        'End If
        '    Else
        '        DupTitle = "Duplicate Record - Save NOT Allowed"
        '        'DupMessage = $"A record already exists with Auction ID {txt_auction_id.Text} and Auction Name {txt_auction_name.Text} and Location Name {txt_location_address.Text}"
        '        'MessageBox.Show(DupMessage, DupTitle)
        '    End If
        'Catch ex As Exception
        '    DupTitle = "Connection failed"
        '    DupMessage = "Unable to Open Auction Information Connection to check for Existing Records" + ex.Message
        '    MessageBox.Show(DupMessage, DupTitle)
        'End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CONNBY As String = ConfigurationManager.AppSettings("connectionby")
        If CONNBY = "USB" Then
            If getprintbyUSBC() = True Then


            End If
        End If
        'If CONNBY = "TCP" Then
        '    If getprintbyTCP() = True Then


        '    End If
        'End If
        'Try
        '    If ComboBox2.Items.Count = 0 Then
        '        MessageBox.Show("Machine Details not available".ToUpper)
        '        Return
        '    End If
        'Catch ex As Exception

        'End Try
        'If ComboBox2.SelectedIndex = "0" Then
        '    MessageBox.Show("Select Machine Details")
        '    Return
        'End If

        'calibration

        'machine list

        'enabled
        EnableControl(True)
        ' Button2.Enabled = False
        Button3.Enabled = True
    End Sub
    Sub EnableControl(pFlag As Boolean)
        TextBox2.Enabled = pFlag
        TextBox1.Enabled = pFlag
        TextBox3.Enabled = pFlag
        ' Button4.Enabled = pFlag
        Button3.Enabled = pFlag
        '  ComboBox2.Enabled = pFlag
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("Enter Customer Name".ToUpper)
            Return
        End If
        If TextBox3.Text = "" Then
            MessageBox.Show("Enter CL60K ROLL ID".ToUpper)
            Return
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("Enter Quantity for QC".ToUpper)
            Return
        End If
        Dim CONNBY As String = ConfigurationManager.AppSettings("connectionby")
        If CONNBY = "USB" Then
            If getprintbyUSBread() = True Then


            End If
        End If
        If CONNBY = "TCP" Then
            If getprintbyTCPread() = True Then


            End If
        End If
        'validation


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pf As String = InsertDBCL60K()
        If pf = "" Then
            Return
        End If
        Dim cseqd As String = getseq()
        Try
            Using sw As New StreamWriter(File.Create("QCReport_" + Today.Day.ToString() + Today.Month.ToString() + Date.Now.Minute.ToString() + Date.Now.Second.ToString() + ".xls", FileMode.CreateNew))
                sw.WriteLine("  ")
                sw.WriteLine("QC Reading For Customer-  " + TextBox1.Text)
                sw.WriteLine("  ")
                sw.WriteLine("Qunatity -  " + TextBox2.Text)
                sw.WriteLine("  ")
                sw.WriteLine("Roll -  " + TextBox3.Text)
                sw.WriteLine("  ")
                sw.WriteLine("QC Reading Start at " + Date.Now.ToString)
                sw.WriteLine("  ")

                sw.WriteLine("  ")

                For i As Integer = 1 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Item(1, i).Value <> Nothing Then
                        If DataGridView1.Item(1, i).Value.ToString <> "" Then
                            InsertDBCL60KDetails(DataGridView1.Item(1, i).Value, pf, cseqd)
                            cseqd = Val(cseqd) + 1
                            sw.WriteLine("Tid  -  " + DataGridView1.Item(1, i).Value.ToString)
                        End If
                    End If

                Next
                sw.WriteLine("  ")
                sw.WriteLine("  ")
                sw.WriteLine("Good Count " + GOODCOUNT.Text)
                sw.WriteLine("  ")
                sw.WriteLine("Bad Count " + BADCOUNT.Text)
                sw.WriteLine("  ")
                sw.WriteLine("Total Count " + TOTALCOUNT.Text)
                sw.WriteLine("  ")
                sw.WriteLine("QC Reading END at " + Date.Now.ToString)
            End Using
        Catch ex As Exception

        End Try
        Button4.Enabled = False
    End Sub
    Private Function getseq() As String
        Dim CL60KSEQd As String = ""
        Try
            Dim DataTable As New Data.DataTable


            Using OdbcConnection As New Odbc.OdbcConnection(GetConnectionString())
                OdbcConnection.Open()
                ' Dim j As Integer = 0
                Try

                    Using cmdDups As New OdbcCommand("Select  MAX(""CL60MDid"") aa from ""public"".""CL60K_MASTER_DETAILS""  ", OdbcConnection)
                        DataTable.Load(cmdDups.ExecuteReader)
                    End Using

                    Dim ct As New ComboBox
                    ct.DataSource = DataTable
                    ct.DisplayMember = DataTable.Columns("aa").ToString
                    ct.ValueMember = DataTable.Columns("aa").ToString
                    CL60KSEQd = (Val(DataTable.Rows(0).Item("aa") + 1)).ToString

                Catch ex As Exception
                    CL60KSEQd = 1
                    MessageBox.Show(ex.Message)
                Finally
                    OdbcConnection.Close()
                End Try

            End Using
        Catch ex As Exception

        End Try
        Return CL60KSEQd
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim CONNBY As String = ConfigurationManager.AppSettings("connectionby")
        If CONNBY = "USB" Then
            If getprintbyUSBR() = True Then


            End If
        End If
        'If CONNBY = "TCP" Then
        '    If getprintbyTCP() = True Then


        '    End If
        'End If
        'Try
        '    If ComboBox2.Items.Count = 0 Then
        '        MessageBox.Show("Machine Details not available".ToUpper)
        '        Return
        '    End If
        'Catch ex As Exception

        'End Try
        'If ComboBox2.SelectedIndex = "0" Then
        '    MessageBox.Show("Select Machine Details")
        '    Return
        'End If

        'calibration

        'machine list

        'enabled
        EnableControl(True)
        ' Button2.Enabled = False
        Button3.Enabled = True
    End Sub
End Class
