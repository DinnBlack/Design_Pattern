drop database if exists FinalProject
go

create database FinalProject
go

use FinalProject
go

Create table Province(
    provinceID int identity,
    provinceName nvarchar(500) unique,
	primary key(ProvinceID)
)
go

insert into Province(provinceName) values
(N'An Giang'),
(N'Bà Rịa-Vũng Tàu'),
(N'Bạc Liêu'),
(N'Bắc Kạn'),
(N'Bắc Giang'),
(N'Bắc Ninh'),
(N'Bến Tre'),
(N'Bình Dương'),
(N'Bình Định'),
(N'Bình Phước'),
(N'Bình Thuận'),
(N'Cà Mau'),
(N'Cao Bằng'),
(N'Cần Thơ'),
(N'Đà Nẵng'),
(N'Đắk Lắk'),
(N'Đắk Nông'),
(N'Điện Biên'),
(N'Đồng Nai'),
(N'Đồng Tháp'),
(N'Gia Lai'),
(N'Hà Giang'),
(N'Hà Nam'),
(N'Hà Nội'),
(N'Hà Tây'),
(N'Hà Tĩnh'),
(N'Hải Dương'),
(N'Hải Phòng'),
(N'Hòa Bình'),
(N'Hồ Chí Minh'),
(N'Hậu Giang'),
(N'Hưng Yên'),
(N'Khánh Hòa'),
(N'Kiên Giang'),
(N'Kon Tum'),
(N'Lai Châu'),
(N'Lào Cai'),
(N'Lạng Sơn'),
(N'Lâm Đồng'),
(N'Long An'),
(N'Nam Định'),
(N'Nghệ An'),
(N'Ninh Bình'),
(N'Ninh Thuận'),
(N'Phú Thọ'),
(N'Phú Yên'),
(N'Quảng Bình'),
(N'Quảng Nam'),
(N'Quảng Ngãi'),
(N'Quảng Ninh'),
(N'Quảng Trị'),
(N'Sóc Trăng'),
(N'Sơn La'),
(N'Tây Ninh'),
(N'Thái Bình'),
(N'Thái Nguyên'),
(N'Thanh Hóa'),
(N'Thừa Thiên – Huế'),
(N'Tiền Giang'),
(N'Trà Vinh'),
(N'Tuyên Quang'),
(N'Vĩnh Long'),
(N'Vĩnh Phúc'),
(N'Yên Bái')
go

create table LoginData
(
    userID varchar(8) not null,
    fullName nvarchar(500) not null,
    emailAddress varchar(500) not null,
    contactAddress nvarchar(500) not null,
	phoneNumber varchar(10) not null,
    userName varchar(500) not null unique,
    userPassword varchar(500) not null,
	userRole varchar(500) not null default 'user',
	userDateOfBirth date default current_timestamp,
    primary key(userID)
)
go

alter table LoginData add constraint fk_LoginData_provinceName_Province foreign key(contactAddress) references Province(provinceName)
go

create procedure InsertManagerLoginData
    @fullName nvarchar(500),
    @emailAddress varchar(500),
    @contactAddress nvarchar(500),
	@phoneNumber varchar(10),
    @userName varchar(500),
    @userPassword varchar(500)
as
begin
    declare @newUserID char(8)
	declare @maxUserID varchar(500)
	set @newUserID = 'MID00001'
	select @maxUserID = cast(max(cast(substring(userID, 4, 8) as int)) + 1 as varchar) from LoginData where substring(userID, 1, 3) = 'MID'
	if (cast(@maxUserID as int) > cast(substring(@newUserID, 4, 8) as int))
	begin
		while (len(@maxUserID) < 5)
		begin
			set @maxUserID = '0' + @maxUserID
		end
		set @newUserID = 'MID' + @maxUserID 
	end
    insert into LoginData (userID, fullName, emailAddress, contactAddress, phoneNumber, userName, userPassword, userRole) values (@newUserID, @fullName, @emailAddress, @contactAddress, @phoneNumber, @userName, @userPassword, 'manager')
end
go

create procedure InsertStaffLoginData
    @fullName nvarchar(500),
    @emailAddress varchar(500),
    @contactAddress nvarchar(500),
	@phoneNumber varchar(10),
    @userName varchar(500),
    @userPassword varchar(500)
as
begin
    declare @newUserID char(8)
	declare @maxUserID varchar(500)
	set @newUserID = 'SID00001'
	select @maxUserID = cast(max(cast(substring(userID, 4, 8) as int)) + 1 as varchar) from LoginData where substring(userID, 1, 3) = 'SID'
	if (cast(@maxUserID as int) > cast(substring(@newUserID, 4, 8) as int))
	begin
		while (len(@maxUserID) < 5)
		begin
			set @maxUserID = '0' + @maxUserID
		end
		set @newUserID = 'SID' + @maxUserID 
	end
    insert into LoginData (userID, fullName, emailAddress, contactAddress, phoneNumber, userName, userPassword, userRole) values (@newUserID, @fullName, @emailAddress, @contactAddress, @phoneNumber, @userName, @userPassword, 'staff')
end
go

create procedure InsertUserLoginData
    @fullName nvarchar(500),
    @emailAddress varchar(500),
    @contactAddress nvarchar(500),
	@phoneNumber varchar(10),
    @userName varchar(500),
    @userPassword varchar(500)
as
begin
    declare @newUserID char(8)
	declare @maxUserID varchar(500)
	set @newUserID = 'UID00001'
	select @maxUserID = cast(max(cast(substring(userID, 4, 8) as int)) + 1 as varchar) from LoginData where substring(userID, 1, 3) = 'UID'
	if (cast(@maxUserID as int) > cast(substring(@newUserID, 4, 8) as int))
	begin
		while (len(@maxUserID) < 5)
		begin
			set @maxUserID = '0' + @maxUserID
		end
		set @newUserID = 'UID' + @maxUserID 
	end
    insert into LoginData (userID, fullName, emailAddress, contactAddress, phoneNumber, userName, userPassword) values (@newUserID, @fullName, @emailAddress, @contactAddress, @phoneNumber, @userName, @userPassword)
end
go

create procedure InsertAdminLoginData
    @fullName nvarchar(500),
    @emailAddress varchar(500),
    @contactAddress nvarchar(500),
	@phoneNumber varchar(10),
    @userName varchar(500),
    @userPassword varchar(500)
as
begin
    declare @newAdminID char(8)
	declare @maxAdminID varchar(500)
	set @newAdminID = 'AID00001'
	select @maxAdminID = cast(max(cast(substring(userID, 4, 8) as int)) + 1 as varchar) from LoginData where substring(userID, 1, 3) = 'AID'
	if (cast(@maxAdminID as int) > cast(substring(@newAdminID, 4, 8) as int))
	begin
		while (len(@maxAdminID) < 5)
		begin
			set @maxAdminID = '0' + @maxAdminID
		end
		set @newAdminID = 'AID' + @maxAdminID 
	end
    insert into LoginData (userID, fullName, emailAddress, contactAddress, phoneNumber, userName, userPassword, userRole) values (@newAdminID, @fullName, @emailAddress, @contactAddress, @phoneNumber, @userName, @userPassword, 'admin')
end
go

