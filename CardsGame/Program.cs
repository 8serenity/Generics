using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    /*Программа «Карточная игра!»
    Создать модель карточной игры.
    
    Требования:
    
    Класс Game формирует и обеспечивает:
    Список игроков (минимум 2);
    Колоду карт (36 карт);
    Перетасовку карт (случайным образом);
    Раздачу карт игрокам (равными частями каждому игроку);

    Игровой процесс.
    
    Принцип: Игроки кладут по одной карте. У кого карта больше,
    то тот игрок забирает все карты и кладет их в конец своей колоды.
    
    Упрощение: при совпадении карт забирает первый игрок,
    шестерка не забирает туза.
    Выигрывает игрок, который забрал все карты.

    Класс Player (набор имеющихся карт, вывод имеющихся карт).
    Класс Karta (масть и тип карты (6–10, валет, дама, король, туз).
    */


    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = 4;
            Game gameNew = new Game(numberOfPlayers);
            bool GameOver = false;
            //foreach(var x in gameNew.TotalCards)
            //{
            //    Console.WriteLine("Rank {0} Suit {1}", x.Rank, x.Suit);
            //}

            while (!GameOver)
            {
                for (int i = 0; i < gameNew.Players.Count; i++)
                {
                    Console.WriteLine("Player {0}, choose your card to play:", i + 1);
                    for (int j = 0; j < gameNew.Players[i].PlayerCards.Count; j++)
                    {
                        Console.WriteLine("Card {0} - {1} of {2}", j + 1, gameNew.Players[i].PlayerCards[j].Rank, gameNew.Players[i].PlayerCards[j].Suit);
                    }
                    int playerChoice = Convert.ToInt32(Console.ReadLine());
                    gameNew.Players[i].ChooseCard(playerChoice - 1);
                }
                gameNew.ChooseWinner();
                for (int i = 0; i < gameNew.Players.Count; i++)
                {
                    if (gameNew.Players[i].PlayerCards.Count <= 0)
                    {
                        gameNew.Players.RemoveAt(i);
                    }
                }
                if (gameNew.Players.Count <= 1)
                {
                    GameOver = true;
                }
            }






            Console.Read();

        }
    }
}
