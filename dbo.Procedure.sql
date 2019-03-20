CREATE PROCEDURE sproc_tblBook_FilterByBookId
--parameter to store the BookId we are looking for 
  @BookId int
	
AS 
-- select all field from table where the BookId matches the parameter data
	SELECT * from tblBook  where BookId = @BookId

RETURN 0
