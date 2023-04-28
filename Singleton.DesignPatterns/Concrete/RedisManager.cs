using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.DesignPatterns.Concrete
{
    public class RedisManager
    {
        /// <summary>
        /// connection lock object 
        /// </summary>
        private static object _lockConnectionObject = new object();

        /// <summary>
        /// this property live forever.
        /// </summary>
        private static RedisConnection _connection;

        /// <summary>
        /// we prevent create instance from other place with private constructor.
        /// </summary>
        private RedisManager(){}

        /// <summary>
        /// we can handle connection object with getter scope and we should lock this object because parallel programming can break your code.
        /// </summary>
        public static RedisConnection Connection
        {
            get
            {
                lock (_lockConnectionObject)
                {
                    if (_connection == null)
                    {
                        Console.WriteLine("redis connection created !");
                        _connection = new RedisConnection();
                    }
                }

                return _connection;
            }
        }

    }

    //dummy redis connection object.
    public class RedisConnection
    {

    }
}
