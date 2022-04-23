Console.Write("Введите скорость первого друга:  ");
float FirstFriendSpeed = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите скорость второго друга:  ");
float SecondFriendSpeed = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите скорость бедной собаки:  ");
float DogSpeed = Convert.ToSingle(Console.ReadLine());
Console.Write("Изначальное расстояние между друзьями:  ");
float TotalDistance = Convert.ToSingle(Console.ReadLine());
Console.Write("Длина собаки:  ");
float DogLength = Convert.ToSingle(Console.ReadLine());

float CurrentDistance = TotalDistance;
int DogDirection = 1;
int DogCount = 0;
float TotalTime = 0;
float CurrentTime = 0;

while (CurrentDistance>DogLength)
{
    if (DogDirection == 1)
    {
        CurrentTime = CurrentDistance/(SecondFriendSpeed + DogSpeed); 
        DogDirection = 2;
    }
    else
    {
        CurrentTime = CurrentDistance/(FirstFriendSpeed + DogSpeed);
        DogDirection = 1;
    }
    CurrentDistance = CurrentDistance - FirstFriendSpeed * CurrentTime - SecondFriendSpeed * CurrentTime;
    TotalTime = TotalTime + CurrentTime;
    DogCount++;
}

Console.WriteLine("Друзья встретятся через {0} часов, собака за это время сбегает 'туда-сюда' {1} раза и пробежит {2} км", TotalTime, DogCount, TotalTime * DogSpeed);