 create database YurtÖðrenciOtomasyonSistem

 use YurtÖðrenciOtomasyonSistem

-- Öðrenci tablosu
CREATE TABLE Ogrenciler (
    OgrenciID INT PRIMARY KEY IDENTITY(1,1),
    TCKimlik VARCHAR(11) UNIQUE NOT NULL,
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    DogumTarihi DATE,
    CepTelefonu VARCHAR(15),
    AileTelefonu VARCHAR(15),
    Email VARCHAR(100),
    KayitTarihi DATE DEFAULT GETDATE(),
    Aktif BIT DEFAULT 1
);

-- Oda tablosu
CREATE TABLE Odalar (
    OdaID INT PRIMARY KEY IDENTITY(1,1),
    OdaNo VARCHAR(10) UNIQUE NOT NULL,
    Kat INT NOT NULL,
    Kapasite INT DEFAULT 4,
    DoluYatakSayisi INT DEFAULT 0
);

-- Yatak tablosu
CREATE TABLE Yataklar (
    YatakID INT PRIMARY KEY IDENTITY(1,1),
    OdaID INT FOREIGN KEY REFERENCES Odalar(OdaID),
    YatakNo VARCHAR(10) NOT NULL,
    Durum BIT DEFAULT 0, -- 0: Boþ, 1: Dolu
    OgrenciID INT FOREIGN KEY REFERENCES Ogrenciler(OgrenciID),
    UNIQUE (OdaID, YatakNo)
);

-- Giriþ-Çýkýþ kayýtlarý
CREATE TABLE GirisCikisKayitlari (
    KayitID INT PRIMARY KEY IDENTITY(1,1),
    OgrenciID INT FOREIGN KEY REFERENCES Ogrenciler(OgrenciID),
    GirisTarihi DATETIME,
    CikisTarihi DATETIME,
    IzinliMi BIT DEFAULT 0,
    Aciklama NVARCHAR(200)
);

-- Yemek kayýtlarý
CREATE TABLE YemekKayitlari (
    KayitID INT PRIMARY KEY IDENTITY(1,1),
    OgrenciID INT FOREIGN KEY REFERENCES Ogrenciler(OgrenciID),
    YemekTarihi DATE DEFAULT GETDATE(),
    YemekTipi TINYINT NOT NULL, -- 1: Kahvaltý, 2: Öðle, 3: Akþam
    YendiMi BIT DEFAULT 0,
    KayitZamani DATETIME DEFAULT GETDATE()
); 

-- Oda tablosuna ek alanlar
ALTER TABLE Odalar ADD Blok VARCHAR(20); -- A Blok, B Blok gibi
ALTER TABLE Odalar ADD Aciklama VARCHAR(200);

-- Yatak tablosuna ek alanlar
ALTER TABLE Yataklar ADD EkOzellikler VARCHAR(100); -- Tek kiþilik, çift kiþilik gibi
ALTER TABLE Yataklar ADD KayitTarihi DATETIME DEFAULT GETDATE();



INSERT INTO Ogrenciler (TCKimlik, Ad, Soyad, DogumTarihi, CepTelefonu, AileTelefonu, Email)
VALUES
('12345678901', 'Ahmet', 'Yýlmaz', '2000-05-15', '5551234567', '2121234567', 'ahmet.yilmaz@mail.com'),
('23456789012', 'Mehmet', 'Kaya', '2001-07-22', '5552345678', '2162345678', 'mehmet.kaya@mail.com'),
('34567890123', 'Ayþe', 'Demir', '1999-03-10', '5553456789', '3123456789', 'ayse.demir@mail.com'),
('45678901234', 'Fatma', 'Þahin', '2000-11-30', '5554567890', '2424567890', 'fatma.sahin@mail.com'),
('56789012345', 'Ali', 'Yýldýz', '2002-01-18', '5555678901', '2165678901', 'ali.yildiz@mail.com');



INSERT INTO Odalar (OdaNo, Kat, Kapasite, Blok, Aciklama)
VALUES
('A101', 1, 4, 'A Blok', '1. Kat Giriþ Katý'),
('A102', 1, 4, 'A Blok', '1. Kat Giriþ Katý'),
('A201', 2, 4, 'A Blok', '2. Kat'),
('A202', 2, 4, 'A Blok', '2. Kat'),
('B101', 1, 4, 'B Blok', '1. Kat Giriþ Katý'),
('B102', 1, 4, 'B Blok', '1. Kat Giriþ Katý');




-- A101 Odasý için yataklar
INSERT INTO Yataklar (OdaID, YatakNo, Durum, OgrenciID, EkOzellikler)
VALUES
(1, 'A101-1', 1, 1, 'Pencere Kenarý'),
(1, 'A101-2', 1, 2, 'Kapý Yaný'),
(1, 'A101-3', 0, NULL, 'Ortada'),
(1, 'A101-4', 0, NULL, 'Pencere Kenarý');

-- A102 Odasý için yataklar
INSERT INTO Yataklar (OdaID, YatakNo, Durum, OgrenciID, EkOzellikler)
VALUES
(2, 'A102-1', 1, 3, 'Pencere Kenarý'),
(2, 'A102-2', 0, NULL, 'Kapý Yaný'),
(2, 'A102-3', 0, NULL, 'Ortada'),
(2, 'A102-4', 0, NULL, 'Pencere Kenarý');

-- Oda dolu yatak sayýlarýný güncelleme
UPDATE Odalar SET DoluYatakSayisi = 2 WHERE OdaID = 1;
UPDATE Odalar SET DoluYatakSayisi = 1 WHERE OdaID = 2;



INSERT INTO GirisCikisKayitlari (OgrenciID, GirisTarihi, CikisTarihi, IzinliMi, Aciklama)
VALUES
(1, '2023-09-01 08:00:00', '2023-09-01 18:00:00', 0, 'Okula gitti'),
(1, '2023-09-01 19:30:00', '2023-09-02 08:15:00', 0, 'Gece yurtta kaldý'),
(2, '2023-09-01 09:00:00', '2023-09-01 17:30:00', 0, 'Ders için çýktý'),
(3, '2023-09-01 10:00:00', '2023-09-03 20:00:00', 1, 'Hafta sonu izinli'),
(4, '2023-09-01 08:30:00', '2023-09-01 21:00:00', 0, 'Günlük aktiviteler');

INSERT INTO YemekKayitlari (OgrenciID, YemekTarihi, YemekTipi, YendiMi)
VALUES
(1, '2023-09-01', 1, 1), -- Kahvaltý
(1, '2023-09-01', 2, 1), -- Öðle
(1, '2023-09-01', 3, 1), -- Akþam
(2, '2023-09-01', 1, 1),
(2, '2023-09-01', 2, 0), -- Yemedi
(2, '2023-09-01', 3, 1),
(3, '2023-09-01', 1, 0), -- Ýzinli olduðu için
(3, '2023-09-01', 2, 0),
(3, '2023-09-01', 3, 0),
(4, '2023-09-01', 1, 1),
(4, '2023-09-01', 2, 1),
(4, '2023-09-01', 3, 1);