namespace ConsoleApplication1.Chapter6_OOP.task43
{
    public interface IChampion
    {
        void TakeHit(int opponentDmg);
        void UseAbility(int mana,bool cooldown);
        void ShowStats();
        int GetDamage();
        bool IsAlive();
        bool IsAbilityCoolDown();

    }
}