int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int DogSpeed = 5;
int count = 0;
double distance = 10000;
int meetDistance = 10;
bool friends = true;

while(distance > meetDistance)
{
    double time = 0;
    if(friends == true)
    {
        time = distance/(FirstFriendSpeed + DogSpeed);
        friends = false;
    }
    else
    {
        time = distance/(SecondFriendSpeed + DogSpeed);
        friends = true;
    }
    distance = distance - time  * (FirstFriendSpeed + SecondFriendSpeed);
    count++;
}
Console.WriteLine(count);

