use Examination_System

/*                                                                   Question                                                                */
/*								select                             */
go
create proc question_select
as
return select * from Question
/*							select by type                         */
go
create proc question_type_select(@type char(1))
as
return select * from Question where type=@type
/*					   	select by question                         */
go
create proc question_question_select(@Question varchar(200))
as
return select * from Question where Question=@Question
/*								insert                             */
go
create proc question_insert(@type char(1),@Question varchar(200),@Answer varchar(1))
as
insert into Question(type,Question,Answer) values (@type,@Question,@Answer)
return 
/*						  update type                             */
go
create proc question_type_update(@QID smallint,@type char(1))
as
update Question
set type=@type
where QID=@QID
return 
/*						 update question                          */
go
create proc question_question_update(@QID smallint,@Question varchar(200))
as
update Question
set Question=@Question
where QID=@QID
return 
/*		    		      update answer                          */
go
create proc question_answer_update(@QID smallint,@Answer varchar(1))
as
update Question
set Answer=@Answer
where QID=@QID
return 
/*							delete                             */
go
create proc question_delete(@QID smallint)
as
delete from Question 
where QID=@QID
return 




