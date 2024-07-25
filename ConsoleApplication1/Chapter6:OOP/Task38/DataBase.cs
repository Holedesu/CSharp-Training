using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task38
{
    public class DataBase
    {
        private List<PlayerPartThree> _userDatabase;
        
        public DataBase()
        {
            _userDatabase = new List<PlayerPartThree>();
        }

        public void AddData(PlayerPartThree player)
        {
            _userDatabase.Add(player);
        }

        public void ShowAllData()
        {
            foreach (var data in _userDatabase)
            {
                data.ShowInfo();
            }
        }
        
        public void BanPlayer(int id)
        {
            foreach (var data in _userDatabase)
            {
                if (data.ShowId() == id)
                {
                    data.BanPlayer();
                }
            }
        }
        
        public void UnbanPlayer(int id)
        {
            foreach (var data in _userDatabase)
            {
                if (data.ShowId() == id)
                {
                    data.UnbanPlayer();
                }
            }
        }



    }
}