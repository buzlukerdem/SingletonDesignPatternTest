// See https://aka.ms/new-console-template for more information



// Singleton Design Pattern Practices
#region 1.Practice
var instance = MyClass.GetMyClassInstance();
var instance2 = MyClass.GetMyClassInstance();
var instance3 = MyClass.GetMyClassInstance();
var instance4 = MyClass.GetMyClassInstance();


class MyClass
{
    //new ile nesne üretimi engellendi.
    private MyClass()
    {
        Console.WriteLine($"{nameof(MyClass)} nesnesi üretildi.");
    }
    //static global field
    static MyClass _myClassInstance;
    //static ctor
    static MyClass()
    {
        _myClassInstance = new MyClass();
    }
    // static member 
    public static MyClass GetMyClassInstance()
    {
        #region 1.Yöntem Kontrollü
        if (_myClassInstance == null)
            _myClassInstance = new MyClass();
        return _myClassInstance;
        #endregion
        #region 2.Yöntem kontrolsüz.
        return _myClassInstance;
        #endregion

    }
}

#endregion

