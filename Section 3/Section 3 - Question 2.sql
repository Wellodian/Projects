--BEGIN TRAN


CREATE TABLE dbo.Students (
	StudentNumber	INT				NOT NULL	IDENTITY(1,1),
	Name			VARCHAR(100)	NOT NULL

    -- Primary key
    CONSTRAINT XPKStudents
        PRIMARY KEY CLUSTERED (StudentNumber) ON [PRIMARY]

)


CREATE TABLE dbo.Courses (
	CourseNumber	INT				NOT NULL	IDENTITY(1,1),
	Name			VARCHAR(200)	NOT NULL

    -- Primary key
    CONSTRAINT XPKCourses
        PRIMARY KEY CLUSTERED (CourseNumber) ON [PRIMARY]

)

CREATE TABLE dbo.StudentCourses (
	StudentCourseID	INT			NOT NULL	IDENTITY(1,1),
	StudentNumber	INT			NOT NULL,
	CourseNumber	INT			NOT NULL
	
    -- Primary key
    CONSTRAINT XPKStudentCourses
        PRIMARY KEY CLUSTERED (StudentCourseID) ON [PRIMARY],

    -- Unique key
	CONSTRAINT XAK1StudentCourses
        UNIQUE NONCLUSTERED (StudentNumber, CourseNumber) ON [INDX],  

    -- Foreign key(s)
    CONSTRAINT IFStudent
        FOREIGN KEY (StudentNumber)
        REFERENCES dbo.Students (StudentNumber),

    -- Foreign key(s)
    CONSTRAINT IFCourse
        FOREIGN KEY (CourseNumber)
        REFERENCES dbo.Courses (CourseNumber)
)

CREATE TABLE dbo.Tests (
	TestID			INT			NOT NULL	IDENTITY(1,1),
	StudentCourseID	INT			NOT NULL, -- a student must be enrolled in a course to receive a test mark for that course
	[Date]			DATETIME	NOT NULL,
	Mark			INT			NOT NULL -- Assuming the marks are whole numbers :)
	
    -- Primary key
    CONSTRAINT XPKTests
        PRIMARY KEY CLUSTERED (TestID) ON [PRIMARY],

    -- Unique key
	CONSTRAINT XAK1Tests
        UNIQUE NONCLUSTERED (StudentCourseID, [Date]) ON [INDX],  -- Assuming that a student can't have multiple tests for the same course in a day, otherwise won't be required.

    -- Foreign key(s)
    CONSTRAINT IFStudentCourses
        FOREIGN KEY (StudentCourseID)
        REFERENCES dbo.StudentCourses (StudentCourseID)
)


--ROLLBACK TRAN
-- COMMIT TRAN
