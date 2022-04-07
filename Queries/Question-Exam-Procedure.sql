use Examination_System

/*                                                       Question Exam                                                            */
/*								select                             */
go
create proc question_exam_select(@EID smallint)
as
return select QID
from Question_Exam
where EID=@EID
/*						select Exam Questions                     */
go
create proc question_exam_questions_select(@EID smallint)
as
return select Q.QID,Q.type,Q.Question,Q.Answer
from Question_Exam QE,Question Q
where QE.EID=@EID
/*						select Model Answers                     */
return select Q.QID,Q.Answer
from Question_Exam QE,Question Q
where QE.EID=@EID
/*                           delete exam                         */
go
create proc question_exam_delete (@EID smallint)
as
delete from Question_Exam where  EID=@EID
return
/*                           delete a question                         */
go
create proc question_exam_question_delete (@QID smallint)
as
delete from Question_Exam where  QID=@QID
return
