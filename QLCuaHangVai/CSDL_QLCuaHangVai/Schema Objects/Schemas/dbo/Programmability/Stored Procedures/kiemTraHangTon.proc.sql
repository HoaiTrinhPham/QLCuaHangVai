
create proc kiemTraHangTon
	@Ma char(10)
as
	select * from SanPham where MaHH =@Ma
