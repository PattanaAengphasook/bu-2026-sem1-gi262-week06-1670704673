using UnityEngine;

namespace MidtermExam.Prob01
{
    public class Character
    {
        public string characterName;
        protected float moveSpeed;
        private int level;
        // TODO: Implement inheritance, fields and methods according to Class Diagram
        public virtual void Attack(GameEntity target)
        {
            Debug.Log(characterName + "‚®¡µ’");
        }
        protected virtual void LevelUp()
        {
            Debug.Log(characterName += 1 + "‡≈‡«≈Õ—æ");
        }
    }
}
