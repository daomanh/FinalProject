--drop--
use master
drop database Vietnam_Tourism

create database Vietnam_Tourism
go 
use Vietnam_Tourism
go

--area--
create table TblArea
(
	IDa int primary key identity(1,1),
	AreaName nvarchar(100)
)

	create proc AllArea
	as
	begin
		select * from TblArea
	end

--location--
create table TblLocation
(
	ID int primary key identity(1,1),
	NameLocation nvarchar(100),
	AreaID int,
	LocationContent nvarchar(4000),
	Username nvarchar(100),
	DateCreate Date,
	DateUpdate Date,
	Viewer int default 0,
	Rate int default 0
)
	--show all--
	create proc ViewAllTblLocation
	as
	begin
		select * from TblLocation
	end
	--insert--
	create proc InsertTblLocation
	(	
		@NameLocation nvarchar(100),
		@Area nvarchar(100),
		@LocationContent nvarchar(100),
		@Username nvarchar(100),
		@DateCreate Date
	)
	as
	begin
		insert into TblLocation(NameLocation,Area,LocationContent,Username,DateCreate) values (@NameLocation, @Area, @LocationContent, @Username, @DateCreate)
	end
	
	--edit--
	create proc UpdateTblLocation
	(		
		@NameLocation nvarchar(100),
		@Area nvarchar(100),
		@LocationContent nvarchar(100),
		@Username nvarchar(100),
		@DateUpdate Date,
		@ID int
	)
	as
	begin
		update TblLocation set NameLocation=@NameLocation, Area=@Area,LocationContent=@LocationContent,Username=@Username,@DateUpdate=DateUpdate where ID=@ID
	end

	exec UpdateTblLocation 'hanoi','vietnam','hanoi hanoi','Admin',0,1
	--delete--
	create proc DeleteTblLocation
	(
		@ID int 
	)
	as 
	begin
		delete TblLocation where ID=@ID
	end
	--search location by name and area--
	create proc SearchLocationByName_Area
	(
		@NameLocation nvarchar(100),
		@Area nvarchar(100)
	)
	as
	begin
		select * from TblLocation inner join TblPicture on TblLocation.ID = TblPicture.LocationID where(@NameLocation is null or NameLocation like '%'+@NameLocation+'%' )and Area=@Area and TblPicture.Statut='showerLocation'

	end
	
	select Area from TblLocation
	--search location by name--
	create proc SearchLocationByName
	(
		@NameLocation nvarchar(100)
	)
	as
	begin
		select * from TblLocation where NameLocation=@NameLocation 
	end
	
	--search location by ID--
	create proc SearchLocationByID
	(
		@ID int
	)
	as
	begin
		select * from TblLocation where ID=@ID 
	end

	--select top ID--
	create proc SelectTopID
	as
	begin	
		select top 1 ID from TblLocation order by ID desc
	end
	
	--select top view--
	create proc SelectTopViewer
	as
	begin	
		select top 4 * from TblLocation order by Viewer desc
	end

	--select top new--
	create proc SelectTopNews
	as
	begin	
		select top 4 * from TblLocation order by DateCreate desc
	end
	select * from TblLocation where Year(TblLocation.DateCreate)<2016

	--select top rate--
	create proc SelectTopRate
	as
	begin	
		select top 4 * from TblLocation order by Rate desc
	end

	--update rate
	create proc updateRate	
	(
		@ID int,
		@Rate int
	)
	as
	begin
		update TblLocation set Rate=@Rate where ID=@ID
	end

	exec updateRate 1,8
	select * from TblLocation
	--update Viewer
	create proc Update_Viewer
	(
		@ID int,
		@Viewer int
	)
	as
	begin
		update TblLocation set Viewer=@Viewer where ID=@ID
	end

	--show viewer by locationID
	create proc Viewer_OF_Location
	(
		@ID int,
		@Viewer int
	)
	as
	begin
		select TblLocation.Viewer from TblLocation where TblLocation.ID=@ID
	end



