// See https://aka.ms/new-console-template for more information

var task1 = Task.Run(() =>
{
    Test.GetInstance();
});

var task2 = Task.Run(() =>
{
    Test.GetInstance();
});

await Task.WhenAll(task1, task2);


class Test
{
    private Test()
    {
        Console.WriteLine($"{nameof(Test)} nesnesi üretildi.");
    }
    static Test _test;

    static Test()
    {
        _test = new Test();
    }
    static public Test GetInstance()
    {
        return _test;
    }
}
