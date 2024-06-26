using System;

namespace ClassLibrary1
{
  //delegate type
  public delegate void MyDelegateType(int a,  int b);

  //publisher
  public class Publisher
  {
    //private delegate
    //private MyDelegateType myDelegate;

    //step1: create event
    //public event MyDelegateType myEvent
    //{
    //  add
    //  {
    //    myDelegate += value;
    //  }

    //  remove 
    //  { 
    //    myDelegate -= value;
    //  }
    //}

    //Auto-Implemented Events
    //public event MyDelegateType myEvent;

    //Func
    //public event Func<int, int, int> myEvent;

    //Action
    public event Action<int, int> myEvent;

    //Needed for event with delegate
    //public void RaiseEvent(int a, int b)
    //{
    //  //step2: raise event
    //  if (this.myDelegate != null)
    //  {
    //    this.myDelegate(a, b);
    //  }
    //}

    //Auto-Implemented Events
    public void RaiseEvent(int a, int b)
    {
      //step2: raise event
      if (this.myEvent != null)
      {
        this.myEvent(a, b);
      }
    }

  }
}
