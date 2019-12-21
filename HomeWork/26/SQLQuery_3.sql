CREATE DATABASE  AirportInfo;

USE AirportInfo
GO
CREATE TABLE DepartureBoard(
    FlightNumber CHAR(6) NOT NULL,
    CityOfDeparture VARCHAR(20) NOT NULL,
    CountryOfDeparture VARCHAR(20) NOT NULL,
    DataDeparture DATETIME2,
    CityOfArrival VARCHAR(20) NOT NULL,
    CountryOfArrival VARCHAR(20) NOT NULL,
    DateArrival DATETIME2,
    FlightTime TIME,
    Airline VARCHAR(10) NOT NULL,
    AirplaneModel VARCHAR(20) NOT NULL
);

INSERT INTO DepartureBoard
VALUES('SU3888','MOSCOW','RUSSIA','2019-12-31 14:12','SOCHI','RUSSIA','2019-12-31 16:12','2:00:00','S7','AIRBUS A319'),
      ('SU3558','SOCHI','RUSSIA','2020-01-11 15:35','MOSCOW','RUSSIA','2020-01-11 17:35','2:00:00','S7','AIRBUS A319');

SELECT * FROM DepartureBoard;

DROP DATABASE AirportInfo;

