delete from Student
DBCC CHECKIDENT(Student, RESEED, 0)

delete from Enrollment
DBCC CHECKIDENT(Enrollment, RESEED, 0)

delete from OfficeAssignment

delete from CourseAssignment

delete from Course

delete from Department
DBCC CHECKIDENT(Department, RESEED, 0)

delete from Instructor
DBCC CHECKIDENT(Instructor, RESEED, 0)
