create proc TTMotNhanVien
	@ID nvarchar(20)
as
	select * from NhanVien where ID = @ID
