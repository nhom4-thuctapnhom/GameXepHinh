use master
go
create database GameXepHinh 
on primary 
( 
  size = 8
  ,filegrowth = 64
  ,maxsize = 1000
  ,filename =  'E:\GameXepHinh\Database\GameXepHinh.mdf'
  ,name = GameXepHinh
)
log on 
(
  size = 8
  ,filegrowth = 64
  ,maxsize = 1000
  ,filename = 'E:\GameXepHinh\Database\GameXepHinh.ldf'
  ,name = GameXepHinh_log
)
go
use GameXepHinh
go

/*================== Tạo các bảng ==================*/

-- NGUOI CHOI --
create table NGUOICHOI
(
	ID int primary key,
	Ten nchar(10)
) 

-- MUCDO --
create table MUCDO
(
	IDMucDo nchar(20) primary key,
	MucDo	nchar(20)
)

-- THONGKE --
create table THONGKE
(
	ID int,
	ThoiGian int,
	SoLanThaoTac int,
	IDMucDo nchar(20),
	primary key (ID, IDMucDo),
	constraint TK_ID_FK foreign key (ID) references dbo.NGUOICHOI(ID),
	constraint TK_IDMucDo_FK foreign key (IDMucDo) references dbo.MUCDO(IDMucDo)
)
/*=====================================================*/