use Examination_System
/*                                                            Instructor                                                                  */
/*								select                             */
go
create proc instructor_select
as
return select * from instructor
/*								insert                             */
go
create proc instructor_insert(@ins_Name varchar(20),@ins_Username nvarchar(20),@ins_Password varchar(20))
as
insert into instructor(Ins_Name,Ins_Username,Ins_password) values (@ins_Name,@ins_Username,@ins_Password)
return 
/*						  update name                             */
go
create proc instructor_name_update(@Ins_ID smallint,@ins_Name varchar(20))
as
update instructor
set Ins_Name=@ins_Name
where Ins_ID=@Ins_ID
return 
/*						 update password                          */
go
create proc instructor_password_update(@Ins_ID smallint,@ins_Password varchar(20))
as
update instructor
set Ins_password=@ins_Password
where Ins_ID=@Ins_ID
return 
/*			    	    		delete                             */
go
create proc instructor_delete(@Ins_ID smallint)
as
delete from instructor 
where Ins_ID=@Ins_ID
return 
