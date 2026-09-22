using UnityEngine;

namespace MidtermExam.Prob01
{
    public class GameEntity
    {
        // TODO: Implement fields and methods according to Class Diagram
        public string id;
        Vector3 postition;
        protected int health;
        public virtual void Update()
        {
        }

        public virtual void TakeDamage(int damage)
        {
        }

        public virtual void Move(Vector3 direction)
        {
        }

    }

}