create proc getGioCong
	@ID nchar(20)
as
	select GioLuong from NhanVien where ID = @ID
