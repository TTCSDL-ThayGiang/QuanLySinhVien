Create database Quan_ly_sinh_vien
Use Quan_ly_sinh_vien
Create table Phan_quyen(
	Ma_phan_quyen char(10) Primary key,
	Ten_phan_quyen nvarchar(50),
	Mo_ta nvarchar(50)
)
Create table Nguoi_dung(
	Id_user char(10)Primary key,
	Username varchar(20) not null,
	Pass varchar(20) not null,
	Ma_phan_quyen char(10) References Phan_quyen(Ma_phan_quyen)
)
Create table Khoa(
	Ma_khoa char (10) Primary key,
	Ten_khoa nvarchar(50),
	Ma_cnkhoa char(10)
)
Create table Giao_vien(
	Ma_giao_vien char(10) Primary key,
	Ten_giao_vien nvarchar(50),
	Gioi_tinh bit,
	Hoc_vi nvarchar(30),
	Dia_chi nvarchar(50),
	Ma_khoa char(10) References Khoa(Ma_khoa)
)
Create table Lop(
	Ma_lop char(10) Primary key,
	Ten_lop nvarchar(50),
	Ma_khoa char(10) References Khoa(Ma_khoa),
	Ma_giaoviencn char(10) References Giao_vien(Ma_giao_vien)
)
Create table Hoc_ky(
	Ma_hoc_ky char(10) Primary key,
	Ten_hoc_ky nvarchar(30),
	Thoi_gian_bat_dau date,
	Thoi_gian_ket_thuc date,
	Ma_lop char(10) References Lop(Ma_lop)
)
Create table Hoc_phan(
	Ma_hoc_phan char(10) Primary key,
	Ten_hoc_phan nvarchar(30),
	So_tin_chi int,
	Ma_hoc_ky char(10) References Hoc_ky(Ma_hoc_ky)
)
Create table Lop_hoc_phan(
	Ma_lop_hoc_phan char(10) Primary key,
	Ma_hoc_phan char(10) References Hoc_phan(Ma_hoc_phan),
	Ma_giao_vien char(10) References Giao_vien(Ma_giao_vien),
	So_sv_toi_da int,
	Ngay_bat_dau date,
	Thoi_gian_hoc nvarchar(50),
	Giang_duong nvarchar(20),
	Ngay_ket_thuc date,
	Ngay_thi date,
	Hinh_thuc_thi nvarchar(30)
)
Create table Sinh_vien(
	Ma_sinh_vien char(10) Primary key,
	Ten_sinh_vien nvarchar(50),
	Ngay_sinh date,
	Gioi_tinh bit,
	Dia_chi nvarchar(50),
	Ma_lop char(10) References Lop(Ma_lop)
)
Create table Bang_diem(
	Ma_sinh_vien char(10) References Sinh_vien(Ma_sinh_vien),
	Ma_hoc_phan char(10) References Hoc_phan(Ma_hoc_phan),
	Diem_chuyen_can int,
	Diem_thuong_xuyen int,
	Diem_cuoi_ky int,
	Constraint SV_HP Primary key(Ma_sinh_vien,Ma_hoc_phan)
)
Create table Phieu_dang_ky(
	Ma_phieu char(10) Primary key,
	Ma_sinh_vien char(10) References Sinh_vien(Ma_sinh_vien),
	Ma_lop_hoc_phan char(10),
	Lan_dang_ky int
)
----------------------------
Create proc Them_khoa(@Ma_khoa char(10),@Ten_khoa nvarchar(50),@Ma_cnkhoa char(10))
as
Begin tran
	if not exists (select Ma_khoa from Khoa where Ma_khoa=@Ma_khoa)
		Begin
		Insert into Khoa(Ma_khoa,Ten_khoa,Ma_cnkhoa)
		Values(@Ma_khoa,@Ten_khoa,@Ma_cnkhoa)
		Commit tran
		End
	else
		Begin
		Print 'MA KHOA DA TON TAI !'
		Rollback tran
		End
