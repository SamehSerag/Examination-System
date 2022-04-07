use Examination_System
------------------------------------------- Exam Table -------------------------------------------
--insert 
-- (Inserting Date / Description / Course_ID) To the Exam --> Exam ID is Auto generated
go
Create OR Alter Procedure Exam_Insert @Date date, @Desc varchar(15), @Course_ID smallint
AS
BEGIN TRY
	Insert into Exam (date, description, CID)
	Values (@Date, @Desc, @Course_ID)
END TRY

BEGIN CATCH
	SELECT 'Error, Data is incorrect (Maybe Course ID Does NOT EXIST)'
END CATCH
----------------
-- Trying Insert Procedure
execute Exam_Insert '2021-12-15', 'Description Of Exam', 2 --Error Data type ! Varchar to date
---------------------------------------------------------------------------------------------------------
-- Update
go
Create OR Alter procedure Exam_Update @id smallint, @date date, @Desc varchar(15), @Course_ID smallint
AS 
	BEGIN TRY
			UPDATE Exam
			Set date = @date, description = @Desc, CID = @Course_ID
			Where EID = @id --So Will update date / Description / Course ID based on the Exam ID
	END TRY
	BEGIN CATCH
		Select 'Error,  ID is invalid (NOT Exist)'
	END CATCH
----------------
-- Trying Update Procedure
execute Exam_Update 3, '2021-11-23', 'Final Exam',2

-----------------------------------------------------------------------
-- Delete
go
Create OR Alter  Procedure Exam_Delete @id int
AS 

if exists(select* from Exam where EID = @id)
	begin
		delete From Exam
		where EID = @id
	end
else
	select 'The ID is Incorrect or does NOT exist' AS 'Error'
----------------
-- Trying Delete Procedure
execute Exam_Delete 10
-----------------------------------------------------------------------
-- Select
go
Create OR Alter Procedure Exam_Select @id smallint
AS
Select* From Exam Where EID = @id


--Select All Exams
go
Create OR Alter PROCEDURE Exam_SelectAll
AS
Select *  from Exam 

----------------
-- Trying Select Procedure
execute Exam_Select 1
execute Exam_SelectAll



------------------------------------------- Student_course Table -------------------------------------------
--insert
go
Create OR Alter Procedure student_course_Insert @course_id smallint, @student_id smallint
AS
BEGIN TRY
	Insert into student_course (SID, CID)
	Values (@student_id, @course_id)
END TRY

BEGIN CATCH
	SELECT 'Error, Data is incorrect OR Duplicated (Maybe Course ID Does NOT exist OR Student ID is Invalid'
END CATCH
----------------
-- Trying Insert Procedure
execute student_course_Insert 2, 2
-----------------------------------------------------------------------
-- Update
go
Create OR Alter proc student_course_Update @course_id smallint, @student_id smallint
AS 
	BEGIN TRY
			UPDATE student_course
			Set SID = @student_id, CID = @course_id 
			Where SID = @student_id -- updating course ID to the student ID
	END TRY
	BEGIN CATCH
		Select 'Error,  ID is invalid (NOT Exist)'
	END CATCH
----------------
-- Trying Update Procedure
execute student_course_Update 2,5

-----------------------------------------------------------------------
-- Delete
-- Deleting the Student
go
Create OR Alter Procedure student_course_Delete @id smallint
AS 

if exists(select* from student_course where SID = @id)
	begin
		delete From student_course
		where SID = @id
	end
else
	select 'The Student ID does NOT exist'
----------------
-- Trying Delete Procedure
execute student_course_Delete 1
-----------------------------------------------------------------------
-- Select
go
Create OR Alter Procedure student_course_Select @id smallint
AS
Select * From student_course Where SID = @id

--Select All Student_Course
go
Create OR Alter PROCEDURE student_course_SelectALL
AS
Select *  from student_course
----------------
-- Trying Select Procedure
execute student_course_Select 3
execute student_course_SelectALL

------------------------------------------- Student_Exam Table -------------------------------------------
--insert
go
Create OR Alter proc Student_Exam_insert @Exam_id smallint, @Student_id smallint
AS 
		begin try
			insert into student_exam(EID, SID) 
			values (@Exam_id, @Student_id)
		end try
		begin catch
			select 'Exam ID or Student ID Duplicated or Incorrect'
		end catch
----------------
-- Trying Insert Procedure
go
Student_Exam_insert 6, 6
-----------------------------------------------------------------------
-- Update
go
Create OR Alter proc Student_Exam_update  @Student_id smallint, @Exam_id smallint
as 
if exists(select* from Student_exam where SID = @Student_id)
	begin
		begin try
			update Student_Exam
			set EID = @Exam_id
			where SID = @Student_id
		end try
		begin catch
			select 'Student Does NOT Exists'
		end catch
	end
else
	select 'Not Exists'
----------------
-- Trying Update Procedure
execute Student_Exam_update 2 , 8
-----------------------------------------------------------------------
-- Delete
go
Create OR Alter Procedure Student_Exam_delete @Student_id smallint
AS 
	begin
		delete From Student_Exam
		where SID = @Student_id
	end
----------------
-- Trying Delete Procedure
execute Student_Exam_delete 3
-----------------------------------------------------------------------
-- Select
go
Create OR Alter Procedure Student_Exam_Select @id smallint
AS
Select* From Student_Exam Where EID = @id

----------------
-- Trying Select Procedure
execute Student_Exam_Select 4




------------------------------------------- Student_Exam_Question Table -------------------------------------------
go
Create OR Alter Procedure student_exam_question_delete @Student_id smallint
AS 
	delete From student_exam_question
	where SID = @Student_id

----------------
-- Trying Delete Procedure

execute student_exam_question_delete 2
-----------------------------------------------------------------------
go
-- Select
Create OR Alter Procedure student_exam_question_Select @Student_id smallint
AS
Select * From student_exam_question Where SID = @Student_id

--Select All Student_Course
go
Create OR Alter PROCEDURE student_exam_question_SelectALL
AS
Select *  from student_exam_question
----------------
-- Trying Select Procedure
go
execute student_exam_question_Select 1
execute student_exam_question_SelectALL
