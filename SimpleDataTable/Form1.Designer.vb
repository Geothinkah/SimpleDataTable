<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MyApplicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyApplicationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyApplicationBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FrmMainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrmMainBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnFakeInfo = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyApplicationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyApplicationBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmMainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrmMainBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyApplicationBindingSource
        '
        Me.MyApplicationBindingSource.DataSource = GetType(SimpleDataTable.My.MyApplication)
        '
        'MyApplicationBindingSource1
        '
        Me.MyApplicationBindingSource1.DataSource = GetType(SimpleDataTable.My.MyApplication)
        '
        'MyApplicationBindingSource2
        '
        Me.MyApplicationBindingSource2.DataSource = GetType(SimpleDataTable.My.MyApplication)
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(65, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(654, 282)
        Me.DataGridView1.TabIndex = 0
        '
        'FrmMainBindingSource
        '
        Me.FrmMainBindingSource.DataSource = GetType(SimpleDataTable.FrmMain)
        '
        'FrmMainBindingSource1
        '
        Me.FrmMainBindingSource1.DataSource = GetType(SimpleDataTable.FrmMain)
        '
        'BtnFakeInfo
        '
        Me.BtnFakeInfo.Location = New System.Drawing.Point(75, 37)
        Me.BtnFakeInfo.Name = "BtnFakeInfo"
        Me.BtnFakeInfo.Size = New System.Drawing.Size(75, 23)
        Me.BtnFakeInfo.TabIndex = 1
        Me.BtnFakeInfo.Text = "Fake Info"
        Me.BtnFakeInfo.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(243, 37)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnFakeInfo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Data Table"
        CType(Me.MyApplicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyApplicationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyApplicationBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmMainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrmMainBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FrmMainBindingSource As BindingSource
    Friend WithEvents MyApplicationBindingSource As BindingSource
    Friend WithEvents MyApplicationBindingSource1 As BindingSource
    Friend WithEvents FrmMainBindingSource1 As BindingSource
    Friend WithEvents MyApplicationBindingSource2 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnFakeInfo As Button
    Friend WithEvents BtnAdd As Button
End Class
