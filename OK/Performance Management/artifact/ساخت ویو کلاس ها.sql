--server: OKDC30063\NODE
use webjam
--create view  ok_view_class as 
select 
class_code,class_name,class_state,Course_code,course_name,t.duration,t.startdate,t.finishdate,t.Eyear,training_center_name,ravesh_name,Edju_name,kind_course
,employee_no,Id_code,firstname,lastname,atwork,sex,Job_title,organ1_name,organ2_name,shobeh_name,level1_name,level2_name,honor,rest
from tclass t inner join courses c on t.course_id=c.course_id
inner join training_centers tc on t.training_center_id=tc.training_center_id
left join ravesh_edju r on t.ravesh_id=r.ravesh_id
left join Type_Edju te on t.edju_id=te.edju_id
left join kind_course k on c.kind_id=k.kind_id
inner join Employees_Program ep on t.class_id=ep.class_id
inner join employees_view ev on ep.Employee_id=ev.employee_id
left join Employees_Excute_Edju ee on ep.radif=ee.radif_program
where t.Eyear=1403





