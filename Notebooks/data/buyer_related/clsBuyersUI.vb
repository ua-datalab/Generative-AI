Friend Class clsBuyersUI

#Region "Inherits"
#End Region

#Region "Implements"
#End Region

#Region "Important Comments"

'* CodeFactory    Version  : CodeFactory_V_11_R_02.00.11
'* Template Class Version  : 10 
'* Created on              : Wednesday, 14 May, 2025 at 06:50:57 PM
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
	Delegate Function RecordsetReposition_GUI() As Boolean
	Delegate Function EnableUserInterface_GUI(ByVal InEvent As clsGlobalEnum.enumFormEvents) As Boolean
	Delegate Function CaptureData_GUI() As Boolean
	Delegate Function DisplayData_GUI() As Boolean
#End Region

#Region "Constants"
	'/* Constant - Public */ (There should not be any public constants, create properties instead)
	'/* Constant - Friend */
	'/* Constant - Protected */
	'/* Constant - Private */
	Private Const CgstrSaveMessage As String = "Do you really want To save this record ?"
	Private Const CgstrMsgboxCaption As String = " Confirmation "
	Private Const CgstrDeleteMessage As String = " Are you sure you want To delete this record ?"

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
	Private mobjFormAttribute As clsFormAttribute
	Private mobjClassAttribute As clsClassAttribute

	Private mobjcmdAddNew As Button
	Private mobjcmdEdit As Button
	Private mobjcmdSave As Button
	Private mobjcmdDelete As Button
	Private mobjcmdCancel As Button

	Private mobjlblRecordStatus As Label
	Private mobjchkGrid As CheckBox
	Private mobjtxtGoToId As TextBox
	Private mobjcmdGoToId As Button

	Private mobjFunction_RecordsetReposition_GUI As  RecordsetReposition_GUI
	Private mobjFunction_EnableUserInterface_GUI As  EnableUserInterface_GUI
	Private mobjFunction_CaptureData_GUI As  CaptureData_GUI
	Private mobjFunction_DisplayData_GUI As  DisplayData_GUI

	'/* Variable - Property - Public */ (There should not be any public variable, create properties instead)
	'/* Variable - Property - Friend */
	'/* Variable - Property - Protected */
	'/* Variable - Property - Private */

#End Region