--picture--
create table TblPicture
(
	ID int primary key identity(1,1),
	LocationID int,
	PicName nvarchar(100),
	PicUrl nvarchar(100) default '/AdminPage/Location/image/noImage.png', 
	Statut nvarchar(100),
	Roll nvarchar(30)
)
	
	--show all--
	create proc ViewAllTblPicture
	as
	begin
		select * from TblPicture
	end
	--show picture By roll--
	create proc ViewTblPictureByRoll
		@Roll nvarchar(30)
	as
	begin
		select * from TblPicture where Roll=@Roll
	end
	--show picture By LocationID
	create proc ViewTblPictureByLocationID
		@LocationID int
	as
	begin
		select * from  TblPicture where LocationID=@LocationID and TblPicture.Statut='showerLocation'
	end
	--insert--
	create proc InsertTblPicture
	(	
		@LocationID nvarchar(100),
		@PicName nvarchar(100),
		@PicUrl nvarchar(100),
		@Statut nvarchar(100),
		@Roll nvarchar(30)	
	)
	as
	begin
		insert into TblPicture(LocationID,PicName,PicUrl,Statut,Roll) values (@LocationID,@PicName,@PicUrl,@Statut,@Roll)
	end
	--edit--
	create proc UpdateTblPicture
	(
		@ID int,
		@LocationID nvarchar(100),
		@PicName nvarchar(100),
		@PicUrl nvarchar(100),
		@Statut nvarchar(100),
		@Roll nvarchar(30)	
	)
	as
	begin
		update TblPicture set LocationID=@LocationID, PicName=@PicName,PicUrl=@PicUrl,Statut=@Statut,Roll=@Roll where ID=@ID
	end
	--delete--
	create proc DeleteTblPicture
	(
		@ID int 
	)
	as 
	begin
		delete TblPicture where ID=@ID
	end
	--select location and pic
	create proc SelecttblLocationANDTblPicture
	as
	begin
	select * from TblLocation inner join TblPicture on TblLocation.ID = TblPicture.LocationID where TblPicture.Statut='showerLocation'
	end

--Review--
create table TblReview
(
	ID int primary key identity(1,1),
	LocationID int,
	U_ID int,
	DateReview date,
	ReviewContent nvarchar(4000),
	ReviewStt nvarchar(20) default 'not reply'
)

	--show all--
	create proc ViewAllTblReview
	as
	begin
		select * from TblReview
	end

	--select review and location and acount name
	create proc ViewAllTblReviewAndLocationAndAcount
	as
	begin
		select * from  TblReview inner join TblUser on TblReview.U_ID = TblUser.ID  inner join TblLocation on TblReview.LocationID = TblLocation.ID
	end

	--count review of location
	create  proc countReviewOFLocation
	as
	begin
		SELECT TblLocation.ID, TblLocation.NameLocation, (select COUNT(*) FROM TblReview where TblLocation.ID=TblReview.LocationID) as totalReview from TblLocation 
	end
	
	--show by id
	create  proc showContentByID
	(
		@ID int 
	)
	as
	begin
		SELECT TblReview.ReviewContent from TblReview where TblReview.ID = @ID
	end
	--show all review by id
	create proc ViewAllTblReviewByLocationID
	(
		@LocationID int 
	)
	as
	begin
		select * from TblReview inner join TblUser on TblReview.U_ID = TblUser.ID where TblReview.LocationID=@LocationID 
	end

	--show review by id and not reply
	create proc ViewAllTblReviewByLocationID_NOTREPLY
	(
		@LocationID int 
	)
	as
	begin
		select * from TblReview inner join TblUser on TblReview.U_ID = TblUser.ID where TblReview.LocationID=@LocationID and ReviewStt='not reply'
	end

	--show review by id and review reply
	create proc ViewAllTblReviewByLocationID_Reply
	(
		@LocationID int 
	)
	as
	begin
		select * from TblReview inner join TblUser on TblReview.U_ID = TblUser.ID inner join ReplyReview on ReplyReview.IDReview=TblReview.ID where TblReview.LocationID=@LocationID
	end
		
	--insert--
	create proc InsertTblReview
	(	
		@LocationID int,
		@U_ID int,
		@DateReview date,
		@ReviewContent nvarchar(4000)		
	)
	as
	begin
		insert into TblReview(LocationID,U_ID,DateReview,ReviewContent) values (@LocationID,@U_ID,@DateReview,@ReviewContent)
	end
	--edit--
	create proc UpdateTblReview
	(
		@ID int,
		@LocationID nvarchar(100),
		@U_ID nvarchar(100),
		@ReviewContent nvarchar(100)		
	)
	as
	begin
		update TblReview set LocationID=@LocationID, U_ID=@U_ID,ReviewContent=@ReviewContent where ID=@ID
	end

	--edit stt--
	create proc UpdateSTTTblReview
	(
		@ID int,
		@ReviewStt nvarchar(20)
	)
	as
	begin
		update TblReview set ReviewStt=@ReviewStt where ID=@ID
	end

	--delete--
	create proc DeleteTblReview
	(
		@ID int 
	)
	as 
	begin
		delete TblReview where ID=@ID
	end

