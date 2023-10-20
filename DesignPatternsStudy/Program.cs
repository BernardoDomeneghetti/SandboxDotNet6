using DesignPatternsNet6.Models.Prototype;

internal class Program
{
    private static void Main(string[] args)
    {

        
    }

    private void PrototypePaternExample()
    {
        var obj1 = new Example(){Name = "Test"};
        var obj2 = obj1;

        obj2.Name = "Test2";
        
        Console.WriteLine("Obj nome da classe: {0} nome referencia: {1} Nome propriedade: {2}", obj1.GetType().ToString(), nameof(obj1), obj1.Name);
        Console.WriteLine("Obj nome da classe: {0} nome referencia: {1} Nome propriedade: {2}", obj1.GetType().ToString(), nameof(obj2), obj2.Name);
        

        var obj3 = new CloneableExample(){Name = "ClonableTest"};
        var obj4 = (CloneableExample)obj3.Clone();

        obj4.Name = "ClonableTest2";

        Console.WriteLine("Obj nome da classe: {0} nome referencia: {1} Nome propriedade: {2}", obj3.GetType().ToString(), nameof(obj3), obj3.Name);
        Console.WriteLine("Obj nome da classe: {0} nome referencia: {1} Nome propriedade: {2}", obj4.GetType().ToString(), nameof(obj4), obj4.Name);
    }
}