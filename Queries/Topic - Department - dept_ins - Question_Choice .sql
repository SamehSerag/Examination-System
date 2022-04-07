use Examination_System

------------------------------- Topic Table ---------------------------
------------------ Insert
go
create proc topic_insert @tp_n varchar(20), @CID int = null, @tpid smallint = null output 
WITH ENCRYPTION
as 
if not exists(select* from topic where Topic_Name =@tp_n and CID = @CID)
	begin
		begin try
			insert into topic (Topic_Name, CID) values (@tp_n,@CID)
			select @tpid=Topic_ID from topic where Topic_Name = @tp_n and CID = @CID
		end try
		begin catch
			select 'Course Not Exists'
		end catch
	end
else
	select 'Already Exists'


----------------- Update
go
create proc topic_update @tpid smallint, @tp_n varchar(20), @CID int = null 
WITH ENCRYPTION
as 
if exists(select* from topic where Topic_ID =@tpid)
	begin
		begin try
			update topic
			set Topic_Name = @tp_n , CID =@CID
			where Topic_ID = @tpid
		end try
		begin catch
			select 'Course Not Exists'
		end catch
	end
else
	select 'Not Exists'


---------------- Update topic name
go
create proc topic_update_tn @tpid smallint, @tp_n varchar(20)
WITH ENCRYPTION
as 
if exists(select* from topic where Topic_ID =@tpid)
	begin
		begin try
			update topic
			set Topic_Name = @tp_n
			where Topic_ID = @tpid
		end try
		begin catch
			select 'Error'
		end catch
	end
else
	select 'Not Exists'


------------------ Update topic course ID
go
create proc topic_update_cid @tpid smallint, @cid smallint
WITH ENCRYPTION
as 
if exists(select* from topic where Topic_ID =@tpid)
	begin
		begin try
			update topic
			set CID = @cid
			where Topic_ID = @tpid
		end try
		begin catch
			select 'Course Not Found'
		end catch
	end
else
	select 'Not Exists'


-------------- Delete
go
create proc topic_delete @tpid smallint
WITH ENCRYPTION
as 
if exists(select* from topic where Topic_ID =@tpid)
	begin
		delete topic
		where Topic_ID = @tpid
	end
else
	select 'Not Exists'

execute topic_delete 11 



---------------Select
go
create proc topic_select @tpid smallint
WITH ENCRYPTION
as 
select* from topic where Topic_ID =@tpid

go
execute topic_select 11 


------------------------------- Department Table ---------------------------
-- Insert
go
create proc department_insert @Did smallint, @dname varchar(20)
WITH ENCRYPTION
as 
if not exists(select* from department where Dept_ID = @Did)
	begin
		insert into department (Dname, Dept_ID) values (@dname,@Did)
	end
else
	select 'ID Already Exists'



--Update
go
create proc department_update @idToChange smallint, @Did smallint, @dname varchar(20)
WITH ENCRYPTION
as 
if exists(select* from department where Dept_ID =@idToChange)
	begin
		update department
		set Dname = @dname , Dept_ID =@Did
		where Dept_ID = @idToChange
	end
else
	select 'Not Exists'

execute department_update 5 ,8 ,'deptTest5'


----------Update department name
go
create proc department_update_dn @idToChange smallint, @dname varchar(20)
WITH ENCRYPTION
as 
if exists(select* from department where Dept_ID =@idToChange)
	begin
		update department
		set Dname = @dname
		where Dept_ID = @idToChange
	end
else
	select 'Not Exists'



-----------Update department id
go
create proc department_update_id @idToChange smallint, @Did smallint
WITH ENCRYPTION
as 
if exists(select* from department where Dept_ID =@idToChange)
	begin
		update department
		set Dept_ID =@Did
		where Dept_ID = @idToChange
	end
else
	select 'Not Exists'



