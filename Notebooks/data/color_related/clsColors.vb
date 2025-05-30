Public Class clsColors

#Region "Inherits"
#End Region

#Region "Implements"
	Implements ifaBusinessObject
#End Region

#Region "Important Comments"

'* CodeFactory    Version  : CodeFactory_V_11_R_02.00.11
'* Template Class Version  : 10 
'* Created on              : Monday, 19 May, 2025 at 01:31:26 PM
'************** Code Grouping Convention***********
'*   Inherits                                     *
'*   Implements                                   *
'*   Declares                                     *
'*   Delegates                                    *
'*   Constants                                    *
'*   Enumerics                                    *
'*   Variables                                    *
'*   Class Constructor                            *
'*   Class Destructor                             *
'*   Properties                                   *
'*   Functions                                    *
'*   Procedures                                   *
'*   Events                                       *
'*   Events_Functions                             *
'*   BR_Functions                                 *
'*   SourceCode_ToRemove                          *
'*   SourceCode_ToTest                            *
'**************************************************

'************** Declaration Priority **************
' Acsess Modifier Priority
'      Public  
'      Friend  
'      Protected  
'      Private  

' Declaration Priority
'      Object Constants / Variables  
'      Other  Constants / Variables  

' AccessRights Priority
'      Readonly  
'      Writeonly  
'      ReadAndWrite  
'************** Declaration Priority **************
#End Region

#Region "COM GUIDs"
	' These  GUIDs provide the COM identity for this class 
	' and its COM interfaces. If you change them, existing 
	' clients will no longer be able to access the class.
#End Region

#Region "Declares"
	'/* Declare - Public */
	'/* Declare - Friend */
	'/* Declare - Protected */
	'/* Declare - Private */
#End Region

#Region "Delegates"
	'/* Delegate - Sub */
	'/* Delegate - Function */
#End Region

#Region "Constants"
	'/* Constant - Public */ (There should not be any public constants, create properties instead)
	'/* Constant - Friend */
	'/* Constant - Protected */
	'/* Constant - Private */
	Private Const CmstrTableName As String = "Color"

#End Region

#Region "Enumerics"
	'/* Enumeric - Public */
	'/* Enumeric - Friend */
	'/* Enumeric - Protected */
	'/* Enumeric - Private */
#End Region

#Region "Variables"
#Region "Variables - Property"
	'/* Variable - Property - Public - Object */
	'/* Variable - Property - Friend - Object */
	'/* Variable - Property - Protected - Object */
	'/* Variable - Property - Private - Object */
	Private mobjColor As clsColor'Element Class's object
	Private mobjClassAttribute As clsClassAttribute

	'/* Variable - Property - Public */ (There should not be any public variable, create properties instead)
	'/* Variable - Property - Friend */
	'/* Variable - Property - Protected */
	'/* Variable - Property - Private */
	Private mbolAutoValidate As Boolean

#End Region

#Region "Variables - General"
	'/* Variable - General - Public - Object */
	'/* Variable - General - Friend - Object */
	'/* Variable - General - Protected - Object */
	'/* Variable - General - Private - Object */
	Private mobjSolutionBO As clsSolutionBO'Default Design
	Private mobjCollection_MU As clsCollection_MultiUser

	'/* Variable - General - Public */ (There should not be any public variable, create properties instead)
	'/* Variable - General - Friend */
	'/* Variable - General - Protected */
	'/* Variable - General - Private */
#End Region

	'/* Variable for Composite Keys */
#End Region

#Region "Class Constructor"
	'/* Class Constructor - New */
	' A creatable COM class must have a Public Sub New() 
	' with no parameters, otherwise, the class will not be 
	' registered in the COM registry and cannot be created  
	' via CreateObject.
	Public Sub New (byref InobjSolutionBO as clsSolutionBO)
		MyBase.New()
		Initialize(InobjSolutionBO)
	End Sub
#End Region

#Region "Class Destructor"
	'/* Class Destructor - Finalizes */
	Protected Overrides Sub Finalize()
			Terminate()
		MyBase.Finalize()
	End Sub
#End Region

