# Figures

## Задание 1:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
* Юнит-тесты
* Легкость добавления других фигур
* Вычисление площади фигуры без знания типа фигуры в compile-time
* Проверку на то, является ли треугольник прямоугольным

## Решение:

Figures - библиотека с фигурами

FigureTests - тесты

FiguresApp - консольное приложение с демонстрацией

[![Generic badge](https://img.shields.io/badge/.NET%20version-6.0-blue.svg?style=flat&logo=.NET)](https://shields.io/)
[![Maintainability](https://api.codeclimate.com/v1/badges/fe8a5fd502e7e53c812a/maintainability)](https://codeclimate.com/github/winerar/FiguresApp/maintainability)

## Задание 2:

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

## Решение:

Предположим, что структура БД следующая:

* Products - таблица продуктов, содержит Name и Id

* Categories - таблица категорий, содержит Name и Id

* ProductCategories - таблица соответствия продуктов и категорий, содержит ProductId и CategoryId.

Тогда получим запрос:

```sql
SELECT Products.Name
SELECT P.Name as ProductName, C.Name as CategoryName
FROM Products P
LEFT JOIN ProductCategories PC
ON P.Id = PC.ProductId
LEFT JOIN Categories C
ON PC.CategoryId = C.Id
```
