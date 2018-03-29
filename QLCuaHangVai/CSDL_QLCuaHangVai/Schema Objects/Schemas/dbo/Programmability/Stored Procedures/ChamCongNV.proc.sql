create proc ChamCongNV
	@ID nchar(20), @giaTriMoi real
as
	update NhanVien
	set GioLuong = @giaTriMoi
	where ID = @ID