---------------------Delete
go
create proc department_delete @idToDelete smallint
WITH ENCRYPTION
as 
if exists(select* from department where Dept_ID =@idToDelete)
	begin
		delete department
		where Dept_ID = @idToDelete
	end
else
	select 'Not Exists'

---------Select
go
alter proc department_select @id smallint
WITH ENCRYPTION
as 
select * from department
where Dept_ID = @id



------------------------------- dept_ins Table ---------------------------
--insert
go
create proc dept_ins_insert  @did smallint, @inId smallint
WITH ENCRYPTION
as 
if not exists(select* from dept_ins where Ins_ID = @inId)
	begin
		begin try
			insert into dept_ins (Dept_ID, Ins_ID) values (@did,@inId)
		end try
		begin catch
			select 'Department or Instructor Not Found'
		end catch
	end
else
	select 'ID Already Exists'



------------ Update department ID
go
create proc dept_ins_update  @inId smallint, @did smallint
WITH ENCRYPTION
as 
if exists(select* from dept_ins where Ins_ID = @inId)
	begin
		begin try
			update dept_ins
			set Dept_ID =@did
			where Ins_ID = @inId
		end try
		begin catch
			select 'Department Not Exists'
		end catch
	end
else
	select 'Not Exists'

execute dept_ins_update 5 , 2

---------------- Update dept_ins instructor id
go
create proc dept_ins_update_inID  @idToChange smallint, @inId smallint
WITH ENCRYPTION
as 
if exists(select* from dept_ins where Ins_ID = @idToChange)
	begin
		begin try
			update dept_ins
			set Ins_ID =@inId
			where Ins_ID = @idToChange
		end try
		begin catch
			select 'Instructor Not Exists'
		end catch
	end
else
	select 'Not Exists'


------------------------Delete
go
create proc dept_ins_delete @idToDelete smallint
WITH ENCRYPTION
as 
if exists(select* from dept_ins where Ins_ID = @idToDelete)
	begin
		delete dept_ins
		where Ins_ID = @idToDelete
	end
else
	select 'Not Exists'

execute dept_ins_delete 5

--Select
go
create proc dept_ins_select @id smallint
WITH ENCRYPTION
as 
select * from dept_ins
where Ins_ID = @id


------------------------------- Question_choice Table ---------------------------
--insert
go
create proc Question_choice_insert @QID int,@choiceChar char(1) ,@choice varchar(200)
WITH ENCRYPTION
as 
if not exists(select* from Question_choice where QID = @QID and Choice = @choice and ChoiceChar = @choiceChar)
	begin
		begin try
			insert into Question_choice (QID, ChoiceChar ,Choice) values (@QID,@choiceChar ,@choice)
		end try
		begin catch
			select 'Duplication Choice'
		end catch
	end
else
	select 'Already Exists'

go



--delete
go
create proc Question_choice_delete @Qid smallint, @choice varchar(200)
WITH ENCRYPTION
as 
if exists(select* from Question_choice where QID =@Qid and TRIM(Choice) = TRIM(@choice))
	begin
		delete Question_choice
		where QID = @Qid and TRIM(Choice) = TRIM(@choice)
	end
else
	select 'Not Exists'

go
execute Question_choice_delete 30, 'teSt '

--Update
go
create proc Question_choice_update @Qid smallint, @choice varchar(200), @newchoice varchar(200) 
WITH ENCRYPTION
as 
if exists(select* from Question_choice where QID =@Qid and TRIM(Choice) = TRIM(@choice))
	begin
		begin try
			update Question_choice
			set Choice = TRIM (@newchoice)
			where QID = @Qid and TRIM(Choice) = TRIM(@choice)
		end try
		begin catch
			select 'Choice Already Exits'
		end catch
	end
else
	select 'Not Exists'

go


-----------------select
go
create proc Question_choice_select @id smallint
WITH ENCRYPTION
as 
select * from Question_choice
where QID = @id

execute Question_choice_select 30

select * from Question_choice
where QID = 30