exec InsertUserLoginData N'Vương Thanh Huy', 'vuongthanhhuy@gmail.com', N'Trà Vinh', '08546377748', 'vuonggthanhhhuyy', 'vuongthanhhuy2003'
exec InsertUserLoginData N'Nguyễn Thành Nhật Tân', 'nguyenthanhnhattan@gmail.com', N'Trà Vinh', '0898495911', 'nguyennthanhhnhatttann', 'nguyenthanhnhattan2003'
exec InsertAdminLoginData N'Phùng Thị Thủy Tiên', 'phungthithuytien@gmail.com', N'Đắk Nông', '0868429676', 'phunggthiithuyytienn', 'phungthithuytien2003'
exec InsertAdminLoginData N'Nguyễn Trung Dũng', 'nguyentrungdung@gmail.com', N'Nghệ An', '0377485395', 'nguyenntrunggdungg', 'nguyentrungdung2003'
exec InsertUserLoginData N'Lauren Vargas','fmcconnell@example.com',N'An Giang','0868429601','christopher33','I+U1jSf(&2'
exec InsertUserLoginData N'Joseph Schmitt','mchen@example.org',N'An Giang','0868429602','brittanythomas','McxXOz@O(1'
exec InsertUserLoginData N'Bradley Baldwin','otorres@example.org',N'An Giang','0868429603','ronald76','H3PVnukh&q'
exec InsertUserLoginData N'Kevin Torres','guerrerolori@example.net',N'Bạc Liêu','0868429604','adamsdiane','As%53ILsUJ'
exec InsertUserLoginData N'Andrew Hunt','meganpeterson@example.com',N'Bạc Liêu','0868429605','grodriguez','Cq7OgQd5%L'
exec InsertUserLoginData N'Isaac Beard','wattsjamie@example.net',N'Bạc Liêu','0868429606','petersonallison','9Io8P3Gf%0'
exec InsertUserLoginData N'Jason Sosa','joshua89@example.org',N'Bạc Liêu','0868429607','russelljones','!o7oF_XloK'
exec InsertUserLoginData N'Mary Murillo','jenniferthompson@example.net',N'Bắc Giang','0868429608','johnpowell','$^UVpWDy_0'
exec InsertUserLoginData N'Erin Ruiz','amber16@example.net',N'Bắc Giang','0868429609','matthew20','iLc2U#sh_j'
exec InsertUserLoginData N'Timothy Pitts','zachary83@example.org',N'Bắc Giang','0868429610','william23','Yj2%64El@J'
exec InsertUserLoginData N'Mason Roberts','robertrobertson@example.net',N'Bắc Kạn','0868429611','danielwilson','&^%68XJgOz'
exec InsertUserLoginData N'Joseph Price','awalker@example.com',N'Bắc Kạn','0868429612','haley70','6S3NOhth!D'
exec InsertUserLoginData N'Katherine Wilson','zavalacolleen@example.org',N'Bắc Kạn','0868429613','brownmatthew','*v8wKv$nYe'
exec InsertUserLoginData N'Ricky Moore','benjaminjohnson@example.com',N'Bắc Kạn','0868429614','branchgrant','d*Zl$3tn!R'
exec InsertUserLoginData N'Craig Davis','becky03@example.org',N'Bắc Kạn','0868429615','brasmussen','%sP1unI)B3'
exec InsertUserLoginData N'Matthew Martinez','staffordchristine@example.org',N'Bắc Ninh','0868429616','victoriaadkins','DPC@d2#c+7'
exec InsertUserLoginData N'Ann Smith','isabel20@example.net',N'Bắc Ninh','0868429617','edwardschristian','8nRVVuUx%d'
exec InsertUserLoginData N'Linda King','watkinsandrew@example.net',N'Bắc Ninh','0868429618','jjohnson','Q!1)TXObtN'
exec InsertUserLoginData N'Drew Williams','marvin64@example.com',N'Bắc Ninh','0868429619','zwilliams','sr&N9Ix8J^'
exec InsertUserLoginData N'Ricky Arnold','patrick94@example.net',N'Bến Tre','0868429620','dana10','!pGHitl33Q'
exec InsertUserLoginData N'Monique Martin','zfrederick@example.net',N'Bến Tre','0868429621','tgilbert','Se77&xXeW^'
exec InsertUserLoginData N'Linda Lewis','steven15@example.net',N'Bến Tre','0868429622','angela20','F7ZlXTCm!7'
exec InsertUserLoginData N'Adrian Nguyen PhD','eberry@example.org',N'Bến Tre','0868429623','bushstacy','_4WSwPwG1k'
exec InsertUserLoginData N'Rodney Spencer','danielsalan@example.net',N'Bến Tre','0868429624','mccarthysean','r5!3fZyp5n'
exec InsertUserLoginData N'Robert Smith','zgrimes@example.net',N'Bình Dương','0868429625','scott22','M9A8G0Jc@A'
exec InsertUserLoginData N'Patrick Dominguez','irose@example.org',N'Bình Dương','0868429626','kathleensmith','dn@o4XTliu'
exec InsertUserLoginData N'Victoria Patel','pittmancrystal@example.org',N'Bình Dương','0868429627','julie54','+7D0CcXR%l'
exec InsertUserLoginData N'Misty Thompson','rebeccahancock@example.net',N'Bình Dương','0868429628','scott62','_i2XRmm7oY'
exec InsertUserLoginData N'Lauren Wang','lindamartinez@example.com',N'Bình Định','0868429629','zwells','$82HDQgwym'
exec InsertUserLoginData N'Chelsea Cruz','xraymond@example.com',N'Bình Định','0868429630','melissawarner','%3QBksGo8%'
exec InsertUserLoginData N'Lisa Morgan','rhodesstanley@example.com',N'Bình Định','0868429631','allendaniel','_2JLeMq_sO'
exec InsertUserLoginData N'Stephen Warner','alyssadavidson@example.org',N'Bình Phước','0868429632','james42','#NAME?'
exec InsertUserLoginData N'Steven Myers','victoriabeasley@example.com',N'Bình Phước','0868429633','karenlewis','wH2ZU4hD!G'
exec InsertUserLoginData N'Jimmy Glover','jefferywilliamson@example.net',N'Bình Phước','0868429634','joshuaking','J87IviMQM*'
exec InsertUserLoginData N'Mr. Brian King Jr.','sharon06@example.com',N'Bình Thuận','0868429635','vanessa26','ZG$3WkSr_1'
exec InsertUserLoginData N'Jamie Morse','carly21@example.com',N'Bình Thuận','0868429636','penny52','sk*8Qa+t3Z'
exec InsertUserLoginData N'John Guerra','wwashington@example.com',N'Bình Thuận','0868429637','thomasmaria','n%S9W9e%L8'
exec InsertUserLoginData N'Nicholas Olsen','christopher34@example.net',N'Bình Thuận','0868429638','curtismassey','aB2YF04la*'
exec InsertUserLoginData N'Terry Adams','kristencalderon@example.net',N'Cà Mau','0868429639','brianhowell','$OFNa(pIo8'
exec InsertUserLoginData N'Jose Shannon','barkercarla@example.com',N'Cà Mau','0868429640','philipcampos','QFr7EJi@&^'
exec InsertUserLoginData N'Joshua Barajas','kevinschmitt@example.org',N'Cà Mau','0868429641','thomasmathew','N4vSH88l&S'
exec InsertUserLoginData N'Kathryn Murillo','moralestammy@example.net',N'Cà Mau','0868429642','dustin11','MG@o6Letsw'
exec InsertUserLoginData N'Michele Juarez','carmen71@example.org',N'Cao Bằng','0868429643','brandonhernandez','WF8N@S7hp#'
exec InsertUserLoginData N'Mary Brewer','william43@example.com',N'Cao Bằng','0868429644','alishaparker',')E8HMhHNK+'
exec InsertUserLoginData N'Jessica Hernandez','hoopermarcus@example.org',N'Cao Bằng','0868429645','browningjohn','_&A4QGhe&d'
exec InsertUserLoginData N'Amy Wood','priceclaire@example.net',N'Cao Bằng','0868429646','justin21','l$Gd_7VkJ*'
exec InsertUserLoginData N'Catherine Barton','smithdylan@example.com',N'Cao Bằng','0868429647','marcus51','!XjF+j$uV5'
exec InsertUserLoginData N'Brandi Miller','fhughes@example.net',N'Cao Bằng','0868429648','derekspencer','en(8@pMu^3'
exec InsertUserLoginData N'Robert Murphy','washingtonamber@example.com',N'Đắk Lắk','0868429649','kimberlykim','Zc6eGllM!5'
exec InsertUserLoginData N'Stephanie Santiago','christopherpruitt@example.net',N'Đắk Lắk','0868429650','espinozamartin','+06%Osvff_'
exec InsertUserLoginData N'Autumn Graham','danielgallagher@example.com',N'Đắk Lắk','0868429651','brittney30','f@0CEzmnPP'
exec InsertAdminLoginData N'Amy Baker','laurahill@example.com',N'Đắk Lắk','0868429652','palmerjason','@(piO)qq4U'
exec InsertAdminLoginData N'Kelly Jordan','pgomez@example.net',N'Đắk Lắk','0868429653','davidfisher','(D25I!w%S1'
exec InsertAdminLoginData N'Laura Harrison','donovanjody@example.com',N'Đắk Nông','0868429654','brooksroberto','C*8Fm38c(_'
exec InsertAdminLoginData N'Andrea Lopez','vazquezmark@example.net',N'Đắk Nông','0868429655','travis79','B#8&opRfC9'
exec InsertAdminLoginData N'Samantha Wood','wangcaitlin@example.org',N'Đắk Nông','0868429656','maytiffany','^lQB3EwD!9'
exec InsertAdminLoginData N'Alexandria Roberts','cjenkins@example.org',N'Hà Nội','0868429657','jamesbaker','r_2wKjO%9r'
exec InsertAdminLoginData N'Stephen Obrien','thomascastro@example.com',N'Hà Nội','0868429658','mhuber','R__XV*^v+3'
exec InsertAdminLoginData N'Kevin West','suzanne68@example.org',N'Hà Nội','0868429659','walkerpaul','jvbDlO_#*8'
exec InsertAdminLoginData N'Christopher Martin','dylancraig@example.com',N'Hà Nội','0868429660','cherylpeters','es2f+NZjj^'
exec InsertAdminLoginData N'Angela Glover','nbryant@example.org',N'Hà Nội','0868429661','jackson99','+2e2vZPt(l'
exec InsertAdminLoginData N'Deborah Lee','vdudley@example.net',N'Hà Nội','0868429662','hillwilliam','f3cT3QUv)G'
exec InsertAdminLoginData N'Andrea Jennings','guerrerodaniel@example.net',N'Hà Nội','0868429663','codyfrench','a&8ArkkB9G'
exec InsertAdminLoginData N'Cheryl Good','jennifer79@example.com',N'Hà Nội','0868429664','williamsbrian','^&Pfdxynx9'
exec InsertAdminLoginData N'Scott Mccann','billygordon@example.com',N'Hà Nội','0868429665','grobertson','xj+9Vd!7iq'
exec InsertAdminLoginData N'Sandra Walton','sheltontonya@example.org',N'Hà Nội','0868429666','reginald10','95g5HFTb&^'
exec InsertAdminLoginData N'Valerie Lynch','ijoseph@example.net',N'Hà Nội','0868429667','chelseaolson','f&^3LWmVMg'
exec InsertAdminLoginData N'Allen Calhoun','knightjoan@example.com',N'Hà Nội','0868429668','ijones','QEu+2M6rPq'
exec InsertAdminLoginData N'Yesenia Dyer','kristin20@example.org',N'Hà Nội','0868429669','gibbsdavid','j%1)8Lz^(K'
exec InsertAdminLoginData N'Steven Armstrong','josephmaldonado@example.org',N'Hà Nội','0868429670','qrodriguez',')#r04MhO#_'
exec InsertAdminLoginData N'Carrie Vargas','wallacechristopher@example.org',N'Hà Nội','0868429671','cainelizabeth','i0qY$mNa_9'
exec InsertAdminLoginData N'Daniel Duran','youngjustin@example.net',N'Hà Nội','0868429672','farmerwesley','(u11QWk9@2'
exec InsertAdminLoginData N'Dr. Miranda Stevenson','rebeccaspencer@example.org',N'Hà Nội','0868429673','hhall','+LVZ(u688G'
exec InsertAdminLoginData N'Anthony Hoover','thomasramos@example.com',N'Hà Nội','0868429674','cameronhenry','(N7ROrMjyH'
exec InsertAdminLoginData N'Brittany Webb','robertmccall@example.com',N'Hà Nội','0868429675','kristin62','%YgD+m9m)4'
exec InsertAdminLoginData N'Kelly Smith','bdominguez@example.net',N'Hà Nội','0868429999','qrivas','Y+xL^2EgzC'
exec InsertAdminLoginData N'Joseph Allen','bjohnson@example.org',N'Hà Nội','0868429677','florescatherine','wlS0JPq#&L'
exec InsertAdminLoginData N'Elizabeth Dean','phillipsdouglas@example.com',N'Hà Nội','0868429678','rwhite','Pe(8Jd@)M$'
exec InsertAdminLoginData N'Justin Gallagher','michael97@example.net',N'Hà Nội','0868429679','justinturner','(%4S^SNFyl'
exec InsertAdminLoginData N'Samantha Hunter','erikroberson@example.org',N'Hà Nội','0868429680','wbryant','&7%c5BGjA0'
exec InsertAdminLoginData N'Kelly Miller','fbishop@example.com',N'Hà Nội','0868429681','angela77','Ob^xiSHx@1'
exec InsertAdminLoginData N'Alexandria Long','hollypeterson@example.net',N'Hà Nội','0868429682','zacharygray','0KJkhort(2'
exec InsertAdminLoginData N'Kelly Wilcox','brooksmichelle@example.org',N'Hà Nội','0868429683','john17','l3JxOnJX&B'
exec InsertAdminLoginData N'Stephanie Leach','matthewcallahan@example.org',N'Hà Nội','0868429684','deborahbailey','dr5GyRjHm^'
exec InsertAdminLoginData N'Jacob Herrera','cunninghambenjamin@example.org',N'Hà Nội','0868429685','daniellewhite','K0Ac*t+a+%'
exec InsertAdminLoginData N'Ricky Anderson','ewoods@example.org',N'Hà Nội','0868429686','nelsonkeith','8C8pGVUjt^'
exec InsertAdminLoginData N'Nicole Garcia','kathleenalexander@example.net',N'Hà Nội','0868429687','lmcdowell','%DnCEfUn#3'
exec InsertAdminLoginData N'Samuel Moody','bwebb@example.net',N'Hà Nội','0868429688','williamwilson','+^4PSLyS+4'
exec InsertAdminLoginData N'Suzanne Meadows','jessicawhite@example.net',N'Hà Nội','0868429689','kleinrebecca','E&5)s_XdB8'
exec InsertAdminLoginData N'Elizabeth Green','danielberry@example.com',N'Hà Nội','0868429690','barrettkathleen','fYA0FFKeS!'
exec InsertAdminLoginData N'Randy Jackson','garciagary@example.net',N'Hà Nội','0868429691','hardysarah','1xp5mJcot$'
exec InsertAdminLoginData N'Blake Gilbert','across@example.com',N'Hà Nội','0868429692','martinezlauren','zo%10XlzX8'
exec InsertAdminLoginData N'Linda Edwards','echen@example.net',N'Hà Nội','0868429693','kbarber','JzH4bVfq@A'
exec InsertAdminLoginData N'Tracy Johnston','hayesjimmy@example.com',N'Hà Nội','0868429694','jeremy33','64DlHNjp$8'
exec InsertAdminLoginData N'Thomas Sanchez','landrymichael@example.com',N'Hà Nội','0868429695','tiffany19','%H1Cl@ao^4'
exec InsertAdminLoginData N'Thomas Fry','curtisjones@example.org',N'Hà Nội','0868429696','susanwebb','Pb)0ZEcbwK'
exec InsertAdminLoginData N'Stanley Hill','rsanders@example.org',N'Hà Nội','0868429697','jordan61','1*AdFGwE&w'
exec InsertAdminLoginData N'Daniel Kelley','johnny28@example.com',N'Hà Nội','0868429698','brenda51','sy1DJAbe*H'
exec InsertAdminLoginData N'Mark Carroll','zbraun@example.net',N'Hà Nội','0868429699','tacevedo','OxbX6L0II!'
go

