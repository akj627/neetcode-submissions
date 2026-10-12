public interface IShape {
    IShape Clone();
}

public class Rectangle : IShape {
    private int width;
    private int height;

    public Rectangle(int width, int height) {
        this.width = width;
        this.height = height;
    }

    public int GetWidth() {
        return this.width;
    }

    public int GetHeight() {
        return this.height;
    }

    public IShape Clone() {
        return new Rectangle(GetWidth(), GetHeight());
    }
}

public class Square : IShape {
    private int length;

    public Square(int length) {
        this.length = length;
    }

    public int GetLength() {
        return this.length;
    }

    public IShape Clone() {
        return new Square(GetLength());
    }
}

public class Test {
    public List<IShape> CloneShapes(List<IShape> shapes) {
        var ret = new List<IShape>();
        foreach (var shape in shapes)
        {
            ret.Add(shape.Clone());
        }
        return ret;
    }
}
