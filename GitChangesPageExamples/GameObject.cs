using System;

namespace game
{
    class GameObject
    {
        private int posX, posY;

        public GameObject(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }

        public void interact()
        {
            throw new NotImplementedException();
        }

        public void draw()
        {
            throw new NotImplementedException();
        }
    }
}