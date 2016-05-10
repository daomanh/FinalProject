use Vietnam_Tourism_2
go
select * from TblLocation

--insert into tblArea
insert into TblArea values('Northern Region')
insert into TblArea values('Center Region')
insert into TblArea values('Southern Region')

--insert into LocationTBl
--date format: mm/dd/yyyy

insert into TblLocation values('Ha Long','Northern Region','If you only travel in Halong you can go for 2 days. The morning of June 1 start the car to Halong, so go early first trip around 7am. Around 11h30 you to turn down 3 on Tuan Chau tourist site you get off and catch a motorbike taxi driver went into the Tuan Chau tourist port (from 01.01.2016 of moving cruise ship docks Tuan Chau Tourism). Lunch at a restaurant along the tourist port, the price is not too expensive where you have to select the menu. Early afternoon ticket harbor sights and asked about visiting the Bay ship running. You will buy tickets and rent private landscapes own ship, because the ship ran piecing together will cost from 100k - 150k / person. Can ask a ticket or some vienn Stork around it, rest assured that the general price does not mind. If you go with a group or family, you should hire a private ship, price range 1500k - 1700k / trip 4 hours - 6 hours.','Admin',
								'10/01/2015','02/15/2016',15,7)

insert into TblLocation values('Ha Noi','Northern Region','Hoan Kiem Lake: Geographical Features of Hanoi is in the heart of the city there are many lakes surrounding the city and is the largest river. Hoan Kiem Lake is located in the city center with ancient Turtle Tower is located on a small peninsula between the lakes. Next to Hoan Kiem Lake are the impressive buildings and precious heritage of the city: Tower Pen, Radio Look, The Huc bridge leading to the upstairs Dac Nguyet Tran Ba ... or on the lines at the Ngoc Son Temple .','Admin',
								'10/02/2015','02/15/2016',10,12)

insert into TblLocation values('Nha Trang','Center Region','Nha Trang climate relatively mild and has two distinct seasons: rainy and dry seasons. A short rainy season, from mid-September to mid-December, focusing on October 2 and November you should avoid traveling in Nha Trang on this month. The rest is the dry season. The annual average temperature of 26.7 ° Nha Trang tall own C on the mountain for more than three (30 km from Nha Trang crow flies) climate like Dalat and Sapa. Or hear people say "August Nha Trang Sea appointment" is probably very appropriate time for the summer tour of your sea. Often by the time July last until September in Saigon or Hanoi are often faced with the constant incessant rains in contrast to the beautiful sunny weather is very convenient for sightseeing trip beautiful sea floating with sandy in Nha Trang makes me not want to leave here','Admin',
								'10/01/2016','03/16/2015',10,10)

insert into TblLocation values('Da Lat','Center Region','Dalat is a city under the province and the provincial town of Lam Dong province, located on the Lam Vien Plateau. Is like a sub Paris, Dalat dreamy and poetic plateau through the cold night and morning fog patches of pine forest surrounding the city. Dalat is also known as: city flower, city of love, city of spring, the city of fog.
								During the French colonial period, the Latin name Laetitiam Aliis Aliis Temperiem Dat means "joy to these people, for others the cool". Was found at around 1893 due to the need of the French resort looking for a similar climate where their country, by a Swedish nationality French doctor Alexandre Yersin. After more than 100 years of development, is now Dalat is becoming a leading tourism center of Vietnam suck so much competition in the local and foreign tourists.','Admin',
								'01/14/2016','03/15/2016',5,20)

