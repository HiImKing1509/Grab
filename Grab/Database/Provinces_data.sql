use Grab
go


-- DATA for provinces
INSERT INTO PROVINCES (PROVINCE_CODE, PROVINCE_NAME, PROVINCE_NAME_ENG, PROVINCE_FULLNAME, PROVINCE_FULLNAME_ENG, PROVINCE_CODE_NAME, ADMIN_UNIT_ID, ADMIN_REGION_ID, PROVINCE_LATITUDE, PROVINCE_LONGITUDE) VALUES
	 ('01',N'Hà Nội',N'Ha Noi',N'Thành phố Hà Nội',N'Ha Noi City',N'ha noi',1,3, 21.0245, 105.8412),
	 ('26',N'Vĩnh Phúc',N'Vinh Phuc',N'Tỉnh Vĩnh Phúc',N'Vinh Phuc Province',N'vinh phuc',2,3, 21.1817, 105.3613),
	 ('27',N'Bắc Ninh',N'Bac Ninh',N'Tỉnh Bắc Ninh',N'Bac Ninh Province',N'bac ninh',2,3, 21.1861, 106.0763),
	 ('30',N'Hải Dương',N'Hai Duong',N'Tỉnh Hải Dương',N'Hai Duong Province',N'hai duong',2,3, 20.9399, 106.3309),
	 ('31',N'Hải Phòng',N'Hai Phong',N'Thành phố Hải Phòng',N'Hai Phong City',N'hai phong',1,3, 20.8000, 106.6667),
	 ('33',N'Hưng Yên',N'Hung Yen',N'Tỉnh Hưng Yên',N'Hung Yen Province',N'hung yen',2,3, 20.36, 105.53),
	 ('34',N'Thái Bình',N'Thai Binh',N'Tỉnh Thái Bình',N'Thai Binh Province',N'thai binh',2,3, 20.4461, 106.3422),
	 ('35',N'Hà Nam',N'Ha Nam',N'Tỉnh Hà Nam',N'Ha Nam Province',N'ha nam',2,3, 20.35, 105.60),
	 ('96',N'Cà Mau',N'Ca Mau',N'Tỉnh Cà Mau',N'Ca Mau Province',N'ca mau',2,8, 9.1833, 105.1500),
	 ('02',N'Hà Giang',N'Ha Giang',N'Tỉnh Hà Giang',N'Ha Giang Province',N'ha giang',2,1, 23.1300, 105.3004);
INSERT INTO PROVINCES (PROVINCE_CODE, PROVINCE_NAME, PROVINCE_NAME_ENG, PROVINCE_FULLNAME, PROVINCE_FULLNAME_ENG, PROVINCE_CODE_NAME, ADMIN_UNIT_ID, ADMIN_REGION_ID, PROVINCE_LATITUDE, PROVINCE_LONGITUDE) VALUES
	 ('04',N'Cao Bằng',N'Cao Bang',N'Tỉnh Cao Bằng',N'Cao Bang Province',N'cao bang',2,1, 23.0712, 10.1615),
	 ('06',N'Bắc Kạn',N'Bac Kan',N'Tỉnh Bắc Kạn',N'Bac Kan Province',N'bac kan',2,1, 22.0923, 105.05115),
	 ('08',N'Tuyên Quang',N'Tuyen Quang',N'Tỉnh Tuyên Quang',N'Tuyen Quang Province',N'tuyen quang',2,1, 22.40, 105.40),
	 ('19',N'Thái Nguyên',N'Thai Nguyen',N'Tỉnh Thái Nguyên',N'Thai Nguyen Province',N'thai nguyen',2,1, 21.6000, 105.8500),
	 ('20',N'Lạng Sơn',N'Lang Son',N'Tỉnh Lạng Sơn',N'Lang Son Province',N'lang son',2,1, 21.45, 106.32),
	 ('22',N'Quảng Ninh',N'Quang Ninh',N'Tỉnh Quảng Ninh',N'Quang Ninh Province',N'quang ninh',2,1, 21.40, 108.31),
	 ('24',N'Bắc Giang',N'Bac Giang',N'Tỉnh Bắc Giang',N'Bac Giang Province',N'bac giang',2,1, 21.37, 107.02),
	 ('25',N'Phú Thọ',N'Phu Tho',N'Tỉnh Phú Thọ',N'Phu Tho Province',N'phu tho',2,1, 21.43, 105.27),
	 ('10',N'Lào Cai',N'Lao Cai',N'Tỉnh Lào Cai',N'Lao Cai Province',N'lao cai',2,2, 21.51, 104.38),
	 ('11',N'Điện Biên',N'Dien Bien',N'Tỉnh Điện Biên',N'Dien Bien Province',N'dien bien',2,2, 22.33, 103.36);