create table MenuData
(
	dishID varchar(8) not null,
	dishPicture varchar(500) not null,
    dishName nvarchar(500) not null,
    dishDescription nvarchar(500) not null,
    dishPrice int not null,
	dishType varchar(500) not null,
    primary key(dishID)
)
go

create procedure InsertMenuData
    @dishPicture varchar(500),
    @dishName nvarchar(500),
    @dishDescription nvarchar(500),
    @dishPrice int,
	@dishType varchar(500)
as
begin
    declare @newDishID char(8)
	declare @maxDishID varchar(500)
	set @newDishID = 'DID00001'
	select @maxDishID = cast(max(cast(substring(dishID, 4, 8) as int)) + 1 as varchar) from MenuData
	if (cast(@maxDishID as int) > cast(substring(@newDishID, 4, 8) as int))
	begin
		while (len(@maxDishID) < 5)
		begin
			set @maxDishID = '0' + @maxDishID
		end
		set @newDishID = 'DID' + @maxDishID 
	end
    insert into MenuData(dishID, dishPicture, dishName, dishDescription, dishPrice, dishType) values (@newDishID, @dishPicture, @dishName, @dishDescription, @dishPrice, @dishType)
end
go

exec InsertMenuData 'https://product.hstatic.net/200000758381/product/khoai-mui-cau-r_d49b43c7840f4d6ebd84250c2a6e0191_grande.jpg', N'Khoai Tây Múi Cau', N'Khoai tây chiên cắt múi cau đậm vị', 100000, 'food'
exec InsertMenuData 'https://bizweb.dktcdn.net/thumb/1024x1024/100/440/789/products/z2980803716637-8893feeff06a255cf3543170f2437ffe.jpg?v=1638268536737', N'Combo Đùi Gà Rán', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 150000, 'combo'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSkdMbmF6HsgaDlepI3VzMog_H77Um1W3_-vA&usqp=CAU', N'Gà Sốt Mala (1 miếng)', N'Giòn tan đậm vị', 40000, 'food'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSkdMbmF6HsgaDlepI3VzMog_H77Um1W3_-vA&usqp=CAU', N'Gà Sốt Mala (3 miếng)', N'Giòn tan đậm vị', 112000, 'food'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSkdMbmF6HsgaDlepI3VzMog_H77Um1W3_-vA&usqp=CAU', N'Gà Sốt Mala (6 miếng)', N'Giòn tan đậm vị', 217000, 'food'
exec InsertMenuData 'https://bizweb.dktcdn.net/thumb/1024x1024/100/440/789/products/z2980803716637-8893feeff06a255cf3543170f2437ffe.jpg?v=1638268536737', N'Gà Rán (1 miếng)', N'Giòn tan đậm vị', 35000, 'food'
exec InsertMenuData 'https://bizweb.dktcdn.net/thumb/1024x1024/100/440/789/products/z2980803716637-8893feeff06a255cf3543170f2437ffe.jpg?v=1638268536737', N'Gà Rán (3 miếng)', N'Giòn tan đậm vị', 101000, 'food'
exec InsertMenuData 'https://bizweb.dktcdn.net/thumb/1024x1024/100/440/789/products/z2980803716637-8893feeff06a255cf3543170f2437ffe.jpg?v=1638268536737', N'Gà Rán (6 miếng)', N'Giòn tan đậm vị', 195000, 'food'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSkdMbmF6HsgaDlepI3VzMog_H77Um1W3_-vA&usqp=CAU', N'Gà Sốt HS (1 miếng)', N'Giòn tan đậm vị', 40000, 'food'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSkdMbmF6HsgaDlepI3VzMog_H77Um1W3_-vA&usqp=CAU', N'Gà Sốt HS (3 miếng)', N'Giòn tan đậm vị', 112000, 'food'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSkdMbmF6HsgaDlepI3VzMog_H77Um1W3_-vA&usqp=CAU', N'Gà Sốt HS (6 miếng)', N'Giòn tan đậm vị', 217000, 'food'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR0EbVcJskPoI1rqDjLSnj_y8HgaU_0PdcsU23VGhr-kQWJUU3cOayOWzzH2Z32lJYPmDQ&usqp=CAU', N'Gà Sốt Đậu (1 miếng)', N'Giòn tan đậm vị', 40000, 'food'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR0EbVcJskPoI1rqDjLSnj_y8HgaU_0PdcsU23VGhr-kQWJUU3cOayOWzzH2Z32lJYPmDQ&usqp=CAU', N'Gà Sốt Đậu (3 miếng)', N'Nước ngọt có gas', 129000, 'combo'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTEhd0i1uAUhbJOzamvNzlOkRuWfBmdWvSDIw&usqp=CAU', N'Loy Set', N'02 Gà rán + 01 Burger Bulgogi', 136000, 'combo'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTEhd0i1uAUhbJOzamvNzlOkRuWfBmdWvSDIw&usqp=CAU', N'Lody Set', N'Combo kết hợp 02 Gà rán + 01 Mì ý', 136000, 'combo'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTEhd0i1uAUhbJOzamvNzlOkRuWfBmdWvSDIw&usqp=CAU', N'Lony Set', N'Combo kết hợp 02 Gà rán + 01 Burger Bulgogi', 189000, 'combo'
exec InsertMenuData 'https://cdn.dealtoday.vn/img/s630x420/39f3dcf249c04692ad1c45e4c4c35206.jpg?sign=K2tQhBp9GfWBDbJct3ZHVA', N'Loking Set', N'Combo kết hợp 2 miếng gà rán + 1 mỳ ý', 207000, 'combo'
exec InsertMenuData 'https://cdn.dealtoday.vn/img/s630x420/26bbb47003914e68807543cbcd322bdf.jpg?sign=-G4LqCotGy8F6a-Bnjo6Jw', N'L4 Set', N'Combo kết hợp 04 Gà rán + 01 Burger Bulgogi', 265000, 'combo'
exec InsertMenuData 'https://cdn.dealtoday.vn/img/s630x420/26bbb47003914e68807543cbcd322bdf.jpg?sign=-G4LqCotGy8F6a-Bnjo6Jw', N'Milkis', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 22000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqSHE-_zvYOOdr3wf06Vc-cqkuR4EJiFZPvQ&usqp=CAU', N'Nước Cam', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 27000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTEhd0i1uAUhbJOzamvNzlOkRuWfBmdWvSDIw&usqp=CAU', N'Nestea', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 18000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT97yf3rcV08VFGqOn8MgaMzMOqf6npwX5Yqw&usqp=CAU', N'Pepsi (L)', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 18000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT97yf3rcV08VFGqOn8MgaMzMOqf6npwX5Yqw&usqp=CAU', N'Pepsi Zero (L)', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 18000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZY5pTQuJoUl2LG9sMIGfWrjFEvPVh6sP54w&usqp=CAU', N'7 UP (L)', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 18000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGKy1-Up7QHw0A2lvMlodr-bEIAOEHmlfZqA&usqp=CAU', N'Mirinda (L)', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 18000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT97yf3rcV08VFGqOn8MgaMzMOqf6npwX5Yqw&usqp=CAU', N'Pepsi Zero (M)', N'Nước ngọt có gas', 14000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT97yf3rcV08VFGqOn8MgaMzMOqf6npwX5Yqw&usqp=CAU', N'Pepsi (M)', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 18000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZY5pTQuJoUl2LG9sMIGfWrjFEvPVh6sP54w&usqp=CAU', N'7 UP (M)', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 14000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGKy1-Up7QHw0A2lvMlodr-bEIAOEHmlfZqA&usqp=CAU', N'Mirinda (M)', N'Combo kết hợp 2 miếng đùi gá + 1 khoai tây chiên + 1 coca', 14000, 'drink'
exec InsertMenuData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT97yf3rcV08VFGqOn8MgaMzMOqf6npwX5Yqw&usqp=CAU', N'Pepsi Lon', N'Nước ngọt có gas', 129000, 'drink'
go

