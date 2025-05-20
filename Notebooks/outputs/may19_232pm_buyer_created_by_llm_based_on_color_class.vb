Public Class clsBuyer

#Region "Inherits"
#End Region

#Region "Implements"
    Implements ifaBusinessElement
#End Region

#Region "Important Comments"

'* CodeFactory    Version  : CodeFactory_V_11_R_02.00.11
'* Template Class Version  : 10 
'* Created on              : Sunday, 13 April, 2025 at 11:11:17 PM
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
    Public Const CmintBuyerId_Length As Integer = clsGlobalEnum.enumFieldLength.eLength4
    Public Const CmintBuyerName_Length As Integer = clsGlobalEnum.enumFieldLength.eLength100
    Public Const CmintAddress1_Length As Integer = clsGlobalEnum.enumFieldLength.eLength50
    Public Const CmintAddress2_Length As Integer = clsGlobalEnum.enumFieldLength.eLength50
    Public Const CmintAddress3_Length As Integer = clsGlobalEnum.enumFieldLength.eLength50
    Public Const CmintAddress4_Length As Integer = clsGlobalEnum.enumFieldLength.eLength50
    Public Const CmintPhone1_Length As Integer = clsGlobalEnum.enumFieldLength.eLength25
    Public Const CmintPhone2_Length As Integer = clsGlobalEnum.enumFieldLength.eLength25
    Public Const CmintMobilePhone_Length As Integer = clsGlobalEnum.enumFieldLength.eLength25

    'Constant for Field DataType
    Public Const CmintBuyerId_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eInteger
    Public Const CmintBuyerName_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar
    Public Const CmintAddress1_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar
    Public Const CmintAddress2_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar
    Public Const CmintAddress3_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar
    Public Const CmintAddress4_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar
    Public Const CmintPhone1_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar
    Public Const CmintPhone2_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar
    Public Const CmintMobilePhone_DataType As clsGlobalEnum.enumDataTypes = clsGlobalEnum.enumDataTypes.eVarWChar

    '/* Constant - Friend */
    '/* Constant - Protected */
    '/* Constant - Private */
    'Constant for Field Count
    Private Const mlngFieldCount As Long = 9

    'Constant for Field names
    Private Const CmstrBuyerId As String = "BuyerId"
    Private Const CmstrBuyerName As String = "BuyerName"
    Private Const CmstrAddress1 As String = "Address1"
    Private Const CmstrAddress2 As String = "Address2"
    Private Const CmstrAddress3 As String = "Address3"
    Private Const CmstrAddress4 As String = "Address4"
    Private Const CmstrPhone1 As String = "Phone1"
    Private Const CmstrPhone2 As String = "Phone2"
    Private Const CmstrMobilePhone As String = "MobilePhone"

#End Region

