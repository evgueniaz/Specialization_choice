# Specialization_choice

**Задача**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

**Solution**

1. Ask a user to enter an array size
2. Check whether the entered value is numerical and positive. If so, pass to the next step, if not, go to the previous step.
3. Create an array of string values of the user's size.
4. Create a second zero size array for results.
5. Fill in the first array by values entered by the user through a cycle.
6. Print the first array.
7. Through a cycle check one by one the length of each value of the first array. If the value has a length smaller than 4, then the size of the second array is increased by 1 and the value is added to the second array.
8. Print the second (resulting) array.