create table PromotionData
(
	promotionID varchar(8) not null,
	promotionPicture varchar(500) not null,
    promotionName nvarchar(500) not null unique,
    promotionDescription nvarchar(500) not null,
    promotionDate datetime not null default current_timestamp,
	promotionPercent int not null,
    primary key(promotionID)
)
go

create procedure InsertPromotionData
    @promotionPicture varchar(500),
    @promotionName nvarchar(500),
    @promotionDescription nvarchar(500),
	@promotionPercent int
as
begin
    declare @newPromotionID char(8)
	declare @maxPromotionID varchar(500)
	set @newPromotionID = 'PID00001'
	select @maxPromotionID = cast(max(cast(substring(promotionID, 4, 8) as int)) + 1 as varchar) from PromotionData
	if (cast(@maxPromotionID as int) > cast(substring(@newPromotionID, 4, 8) as int))
	begin
		while (len(@maxPromotionID) < 5)
		begin
			set @maxPromotionID = '0' + @maxPromotionID
		end
		set @newPromotionID = 'PID' + @maxPromotionID 
	end
    insert into PromotionData(promotionID, promotionPicture, promotionName, promotionDescription, promotionPercent) values (@newPromotionID, @promotionPicture, @promotionName, @promotionDescription, @promotionPercent)
