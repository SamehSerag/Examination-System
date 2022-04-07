use Examination_System
go
create PROC select_student @id INT
as
begin try
select Stud_ID, Stud_Name, Stud_username, Stud_Password, Dept_ID from Student where Stud_Id=@id;
end try
begin catch
Select 'couldnt select student'
end catch


go
create Proc insert_student @name varchar(20)
, @username varchar(20), @password varchar(20), @Dept smallint
as 
begin try
insert into student values(@name, @username, @password , @Dept)
end try
begin catch
select 'insert failed'
end catch


go
create Proc update_student_name @id smallint , @name varchar(20)
as 
begin try
update student
set stud_name=@name where Stud_ID=@id
end try
begin catch
select 'update failed'
end catch


go
create Proc update_student_password @id smallint , @password varchar(20)
as 
begin try
update student
set Stud_Password=@password where Stud_ID=@id
end try
begin catch
select 'update failed'
end catch


go
create Proc update_student_username @id smallint , @uname varchar(20)
as 
begin try
update student
set Stud_username=@uname where Stud_ID=@id
end try
begin catch
select 'update failed'
end catch


go
create Proc update_student_department @id smallint , @dname varchar(20)
as 
begin try
update student
set Dept_ID=@dname where Stud_ID=@id
end try
begin catch
select 'update failed'
end catch

go
create PROC delete_student @id INT
as
begin try
delete from student where Stud_Id=@id;
end try
begin catch
Select 'couldnt delete student'
end catch


go
create PROC select_course @cid smallINT
as
begin try
select CID, course_name, Ins_ID from Course where CID=@cid;
end try
begin catch
Select 'couldnt select this course'
end catch


go
create Proc insert_course @cid smallint , @name varchar(20), @ins_id smallint
as 
begin try
insert into Course values(@cid, @name, @ins_id)
end try
begin catch
select 'insert failed'
end catch


go
create Proc update_coursename @cid smallint , @name varchar(20)
as
begin try
update Course
set Course_Name=@name where CID=@cid
end try
begin catch
select 'update failed'
end catch


go
create Proc update_course_instructor @cid smallint , @iid smallint
as
begin try
update Course
set Ins_ID=@iid where CID=@cid
end try
begin catch
select 'update failed'
end catch


go
create PROC delete_course @cid smallINT
as
begin try
delete from Course where CID=@cid;
end try
begin catch
Select 'couldnt delete course'
end catch


go
create PROC select_all_dept_for_course @cid smallINT
as
begin try
select Dept_ID from Dept_Course where CID=@cid;
end try
begin catch
Select 'couldnt select all departments for this course'
end catch


go
create PROC select_all_courses_for_dept @did smallINT
as
begin try
select CID from Dept_Course where Dept_ID=@did;
end try
begin catch
Select 'couldnt select all courses for this department'
end catch


go
create Proc insert_dept_course @did smallint , @cid smallint  /* shouldnt this insert be in course*/
as 
begin try
insert into dept_Course values(@did, @cid)
end try
begin catch
select 'insert failed'
end catch


go
create Proc update_course_in_dept @cid smallint , @did smallint
as
begin try
update Dept_Course
set CID=@cid where dept_ID=@did
end try
begin catch
select 'update failed'
end catch


go
create Proc update_dept_for_course @cid smallint , @did smallint
as
begin try
update Dept_Course
set Dept_ID=@did where CID=@cid
end try
begin catch
select 'update failed'
end catch


go
create PROC delete_dept_course @cid smallINT
as
begin try
delete from dept_Course where CID=@cid;
end try
begin catch
Select 'couldnt delete course'
end catch


go
create PROC delete_dept_course2 @did smallINT
as
begin try
delete from dept_Course where dept_ID=@did;
end try
begin catch
Select 'couldnt delete department'
end catch