INSERT INTO PROVINCES (PROVINCE_CODE, PROVINCE_NAME, PROVINCE_NAME_ENG, PROVINCE_FULLNAME, PROVINCE_FULLNAME_ENG, PROVINCE_CODE_NAME, ADMIN_UNIT_ID, ADMIN_REGION_ID, PROVINCE_LATITUDE, PROVINCE_LONGITUDE) VALUES
	 ('12',N'Lai Châu',N'Lai Chau',N'Tỉnh Lai Châu',N'Lai Chau Province',N'lai chau',2,2, 22.50, 103.59),
	 ('14',N'Sơn La',N'Son La',N'Tỉnh Sơn La',N'Son La Province',N'son la',2,2, 22.50, 103.59),
	 ('15',N'Yên Bái',N'Yen Bai',N'Tỉnh Yên Bái',N'Yen Bai Province',N'yen bai',2,2, 22.16, 105.03),
	 ('17',N'Hoà Bình',N'Hoa Binh',N'Tỉnh Hoà Bình',N'Hoa Binh Province',N'hoa binh',2,2, 21.08, 105.40),
	 ('70',N'Bình Phước',N'Binh Phuoc',N'Tỉnh Bình Phước',N'Binh Phuoc Province',N'binh phuoc',2,7, 11.22, 107.8),
	 ('72',N'Tây Ninh',N'Tay Ninh',N'Tỉnh Tây Ninh',N'Tay Ninh Province',N'tay ninh',2,7, 11.3131, 106.0963),
	 ('74',N'Bình Dương',N'Binh Duong',N'Tỉnh Bình Dương',N'Binh Duong Province',N'binh duong',2,7, 12.18, 107.6730),
	 ('75',N'Đồng Nai',N'Dong Nai',N'Tỉnh Đồng Nai',N'Dong Nai Province',N'dong nai',2,7, 11.3457, 107.35),
	 ('79',N'Hồ Chí Minh',N'Ho Chi Minh',N'Thành phố Hồ Chí Minh',N'Ho Chi Minh City',N'ho chi minh',1,7, 10.8167, 106.6333),
	 ('77',N'Bà Rịa - Vũng Tàu',N'Ba Ria - Vung Tau',N'Tỉnh Bà Rịa - Vũng Tàu',N'Ba Ria - Vung Tau Province',N'ba ria vung tau',2,7, 10.4042, 107.1417);
INSERT INTO PROVINCES (PROVINCE_CODE, PROVINCE_NAME, PROVINCE_NAME_ENG, PROVINCE_FULLNAME, PROVINCE_FULLNAME_ENG, PROVINCE_CODE_NAME, ADMIN_UNIT_ID, ADMIN_REGION_ID, PROVINCE_LATITUDE, PROVINCE_LONGITUDE) VALUES
	 ('36',N'Nam Định',N'Nam Dinh',N'Tỉnh Nam Định',N'Nam Dinh Province',N'nam dinh',2,3, 20.4200, 106.1683),
	 ('37',N'Ninh Bình',N'Ninh Binh',N'Tỉnh Ninh Bình',N'Ninh Binh Province',N'ninh binh',2,3, 20.27, 106.27),
	 ('38',N'Thanh Hóa',N'Thanh Hoa',N'Tỉnh Thanh Hóa',N'Thanh Hoa Province',N'thanh hoa',2,4, 19.8075, 105.7764),
	 ('40',N'Nghệ An',N'Nghe An',N'Tỉnh Nghệ An',N'Nghe An Province',N'nghe an',2,4, 20.01, 105.48),
	 ('42',N'Hà Tĩnh',N'Ha Tinh',N'Tỉnh Hà Tĩnh',N'Ha Tinh Province',N'ha tinh',2,4, 18.37, 105.07),
	 ('44',N'Quảng Bình',N'Quang Binh',N'Tỉnh Quảng Bình',N'Quang Binh Province',N'quang binh',2,4, 18.05, 105.37),
	 ('45',N'Quảng Trị',N'Quang Tri',N'Tỉnh Quảng Trị',N'Quang Tri Province',N'quang tri',2,4, 17.1, 104.24),
	 ('46',N'Thừa Thiên Huế',N'Thua Thien Hue',N'Tỉnh Thừa Thiên Huế',N'Thua Thien Hue Province',N'thua thien hue',2,4, 16.4637, 107.5908),
	 ('48',N'Đà Nẵng',N'Da Nang',N'Thành phố Đà Nẵng',N'Da Nang City',N'da nang',1,5, 16.1410, 108.2000),
	 ('49',N'Quảng Nam',N'Quang Nam',N'Tỉnh Quảng Nam',N'Quang Nam Province',N'quang nam',2,5, 15.3843, 108.2616);
