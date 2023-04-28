using Singleton.DesignPatterns.Concrete;

Parallel.For(0, 50, (i) =>
{
    var redisConnection = RedisManager.Connection;
});

Console.ReadLine();