#Region "Properties"
	'/* Property - Public - Readonly */
	Public ReadOnly Property ClassAttribute() As clsClassAttribute
		Get
			Return mobjClassAttribute
		End Get
	End Property
	Public ReadOnly Property Color() As clsColor
		Get
			Return mobjColor
		End Get
	End Property
	Public ReadOnly Property Element() As ifaBusinessElement Implements ifaBusinessObject_Public.Element
		Get
			Return mobjColor
		End Get
	End Property
	Public ReadOnly Property ErrMessage() As String Implements ifaBusinessObject_Public.ErrMessage
		Get
			Return mobjCollection_MU.Collection_ErrMessage
		End Get
	End Property
	Public ReadOnly Property RS() As ifaRecordset Implements ifaBusinessObject.RS
		Get
			Return mobjCollection_MU
		End Get
	End Property
	Public ReadOnly Property TableName() As String Implements ifaBusinessObject_Public.TableName
		Get
			Return CmstrTableName
		End Get

	End Property
	'/* Property - Public - Writeonly */
	Public WriteOnly Property ClientHandle() As Long Implements ifaBusinessObject_Public.ClientHandle
		Set (ByVal RHS As Long)
			mobjCollection_MU.Collection_ClientHandle = RHS
		End Set
	End Property
	Public WriteOnly Property ClientIpAddress() As String Implements ifaBusinessObject_Public.ClientIpAddress
		Set (ByVal RHS As String)
			mobjCollection_MU.Collection_ClientIpAddress = Trim(RHS)
		End Set
	End Property
	Public WriteOnly Property LockServer() As Object Implements ifaBusinessObject_Public.LockServer
		Set (ByVal RHS As Object)
			mobjCollection_MU.Collection_LockServer = RHS
		End Set

	End Property
	'/* Property - Public - Read & Write */
	Public  Property AutoValidate() As Boolean Implements ifaBusinessObject_Public.AutoValidate
		Get
			Return mbolAutoValidate
		End Get
		Set (ByVal RHS As Boolean)
			mbolAutoValidate = RHS
		End Set
	End Property
	'/* Property - Friend - Readonly */
	'/* Property - Friend - Writeonly */
	'/* Property - Friend - Read & Write */
	'/* Property - Protected - Readonly */
	'/* Property - Protected - Writeonly */
	'/* Property - Protected - Read & Write */
	'/* Property - Private - Readonly */
	Private ReadOnly Property ThisClassName() As String 'Default Design
		Get
			Return System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
		End Get
	End Property
	Private ReadOnly Property DeleteRecordsetSQL() As String
		Get
			Return "Delete From " & CmstrTableName
		End Get
	End Property
	Private ReadOnly Property DeleteSQL() As String
		Get
			Dim strReturnValue As String
			strReturnValue = clsGlobalEnum.CgstrBlank

			strReturnValue = "Delete From " & CmstrTableName & " Where " & mobjColor.PrimaryKeyName & " = " & mobjColor.FieldValue(mobjColor.PrimaryKeyIndex)
			Return strReturnValue
		End Get
	End Property
	Private ReadOnly Property InsertSQL() As String Implements ifaBusinessObject_Private_Multiuser.InsertSQL
		Get
			Dim strReturnValue As String
			Dim OutstrReturnValue As String
			Dim intCntr As Integer

			strReturnValue = clsGlobalEnum.CgstrBlank
			OutstrReturnValue = clsGlobalEnum.CgstrBlank
			strReturnValue = "Insert Into " & TableName &" ("

			For intCntr = 0 To mobjColor.FieldCount - 1
				strReturnValue = strReturnValue & mobjColor.FieldName(intCntr)

				If intCntr <= mobjColor.FieldCount- 2 Then
					strReturnValue = strReturnValue & ","
				ElseIf intCntr <= mobjColor.FieldCount - 1 Then
					strReturnValue = strReturnValue & ")"
				End If
			Next

			strReturnValue = strReturnValue & " Values ("

			For intCntr = 0 To mobjColor.FieldCount - 1
				If mobjSolutionBO.AppBO_Friend.AppBO_Functions.AF_SQLStmt_FormatData(mobjCollection_MU.RS_Connection.ConnectionString.DatabaseType, mobjColor.FieldType(intCntr), intCntr, mobjColor, OutstrReturnValue) = False Then Exit Property
				strReturnValue = strReturnValue & OutstrReturnValue
				
			If intCntr <= mobjColor.FieldCount - 2 Then
				strReturnValue = strReturnValue & ","
			ElseIf intCntr <= mobjColor.FieldCount - 1 Then
				strReturnValue = strReturnValue & ")"
			End If

		Next

		Return strReturnValue
	End Get
	End Property
	Private ReadOnly Property SelectSQL() As String
		Get
			Dim strReturnValue As String
			Dim intCntr As Integer

			strReturnValue = clsGlobalEnum.CgstrBlank
			strReturnValue = "Select "

			For intCntr = 0 To mobjColor.FieldCount - 1
				strReturnValue = strReturnValue & mobjColor.FieldName(intCntr)
				If intCntr < mobjColor.FieldCount- 1 Then
					strReturnValue = strReturnValue & ","
				End If
			Next

			strReturnValue = strReturnValue & " From " & CmstrTableName

			SelectSQL = strReturnValue
		End Get
	End Property
	Private ReadOnly Property UpdateSQL() As String Implements ifaBusinessObject_Private_Multiuser.UpdateSQL
		Get
			Dim strReturnValue As String
			Dim OutstrReturnValue As String
			Dim intCntr As Integer

			strReturnValue = clsGlobalEnum.CgstrBlank
			OutstrReturnValue = clsGlobalEnum.CgstrBlank
			strReturnValue = "Update " & TableName & " Set "
			
			For intCntr = 1 To mobjColor.FieldCount - 1
				If mobjSolutionBO.AppBO_Friend.AppBO_Functions.AF_SQLStmt_FormatData(mobjCollection_MU.RS_Connection.ConnectionString.DatabaseType, mobjColor.FieldType(intCntr), intCntr, mobjColor, OutstrReturnValue) = False Then Exit Property
				strReturnValue = strReturnValue & " " & mobjColor.FieldName(intCntr) & " = " & OutstrReturnValue
				
				If intCntr <= mobjColor.FieldCount - 2 Then
					strReturnValue = strReturnValue & ","
				ElseIf intCntr <= mobjColor.FieldCount - 1 Then
					strReturnValue = strReturnValue & " Where " & " " & mobjColor.PrimaryKeyName & " = " & mobjColor.FieldValue(mobjColor.PrimaryKeyIndex)
				End If
			Next

			Return strReturnValue
			End Get
	End Property
	'/* Property - Private - Writeonly */
	'/* Property - Private - Read & Write */
