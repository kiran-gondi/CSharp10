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
    //public event Action<int, int> myEvent;

    //Predicate
    //public event Predicate<int> myEvent;

    //EventHandler
    public event EventHandler<CustomEventArgs> myEvent;

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
    //public bool RaiseEvent(int a)
    //{
    //  //step2: raise event
    //  if (this.myEvent != null)
    //  {
    //    bool result = this.myEvent(a);
    //    return result;
    //  }
    //  else
    //  {
    //    return false;
    //  }
    //}

    //EventArgs
    public void RaiseEvent(object sender, int a, int b)
    {
      //step2: raise event
      if (this.myEvent != null)
      {
        CustomEventArgs customEventArgs = new CustomEventArgs() { a = a, b = b};
        this.myEvent(sender, customEventArgs);
      }
    }

  }

  //child class of EventArgs
  public class CustomEventArgs : EventArgs
  {
      public int a { get; set; }
      public int b { get; set; }
  }
}
