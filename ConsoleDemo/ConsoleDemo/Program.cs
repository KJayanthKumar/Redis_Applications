using StackExchange.Redis;
using System;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");
            IDatabase db = redis.GetDatabase();
            //set value in redis server  
            db.StringSet("redisKey", "redisvalue");
            db.StringSet("Sachin", "10");
            //get value from redis server  
            var value = db.StringGet("redisKey");
            Console.WriteLine("Value cached in redis server is: " + value);
            var val = db.StringGet("k1");
            Console.WriteLine("Value of k1 cached in redis server is: " + val);
            var Sval = db.StringGet("Sachin");
            Console.WriteLine("Value of Sachin cached in redis server is: " + Sval);
            Console.ReadLine();
        }
    }
}
