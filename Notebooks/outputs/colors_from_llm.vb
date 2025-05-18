Public Class clsColor

#Region "Inherits"
#End Region

#Region "Implements"
    Implements ifaBusinessElement
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
    'Constant for Field Length
    Public Const CmintColorUid_Length As Integer = clsGlobalEnum.enumFieldLength.eLength4
    Public Const CmintColorCode_Length As Integer = clsGlobalEnum.enumFieldLength.eLength10
    Public Const CmintColorName_Length As Integer = clsGlobalEnum.enumFieldLength.eLength31

    'Constant for Field DataType
    Public Const CmintColorUid_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eInteger
    Public Const CmintColorCode_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar
    Public Const CmintColorName_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar

    '/* Constant - Friend */
    '/* Constant - Protected */
    '/* Constant - Private */
    'Constant for Field Count
    Private Const mlngFieldCount As Long = 3

    'Constant for Field names
    Private Const CmstrColorUid As String = "ColorUid"
    Private Const CmstrColorCode As String = "ColorCode"
    Private Const CmstrColorName As String = "ColorName"

#End Region

#Region "Enumerics"
    '/* Enumeric - Public */
    'Enumerics for Field
    Public Enum enumFieldsColor
        eColorUid = 0
        eColorCode = 1
        eColorName = 2
    End Enum

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
    '/* Variable - Property - Public */ (There should not be any public variable, create properties instead)
    '/* Variable - Property - Friend */
    '/* Variable - Property - Protected */
    '/* Variable - Property - Private */

    ' Variable for Fields
    Private mlngColorUid As String
    Private mstrColorCode As String
    Private mstrColorName As String

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
    Public Sub New(ByRef InobjSolutionBO As clsSolutionBO)
        MyBase.New()
        Initialize(InobjSolutionBO)
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
    Public ReadOnly Property FieldCount() As Long Implements ifaBusinessElement.FieldCount
        Get
            Return mlngFieldCount
        End Get
    End Property
    Public ReadOnly Property FieldName(ByVal InintIndex As Integer) As String Implements ifaBusinessElement.FieldName
        Get
            Dim strReturnValue As String

            Select Case InintIndex
                Case enumFieldsColor.eColorUid
                    strReturnValue = CmstrColorUid
                Case enumFieldsColor.eColorCode
                    strReturnValue = CmstrColorCode
                Case enumFieldsColor.eColorName
                    strReturnValue = CmstrColorName
                Case Else
                    strReturnValue = clsGlobalEnum.CgstrBlank
            End Select

            Return strReturnValue
        End Get
    End Property
    Public ReadOnly Property FieldType(ByVal InintIndex As Integer) As clsGlobalEnum.enumDataTypes Implements ifaBusinessElement.FieldType
        Get
            Dim intReturnValue As clsGlobalEnum.enumDataTypes

            Select Case InintIndex
                Case enumFieldsColor.eColorUid
                    intReturnValue = CmintColorUid_DataType
                Case enumFieldsColor.eColorCode
                    intReturnValue = CmintColorCode_DataType
                Case enumFieldsColor.eColorName
                    intReturnValue = CmintColorName_DataType
            End Select

            Return intReturnValue
        End Get
    End Property
    Public ReadOnly Property FieldType(ByVal InstrFieldName As String) As clsGlobalEnum.enumDataTypes Implements ifaBusinessElement.FieldType
        Get
            Dim intReturnValue As clsGlobalEnum.enumDataTypes

            Select Case InstrFieldName
                Case CmstrColorUid
                    intReturnValue = CmintColorUid_DataType
                Case CmstrColorCode
                    intReturnValue = CmintColorCode_DataType
                Case CmstrColorName
                    intReturnValue = CmintColorName_DataType
            End Select

            Return intReturnValue
        End Get
    End Property

    Public ReadOnly Property PrimaryKeyIndex() As Integer
        Get
            Return enumFieldsColor.eColorUid
        End Get
    End Property
    Public ReadOnly Property PrimaryKeyName() As String
        Get
            Return CmstrColorUid
        End Get
    End Property
    '/* Property - Public - Writeonly */
    '/* Property - Public - Read & Write */
    Public Property FieldValue(ByVal InintIndex As Integer) As String Implements ifaBusinessElement.FieldValue
        Get
            Dim strReturnValue As String
            strReturnValue = clsGlobalEnum.CgstrBlank

            Select Case InintIndex
                Case enumFieldsColor.eColorUid
                    strReturnValue = ColorUid
                Case enumFieldsColor.eColorCode
                    strReturnValue = ColorCode
                Case enumFieldsColor.eColorName
                    strReturnValue = ColorName
            End Select
            Return strReturnValue
        End Get
        Set(ByVal Value As String)
            Select Case InintIndex
                Case enumFieldsColor.eColorUid
                    ColorUid = Value
                Case enumFieldsColor.eColorCode
                    ColorCode = Value
                Case enumFieldsColor.eColorName
                    ColorName = Value
            End Select
        End Set
    End Property
    Public Property ColorUid() As String
        Get
            Return mlngColorUid
        End Get
        Set(ByVal Value As String)
            mlngColorUid = Value
        End Set
    End Property
    Public Property ColorCode() As String
        Get
            Return mstrColorCode
        End Get
        Set(ByVal Value As String)
            mstrColorCode = Value
        End Set
    End Property
    Public Property ColorName() As String
        Get
            Return mstrColorName
        End Get
        Set(ByVal Value As String)
            mstrColorName = Value
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
    '/* Property - Private - Writeonly */
    '/* Property - Private - Read & Write */
#End Region

#Region "Functions"
    '/* Function - Public */
    '/* Function - Friend */
    '/* Function - Protected */
    '/* Function - Private */
    Private Function Initialize(ByRef InobjSolutionBO As clsSolutionBO) As Boolean 'Default Design
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

        ExecutionComplete = True
        '----/* Functionality  - End */----
        '----/* Close - Variables */----
ExitFunction:

        '----/* Return Execution Status */----
        If ExecutionComplete = True Then Initialize = True
        Exit Function

ErrorHandler:
        GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
        GoTo ExitFunction

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
        mobjSolutionBO = Nothing

        ExecutionComplete = True
        '----/* Functionality  - End */----
        '----/* Close - Variables */----
ExitFunction:

        '----/* Return Execution Status */----
        If ExecutionComplete = True Then Terminate = True
        Exit Function

ErrorHandler:
        GenericErrorHandler(Err, ThisClassName, ThisFunctionName)
        GoTo ExitFunction

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
