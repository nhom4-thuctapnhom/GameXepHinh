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
	ThoiGian nvarchar(50),
	SoLanThaoTac int,
	IDMucDo nchar(20),
	primary key (ID, IDMucDo),
	constraint TK_ID_FK foreign key (ID) references dbo.NGUOICHOI(ID),
	constraint TK_IDMucDo_FK foreign key (IDMucDo) references dbo.MUCDO(IDMucDo)
)
/*=====================================================*/

insert into dbo.MUCDO(IDMucDo, MucDo)
values	(1, 'Dễ'),
		(2, 'Trung bình'),
		(3, 'Khó');
		
insert into dbo.NGUOICHOI (ID, Ten)
values	(1, 'Bao'),
		(2, 'Hoan'),
		(3, 'Diep'),
		(4, 'Cuong'),
		(5, 'Cong'),
		(6, 'Thuy'),
		(7, 'Viet'),
		(8, 'Trong'),
		(9, 'Tuan');

insert into dbo.THONGKE (ID, ThoiGian, SoLanThaoTac, IDMucDo)
values	(1, '4 phút : 12 giây',	315, 1),
		(2, '5 phút : 27 giây',	423, 1),
		(3, '3 phút : 55 giây',	256, 1),
		(4, '4 phút : 23 giây',	297, 1),
		(5, '5 phút : 06 giây',	333, 1),
		(6, '7 phút : 12 giây',	500, 1),
		(7, '10 phút : 34 giây', 928, 1),
		(8, '2 phút : 10 giây',	183, 1),
		(9, '3 phút : 18 giây',	254, 1);