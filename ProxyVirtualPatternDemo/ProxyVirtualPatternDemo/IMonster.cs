using System.Drawing;

namespace ProxyVirtualPatternDemo
{
    enum Races
    {
        Earth ,Magic
    }

    public interface IMonster
    {
        void Move(Point p);
        void Draw();
    }
}