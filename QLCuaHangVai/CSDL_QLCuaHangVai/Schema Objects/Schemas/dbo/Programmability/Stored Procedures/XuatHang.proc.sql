create proc XuatHang
	@Ma nchar(10),@SoLuong int
as
	update SanPham set SoLuong = SoLuong - @SoLuong where MaHH = @Ma
