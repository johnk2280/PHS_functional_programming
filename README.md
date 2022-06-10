# PHS_functional_programming

### 1. Первая программа на F#.
####  Задания:

1. Напишите программу, выводящую строку "Hello, World!!!"

2. Напишите программу, вычисляющую и выводящую на экран значение выражения 2.1 + 3.2 * (8 / 4 + 1.3)

----
### 2. Объявление, определение функций.
#### Задания: 

1. Напишите функцию g(n) = n + 5 без использования анонимной функции, и в комментариях укажите её тип.

2. Реализуйте функцию gg(n) = n + 5 с помощью лямбда-функции.

3. Напишите функцию h(x,y) (тип float * float -> float), где h(x,y) вычисляет корень из суммы квадратов параметров. Для расчёта корня используйте стандартную функцию System.Math.Sqrt.
---

### 3. Функциональные выражения с шаблонами.
#### Задание:

Напишите функцию, использующую сопоставление с образцом, которая получает на вход номер месяца (1-январь .. 12-декабрь) и возвращает целое число -- количество дней в нём, или 0, если номер месяца некорректный.

---
### 4. Рекурсия.
#### Задания:

1. Напишите рекурсивную функцию fibo: int -> int, где fibo(n) вычисляет n-е число Фибоначчи (n >= 0, fibo(0)=0, fibo(1)=1, ...). Последовательность Фибоначчи начинается с двух значений 0,1, а n-й элемент равен сумме n-1 - го и n-2 - го элементов: 0,1,1,2,3,5,8,13,...

2. Напишите рекурсивную функцию sum: int -> int, где sum(n) вычисляет сумму первых n чисел ряда 1 + 2 + 3 + ... + n-1 + n
Параметр n -- натуральное число.

3. Напишите рекурсивную функцию sum2: int * int -> int, где sum2(m, n) вычисляет сумму m + m+1 + ... + m+(n-1) + m+n, где m >= 0 и n >= 0.
Используйте шаблоны (m,0) и (m,n).

----

### 5. Типы и операторы.
#### Задания:

1. Напишите функцию-предикат notDivisible: int * int -> bool, где notDivisible(n,m) возвращает true, если число n -- делитель числа m.

2. Напишите функцию-предикат prime: int -> bool, где prime(n) возвращает true, если n -- простое число.

----

### 6. Символы и строки.
#### Задания:

1. Напишите функцию pow: string * int -> string, где pow(s,n) выдаёт строку s, повторенную n раз.

2. Напишите функцию-предикат isIthChar: string * int * char -> bool, где isIthChar(s,n,c) проверяет, равен ли n-й (начиная с нуля) символ строки s символу c.

3. Напишите функцию occFromIth: string * int * char -> int, где occFromIth(s,n,c) возвращает количество вхождений символа с в строке s, начиная с позиции n.

----

### 7. Композиция и каррирование.
#### Задания:
1. Напишите функцию vat: int -> float -> float, так что vat n x увеличивает x на n процентов (0 <= n <= 100).

2. Напишите функцию unvat: int -> float -> float такую, что
unvat n (vat n x) = x

3. Напишите функцию min: (int -> int) -> int, так что min(f) вычисляет минимальное целое положительное число n, когда f(n) = 0. Подразумевается, что такое натуральное число существует всегда.

----
### 8. Замыкания (closures).
#### Задание:
Даны две функции:

    **curry: (int * int -> int) -> int -> int ->int**

и

    **uncurry: (int -> int ->int) -> int * int -> int**

curry f -- это функция g, где g x -- это функция h, где h y = f(x,y).

uncurry g -- это функция f, где f(x,y) -- это значение h y для функции h = g x.

Напишите их реализации.

----
### 9. Объявление операторов.

#### Задания:

1. В фэнтези-РПГ принята следующая денежная система: в одном золотом 20 серебряных, а в одном серебряном 12 медяков. Суммы в такой системе задаются тройками целых чисел (золотые, серебряные, медяки), например (1, 0, 128) или (32, 23, 5).
Реализуйте инфиксный оператор **.+.** , который складывает деньги, представленные в виде троек, и инфиксный оператор **.-.** , который вычитает деньги. Результат приводите к формату, когда количество медяков не превышает 11, а количество серебряных не превышает 19.

2. Реализуйте логику работы с комплексными числами. Комплексное число задаётся парой вещественных чисел (x,y).

   Правила сложения и умножения:

   (a, b) + (c, d) = (a + c, b + d)
   (a, b) * (c, d) = (ac - bd, bc + ad)
   
   Вычитание реализуется сложением через инверсию:

   -(a, b) = (-a,-b),
   
   Деление реализуется умножением через инверсию:

   1/(a, b) = (a/(a^2+b^2),-b/(a^2+b^2))
   Реализуйте соответствующие инфиксные операторы .+ , .- , .* и ./ .
   
----
### 10. Записи (records).
#### Задание:

Время дня может быть представлено тройкой (часы, минуты, половина дня), где часы принимают значение в диапазоне от 0 до 11, минуты -- от 0 до 59, и половина дня -- это либо "AM" (первые 12 часов), либо "PM" (вторые 12 часов).

Реализуйте инфиксный оператор .>. , который сравнивает два корректных значения типа TimeOfDay.

----
### 11. Размеченные объединения.

#### Задание:

Реализуйте задание 24.4, в котором половина дня представлена не строкой, а размеченным объединением F.

----
