// Виды методов


// Вид 1
void MethodType1 ()
{
    Console.WriteLine("хай");
}

MethodType1();

// Вид 2
void MethodType2 (string msg)
{
    Console.WriteLine(msg);
}

string msg = "шалом";

MethodType2(msg);

void MethodType2_1 (string msg, int count)
{
    int i = 0;
    while (i < count) {
    Console.WriteLine(msg);
    i++;
    }
}

MethodType2_1 (count: 4, msg: "повторяемый текст");



// Вид 3

int MethodType3 ()
{

return DateTime.Now.Year;     
}

Console.WriteLine(MethodType3());

// Вид 4

string Method4 (int count, string msg){

    int i = 0;
    string res = String.Empty;
    while (i < count){
        res = res + msg;
        i++;
    }
    return res;
}

Console.WriteLine(Method4(count: 3, "раз "));


string Method4_2 (int count, string msg){

    string res = String.Empty;
    for (int i = 0; i < count; i++){
        res = res + msg;
    }
    return res;
}

Console.WriteLine(Method4_2(count: 3, "два "));


