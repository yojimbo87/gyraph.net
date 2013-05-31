using System;
using ServiceStack.Redis;

namespace Gyraph.Client
{
    public class Gyraph : IDisposable
    {
        private RedisClient _redisClient;

        public Gyraph()
        {
            _redisClient = GyraphManager.GetClient();
        }

        public void Dispose()
        {
            GyraphManager.DisposeClient(_redisClient);
            _redisClient = null;
        }
    }
}
