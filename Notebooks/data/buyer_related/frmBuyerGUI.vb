<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuyer
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuyer))
		Me.lblBuyer = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.lblUID = New System.Windows.Forms.Label()
		Me.txtBuyerName = New System.Windows.Forms.TextBox()
		Me.lblBuyerName = New System.Windows.Forms.Label()
		Me.lblMobilePhone = New System.Windows.Forms.Label()
		Me.txtBuyerId = New System.Windows.Forms.TextBox()
		Me.txtMobilePhone = New System.Windows.Forms.TextBox()
		Me.txtAddress1 = New System.Windows.Forms.TextBox()
		Me.txtPhone1 = New System.Windows.Forms.TextBox()
		Me.lblAddress1 = New System.Windows.Forms.Label()
		Me.lblPhone1 = New System.Windows.Forms.Label()
		Me.txtAddress3 = New System.Windows.Forms.TextBox()
		Me.lblPhone2 = New System.Windows.Forms.Label()
		Me.lblAddress3 = New System.Windows.Forms.Label()
		Me.txtPhone2 = New System.Windows.Forms.TextBox()
		Me.lblAddress2 = New System.Windows.Forms.Label()
		Me.lblAddress4 = New System.Windows.Forms.Label()
		Me.txtAddress2 = New System.Windows.Forms.TextBox()
		Me.txtAddress4 = New System.Windows.Forms.TextBox()
		Me.Toolbox = New System.Windows.Forms.GroupBox()
		Me.cmdAddNew = New System.Windows.Forms.Button()
		Me.cmdDelete = New System.Windows.Forms.Button()
		Me.cmdCancel = New System.Windows.Forms.Button()
		Me.cmdEdit = New System.Windows.Forms.Button()
		Me.cmdSave = New System.Windows.Forms.Button()
		Me.gbDetail_1 = New System.Windows.Forms.GroupBox()
		Me.cmdClose = New System.Windows.Forms.Button()
		Me.cmdClient = New System.Windows.Forms.Button()
		Me.chkGrid = New System.Windows.Forms.CheckBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtGoToid = New System.Windows.Forms.TextBox()
		Me.cmdMoveLast = New System.Windows.Forms.Button()
		Me.cmdMoveNext = New System.Windows.Forms.Button()
		Me.cmdMovePrevious = New System.Windows.Forms.Button()
		Me.cmdMoveFirst = New System.Windows.Forms.Button()
		Me.cmdGoToId = New System.Windows.Forms.Button()
		Me.lblRecordStatus = New System.Windows.Forms.Label()
		Me.Toolbox.SuspendLayout()
		Me.gbDetail_1.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblBuyer
		'
		Me.lblBuyer.AutoSize = True
		Me.lblBuyer.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBuyer.Location = New System.Drawing.Point(44, 21)
		Me.lblBuyer.Name = "lblBuyer"
		Me.lblBuyer.Size = New System.Drawing.Size(66, 22)
		Me.lblBuyer.TabIndex = 0
		Me.lblBuyer.Text = "Buyer"
		'
		'Button1
		'
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(591, 19)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(27, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "X"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(0, 44)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(625, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = resources.GetString("Label2.Text")
		'
		'Button2
		'
		Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(559, 19)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(25, 23)
		Me.Button2.TabIndex = 3
		Me.Button2.UseVisualStyleBackColor = True
		'
		'lblUID
		'
		Me.lblUID.AutoSize = True
		Me.lblUID.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblUID.Location = New System.Drawing.Point(44, 82)
		Me.lblUID.Name = "lblUID"
		Me.lblUID.Size = New System.Drawing.Size(28, 16)
		Me.lblUID.TabIndex = 18
		Me.lblUID.Text = "UID"
		'
		'txtBuyerName
		'
		Me.txtBuyerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtBuyerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBuyerName.Location = New System.Drawing.Point(156, 108)
		Me.txtBuyerName.MaxLength = 50
		Me.txtBuyerName.Multiline = True
		Me.txtBuyerName.Name = "txtBuyerName"
		Me.txtBuyerName.Size = New System.Drawing.Size(465, 23)
		Me.txtBuyerName.TabIndex = 21
		'
		'lblBuyerName
		'
		Me.lblBuyerName.AutoSize = True
		Me.lblBuyerName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBuyerName.Location = New System.Drawing.Point(44, 111)
		Me.lblBuyerName.Name = "lblBuyerName"
		Me.lblBuyerName.Size = New System.Drawing.Size(88, 16)
		Me.lblBuyerName.TabIndex = 20
		Me.lblBuyerName.Text = "Buyer Name *"
		'
		'lblMobilePhone
		'
		Me.lblMobilePhone.AutoSize = True
		Me.lblMobilePhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMobilePhone.Location = New System.Drawing.Point(473, 267)
		Me.lblMobilePhone.Name = "lblMobilePhone"
		Me.lblMobilePhone.Size = New System.Drawing.Size(54, 16)
		Me.lblMobilePhone.TabIndex = 34
		Me.lblMobilePhone.Text = "Mobile *"
		'
		'txtBuyerId
		'
		Me.txtBuyerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtBuyerId.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBuyerId.Location = New System.Drawing.Point(156, 77)
		Me.txtBuyerId.Multiline = True
		Me.txtBuyerId.Name = "txtBuyerId"
		Me.txtBuyerId.Size = New System.Drawing.Size(465, 23)
		Me.txtBuyerId.TabIndex = 19
		'
		'txtMobilePhone
		'
		Me.txtMobilePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtMobilePhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMobilePhone.Location = New System.Drawing.Point(537, 263)
		Me.txtMobilePhone.MaxLength = 50
		Me.txtMobilePhone.Multiline = True
		Me.txtMobilePhone.Name = "txtMobilePhone"
		Me.txtMobilePhone.Size = New System.Drawing.Size(84, 23)
		Me.txtMobilePhone.TabIndex = 35
		'
		'txtAddress1
		'
		Me.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtAddress1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress1.Location = New System.Drawing.Point(156, 139)
		Me.txtAddress1.MaxLength = 50
		Me.txtAddress1.Multiline = True
		Me.txtAddress1.Name = "txtAddress1"
		Me.txtAddress1.Size = New System.Drawing.Size(465, 23)
		Me.txtAddress1.TabIndex = 23
		'
		'txtPhone1
		'
		Me.txtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtPhone1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPhone1.Location = New System.Drawing.Point(156, 263)
		Me.txtPhone1.Multiline = True
		Me.txtPhone1.Name = "txtPhone1"
		Me.txtPhone1.Size = New System.Drawing.Size(84, 23)
		Me.txtPhone1.TabIndex = 31
		'
		'lblAddress1
		'
		Me.lblAddress1.AutoSize = True
		Me.lblAddress1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAddress1.Location = New System.Drawing.Point(44, 142)
		Me.lblAddress1.Name = "lblAddress1"
		Me.lblAddress1.Size = New System.Drawing.Size(66, 16)
		Me.lblAddress1.TabIndex = 22
		Me.lblAddress1.Text = "Address 1"
		'
		'lblPhone1
		'
		Me.lblPhone1.AutoSize = True
		Me.lblPhone1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPhone1.Location = New System.Drawing.Point(44, 268)
		Me.lblPhone1.Name = "lblPhone1"
		Me.lblPhone1.Size = New System.Drawing.Size(60, 16)
		Me.lblPhone1.TabIndex = 30
		Me.lblPhone1.Text = "Phone1 *"
		'
		'txtAddress3
		'
		Me.txtAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtAddress3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress3.Location = New System.Drawing.Point(156, 201)
		Me.txtAddress3.MaxLength = 50
		Me.txtAddress3.Multiline = True
		Me.txtAddress3.Name = "txtAddress3"
		Me.txtAddress3.Size = New System.Drawing.Size(465, 23)
		Me.txtAddress3.TabIndex = 27
		'
		'lblPhone2
		'
		Me.lblPhone2.AutoSize = True
		Me.lblPhone2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPhone2.Location = New System.Drawing.Point(282, 267)
		Me.lblPhone2.Name = "lblPhone2"
		Me.lblPhone2.Size = New System.Drawing.Size(60, 16)
		Me.lblPhone2.TabIndex = 32
		Me.lblPhone2.Text = "Phone2 *"
		'
		'lblAddress3
		'
		Me.lblAddress3.AutoSize = True
		Me.lblAddress3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAddress3.Location = New System.Drawing.Point(44, 204)
		Me.lblAddress3.Name = "lblAddress3"
		Me.lblAddress3.Size = New System.Drawing.Size(66, 16)
		Me.lblAddress3.TabIndex = 26
		Me.lblAddress3.Text = "Address 3"
		'
		'txtPhone2
		'
		Me.txtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtPhone2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPhone2.Location = New System.Drawing.Point(351, 263)
		Me.txtPhone2.MaxLength = 50
		Me.txtPhone2.Multiline = True
		Me.txtPhone2.Name = "txtPhone2"
		Me.txtPhone2.Size = New System.Drawing.Size(84, 23)
		Me.txtPhone2.TabIndex = 33
		'
		'lblAddress2
		'
		Me.lblAddress2.AutoSize = True
		Me.lblAddress2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAddress2.Location = New System.Drawing.Point(44, 174)
		Me.lblAddress2.Name = "lblAddress2"
		Me.lblAddress2.Size = New System.Drawing.Size(66, 16)
		Me.lblAddress2.TabIndex = 24
		Me.lblAddress2.Text = "Address 2"
		'
		'lblAddress4
		'
		Me.lblAddress4.AutoSize = True
		Me.lblAddress4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAddress4.Location = New System.Drawing.Point(44, 235)
		Me.lblAddress4.Name = "lblAddress4"
		Me.lblAddress4.Size = New System.Drawing.Size(66, 16)
		Me.lblAddress4.TabIndex = 28
		Me.lblAddress4.Text = "Address 4"
		'
		'txtAddress2
		'
		Me.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtAddress2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress2.Location = New System.Drawing.Point(156, 170)
		Me.txtAddress2.Multiline = True
		Me.txtAddress2.Name = "txtAddress2"
		Me.txtAddress2.Size = New System.Drawing.Size(465, 23)
		Me.txtAddress2.TabIndex = 25
		'
		'txtAddress4
		'
		Me.txtAddress4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtAddress4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAddress4.Location = New System.Drawing.Point(156, 232)
		Me.txtAddress4.MaxLength = 50
		Me.txtAddress4.Multiline = True
		Me.txtAddress4.Name = "txtAddress4"
		Me.txtAddress4.Size = New System.Drawing.Size(465, 23)
		Me.txtAddress4.TabIndex = 29
		'
		'Toolbox
		'
		Me.Toolbox.Controls.Add(Me.cmdAddNew)
		Me.Toolbox.Controls.Add(Me.cmdDelete)
		Me.Toolbox.Controls.Add(Me.cmdCancel)
		Me.Toolbox.Controls.Add(Me.cmdEdit)
		Me.Toolbox.Controls.Add(Me.cmdSave)
		Me.Toolbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Toolbox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Toolbox.Location = New System.Drawing.Point(47, 338)
		Me.Toolbox.Name = "Toolbox"
		Me.Toolbox.Size = New System.Drawing.Size(574, 50)
		Me.Toolbox.TabIndex = 36
		Me.Toolbox.TabStop = False
		Me.Toolbox.Text = "Toolbox"
		'
		'cmdAddNew
		'
		Me.cmdAddNew.BackColor = System.Drawing.Color.Transparent
		Me.cmdAddNew.FlatAppearance.BorderSize = 0
		Me.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdAddNew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdAddNew.Location = New System.Drawing.Point(18, 17)
		Me.cmdAddNew.Name = "cmdAddNew"
		Me.cmdAddNew.Size = New System.Drawing.Size(95, 22)
		Me.cmdAddNew.TabIndex = 23
		Me.cmdAddNew.Text = "&AddNew"
		Me.cmdAddNew.UseVisualStyleBackColor = False
		'
		'cmdDelete
		'
		Me.cmdDelete.BackColor = System.Drawing.Color.Transparent
		Me.cmdDelete.FlatAppearance.BorderSize = 0
		Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDelete.Location = New System.Drawing.Point(350, 17)
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdDelete.Size = New System.Drawing.Size(95, 22)
		Me.cmdDelete.TabIndex = 26
		Me.cmdDelete.Text = "&Delete"
		Me.cmdDelete.UseVisualStyleBackColor = False
		'
		'cmdCancel
		'
		Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
		Me.cmdCancel.FlatAppearance.BorderSize = 0
		Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.Location = New System.Drawing.Point(461, 17)
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdCancel.Size = New System.Drawing.Size(95, 22)
		Me.cmdCancel.TabIndex = 27
		Me.cmdCancel.Text = "&Cancel"
		Me.cmdCancel.UseVisualStyleBackColor = False
		'
		'cmdEdit
		'
		Me.cmdEdit.BackColor = System.Drawing.Color.Transparent
		Me.cmdEdit.FlatAppearance.BorderSize = 0
		Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdEdit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdEdit.Location = New System.Drawing.Point(129, 17)
		Me.cmdEdit.Name = "cmdEdit"
		Me.cmdEdit.Size = New System.Drawing.Size(95, 22)
		Me.cmdEdit.TabIndex = 24
		Me.cmdEdit.Text = "&Edit"
		Me.cmdEdit.UseVisualStyleBackColor = False
		'
		'cmdSave
		'
		Me.cmdSave.BackColor = System.Drawing.Color.Transparent
		Me.cmdSave.FlatAppearance.BorderSize = 0
		Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.Location = New System.Drawing.Point(239, 17)
		Me.cmdSave.Name = "cmdSave"
		Me.cmdSave.Size = New System.Drawing.Size(95, 22)
		Me.cmdSave.TabIndex = 25
		Me.cmdSave.Text = "&Save"
		Me.cmdSave.UseVisualStyleBackColor = False
		'
		'gbDetail_1
		'
		Me.gbDetail_1.Controls.Add(Me.cmdClose)
		Me.gbDetail_1.Controls.Add(Me.cmdClient)
		Me.gbDetail_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbDetail_1.Location = New System.Drawing.Point(397, 401)
		Me.gbDetail_1.Name = "gbDetail_1"
		Me.gbDetail_1.Size = New System.Drawing.Size(224, 50)
		Me.gbDetail_1.TabIndex = 37
		Me.gbDetail_1.TabStop = False
		Me.gbDetail_1.Text = "Detail"
		'
		'cmdClose
		'
		Me.cmdClose.FlatAppearance.BorderSize = 0
		Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.Location = New System.Drawing.Point(120, 17)
		Me.cmdClose.Name = "cmdClose"
		Me.cmdClose.Size = New System.Drawing.Size(95, 22)
		Me.cmdClose.TabIndex = 38
		Me.cmdClose.Text = "C&lose"
		Me.cmdClose.UseVisualStyleBackColor = True
		'
		'cmdClient
		'
		Me.cmdClient.FlatAppearance.BorderSize = 0
		Me.cmdClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdClient.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClient.Location = New System.Drawing.Point(11, 17)
		Me.cmdClient.Name = "cmdClient"
		Me.cmdClient.Size = New System.Drawing.Size(95, 22)
		Me.cmdClient.TabIndex = 33
		Me.cmdClient.Text = "Clien&t"
		Me.cmdClient.UseVisualStyleBackColor = True
		'
		'chkGrid
		'
		Me.chkGrid.AutoSize = True
		Me.chkGrid.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkGrid.Location = New System.Drawing.Point(44, 423)
		Me.chkGrid.Name = "chkGrid"
		Me.chkGrid.Size = New System.Drawing.Size(46, 18)
		Me.chkGrid.TabIndex = 38
		Me.chkGrid.Text = "Grid"
		Me.chkGrid.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(505, 310)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(35, 14)
		Me.Label5.TabIndex = 39
		Me.Label5.Text = "Go To"
		'
		'txtGoToid
		'
		Me.txtGoToid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtGoToid.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtGoToid.Location = New System.Drawing.Point(546, 306)
		Me.txtGoToid.Name = "txtGoToid"
		Me.txtGoToid.Size = New System.Drawing.Size(40, 20)
		Me.txtGoToid.TabIndex = 40
		'
		'cmdMoveLast
		'
		Me.cmdMoveLast.BackColor = System.Drawing.Color.Transparent
		Me.cmdMoveLast.FlatAppearance.BorderSize = 0
		Me.cmdMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdMoveLast.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMoveLast.Location = New System.Drawing.Point(468, 306)
		Me.cmdMoveLast.Name = "cmdMoveLast"
		Me.cmdMoveLast.Size = New System.Drawing.Size(23, 20)
		Me.cmdMoveLast.TabIndex = 51
		Me.cmdMoveLast.Text = ">|"
		Me.cmdMoveLast.UseVisualStyleBackColor = False
		'
		'cmdMoveNext
		'
		Me.cmdMoveNext.BackColor = System.Drawing.Color.Transparent
		Me.cmdMoveNext.FlatAppearance.BorderSize = 0
		Me.cmdMoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdMoveNext.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMoveNext.Location = New System.Drawing.Point(440, 306)
		Me.cmdMoveNext.Name = "cmdMoveNext"
		Me.cmdMoveNext.Size = New System.Drawing.Size(23, 20)
		Me.cmdMoveNext.TabIndex = 50
		Me.cmdMoveNext.Text = ">"
		Me.cmdMoveNext.UseVisualStyleBackColor = False
		'
		'cmdMovePrevious
		'
		Me.cmdMovePrevious.BackColor = System.Drawing.Color.Transparent
		Me.cmdMovePrevious.FlatAppearance.BorderSize = 0
		Me.cmdMovePrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdMovePrevious.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMovePrevious.Location = New System.Drawing.Point(324, 306)
		Me.cmdMovePrevious.Name = "cmdMovePrevious"
		Me.cmdMovePrevious.Size = New System.Drawing.Size(23, 20)
		Me.cmdMovePrevious.TabIndex = 49
		Me.cmdMovePrevious.Text = "<"
		Me.cmdMovePrevious.UseVisualStyleBackColor = False
		'
		'cmdMoveFirst
		'
		Me.cmdMoveFirst.BackColor = System.Drawing.Color.Transparent
		Me.cmdMoveFirst.FlatAppearance.BorderSize = 0
		Me.cmdMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdMoveFirst.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdMoveFirst.Location = New System.Drawing.Point(294, 306)
		Me.cmdMoveFirst.Name = "cmdMoveFirst"
		Me.cmdMoveFirst.Size = New System.Drawing.Size(23, 20)
		Me.cmdMoveFirst.TabIndex = 48
		Me.cmdMoveFirst.Text = "|<"
		Me.cmdMoveFirst.UseVisualStyleBackColor = False
		'
		'cmdGoToId
		'
		Me.cmdGoToId.BackColor = System.Drawing.Color.Transparent
		Me.cmdGoToId.FlatAppearance.BorderSize = 0
		Me.cmdGoToId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cmdGoToId.Location = New System.Drawing.Point(592, 306)
		Me.cmdGoToId.Name = "cmdGoToId"
		Me.cmdGoToId.Size = New System.Drawing.Size(30, 20)
		Me.cmdGoToId.TabIndex = 52
		Me.cmdGoToId.Text = "..."
		Me.cmdGoToId.UseVisualStyleBackColor = False
		'
		'lblRecordStatus
		'
		Me.lblRecordStatus.BackColor = System.Drawing.Color.White
		Me.lblRecordStatus.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRecordStatus.ForeColor = System.Drawing.Color.Black
		Me.lblRecordStatus.Location = New System.Drawing.Point(354, 308)
		Me.lblRecordStatus.Name = "lblRecordStatus"
		Me.lblRecordStatus.Size = New System.Drawing.Size(80, 18)
		Me.lblRecordStatus.TabIndex = 53
		'
		'frmBuyer
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(669, 481)
		Me.Controls.Add(Me.lblRecordStatus)
		Me.Controls.Add(Me.cmdGoToId)
		Me.Controls.Add(Me.cmdMoveLast)
		Me.Controls.Add(Me.cmdMoveNext)
		Me.Controls.Add(Me.cmdMovePrevious)
		Me.Controls.Add(Me.cmdMoveFirst)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtGoToid)
		Me.Controls.Add(Me.chkGrid)
		Me.Controls.Add(Me.gbDetail_1)
		Me.Controls.Add(Me.Toolbox)
		Me.Controls.Add(Me.lblUID)
		Me.Controls.Add(Me.txtBuyerName)
		Me.Controls.Add(Me.lblBuyerName)
		Me.Controls.Add(Me.lblMobilePhone)
		Me.Controls.Add(Me.txtBuyerId)
		Me.Controls.Add(Me.txtMobilePhone)
		Me.Controls.Add(Me.txtAddress1)
		Me.Controls.Add(Me.txtPhone1)
		Me.Controls.Add(Me.lblAddress1)
		Me.Controls.Add(Me.lblPhone1)
		Me.Controls.Add(Me.txtAddress3)
		Me.Controls.Add(Me.lblPhone2)
		Me.Controls.Add(Me.lblAddress3)
		Me.Controls.Add(Me.txtPhone2)
		Me.Controls.Add(Me.lblAddress2)
		Me.Controls.Add(Me.lblAddress4)
		Me.Controls.Add(Me.txtAddress2)
		Me.Controls.Add(Me.txtAddress4)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.lblBuyer)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "frmBuyer"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmBuyer"
		Me.Toolbox.ResumeLayout(False)
		Me.gbDetail_1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents lblBuyer As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lblUID As Label
    Friend WithEvents txtBuyerName As TextBox
    Friend WithEvents lblBuyerName As Label
    Friend WithEvents lblMobilePhone As Label
    Friend WithEvents txtBuyerId As TextBox
    Friend WithEvents txtMobilePhone As TextBox
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtPhone1 As TextBox
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents lblPhone1 As Label
    Friend WithEvents txtAddress3 As TextBox
    Friend WithEvents lblPhone2 As Label
    Friend WithEvents lblAddress3 As Label
    Friend WithEvents txtPhone2 As TextBox
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents lblAddress4 As Label
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtAddress4 As TextBox
    Friend WithEvents Toolbox As GroupBox
    Friend WithEvents cmdAddNew As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents gbDetail_1 As GroupBox
    Friend WithEvents cmdClient As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents chkGrid As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGoToid As TextBox
    Friend WithEvents cmdMoveLast As Button
    Friend WithEvents cmdMoveNext As Button
    Friend WithEvents cmdMovePrevious As Button
    Friend WithEvents cmdMoveFirst As Button
    Friend WithEvents cmdGoToId As Button
    Friend WithEvents lblRecordStatus As Label
End Class
