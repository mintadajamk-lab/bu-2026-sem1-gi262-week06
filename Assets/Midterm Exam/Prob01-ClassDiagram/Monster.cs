using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Monster : Character
    {
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public int basseDamage;
        protected int aggroRange;
        public override void Attack(GameEntity target)
        {
            
        }
        protected virtual void Roar()
        {
            
        }
    }
}