end
go

exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'THÁNG 5 RỰC RỠ', N'Áp dụng từ ngày 01/05/2023 đến ngày 30/05/2023', 50
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'THƯỞNG THỨC HƯƠNG VỊ BÁNH BURGER THƯỢNG HẠNG HOÀN TOÀN MỚI', N'Áp dụng từ ngày 03/06/2023 đến ngày 30/06/2023', 70
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'BỘ BA POKEMON SIÊU PHẨM ĐÃ SẴN SÀNG!', N'Áp dụng từ ngày 03/07/2023 đến ngày 30/07/2023', 30
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO1 giảm ngay 50%', N'Áp dụng từ ngày 03/08/2023 đến ngày 30/08/2023', 50
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO2 giảm ngay 70%', N'Áp dụng từ ngày 03/09/2023 đến ngày 30/09/2023', 70
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO1 giảm ngay 10%', N'Áp dụng từ ngày 04/01/2023 đến ngày 30/01/2023', 10
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO2 giảm ngay 20%', N'Áp dụng từ ngày 05/02/2023 đến ngày 30/02/2023', 20
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO3 giảm ngay 30%', N'Áp dụng từ ngày 06/03/2023 đến ngày 30/03/2023', 30
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO4 giảm ngay 40%', N'Áp dụng từ ngày 07/04/2023 đến ngày 30/04/2023', 40
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO5 giảm ngay 50%', N'Áp dụng từ ngày 08/11/2023 đến ngày 30/11/2023', 50
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO6 giảm ngay 60%', N'Áp dụng từ ngày 09/12/2023 đến ngày 30/12/2023', 60
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO7 giảm ngay 70%', N'Áp dụng từ ngày 03/01/2023 đến ngày 30/01/2023', 70
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO8 giảm ngay 60%', N'Áp dụng từ ngày 04/02/2023 đến ngày 30/02/2023', 60
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMBO9 giảm ngay 50%', N'Áp dụng từ ngày 05/03/2023 đến ngày 30/03/2023', 50
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMB10 giảm ngay 40%', N'Áp dụng từ ngày 06/04/2023 đến ngày 30/04/2023', 40
exec InsertPromotionData 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRno2vE8T6_I0qxOSdyD7FLUsbfMFPHR3XciQ&usqp=CAU', N'Nhập mã COMB11 giảm ngay 30%', N'Áp dụng từ ngày 07/05/2023 đến ngày 30/05/2023', 30
go

create table StoreAddress
(
	storeID varchar(8) not null,
	storePicture varchar(500) not null,
    storeName nvarchar(500) not null,
    storeDescription nvarchar(500) not null,
    storeTime nvarchar(500) not null,
	storePhone varchar(500) not null,
    primary key(storeID)
)
go

create procedure InsertStoreAddress
    @storePicture varchar(500),
    @storeName nvarchar(500),
    @storeDescription nvarchar(500),
    @storeTime nvarchar(500),
	@storePhone varchar(500)
