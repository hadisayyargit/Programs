EXECUTE DBA.dbo.dbasp_WhoIsActive @output_column_list = 
'[dd%][session_id][host_name][login_name][status][sql_text][sql_command][wait_info][block%][percent_complete][tasks][tran_log%][cpu%][temp%][reads%][writes%][context%][physical%][query_plan][locks]';


/*
SELECT
    name, OBJECT_NAME(parent_object_id) 'Table'
FROM 
    sys.foreign_keys
WHERE 
    --referenced_object_id = OBJECT_ID('COM.DIM_Item')
	 [name] like N'%Fact_InternalReceipt%'
*/

Select
	object_name(rkeyid) Parent_Table,
	object_name(fkeyid) Child_Table,
	object_name(constid) FKey_Name,
	c1.name FKey_Col,
	c2.name Ref_KeyCol
From
	sys.sysforeignkeys s
	Inner join sys.syscolumns c1
		on ( s.fkeyid = c1.id And s.fkey = c1.colid )
	Inner join syscolumns c2
		on ( s.rkeyid = c2.id And s.rkey = c2.colid )
where 	1=1
  and object_name(rkeyid)='DIM_Date'
  and object_name(fkeyid)='Fact_DiscountTrans'
Order by Parent_Table,Child_Table
