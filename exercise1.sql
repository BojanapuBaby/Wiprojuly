Use EmpSample_#OK
GO
--1.one part name
SELECT Name
FROM tblEmployees
WHERE Name NOT LIKE '% %'
GO


--2.Three part name

select emp.Name
from dbo.tblEmployees emp
where emp.Name like '[a-z]%[ ][a-z]%[ ][a-z]%' and emp.Name not like '[a-z]%[ ][a-z]%[ ][a-z]%[ ][a-z]%';

--3.have a First Middle Or last name as Ram, and not any thing else

select emp.Name
from dbo.tblEmployees emp
where emp.Name like 'ram[ ]%' or emp.Name like '%[ ]ram' or emp.Name like '%[. ]ram[ ]%';
GO

--4.1  65 OR 11

select emp.EmployeeNumber, emp.Name, emp.CentreCode
from dbo.tblEmployees emp
where emp.CentreCode = 65 or emp.CentreCode = 11;

--4.2   65 XOR 11

select COUNT(*)
from dbo.tblEmployees emp
where (emp.CategoryCode = 65 and emp.CentreCode <> 11) or ((emp.CategoryCode <> 65 and emp.CentreCode = 11));
  
  
--4.3  65 AND 11

select emp.EmployeeNumber, emp.Name, emp.CentreCode, emp.CategoryCode
from tblEmployees emp
where emp.CategoryCode = 12 and emp.CentreCode = 4;

--4.4  (12 AND 4) OR ( 13 AND 1)

select emp.EmployeeNumber, emp.Name, emp.CentreCode, emp.CategoryCode
from dbo.tblEmployees emp
where (emp.CategoryCode=12 and emp.CentreCode=4)or (emp.CategoryCode=13 and emp.CentreCode=1);
 
--4.5   127  OR  64

select emp.EmployeeNumber, emp.Name
from dbo.tblEmployees emp
where emp.EmployeeNumber = 127 or emp.EmployeeNumber = 64;

--4.6   127  XOR 64

select emp.EmployeeNumber,emp.Name
from dbo.tblEmployees emp
where (emp.CategoryCode = 127 and emp.CentreCode <> 64) or ((emp.CategoryCode <> 127 and emp.CentreCode = 64));

--4.7    127 XOR 128


select emp.EmployeeNumber,emp.Name
from dbo.tblEmployees emp
where (emp.CategoryCode = 127 and emp.CentreCode <> 128) or ((emp.CategoryCode <> 127 and emp.CentreCode = 128));

--4.8    127 AND 64

select emp.EmployeeNumber, emp.Name
from dbo.tblEmployees emp
where emp.EmployeeNumber = 127 and emp.AreaCode = 64;

--4.9    127 AND 128

select emp.EmployeeNumber, emp.Name
from dbo.tblEmployees emp
where emp.EmployeeNumber = 127 and emp.AreaCode = 128;

--5  returns data in all columns from the table dbo.tblCentreMaster

SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'tblCentreMaster'
GO

--6   query which gives employee types in the organization

select distinct emp.EmployeeType
from dbo.tblEmployees emp;

--which returns Name, FatherName, DOB of employees whose PresentBasic 
--7.1   Greater than 3000.

select name,fatherName,DOB,presentbasic
from tblEmployees
where presentbasic > 3000;

--7.2    Less than 3000.

select name,fatherName,DOB,presentbasic
from tblEmployees
where presentbasic < 3000;


--7.3    Between 3000 and 5000.

select name,fatherName,DOB,presentbasic
from tblEmployees
where presentbasic between 3000 and 5000;

---which returns All the details of employees whose Name
--8.1   Ends with 'KHAN'

select *
from dbo.tblEmployees emp
where emp.Name like '%khan';
GO

--8.2      Starts with 'CHANDRA'

select *
from dbo.tblEmployees emp
where emp.Name like 'chandra%';
GO

--8.3  Is 'RAMESH' and their initial will be in the rage of alphabets a-t.

select emp.Name 
from dbo.tblEmployees emp
where emp.Name like '[a-t][.]Ramesh';
GO

