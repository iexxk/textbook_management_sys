<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class msg_in
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DB_book_manageDataSet3 = New 教材管理系统.DB_book_manageDataSet3()
        Me.BOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKTableAdapter = New 教材管理系统.DB_book_manageDataSet3TableAdapters.BOOKTableAdapter()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.书名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.作者DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.出版社DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.价格DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.复本量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.库存量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_book_manageDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.书名DataGridViewTextBoxColumn, Me.作者DataGridViewTextBoxColumn, Me.出版社DataGridViewTextBoxColumn, Me.价格DataGridViewTextBoxColumn, Me.复本量DataGridViewTextBoxColumn, Me.库存量DataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BOOKBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(792, 382)
        Me.DataGridView1.TabIndex = 8
        '
        'DB_book_manageDataSet3
        '
        Me.DB_book_manageDataSet3.DataSetName = "DB_book_manageDataSet3"
        Me.DB_book_manageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKBindingSource
        '
        Me.BOOKBindingSource.DataMember = "BOOK"
        Me.BOOKBindingSource.DataSource = Me.DB_book_manageDataSet3
        '
        'BOOKTableAdapter
        '
        Me.BOOKTableAdapter.ClearBeforeFill = True
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        '
        '书名DataGridViewTextBoxColumn
        '
        Me.书名DataGridViewTextBoxColumn.DataPropertyName = "书名"
        Me.书名DataGridViewTextBoxColumn.HeaderText = "书名"
        Me.书名DataGridViewTextBoxColumn.Name = "书名DataGridViewTextBoxColumn"
        Me.书名DataGridViewTextBoxColumn.ReadOnly = True
        '
        '作者DataGridViewTextBoxColumn
        '
        Me.作者DataGridViewTextBoxColumn.DataPropertyName = "作者"
        Me.作者DataGridViewTextBoxColumn.HeaderText = "作者"
        Me.作者DataGridViewTextBoxColumn.Name = "作者DataGridViewTextBoxColumn"
        Me.作者DataGridViewTextBoxColumn.ReadOnly = True
        '
        '出版社DataGridViewTextBoxColumn
        '
        Me.出版社DataGridViewTextBoxColumn.DataPropertyName = "出版社"
        Me.出版社DataGridViewTextBoxColumn.HeaderText = "出版社"
        Me.出版社DataGridViewTextBoxColumn.Name = "出版社DataGridViewTextBoxColumn"
        Me.出版社DataGridViewTextBoxColumn.ReadOnly = True
        '
        '价格DataGridViewTextBoxColumn
        '
        Me.价格DataGridViewTextBoxColumn.DataPropertyName = "价格"
        Me.价格DataGridViewTextBoxColumn.HeaderText = "价格"
        Me.价格DataGridViewTextBoxColumn.Name = "价格DataGridViewTextBoxColumn"
        Me.价格DataGridViewTextBoxColumn.ReadOnly = True
        '
        '复本量DataGridViewTextBoxColumn
        '
        Me.复本量DataGridViewTextBoxColumn.DataPropertyName = "复本量"
        Me.复本量DataGridViewTextBoxColumn.HeaderText = "复本量"
        Me.复本量DataGridViewTextBoxColumn.Name = "复本量DataGridViewTextBoxColumn"
        Me.复本量DataGridViewTextBoxColumn.ReadOnly = True
        '
        '库存量DataGridViewTextBoxColumn
        '
        Me.库存量DataGridViewTextBoxColumn.DataPropertyName = "库存量"
        Me.库存量DataGridViewTextBoxColumn.HeaderText = "库存量"
        Me.库存量DataGridViewTextBoxColumn.Name = "库存量DataGridViewTextBoxColumn"
        Me.库存量DataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(351, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "添加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(729, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "刷新"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'msg_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "msg_in"
        Me.Text = "msg_in"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_book_manageDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_book_manageDataSet3 As DB_book_manageDataSet3
    Friend WithEvents BOOKBindingSource As BindingSource
    Friend WithEvents BOOKTableAdapter As DB_book_manageDataSet3TableAdapters.BOOKTableAdapter
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 书名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 作者DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 出版社DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 价格DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 复本量DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 库存量DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
