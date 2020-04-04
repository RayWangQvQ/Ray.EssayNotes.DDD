using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Ray.EssayNotes.DDD.StartupDemo.Test;

namespace Ray.EssayNotes.DDD.StartupDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            //�������ڲ�����������builder��˳��
            //Test01.CreateHostBuilder(args).Build().Run();
            //Test02.CreateHostBuilder(args).Build().Run();

            //Startup�಻�Ǳ���ģ�����ֱ����ί�д���
            Test03.CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// ϵͳ���ɵ�Ĭ�ϵĴ�������������
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        /// <summary>
        /// �򻯺���ʵ��3��
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder1(string[] args)
        {
            //1.����������
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args);
            //2.���ù�����
            hostBuilder.ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
            //3.���ع�����
            return hostBuilder;
        }
    }
}
