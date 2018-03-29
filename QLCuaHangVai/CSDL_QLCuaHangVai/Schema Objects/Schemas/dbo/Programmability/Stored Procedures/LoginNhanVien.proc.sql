create proc LoginNhanVien 
	@ID nchar(20)
as
	select Pass from NhanVien where ID = @ID
