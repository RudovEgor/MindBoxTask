# Ответы на вопросы:

---

### 1) https://github.com/RudovEgor/Hinkalnya - веб проект

---

### 2) https://github.com/RudovEgor/MindBoxTask - тестовое задание

---

### 3)
    CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
    );

    INSERT INTO Products
    VALUES
	(1, 'C# in a Nutshell'),
	(2, 'KIA Rio'),
	(3, 'ASUS Rog Strix');

    CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
    );

    INSERT INTO Categories
    VALUES
	(1, 'Book'),
	(2, 'Car'),
	(3, 'Gift');

    CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
    );

    INSERT INTO ProductCategories
    VALUES
	(1, 1),
	(1, 3),
	(2, 2);

    SELECT P."Name", C."Name"
    FROM Products P
    LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
    LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
  
---  
  
### 4) ДА!). Я давно узнал о вашей компании и было бы очень круто если бы свой долгий путь программиста начинался именно с вамиm