#Region "Enumerics"
    '/* Enumeric - Public */
    'Enumerics for Field
    Public Enum enumFieldsBuyer
        eBuyerId = 0
        eBuyerName = 1
        eAddress1 = 2
        eAddress2 = 3
        eAddress3 = 4
        eAddress4 = 5
        ePhone1 = 6
        ePhone2 = 7
        eMobilePhone = 8
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
    Private mlngBuyerId As Integer
    Private mstrBuyerName As String
    Private mstrAddress1 As String
    Private mstrAddress2 As String
    Private mstrAddress3 As String
    Private mstrAddress4 As String
    Private mstrPhone1 As String
    Private mstrPhone2 As String
    Private mstrMobilePhone As String

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
            Case enumFieldsBuyer.eBuyerId
                strReturnValue = CmstrBuyerId
            Case enumFieldsBuyer.eBuyerName
                strReturnValue = CmstrBuyerName
            Case enumFieldsBuyer.eAddress1
                strReturnValue = CmstrAddress1
            Case enumFieldsBuyer.eAddress2
                strReturnValue = CmstrAddress2
            Case enumFieldsBuyer.eAddress3
                strReturnValue = CmstrAddress3
            Case enumFieldsBuyer.eAddress4
                strReturnValue = CmstrAddress4
            Case enumFieldsBuyer.ePhone1
                strReturnValue = CmstrPhone1
            Case enumFieldsBuyer.ePhone2
                strReturnValue = CmstrPhone2
            Case enumFieldsBuyer.eMobilePhone
                strReturnValue = CmstrMobilePhone
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
            Case enumFieldsBuyer.eBuyerId
                intReturnValue = CmintBuyerId_DataType
            Case enumFieldsBuyer.eBuyerName
                intReturnValue = CmintBuyerName_DataType
            Case enumFieldsBuyer.eAddress1
                intReturnValue = CmintAddress1_DataType
            Case enumFieldsBuyer.eAddress2
                intReturnValue = CmintAddress2_DataType
            Case enumFieldsBuyer.eAddress3
                intReturnValue = CmintAddress3_DataType
            Case enumFieldsBuyer.eAddress4
                intReturnValue = CmintAddress4_DataType
            Case enumFieldsBuyer.ePhone1
                intReturnValue = CmintPhone1_DataType
            Case enumFieldsBuyer.ePhone2
                intReturnValue = CmintPhone2_DataType
            Case enumFieldsBuyer.eMobilePhone
                intReturnValue = CmintMobilePhone_DataType
        End Select
    
         Return intReturnValue
        End Get
    End Property
    Public ReadOnly Property FieldType(ByVal InstrFieldName As String) As clsGlobalEnum.enumDataTypes Implements ifaBusinessElement.FieldType
        Get
        Dim intReturnValue As clsGlobalEnum.enumDataTypes
    
        Select Case InstrFieldName
            Case CmstrBuyerId
                intReturnValue = CmintBuyerId_DataType
            Case CmstrBuyerName
                intReturnValue = CmintBuyerName_DataType
            Case CmstrAddress1
                intReturnValue = CmintAddress1_DataType
            Case CmstrAddress2
                intReturnValue = CmintAddress2_DataType
            Case CmstrAddress3
                intReturnValue = CmintAddress3_DataType
            Case CmstrAddress4
                intReturnValue = CmintAddress4_DataType
            Case CmstrPhone1
                intReturnValue = CmintPhone1_DataType
            Case CmstrPhone2
                intReturnValue = CmintPhone2_DataType
            Case CmstrMobilePhone
                intReturnValue = CmintMobilePhone_DataType
        End Select
    
         Return intReturnValue
        End Get
    End Property

    Public ReadOnly Property PrimaryKeyIndex() As Integer
    Get
        Return enumFieldsBuyer.eBuyerId
    End Get
    End Property
    Public ReadOnly Property PrimaryKeyName() As String
    Get
        Return CmstrBuyerId
    End Get
    End Property
    '/* Property - Public - Writeonly */
    '/* Property - Public - Read & Write */
    Public Property FieldValue(ByVal InintIndex As Integer) As String Implements ifaBusinessElement.FieldValue
        Get
            Dim strReturnValue As String
            strReturnValue = clsGlobalEnum.CgstrBlank

            Select Case InintIndex
                Case enumFieldsBuyer.eBuyerId
                    strReturnValue = BuyerId.ToString()
                Case enumFieldsBuyer.eBuyerName
                    strReturnValue = BuyerName
                Case enumFieldsBuyer.eAddress1
                    strReturnValue = Address1
                Case enumFieldsBuyer.eAddress2
                    strReturnValue = Address2
                Case enumFieldsBuyer.eAddress3
                    strReturnValue = Address3
                Case enumFieldsBuyer.eAddress4
                    strReturnValue = Address4
                Case enumFieldsBuyer.ePhone1
                    strReturnValue = Phone1
                Case enumFieldsBuyer.ePhone2
                    strReturnValue = Phone2
                Case enumFieldsBuyer.eMobilePhone
                    strReturnValue = MobilePhone
            End Select
            Return strReturnValue
        End Get
        Set (ByVal Value As String)
            Select Case InintIndex
                Case enumFieldsBuyer.eBuyerId
                    BuyerId = CInt(Value)
                Case enumFieldsBuyer.eBuyerName
                    BuyerName = Value
                Case enumFieldsBuyer.eAddress1
                    Address1 = Value
                Case enumFieldsBuyer.eAddress2
                    Address2 = Value
                Case enumFieldsBuyer.eAddress3
                    Address3 = Value
                Case enumFieldsBuyer.eAddress4
                    Address4 = Value
                Case enumFieldsBuyer.ePhone1
                    Phone1 = Value
                Case enumFieldsBuyer.ePhone2
                    Phone2 = Value
                Case enumFieldsBuyer.eMobilePhone
                    MobilePhone = Value
            End Select
        End Set
    End Property
    Public Property BuyerId() As Integer
        Get
            Return mlngBuyerId
        End Get
        Set (ByVal Value As Integer)
            mlngBuyerId = Value
        End Set
    End Property
    Public Property BuyerName() As String
        Get
            Return mstrBuyerName
        End Get
        Set (ByVal Value As String)
            mstrBuyerName = Value
        End Set
    End Property
    Public Property Address1() As String
        Get
            Return mstrAddress1
        End Get
        Set (ByVal Value As String)
            mstrAddress1 = Value
        End Set
    End Property
    Public Property Address2() As String
        Get
            Return mstrAddress2
        End Get
        Set (ByVal Value As String)
            mstrAddress2 = Value
        End Set
    End Property
    Public Property Address3() As String
        Get
            Return mstrAddress3
        End Get
        Set (ByVal Value As String)
            mstrAddress3 = Value
        End Set
    End Property
    Public Property Address4() As String
        Get
            Return mstrAddress4
        End Get
        Set (ByVal Value As String)
            mstrAddress4 = Value
        End Set
    End Property
    Public Property Phone1() As String
        Get
            Return mstrPhone1
        End Get
        Set (ByVal Value As String)
            mstrPhone1 = Value
        End Set
    End Property
    Public Property Phone2() As String
        Get
            Return mstrPhone2
        End Get
        Set (ByVal Value As String)
            mstrPhone2 = Value
        End Set
    End Property
    Public Property MobilePhone() As String
        Get
            Return mstrMobilePhone
        End Get
        Set (ByVal Value As String)
            mstrMobilePhone = Value
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
    Private Function Terminate() As Boolean'Default Design
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
