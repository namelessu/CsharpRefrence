using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_c__revision
{
    internal interface IInterface1
    {
        //First etter must be upper case and must be 'I'
        //First letter of the name must be upper case
        //auto properties
        //methods headers ==>abstract method
        //there is no access modifiers in interface all are public by default

        //string name; //cannot contain instance fields
        int Id { get; set; }
        string Name {  get; set; }

        //private int Id { get { return "";  } set { name = ""; } } //cannot define private property in interface
        void SignIn();
        void SignOut();
        int Add(int x,int y);
    }
    interface IInterface2
    {
        void SignIn();
        void SignOut();
        public int Add(int x, int y);
        int Sub(int x, int y);

    }
}
