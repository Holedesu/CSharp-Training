using System;
using System.Collections.Generic;

namespace ConsoleApplication1.Chapter6_OOP.Task45
{
    public class Squad
    {
        private string _countryName;
        private List<Soldier> _squad;
        private List<Soldier> _deseased;
        private int _numberOfSoldiers;
        
        
        public Squad(string countryName, int numberOfSoldiers)
        {
            _countryName = countryName;
            _numberOfSoldiers = numberOfSoldiers;
            createSquad(numberOfSoldiers);
            _deseased = new List<Soldier>();
        }
        
        private void createSquad(int numberOfSoldiers)
        {
            _squad = new List<Soldier>();
            Random rand = new Random();
            
            int i = 0;
            while (i < numberOfSoldiers)
            {
                Soldier newSoldier = new Soldier(rand.Next(10, 50), rand.Next(10, 50));
                _squad.Add(newSoldier);
                i++;
            }
        }
        
        public bool IsSquadDeceased()
        {
            if (_squad.Count == 0)
            {
                return true;
            }
            return false;
        }
        
        public void TakeDamage(Squad squad)
        {
            Random random = new Random();
            foreach (var soldier in squad._squad)
            {
                if (IsSquadDeceased())
                {
                    return;
                }
                Soldier currentSoldier = _squad[random.Next(0, _squad.Count)];
                currentSoldier.TakeDamage(soldier.GetDamage());
                if (currentSoldier.IsDead())
                {
                    _deseased.Add(currentSoldier);
                    _squad.Remove(currentSoldier);
                }
            }
        }
        
        public string GetCountryName()
        {
            return _countryName;
        }
        
        public void ShowSquad()
        {
            foreach (var soldier in _squad)
            {
                soldier.ShowInfo();
            }
        
            Console.ReadLine();
        }
        
        public void ShowDeseased()
        {
            foreach (var soldier in _deseased)
            {
                soldier.ShowInfo();
            }
            Console.WriteLine("Total number of deseased: " + _deseased.Count);
        }
    }
}