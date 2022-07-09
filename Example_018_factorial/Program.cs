double Factorial (int num){
    if (num == 1) return 1;
    return num*Factorial(num-1);
}
// Console.WriteLine(Factorial(1));
// Console.WriteLine(Factorial(2));
// Console.WriteLine(Factorial(3));
// Console.WriteLine(Factorial(4));

for (int i = 1; i < 40; i++){

   Console.WriteLine($"{i}! = {Factorial(i)}");
}