--reply review
	create table ReplyReview
	(
		IDRep int primary key identity(1,1),
		IDReview int,
		U_ID int,
		UserName nvarchar(100),
		DateReply date,
		Content nvarchar(4000),
	)
	select * from ReplyReview
	create proc InsertRepylReview
	(
		@IDReview int,
		@UserName nvarchar(100),
		@DateReply date,
		@Content nvarchar(4000)
	)
	as
	begin
		insert into ReplyReview(IDReview,UserName,DateReply,Content) values (@IDReview,@UserName,@DateReply,@Content)
	end

	create proc UpdateReplyReview
	(
		@IDRep int,
		@UserName nvarchar(100),
		@DateReply date,
		@Content nvarchar(4000)
	)
	as
	begin
		update ReplyReview set UserName=@UserName, DateReply=@DateReply, Content=@Content where IDRep=@IDRep
	end
	select * from ReplyReview
	create proc showReply_By_ReviewID
	(
		@IDReview int
	)
	as
	begin
		select * from ReplyReview where IDReview = @IDReview
	end

--User--
create table TblUser
(
	ID int primary key identity(1,1),
	Username nvarchar(100),
	Pass nvarchar(100),
	Fullname nvarchar(100),
	PhoneNumber nvarchar(30),
	Gender nvarchar(30),
	Email nvarchar(100),
	Addres nvarchar(100),
	Roll nvarchar(10),
)

	--show all--
	create proc ViewAllTblUser
	as
	begin
		select * from TblUser
	end
	--insert--
	create proc InsertTblUser
	(	
		@Username nvarchar(100),
		@Pass nvarchar(100),
		@Fullname nvarchar(100),
		@PhoneNumber nvarchar(30),
		@Gender nvarchar(30),
		@Email nvarchar(100),
		@Addres nvarchar(100),
		@Roll nvarchar(10)
	)
	as
	begin
		insert into TblUser(Username,Pass,Fullname,PhoneNumber,Gender,Email,Addres,Roll) values (@Username,@Pass,@Fullname,@PhoneNumber,@Gender,@Email,@Addres,@Roll)
	end
	--edit--
	create proc UpdateTblUser
	(
		@ID int,
		@Username nvarchar(100),
		@Pass nvarchar(100),
		@Fullname nvarchar(100),
		@PhoneNumber nvarchar(30),
		@Gender nvarchar(30),
		@Email nvarchar(100),
		@Addres nvarchar(100),
		@Roll nvarchar(10)
	)
	as
	begin
		update TblUser set Username=@Username, Pass=@Pass,Fullname=@Fullname,PhoneNumber=@PhoneNumber,Gender=@Gender,Email=@Email,Addres=@Addres,Roll=@Roll where ID=@ID
	end
	--delete--
	create proc DeleteTblUser
	(
		@ID int 
	)
	as 
	begin
		delete TblUser where ID=@ID
	end

	--login--
	create proc LoginUSer
	(
		@Username nvarchar(100),
		@Pass nvarchar(100)
	)
	as
	begin
		select * from TblUser where Username=@Username and Pass= @Pass
	end

	--select information user by id
	create proc selectUserByID
	(
		@ID int 
	)
	as
	begin
		select * from TblUser where ID=@ID
	end
