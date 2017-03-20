using System.Drawing;

namespace ProxyVirtualPatternDemo
{
    public interface CreateShape
    {
        void Move(Point p);
        void Draw();
    }
}