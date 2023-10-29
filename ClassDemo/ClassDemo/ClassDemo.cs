class ClassDemo
{
    static void Main()
    {
        ClassOne.Hi();
        ClassTwo.Hi();

        ClassTwo ct = new ClassTwo();
        ct.Hello();
    }
}