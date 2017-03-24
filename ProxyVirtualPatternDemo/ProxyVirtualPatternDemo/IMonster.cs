using System.Drawing;

namespace ProxyVirtualPatternDemo
{
    public interface IShape
    {
        void Move(Point p);
        void Draw();
    }
}