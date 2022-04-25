
CREATE TABLE [CaSub]
(
	CounterpartyID int  NOT NULL ,
	SubID int  NOT NULL 
)
go


ALTER TABLE [CaSub]
	ADD CONSTRAINT XPKКонтрагентАбонимент PRIMARY KEY  CLUSTERED (CounterpartyID ASC,SubID ASC)
go


CREATE TABLE [Counterparty]
(
	CounterpartyID int IDENTITY(1,1)  NOT NULL ,
	Name varchar(20)  NULL ,
	Surname varchar(20)  NULL ,
	MiddleName varchar(20)  NULL ,
	Type int  NULL 
)
go


ALTER TABLE Counterparty
	ADD CONSTRAINT XPKКонтрагент PRIMARY KEY  NONCLUSTERED (CounterpartyID ASC)
go


CREATE TABLE [Lesson]
(
	LessonID int IDENTITY(1,1) NOT NULL ,
	Name nvarchar(30)  NULL ,
	DayWeek int  NULL ,
	TimeSpending varchar(20)  NULL ,
	CounterpartyID int  NULL ,
	Status int  NULL 
)
go


ALTER TABLE Lesson
	ADD CONSTRAINT XPKЗанятие PRIMARY KEY  NONCLUSTERED (LessonID ASC)
go


CREATE TABLE [SubLesson]
(
	LessonID int  NOT NULL ,
	SubID int  NOT NULL 
)
go


ALTER TABLE SubLesson
	ADD CONSTRAINT XPKАбониментЗанятие PRIMARY KEY  NONCLUSTERED (LessonID ASC,SubID ASC)
go


CREATE TABLE [Subscription]
(
	SubID int IDENTITY(1,1) NOT NULL ,
	DatePurchase nvarchar(20)  NULL ,
	DateExpiration nvarchar(20)  NULL 
)
go


ALTER TABLE Subscription
	ADD CONSTRAINT XPKАбонемент PRIMARY KEY  CLUSTERED (SubID ASC)
go


CREATE TABLE [User]
(
	UserID int IDENTITY(1,1) NOT NULL ,
	Type int  NULL ,
	Login nvarchar(40)  NULL ,
	Password nvarchar(40)  NULL ,
	CounterpartyID int  NULL 
)
go


ALTER TABLE [User]
	ADD CONSTRAINT XPKПользователь PRIMARY KEY  NONCLUSTERED (UserID ASC)
go



ALTER TABLE CaSub
	ADD CONSTRAINT  R_8 FOREIGN KEY (CounterpartyID) REFERENCES Counterparty(CounterpartyID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE CaSub
	ADD CONSTRAINT  R_9 FOREIGN KEY (SubID) REFERENCES Subscription(SubID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE Lesson
	ADD CONSTRAINT  R_6 FOREIGN KEY (CounterpartyID) REFERENCES Counterparty(CounterpartyID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE SubLesson
	ADD CONSTRAINT  R_3 FOREIGN KEY (LessonID) REFERENCES Lesson(LessonID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

ALTER TABLE SubLesson
	ADD CONSTRAINT  R_4 FOREIGN KEY (SubID) REFERENCES Subscription(SubID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go



ALTER TABLE [User]
	ADD CONSTRAINT  R_7 FOREIGN KEY (CounterpartyID) REFERENCES Counterparty(CounterpartyID)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
go

