double distance = 10000;
double firstFriendSpeed = 1, secondFriendSpeed = 2, dogSpeed = 5;
double time;

int count = 0;
int friend = 2;

while (distance > 1){
if (friend == 3){
    time = distance/(firstFriendSpeed + dogSpeed);
    friend = 2;
    }
else {
    time = distance/(secondFriendSpeed + dogSpeed);
    friend = 1;
    }
distance = (firstFriendSpeed+secondFriendSpeed)*time;
count +=1;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз/а");