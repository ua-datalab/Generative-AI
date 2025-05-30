Public Class clsBuyersBO

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
#End Region

#Region "Variables"
#Region "Variables - Property"
	'/* Variable - Property - Public - Object */
	'/* Variable - Property - Friend - Object */
	'/* Variable - Property - Protected - Object */
	'/* Variable - Property - Private - Object */
	Private mobjBuyers As clsBuyers
	Private mobjClassAttribute As clsClassAttribute

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
	Public ReadOnly Property Buyers() As clsBuyers
		Get
			Return mobjBuyers
		End Get
	End Property
	Public ReadOnly Property CRUDS() As ifaCRUDS
		Get
			Return mobjBuyers
		End Get
	End Property
	'/* Property - Public - Writeonly */
	'/* Property - Public - Read & Write */
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
	'/* Property - Private - Writeonly */
	'/* Property - Private - Read & Write */
#End Region

#Region "Functions"
	'/* Function - Public */
	Public Function Initialize_BO(Optional ByRef InobjClassAttribute As clsClassAttribute = Nothing) As Boolean 'Default Design
		On Error GoTo ErrorHandler
	
	'----/* Declaration - Private Object variables */----
		'----/* Declaration - Private variables */----
		Dim ExecutionComplete As Boolean
		Dim ThisFunctionName As String = System.Reflection.MethodInfo.GetCurrentMethod().Name 

		'----/* Initialize - Variables */----
	'--Local Variables
		ExecutionComplete = False
		Initialize_BO = False

	'--Parameters
	
	'----/* Functionality  - Start */----
		 mobjClassAttribute = InobjClassAttribute

		If mobjBuyers.Initialize_CO(mobjClassAttribute) = False Then Goto ExitFunction
		If mobjBuyers.RS.RS_Refresh() = False Then Goto ExitFunction

		ExecutionComplete = True
		'----/* Functionality  - End */----
		'----/* Close - Variables */----
	ExitFunction:

		'----/* Return Execution Status */----
		If ExecutionComplete = True Then Initialize_BO = True
		Exit Function
	
	ErrorHandler:
		GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
		Goto ExitFunction

	End Function
	'/* Function - Friend */
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
		mobjBuyers = New clsBuyers(mobjSolutionBO)

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
		mobjClassAttribute = Nothing
		mobjBuyers = Nothing

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