insert into TblLocation values('Dien Bien','Northern Region','1. Field Muong Thanh
								Rice season, Muong Thanh lush fields of life, as beautiful as a painting with young green trees and grass stretching headline or golden color in the sun at the time of grain. With an area of ​​4,000 hectares, spread across the basin of Dien Bien Phu, Muong Thanh field is considered to be the Northwests largest, became the granary of the province of Dien Bien. Many tourists like to visit in late September, when the rice crop ripening by the view from above, Muong Thanh field as a golden valley with fragrant rice flavor.
								2.  Pa Khoang lake
								With rich vegetation, lakes and forests surrounding the brightly blooming orchid gardens, lakes Pa compartment suitable for convalescence. If you prefer a fabulous scenery, come in the winter, the lake covered in mist release creates a dreamy landscape.
								And in the summer, fresh air, cool, visitors can admire panoramic clouds away water garden and boating excursions, scenic natural beauty, charm makes all your troubles as left behind. Not only beautiful natural scenery, it also attracted by the cultural identity of many unique traditional ethnic Thai, Kho Mu ...
								','Admin','01/01/2016','02/19/2016',10,2)

insert into TblLocation values('Ho Chi Minh city','Southern Region','It is no coincidence that Saigon is considered the "capital hedonistic" young people with many restaurants carry cuisine of different regions. Almost specialty domains can also find on the alleys of Saigon, in the popular market area, the sidewalk ... The Saigon to play late and almost did not sleep so the bar will also light up to midnight, even all night until morning.
								Ben Thanh night market
								Located right in the center of Ben Thanh Market should always be considered a food mecca famous night in Saigon, especially serving beneficiaries are tourists, and hence the higher price elsewhere. However, because the location is very convenient so regardless of day or night, not always with khach.Khu cuisine located at the mouth of the Western night Ben Thanh market with a variety of dishes such as noodles, beef noodle, soup, nuts, noodles ... crab dishes including Western, Chinese ... starting from 19h Market with lots of delicious meals, warm actually entered the area you will be ecstatic by the seductive aroma in this place. Most especially in areas where this is odd barbecue grills, dishes meticulously prepared and quite delicious with reasonable price.
								','Admin','03/01/2016','03/15/2016',1,1)
select * from TblLocation
-- insert picture
select * from TblPicture
insert into TblPicture values(1,'halong1','/AdminPage/Location/image/halong1.JPG','showerLocation','writer')
insert into TblPicture values(1,'halong2','/AdminPage/Location/image/halong2.JPG','shower','writer')
insert into TblPicture values(2,'hanoi1','/AdminPage/Location/image/hanoi1.JPG','showerLocation','writer')
insert into TblPicture values(2,'hanoi1','/AdminPage/Location/image/hanoi2.JPG','shower','writer')
insert into TblPicture values(3,'nhatrang1','/AdminPage/Location/image/nhatrang1.JPG','showerLocation','writer')
insert into TblPicture values(3,'nhatrang2','/AdminPage/Location/image/nhatrang2.JPG','shower','writer')
insert into TblPicture values(4,'dalat1','/AdminPage/Location/image/dalat1.JPG','showerLocation','writer')
insert into TblPicture values(4,'datlat2','/AdminPage/Location/image/dalat2.JPG','shower','writer')
insert into TblPicture values(5,'datlat2','/AdminPage/Location/image/noImage.png','showerLocation','writer')
insert into TblPicture values(6,'datlat2','/AdminPage/Location/image/noImage.png','showerLocation','writer')
insert into TblPicture values(7,'datlat2','/AdminPage/Location/image/noImage.png','showerLocation','writer')


insert into TblPicture values(0,'cmb-thushan-beach-1300x500.jpg','/AdminPage/PictureBanner/image/cmb-thushan-beach-1300x500.jpg','banner','banner')
insert into TblPicture values(0,'slide4_sailboat1-1300x500.jpg','/AdminPage/PictureBanner/image/slide4_sailboat1-1300x500.jpg','banner','banner')
insert into TblPicture values(0,'slide-1-1300x500-65.jpg','/AdminPage/PictureBanner/image/slide-1-1300x500-65.jpg','banner','banner')


-- insert review
exec InsertTblReview 1,1,'03/01/2016','good'
exec InsertTblReview 2,2,'03/01/2016','good and amazing'
exec InsertTblReview 1,3,'03/01/2016','bad location'
select * from tblReview

--insert user
exec InsertTblUser 'daomanh','daomanh123','dao ngoc manh',0915671098,'male','daomanh94@gmail.com','ha long','user'
exec InsertTblUser 'long','longlh123','le long',0987878282,'male','longlh@gmail.com','ha noi','user'
exec InsertTblUser 'hung','hungdt1122','dinh the hung',01679889456,'male','hungdt@gmail.com','hcm','user'
exec InsertTblUser 'Admin','Admin','daomanh','0915671098','male','daomanh94@gmail.com','halong','admin'
select * from TblUser