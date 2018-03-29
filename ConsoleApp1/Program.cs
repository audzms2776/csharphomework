using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;

namespace ConsoleApp1
{
    class Program 
    {
        private static void Main(string[] args)
        {
            var sourceObservable = Observable.Range(1, 5);
            
            var subscriber = sourceObservable.Subscribe(
                x => Console.WriteLine("OnNext: {0}", x),
                ex => Console.WriteLine("OnError: {0}", ex.Message),
                () => Console.WriteLine("OnCompleted"));

            subscriber.Dispose();

            var studentFactory = new StudentFactory();



        }
    }
}
