<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class msg_search
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.书名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.作者DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.出版社DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.价格DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.复本量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.库存量DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BOOKBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_book_manageDataSet2 = New 教材管理系统.DB_book_manageDataSet2()
        Me.BOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_book_manageDataSet1 = New 教材管理系统.DB_book_manageDataSet1()
        Me.TbstorageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_book_manageDataSet = New 教材管理系统.DB_book_manageDataSet()
        Me.Tb_storageTableAdapter = New 教材管理系统.DB_book_manageDataSetTableAdapters.tb_storageTableAdapter()
        Me.BOOKTableAdapter = New 教材管理系统.DB_book_manageDataSet1TableAdapters.BOOKTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BOOKTableAdapter1 = New 教材管理系统.DB_book_manageDataSet2TableAdapters.BOOKTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_book_manageDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_book_manageDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbstorageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_book_manageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "书名："
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "查询"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "关键字："
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(523, 54)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 21)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "作者："
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(71, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 21)
        Me.TextBox3.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.书名DataGridViewTextBoxColumn, Me.作者DataGridViewTextBoxColumn, Me.出版社DataGridViewTextBoxColumn, Me.价格DataGridViewTextBoxColumn, Me.复本量DataGridViewTextBoxColumn, Me.库存量DataGridViewTextBoxColumn, Me.id, Me.Column1})
        Me.DataGridView1.DataSource = Me.BOOKBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(14, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(785, 382)
        Me.DataGridView1.TabIndex = 7
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
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "操作"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "修改"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 40
        '
        'BOOKBindingSource1
        '
        Me.BOOKBindingSource1.DataMember = "BOOK"
        Me.BOOKBindingSource1.DataSource = Me.DB_book_manageDataSet2
        '
        'DB_book_manageDataSet2
        '
        Me.DB_book_manageDataSet2.DataSetName = "DB_book_manageDataSet2"
        Me.DB_book_manageDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKBindingSource
        '
        Me.BOOKBindingSource.DataMember = "BOOK"
        Me.BOOKBindingSource.DataSource = Me.DB_book_manageDataSet1
        '
        'DB_book_manageDataSet1
        '
        Me.DB_book_manageDataSet1.DataSetName = "DB_book_manageDataSet1"
        Me.DB_book_manageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbstorageBindingSource
        '
        Me.TbstorageBindingSource.DataMember = "tb_storage"
        Me.TbstorageBindingSource.DataSource = Me.DB_book_manageDataSet
        '
        'DB_book_manageDataSet
        '
        Me.DB_book_manageDataSet.DataSetName = "DB_book_manageDataSet"
        Me.DB_book_manageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_storageTableAdapter
        '
        Me.Tb_storageTableAdapter.ClearBeforeFill = True
        '
        'BOOKTableAdapter
        '
        Me.BOOKTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(650, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "模糊查询"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BOOKTableAdapter1
        '
        Me.BOOKTableAdapter1.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(724, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "刷新"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'msg_search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 518)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "msg_search"
        Me.Text = "msg_search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_book_manageDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_book_manageDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbstorageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_book_manageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DB_book_manageDataSet As DB_book_manageDataSet
    Friend WithEvents TbstorageBindingSource As BindingSource
    Friend WithEvents Tb_storageTableAdapter As DB_book_manageDataSetTableAdapters.tb_storageTableAdapter
    Friend WithEvents DB_book_manageDataSet1 As DB_book_manageDataSet1
    Friend WithEvents BOOKBindingSource As BindingSource
    Friend WithEvents BOOKTableAdapter As DB_book_manageDataSet1TableAdapters.BOOKTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents DB_book_manageDataSet2 As DB_book_manageDataSet2
    Friend WithEvents BOOKBindingSource1 As BindingSource
    Friend WithEvents BOOKTableAdapter1 As DB_book_manageDataSet2TableAdapters.BOOKTableAdapter
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 书名DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 作者DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 出版社DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 价格DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 复本量DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents 库存量DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Button3 As Button
End Class