as
begin
    declare @newStoreID char(8)
	declare @maxStoreID varchar(500)
	set @newStoreID = 'SID00001'
	select @maxStoreID = cast(max(cast(substring(storeID, 4, 8) as int)) + 1 as varchar) from StoreAddress
	if (cast(@maxStoreID as int) > cast(substring(@newStoreID, 4, 8) as int))
	begin
		while (len(@maxStoreID) < 5)
		begin
			set @maxStoreID = '0' + @maxStoreID
		end
		set @newStoreID = 'SID' + @maxStoreID 
	end
    insert into StoreAddress(storeID, storePicture, storeName, storeDescription, storeTime, storePhone) values (@newStoreID, @storePicture, @storeName, @storeDescription, @storeTime, @storePhone)
end
go

create table UserAddress
(
	userID varchar(8),
	storeID varchar(8),
	primary key(userID, storeID),
	foreign key(userID) references LoginData(userID),
	foreign key(storeID) references StoreAddress(storeID)
)
go

exec InsertStoreAddress 'https://vietnamtop10.net/wp-content/uploads/lotteria-viet-nam-co-the-dong-cua-ngay-trong-nam-nay.jpg', N'Lotteria Parkson Lê Thánh Tôn', N'Số 35 Bis - 45 Lê Thánh Tôn, Quận 1, TP.HCM', N'7:00 AM - 11:00 PM', '19001568'
exec InsertStoreAddress 'https://vietnamtop10.net/wp-content/uploads/lotteria.jpg', N'Lotteria Metro', N'Khu An Phú, An Khánh, Thảo Điền Q.2, TP.HCM', N'7:00 AM - 11:00 PM', '19001568'
exec InsertStoreAddress 'https://vietnamtop10.net/wp-content/uploads/bien-hieu-1000x625px-750x468.jpg', N'Lotteria Diamond', N'Số 34 Lê Duẩn, Quận 1, TP.HCM', N'7:00 AM - 11:00 PM', '19001568'
exec InsertStoreAddress 'https://vietnamtop10.net/wp-content/uploads/LR3.jpg', N'Lotteria Trần Quang Khải', N'Số 2 Nguyễn Hữu Cầu, Quận 1, TP HCM', N'7:00 AM - 11:00 PM', '19001568'
exec InsertStoreAddress 'https://vietnamtop10.net/wp-content/uploads/man-hinh-led-95-tran-hung-dao-quan-1-hcm-4-1030x772.jpg', N'Lotteria Đinh Tiên Hoàng', N'Số 95A Trần Hưng Đạo, Quận 1, TP HCM', N'7:00 AM - 11:00 PM', '19001568'
exec InsertStoreAddress 'https://vietnamtop10.net/wp-content/uploads/gYPRka.jpg', N'Lotteria Trần Hưng Đạo', N'Số 34 Lê Duẩn, Quận 1, TP.HCM', N'7:00 AM - 11:00 PM', '19001568'
go

create table NotificationData
(
	notificationID varchar(8) not null,
	notificationPicture varchar(500) not null,
    notificationName nvarchar(500) not null,
    notificationDate datetime not null,
    primary key(notificationID)
)
go

create table NotificationDataDetail
(
	notificationID varchar(8) not null,
	notificationPictureDetail varchar(500) not null,
    notificationDescription nvarchar(4000) not null,
	notificationFocus nvarchar(4000),
    primary key(notificationID),
	foreign key(notificationID) references NotificationData(notificationID)
)
go

create procedure InsertNotificationData
    @notificationPicture varchar(500),
    @notificationName nvarchar(500),
    @notificationDate datetime,
	@notificationPictureDetail varchar(500),
	@notificationDescription nvarchar(4000),
	@notificationFocus nvarchar(4000)
as
begin
    declare @newnNotificationID char(8)
	declare @maxNotificationID varchar(500)
	set @newnNotificationID = 'NID00001'
	select @maxNotificationID = cast(max(cast(substring(notificationID, 4, 8) as int)) + 1 as varchar) from NotificationData
	if (cast(@maxNotificationID as int) > cast(substring(@newnNotificationID, 4, 8) as int))
	begin
		while (len(@maxNotificationID) < 5)
		begin
			set @maxNotificationID = '0' + @maxNotificationID
		end
		set @newnNotificationID = 'NID' + @maxNotificationID 
	end
    insert into NotificationData(notificationID, notificationPicture, notificationName, notificationDate) values (@newnNotificationID, @notificationPicture, @notificationName, @notificationDate)
	insert into NotificationDataDetail(notificationID, notificationPictureDetail, notificationDescription, notificationFocus) values (@newnNotificationID, @notificationPictureDetail, @notificationDescription, @notificationFocus)
end
go

exec InsertNotificationData 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'THÁNG 5 RỰC RỠ', '2023-04-30', 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'Chào hè rực rỡ, deal Gà ngon hết cỡ

Ghé Lotteria tận hưởng Combo Tháng 5 ưu đãi siêu hời nha Fans:

Combo Rực Rỡ 1: 2 Gà rán + Mì Ý + Khoai tây chiên (M) + 2 Pepsi (M) giá chỉ 99.000 (tiết kiệm đến 59.000)

Combo Rực Rỡ 2: 2 Gà rán + Burger Bulgogi + Khoai tây lắc + 2 Pepsi (M) giá chỉ 139.000

Combo Rực Rỡ 3: 3 Gà rán + Burger Bulgogi + Mì ý + 3 Pepsi (M) giá chỉ 169.000

Đặc biệt hơn, Lotteria giao hàng MIỄN PHÍ khi bạn đặt hàng qua App LOTTERIA VN & Website lotteria.vn hoặc gọi đến số 1900.6778.

Nhấc máy lên “o-đờ” nào Fans ơi!', N'Combo Rực Rỡ 1: 2 Gà rán + Mì Ý + Khoai tây chiên (M) + 2 Pepsi (M) giá chỉ 99.000 (tiết kiệm đến 59.000)

Combo Rực Rỡ 2: 2 Gà rán + Burger Bulgogi + Khoai tây lắc + 2 Pepsi (M) giá chỉ 139.000

Combo Rực Rỡ 3: 3 Gà rán + Burger Bulgogi + Mì ý + 3 Pepsi (M) giá chỉ 169.000'
exec InsertNotificationData 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'THƯỞNG THỨC HƯƠNG VỊ BÁNH BURGER THƯỢNG HẠNG HOÀN TOÀN MỚI', '2023-12-05', 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'Lần đầu tiên xuất hiện tại Lotteria: Bánh Burger Brioche.
Bánh Burger mới đã được “thăng cấp” toàn diện từ diện mạo lẫn hương vị.

 Mềm mại hơn  Thơm hơn  Ngon hơn 

 Đậm vị trứng, thơm vị bơ 

 Bánh Burger được làm từ những nguyên liệu thượng hạng, mang đến cho bạn cảm nhận sự khác biệt trong từng thớ bánh.

Cùng trải nghiệm bánh Burger mới và những chiếc combo siêu hời này nha:

 Combo Burger mới Ngon: Burger Double Double + Burger Tôm + Khoai tây lắc + 2 Pepsi (M)

 giá chỉ 119.000 (tiết kiệm 53.000)

 Combo Burger mới Rất Ngon: 2 Gà rán + Burger Bulgogi + Burger Tôm + Khoai tây chiên (M) +2 Pepsi (M)

 giá chỉ 149.000 (tiết kiệm đến 68.000)

 Bánh Burger mới đã “lên kệ” từ ngày 5 tháng 12 này, đang chờ các RIA Fans đến để thưởng thức đó.

