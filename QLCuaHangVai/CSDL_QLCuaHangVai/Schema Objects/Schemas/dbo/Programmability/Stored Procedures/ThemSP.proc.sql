create proc ThemSP
	@MaHH nchar(10), @TenHH nvarchar(50), @LoaiHH nvarchar(50), @Mau nchar(10), @SoLuong int, @DonGia float
as
	insert SanPham VALUES (@MaHH,@TenHH,@LoaiHH,@Mau,@SoLuong,@DonGia)