#Region "Variables - General"
	'/* Variable - General - Public - Object */
	'/* Variable - General - Friend - Object */
	'/* Variable - General - Protected - Object */
	'/* Variable - General - Private - Object */
	Private mobjApp As clsApplication'Default Design
	Private mobjSolutionBO As clsSolutionBO'Default Design
	Private mobjGUI As Form

	Private mobjRS_GridView As ifaRecordset
	Private mobjBuyer As clsBuyer
	Private mobjBuyersBO As clsBuyersBO

	Private mobjfrmGrid As frmGrid2

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
	Public Sub New (byref InobjApp as clsApplication)
		MyBase.New()
		Initialize(InobjApp)
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
	Public ReadOnly Property BuyersBO() As clsBuyersBO
		Get
			Return mobjBuyersBO
		End Get
	End Property
	'/* Property - Public - Writeonly */
	'/* Property - Public - Read & Write */
	Public Property FormAttribute() As clsFormAttribute 
		Get
			Return mobjFormAttribute
		End Get
		Set(Value As clsFormAttribute)
			mobjFormAttribute = Value
		End Set
	End Property
	'/* Property - Friend - Readonly */
	'/* Property - Friend - Writeonly */
	'/* Property - Friend - Read & Write */
	Friend Property Function_CaptureData_GUI() As CaptureData_GUI
		Get
			Return mobjFunction_CaptureData_GUI
		End Get
		Set (Value As CaptureData_GUI )
			mobjFunction_CaptureData_GUI = Value
		End Set
	End Property
	Friend Property Function_DisplayData_GUI() As DisplayData_GUI
		Get
			Return mobjFunction_DisplayData_GUI
		End Get
		Set (Value As DisplayData_GUI )
			mobjFunction_DisplayData_GUI = Value
		End Set
	End Property
	Friend Property Function_EnableUserInterface_GUI() As EnableUserInterface_GUI
		Get
			Return mobjFunction_EnableUserInterface_GUI
		End Get
		Set (Value As EnableUserInterface_GUI )
			mobjFunction_EnableUserInterface_GUI = Value
		End Set
	End Property
	Friend Property Function_RecordsetReposition_GUI() As RecordsetReposition_GUI
		Get
			Return mobjFunction_RecordsetReposition_GUI
		End Get
		Set (Value As RecordsetReposition_GUI )
			mobjFunction_RecordsetReposition_GUI = Value
		End Set
	End Property

	Friend Property Button_AddNew() As Button
		Get
			Return mobjcmdAddNew
		End Get
		Set(Value As Button)
			mobjcmdAddNew = Value
		End Set
	End Property
	Friend Property Button_Edit() As Button
		Get
			Return mobjcmdEdit
		End Get
		Set(Value As Button)
			mobjcmdEdit = Value
		End Set
	End Property
	Friend Property Button_Save() As Button
		Get
			Return mobjcmdSave
		End Get
		Set(Value As Button)
			mobjcmdSave = Value
		End Set
	End Property
	Friend Property Button_Delete() As Button
		Get
			Return mobjcmdDelete
		End Get
		Set(Value As Button)
			mobjcmdDelete = Value
		End Set
	End Property
	Friend Property Button_Cancel() As Button
		Get
			Return mobjcmdCancel
		End Get
		Set(Value As Button)
			mobjcmdCancel = Value
		End Set
	End Property

	Friend Property Label_RecordStatus() As Label
		Get
			Return mobjlblRecordStatus
		End Get
		Set(Value As Label)
			mobjlblRecordStatus = Value
		End Set
	End Property
	Friend Property CheckBox_Grid() As CheckBox
		Get
			Return mobjchkGrid
		End Get
		Set(Value As CheckBox)
			mobjchkGrid = Value
		End Set
	End Property
	Friend Property TextBox_GoToId() As TextBox
		Get
			Return mobjtxtGoToId
		End Get
		Set(Value As TextBox)
			mobjtxtGoToId = Value
		End Set
	End Property
	Friend Property Button_GoToId() As Button
		Get
			Return mobjcmdGoToId
		End Get
		Set(Value As Button)
			mobjcmdGoToId = Value
		End Set
	End Property

	'/* Property - Protected - Readonly */
	'/* Property - Protected - Writeonly */
	'/* Property - Protected - Read & Write */
	'/* Property - Private - Readonly */
	Private ReadOnly Property ThisClassName() As String 'Default Design
		Get
			Return System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name
		End Get
	End Property
	'/* Property - Private - Writeonly */
	'/* Property - Private - Read & Write */
#End Region

