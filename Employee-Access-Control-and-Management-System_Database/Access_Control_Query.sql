access_controlCREATE DATABASE access_control;
USE access_control;

CREATE TABLE employee_info (
	rfid_num 	CHAR(14)	PRIMARY KEY NOT NULL,
	emp_num		CHAR(10)	NOT NULL,
	emp_name		CHAR(5)	NOT NULL,
	emp_gender	ENUM('M', 'W') NOT NULL,
	emp_birth	CHAR(6) NOT NULL
);

INSERT INTO employee_info (rfid_num, emp_num, emp_name, emp_gender, emp_birth) VALUES ('23 24 25 26 27', 12345678, '권순석', 'M', '930222');
SELECT rfid_num FROM employee_info WHERE rfid_num='23 24 25 26 27';