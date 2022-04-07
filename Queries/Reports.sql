----1----
create proc all_dept_studes @dept_id smallint
as
select Stud_ID, Stud_Name, Stud_username from student 
where Dept_ID=@dept_id
go
all_dept_studes 1
----------------------------------------------------------
----2-----
go
create proc student_grades @sid smallint
as
select Stud_ID, Stud_Name, course_name, Grade 
from student inner join Student_exam on Student_exam.SID=student.Stud_ID inner join exam on 
exam.EID=Student_exam.EID inner join course on course.CID=exam.CID
where Stud_ID=@sid

go
student_grades 3

----------------------------------------------------------

----3----- 
go
alter proc ins_course @ins_id smallint
as
select instructor.Ins_ID , Course.Course_Name , count(student_course.SID) as Count
from 
instructor inner join Course on course.Ins_ID=instructor.Ins_ID 
left outer join
student_course on student_course.CID =Course.CID 
where instructor.Ins_ID= @ins_id
group by  Course.Course_Name, instructor.Ins_ID


go
ins_course 2

----------------------------------------------------------

---4---
go
create proc course_topics @cid smallint
as
select course.Course_Name, topic.Topic_Name
from Course inner join topic on topic.CID=Course.CID
where course.CID=@cid

go
course_topics 1

----------------------------------------------------------

---5---
go
alter function  GetChoices(@QI smallint)
returns nvarchar(max)
begin
declare @choices varchar(max) =' '

if( (select type from Question where QID=@QI) = 'b')
set @choices = 'T/F'
else
select @choices += ChoiceChar+') '+ Choice+ CHAR(13)+CHAR(10) + ' '
from Question_choice 
where QID=@QI

return @choices 	
end 

go
alter proc exam_questions_choices @eid smallint
as
select q.Question, dbo.GetChoices(q.QID) as [Choices]
from Question q, Question_Exam qe
where qe.EID = @eid and q.QID = qe.QID


exam_questions_choices 153



----------------------------------------------------------

---6---

go
alter proc student_answers_in_exam @eid smallint, @sid smallint
as
select q.Question, qc.Choice as [Model Answer], 
		(
			select qc2.Choice
			from Question_choice qc2
			where seq.answers = qc2.ChoiceChar and 
					qc2.QID = q.QID and
					seq.EID = @eid and
					seq.SID = @sid

		) as [Student Answer]
from student_exam_question seq, Question q , Question_choice qc
where seq.EID = @eid and
	  seq.SID = @sid and
	  seq.QID = q.QID and
	  q.QID = qc.QID and
	  qc.ChoiceChar = q.Answer
union 
select q.Question, 
	Case q.Answer
		when 'a' then 'True'
		when 'b' then 'False'
	End as [Model Answer],
	Case seq.answers
		when 'a' then 'True'
		when 'b' then 'False'
	End as [Student Answer]

from student_exam_question seq, Question q 
where seq.EID = @eid and
	  seq.QID = q.QID and
	  seq.SID = @sid and
	  q.type = 'b'
	  
go
student_answers_in_exam 9,1