#Region "Functions"
	'/* Function - Public */
	Public Function Initialize_UI(ByRef InobjClassAttribute As clsClassAttribute, ByRef InoutobjGUI As Form)As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		Dim strFormCaption As String
		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Initialize_UI = False

		strFormCaption = clsGlobalEnum.CgstrBlank
	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjClassAttribute = InobjClassAttribute
		mobjBuyer = mobjBuyersBO.Buyers.Buyer
		mobjGUI = InoutobjGUI

		If mobjSolutionBO.AppBO .GetFormCaption(mobjGUI.Name, strFormCaption) = False Then Goto ExitFunction
		mobjFormAttribute.Caption = strFormCaption

		mobjBuyersBO.Buyers.RS.RS_SelectWhere = mobjFormAttribute.WhereClause_A
		If mobjBuyersBO.Initialize_BO(mobjClassAttribute) = False Then Goto ExitFunction

		If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Initialize_UI = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	'/* Function - Friend */
	Friend Function CaptureData()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		CaptureData = False

	'--Parameters
	
	'----/* Functionality  - Start */----
	If IsNothing(mobjFunction_CaptureData_GUI) = False Then If mobjFunction_CaptureData_GUI() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then CaptureData = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function DisplayData()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		DisplayData = False

	'--Parameters
	
	'----/* Functionality  - Start */----
	If IsNothing(mobjFunction_DisplayData_GUI) = False Then If mobjFunction_DisplayData_GUI() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then DisplayData = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function EnableButtons(ByVal InEvent As clsGlobalEnum.enumFormEvents ) As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		EnableButtons = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjcmdAddNew.Enabled = False
		mobjcmdEdit.Enabled = False
		mobjcmdSave.Enabled = False
		mobjcmdDelete.Enabled = False
		mobjcmdCancel.Enabled = False
		mobjchkGrid.Enabled = False

			Select Case InEvent
				Case clsGlobalEnum.enumFormEvents.eFormCancel, clsGlobalEnum.enumFormEvents.eFormSave, clsGlobalEnum.enumFormEvents.eFormDefault
					If mobjFormAttribute.UserPermission.Append = True Then
						mobjcmdAddNew.Enabled = True
					End If

					If mobjFormAttribute.UserPermission.Delete = True Then
						mobjcmdDelete.Enabled = True
					End If

					If mobjFormAttribute.UserPermission.Edit = True Then
						mobjcmdEdit.Enabled = True
					End If

				Case clsGlobalEnum.enumFormEvents.eFormNoRecords
					 If mobjFormAttribute.UserPermission.Append = True Then
						mobjcmdAddNew.Enabled = True
					End If

				Case clsGlobalEnum.enumFormEvents.eFormAdd, clsGlobalEnum.enumFormEvents.eFormEdit
					mobjcmdSave.Enabled = True
					mobjcmdCancel.Enabled = True
				End Select

			mobjApp.AppUI.AppUI_Functions.AFUI_Color_FormButton(mobjGUI)

		If EnableUserInterface(InEvent) = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then EnableButtons = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function EnableUserInterface(ByVal InEvent As clsGlobalEnum.enumFormEvents) As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		EnableUserInterface = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		'/* Disable user interface controls

		'/* Enable user interface controls
		Select Case InEvent

			Case clsGlobalEnum.enumFormEvents.eFormRecordFound

			Case clsGlobalEnum.enumFormEvents.eFormSave, clsGlobalEnum.enumFormEvents.eFormCancel, clsGlobalEnum.enumFormEvents.eFormDefault 

			Case clsGlobalEnum.enumFormEvents.eFormAdd, clsGlobalEnum.enumFormEvents.eFormEdit, clsGlobalEnum.enumFormEvents.eFormNoRecords

				End Select

		If IsNothing(mobjFunction_EnableUserInterface_GUI) = False Then If mobjFunction_EnableUserInterface_GUI(InEvent) = False Then Goto ExitFunction
		'/* Enable user interface controls

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then EnableUserInterface = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function GoToRecord( ByVal InstrSearchValue As String, ByRef OutbolRecordFound As Boolean, ByRef OutstrReturnMessage As String) As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		Dim strFieldName As String
		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		GoToRecord = False

	'--Parameters
		OutbolRecordFound = False
		OutstrReturnMessage = clsGlobalEnum.CgstrBlank
	
	'----/* Functionality  - Start */----
		'/* Validate the search val */
		If Trim(InstrSearchValue) = clsGlobalEnum.CgstrBlank Then
		OutstrReturnMessage = "GoTo Id cannot be Blank"

		ElseIf Not IsNumeric(Trim(InstrSearchValue)) Then
		OutstrReturnMessage = "GoTo Id cannot be Non-numeric"

		Else
				strFieldName = mobjBuyer.FieldName(clsBuyer.enumFieldsBuyer.eBuyerId)
		If mobjBuyersBO.Buyers.RS.RS_Find(strFieldName, Trim(InstrSearchValue)) Then
			If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction
			OutbolRecordFound = True
		Else
		OutstrReturnMessage = "No Record Found"
		End If
		End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then GoToRecord = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function RecordsetFind(ByRef InstrFieldName As String, ByRef InstrSearchValue As String) As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		RecordsetFind = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjBuyersBO.Buyers.RS.RS_Find(InstrFieldName, InstrSearchValue) = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then RecordsetFind = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function RecordsetRefresh() As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		RecordsetRefresh = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjBuyersBO.Buyers.RS.RS_Refresh() = False Then Goto ExitFunction
		If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then RecordsetRefresh = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function RecordsetReposition()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		RecordsetReposition = False

	'--Parameters
	
	'----/* Functionality  - Start */----
			If mobjSolutionBO.AppBO.GF_Desktop.DisplayRecordPosition(0, 0, mobjlblRecordStatus.Text) = False Then Exit Function
			If(mobjBuyersBO.Buyers.RS.RS_Bof And mobjBuyersBO.Buyers.RS.RS_Eof) Then
				If EnableButtons(clsGlobalEnum.enumFormEvents.eFormNoRecords) = False Then Goto ExitFunction
				mobjchkGrid.Enabled = False
			Else
				If EnableButtons(clsGlobalEnum.enumFormEvents.eFormDefault) = False Then Goto ExitFunction
				mobjchkGrid.Enabled = True
			End If
			If mobjSolutionBO.AppBO.GF_Desktop.DisplayRecordPosition(mobjBuyersBO.Buyers.RS.RS_AbsolutePosition, mobjBuyersBO.Buyers.RS.RS_RecordCount, mobjlblRecordStatus.Text) = False Then Goto ExitFunction
		If DisplayData() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then RecordsetReposition = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	'/* Function - Protected */
	'/* Function - Private */
	Private Function Initialize(ByRef InobjApp As clsApplication) As Boolean'Default Design
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
		mobjApp = InobjApp
		mobjSolutionBO = mobjApp.SolutionBO

		mobjClassAttribute = New clsClassAttribute
		mobjFormAttribute = New clsFormAttribute
		mobjBuyersBO = New clsBuyersBO(mobjSolutionBO)

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
	Private Function Terminate() As Boolean 'Default Design
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
		mobjClassAttribute = Nothing
		mobjFormAttribute = Nothing
		mobjBuyersBO = Nothing

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
	Friend Function cmdAddNew_Click()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdAddNew_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If EnableButtons(clsGlobalEnum.enumFormEvents.eFormAdd) = False Then Goto ExitFunction
		If mobjBuyersBO.CRUDS.Add() = False Then Goto ExitFunction

		If DisplayData() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdAddNew_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdCancel_Click()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdCancel_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjBuyersBO.CRUDS.Cancel() = False Then Goto ExitFunction
		If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdCancel_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdDelete_Click(Optional ByVal InbolAskConfirmation As Boolean = True)As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		Dim intMsgResult As Microsoft.VisualBasic.MsgBoxResult
		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdDelete_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If InbolAskConfirmation = True  Then
		intMsgResult = MsgBox(CgstrDeleteMessage, vbYesNo, CgstrMsgboxCaption)
		Else
			intMsgResult = vbYes
		End If
		
		If intMsgResult = vbYes
			If mobjBuyersBO.CRUDS.Delete()= False Then Goto ExitFunction
		If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction
		End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdDelete_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdEdit_Click()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdEdit_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjBuyersBO.CRUDS.Edit() = False Then Goto ExitFunction
		If EnableButtons( clsGlobalEnum.enumFormEvents.eFormEdit) = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdEdit_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdSave_Click(Optional ByVal InbolAskConfirmation As Boolean = True) As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		Dim intMsgResult As Microsoft.VisualBasic.MsgBoxResult
		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdSave_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If InbolAskConfirmation = True  Then
			intMsgResult = MsgBox(CgstrSaveMessage, vbYesNo, CgstrMsgboxCaption)
		Else
			intMsgResult = vbYes
		End If
		
		If intMsgResult = vbYes Then 
			If CaptureData() = False Then Goto ExitFunction
			If mobjBuyersBO.CRUDS.Save() = False Then Goto ExitFunction
		If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction
		End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdSave_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdGoToId_Click(Optional ByVal InstrRecordSource As String = clsGlobalEnum.CgstrBlank)As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdGoToId_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjtxtGoToId.Text = clsGlobalEnum.CgstrBlank
		If InstrRecordSource = clsGlobalEnum.CgstrBlank Then
			If mobjApp.AppUI.AppUI_Functions.AFUI_cmdGoToId_Click(mobjBuyersBO.Buyers.RS.RS_RecordSource, clsBuyer.enumFieldsBuyer.eBuyerId, mobjGUI, mobjtxtGoToId) = False Then Goto ExitFunction
		Else
			If mobjApp.AppUI.AppUI_Functions.AFUI_cmdGoToId_Click(InstrRecordSource, clsBuyer.enumFieldsBuyer.eBuyerId, mobjGUI, mobjtxtGoToId) = False Then Goto ExitFunction
		End If
		If Trim(mobjtxtGoToId.Text) <> clsGlobalEnum.CgstrBlank  Then
			If txtGoToId_KeyPress(mobjtxtGoToId, New KeyPressEventArgs(Chr(Keys.Enter))) = False Then Goto ExitFunction
		End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdGoToId_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdRefresh_Click()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdRefresh_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If RecordsetRefresh() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdRefresh_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdMoveFirst_Click()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdMoveFirst_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjBuyersBO.Buyers.RS.RS_MoveFirst()
		If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdMoveFirst_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdMoveLast_Click()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdMoveLast_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjBuyersBO.Buyers.RS.RS_MoveLast()
		If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdMoveLast_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdMoveNext_Click()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdMoveNext_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjBuyersBO.Buyers.RS.RS_MoveNext()
		If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdMoveNext_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function cmdMovePrevious_Click()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdMovePrevious_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		mobjBuyersBO.Buyers.RS.RS_MovePrevious()
		If IsNothing(mobjFunction_RecordsetReposition_GUI) = False Then If mobjFunction_RecordsetReposition_GUI() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then cmdMovePrevious_Click = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function chkGrid_CheckedChanged(Optional ByVal InstrRecordSource As String = clsGlobalEnum.CgstrBlank)As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		chkGrid_CheckedChanged = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If InstrRecordSource = clsGlobalEnum.CgstrBlank Then
		If mobjApp.AppUI.AppUI_Functions.AFUI_chkGrid_CheckStateChanged(mobjBuyersBO.Buyers.RS.RS_RecordSource, clsBuyer.enumFieldsBuyer.eBuyerId, mobjGUI, mobjchkGrid, mobjBuyersBO.Buyers) = False Then Goto ExitFunction
		Else
		If mobjApp.AppUI.AppUI_Functions.AFUI_chkGrid_CheckStateChanged(InstrRecordSource, clsBuyer.enumFieldsBuyer.eBuyerId, mobjGUI, mobjchkGrid, mobjBuyersBO.Buyers) = False Then Goto ExitFunction
		End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then chkGrid_CheckedChanged = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Friend Function txtGoToId_KeyPress(ByRef InouttxtTextBox As TextBox, ByRef e As System.Windows.Forms.KeyPressEventArgs )As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		Dim bolRecordFound As Boolean
		Dim strReturnMessage As String
		Dim intKeyAscii As Integer
		
		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		txtGoToId_KeyPress = False

		bolRecordFound = False
		strReturnMessage = clsGlobalEnum.CgstrBlank
		intKeyAscii = Asc(e.KeyChar)
		
	'--Parameters
	
	'----/* Functionality  - Start */----
		If intKeyAscii = 13 Then
			If Trim(mobjtxtGoToId.Text) = clsGlobalEnum.CgstrBlank Then
			MsgBox("GoToId Cannot be blank ",MsgBoxStyle.Information)
			If cmdMoveFirst_Click() = False Then Goto ExitFunction
			Goto ExitFunction
			End If

			If GoToRecord(mobjtxtGoToId.Text, bolRecordFound, strReturnMessage) = False Then Goto ExitFunction
			If bolRecordFound = False Then MsgBox(strReturnMessage, MsgBoxStyle.Information)
		Else
			If mobjtxtGoToId.Text.Length > 0 Then
				If mobjSolutionBO.AppBO.GF_Desktop.GetNumeric(intKeyAscii,  mobjtxtGoToId.Text, clsGlobalEnum.enumFieldLength.eLength8, clsGlobalEnum.CgintNotDefined, False) = False Then Goto ExitFunction
			End If
		End If

		e.KeyChar = Chr(intKeyAscii)
		If intKeyAscii = 0 Then
			e.Handled = True
		End If

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then txtGoToId_KeyPress = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
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