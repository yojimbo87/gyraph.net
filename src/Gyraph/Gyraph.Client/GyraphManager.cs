using ServiceStack.Redis;

namespace Gyraph.Client
{
    public static class GyraphManager
    {
        private static PooledRedisClientManager _redis;

        public static void Connection(string host, int port, string password, int database)
        {
            _redis = new PooledRedisClientManager(database, string.Format("{0}@{1}:{2}", password, host, port));
        }

        internal static RedisClient GetClient()
        {
            return (RedisClient)_redis.GetClient();
        }

        internal static void DisposeClient(RedisClient client)
        {
            _redis.DisposeClient(client);
        }
    }
}