“O-đờ” món ngon tại các cửa hàng Lotteria hoặc truy cập App LOTTERIA VN/gọi đến số 1900.6778 để được giao hàng miễn phí và nhận thêm nhiều ưu đãi nữa nha các bạn!

#MyFAVORITELOTTERIA #LotteriaVietnam #NewBun #Burgerthuonghang', N' Combo Burger mới Ngon: Burger Double Double + Burger Tôm + Khoai tây lắc + 2 Pepsi (M)

 giá chỉ 119.000 (tiết kiệm 53.000)

 Combo Burger mới Rất Ngon: 2 Gà rán + Burger Bulgogi + Burger Tôm + Khoai tây chiên (M) +2 Pepsi (M)

 giá chỉ 149.000 (tiết kiệm đến 68.000)'
exec InsertNotificationData 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'LOTTERIA ĐÃ CÓ MẶT TẠI GAME PLAY TOGETHER', '2023-05-07', 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'Hế lô các thần dân của đảo Kaia, Lotteria vừa "khai trương" một cửa hàng mới tại khu trung tâm đó.

Các bạn đã đến trải nghiệm chưa?

Cùng tham gia làm nhiệm vụ tìm gà rán để trang bị thêm mũ Lody cho tủ đồ của mình nha.

Bạn nào muốn "độ da" sang màu đỏ nâu khỏe khoắn thì thử liền món Gà rán H&S best seller tại cửa hàng Lotteria trên Play Together nhé!

Cùng chờ đón những sự kiện thú vị và vật phẩm hấp dẫn tại cửa hàng ảo Lotteria nha!

Hẹn gặp lại các bạn ở khu trung tâm đảo Kaia!!!', N'Lotteria vừa "khai trương" một cửa hàng mới tại khu trung tâm'
exec InsertNotificationData 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'LOTTERIA CẦN THƠ GO THAY ÁO MỚI', '2023-05-08', 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'Ngày 27/10/2022 Lotteria Cần Thơ Go đã chính thức hoạt động trở lại.

Là Lotteria đầu tiên có mặt tại Cần Thơ, với mong muốn nâng cao chất lượng phục vụ và trải nghiệm của khách hàng tại Cửa hàng, Lotteria Cần Thơ Go đã được thay đổi một diện mạo mới: trẻ trung và năng động hơn.

Địa chỉ: Lô 1  Khu dân cư Hưng Phú, Phường Hưng Phú, Quận Cái Răng , Thành phố Cần Thơ

Cửa hàng được thiết kế với không gian mở, họa tiết L-chicken có tone màu đỏ-vàng bắt mắt, có thể phục vụ hơn 140 chỗ ngồi. Lotteria còn ưu ái dành riêng 1 khu vực chuyên phục vụ nhu cầu tổ chức tiệc của các Fans: Phòng sinh nhật được trang trí hình ảnh những sản phẩm Gà rán đặc trưng và Biệt đội siêu điệp viên L4.

Tại sự kiện khai trương đang diễn ra rất nhiều chương trình khuyến mãi với ưu đãi hấp dẫn, đặc biệt: 400 khách hàng đầu tiên có hóa đơn từ 100.000 được tặng 1 áo thun Biệt đội siêu điệp viên L4, cùng đến chung vui cùng Lotteria Cần Thơ Go các Fans nhé!

', N'Ngày 27/10/2022 Lotteria Cần Thơ Go đã chính thức hoạt động trở lại.'
exec InsertNotificationData 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'BỘ BA POKEMON SIÊU PHẨM ĐÃ SẴN SÀNG!', '2023-05-09', 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'Rước liền 1 combo Pokemon chỉ 169.000 để dắt về nhà một bạn Pokemon siêu cute hột me nha:

Combo Pokemon 1: 2 Gà rán + 1 Mỳ Ý + 1 Khoai tây lắc + 2 Pepsi (M)

Combo Pokemon 2: 1 Burger Tôm + 1 Burger Bulgogi + 1 Phô mai que + 1 Khoai tây lắc + 2 Pepsi (M)

"Hari hari..."

Harimaron - Hệ Cỏ - Pokemon hạt dẻ gai. Pokemon có những chiếc gai như lông nhím và có khả năng chống đỡ những cú tông cực mạnh.

"Fok fok kooo..."
Fokko - Hệ Lửa - Pokemon Cáo lửa. Một chiếc Pokemon với đôi tai rộng có thể phụt ra ngoài những luồng hơi nóng lên đến 390° F (tương đương 190° C).

"Kero kero..."
Keromatsu - Hệ Nước - Pokemon Ếch bong bóng. Khi tham chiến, Keromatsu sẽ tiết ra vô số bong bóng co dãn từ cổ và lưng để giảm sát thương

Tuyệt quá đi thôi, đến Lotteria gần nhất để tham gia cuộc hành trình mới cùng với các bạn Pokemon mới nhé!

Hành trình thu thập Pokemon mới tại Lotteria bắt đầu nữa rồi!!! Vùng đất thế hệ thứ 6 - Kalos đầy thơ mộng không kém phần hấp dẫn. Các RIA Fans đã sẵn sàng chưa nào!!!', N'Combo Pokemon 1: 2 Gà rán + 1 Mỳ Ý + 1 Khoai tây lắc + 2 Pepsi (M)

Combo Pokemon 2: 1 Burger Tôm + 1 Burger Bulgogi + 1 Phô mai que + 1 Khoai tây lắc + 2 Pepsi (M)'
exec InsertNotificationData 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'LOTTERIA CHALLENGE CUP 2022 - ƯƠM MẦM TƯƠNG LAI BÓNG ĐÁ VIỆT', '2023-05-10', 'https://img.lovepik.com/desgin_photo/40094/0536_detail.jpg!detail808', N'Ngày 24 tháng 9 vừa qua, sau chặng đường dài gần hai tháng thi đấu vòng loại đầy gay cấn, 8 đội bóng vô địch từ Thành phố Hà Nội, Thành phố Hải Phòng, Thành phố Vinh, Thành phố Đà Nẵng, Thành phố Hồ Chí Minh và Thành phố Cần Thơ đã tham gia vòng chung kết tranh Lotteria Challenge Cup 2022 được tổ chức tại Câu lạc bộ bóng đá Phú Nhuận, Thành phố Hồ Chí Minh. Chiếc cúp vô địch đã  thuộc về đội FC Bóng đá Học đường TP.HCM bằng chiến thắng thuyết phục trước đội FC HYS Hà Nội với tỷ số 1-0. 

Cùng Lotteria gửi lời chúc mừng đến các đội bóng xuất sắc tại mùa giải năm 2022:

- Nhà Vô địch: CLB Bóng đá học đường TP. Hồ Chí Minh

- Giải nhì và Giải Fairplay: FC HYS Hà Nội

- Giải ba: CLB Kids star TP.Hồ Chí Minh

- Giải tư: U11 Sầm Sơn Thanh Hóa

