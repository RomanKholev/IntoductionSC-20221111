// Обмен значениями 
/*int a=5;
int b=7;
int temp;
temp=a;
a=b;
b=temp;
*/
//Без использования третьей переменной
/*Int a=5;
int a=7;
a=a+b;
b=a-b;
a=a-b;
*/

//Альернативный способ
Int a=5;
int a=7;
a=a^b;
b=a^b;
a=a^b;