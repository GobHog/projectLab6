using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectLab6
{

    public class Player
    {
        public string name
        {
            get;
            set;
        }
        public int money_amount
        {
            get;
            set;
        }
        public int the_biggest_win
        {
            get;
            set;
        }
        public Player(string name)
        {
            this.name = name;
            money_amount = 1000;
            the_biggest_win = 0;
        }

        public List<int> Spots=new List<int>();
        public void clearSpots()
        {
            Spots.Clear();
        }
        public void makeSpot(int spot)
        {
            bool containsVariable = Spots.Contains(spot);
            if (containsVariable)
            {
                int[] newArr = new int[15];
                int index = 0;
                foreach (int element in Spots)
                {
                    if (element != spot)
                    {
                        newArr[index] = element;
                        index++;
                    }
                }
                Spots = newArr.ToList();
            }
            else
            {

                if(Spots.All(el => el > 0))
                {
                    //Вывод сообщения о том, что больше 15 шаров выбрать нельзя
                }
                else
                {
                    int i=0;
                    while (Spots[i]!=0) 
                    {
                        i++;
                    }
                    Spots[i]=spot;
                }
            }
        }
        public int checkWin(List<Round> rounds)
        {
            int number = 0;
            foreach (Round round in rounds)
            {
                number += round.win_amount;
            }
            return number;
        }
        public Match makeMatch(int bet, int round, int[] list_spot)
        {
            var new_match= new Match(bet, round, list_spot);
            return new_match;
        }
    }
}
