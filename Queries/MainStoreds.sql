use Examination_System
-- a				b
-- @MCQNum = 5, @TFNum = 5
go
alter proc Exam_generation @cname varchar(20), @MCQNum tinyint, @TFNum tinyint
as
	declare @CID smallint = (select CID from Course where Course_Name = @cname)
	declare @EID smallint

	insert into Exam 
	values(getdate() ,'Final', @CID)
	set @EID=SCOPE_IDENTITY()
	
insert into Question_Exam
	select top(@MCQNum) QID , @EID
	from Question 
	where type = 'a' and CID = @CID
	order by NEWID()

insert into Question_Exam
	select top(@TFNum) QID , @EID
	from Question 
	where type = 'b' and CID = @CID
	order by NEWID()

	select @EID as EID



execute Exam_generation 'C#', 7, 3
--______________________________________________________________________________________--
go
alter proc Exam_Answers @EID smallint , @SID smallint, @ans1 varchar(1),
	 @ans2 varchar(1), @ans3 varchar(1), @ans4 varchar(1),
	 @ans5 varchar(1), @ans6 varchar(1), @ans7 varchar(1),
	 @ans8 varchar(1), @ans9 varchar(1), @ans10 varchar(1)
 as
 declare @QuestionsID table(q smallint)
 
 insert into @QuestionsID
 select QID from Question_Exam where EID = @EID


declare s_cur cursor
	for Select QID
		  from Question_Exam where EID =  @EID
	for read only

declare @qid smallint
open s_cur 
select @qid
fetch s_cur into @qid
insert into student_exam_question values (@SID,@EID,@qid, @ans1)
fetch s_cur into @qid
insert into student_exam_question values (@SID,@EID,@qid, @ans2)
fetch s_cur into @qid
insert into student_exam_question values (@SID,@EID,@qid, @ans3)
fetch s_cur into @qid
insert into student_exam_question values (@SID,@EID,@qid, @ans4)
fetch s_cur into @qid						
insert into student_exam_question values (@SID,@EID,@qid, @ans5)
fetch s_cur into @qid
insert into student_exam_question values (@SID,@EID,@qid, @ans6)
fetch s_cur into @qid
insert into student_exam_question values (@SID,@EID,@qid, @ans7)
fetch s_cur into @qid
insert into student_exam_question values (@SID,@EID,@qid,@ans8)
fetch s_cur into @qid
insert into student_exam_question values (@SID,@EID,@qid,@ans9)
fetch s_cur into @qid
insert into student_exam_question values (@SID,@EID,@qid,@ans10)
close s_cur
deallocate s_cur

insert into [dbo].[Student_exam] (EID, SID) values(@EID, @SID)

exec Exam_Correction @EID, @SID

go
execute Exam_Answers 109,1,'a','a','a','a','a','a','a','a','a','a'
--______________________________________________________________________________
go
alter proc Exam_Correction @EID smallint, @SID smallint
as
	declare @rightMCQ tinyint
	select @rightMCQ= COUNT(*) 
	from [dbo].[student_exam_question] seq ,[dbo].[Question] q
	where seq.SID = @SID and seq.EID = @EID
			 and seq.QID = q.QID and q.type = 'a' 
			 and seq.answers = q.Answer

	--select @rightMCQ

	declare @rightTF tinyint
	select @rightTF= COUNT(*) 
	from [dbo].[student_exam_question] seq ,[dbo].[Question] q
	where seq.SID = @SID and seq.EID = @EID
			 and seq.QID = q.QID and q.type = 'b' 
			 and seq.answers = q.Answer

	--select @rightTF

	update [dbo].[Student_exam]
	set grade = (@rightTF+@rightMCQ) 
	where SID = @SID and EID = @EID




exec Exam_Correction 109, 1

--______________________________________________________________________________________________

------------------ Additional For Desctop APP --------------
go
alter proc Student_Login (@username varchar(20), @password varchar(20))
as
select * from student 
where Stud_username = @username and Stud_Password = @password
----------------------------------------------------

go
alter proc Instructor_Login (@username varchar(20), @password varchar(20))
as
select * from instructor 
where Ins_Username = @username and Ins_password = @password

----------------------------------------------------


go
create proc Select_Exam (@Eid smallint)
as
	select q.QID, q.Question , c.Choice
	from Question_Exam e, Question q, Question_choice c
	where EID = 109 and q.QID = e.QID and c.QID =q.QID and q.type = 'a'
	union 
	select q.QID, q.Question , 'True'
	from Question_Exam e, Question q
	where EID = 109 and q.QID = e.QID and q.type = 'b'
	union 
	select q.QID, q.Question , 'False'
	from Question_Exam e, Question q
	where EID = 109 and q.QID = e.QID and q.type = 'b'

Select_Exam 109

--_______________________________________________________________________________________

go
create proc Select_Courses (@Sid smallint)
as
	select c.CID, c.Course_Name
	from student s, department d, Dept_Course dc, Course c
	where s.Dept_ID = d.Dept_ID and 
		  d.Dept_ID = dc.Dept_ID and 
		 dc.CID = c.CID and  s.Stud_ID = @Sid
		 and c.CID not in (select e.CID
								from Student_exam se, Exam e
								where se.SID = @Sid and se.EID = e.EID
								)

go
Select_Courses 4

--_________________________________________________________________
go
create proc SelectStudentGrades (@SID smallint)
as
	select c.Course_Name as Course , se.grade as Grade
	from[dbo].[Student_exam] se, [dbo].[Exam] e,[dbo].[Course] c
	where se.SID = @SID and se.EID = e.EID and e.CID = c.CID

go
exec SelectStudentGrades 3

--_________________________________________________________________

go
alter proc SelectInstCourses(@Iid smallint)
as
	select c.CID , c.Course_Name
	from Course c, instructor i
	where c.Ins_ID = i.Ins_ID and i.Ins_ID = @Iid

go
exec SelectInstCourses 2

























