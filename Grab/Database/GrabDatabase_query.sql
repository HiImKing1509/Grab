use Grab
go

-- Query
---- Select all Transport services in grab application
select * from GRAB_TRANSPORT
go
---- Select all Delivery services in grab application
select * from GRAB_DELIVERY
go
---- Select all services category in grab application
select * from GRAB_CATEGORY
go

-- Select all Provinces
select * from PROVINCES
go

-- Select all Districts
select * from DISTRICTS
go

-- Select all Wards
select * from WARDS
go

-- Join Location
SELECT
  PROVINCES.PROVINCES_NAME,
  DISTRICTS.DISTRICTS_NAME,
  WARDS.WARDS_NAME
FROM PROVINCES
JOIN DISTRICTS
  ON PROVINCES.PROVINCES_ID = DISTRICTS.student_id
JOIN course
  ON course.id = student_course.course_id;