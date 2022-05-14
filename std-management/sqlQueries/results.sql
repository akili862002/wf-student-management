DECLARE @cols AS NVARCHAR(MAX),
    @query  AS NVARCHAR(MAX)

select @cols = STUFF((SELECT ',' + QUOTENAME(label) 
                    from course
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)') 
        ,1,1,'')

PRINT @cols

set @query = N'SELECT student_code, first_name, last_name, ' + @cols + N', Result
FROM 
(
	SELECT student_code, course_id, label, student_score, first_name, last_name
	FROM (
		score
		JOIN students ON score.student_code = students.code 
		JOIN course ON score.course_id = course.id
	)
) a
 JOIN 
(
	SELECT student_code as std_code, AVG(student_score) as Result
	FROM (
		score
		JOIN students ON score.student_code = students.code 
		JOIN course ON score.course_id = course.id
	)
	GROUP BY student_code, first_name, last_name
) b
ON (a.student_code = b.std_code)
PIVOT 
(AVG(student_score) FOR label IN (' + @cols + N')) as subjects'
exec sp_executesql @query;