Return
---
Exec Them_khoa 'K08','KHOA 8','GV020'
---
Create proc suakhoa(@Ma_khoa char(10),@Ten_khoa nvarchar(50),@Ma_cnkhoa char(10))
as
Begin tran
	if exists (select Ma_khoa from Khoa where Ma_khoa=@Ma_khoa)
		Begin
		Update Khoa
		Set Ten_khoa=@Ten_khoa,Ma_cnkhoa=@Ma_cnkhoa
		Where Ma_khoa=@Ma_khoa
		Commit tran
		End
	else
		Begin
		Print 'MA KHOA KHONG TON TAI !'
		Rollback tran
		End
Return
---
Create proc Them_giao_vien(@Ma_gv char(10),@Ten_gv nvarchar(50),@Gioi_tinh bit,@Hoc_vi nchar(30),@Dia_chi nvarchar(50),@Ma_khoa char(10))
as
Begin tran
	if not exists (select Ma_giao_vien from Giao_vien where Ma_giao_vien=@Ma_gv)
	Begin
		if exists (select Ma_khoa from Khoa where Ma_khoa=@Ma_khoa)
			Begin
			Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
			Values(@Ma_gv,@Ten_gv,@Gioi_tinh,@Hoc_vi,@Dia_chi,@Ma_khoa)
			End
		else
			Begin
			Print 'MAKHOA KHONG TON TAI!'
			Rollback tran
			End
	End
	else
		Begin
		Print 'MA GIAO VIEN DA TON TAI!'
		Rollback tran
		End
Return
---
Exec Them_giao_vien 'GV026', 'Nguyễn Văn Bình','0','Hà Nội','K04'
---
Create proc Them_sinh_vien(@Ma_sinh_vien char(10),@Ten_sinh_vien nvarchar(50),@Ngay_sinh date,@Gioi_tinh bit,@Dia_chi nvarchar(50),@Ma_lop char(10))
as
Begin tran
	if not exists (select Ma_sinh_vien from Sinh_vien where Ma_sinh_vien=@Ma_sinh_vien)
		Begin
		Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
		Values(@Ma_sinh_vien,@Ten_sinh_vien,@Ngay_sinh,@Gioi_tinh,@Dia_chi,@Ma_lop)
		Commit tran
		End
	else
		Begin
		Print 'MA SINH VIEN DA TON TAI !'
		Rollback tran
		End
Return
---
Create proc Sua_sinh_vien(@Ma_sinh_vien char(10),@Ten_sinh_vien nvarchar(50),@Ngay_sinh date,@Gioi_tinh bit,@Dia_chi nvarchar(50),@Ma_lop char(10))
as
Begin tran
	if exists (select Ma_sinh_vien from Sinh_vien where Ma_sinh_vien=@Ma_sinh_vien)
		Begin
		Update Sinh_vien
		Set Ten_sinh_vien=@Ten_sinh_vien,Ngay_sinh=@Ngay_sinh,Gioi_tinh=@Gioi_tinh,Dia_chi=@Dia_chi,Ma_lop=@Ma_lop
		Where Ma_sinh_vien=@Ma_sinh_vien
		Commit tran
		End
	else
		Begin
		Print 'MA SINH VIEN KHONG TON TAI !'
		Rollback tran
		End
Return
---
Create proc Xoa_sinh_vien(@Ma_sinh_vien char(10))
as
Begin tran
	if exists (select Ma_sinh_vien FROM Sinh_vien where Ma_sinh_vien=@Ma_sinh_vien)
		Begin
		Delete from Bang_diem where(Ma_sinh_vien=@Ma_sinh_vien)
		Delete from Phieu_dang_ky where(Ma_sinh_vien=@Ma_sinh_vien)
		Delete from Sinh_vien where(Ma_sinh_vien=@Ma_sinh_vien)
		Commit tran
		End
	else
		Begin
		Print 'KHONG TON TAI MASV NAY !'
		Rollback tran
		End
