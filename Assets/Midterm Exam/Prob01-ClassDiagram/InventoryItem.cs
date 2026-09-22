using UnityEngine;

namespace MidtermExam.Prob01
{
    public class InventoryItem
    {
        // TODO: Implement fields and methods according to Class Diagram
        public string itemName;
        protected int weight;
        int itemValue;
        public virtual void Use(Character user)
        {

        }
    }
}
