Friend Class frmColor

#Region "Inherits"
#End Region

#Region "Implements"
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
#End Region

#Region "Enumerics"
	'/* Enumeric - Public */
	'/* Enumeric - Friend */
	'/* Enumeric - Protected */
	'/* Enumeric - Private */
	'Enumerics for Frame
	Private Enum enumFrame
		efraNotDefined = 0
		efraColor = 1
	End Enum

#End Region

#Region "Variables"
#Region "Variables - Property"
	'/* Variable - Property - Public - Object */
	'/* Variable - Property - Friend - Object */
	'/* Variable - Property - Protected - Object */
	'/* Variable - Property - Private - Object */
	Private mobjFormAttribute As clsFormAttribute
	Private mobjClassAttribute As clsClassAttribute
	Private mobjApp As clsApplication'Default Design

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
	Private mobjSolutionBO As clsSolutionBO'Default Design
	Private mobjColorsUI As clsColorsUI

	Private mobjRS_ColorView As ifaRecordset
	Private inteFrame As enumFrame

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
	Public Sub New()
		' Call to InitilizeComponent is required by the Windows Form Designer.
		' Add any initialization after the InitializeComponent() call.
		InitializeComponent()
		Initialize()
	End Sub

#End Region

#Region "Class Destructor"
	'/* Class Destructor - Finalizes */
	Protected Overrides Sub Finalize()
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
	Public ReadOnly Property FormAttribute() As clsFormAttribute 
		Get
			Return mobjFormAttribute
		End Get
	End Property
	Public ReadOnly Property ColorsUI () As clsColorsUI
		Get
			Return mobjColorsUI
		End Get
	End Property
	'/* Property - Public - Writeonly */
	'/* Property - Public - Read & Write */
	'/* Property - Friend - Readonly */
	'/* Property - Friend - Writeonly */
	'/* Property - Friend - Read & Write */
	Friend Property App() As clsApplication
		Get
			Return mobjApp
		End Get
		Set (Value As clsApplication)
			mobjApp = Value
			mobjSolutionBO = mobjApp.SolutionBO
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
	Public Function Initialize_Form()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		Dim lngFormId As Long
		Dim strFormCaption As String

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Initialize_Form = False

	'--Parameters
		strFormCaption = clsGlobalEnum.CgstrBlank

	
	'----/* Functionality  - Start */----
		mobjColorsUI = New clsColorsUI(mobjApp)
		mobjColorsUI.FormAttribute = Me.FormAttribute
		Me.MdiParent = mobjApp.Form_Parent


	mobjColorsUI.Button_AddNew = cmdAddNew
	mobjColorsUI.Button_Edit = cmdEdit
	mobjColorsUI.Button_Save = cmdSave
	mobjColorsUI.Button_Delete = cmdDelete
	mobjColorsUI.Button_Cancel = cmdCancel

	mobjColorsUI.Label_RecordStatus = lblRecordStatus
	mobjColorsUI.CheckBox_Grid = chkGrid
	mobjColorsUI.TextBox_GoToId = txtGoToId
	mobjColorsUI.Button_GoToId = cmdGoToId

	mobjColorsUI.Function_CaptureData_GUI =AddressOf CaptureData
	mobjColorsUI.Function_DisplayData_GUI =AddressOf DisplayData
	mobjColorsUI.Function_EnableUserInterface_GUI =AddressOf EnableUserInterface
	mobjColorsUI.Function_RecordsetReposition_GUI =AddressOf RecordsetReposition

	If mobjColorsUI.Initialize_UI(mobjClassAttribute, Me) = False Then Goto ExitFunction

	If DefaultGuiSettings() = False Then Goto ExitFunction
	If RecordsetReposition() = False Then Goto ExitFunction


		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Initialize_Form = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Public Function Terminate_Form()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Terminate_Form = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If Terminate() = False Then Goto ExitFunction
		Me.Close()


		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Terminate_Form = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	Public Function RecordsetReposition()As Boolean
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
		If mobjColorsUI.RecordsetReposition() = False Then Goto ExitFunction

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
		With mobjColorsUI.ColorsBO.Colors.Color

			.ColorUid = txtColorUid.Text
			.Colorcode = txtColorcode.Text
			.Colorname = txtColorname.Text

		End With

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
		With mobjColorsUI.ColorsBO.Colors.Color

			txtColorUid.Text = .ColorUid
			txtColorcode.Text = .Colorcode
			txtColorname.Text = .Colorname

		End With

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

		'Controls - Standard - Database
		txtColorUid.Enabled = False
		txtColorcode.Enabled = False
		txtColorname.Enabled = False

		'Controls - Standard - Additional
		txtGoToId.Enabled = False
		cmdGoToId.Enabled = False
		chkGrid.Enabled = False

		'Controls - Standard - Navigation
		cmdMoveFirst.Enabled = False
		cmdMovePrevious.Enabled = False
		cmdMoveNext.Enabled = False
		cmdMoveLast.Enabled = False

		'Controls - Others

		'/* Enable user interface controls
		Select Case InEvent

			Case clsGlobalEnum.enumFormEvents.eFormNoRecords

			Case clsGlobalEnum.enumFormEvents.eFormSave, clsGlobalEnum.enumFormEvents.eFormCancel, clsGlobalEnum.enumFormEvents.eFormDefault

		'Controls - Standard - Additional
		txtGoToId.Enabled = True
		cmdGoToId.Enabled = True
		chkGrid.Enabled = True

		'Controls - Standard - Navigation
		cmdMoveFirst.Enabled = True
		cmdMovePrevious.Enabled = True
		cmdMoveNext.Enabled = True
		cmdMoveLast.Enabled = True

			Case clsGlobalEnum.enumFormEvents.eFormAdd, clsGlobalEnum.enumFormEvents.eFormEdit

		'Controls - Standard - Database
			txtColorUid.Enabled = True
			txtColorcode.Enabled = True
			txtColorname.Enabled = True

		'Controls - Others

				End Select

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
	'/* Function - Protected */
	'/* Function - Private */
	Private Function Initialize() As Boolean'Default Design
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
		mobjClassAttribute = New clsClassAttribute
		mobjFormAttribute = New clsFormAttribute

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

	mobjColorsUI = Nothing

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
	Private Function DefaultGuiSettings()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		DefaultGuiSettings = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		Me.Text = mobjFormAttribute.Caption
		Me.TopMost = True

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then DefaultGuiSettings = True
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
	Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click
			cmdAddNew_Click()
	End Sub
	Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
			cmdCancel_Click()
	End Sub
	Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
			cmdDelete_Click()
	End Sub
	Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
			cmdEdit_Click()
	End Sub
	Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
			cmdSave_Click()
	End Sub
	Private Sub cmdMoveFirst_Click(sender As Object, e As EventArgs) Handles cmdMoveFirst.Click
			mobjColorsUI.cmdMoveFirst_Click()
	End Sub
	Private Sub cmdMoveLast_Click(sender As Object, e As EventArgs) Handles cmdMoveLast.Click
			mobjColorsUI.cmdMoveLast_Click()
	End Sub
	Private Sub cmdMoveNext_Click(sender As Object, e As EventArgs) Handles cmdMoveNext.Click
			mobjColorsUI.cmdMoveNext_Click()
	End Sub
	Private Sub cmdMovePrevious_Click(sender As Object, e As EventArgs) Handles cmdMovePrevious.Click
			mobjColorsUI.cmdMovePrevious_Click()
	End Sub
	Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
			Terminate_Form()
	End Sub
	Private Sub cmdGoToId_Click(sender As Object, e As EventArgs) Handles cmdGoToId.Click
			mobjColorsUI.cmdGoToId_Click()
	End Sub
	Private Sub lblCloseForm_Click(sender As Object, e As EventArgs) Handles lblCloseForm.Click
			Terminate_Form()
	End Sub
	Private Sub chkGrid_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrid.CheckedChanged
			mobjColorsUI.chkGrid_CheckedChanged()
	End Sub
	Private Sub txtGoToId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGoToId.KeyPress
			mobjColorsUI.txtGoToId_KeyPress(txtGoToId, e)
	End Sub
#End Region

#Region "Event Functions"
	'/* Event Function - Public */
	'/* Event Function - Friend */
	'/* Event Function - Protected */
	'/* Event Function - Private */
	Private Function cmdAddNew_Click()As Boolean
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
		If mobjColorsUI.cmdAddNew_Click() = False Then Goto ExitFunction

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
	Private Function cmdCancel_Click()As Boolean
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
		If mobjColorsUI.cmdCancel_Click() = False Then Goto ExitFunction

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
	Private Function cmdDelete_Click()As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdDelete_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjColorsUI.cmdDelete_Click() = False Then Goto ExitFunction

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
	Private Function cmdEdit_Click()As Boolean
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
		If mobjColorsUI.cmdEdit_Click() = False Then Goto ExitFunction

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
	Private Function cmdSave_Click() As Boolean
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		cmdSave_Click = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		If mobjColorsUI.cmdSave_Click() = False Then Goto ExitFunction

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
#End Region

#Region "BR Functions"
	'/* BR Function */
#End Region

#Region "SourceCode - ToRemove"
#End Region

#Region "SourceCode - ToTest"
#End Region

End Class