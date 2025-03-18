using Adv_c__revision;

namespace Adv_c__revision
{
    // I want to  create delgate return bool and parametre let us say that it is one param Employee2
    //Syntax:  public delegate returnType DelegateName (param);

    public delegate bool MyDelegate(Employee2 employee);

    public delegate int MyMathDelegate(int left, int right);

    public delegate void MyDelegate1(Employee2 employee);


    //////// Generic Delegates
    // in,out 
    // kewords factor of saftey 
    public delegate void GenericDelegate1<T>(T param);
    public delegate T GenericDelegate2<T>(T param);
    public delegate U GenericDelegate3<in T, out U>(T param);
}