Return
---
Create proc Them_bang_diem(@Ma_sinh_vien char(10),@Ma_hoc_phan char(10),@Diem1 int,@Diem2 int,@Diem3 int)
as
Begin tran
	if not exists (select Ma_sinh_vien from Bang_diem where Ma_sinh_vien=@Ma_sinh_vien)
		Begin
		Insert into Bang_diem(Ma_sinh_vien,Ma_hoc_phan,Diem_chuyen_can,Diem_thuong_xuyen,Diem_cuoi_ky)
		Values(@Ma_sinh_vien,@Ma_hoc_phan,@Diem1,@Diem2,@Diem3)
		Commit tran
		end
	else
		Begin
		Print 'MA SINH VIEN DA TON TAI !'
		Rollback tran
		End
Return
---
Create proc Sua_bang_diem(@Ma_sinh_vien char(10),@Ma_hoc_phan char(10),@Diem1 int,@Diem2 int,@Diem3 int)
as
Begin tran
	if exists (select Ma_sinh_vien from Bang_diem where Ma_sinh_vien=@Ma_sinh_vien)
		Begin
		Update Bang_diem
		Set Ma_hoc_phan=@Ma_hoc_phan,Diem_chuyen_can=@Diem1,Diem_thuong_xuyen=@Diem2,Diem_cuoi_ky=@Diem3
		Where Ma_sinh_vien=@Ma_sinh_vien 
		Commit tran
		End
	else
		Begin
		Print 'MA SINH VIEN KHONG TON TAI !'
		Rollback tran
		End
Return
---
Create proc Xoa_bang_diem(@Ma_sinh_vien char(10))
as
Begin tran
	if exists (select Ma_sinh_vien from Bang_diem where Ma_sinh_vien=@Ma_sinh_vien)
		Begin
		Delete Bang_diem where(Ma_sinh_vien=@Ma_sinh_vien)
		Commit tran
		End
	else
		Begin	
		Print 'KHONG TON TAI MASV NAY !'
		Rollback tran
		End
Return
--
Create proc Them_nguoi_dung(@Id char(10),@Username char(20),@Pass char(20),@Ma_phan_quyen char(10))
as
Begin tran
	if not exists (select Id_user from Nguoi_dung where Id_user=@Id)
		Begin
		Insert into Nguoi_dung(Id_user,Username,Pass,Ma_phan_quyen)
		Values(@Id,@Username,@Pass,@Ma_phan_quyen)
		Commit tran
		End
	else
		Begin
		Print 'DA TON TAI ID NGUOI DUNG!'
		Rollback tran
		End
Return
--
Create proc Sua_thong_tin_nguoi_dung(@Id char(10),@Username char(20),@Pass char(20),@Ma_phan_quyen char(10))
as
Begin tran
	if exists (select Id_user from Nguoi_dung where Id_user=@Id)
		Begin
		Update Nguoi_dung
		Set Username=@Username,Pass=@Pass,Ma_phan_quyen=@Ma_phan_quyen
		Where Id_user=@Id
		Commit tran
		End
	else
		Begin
		Print 'KHONG TON TON TAI ID NGUOI DUNG!'
		Rollback tran
		End
Return
--
Create proc Xoa_nguoi_dung(@Id char(10))
as
Begin tran
	if exists (select Id_user from Nguoi_dung where Id_user=@Id)
		Begin
		Delete Nguoi_dung where Id_user=@Id
		Commit tran
		End
	else
		Begin
		Print 'KHONG TON TON TAI ID NGUOI DUNG!'
		Rollback tran
		End
Return
--
Create proc Them_lop(@Ma_lop char(10),@Ten_lop nvarchar(50),@Ma_khoa char(10),@Ma_gvcn char(10))
as
Begin tran
	if not exists (select Ma_lop from Lop where Ma_lop=@Ma_lop)
	Begin
		if exists (select Ma_khoa from Khoa where Ma_khoa=@Ma_khoa)
		Begin
			Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)
			Values(@Ma_lop,@Ten_lop,@Ma_khoa,@Ma_gvcn)
			Commit tran
		End
		else
			Begin
			Print'KHONG TON TAI MA KHOA!'
			Rollback tran
			End
	End
	else
	Begin
	Print'DA TON TAI MA LOP!'
	Rollback tran
	End
