//Instructions
//You're playing a game of Hungry Hungry Hippos with 3 other people. Every round, player 0 will eat 3 pellets, player 1 will eat 4 pellets, player 2 will eat 6 pellets, and player 3 will eat 1 pellet, in that order. The game ends when there are 0 pellets left.

//Write a method that takes in the starting number of pellets, and return an array containing which turn the game ends on, and which player eats the last pellet.

//Example

//hippo(1) => [1, 0]
//hippo(9) => [1, 2]
//hippo(19) => [2, 1]
//hippo(1) => [1, 0]
//hippo(9) => [1, 2]
//hippo(19) => [2, 1]


//Hippos(1);
//Hippos(19);
//Hippos(9);
//Hippos(9);




static int[] Hippos(int pellets)
{
    int[] playerTurns = { 3, 4, 6, 1 };
    int round = 1;
    int[] result = new int[2];

    while (pellets > 0)
    {
        for (int i = 0; i < playerTurns.Length; i++)
        {
            pellets -= playerTurns[i];
            if (pellets <= 0)
            {
                result[0] = round;
                result[1] = i;
                break;
            }
        }
        round++;
    }

    return result;
}