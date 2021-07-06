<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form26
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NIMLabel As System.Windows.Forms.Label
        Dim NAMALabel As System.Windows.Forms.Label
        Dim ALAMATLabel As System.Windows.Forms.Label
        Dim TELPLabel As System.Windows.Forms.Label
        Dim KELAMINLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form26))
        Me.MhsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MhsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NIMTextBox = New System.Windows.Forms.TextBox()
        Me.NAMATextBox = New System.Windows.Forms.TextBox()
        Me.ALAMATTextBox = New System.Windows.Forms.TextBox()
        Me.TELPTextBox = New System.Windows.Forms.TextBox()
        Me.KELAMINTextBox = New System.Windows.Forms.TextBox()
        Me.MhsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MhsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database11DataSet = New resqy.Database11DataSet()
        Me.MhsTableAdapter = New resqy.Database11DataSetTableAdapters.mhsTableAdapter()
        Me.TableAdapterManager = New resqy.Database11DataSetTableAdapters.TableAdapterManager()
        Me.DataSet1 = New resqy.DataSet1()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New resqy.DataSet1TableAdapters.TableTableAdapter()
        Me.TableAdapterManager1 = New resqy.DataSet1TableAdapters.TableAdapterManager()
        NIMLabel = New System.Windows.Forms.Label()
        NAMALabel = New System.Windows.Forms.Label()
        ALAMATLabel = New System.Windows.Forms.Label()
        TELPLabel = New System.Windows.Forms.Label()
        KELAMINLabel = New System.Windows.Forms.Label()
        CType(Me.MhsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MhsBindingNavigator.SuspendLayout()
        CType(Me.MhsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MhsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NIMLabel
        '
        NIMLabel.AutoSize = True
        NIMLabel.Location = New System.Drawing.Point(73, 70)
        NIMLabel.Name = "NIMLabel"
        NIMLabel.Size = New System.Drawing.Size(30, 13)
        NIMLabel.TabIndex = 1
        NIMLabel.Text = "NIM:"
        '
        'NAMALabel
        '
        NAMALabel.AutoSize = True
        NAMALabel.Location = New System.Drawing.Point(62, 94)
        NAMALabel.Name = "NAMALabel"
        NAMALabel.Size = New System.Drawing.Size(41, 13)
        NAMALabel.TabIndex = 3
        NAMALabel.Text = "NAMA:"
        '
        'ALAMATLabel
        '
        ALAMATLabel.AutoSize = True
        ALAMATLabel.Location = New System.Drawing.Point(48, 120)
        ALAMATLabel.Name = "ALAMATLabel"
        ALAMATLabel.Size = New System.Drawing.Size(53, 13)
        ALAMATLabel.TabIndex = 5
        ALAMATLabel.Text = "ALAMAT:"
        '
        'TELPLabel
        '
        TELPLabel.AutoSize = True
        TELPLabel.Location = New System.Drawing.Point(64, 146)
        TELPLabel.Name = "TELPLabel"
        TELPLabel.Size = New System.Drawing.Size(37, 13)
        TELPLabel.TabIndex = 7
        TELPLabel.Text = "TELP:"
        '
        'KELAMINLabel
        '
        KELAMINLabel.AutoSize = True
        KELAMINLabel.Location = New System.Drawing.Point(44, 172)
        KELAMINLabel.Name = "KELAMINLabel"
        KELAMINLabel.Size = New System.Drawing.Size(57, 13)
        KELAMINLabel.TabIndex = 9
        KELAMINLabel.Text = "KELAMIN:"
        '
        'MhsBindingNavigator
        '
        Me.MhsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MhsBindingNavigator.BindingSource = Me.MhsBindingSource
        Me.MhsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MhsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MhsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MhsBindingNavigatorSaveItem})
        Me.MhsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MhsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MhsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MhsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MhsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MhsBindingNavigator.Name = "MhsBindingNavigator"
        Me.MhsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MhsBindingNavigator.Size = New System.Drawing.Size(629, 25)
        Me.MhsBindingNavigator.TabIndex = 0
        Me.MhsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MhsBindingNavigatorSaveItem
        '
        Me.MhsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MhsBindingNavigatorSaveItem.Image = CType(resources.GetObject("MhsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MhsBindingNavigatorSaveItem.Name = "MhsBindingNavigatorSaveItem"
        Me.MhsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MhsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NIMTextBox
        '
        Me.NIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MhsBindingSource, "NIM", True))
        Me.NIMTextBox.Location = New System.Drawing.Point(109, 67)
        Me.NIMTextBox.Name = "NIMTextBox"
        Me.NIMTextBox.Size = New System.Drawing.Size(79, 20)
        Me.NIMTextBox.TabIndex = 2
        '
        'NAMATextBox
        '
        Me.NAMATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MhsBindingSource, "NAMA", True))
        Me.NAMATextBox.Location = New System.Drawing.Point(109, 91)
        Me.NAMATextBox.Name = "NAMATextBox"
        Me.NAMATextBox.Size = New System.Drawing.Size(137, 20)
        Me.NAMATextBox.TabIndex = 4
        '
        'ALAMATTextBox
        '
        Me.ALAMATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MhsBindingSource, "ALAMAT", True))
        Me.ALAMATTextBox.Location = New System.Drawing.Point(107, 117)
        Me.ALAMATTextBox.Name = "ALAMATTextBox"
        Me.ALAMATTextBox.Size = New System.Drawing.Size(254, 20)
        Me.ALAMATTextBox.TabIndex = 6
        '
        'TELPTextBox
        '
        Me.TELPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MhsBindingSource, "TELP", True))
        Me.TELPTextBox.Location = New System.Drawing.Point(107, 143)
        Me.TELPTextBox.Name = "TELPTextBox"
        Me.TELPTextBox.Size = New System.Drawing.Size(139, 20)
        Me.TELPTextBox.TabIndex = 8
        '
        'KELAMINTextBox
        '
        Me.KELAMINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MhsBindingSource, "KELAMIN", True))
        Me.KELAMINTextBox.Location = New System.Drawing.Point(107, 169)
        Me.KELAMINTextBox.Name = "KELAMINTextBox"
        Me.KELAMINTextBox.Size = New System.Drawing.Size(139, 20)
        Me.KELAMINTextBox.TabIndex = 10
        '
        'MhsDataGridView
        '
        Me.MhsDataGridView.AutoGenerateColumns = False
        Me.MhsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MhsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.MhsDataGridView.DataSource = Me.MhsBindingSource
        Me.MhsDataGridView.Location = New System.Drawing.Point(51, 207)
        Me.MhsDataGridView.Name = "MhsDataGridView"
        Me.MhsDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.MhsDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NIM"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NIM"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAMA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMA"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ALAMAT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ALAMAT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TELP"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TELP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "KELAMIN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "KELAMIN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'MhsBindingSource
        '
        Me.MhsBindingSource.DataMember = "mhs"
        Me.MhsBindingSource.DataSource = Me.Database11DataSet
        '
        'Database11DataSet
        '
        Me.Database11DataSet.DataSetName = "Database11DataSet"
        Me.Database11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MhsTableAdapter
        '
        Me.MhsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mhsTableAdapter = Me.MhsTableAdapter
        Me.TableAdapterManager.UpdateOrder = resqy.Database11DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.DataSet1
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.TableTableAdapter = Me.TableTableAdapter
        Me.TableAdapterManager1.UpdateOrder = resqy.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form26
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 439)
        Me.Controls.Add(Me.MhsDataGridView)
        Me.Controls.Add(KELAMINLabel)
        Me.Controls.Add(Me.KELAMINTextBox)
        Me.Controls.Add(TELPLabel)
        Me.Controls.Add(Me.TELPTextBox)
        Me.Controls.Add(ALAMATLabel)
        Me.Controls.Add(Me.ALAMATTextBox)
        Me.Controls.Add(NAMALabel)
        Me.Controls.Add(Me.NAMATextBox)
        Me.Controls.Add(NIMLabel)
        Me.Controls.Add(Me.NIMTextBox)
        Me.Controls.Add(Me.MhsBindingNavigator)
        Me.Name = "Form26"
        Me.Text = "Form26"
        CType(Me.MhsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MhsBindingNavigator.ResumeLayout(False)
        Me.MhsBindingNavigator.PerformLayout()
        CType(Me.MhsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MhsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database11DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database11DataSet As Database11DataSet
    Friend WithEvents MhsBindingSource As BindingSource
    Friend WithEvents MhsTableAdapter As Database11DataSetTableAdapters.mhsTableAdapter
    Friend WithEvents TableAdapterManager As Database11DataSetTableAdapters.TableAdapterManager
    Friend WithEvents MhsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MhsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NIMTextBox As TextBox
    Friend WithEvents NAMATextBox As TextBox
    Friend WithEvents ALAMATTextBox As TextBox
    Friend WithEvents TELPTextBox As TextBox
    Friend WithEvents KELAMINTextBox As TextBox
    Friend WithEvents MhsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As DataSet1TableAdapters.TableTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSet1TableAdapters.TableAdapterManager
End Class