INSERT INTO PROVINCES (PROVINCE_CODE, PROVINCE_NAME, PROVINCE_NAME_ENG, PROVINCE_FULLNAME, PROVINCE_FULLNAME_ENG, PROVINCE_CODE_NAME, ADMIN_UNIT_ID, ADMIN_REGION_ID, PROVINCE_LATITUDE, PROVINCE_LONGITUDE) VALUES
	 ('51',N'Quảng Ngãi',N'Quang Ngai',N'Tỉnh Quảng Ngãi',N'Quang Ngai Province',N'quang ngai',2,5, 15.1206, 108.7922),
	 ('52',N'Bình Định',N'Binh Dinh',N'Tỉnh Bình Định',N'Binh Dinh Province',N'binh dinh',2,5, 13.54, 109.22),
	 ('54',N'Phú Yên',N'Phu Yen',N'Tỉnh Phú Yên',N'Phu Yen Province',N'phu yen',2,5, 13.4128, 109.2747),
	 ('56',N'Khánh Hòa',N'Khanh Hoa',N'Tỉnh Khánh Hòa',N'Khanh Hoa Province',N'khanh hoa',2,5, 11.4250, 109.2755),
	 ('58',N'Ninh Thuận',N'Ninh Thuan',N'Tỉnh Ninh Thuận',N'Ninh Thuan Province',N'ninh thuan',2,5, 11.10, 109.14),
	 ('60',N'Bình Thuận',N'Binh Thuan',N'Tỉnh Bình Thuận',N'Binh Thuan Province',N'binh thuan',2,5, 11.33, 108.23),
	 ('62',N'Kon Tum',N'Kon Tum',N'Tỉnh Kon Tum',N'Kon Tum Province',N'kon tum',2,6, 13.5510, 108.3230),
	 ('64',N'Gia Lai',N'Gia Lai',N'Tỉnh Gia Lai',N'Gia Lai Province',N'gia lai',2,6, 14.3700, 108.5440),
	 ('66',N'Đắk Lắk',N'Dak Lak',N'Tỉnh Đắk Lắk',N'Dak Lak Province',N'dak lak',2,6, 13.2506, 108.5937),
	 ('67',N'Đắk Nông',N'Dak Nong',N'Tỉnh Đắk Nông',N'Dak Nong Province',N'dak nong',2,6, 12.50, 108.10);
INSERT INTO PROVINCES (PROVINCE_CODE, PROVINCE_NAME, PROVINCE_NAME_ENG, PROVINCE_FULLNAME, PROVINCE_FULLNAME_ENG, PROVINCE_CODE_NAME, ADMIN_UNIT_ID, ADMIN_REGION_ID, PROVINCE_LATITUDE, PROVINCE_LONGITUDE) VALUES
	 ('68',N'Lâm Đồng',N'Lam Dong',N'Tỉnh Lâm Đồng',N'Lam Dong Province',N'lam dong',2,6, 12.1500, 107.4500),
	 ('80',N'Long An',N'Long An',N'Tỉnh Long An',N'Long An Province',N'long an',2,8, 11.0200, 106.4702),
	 ('82',N'Tiền Giang',N'Tien Giang',N'Tỉnh Tiền Giang',N'Tien Giang Province',N'tien giang',2,8, 10.3526, 106.4806),
	 ('83',N'Bến Tre',N'Ben Tre',N'Tỉnh Bến Tre',N'Ben Tre Province',N'ben tre',2,8, 10.20, 106.48),
	 ('84',N'Trà Vinh',N'Tra Vinh',N'Tỉnh Trà Vinh',N'Tra Vinh Province',N'tra vinh',2,8, 9.4850, 106.2989),
	 ('86',N'Vĩnh Long',N'Vinh Long',N'Tỉnh Vĩnh Long',N'Vinh Long Province',N'vinh long',2,8, 10.1950, 106.1700),
	 ('87',N'Đồng Tháp',N'Dong Thap',N'Tỉnh Đồng Tháp',N'Dong Thap Province',N'dong thap',2,8, 10.58, 105.12),
	 ('89',N'An Giang',N'An Giang',N'Tỉnh An Giang',N'An Giang Province',N'an giang',2,8, 10.1060, 105.35),
	 ('91',N'Kiên Giang',N'Kien Giang',N'Tỉnh Kiên Giang',N'Kien Giang Province',N'kien giang',2,8, 10.3230, 105.3240),
	 ('92',N'Cần Thơ',N'Can Tho',N'Thành phố Cần Thơ',N'Can Tho City',N'can tho',1,8, 10.0333, 105.7833);
INSERT INTO PROVINCES (PROVINCE_CODE, PROVINCE_NAME, PROVINCE_NAME_ENG, PROVINCE_FULLNAME, PROVINCE_FULLNAME_ENG, PROVINCE_CODE_NAME, ADMIN_UNIT_ID, ADMIN_REGION_ID, PROVINCE_LATITUDE, PROVINCE_LONGITUDE) VALUES
	 ('93',N'Hậu Giang',N'Hau Giang',N'Tỉnh Hậu Giang',N'Hau Giang Province',N'hau giang',2,8, 10.1917, 105.1403),
	 ('94',N'Sóc Trăng',N'Soc Trang',N'Tỉnh Sóc Trăng',N'Soc Trang Province',N'soc trang',2,8, 9.6000, 105.9719),
	 ('95',N'Bạc Liêu',N'Bac Lieu',N'Tỉnh Bạc Liêu',N'Bac Lieu Province',N'bac lieu',2,8, 9.2833, 105.7167);