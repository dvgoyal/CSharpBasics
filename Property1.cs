using System;

public class Rectangle{
    double _length;
    double _width;
    double _area;
    public double Length{
        get => _length;
        set => _length = value;
    }
    public double Width{
        get{
           return _width;
        }
        set{
            _width = value;
        }
    }
    public Rectangle(double l, double w){
        _length = l;
        _width = w;
    }
    public double getArea(){
        _area = _length * _width;
        return _area;
    }
}

public class ClientCode{
    public static void Main(){
        Rectangle r = new Rectangle(5, 8);
        Console.WriteLine(r.getArea());
        r.Length = 20;
        r.Width = 15;
        Console.WriteLine(r.getArea());
        
        Rectangle r2 = new Rectangle(r.Length, r.Width + 2);
        Console.WriteLine(r2.getArea());
    }
}
