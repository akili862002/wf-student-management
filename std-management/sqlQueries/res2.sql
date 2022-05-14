DECLARE @cols AS NVARCHAR(MAX),
@rounded_cols AS NVARCHAR(MAX),
@query  AS NVARCHAR(MAX)

select @cols = STUFF((SELECT ',' + QUOTENAME(id) from course FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'')
select @rounded_cols = STUFF((SELECT ', ROUND(' + QUOTENAME(id) + ', 3) AS ' + QUOTENAME(label) from course FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,1,'')

set @query = N'SELECT student_code, first_name, last_name, ' + @rounded_cols + N', ROUND(avg_score, 2) as [Avg score], result
FROM (
SELECT student_code, course_id, student_score, first_name, last_name
FROM (score JOIN students ON score.student_code = students.code  JOIN course ON score.course_id = course.id)
) a
JOIN (
SELECT student_code as std_code, AVG(student_score) avg_score, CASE WHEN  AVG(student_score) >= 5 THEN ''Pass'' ELSE ''Fail'' END AS result
FROM (score JOIN students ON score.student_code = students.code JOIN course ON score.course_id = course.id) GROUP BY student_code, first_name, last_name
) b
ON (a.student_code = b.std_code)
PIVOT 
(AVG(student_score) FOR course_id IN (' + @cols + N')) as subjects
WHERE 1 = 1 '
exec sp_executesql @query;


SELECT COUNT(*)
FROM (
	SELECT student_code as std_code, AVG(student_score) avg_score, COUNT(student_code) as total
	FROM (score JOIN students ON score.student_code = students.code JOIN course ON score.course_id = course.id) GROUP BY student_code, first_name, last_name
) a
WHERE a.avg_score >= 5

SELECT COUNT(*)
FROM students