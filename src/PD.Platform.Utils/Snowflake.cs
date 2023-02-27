using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.Platform.Utils
{
    public class Snowflake
    {
        /// <summary>
        /// 机器ID
        /// </summary>
        private static long workerId;

        private static long twepoch = 687888001020L;

        /// <summary>
        /// 同一微毫的序列号
        /// </summary>
        private static long sequence = 0L;

        /// <summary>
        /// 机器码字节数。4个字节用来保存机器码(定义为Long类型会出现，最大偏移64位，所以左移64位没有意义)
        /// </summary>
        private static int workerIdBits = 4;

        //最大机器ID  
        private static long maxWorkerId = -1 ^ (-1L << workerIdBits);

        /// <summary>
        /// 计数器字节数，10个字节用来保存计数码
        /// </summary>
        private static int sequenceBits = 10;

        /// <summary>
        /// 机器码数据左移位数，就是后面计数器占用的位数
        /// </summary>
        private static int workerIdShift = sequenceBits;

        /// <summary>
        /// 时间戳左移动位数就是机器码和计数器总字节数
        /// </summary>
        private static int timestampLeftShift = sequenceBits + workerIdBits;

        /// <summary>
        /// 一微秒内可以产生计数，如果达到该值则等到下一微妙在进行生成
        /// </summary>
        private static long sequenceMask = -1 ^ (-1L << sequenceBits);

        ///最后一个时间戳 
        private static long lastTimestamp = -1L;

        /// <summary>
        /// 线程锁
        /// </summary>
        private static object lockObject = new object();

        /// <summary>
        /// 获取下一个值
        /// </summary>
        /// <param name="workerId">机器序列号</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static long Next(long workerId = 1L)
        {
            lock (lockObject)
            {
                if (workerId > maxWorkerId || workerId < 0)
                {
                    throw new Exception($"worker Id can't be greater than {workerId} or less than 0 ");
                }

                Snowflake.workerId = workerId;
                long num = GetTimestamp();
                if (lastTimestamp == num)
                {
                    sequence = (sequence + 1) & sequenceMask;
                    if (sequence == 0L)
                    {
                        num = GetNextMillis(lastTimestamp);
                    }
                }
                else
                {
                    sequence = 0L;
                }

                if (num < lastTimestamp)
                {
                    throw new Exception($"Clock moved backwards.  Refusing to generate id for {lastTimestamp - num} milliseconds");
                }

                lastTimestamp = num;
                return (num - twepoch << timestampLeftShift) | (Snowflake.workerId << workerIdShift) | sequence;
            }
        }

        /// <summary>
        /// 获取下一微秒时间戳
        /// </summary>
        /// <param name="lastTimestamp"></param>
        /// <returns></returns>
        private static long GetNextMillis(long lastTimestamp)
        {
            long timestamp;
            for (timestamp = GetTimestamp(); timestamp <= lastTimestamp; timestamp = GetTimestamp())
            {
            }

            return timestamp;
        }
        /// <summary>
        /// 生成当前时间戳
        /// </summary>
        /// <returns></returns>
        private static long GetTimestamp()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }
    }
}