--tblBooking
create table Booking
(
	IDB int primary key identity(1,1),
	
	U_ID int,
	NameOFcustomer nvarchar(50),	
	Adress nvarchar(100),
	Phonenumber nvarchar(100),
	Email nvarchar(100),

	LocationID int,
	NumberPeople int,
	DateStart date,

	Statut nvarchar(30) default 'Wait'
)	

	--select all Booking
	create proc selectAllBooking
	as
	begin
		select * from Booking
	end

	--select Booking and location
	create proc selectBookingAndLocation
	as
	begin
		select * from Booking inner join TblLocation on Booking.LocationID = TblLocation.ID
	end

	--select Booking and location by U_ID
	create proc selectBookingAndLocation_BY_U_ID
	(
		@U_ID int
	)
	as
	begin
		select * from Booking inner join TblLocation on Booking.LocationID = TblLocation.ID where U_ID = @U_ID
	end

	--insert booking
	create proc InsertBooking
	(
		@U_ID int,
		@NameOFcustomer nvarchar(50),	 
		@Adress nvarchar(100), 
		@Phonenumber nvarchar(100), 
		@Email nvarchar(100), 

		@LocationID int,
		@NumberPeople int,
		@DateStart date
	)
	as
	begin
		insert into Booking(U_ID,NameOFcustomer,Adress,Phonenumber,Email,LocationID,NumberPeople,DateStart) values(@U_ID,@NameOFcustomer,@Adress,@Phonenumber,@Email,@LocationID,@NumberPeople,@DateStart)
	end

	--update booking
	create proc UpdateBooking
	(
		@IDB int,
		@U_ID int,
		@NameOFcustomer nvarchar(50),		
		@Adress nvarchar(100),
		@Phonenumber nvarchar(100),
		@Email nvarchar(100),

		@LocationID int,
		@NumberPeople int,
		@Statut nvarchar(30)
	)
	as
	begin
		update Booking set U_ID=@U_ID, NameOFcustomer=@NameOFcustomer, Adress=@Adress,Phonenumber=@Phonenumber,Email=@Email,LocationID=@LocationID,NumberPeople=@NumberPeople,Statut=@Statut where IDB=@IDB
	end

	--update stt booking 
	create proc Update_STT_BYID_Booking
	(
		@IDB int,		
		@Statut nvarchar(30)
	)
	as
	begin
		update Booking set Statut=@Statut where IDB=@IDB
	end
	select * from Booking
	--delete 
	create proc DeleteBooking
	(
		@IDB int 
	)
	as 
	begin
		delete Booking where IDB=@IDB
	end

--Contact 
	create table TblContact
	(
		ID int primary key identity(1,1),
		Name nvarchar(100),
		Email nvarchar(100),
		PhoneNumber nvarchar(100),
		Mesage nvarchar(4000),
		STT nvarchar(100)
	)
	select * from TblContact
	create proc Insert_Contact
	(
		@Name nvarchar(100),
		@Email nvarchar(100),
		@PhoneNumber nvarchar(30),
		@Mesage nvarchar(4000),
		@STT nvarchar(10)
	)
	as
	begin
		insert into TblContact(Name,Email,PhoneNumber,Mesage,STT) values (@Name,@Email,@PhoneNumber,@Mesage,@STT)
	end

	create proc Update_STT_Contact
	(
		@ID int,
		@STT nvarchar(10)
	)
	as
	begin
		update TblContact set STT=@STT where ID=@ID
	end

	create proc AllContact_STT
	(		
		@STT nvarchar(10)
	)
	as
	begin
		select * from TblContact where STT=@STT
	end

	create proc AllContact	
	as
	begin
		select * from TblContact 
	end


--insert values
insert into TblLocation(NameLocation,Area,LocationContent,Username,Rate) values ('halong','northeast','Hạ Long city is divided into two parts: East Hạ Long and West Hạ Long','admin','2');

exec InsertTblUser 'Admin','Admin','daomanh','0915671098','male','daomanh94@gmail.com','halong','admin'

select * from TblUser where Username='Admin' and Pass= 'Admin'
select * from TblLocation
select * from TblPicture


SELECT ID FROM TblLocation
ORDER BY ID DESC 

select top 1 ID
from TblLocation
order by ID desc
insert into TblLocation(NameLocation,Area,LocationContent,Username,DateCreate,DateUpdate,Viewer,Rate)values('Ha Long','Northeast','If you only travel in Halong you can go for 2 days. ','Admin','10/01/2016','15/02/2016',15,7)



select * from ReplyReview inner join TblReview on ReplyReview.IDReview=TblReview.ID inner join TblLocation on TblLocation.ID=TblReview.LocationID

