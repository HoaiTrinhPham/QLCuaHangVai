create proc LoginQuanLy 
	@ID nchar(20)
as
	select Pass from QuanLy where ID = @ID
