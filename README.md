# Ответы на вопросы:

---

### 1) Опыт был, верстал сайты с макетов Figma, на данный момент практикую ASP.NET , хочу вернуться к web-разработке, уж очень мне это нравилось)
### https://github.com/RudovEgor/Hinkalnya - веб проект

---

### 2) Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным


###  https://github.com/RudovEgor/MindBoxTask - тестовое задание

---

### 3) В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

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
	(2, 1),
	(3, 2);

    SELECT P."Name", C."Name"
    FROM Products P
    LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
    LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
  
---  
  
### 4) ДА!). Я давно узнал о вашей компании и было бы очень круто если бы свой долгий путь программиста начинался именно с вами, я попробую выжать из стажировки, и в последующей работе надеюсь, максимум пользы для себя и для вас)
