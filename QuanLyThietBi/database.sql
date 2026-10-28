CREATE DATABASE DuLieu_ThietBi;
GO
USE DuLieu_ThietBi;
GO
CREATE TABLE ThietBi(
	MaThietBi NVARCHAR(10) PRIMARY KEY,
	TenThietBi nText NOT NULL,
	DonGia NVARCHAR(12) NOT NULL
);
GO
INSERT INTO ThietBi(MaThietBi, TenThietBi, DonGia) VALUES
('TB001', 'Máy tính xách tay Dell', '15.000.000'),
('TB002', 'Máy tính HP LaserJet', '5.500.000'),
('TB003', 'Màn hình Samsung', '3.800.000'),
('TB004', 'Bàn phím cơ Logitech', '1.200.000'),
('TB005', 'Chuột không dây', '450.000')
GO
SELECT *FROM ThietBi