Return
--
Create proc Sua_lop(@Ma_lop char(10),@Ten_lop nvarchar(50),@Ma_khoa char(10),@Ma_gvcn char(10))
as
Begin tran
	if exists (select Ma_lop from Lop where Ma_lop=@Ma_lop)
	Begin
		if exists (select Ma_khoa from Khoa where Ma_khoa=@Ma_khoa)
		Begin
			Update Lop
			Set Ten_lop=@Ten_lop,Ma_khoa=@Ma_khoa,Ma_giaoviencn=@Ma_gvcn
			where Ma_lop=@Ma_lop
			Commit tran
		End
		else
			Begin
			Print'KHONG TON TAI MA KHOA!'
			Rollback tran
			End
	End
	else
	Begin
	Print'KHONG TON TAI MA LOP!'
	Rollback tran
	End
Return
--
Create proc Xoa_lop(@Ma_lop char(10))
as
Begin tran
	if exists (select Ma_lop from Lop where Ma_lop=@Ma_lop)
		Begin
		Delete Sinh_vien where Ma_lop=@Ma_lop
		Delete Lop where Ma_lop=@Ma_lop
		Commit tran
	End
	else
		Begin
		Print'KHONG TON TAI MA LOP!'
		Rollback tran
		End
Return
--
Insert into Khoa(Ma_khoa,Ten_khoa,Ma_cnkhoa) Values('K01',N'Công nghệ thông tin','GV001')
Insert into Khoa(Ma_khoa,Ten_khoa,Ma_cnkhoa) Values('K02',N'Vô tuyến điện tử','GV002')
Insert into Khoa(Ma_khoa,Ten_khoa,Ma_cnkhoa) Values('K03',N'Hóa lý kĩ thuật','GV003')
Insert into Khoa(Ma_khoa,Ten_khoa,Ma_cnkhoa) Values('K04',N'Kĩ thuật điều khiển','GV004')
Insert into Khoa(Ma_khoa,Ten_khoa,Ma_cnkhoa) Values('K05',N'Cơ khí','GV005')
Insert into Khoa(Ma_khoa,Ten_khoa,Ma_cnkhoa) Values('K06',N'Hàng không vũ trụ','GV006')
Insert into Khoa(Ma_khoa,Ten_khoa,Ma_cnkhoa) Values('K07',N'Động lực','GV007')
Select * from Khoa
Delete from Khoa where(Ma_khoa='K08')
--
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV008',N'Nguyễn Trung Dũng','0',N'Giáo viên',N'Hà Nội','K01')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV009',N'Dương Thị Hạnh','1',N'Giáo viên',N'Hải Phòng','K01')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV010',N'Đỗ Thanh Bình','0',N'Giáo viên',N'Bắc Ninh','K01')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV011',N'Phùng Văn Bình','0',N'Trợ giảng',N'Hà Nội','K01')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV012',N'Phạm Hoàng','0',N'Giáo viên',N'Hà Nội','K02')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV013',N'Vũ Trọng Quang','0',N'Giáo viên',N'Hải Phòng','K02')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV014',N'Kiều Khắc Phương','0',N'Giáo viên',N'Bắc Ninh','K02')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV015',N'Trần Thị Thu Hương','1',N'Trợ giảng',N'Hà Nội','K02')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV016',N'Nguyễn Thu Nga','1',N'Giáo viên',N'Hà Nội','K03')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV017',N'Võ Thanh Lương','0',N'Giáo viên',N'Hải Phòng','K03')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV018',N'Nguyễn Sỹ Đình','0',N'Giáo viên',N'Bắc Ninh','K03')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV019',N'Trần Minh Sơn','0',N'Trợ giảng',N'Hà Nội','K03')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV020',N'Lê Kim Thư','1',N'Giáo viên',N'Hà Nội','K04')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV021',N'Nguyễn Ngọc Thành','0',N'Giáo viên',N'Hải Phòng','K04')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV022',N'Đỗ Mạnh Tùng','0',N'Giáo viên',N'Bắc Ninh','K04')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV023',N'Lương Thị Thanh Hà','1',N'Trợ giảng',N'Hà Nội','K04')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV024',N'Vũ Văn Tuấn','0',N'Giáo viên',N'Hà Nội','K05')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV025',N'Cao Văn Hòa','0',N'Giáo viên',N'Hải Phòng','K05')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV026',N'Hoàng Quang Chính','0',N'Giáo viên',N'Bắc Ninh','K05')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV027',N'Hoàng Văn Tiến','0',N'Trợ giảng',N'Hà Nội','K05')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV028',N'Nguyễn Quý Đạt','0',N'Giáo viên',N'Hà Nội','K06')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV029',N'Nguyễn Mạnh Thường','0',N'Giáo viên',N'Hải Phòng','K06')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV030',N'Nguyễn Đình Tuấn','0',N'Giáo viên',N'Bắc Ninh','K07')
Insert into Giao_vien(Ma_giao_vien,Ten_giao_vien,Gioi_tinh,Hoc_vi,Dia_chi,Ma_khoa)
Values('GV031',N'Hoàng Văn Phúc','0',N'Giáo Viên',N'Hà Nội','K07')

