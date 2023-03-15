;#DropDB XAF_CRMEasyTest

#Application XAF_CRM.Win
#Application XAF_CRM.Web

*FillForm
 User Name = Admin
*Action Log In

#IfDef XAF_CRM.Win

*Action About...
 
*Action OK

#EndIf

#IfDef XAF_CRM.Web
*Action Navigation(My Details)
#EndIf
