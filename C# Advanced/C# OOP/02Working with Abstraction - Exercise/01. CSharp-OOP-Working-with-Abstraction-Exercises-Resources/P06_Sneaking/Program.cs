using System;

namespace P06_Sneaking
{
    class Sneaking
    {
        static char[][] room;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            room = new char[n][];
            IntilizateRoom(n);

            var moves = Console.ReadLine().ToCharArray();
            int[] position = new int[2];
            GetPositionSam(position);

            for (int i = 0; i < moves.Length; i++)
            {
                for (int row = 0; row < room.Length; row++)
                {
                    for (int col = 0; col < room[row].Length; col++)
                    {
                        if (room[row][col] == 'b')
                        {
                            if (row >= 0 && row < room.Length && col + 1 >= 0 && col + 1 < room[row].Length)
                            {
                                room[row][col] = '.';
                                room[row][col + 1] = 'b';
                                col++;
                            }
                            else
                            {
                                room[row][col] = 'd';
                            }
                        }
                        else if (room[row][col] == 'd')
                        {
                            if (row >= 0 && row < room.Length && col - 1 >= 0 && col - 1 < room[row].Length)
                            {
                                room[row][col] = '.';
                                room[row][col - 1] = 'd';
                            }
                            else
                            {
                                room[row][col] = 'b';
                            }
                        }
                    }
                }

                int[] getEnemy = new int[2];
                for (int j = 0; j < room[position[0]].Length; j++)
                {
                    if (room[position[0]][j] != '.' && room[position[0]][j] != 'S')
                    {
                        getEnemy[0] = position[0];
                        getEnemy[1] = j;
                    }
                }
                if (HasEnemy(position, getEnemy))
                {
                    //position[1] < getEnemy[1] && room[getEnemy[0]][getEnemy[1]] == 'd' && getEnemy[0] == position[0];
                    Died(position);
                }
                else if (getEnemy[1] < position[1] && room[getEnemy[0]][getEnemy[1]] == 'b' && getEnemy[0] == position[0])
                {
                    Died(position);
                }


                room[position[0]][position[1]] = '.';
                switch (moves[i])
                {
                    case 'U':
                        position[0]--;
                        break;
                    case 'D':
                        position[0]++;
                        break;
                    case 'L':
                        position[1]--;
                        break;
                    case 'R':
                        position[1]++;
                        break;
                    default:
                        break;
                }
                room[position[0]][position[1]] = 'S';

                for (int j = 0; j < room[position[0]].Length; j++)
                {
                    if (room[position[0]][j] != '.' && room[position[0]][j] != 'S')
                    {
                        getEnemy[0] = position[0];
                        getEnemy[1] = j;
                    }
                }
                if (room[getEnemy[0]][getEnemy[1]] == 'N' && position[0] == getEnemy[0])
                {
                    room[getEnemy[0]][getEnemy[1]] = 'X';
                    Console.WriteLine("Nikoladze killed!");
                    for (int row = 0; row < room.Length; row++)
                    {
                        for (int col = 0; col < room[row].Length; col++)
                        {
                            Console.Write(room[row][col]);
                        }
                        Console.WriteLine();
                    }
                    Environment.Exit(0);
                }
            }
        }

        private static void Died(int[] position)
        {
            room[position[0]][position[1]] = 'X';
            Console.WriteLine($"Sam died at {position[0]}, {position[1]}");
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        private static bool HasEnemy(int[] position, int[] getEnemy)
        {
            return position[1] < getEnemy[1] && room[getEnemy[0]][getEnemy[1]] == 'd' && getEnemy[0] == position[0];
        }

        private static void GetPositionSam(int[] position)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'S')
                    {
                        position[0] = row;
                        position[1] = col;
                    }
                }
            }
        }

        private static void IntilizateRoom(int n)
        {
            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                room[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];
                }
            }
        }
    }
}