#End Region

#Region "Functions"
	'/* Function - Public */
	Shadows Function Rs_GridDataFill(ByRef InobjGrid As System.Windows.Forms.DataGridView) As Boolean Implements ifaBusinessObject_Public.Rs_GridDataFill
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Rs_GridDataFill = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjCollection_MU.Rs_GridDataFill(InobjGrid,CmstrTableName)

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Rs_GridDataFill = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	'/* Function - Friend */
	Friend Function Initialize_CO(Optional ByRef InobjClassAttribute As clsClassAttribute = Nothing) As Boolean 'Default Design
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Initialize_CO = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		 mobjClassAttribute = InobjClassAttribute

		If mobjCollection_MU.Initialize_Object() = False Then Goto ExitFunction
		If mobjCollection_MU.RS_Initialize() = False Then Goto ExitFunction
		mobjCollection_MU.RS_Connection = mobjSolutionBO.AppBO.StorageBO.DBRDBMS_DBName.ADOConnection

		mobjCollection_MU.RS_BusinessObject = Me
		mobjCollection_MU.RS_BusinessObject_Multiuser = Me
		mobjCollection_MU.RS_SelectPhrase = SelectSQL
		mobjCollection_MU.RS_BookmarkField = mobjColor.FieldName(clsColor.enumFieldsColor.eColorUid)
		AutoValidate = True

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Initialize_CO = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function Add() As Boolean Implements ifaBusinessObject.Add
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Add = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjCollection_MU.CAdd() = False Then Goto ExitFunction
		RefreshElement(clsGlobalEnum.enumRefreshElement.eBlank)
		Me.Color.ColorUid = clsGlobalEnum.CgintNotDefined
		mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eAdd

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Add = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function Cancel() As Boolean Implements ifaBusinessObject.Cancel
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Cancel = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjCollection_MU.CCancel(Me) = False Then Goto ExitFunction
		mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eNavigation

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Cancel = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function Delete() As Boolean Implements ifaBusinessObject.Delete
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Delete = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjCollection_MU.CDelete(DeleteSQL) = False Then Goto ExitFunction
		If RefreshElement(clsGlobalEnum.enumRefreshElement.eRecordValue) = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Delete = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function DeleteRecordset() As Boolean Implements ifaBusinessObject.DeleteRecordset
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		DeleteRecordset = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjCollection_MU.CDeleteRecordset(DeleteRecordsetSQL) = False Then Goto ExitFunction
		If RefreshElement(clsGlobalEnum.enumRefreshElement.eRecordValue) = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then DeleteRecordset = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function Edit() As Boolean Implements ifaBusinessObject.Edit
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Edit = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjCollection_MU.CEdit() = False Then Goto ExitFunction 
		mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eEdit

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Edit = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function Save() As Boolean Implements ifaBusinessObject.Save
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		Dim strErrMessage As String

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Save = False

		strErrMessage = clsGlobalEnum.CgstrBlank

	'--Parameters
	
	'----/* Functionality  - Start */----
		If AutoValidate = True Then
			If ValidateInputData(clsGlobalEnum.enumValidationScope.eAllFields, strErrMessage) = False Then
				MsgBox (strErrMessage, MsgBoxStyle.Information)
				Goto ExitFunction
			End If
		End If

		If mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eAdd Then
			If mobjCollection_MU.CSave(CmstrTableName) = False Then Goto ExitFunction
			RefreshElement(clsGlobalEnum.enumRefreshElement.eRecordValue)
			mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eNavigation

		ElseIf mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eEdit Then
			If mobjCollection_MU.CSave(CmstrTableName) = False Then Goto ExitFunction
			mobjCollection_MU.RS_EditMode = clsGlobalEnum.enumEditModes.eNavigation

		End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Save = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	'/* Function - Protected */
	'/* Function - Private */
	Private Function Initialize(ByRef InobjSolutionBO As clsSolutionBO) As Boolean'Default Design
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Initialize = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjSolutionBO = InobjSolutionBO

		mobjClassAttribute = New clsClassAttribute
		mobjCollection_MU = New clsCollection_MultiUser(mobjSolutionBO)
		mobjColor = New clsColor(mobjSolutionBO)

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Initialize = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Private Function Terminate() As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Terminate = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjCollection_MU = Nothing
		mobjColor = Nothing

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Terminate = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Private Function GetNewPrimaryKeyVal() As Boolean Implements ifaBusinessObject_Public.GetNewPrimaryKeyVal
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		Dim objRs As clsRecordset
		
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		Dim strSqlstmt As String
		Dim strMaxFieldName As String
		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		GetNewPrimaryKeyVal = False

		objRs = New clsRecordset
		strSqlstmt = clsGlobalEnum.CgstrBlank
		strMaxFieldName = "Max" & mobjColor.PrimaryKeyName
	'--Parameters
	
	'----/* Functionality  - Start */----
		objRs.RS_Initialize()
		objRs.RS_Connection = mobjCollection_MU.RS_Connection

		strSqlstmt = "Select Max(" & mobjColor.PrimaryKeyName & ") As " & strMaxFieldName & " From " & CmstrTableName
		objRs.RS_RecordSource = strSqlstmt
		If objRs.RS_Refresh() = False Then Goto ExitFunction

		If Not (objRs.RS_Bof And objRs.RS_Eof) Then
			If objRs.RS_FieldValue(strMaxFieldName).ToString = clsGlobalEnum.CgstrBlank Then
				mobjCollection_MU.RS_NewPrimaryKey = 1
			Else
				mobjCollection_MU.RS_NewPrimaryKey = objRs.RS_FieldValue(strMaxFieldName) + 1
			End If
		End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		objRs = Nothing
		'----/* Return Execution Status */----
		If ExecutionComplete = True Then GetNewPrimaryKeyVal = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Private Function RefreshElement(ByVal InlngVal As clsGlobalEnum.enumRefreshElement) As Boolean Implements ifaBusinessObject_Private.RefreshElement
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		RefreshElement = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		Select Case InlngVal
			Case clsGlobalEnum.enumRefreshElement.eBlank

				For intCntr = 0 To mobjColor.FieldCount - 1
					mobjColor.FieldValue(intCntr) = clsGlobalEnum.CgstrBlank
				Next

				Case clsGlobalEnum.enumRefreshElement.eRecordValue
					If mobjCollection_MU.RS_Bof Or mobjCollection_MU.RS_Eof Then
						mobjCollection_MU.RS_Bookmark =clsGlobalEnum.CgintNotDefined
						RefreshElement(clsGlobalEnum.enumRefreshElement.eBlank)
					Else
						mobjCollection_MU.RS_Bookmark = mobjCollection_MU.RS_FieldValue(mobjColor.PrimaryKeyName)
						For intCntr = 0 To mobjColor.FieldCount - 1
							mobjColor.FieldValue(intCntr) = mobjCollection_MU.RS_FieldValue(mobjColor.FieldName(intCntr)).ToString
						Next
					End If
				End Select

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then RefreshElement = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Private Function SetDefaultFieldValue() As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		SetDefaultFieldValue = False

	'--Parameters
	
	'----/* Functionality  - Start */----
			mobjColor.ColorUid = clsGlobalEnum.CgstrBlank
			mobjColor.Colorcode = clsGlobalEnum.CgstrBlank
			mobjColor.Colorname = clsGlobalEnum.CgstrBlank

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then SetDefaultFieldValue = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Private Function SetNewPrimaryKey() As Boolean Implements ifaBusinessObject_Private_Multiuser.SetNewPrimaryKey
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		SetNewPrimaryKey = False

	'--Parameters
	
	'----/* Functionality  - Start */----
			If GetNewPrimaryKeyVal() Then
				Me.Color.ColorUid = mobjCollection_MU.RS_NewPrimaryKey
			End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then SetNewPrimaryKey = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Private Function ValidateInputData(ByVal InlngValidationScope As clsGlobalEnum.enumValidationScope, ByRef inoutErrMsg As String, Optional ByRef Inoutlngfield As Object = Nothing, Optional ByVal InvarCurrentVal As Object = Nothing, Optional ByRef InoutIntKeyAscii As Object = Nothing) As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		Dim intErrField As clsColor.enumFieldsColor

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		ValidateInputData = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If InlngValidationScope = clsGlobalEnum.enumValidationScope.eSingleField Then
			If IsNothing(Inoutlngfield) Then
				inoutErrMsg = "Error: Field missing"
				Goto ExitFunction
			ElseIf Inoutlngfield = clsGlobalEnum.CgintNotDefined Then
				inoutErrMsg = "Error: Wrong field index"
				Goto ExitFunction
			End If

		ElseIf InlngValidationScope = clsGlobalEnum.enumValidationScope.eSingleFieldKeyPress Then
			If IsNothing(Inoutlngfield) Then
				inoutErrMsg = "Error: Field missing"
				Goto ExitFunction
			ElseIf IsNothing(InvarCurrentVal) Then
				inoutErrMsg = "Error: current value missing"
				Goto ExitFunction
			End If
		End If
		intErrField = clsGlobalEnum.CgintNotDeclared

		If InlngValidationScope = clsGlobalEnum.enumValidationScope.eAllFields Or CLng(Inoutlngfield) = clsColor.enumFieldsColor.eColorUid Then
			If mobjColor.ColorUid = clsGlobalEnum.CgstrBlank Then
				inoutErrMsg = "Error :  ColorUid cannot be blank"
				intErrField = clsColor.enumFieldsColor.eColorUid
				Goto ExitFunction
			End If
			If Trim(mobjColor.ColorUid) = clsGlobalEnum.CgstrBlank Then
					inoutErrMsg = "Error :  ColorUid Cannot be left blank, Please input 0 (Zero) as default input"
					intErrField = clsColor.enumFieldsColor.eColorUid
					Goto ExitFunction
			ElseIf Trim(mobjColor.ColorUid) <> clsGlobalEnum.CgstrBlank Then
				If IsNumeric(mobjColor.ColorUid) = False Then
					inoutErrMsg = "Error :  ColorUid should be numeric only"
					intErrField = clsColor.enumFieldsColor.eColorUid
					Goto ExitFunction
				End If
			End If
		End If
		If InlngValidationScope = clsGlobalEnum.enumValidationScope.eAllFields Or CLng(Inoutlngfield) = clsColor.enumFieldsColor.eColorcode Then
			If mobjColor.Colorcode = clsGlobalEnum.CgstrBlank Then
				inoutErrMsg = "Error :  Colorcode cannot be blank"
				intErrField = clsColor.enumFieldsColor.eColorcode
				Goto ExitFunction
			End If
		End If
		If InlngValidationScope = clsGlobalEnum.enumValidationScope.eAllFields Or CLng(Inoutlngfield) = clsColor.enumFieldsColor.eColorname Then
			If mobjColor.Colorname = clsGlobalEnum.CgstrBlank Then
				inoutErrMsg = "Error :  Colorname cannot be blank"
				intErrField = clsColor.enumFieldsColor.eColorname
				Goto ExitFunction
			End If
		End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then ValidateInputData = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
#End Region

#Region "Procedures"
	'/* Procedure - Public */
	'/* Procedure - Friend */
	'/* Procedure - Protected */
	'/* Procedure - Private */
#End Region

#Region "Events"
	'/* Event */
#End Region

#Region "Event Functions"
	'/* Event Function - Public */
	'/* Event Function - Friend */
	'/* Event Function - Protected */
	'/* Event Function - Private */
#End Region

#Region "BR Functions"
	'/* BR Function */
#End Region

#Region "SourceCode - ToRemove"
#End Region

#Region "SourceCode - ToTest"
#End Region

End Class