Giải Vua phá lưới và Thủ môn xuất sắc được trao cho 2 cầu thủ tại CLB HYS Hà Nội, ngoài ra giải đấu còn vinh danh Huấn luyện viên xuất sắc đến từ CLB Bóng đá học đường TP. Hồ Chí Minh.

Với mong muốn lan tỏa thông điệp trung thực và nêu cao tinh thần bóng đá đẹp, Lotteria Việt Nam đã rất nỗ lực để đưa Lotteria Challenge Cup trở lại sau 2 năm bị gián đoạn bởi dịch Covid-19. Đây cùng là mùa giải thứ 9 mà chúng tôi đồng hành cùng các em thiếu nhi có niềm đam mê bóng đá, giải đấu không chỉ là sân chơi lành mạnh, bổ ích, mà còn là môi trường rèn luyện cho các em những đức tính tốt đẹp: đoàn kết, trung thực và quyết tâm không ngừng nghỉ.

Chứng kiến niềm đam mê của các cầu thủ nhí qua những trận đấu, chúng tôi sẽ cố gắng duy trì sân chơi lành mạnh và bổ ích này, góp phần ươm mầm thêm những tài năng mới cho nền bóng đá Việt. Tinh thần của giải đấu cũng chính là tiêu chí cốt lõi mà Lotteria luôn hướng đến thực hiện tại thị trường Việt Nam.

', N'Cùng Lotteria gửi lời chúc mừng đến các đội bóng xuất sắc tại mùa giải năm 2022:

- Nhà Vô địch: CLB Bóng đá học đường TP. Hồ Chí Minh

- Giải nhì và Giải Fairplay: FC HYS Hà Nội

- Giải ba: CLB Kids star TP.Hồ Chí Minh

- Giải tư: U11 Sầm Sơn Thanh Hóa'
go

CREATE TABLE revenue (
    storeId varchar(8) NOT NULL,
    amount int default 0,
    dateCreate date NOT NULL default current_timestamp,
    FOREIGN KEY (storeID) REFERENCES StoreAddress(storeID)
);
go

insert into revenue(storeId) values
('SID00001'),
('SID00002'),
('SID00003'),
('SID00004'),
('SID00005'),
('SID00006')
go

create table HistoryUserData
(
	orderUserID varchar(8) not null,
	userID varchar(8) not null,
	orderPicture varchar(500) not null default 'https://timviec365.vn/pictures/images/KFC-la-gi-1-min.jpg',
	totalDish int not null,
	totalCash int not null,
	orderDate datetime default current_timestamp,
	condition nvarchar(500) not null default N'Đã thanh toán',
	primary key(orderUserID),
	foreign key(userID) references LoginData(userID)
)
go

create table HistoryUserDataDetail
(
	orderUserID varchar(8),
	dishID varchar(8) not null,
	dishPicture varchar(500) not null,
    dishName nvarchar(500) not null,
    dishPrice int not null,
	dishTotal int not null,
	promotionCash int,
	foreign key(orderUserID) references HistoryUserData(orderUserID),
	foreign key(dishID) references MenuData(dishID),
	primary key(orderUserID, dishID)
)
go

create table CartData
(
	dishID varchar(8) not null,
	dishPicture varchar(500) not null,
    dishName nvarchar(500) not null,
    dishPrice int not null,
	totalQuantity int not null,
	promotionID varchar(8),
	promotionCash int default 0,
	userID varchar(8),
    primary key(dishID, userID),
	foreign key(dishID) references MenuData(dishID),
	foreign key(userID) references LoginData(userID)
)
go

insert into CartData(dishID, dishPicture, dishName, dishPrice, totalQuantity, userID) values
('DID00001', 'https://product.hstatic.net/200000758381/product/khoai-mui-cau-r_d49b43c7840f4d6ebd84250c2a6e0191_grande.jpg', N'Khoai Tây Múi Cau', 100000, 3, 'UID00001'),
('DID00002', 'https://bizweb.dktcdn.net/thumb/1024x1024/100/440/789/products/z2980803716637-8893feeff06a255cf3543170f2437ffe.jpg?v=1638268536737', N'Combo Đùi Gà Rán', 120000, 2, 'UID00001')
go

create procedure PayMoney
    @userID varchar(8),
	@totalCash int,
	@storeName nvarchar(500)
as
begin
	declare @check int
	select @check = count(dishID) from CartData where userID = @userID
	if @check > 0
	begin
		declare @orderUserID char(8)
		declare @maxOrderUserID varchar(500)
		set @orderUserID = 'OUID0001'
		select @maxOrderUserID = cast(max(cast(substring(orderUserID, 5, 8) as int)) + 1 as varchar) from HistoryUserData
		if (cast(@maxOrderUserID as int) > cast(substring(@orderUserID, 5, 8) as int))
		begin
			while (len(@maxOrderUserID) < 4)
			begin
				set @maxOrderUserID = '0' + @maxOrderUserID
			end
			set @orderUserID = 'OUID' + @maxOrderUserID 
		end
		declare @totalDish int
		select @totalDish = sum(totalQuantity) from CartData where userID = @userID
		insert into HistoryUserData(orderUserID, userID, totalDish, totalCash) values (@orderUserID, @userID, @totalDish, @totalCash)
		declare @i int = 0
		declare @loop int
		select @loop = count(dishID) from CartData where userID = @userID
		while @i < @loop
		begin
			declare @dishID varchar(8)
			select @dishID = dishID from CartData where userID = @userID
			declare @dishPicture varchar(500)
			select @dishPicture = dishPicture from CartData where userID = @userID
			declare @dishName varchar(500)
			select @dishName = dishName from CartData where userID = @userID
			declare @dishPrice int
			select @dishPrice = dishPrice from CartData where userID = @userID
			declare @totalQuantity int
			select @totalQuantity = totalQuantity from CartData where userID = @userID
			declare @promotionCash int
			select @promotionCash = promotionCash from CartData where userID = @userID
			insert into HistoryUserDataDetail values (@orderUserID, @dishID, @dishPicture, @dishName, @dishPrice, @totalQuantity, @promotionCash)
			delete from CartData where userID = @userID and dishID = @dishID
			set @i = @i + 1
		end
		declare @storeID varchar(8)
		select @storeID = storeID from StoreAddress where storeName = @storeName
		update revenue set amount = amount + @totalCash, dateCreate = current_timestamp where storeId = @storeID
	end
end
go

select * from revenue
select * from CartData
select * from HistoryUserData
select * from HistoryUserDataDetail
select * from LoginData
select * from MenuData
select * from NotificationData
select * from NotificationDataDetail
select * from PromotionData
select * from Province
select * from StoreAddress
select * from UserAddress

select revenue.* from revenue, UserAddress where UserAddress.userID='MID00001' and revenue.storeId = UserAddress.storeID

select LoginData.* from LoginData, UserAddress where UserAddress.userID=LoginData.userID and UserAddress.storeId = (select storeID from UserAddress where UserAddress.userID='MID00001')

select distinct LoginData.*,UserAddress.storeID from LoginData,UserAddress 
Where (fullName like '%%' or fullName like '%') and UserAddress.storeID = 'SID00001'and LoginData.userID= UserAddress.userID 

update LoginData
set    userDateOfBirth = '2023-04-20'
Where  userID = 'UID00001'
