CREATE DATABASE CLAIMS;

USE CLAIMS;

CREATE TABLE MEMBER(MEMBERID INT IDENTITY(1,1) NOT NULL, FIRSTNAME VARCHAR(50) NOT NULL, LASTNAME VARCHAR(50) NOT NULL, AGE INT NOT NULL, GENDER VARCHAR(10) NOT NULL, DOB DATE NOT NULL, CONTACTNUMBER BIGINT NOT NULL, ALTCONTACTNUMBER BIGINT NOT NULL, EMAILID VARCHAR(50) NOT NULL, PASSWORD VARCHAR(50) NOT NULL, PLANCODEID INT NOT NULL, MEMBERPLANID INT NOT NULL, ADDRESSLINE1 VARCHAR(100) NOT NULL, ADDRESSLINE2 VARCHAR(100) NOT NULL, CITY VARCHAR(50) NOT NULL, STATE VARCHAR(50) NOT NULL, ZIPCODE VARCHAR(10) NOT NULL, ACTIVE VARCHAR(10) NOT NULL);

CREATE TABLE ADMIN(ADMINID INT IDENTITY(1,1) NOT NULL, FIRSTNAME VARCHAR(50) NOT NULL, LASTNAME VARCHAR(50) NOT NULL, AGE INT NOT NULL, GENDER VARCHAR(10) NOT NULL, DOB DATE NOT NULL, CONTACTNUMBER BIGINT NOT NULL, ALTCONTACTNUMBER BIGINT NOT NULL, EMAILID VARCHAR(50) NOT NULL, PASSWORD VARCHAR(50), ACTIVE VARCHAR(10) NOT NULL);

CREATE TABLE CLAIM(CLAIMID INT IDENTITY(1,1) NOT NULL, MEMBERID INT NOT NULL, CLAIMSERVICEDATE DATE NOT NULL, CLAIMSUBMISSIONDATE DATE NOT NULL, CLAIMPROCESSINGDATE DATE NOT NULL, CLAIMSTATUS VARCHAR(10) NOT NULL, CLAIMAMOUNT DECIMAL(12,2) NOT NULL, APPROVEDAMOUNT DECIMAL(12,2) NOT NULL);

CREATE TABLE PLANCODE(PLANCODEID INT NOT NULL, PLANDESCRIPTION VARCHAR(50) NOT NULL, COVERAGE1 VARCHAR(50) NOT NULL, COVERAGE2 VARCHAR(50) NOT NULL, COVERAGE3 VARCHAR(50) NOT NULL,COVERAGE4 VARCHAR(50) NOT NULL, COVERAGE5 VARCHAR(50) NOT NULL);

CREATE TABLE MEMBERPLAN(MEMBERPLANID INT IDENTITY(1,1) NOT NULL, MEMBERID INT NOT NULL, PLANCODEID INT NOT NULL, STARTDATE DATE NOT NULL, ENDDATE DATE NOT NULL);

ALTER TABLE MEMBER ADD CONSTRAINT ME_ID PRIMARY KEY (MEMBERID);

ALTER TABLE ADMIN ADD CONSTRAINT AD_ID PRIMARY KEY (ADMINID);

ALTER TABLE CLAIM ADD CONSTRAINT CL_ID PRIMARY KEY (CLAIMID);

ALTER TABLE PLANCODE ADD CONSTRAINT PC_ID PRIMARY KEY (PLANCODEID);

ALTER TABLE MEMBERPLAN ADD CONSTRAINT MP_ID PRIMARY KEY (MEMBERPLANID);

ALTER TABLE MEMBER ADD CONSTRAINT ME_PL_FK FOREIGN KEY (MEMBERPLANID) REFERENCES MEMBERPLAN (MEMBERPLANID);

ALTER TABLE MEMBER ADD CONSTRAINT ME_PC_FK FOREIGN KEY (PLANCODEID) REFERENCES PLANCODE (PLANCODEID);

ALTER TABLE CLAIM ADD CONSTRAINT CL_ME_FK FOREIGN KEY (MEMBERID) REFERENCES MEMBER (MEMBERID);

ALTER TABLE MEMBERPLAN ADD CONSTRAINT MP_PC_FK FOREIGN KEY (PLANCODEID) REFERENCES PLANCODE (PLANCODEID);

ALTER TABLE MEMBERPLAN ADD CONSTRAINT MP_ME_FK FOREIGN KEY (MEMBERID) REFERENCES MEMBER (MEMBERID);

sp_help MEMBER

sp_help [ADMIN]

sp_help CLAIM

sp_help PLANCODE

sp_help MEMBERPLAN

sp_help SUPERUSER
