namespace Adv_c__revision
{
    class Instructor : IInterface1, IInterface2
    {
        public int Any { get; set; }
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        int IInterface1.Add(int x, int y)
        {
            return 11;
        }

        int IInterface2.Add(int x, int y)
        {
            return 22;
        }

        void IInterface1.SignIn()
        {
            Console.WriteLine("Inside IInterface1");
        }

        void IInterface2.SignIn()
        {
            Console.WriteLine("Inside IInterface2");
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }
        public string Print(string text)
        {
            throw new NotImplementedException();
        }
        public int Sub(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}