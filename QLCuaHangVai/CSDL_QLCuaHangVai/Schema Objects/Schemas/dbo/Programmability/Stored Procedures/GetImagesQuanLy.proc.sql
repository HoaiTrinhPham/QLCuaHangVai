
Create PROC GetImagesQuanLy
		@ID nchar(10)
as
	select AnhDaiDien from QuanLy where ID = @ID
