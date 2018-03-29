
Create PROC GetImagesNhanVien
		@ID nchar(10)
as
	select AnhDaiDien from NhanVien where ID = @ID