Select * from Giao_vien
--
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('TH13A',N'Tin học 13A',N'K01','GV008')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CNTT14',N'Công nghệ thông tin 14',N'K01','GV009')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CNTT15',N'Công nghệ thông tin 15',N'K01','GV010')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CNTT16',N'Công nghệ thông tin 16',N'K01','GV011')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CDT13',N'Cơ điện tử 13',N'K02','GV012')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CDT14A',N'Cơ điện tử 14A',N'K02','GV013')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CDT14B',N'Cơ điện tử 14B',N'K02','GV014')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CDT15',N'Cơ điện tử 15',N'K02','GV015')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('OTO13',N'Ô tô 13',N'K04','GV020')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('TDH13',N'Tự động hóa 13',N'K04','GV021')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('TDH14',N'Tự động hóa 13',N'K04','GV022')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('TDH15',N'Tự động hóa 15',N'K04','GV023')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CK13',N'Cơ khí 13',N'K05','GV016')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CK14A',N'Cơ khí 14A',N'K05','GV017')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CK14B',N'Cơ khí 14B',N'K05','GV018')
Insert into Lop(Ma_lop,Ten_lop,Ma_khoa,Ma_giaoviencn)Values('CK15',N'Cơ khí 15',N'K05','GV019')

Select * from Lop
--
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV001',N'Nguyễn Hoàng Hà','05/08/1994','0',N'Hà Nội','CDT13')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV002',N'Bùi Anh Duy','12/08/1994','0',N'Hải Phòng','CDT13')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV003',N'Trần Mih Nhật','05/01/1997','0',N'Hà Nội','CDT14B')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV004',N'Lưu Đức Lộc','05/06/1997','0',N'Nam Định','CDT14B')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV005',N'Đào Anh Dũng','10/01/1997','0',N'Hà Nội','CDT14B')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV006',N'Nguyễn Văn Hữu','05/02/1997','0',N'Nam Định','CDT14B')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV007',N'Trần Lâm Vũ','05/01/1997','0',N'Hà Nội','CDT14A')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV008',N'Chu Ngọc Long','05/06/1997','0',N'Hải Phòng','CDT14A')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV009',N'Trần Hữu Thắng','10/01/1997','0',N'Nam Định','CDT14A')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV010',N'Lương Trung Đức','05/02/1997','0',N'Bắc Giang','CDT14A')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV011',N'Nguyễn Thị Hoa','05/01/1997','1',N'Hà Nội','CK15')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV012',N'Quách Hải Nam','05/06/1997','0',N'Hải Phòng','CK15')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV013',N'Nguyễn Khác Quyền','10/01/1997','0',N'Nam Định','CK15')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV014',N'Nguyễn Văn Tùng','05/02/1997','0',N'Bắc Giang','CK15')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV015',N'Nguyễn Hữu Tuấn','05/02/1998','0',N'Hà Nội','TDH15')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV016',N'Hoàng Đình Thắng','05/07/1997','0',N'Hải Phòng','TDH15')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV017',N'Nguyễn Huy Thanh','10/02/1998','0',N'Nam Định','TDH15')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV018',N'Đào Quang Huy','05/09/1998','0',N'Bắc Giang','TDH15')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV019',N'Trần Minh Tuấn','05/04/1996','0',N'Hà Nội','TH13A')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV020',N'Hoàng Đình Hiếu','05/08/1996','0',N'Hải Phòng','TH13A')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV021',N'Nguyễn Văn Kiên','10/07/1995','0',N'Nam Định','TH13A')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV022',N'Đào Nhật Anh','05/01/1996','0',N'Bắc Giang','TH13A')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV023',N'Chu Minh Phú','05/02/1996','0',N'Hà Nội','OTO13')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV024',N'Trần Đình Hiếu','05/07/1996','0',N'Hải Phòng','OTO13')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV025',N'Nguyễn Danh  Vinh','10/02/1996','0',N'Nam Định','OTO13')
Insert into Sinh_vien(Ma_sinh_vien,Ten_sinh_vien,Ngay_sinh,Gioi_tinh,Dia_chi,Ma_lop)
Values('SV026',N'Đào Văn Sâm','05/09/1995','0',N'Bắc Giang','OTO13')
Select * from Sinh_vien
--
Insert into Hoc_ky(Ma_hoc_ky,Ten_hoc_ky,Thoi_gian_bat_dau,Thoi_gian_ket_thuc,Ma_lop)
Values('K02-1',N'Học kì 1','09/09/2015','12/12/2015','CDT14A')
Insert into Hoc_ky(Ma_hoc_ky,Ten_hoc_ky,Thoi_gian_bat_dau,Thoi_gian_ket_thuc,Ma_lop)
Values('K04-1',N'Học kì 1','09/09/2015','12/12/2015','TDH14')
Insert into Hoc_ky(Ma_hoc_ky,Ten_hoc_ky,Thoi_gian_bat_dau,Thoi_gian_ket_thuc,Ma_lop)
Values('K05-1',N'Học kì 1','10/09/2016','11/12/2016','CK15')
Select*from Hoc_ky

Insert into Hoc_phan(Ma_hoc_phan,Ten_hoc_phan,So_tin_chi,Ma_hoc_ky)
Values('GT1',N'Giải tích 1','4','K02-1')
Insert into Hoc_phan(Ma_hoc_phan,Ten_hoc_phan,So_tin_chi,Ma_hoc_ky)
Values('NL1',N'Nguyên Lý I','4','K02-1')
Insert into Hoc_phan(Ma_hoc_phan,Ten_hoc_phan,So_tin_chi,Ma_hoc_ky)
Values('LTCB',N'Lập trình cơ bản','4','K02-1')
Insert into Hoc_phan(Ma_hoc_phan,Ten_hoc_phan,So_tin_chi,Ma_hoc_ky)
Values('QP',N'Công tác Quốc Phòng AN','3','K04-1')
Insert into Hoc_phan(Ma_hoc_phan,Ten_hoc_phan,So_tin_chi,Ma_hoc_ky)
Values('TD',N'Giáo dục thể chất','2','K04-1')
Insert into Hoc_phan(Ma_hoc_phan,Ten_hoc_phan,So_tin_chi,Ma_hoc_ky)
Values('DSTT',N'Đại số tuyến tính','3','K04-1')
Select *from Hoc_phan
